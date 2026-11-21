using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057FA RID: 22522
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AdamSmasherStageItem : GridProxyAbstract<IAdamSmasherStageItemData>
	{
		// Token: 0x06037936 RID: 227638 RVA: 0x00F88EF0 File Offset: 0x00F870F0
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

		// Token: 0x06037937 RID: 227639 RVA: 0x00F89036 File Offset: 0x00F87236
		public int GetStageId()
		{
			IAdamSmasherStageItemData stageData = this.StageData;
			if (stageData == null)
			{
				return 0;
			}
			return stageData.StageId;
		}

		// Token: 0x06037938 RID: 227640 RVA: 0x00F8904C File Offset: 0x00F8724C
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

		// Token: 0x06037939 RID: 227641 RVA: 0x00F891C4 File Offset: 0x00F873C4
		public void RefreshDecorationSprite(IAdamSmasherStageItemData data)
		{
			string path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge" + (data.IsHard ? "/SP_TogLevelSelDecoSP.SP_TogLevelSelDecoSP" : "/SP_TogLevelSelDecoNor.SP_TogLevelSelDecoNor");
			this.SetSpriteByPath(path, base.GetSprite(10), false, null, null);
			string path2 = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge" + (data.IsHard ? "/SP_IconTogFinishSP.SP_IconTogFinishSP" : "/SP_IconTogFinishNor.SP_IconTogFinishNor");
			this.SetSpriteByPath(path2, base.GetSprite(11), false, null, null);
		}

		// Token: 0x0603793A RID: 227642 RVA: 0x00F89244 File Offset: 0x00F87444
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

		// Token: 0x0603793B RID: 227643 RVA: 0x00F892B5 File Offset: 0x00F874B5
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

		// Token: 0x0401D50E RID: 120078
		private const string NormalColor = "#666666FF";

		// Token: 0x0401D50F RID: 120079
		private const string HardColor = "#ff606f";

		// Token: 0x0401D510 RID: 120080
		[Nullable(2)]
		public Action<int> OnStageClick;

		// Token: 0x0401D511 RID: 120081
		[Nullable(2)]
		private IAdamSmasherStageItemData StageData;

		// Token: 0x0200B444 RID: 46148
		[NullableContext(0)]
		private enum EStageItemComponent
		{
			// Token: 0x04037C2A RID: 228394
			ToggleBtn,
			// Token: 0x04037C2B RID: 228395
			IndexText,
			// Token: 0x04037C2C RID: 228396
			NameText,
			// Token: 0x04037C2D RID: 228397
			LockPanel,
			// Token: 0x04037C2E RID: 228398
			NormalPanel,
			// Token: 0x04037C2F RID: 228399
			SelectItem,
			// Token: 0x04037C30 RID: 228400
			FinishItem,
			// Token: 0x04037C31 RID: 228401
			RedDot,
			// Token: 0x04037C32 RID: 228402
			BossPanel,
			// Token: 0x04037C33 RID: 228403
			BossLockPanel,
			// Token: 0x04037C34 RID: 228404
			DecorationSprite,
			// Token: 0x04037C35 RID: 228405
			FinishSprite
		}
	}
}
