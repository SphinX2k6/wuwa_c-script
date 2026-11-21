using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C1 RID: 20673
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBattleInfoPanel : BattleViewDynamicUiBase
	{
		// Token: 0x06033BCB RID: 211915 RVA: 0x00E7AFCC File Offset: 0x00E791CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033BCC RID: 211916 RVA: 0x00E7B0DC File Offset: 0x00E792DC
		protected override void OnStart()
		{
			this.LifeLayout = new GenericLayout<RoverlikeReviveLifeItem, bool>(base.GetHorizontalLayout(2), new Func<RoverlikeReviveLifeItem>(this.CreateLifeItem), (AUIBaseActor)base.GetItem(3).GetOwner(), false, true);
			EventSystem.Instance.Add<int, int>(EEventName.RoverlikeReviveTimesUpdate, new Action<int, int>(this.OnReviveTimesUpdate));
			EventSystem.Instance.Add<int, GameplayCue, bool, int>(EEventName.OnRoverlikeQSkillBuff, new Action<int, GameplayCue, bool, int>(this.OnQSkillBuffChanged));
			this.RefreshLifeUI();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				this.RoleShowSequencePlayer = new LevelSequencePlayer(item);
			}
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshQSkillBuffUI();
		}

		// Token: 0x06033BCD RID: 211917 RVA: 0x00E7B180 File Offset: 0x00E79380
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.RoverlikeReviveTimesUpdate, new Action<int, int>(this.OnReviveTimesUpdate));
			EventSystem.Instance.Remove<int, GameplayCue, bool, int>(EEventName.OnRoverlikeQSkillBuff, new Action<int, GameplayCue, bool, int>(this.OnQSkillBuffChanged));
			this.LifeLayout = null;
			this.IsLifeBgNiaVisible = null;
			this.ActiveQSkillBuffSet.Clear();
			LevelSequencePlayer roleShowSequencePlayer = this.RoleShowSequencePlayer;
			if (roleShowSequencePlayer != null)
			{
				roleShowSequencePlayer.Clear();
			}
			this.RoleShowSequencePlayer = null;
			this.StopRoleShowSequencePromise = null;
		}

		// Token: 0x06033BCE RID: 211918 RVA: 0x00E7B204 File Offset: 0x00E79404
		private void RefreshLifeUI()
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			this.BuildLifeUI(instance.GetReviveTimes(), instance.GetReviveTimesMax());
		}

		// Token: 0x06033BCF RID: 211919 RVA: 0x00E7B229 File Offset: 0x00E79429
		private void OnReviveTimesUpdate(int reviveTimes, int reviveTimesMax)
		{
			this.BuildLifeUI(reviveTimes, reviveTimesMax);
		}

		// Token: 0x06033BD0 RID: 211920 RVA: 0x00E7B234 File Offset: 0x00E79434
		private void RefreshQSkillBuffUI()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			EntityHandle entityHandle = (curRoleData != null) ? curRoleData.EntityHandle : null;
			int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
			if (num == null)
			{
				return;
			}
			CharacterGameplayCueComponent characterGameplayCueComponent;
			if (entityHandle == null)
			{
				characterGameplayCueComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				characterGameplayCueComponent = ((entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null);
			}
			CharacterGameplayCueComponent characterGameplayCueComponent2 = characterGameplayCueComponent;
			if (characterGameplayCueComponent2 == null)
			{
				return;
			}
			foreach (GameplayCueBase gameplayCueBase in characterGameplayCueComponent2.GetAllCurrentCueRef())
			{
				if (gameplayCueBase.CueConfig.CueType == 39)
				{
					this.OnQSkillBuffChanged(num.Value, gameplayCueBase.CueConfig, true, gameplayCueBase.BuffHandleId);
				}
			}
		}

		// Token: 0x06033BD1 RID: 211921 RVA: 0x00E7B304 File Offset: 0x00E79504
		private unsafe void OnQSkillBuffChanged(int entityId, GameplayCue cue, bool isAdd, int handleId)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			int? num;
			if (curRoleData == null)
			{
				num = null;
			}
			else
			{
				EntityHandle entityHandle = curRoleData.EntityHandle;
				num = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			}
			int? num2 = num;
			if (!(num2.GetValueOrDefault() == entityId & num2 != null))
			{
				return;
			}
			if (!isAdd)
			{
				this.ActiveQSkillBuffSet.Remove(handleId);
				if (this.ActiveQSkillBuffSet.Count == 0)
				{
					this.HideQSkillRolePanel();
				}
				return;
			}
			this.ActiveQSkillBuffSet.Add(handleId);
			if (cue.ParametersLength != 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LXH;
				string message = "[RoverlikeBattleInfoPanel] buff特效表参数配置不对，Parameters长度应为2";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cueId", cue.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", cue.ParametersLength);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (!string.IsNullOrEmpty(cue.Parameters(0)))
			{
				UUITexture texture = base.GetTexture(4);
				if (texture != null)
				{
					base.SetTextureByPath(cue.Parameters(0), texture, null, null);
				}
			}
			if (!string.IsNullOrEmpty(cue.Parameters(1)))
			{
				UUIText text = base.GetText(5);
				if (text != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text, cue.Parameters(1), Array.Empty<object>());
				}
			}
			this.ShowQSkillRolePanel();
		}

		// Token: 0x06033BD2 RID: 211922 RVA: 0x00E7B478 File Offset: 0x00E79678
		private void ShowQSkillRolePanel()
		{
			UUIItem item = base.GetItem(1);
			if (this.RoleShowSequencePlayer == null)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.LXH, "[RoverlikeBattleInfoPanel.ShowQSkillRolePanel] RoleShowSequencePlayer 未初始化，无法播放 Start 动效", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (item != null)
				{
					item.SetUIActive(true);
				}
				return;
			}
			if (this.StopRoleShowSequencePromise != null && !this.StopRoleShowSequencePromise.IsFulfilled)
			{
				this.RoleShowSequencePlayer.StopSequenceByKey("Close", false, false);
				this.StopRoleShowSequencePromise = null;
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.RoleShowSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06033BD3 RID: 211923 RVA: 0x00E7B510 File Offset: 0x00E79710
		private void HideQSkillRolePanel()
		{
			UUIItem roleShowPanel = base.GetItem(1);
			if (this.RoleShowSequencePlayer != null)
			{
				this.RoleShowSequencePlayer.StopSequenceByKey("Start", false, false);
				if (this.StopRoleShowSequencePromise != null && !this.StopRoleShowSequencePromise.IsFulfilled)
				{
					this.StopRoleShowSequencePromise.SetResult(false);
				}
				CustomPromise<bool> promise = new CustomPromise<bool>();
				this.StopRoleShowSequencePromise = promise;
				this.RoleShowSequencePlayer.PlaySequenceAsync("Close", promise, false, false, null, false).ContinueWith(delegate()
				{
					if (this.IsDestroyOrDestroying)
					{
						return;
					}
					if (this.StopRoleShowSequencePromise != promise)
					{
						return;
					}
					if (this.ActiveQSkillBuffSet.Count == 0)
					{
						UUIItem roleShowPanel2 = roleShowPanel;
						if (roleShowPanel2 != null)
						{
							roleShowPanel2.SetUIActive(false);
						}
					}
					this.StopRoleShowSequencePromise = null;
				});
				return;
			}
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.LXH, "[RoverlikeBattleInfoPanel.HideQSkillRolePanel] RoleShowSequencePlayer 未初始化，无法播放 Close 动效", default(ReadOnlySpan<ValueTuple<string, object>>));
			UUIItem roleShowPanel3 = roleShowPanel;
			if (roleShowPanel3 == null)
			{
				return;
			}
			roleShowPanel3.SetUIActive(false);
		}

		// Token: 0x06033BD4 RID: 211924 RVA: 0x00E7B5EB File Offset: 0x00E797EB
		private void BuildLifeUI(int reviveTimes, int reviveTimesMax)
		{
			this.UpdateLifeBgNiagaraVisible(reviveTimesMax);
			this.UpdateLifeLayout(reviveTimes, reviveTimesMax);
		}

		// Token: 0x06033BD5 RID: 211925 RVA: 0x00E7B5FC File Offset: 0x00E797FC
		private void UpdateLifeBgNiagaraVisible(int reviveTimesMax)
		{
			bool flag = reviveTimesMax > 0;
			bool? isLifeBgNiaVisible = this.IsLifeBgNiaVisible;
			bool flag2 = flag;
			if (isLifeBgNiaVisible.GetValueOrDefault() == flag2 & isLifeBgNiaVisible != null)
			{
				return;
			}
			this.IsLifeBgNiaVisible = new bool?(flag);
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x06033BD6 RID: 211926 RVA: 0x00E7B64C File Offset: 0x00E7984C
		private void UpdateLifeLayout(int reviveTimes, int reviveTimesMax)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < reviveTimesMax; i++)
			{
				list.Add(i < reviveTimes);
			}
			GenericLayout<RoverlikeReviveLifeItem, bool> lifeLayout = this.LifeLayout;
			if (lifeLayout == null)
			{
				return;
			}
			lifeLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06033BD7 RID: 211927 RVA: 0x00E7B688 File Offset: 0x00E79888
		private RoverlikeReviveLifeItem CreateLifeItem()
		{
			return new RoverlikeReviveLifeItem();
		}

		// Token: 0x0401B6CC RID: 112332
		private const string ROLE_SHOW_SEQ_START = "Start";

		// Token: 0x0401B6CD RID: 112333
		private const string ROLE_SHOW_SEQ_CLOSE = "Close";

		// Token: 0x0401B6CE RID: 112334
		private readonly HashSet<int> ActiveQSkillBuffSet = new HashSet<int>();

		// Token: 0x0401B6CF RID: 112335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeReviveLifeItem, bool> LifeLayout;

		// Token: 0x0401B6D0 RID: 112336
		[Nullable(2)]
		private LevelSequencePlayer RoleShowSequencePlayer;

		// Token: 0x0401B6D1 RID: 112337
		[Nullable(2)]
		private CustomPromise<bool> StopRoleShowSequencePromise;

		// Token: 0x0401B6D2 RID: 112338
		private bool? IsLifeBgNiaVisible;

		// Token: 0x0200AD86 RID: 44422
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359E1 RID: 219617
			public const int LifePanel = 0;

			// Token: 0x040359E2 RID: 219618
			public const int RoleShowPanel = 1;

			// Token: 0x040359E3 RID: 219619
			public const int LifeList = 2;

			// Token: 0x040359E4 RID: 219620
			public const int LifeItem = 3;

			// Token: 0x040359E5 RID: 219621
			public const int RoleTexture = 4;

			// Token: 0x040359E6 RID: 219622
			public const int RoleNameText = 5;

			// Token: 0x040359E7 RID: 219623
			public const int LifeBgNiagara = 6;
		}
	}
}
