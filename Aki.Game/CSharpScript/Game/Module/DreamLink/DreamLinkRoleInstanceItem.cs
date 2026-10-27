using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA5 RID: 23205
	public class DreamLinkRoleInstanceItem : UiPanelBase
	{
		// Token: 0x0603AC60 RID: 240736 RVA: 0x00DFF99C File Offset: 0x00DFDB9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AC61 RID: 240737 RVA: 0x00DFFB4C File Offset: 0x00DFDD4C
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(delegate(EToggleState state)
			{
				if (state == EToggleState.ETT_Checked)
				{
					DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
					if (currentActivityData != null)
					{
						currentActivityData.SaveDungeonRedDotStateByInstId(this.Data.InstId);
						base.GetItem(4).SetUIActive(false);
					}
				}
			});
		}

		// Token: 0x0603AC62 RID: 240738 RVA: 0x00DFFB6B File Offset: 0x00DFDD6B
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSelectRoleDreamDungeon, this.Data.InstId);
			}
			this.RefreshHandler(this.Index);
		}

		// Token: 0x0603AC63 RID: 240739 RVA: 0x00DFFBA0 File Offset: 0x00DFDDA0
		[NullableContext(1)]
		public void Refresh(RogueRoleInstData roleInstData, bool isSelect)
		{
			this.Data = roleInstData;
			DreamLinkData activityData = DreamLinkController.Instance.GetCurrentActivityData();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
			extendToggle.CanExecuteChange.Bind(delegate()
			{
				RogueRoleInstData data = this.Data;
				if (data == null || !data.IsUnlock)
				{
					RogueWhiteCatInst? config = ConfigRogueWhiteCatInstById.GetConfig(activityData.GetRoleInstDataIndex(this.Data.InstId) + 1, true);
					if (config != null)
					{
						ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(config.Value.ConditionGroupId);
						if (!StringUtils.IsBlank(conditionGroupConfig.Value.HintText))
						{
							ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupConfig.Value.HintText, Array.Empty<object>());
						}
					}
					return false;
				}
				return true;
			});
			if (isSelect)
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSelectRoleDreamDungeon, this.Data.InstId);
			}
			DreamLinkData activityData2 = activityData;
			IDreamLinkDungeonToggleItemParams dreamLinkDungeonToggleItemParams = (activityData2 != null) ? activityData2.GetDungeonToggleItemParams() : null;
			DreamLinkRoleDungeon? dreamLinkRoleDungeonConfig = DreamLinkConfig.Instance.GetDreamLinkRoleDungeonConfig(roleInstData.InstId);
			base.SetTextureByPath(RoleConfig.Instance.GetRoleConfig(dreamLinkRoleDungeonConfig.Value.RoleId).Value.RoleHeadIconCircle, base.GetTexture(2), null, null);
			this.SetSpriteByPath(dreamLinkRoleDungeonConfig.Value.IndexTexturePath, base.GetSprite(7), false, null, null);
			if (dreamLinkDungeonToggleItemParams != null)
			{
				base.SetTextureByPath(dreamLinkDungeonToggleItemParams.TextureBgPath, base.GetTexture(8), null, null);
				base.SetTextureByPath(dreamLinkDungeonToggleItemParams.TextureLightPath, base.GetTexture(9), null, null);
				FColor fcolor = FColor.FromHex(dreamLinkDungeonToggleItemParams.EffectColor);
				FLinearColor value = new FLinearColor(ref fcolor);
				base.GetUiNiagara(6).SetNiagaraVarLinearColor("Color", value);
			}
			UUITexture texture = base.GetTexture(2);
			UUISprite sprite = base.GetSprite(1);
			if (!roleInstData.IsUnlock)
			{
				texture.SetIsGray(true);
				texture.SetColor(FColor.FromHex("8F7FD999"));
				texture.SetUIActive(false);
				sprite.SetUIActive(true);
			}
			else
			{
				texture.SetIsGray(false);
				texture.SetColor(FColor.FromHex("#ffffff"));
				texture.SetUIActive(true);
				sprite.SetUIActive(false);
			}
			if (activityData.GetInstStage() == EDreamLinkStage.First)
			{
				UUIItem texture2 = base.GetTexture(2);
				bool isFinish = roleInstData.IsFinish;
				FColor? fcolor2 = new FColor?(FColor.FromHex("738ec6ff"));
				texture2.SetChangeColor(isFinish, fcolor2);
			}
			else
			{
				UUIItem texture3 = base.GetTexture(2);
				bool isFinish2 = roleInstData.IsFinish;
				FColor? fcolor2 = new FColor?(FColor.FromHex("9A7F8EFF"));
				texture3.SetChangeColor(isFinish2, fcolor2);
			}
			base.GetItem(3).SetUIActive(!roleInstData.IsUnlock);
			base.GetItem(5).SetUIActive(roleInstData.IsFinish);
			base.GetItem(4).SetUIActive(activityData.CheckDungeonRedDotStateByInstId(roleInstData.InstId));
		}

		// Token: 0x0603AC64 RID: 240740 RVA: 0x00DFFE3A File Offset: 0x00DFE03A
		public void SetToggleState(bool isSelect)
		{
			base.GetExtendToggle(0).SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401EABE RID: 125630
		[Nullable(2)]
		private RogueRoleInstData Data;

		// Token: 0x0401EABF RID: 125631
		[Nullable(1)]
		public Action<int> RefreshHandler = delegate(int index)
		{
		};

		// Token: 0x0401EAC0 RID: 125632
		public int Index;

		// Token: 0x0200BCD3 RID: 48339
		private class EChildComponentDefine
		{
			// Token: 0x04038F46 RID: 233286
			public const int ExtendToggleSelf = 0;

			// Token: 0x04038F47 RID: 233287
			public const int SpriteEmpty = 1;

			// Token: 0x04038F48 RID: 233288
			public const int TextureRoleIcon = 2;

			// Token: 0x04038F49 RID: 233289
			public const int PanelLock = 3;

			// Token: 0x04038F4A RID: 233290
			public const int RedDotItem = 4;

			// Token: 0x04038F4B RID: 233291
			public const int PanelDone = 5;

			// Token: 0x04038F4C RID: 233292
			public const int EffectItem = 6;

			// Token: 0x04038F4D RID: 233293
			public const int SpriteNum = 7;

			// Token: 0x04038F4E RID: 233294
			public const int TextureBg = 8;

			// Token: 0x04038F4F RID: 233295
			public const int TextureLight = 9;
		}
	}
}
