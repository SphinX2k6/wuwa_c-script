using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068AA RID: 26794
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AdamSmasherStageItem : GridProxyAbstract<IAdamSmasherStageItemData>
	{
		// Token: 0x06042DDE RID: 273886 RVA: 0x010478E0 File Offset: 0x01045AE0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
			};
		}

		// Token: 0x06042DDF RID: 273887 RVA: 0x01047A26 File Offset: 0x01045C26
		public int GetStageId()
		{
			IAdamSmasherStageItemData stageData = this.StageData;
			if (stageData == null)
			{
				return 0;
			}
			return stageData.StageId;
		}

		// Token: 0x06042DE0 RID: 273888 RVA: 0x01047A3C File Offset: 0x01045C3C
		public override void Refresh(IAdamSmasherStageItemData data, bool isSelected, int gridIndex)
		{
			this.StageData = data;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(data.IsHard ? "" : data.IndexText, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
			base.GetText(1).useChangeColor = (data.IsUnlocked && !data.IsHard);
			base.GetText(2).useChangeColor = (data.IsUnlocked && !data.IsHard);
			base.GetText(2).SetColor(data.IsHard ? FColor.FromHex("#ff606f") : FColor.FromHex("#666666FF"));
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!data.IsUnlocked && !data.IsHard);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsUnlocked && !data.IsHard);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(AdamSmasherController.Instance.IsStageCleared(data.StageId));
			}
			UUIItem item4 = base.GetItem(8);
			if (item4 != null)
			{
				item4.SetUIActive(data.IsHard);
			}
			UUIItem item5 = base.GetItem(9);
			if (item5 != null)
			{
				item5.SetUIActive(data.IsHard && !data.IsUnlocked);
			}
			this.RefreshDecorationSprite(data);
		}

		// Token: 0x06042DE1 RID: 273889 RVA: 0x01047BB4 File Offset: 0x01045DB4
		public void RefreshDecorationSprite(IAdamSmasherStageItemData data)
		{
			string path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge" + (data.IsHard ? "/SP_TogLevelSelDecoSP.SP_TogLevelSelDecoSP" : "/SP_TogLevelSelDecoNor.SP_TogLevelSelDecoNor");
			this.SetSpriteByPath(path, base.GetSprite(10), false, null, null);
			string path2 = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge" + (data.IsHard ? "/SP_IconTogFinishSP.SP_IconTogFinishSP" : "/SP_IconTogFinishNor.SP_IconTogFinishNor");
			this.SetSpriteByPath(path2, base.GetSprite(11), false, null, null);
		}

		// Token: 0x06042DE2 RID: 273890 RVA: 0x01047C34 File Offset: 0x01045E34
		public void SetToggleActive(bool selected)
		{
			if (this.StageData == null)
			{
				return;
			}
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			bool useChangeColor = (selected || this.StageData.IsUnlocked) && !this.StageData.IsHard;
			base.GetText(1).useChangeColor = useChangeColor;
			base.GetText(2).useChangeColor = useChangeColor;
		}

		// Token: 0x06042DE3 RID: 273891 RVA: 0x01047CA5 File Offset: 0x01045EA5
		private void OnToggleClick(EToggleState state)
		{
			if (this.StageData == null)
			{
				return;
			}
			AdamSmasherSelectView adamSmasherSelectView = UiManager.Instance.GetViewByName(EUiViewName.AdamSmasherSelectView) as AdamSmasherSelectView;
			if (adamSmasherSelectView == null)
			{
				return;
			}
			adamSmasherSelectView.ChangeStageId(this.StageData.StageId);
		}

		// Token: 0x04022CB2 RID: 142514
		private const string NormalColor = "#666666FF";

		// Token: 0x04022CB3 RID: 142515
		private const string HardColor = "#ff606f";

		// Token: 0x04022CB4 RID: 142516
		[Nullable(2)]
		public Action<int> OnStageClick;

		// Token: 0x04022CB5 RID: 142517
		[Nullable(2)]
		private IAdamSmasherStageItemData StageData;

		// Token: 0x0200CA7C RID: 51836
		[NullableContext(0)]
		private enum EStageItemComponent
		{
			// Token: 0x0403D34F RID: 250703
			ToggleBtn,
			// Token: 0x0403D350 RID: 250704
			IndexText,
			// Token: 0x0403D351 RID: 250705
			NameText,
			// Token: 0x0403D352 RID: 250706
			LockPanel,
			// Token: 0x0403D353 RID: 250707
			NormalPanel,
			// Token: 0x0403D354 RID: 250708
			SelectItem,
			// Token: 0x0403D355 RID: 250709
			FinishItem,
			// Token: 0x0403D356 RID: 250710
			RedDot,
			// Token: 0x0403D357 RID: 250711
			BossPanel,
			// Token: 0x0403D358 RID: 250712
			BossLockPanel,
			// Token: 0x0403D359 RID: 250713
			DecorationSprite,
			// Token: 0x0403D35A RID: 250714
			FinishSprite
		}
	}
}
