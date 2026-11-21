using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001310 RID: 4880
public class ActivityTagInfoHelpView : UiViewBase, IExtraUiPopFrameType
{
	// Token: 0x170012B0 RID: 4784
	// (get) Token: 0x0600C010 RID: 49168 RVA: 0x0038C003 File Offset: 0x0038A203
	[Nullable(1)]
	private new int[] OpenParam
	{
		[NullableContext(1)]
		get
		{
			return this.OpenParam as int[];
		}
	}

	// Token: 0x0600C011 RID: 49169 RVA: 0x0038C010 File Offset: 0x0038A210
	[NullableContext(1)]
	public ActivityTagInfoHelpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C012 RID: 49170 RVA: 0x0038C01C File Offset: 0x0038A21C
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

	// Token: 0x0600C013 RID: 49171 RVA: 0x0038C0C8 File Offset: 0x0038A2C8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityTagInfoHelpView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityTagInfoHelpView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C014 RID: 49172 RVA: 0x0038C10B File Offset: 0x0038A30B
	protected override void OnStart()
	{
		this.Init();
	}

	// Token: 0x0600C015 RID: 49173 RVA: 0x0038C113 File Offset: 0x0038A313
	[NullableContext(2)]
	public EUiBehaviourPopType? GetExtraPopFrameType(object param)
	{
		return new EUiBehaviourPopType?(EUiBehaviourPopType.Middle);
	}

	// Token: 0x0600C016 RID: 49174 RVA: 0x0038C11C File Offset: 0x0038A31C
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

	// Token: 0x04006E4C RID: 28236
	[Nullable(2)]
	private ActivityTagInfoItem InfoItem1;

	// Token: 0x04006E4D RID: 28237
	[Nullable(2)]
	private ActivityTagInfoItem InfoItem2;

	// Token: 0x02007588 RID: 30088
	private enum EComponents
	{
		// Token: 0x040262B0 RID: 156336
		ScrollView,
		// Token: 0x040262B1 RID: 156337
		Content,
		// Token: 0x040262B2 RID: 156338
		ExplanationItem1,
		// Token: 0x040262B3 RID: 156339
		ExplanationItem2
	}
}
