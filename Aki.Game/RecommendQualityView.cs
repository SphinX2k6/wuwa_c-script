using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C31 RID: 7217
[NullableContext(1)]
[Nullable(0)]
public class RecommendQualityView : UiViewBase
{
	// Token: 0x06011EE9 RID: 73449 RVA: 0x00546C9F File Offset: 0x00544E9F
	public RecommendQualityView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011EEA RID: 73450 RVA: 0x00546CA8 File Offset: 0x00544EA8
	protected override void OnBeforeCreate()
	{
		this.Model = RecommendQualityModel.Instance;
	}

	// Token: 0x06011EEB RID: 73451 RVA: 0x00546CB8 File Offset: 0x00544EB8
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

	// Token: 0x06011EEC RID: 73452 RVA: 0x00546D80 File Offset: 0x00544F80
	protected override UniTask OnBeforeStartAsync()
	{
		RecommendQualityView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RecommendQualityView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011EED RID: 73453 RVA: 0x00546DC3 File Offset: 0x00544FC3
	protected override void OnAfterDestroy()
	{
		this.AreaLayout = null;
		UiManager.Instance.CloseView(EUiViewName.CreateCharacterView, null);
	}

	// Token: 0x06011EEE RID: 73454 RVA: 0x00546DDC File Offset: 0x00544FDC
	protected override void OnAfterShow()
	{
		RecommendQualityModel model = this.Model;
		if (model == null)
		{
			return;
		}
		model.FinishRecommendQualityShow();
	}

	// Token: 0x06011EEF RID: 73455 RVA: 0x00546DF0 File Offset: 0x00544FF0
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

	// Token: 0x06011EF0 RID: 73456 RVA: 0x00546E42 File Offset: 0x00545042
	private RecommendQualityItem InitItem()
	{
		return new RecommendQualityItem();
	}

	// Token: 0x04009C48 RID: 40008
	private RecommendQualityModel Model;

	// Token: 0x04009C49 RID: 40009
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecommendQualityItem, IRecommendQualityItemData> AreaLayout;

	// Token: 0x02007F3C RID: 32572
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029306 RID: 168710
		public const int ItemLayout = 0;

		// Token: 0x04029307 RID: 168711
		public const int Item = 1;

		// Token: 0x04029308 RID: 168712
		public const int BtnSure = 2;
	}
}
