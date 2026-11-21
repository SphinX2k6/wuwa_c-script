using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A1 RID: 21921
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingRoleTechItem : GridProxyAbstract<IFishingTechNode>
	{
		// Token: 0x060365A2 RID: 222626 RVA: 0x00F2C5E4 File Offset: 0x00F2A7E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060365A3 RID: 222627 RVA: 0x00F2C794 File Offset: 0x00F2A994
		protected override void OnStart()
		{
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x060365A4 RID: 222628 RVA: 0x00F2C7A4 File Offset: 0x00F2A9A4
		[NullableContext(1)]
		public override void Refresh(IFishingTechNode data, bool isSelected, int gridIndex)
		{
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(data.ConfigId);
			if (this.Node != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleTechNode, base.GetItem(8), 0);
			}
			this.Node = data;
			base.GetScrollScrollbar(9).SetValue(0f, true);
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, this.Node.ConfigId);
			RedDotController.Instance.BindRedDot(ERedDotName.FishingRoleTechNode, base.GetItem(8), null, this.Node.ConfigId);
			base.SetTextureByPath(fishingTechById.Icon, base.GetTexture(5), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingTechById.Name, Array.Empty<object>());
			int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(data.ConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "PrefabTextItem_3692737534_Text", new <>z__ReadOnlySingleElementList<object>(techNodeCurrentLevel));
			int effectLength = fishingTechById.EffectLength;
			if (techNodeCurrentLevel >= effectLength)
			{
				base.GetItem(4).SetUIActive(true);
				base.GetItem(2).SetUIActive(false);
				int techEffectId = fishingTechById.Effect(effectLength - 1);
				FishingTechEffect fishingTechEffectById = FishingConfig.Instance.GetFishingTechEffectById(techEffectId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fishingTechEffectById.Desc, fishingTechEffectById.ShowParams());
				return;
			}
			base.GetItem(4).SetUIActive(false);
			bool nodePreNodeUnlock = FishingModel.Instance.GetNodePreNodeUnlock(this.Node.ConfigId);
			base.GetItem(2).SetUIActive(!nodePreNodeUnlock);
			int techEffectId2 = fishingTechById.Effect(techNodeCurrentLevel);
			FishingTechEffect fishingTechEffectById2 = FishingConfig.Instance.GetFishingTechEffectById(techEffectId2);
			if (techNodeCurrentLevel == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fishingTechEffectById2.Desc, fishingTechEffectById2.ShowParams());
				return;
			}
			int techEffectId3 = fishingTechById.Effect(techNodeCurrentLevel - 1);
			FishingTechEffect fishingTechEffectById3 = FishingConfig.Instance.GetFishingTechEffectById(techEffectId3);
			List<string> list = new List<string>();
			int showParamsLength = fishingTechEffectById3.ShowParamsLength;
			for (int i = 0; i < showParamsLength; i++)
			{
				string item = fishingTechEffectById3.ShowParams(i) + "->" + fishingTechEffectById2.ShowParams(i);
				list.Add(item);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fishingTechEffectById2.Desc, list.ToArray());
		}

		// Token: 0x060365A5 RID: 222629 RVA: 0x00F2C9F5 File Offset: 0x00F2ABF5
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleTechNode, base.GetItem(8), this.Node.ConfigId);
		}

		// Token: 0x060365A6 RID: 222630 RVA: 0x00F2CA18 File Offset: 0x00F2AC18
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.Node, base.GetExtendToggle(6));
		}

		// Token: 0x060365A7 RID: 222631 RVA: 0x00F2CA37 File Offset: 0x00F2AC37
		public void SelectToggle()
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack != null)
			{
				onClickToggleBack(this.Node, base.GetExtendToggle(6));
			}
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0401CAE6 RID: 117478
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0401CAE7 RID: 117479
		[Nullable(2)]
		public IFishingTechNode Node;

		// Token: 0x0200B21E RID: 45598
		private class EComponentDefine
		{
			// Token: 0x04037100 RID: 225536
			public const int NameText = 0;

			// Token: 0x04037101 RID: 225537
			public const int DesText = 1;

			// Token: 0x04037102 RID: 225538
			public const int LockItem = 2;

			// Token: 0x04037103 RID: 225539
			public const int EnableItem = 3;

			// Token: 0x04037104 RID: 225540
			public const int MaxItem = 4;

			// Token: 0x04037105 RID: 225541
			public const int IconTexture = 5;

			// Token: 0x04037106 RID: 225542
			public const int Toggle = 6;

			// Token: 0x04037107 RID: 225543
			public const int TechLevelText = 7;

			// Token: 0x04037108 RID: 225544
			public const int RedDotItem = 8;

			// Token: 0x04037109 RID: 225545
			public const int ScrollViewBar = 9;
		}
	}
}
