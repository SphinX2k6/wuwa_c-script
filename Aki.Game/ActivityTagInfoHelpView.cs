using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E4E RID: 7758
public class ActivityTagInfoHelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x17001286 RID: 4742
	// (get) Token: 0x0600EBF1 RID: 60401 RVA: 0x0038036B File Offset: 0x0037E56B
	[Nullable(1)]
	private new int[] OpenParam
	{
		[NullableContext(1)]
		get
		{
			return this.OpenParam as int[];
		}
	}

	// Token: 0x0600EBF2 RID: 60402 RVA: 0x00380378 File Offset: 0x0037E578
	[NullableContext(1)]
	public ActivityTagInfoHelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EBF3 RID: 60403 RVA: 0x00380384 File Offset: 0x0037E584
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600EBF4 RID: 60404 RVA: 0x00380430 File Offset: 0x0037E630
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTagInfoHelpView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTagInfoHelpView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBF5 RID: 60405 RVA: 0x00380473 File Offset: 0x0037E673
	protected override void OnStart()
	{
		this.Init();
	}

	// Token: 0x0600EBF6 RID: 60406 RVA: 0x0038047B File Offset: 0x0037E67B
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.Middle);
	}

	// Token: 0x0600EBF7 RID: 60407 RVA: 0x00380484 File Offset: 0x0037E684
	private void Init()
	{
		int[] openParam = this.OpenParam;
		if (openParam == null || openParam.Length != 2)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "ActivityTagInfoHelpView.Init.OpenParams.Length != 2", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = openParam[0];
		int num2 = openParam[1];
		if (num <= 0)
		{
			base.GetItem(2).SetUIActive(false);
		}
		else
		{
			ActivityTitleTags? activityTitleTags = ActivityConfig.Instance.GetActivityTitleTags(num);
			if (activityTitleTags == null || string.IsNullOrEmpty(activityTitleTags.Value.DescInTip))
			{
				base.GetItem(2).SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(true);
			this.InfoItem1.SetView(activityTitleTags.Value);
		}
		if (num2 <= 0)
		{
			base.GetItem(3).SetUIActive(false);
			return;
		}
		ActivityTitleTags? activityTitleTags2 = ActivityConfig.Instance.GetActivityTitleTags(num2);
		if (activityTitleTags2 == null || string.IsNullOrEmpty(activityTitleTags2.Value.DescInTip))
		{
			base.GetItem(3).SetUIActive(false);
			return;
		}
		base.GetItem(3).SetUIActive(true);
		this.InfoItem2.SetView(activityTitleTags2.Value);
	}

	// Token: 0x04006D6B RID: 28011
	[Nullable(2)]
	private ActivityTagInfoItem InfoItem1;

	// Token: 0x04006D6C RID: 28012
	[Nullable(2)]
	private ActivityTagInfoItem InfoItem2;

	// Token: 0x02008403 RID: 33795
	private enum EComponents
	{
		// Token: 0x0402AF8C RID: 176012
		ScrollView,
		// Token: 0x0402AF8D RID: 176013
		Content,
		// Token: 0x0402AF8E RID: 176014
		ExplanationItem1,
		// Token: 0x0402AF8F RID: 176015
		ExplanationItem2
	}
}
