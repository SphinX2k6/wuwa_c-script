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
	// Token: 0x02005774 RID: 22388
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoAttrSelectCard : GridProxyAbstract<IKurotatoAttrSelectCardData>
	{
		// Token: 0x06038DF7 RID: 232951 RVA: 0x00D836FC File Offset: 0x00D818FC
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

		// Token: 0x06038DF8 RID: 232952 RVA: 0x00D837A4 File Offset: 0x00D819A4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoAttrSelectCard.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoAttrSelectCard.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DF9 RID: 232953 RVA: 0x00D837E7 File Offset: 0x00D819E7
		public void SetFunctionCb(Action<int> cb)
		{
			this.FunctionCb = cb;
		}

		// Token: 0x06038DFA RID: 232954 RVA: 0x00D837F0 File Offset: 0x00D819F0
		public void SetAttrPreviewCb(Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x06038DFB RID: 232955 RVA: 0x00D837F9 File Offset: 0x00D819F9
		public void ClearAttrPreviewSelection()
		{
			this.CardItem.ClearAttrPreviewSelection();
		}

		// Token: 0x06038DFC RID: 232956 RVA: 0x00D83806 File Offset: 0x00D81A06
		public int GetSelectionId()
		{
			IKurotatoAttrSelectCardData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.SelectionId;
		}

		// Token: 0x06038DFD RID: 232957 RVA: 0x00D83819 File Offset: 0x00D81A19
		public bool IsRecommend()
		{
			IKurotatoAttrSelectCardData data = this.Data;
			return data != null && data.IsRecommend;
		}

		// Token: 0x06038DFE RID: 232958 RVA: 0x00D8382C File Offset: 0x00D81A2C
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

		// Token: 0x06038DFF RID: 232959 RVA: 0x00D8384F File Offset: 0x00D81A4F
		public override void Refresh(IKurotatoAttrSelectCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.CardItem.Refresh(data);
			base.GetButton(1).GetRootComponent().SetUIActive(data.SelectType == EKurotatoAttrSelectType.Upgrade);
		}

		// Token: 0x06038E00 RID: 232960 RVA: 0x00D8387E File Offset: 0x00D81A7E
		private void OnClickFunction()
		{
			Action<int> functionCb = this.FunctionCb;
			if (functionCb == null)
			{
				return;
			}
			functionCb(this.Data.SelectionId);
		}

		// Token: 0x06038E01 RID: 232961 RVA: 0x00D8389B File Offset: 0x00D81A9B
		private void OnAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(this.Data.SelectionId, active, deltas);
		}

		// Token: 0x0401DD3C RID: 122172
		[Nullable(2)]
		private IKurotatoAttrSelectCardData Data;

		// Token: 0x0401DD3D RID: 122173
		private readonly KurotatoAttrSelectCardItem CardItem = new KurotatoAttrSelectCardItem();

		// Token: 0x0401DD3E RID: 122174
		[Nullable(2)]
		private Action<int> FunctionCb;

		// Token: 0x0401DD3F RID: 122175
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200B985 RID: 47493
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x0403818B RID: 229771
			public const int CardItem = 0;

			// Token: 0x0403818C RID: 229772
			public const int ButtonFunction = 1;
		}
	}
}
