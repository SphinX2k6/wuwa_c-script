using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200566E RID: 22126
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeCircleItem : AutoAttachItem<IBaseItemData>
	{
		// Token: 0x060384B7 RID: 230583 RVA: 0x00D59D98 File Offset: 0x00D57F98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.SelectedItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060384B8 RID: 230584 RVA: 0x00D59EC2 File Offset: 0x00D580C2
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
		}

		// Token: 0x060384B9 RID: 230585 RVA: 0x00D59EE8 File Offset: 0x00D580E8
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			float floatValue = this.ItemCurve.GetFloatValue(currentMovePercentage);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIItemScale(new FVector(floatValue, floatValue, 1f));
		}

		// Token: 0x060384BA RID: 230586 RVA: 0x00D59F34 File Offset: 0x00D58134
		protected override void OnRefreshItem(IBaseItemData data)
		{
			this.CurrentData = data;
			if (data == null)
			{
				return;
			}
			SynthesisFormula? synthesisFormula;
			int? num = (data.MainType == EComposeListType.Exchange) ? new int?(data.ConfigId) : ((ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId) != null) ? new int?(synthesisFormula.GetValueOrDefault().ItemId) : null);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(num.Value, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(5), "ItemTipsHaveNum", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			ItemInfo? config = ItemConfig.Instance.GetConfig(num.Value);
			if (config == null)
			{
				return;
			}
			base.SetTextureByPath(config.Value.Icon, base.GetTexture(3), null, null);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(config.Value.QualityId);
			if (qualityConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(qualityConfig.Value.ComposeQualityBg, base.GetSprite(2), false, null, null);
			List<IBaseItemData> sameGroupItem = ComposeModel.Instance.GetSameGroupItem(this.CurrentData);
			IBaseItemData currentData = this.CurrentData;
			int? num2 = (currentData != null) ? new int?(currentData.ConfigId) : null;
			int configId = sameGroupItem[0].ConfigId;
			if (num2.GetValueOrDefault() == configId & num2 != null)
			{
				UUISprite sprite = base.GetSprite(0);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
			}
			if (data.IsUnlock > 0)
			{
				return;
			}
			base.GetItem(4).SetUIActive(true);
		}

		// Token: 0x060384BB RID: 230587 RVA: 0x00D5A0E4 File Offset: 0x00D582E4
		public override void OnSelect()
		{
			Action<IBaseItemData, EComposeListType, bool?> buttonFunction = this.ButtonFunction;
			if (buttonFunction != null)
			{
				buttonFunction(this.CurrentData, this.CurrentData.MainType, null);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060384BC RID: 230588 RVA: 0x00D5A131 File Offset: 0x00D58331
		private void SelectedItem(EToggleState toggleState)
		{
			Action<IBaseItemData, EComposeListType, bool?> buttonFunction = this.ButtonFunction;
			if (buttonFunction != null)
			{
				buttonFunction(this.CurrentData, this.CurrentData.MainType, new bool?(true));
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060384BD RID: 230589 RVA: 0x00D5A170 File Offset: 0x00D58370
		protected override void OnUnSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060384BE RID: 230590 RVA: 0x00D5A187 File Offset: 0x00D58387
		private bool CheckCanClick()
		{
			return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
		}

		// Token: 0x060384BF RID: 230591 RVA: 0x00D5A19E File Offset: 0x00D5839E
		public ComposeCircleItem() : base(null)
		{
		}

		// Token: 0x0401D98B RID: 121227
		public Action<IBaseItemData, EComposeListType, bool?> ButtonFunction;

		// Token: 0x0401D98C RID: 121228
		public Func<bool> CheckToggleCanClick;

		// Token: 0x0401D98D RID: 121229
		private IBaseItemData CurrentData;

		// Token: 0x0401D98E RID: 121230
		public UCurveFloat ItemCurve;

		// Token: 0x0200B82F RID: 47151
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037BD6 RID: 228310
			public const int LineSprite = 0;

			// Token: 0x04037BD7 RID: 228311
			public const int Toggle = 1;

			// Token: 0x04037BD8 RID: 228312
			public const int QualitySprite = 2;

			// Token: 0x04037BD9 RID: 228313
			public const int ItemTexture = 3;

			// Token: 0x04037BDA RID: 228314
			public const int LockItem = 4;

			// Token: 0x04037BDB RID: 228315
			public const int NumberText = 5;
		}
	}
}
