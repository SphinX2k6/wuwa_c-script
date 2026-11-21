using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200474B RID: 18251
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoAttrSelectCard : GridProxyAbstract<IKurotatoAttrSelectCardData>
	{
		// Token: 0x0602DD07 RID: 187655 RVA: 0x00CD2204 File Offset: 0x00CD0404
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickFunction));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD08 RID: 187656 RVA: 0x00CD22AC File Offset: 0x00CD04AC
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoAttrSelectCard.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoAttrSelectCard.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD09 RID: 187657 RVA: 0x00CD22EF File Offset: 0x00CD04EF
		public void SetFunctionCb(Action<int> cb)
		{
			this.FunctionCb = cb;
		}

		// Token: 0x0602DD0A RID: 187658 RVA: 0x00CD22F8 File Offset: 0x00CD04F8
		public void SetAttrPreviewCb(Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x0602DD0B RID: 187659 RVA: 0x00CD2301 File Offset: 0x00CD0501
		public void ClearAttrPreviewSelection()
		{
			this.CardItem.ClearAttrPreviewSelection();
		}

		// Token: 0x0602DD0C RID: 187660 RVA: 0x00CD230E File Offset: 0x00CD050E
		public int GetSelectionId()
		{
			IKurotatoAttrSelectCardData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.SelectionId;
		}

		// Token: 0x0602DD0D RID: 187661 RVA: 0x00CD2321 File Offset: 0x00CD0521
		public bool IsRecommend()
		{
			IKurotatoAttrSelectCardData data = this.Data;
			return data != null && data.IsRecommend;
		}

		// Token: 0x0602DD0E RID: 187662 RVA: 0x00CD2334 File Offset: 0x00CD0534
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0 || configParams[0] != "UpgradeRecommend")
			{
				return null;
			}
			return this.CardItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0602DD0F RID: 187663 RVA: 0x00CD2357 File Offset: 0x00CD0557
		public override void Refresh(IKurotatoAttrSelectCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.CardItem.Refresh(data);
			base.GetButton(1).GetRootComponent().SetUIActive(data.SelectType == EKurotatoAttrSelectType.Upgrade);
		}

		// Token: 0x0602DD10 RID: 187664 RVA: 0x00CD2386 File Offset: 0x00CD0586
		private void OnClickFunction()
		{
			Action<int> functionCb = this.FunctionCb;
			if (functionCb == null)
			{
				return;
			}
			functionCb(this.Data.SelectionId);
		}

		// Token: 0x0602DD11 RID: 187665 RVA: 0x00CD23A3 File Offset: 0x00CD05A3
		private void OnAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(this.Data.SelectionId, active, deltas);
		}

		// Token: 0x040187D2 RID: 100306
		[Nullable(2)]
		private IKurotatoAttrSelectCardData Data;

		// Token: 0x040187D3 RID: 100307
		private readonly KurotatoAttrSelectCardItem CardItem = new KurotatoAttrSelectCardItem();

		// Token: 0x040187D4 RID: 100308
		[Nullable(2)]
		private Action<int> FunctionCb;

		// Token: 0x040187D5 RID: 100309
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200A39F RID: 41887
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04032B85 RID: 207749
			public const int CardItem = 0;

			// Token: 0x04032B86 RID: 207750
			public const int ButtonFunction = 1;
		}
	}
}
