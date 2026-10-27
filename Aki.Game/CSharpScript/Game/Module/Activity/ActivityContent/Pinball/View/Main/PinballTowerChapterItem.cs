using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x0200633A RID: 25402
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballTowerChapterItem : UiPanelBase, IPinballChapterItem
	{
		// Token: 0x0603FEC4 RID: 261828 RVA: 0x00F7707C File Offset: 0x00F7527C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnChapterClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FEC5 RID: 261829 RVA: 0x00F771E8 File Offset: 0x00F753E8
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			UUIEffectOutline extraEffectOutline = base.GetText(6).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			this.ExtraEffectOutline = extraEffectOutline;
			base.GetButton(0).OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
		}

		// Token: 0x0603FEC6 RID: 261830 RVA: 0x00F7724B File Offset: 0x00F7544B
		protected override void OnBeforeDestroy()
		{
			base.GetButton(0).OnPointEnterCallBack.Unbind();
		}

		// Token: 0x0603FEC7 RID: 261831 RVA: 0x00F77260 File Offset: 0x00F75460
		public UUIItem GetChapterButtonUiItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return null;
			}
			AUIBaseActor auibaseActor = button.GetOwner() as AUIBaseActor;
			if (auibaseActor == null)
			{
				return null;
			}
			return auibaseActor.GetUIItem();
		}

		// Token: 0x0603FEC8 RID: 261832 RVA: 0x00F77290 File Offset: 0x00F75490
		private EPinballChapterLevelLockStatus GetChapterLockStatus(int chapterId)
		{
			return PinballModel.Instance.ActivityData.GetChapterLockStatus(chapterId);
		}

		// Token: 0x0603FEC9 RID: 261833 RVA: 0x00F772A2 File Offset: 0x00F754A2
		[NullableContext(1)]
		void IPinballChapterItem.Refresh(PinballChapterData data)
		{
			this.Refresh(data, false);
		}

		// Token: 0x0603FECA RID: 261834 RVA: 0x00F772AC File Offset: 0x00F754AC
		[NullableContext(1)]
		public void Refresh(PinballChapterData data, bool defaultGray = false)
		{
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(data.ChapterId);
			bool flag = this.GetChapterLockStatus(data.ChapterId) != EPinballChapterLevelLockStatus.Activated;
			base.GetItem(4).SetUIActive(defaultGray || flag);
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetIsGray(defaultGray || flag);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(defaultGray || flag);
			}
			List<PinballLevelRecordData> list = new List<PinballLevelRecordData>();
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			int num = 0;
			foreach (int levelId in data.LevelIds)
			{
				PinballLevelRecordData levelData = activityData.GetLevelData(levelId);
				list.Add(levelData);
				if (levelData.PassStatus != EPinballLevelPassStatus.Unfinished)
				{
					num++;
				}
			}
			this.SetRedDotVisible(activityData.HasNewChapterRedDot(data.ChapterId));
			base.GetArtText(5).SetText(num.ToString());
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text, pinballChapterConfigById.Value.Name, Array.Empty<object>());
			text.outlineColor = FColor.FromHex(pinballChapterConfigById.Value.OutlineColor);
			UUIEffectOutline extraEffectOutline = this.ExtraEffectOutline;
			if (extraEffectOutline != null)
			{
				extraEffectOutline.SetOutlineColor(FColor.FromHex(pinballChapterConfigById.Value.ExOutlineColor));
			}
			this.ChapterData = data;
			this.LevelDataList = list;
		}

		// Token: 0x0603FECB RID: 261835 RVA: 0x00F77410 File Offset: 0x00F75610
		public void SetGray(bool isSetGray)
		{
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetIsGray(isSetGray);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(isSetGray);
			}
		}

		// Token: 0x0603FECC RID: 261836 RVA: 0x00F77442 File Offset: 0x00F75642
		public void SetRedDotVisible(bool isVisible)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isVisible);
		}

		// Token: 0x0603FECD RID: 261837 RVA: 0x00F77458 File Offset: 0x00F75658
		public UniTask PlayUnlockTweenAsync()
		{
			PinballTowerChapterItem.<PlayUnlockTweenAsync>d__16 <PlayUnlockTweenAsync>d__;
			<PlayUnlockTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockTweenAsync>d__.<>4__this = this;
			<PlayUnlockTweenAsync>d__.<>1__state = -1;
			<PlayUnlockTweenAsync>d__.<>t__builder.Start<PinballTowerChapterItem.<PlayUnlockTweenAsync>d__16>(ref <PlayUnlockTweenAsync>d__);
			return <PlayUnlockTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FECE RID: 261838 RVA: 0x00F7749C File Offset: 0x00F7569C
		private void OnBtnChapterClick()
		{
			if (this.ChapterData == null || this.LevelDataList.Count == 0)
			{
				return;
			}
			EPinballChapterLevelLockStatus chapterLockStatus = this.GetChapterLockStatus(this.ChapterData.ChapterId);
			if (chapterLockStatus == EPinballChapterLevelLockStatus.Lock)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Pinball_Main_ChapterTips01", null);
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)this.ChapterData.UnlockTime, localTextNew);
				ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
				return;
			}
			if (chapterLockStatus == EPinballChapterLevelLockStatus.PreLock)
			{
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(PinballConfig.Instance.GetPinballChapterConfigById(this.ChapterData.PreChapterId).Value.Name, null);
				ScrollingTipsController.Instance.ShowTipsByTextId("Pinball_Level_UnlockInfo", new object[]
				{
					localTextNew2
				});
				return;
			}
			this.SetRedDotVisible(false);
			Action<PinballChapterData, List<PinballLevelRecordData>> onClickTowerBack = this.OnClickTowerBack;
			if (onClickTowerBack == null)
			{
				return;
			}
			onClickTowerBack(this.ChapterData, this.LevelDataList);
		}

		// Token: 0x0603FECF RID: 261839 RVA: 0x00F77574 File Offset: 0x00F75774
		private void OnPointerEnter()
		{
			if (this.ChapterData == null)
			{
				return;
			}
			int chapterId = this.ChapterData.ChapterId;
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(chapterId);
			if (pinballChapterConfigById == null || StringUtils.IsBlank(pinballChapterConfigById.Value.PlanetBg) || StringUtils.IsBlank(pinballChapterConfigById.Value.PlanetMaskBg))
			{
				return;
			}
			Action<string, string, int> onPointerEnterChapterBack = this.OnPointerEnterChapterBack;
			if (onPointerEnterChapterBack == null)
			{
				return;
			}
			onPointerEnterChapterBack(pinballChapterConfigById.Value.PlanetBg, pinballChapterConfigById.Value.PlanetMaskBg, chapterId);
		}

		// Token: 0x0402157F RID: 136575
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballChapterData, List<PinballLevelRecordData>> OnClickTowerBack;

		// Token: 0x04021580 RID: 136576
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, string, int> OnPointerEnterChapterBack;

		// Token: 0x04021581 RID: 136577
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04021582 RID: 136578
		private UUIEffectOutline ExtraEffectOutline;

		// Token: 0x04021583 RID: 136579
		private PinballChapterData ChapterData;

		// Token: 0x04021584 RID: 136580
		[Nullable(1)]
		private List<PinballLevelRecordData> LevelDataList = new List<PinballLevelRecordData>();

		// Token: 0x0200C54A RID: 50506
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B8B1 RID: 243889
			BtnChapter,
			// Token: 0x0403B8B2 RID: 243890
			NormalItem,
			// Token: 0x0403B8B3 RID: 243891
			TexTowerBg,
			// Token: 0x0403B8B4 RID: 243892
			TexDecoration,
			// Token: 0x0403B8B5 RID: 243893
			LockItem,
			// Token: 0x0403B8B6 RID: 243894
			ArtTxtLevelNum,
			// Token: 0x0403B8B7 RID: 243895
			TxtChapterName,
			// Token: 0x0403B8B8 RID: 243896
			RedDotItem
		}
	}
}
