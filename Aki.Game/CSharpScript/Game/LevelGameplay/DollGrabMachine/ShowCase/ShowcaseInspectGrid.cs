using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.ShowCase
{
	// Token: 0x02006EDA RID: 28378
	internal class ShowcaseInspectGrid : UiPanelBase
	{
		// Token: 0x06045212 RID: 283154 RVA: 0x011186E0 File Offset: 0x011168E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnPreview));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06045213 RID: 283155 RVA: 0x01118765 File Offset: 0x01116965
		protected override void OnStart()
		{
			this.InitTransform();
		}

		// Token: 0x06045214 RID: 283156 RVA: 0x01118770 File Offset: 0x01116970
		public void InitTransform()
		{
			UUIItem rootItem = this.RootItem;
			if (((rootItem != null) ? rootItem.GetCanvasScaler() : null) == null)
			{
				return;
			}
			DollItemInfo dollItemInfo = this.DollItemInfo;
			BP_DollShowCaseActor_C bp_DollShowCaseActor_C = (dollItemInfo != null) ? dollItemInfo.DollShowCaseActor : null;
			if (bp_DollShowCaseActor_C == null || !bp_DollShowCaseActor_C.IsValid())
			{
				return;
			}
			Vector vector = Vector.Create();
			LguiUtil.Instance.ConvertSceneActorPositionToLguiPosition(bp_DollShowCaseActor_C, vector);
			UUIItem rootItem2 = this.RootItem;
			FVector fvector = vector.ToUeVectorOld();
			rootItem2.SetUIWorldLocation(fvector);
		}

		// Token: 0x06045215 RID: 283157 RVA: 0x011187D7 File Offset: 0x011169D7
		[NullableContext(1)]
		public void SetDollItemInfo(DollItemInfo dollItemInfo)
		{
			this.DollItemInfo = dollItemInfo;
		}

		// Token: 0x06045216 RID: 283158 RVA: 0x011187E0 File Offset: 0x011169E0
		private void OnPreview()
		{
			if (this.DollItemInfo != null)
			{
				UiManager.Instance.OpenView(EUiViewName.DollGrabShowcaseFocusView, this.DollItemInfo, null);
			}
		}

		// Token: 0x04023FF2 RID: 147442
		[Nullable(2)]
		private DollItemInfo DollItemInfo;
	}
}
