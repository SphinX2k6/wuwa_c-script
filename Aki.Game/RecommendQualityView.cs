using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002746 RID: 10054
[NullableContext(1)]
[Nullable(0)]
public class RecommendQualityView : UiViewBase
{
	// Token: 0x06014A07 RID: 84487 RVA: 0x00537ECB File Offset: 0x005360CB
	public RecommendQualityView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A08 RID: 84488 RVA: 0x00537ED4 File Offset: 0x005360D4
	protected override void OnBeforeCreate()
	{
		this.Model = RecommendQualityModel.Instance;
	}

	// Token: 0x06014A09 RID: 84489 RVA: 0x00537EE4 File Offset: 0x005360E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.BtnSureClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014A0A RID: 84490 RVA: 0x00537FAC File Offset: 0x005361AC
	protected override UniTask OnBeforeStartAsync()
	{
		RecommendQualityView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RecommendQualityView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A0B RID: 84491 RVA: 0x00537FEF File Offset: 0x005361EF
	protected override void OnAfterDestroy()
	{
		this.AreaLayout = null;
		UiManager.Instance.CloseView(EUiViewName.CreateCharacterView, null);
	}

	// Token: 0x06014A0C RID: 84492 RVA: 0x00538008 File Offset: 0x00536208
	protected override void OnAfterShow()
	{
		RecommendQualityModel model = this.Model;
		if (model == null)
		{
			return;
		}
		model.FinishRecommendQualityShow();
	}

	// Token: 0x06014A0D RID: 84493 RVA: 0x0053801C File Offset: 0x0053621C
	private void BtnSureClick()
	{
		if (this.AreaLayout == null)
		{
			return;
		}
		int selectedGridIndex = this.AreaLayout.GetSelectedGridIndex();
		IRecommendQualityItemData recommendQualityItemData = this.AreaLayout.GetDatas()[selectedGridIndex];
		RecommendQualityModel model = this.Model;
		if (model != null)
		{
			model.SaveApply(recommendQualityItemData.Quality);
		}
		base.CloseMe(null);
	}

	// Token: 0x06014A0E RID: 84494 RVA: 0x0053806E File Offset: 0x0053626E
	private RecommendQualityItem InitItem()
	{
		return new RecommendQualityItem();
	}

	// Token: 0x04009AF0 RID: 39664
	private RecommendQualityModel Model;

	// Token: 0x04009AF1 RID: 39665
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecommendQualityItem, IRecommendQualityItemData> AreaLayout;

	// Token: 0x02008DB3 RID: 36275
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402DFEF RID: 188399
		public const int ItemLayout = 0;

		// Token: 0x0402DFF0 RID: 188400
		public const int Item = 1;

		// Token: 0x0402DFF1 RID: 188401
		public const int BtnSure = 2;
	}
}
