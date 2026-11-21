using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059ED RID: 23021
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SolarSchoolQuestNodeItemBase : SyncGridProxyAbstract<int>
	{
		// Token: 0x17006C4B RID: 27723
		// (get) Token: 0x06038B29 RID: 232233 RVA: 0x00FDE7CA File Offset: 0x00FDC9CA
		// (set) Token: 0x06038B2A RID: 232234 RVA: 0x00FDE7D2 File Offset: 0x00FDC9D2
		private protected int QuestId { protected get; private set; }

		// Token: 0x17006C4C RID: 27724
		// (get) Token: 0x06038B2B RID: 232235 RVA: 0x00FDE7DB File Offset: 0x00FDC9DB
		// (set) Token: 0x06038B2C RID: 232236 RVA: 0x00FDE7E3 File Offset: 0x00FDC9E3
		private protected bool PendingUnlock { protected get; private set; }

		// Token: 0x06038B2D RID: 232237 RVA: 0x00FDE7EC File Offset: 0x00FDC9EC
		protected override void OnStart()
		{
			this.Animation = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038B2E RID: 232238 RVA: 0x00FDE7FF File Offset: 0x00FDC9FF
		public override void Refresh(int questId)
		{
			this.RefreshByQuest(questId);
		}

		// Token: 0x06038B2F RID: 232239 RVA: 0x00FDE808 File Offset: 0x00FDCA08
		public override void Clear()
		{
			this.StopAnimation();
			this.UnBindQuestRedDot();
			this.PendingUnlock = false;
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAlpha(1f);
			}
			this.QuestId = 0;
		}

		// Token: 0x06038B30 RID: 232240 RVA: 0x00FDE83A File Offset: 0x00FDCA3A
		[NullableContext(2)]
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06038B31 RID: 232241 RVA: 0x00FDE844 File Offset: 0x00FDCA44
		public void RefreshByQuest(int questId)
		{
			this.UnBindQuestRedDot();
			this.QuestId = questId;
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(questId);
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(questId);
			if (quest == null || questData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 任务树节点找不到配置或运行态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", questId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.OnRefreshNode(quest.Value, questData);
			this.BindQuestRedDot();
		}

		// Token: 0x06038B32 RID: 232242 RVA: 0x00FDE8CC File Offset: 0x00FDCACC
		public void PreparePresentation(SolarSchoolQuestPresentationState state)
		{
			this.PendingUnlock = (state.IsUnlocked && state.InShowTime && !state.IsExpired && !state.FirstUnlockCompleted);
			this.SnapNodeSequence("Mission_In");
			this.RefreshByQuest(state.QuestId);
			this.RootItem.SetAlpha((state.IsExpired || state.FirstShowCompleted) ? 1f : 0f);
		}

		// Token: 0x06038B33 RID: 232243 RVA: 0x00FDE948 File Offset: 0x00FDCB48
		public UniTask PlayAppearAsync()
		{
			SolarSchoolQuestNodeItemBase.<PlayAppearAsync>d__16 <PlayAppearAsync>d__;
			<PlayAppearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAppearAsync>d__.<>4__this = this;
			<PlayAppearAsync>d__.<>1__state = -1;
			<PlayAppearAsync>d__.<>t__builder.Start<SolarSchoolQuestNodeItemBase.<PlayAppearAsync>d__16>(ref <PlayAppearAsync>d__);
			return <PlayAppearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B34 RID: 232244 RVA: 0x00FDE98B File Offset: 0x00FDCB8B
		public virtual UniTask PlayUnlockAsync()
		{
			this.PendingUnlock = false;
			this.RefreshByQuest(this.QuestId);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038B35 RID: 232245 RVA: 0x00FDE9A8 File Offset: 0x00FDCBA8
		protected UniTask PlayNodeSequenceAsync(string sequenceName)
		{
			this.StopAnimation();
			UniTask result = this.Animation.PlaySequenceAsync(sequenceName, new CustomPromise<bool>(), false, false, null, false);
			this.Animation.SequenceJumpToStartWhenPlaying(sequenceName);
			return result;
		}

		// Token: 0x06038B36 RID: 232246 RVA: 0x00FDE9E4 File Offset: 0x00FDCBE4
		protected void SnapNodeSequence(string sequenceName)
		{
			this.StopAnimation();
			this.Animation.PlayLevelSequenceByName(sequenceName, false, null, true);
			this.Animation.StopSequenceByKey(sequenceName, false, true);
		}

		// Token: 0x06038B37 RID: 232247 RVA: 0x00FDEA1C File Offset: 0x00FDCC1C
		protected void CompleteUnlock()
		{
			this.PendingUnlock = false;
			this.RefreshByQuest(this.QuestId);
		}

		// Token: 0x06038B38 RID: 232248 RVA: 0x00FDEA31 File Offset: 0x00FDCC31
		public void StopAnimation()
		{
			LevelSequencePlayer animation = this.Animation;
			if (animation == null)
			{
				return;
			}
			animation.StopPlayingSequence(false, false);
		}

		// Token: 0x06038B39 RID: 232249 RVA: 0x00FDEA45 File Offset: 0x00FDCC45
		protected override void OnBeforeDestroy()
		{
			this.StopAnimation();
			LevelSequencePlayer animation = this.Animation;
			if (animation != null)
			{
				animation.Clear();
			}
			this.Animation = null;
			this.UnBindQuestRedDot();
		}

		// Token: 0x06038B3A RID: 232250
		protected abstract void OnRefreshNode(SolarSchoolQuest quest, SolarSchoolSingleQuestData questData);

		// Token: 0x06038B3B RID: 232251 RVA: 0x00FDEA6B File Offset: 0x00FDCC6B
		[NullableContext(2)]
		protected virtual UUIItem GetQuestRedDotItem()
		{
			return null;
		}

		// Token: 0x06038B3C RID: 232252 RVA: 0x00FDEA70 File Offset: 0x00FDCC70
		private void BindQuestRedDot()
		{
			UUIItem questRedDotItem = this.GetQuestRedDotItem();
			if (questRedDotItem == null || this.QuestId == 0)
			{
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotSolarSchoolQuestItem, questRedDotItem, null, this.QuestId);
		}

		// Token: 0x06038B3D RID: 232253 RVA: 0x00FDEAA8 File Offset: 0x00FDCCA8
		private void UnBindQuestRedDot()
		{
			UUIItem questRedDotItem = this.GetQuestRedDotItem();
			if (questRedDotItem == null || this.QuestId == 0)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotSolarSchoolQuestItem, questRedDotItem, this.QuestId);
		}

		// Token: 0x06038B3E RID: 232254 RVA: 0x00FDEADE File Offset: 0x00FDCCDE
		protected void NotifyClick()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.QuestId);
		}

		// Token: 0x06038B3F RID: 232255 RVA: 0x00FDEAF8 File Offset: 0x00FDCCF8
		protected string GetDateStr(int endDayIndex, bool isExpired)
		{
			ValueTuple<int, int> monthDay = SolarSchoolUtils.GetMonthDay(endDayIndex);
			int item = monthDay.Item1;
			int item2 = monthDay.Item2;
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(isExpired ? "SolarSchool_QuestTree_Complete" : "SolarSchool_QuestTree_Deadline", null), new string[]
			{
				item.ToString("D2"),
				item2.ToString("D2")
			});
		}

		// Token: 0x0401DDAA RID: 122282
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0401DDAB RID: 122283
		[Nullable(2)]
		private LevelSequencePlayer Animation;
	}
}
