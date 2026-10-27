using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002610 RID: 9744
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCustomOptionPanel : CommonQteItemBase<CommonQteSelectOptionContext>
{
	// Token: 0x06013E16 RID: 81430 RVA: 0x004FE2E2 File Offset: 0x004FC4E2
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x06013E17 RID: 81431 RVA: 0x004FE30B File Offset: 0x004FC50B
	public override void SetPreloadQte(int qteId)
	{
		this.PreloadQteId = qteId;
	}

	// Token: 0x06013E18 RID: 81432 RVA: 0x004FE314 File Offset: 0x004FC514
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCustomOptionPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCustomOptionPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E19 RID: 81433 RVA: 0x004FE357 File Offset: 0x004FC557
	protected override void OnStart()
	{
		base.OnStart();
		base.SetUiActive(false);
	}

	// Token: 0x06013E1A RID: 81434 RVA: 0x004FE368 File Offset: 0x004FC568
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in this.OptionItemList)
		{
			commonQteCustomOptionItem.Destroy(null);
		}
		this.OptionItemList.Clear();
	}

	// Token: 0x06013E1B RID: 81435 RVA: 0x004FE3CC File Offset: 0x004FC5CC
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSelectOptionContext;
	}

	// Token: 0x06013E1C RID: 81436 RVA: 0x004FE3D8 File Offset: 0x004FC5D8
	public override void SetQteContext(CommonQteContextBase context)
	{
		CommonQteSelectOptionContext commonQteSelectOptionContext = context as CommonQteSelectOptionContext;
		if (commonQteSelectOptionContext == null)
		{
			return;
		}
		this.QteHandle = context.HandleId;
		this.CommonQteContext = commonQteSelectOptionContext;
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in this.OptionItemList)
		{
			commonQteCustomOptionItem.SetQteContext(context);
		}
		base.SetQteActive(context);
		this.PlayQteStart();
	}

	// Token: 0x06013E1D RID: 81437 RVA: 0x004FE454 File Offset: 0x004FC654
	protected override void OnPlayQteStart()
	{
		this.IsQteStart = true;
		this.IsQteInteractive = true;
		base.SetUiActive(true);
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in this.OptionItemList)
		{
			commonQteCustomOptionItem.PlayQteStart();
		}
	}

	// Token: 0x06013E1E RID: 81438 RVA: 0x004FE4BC File Offset: 0x004FC6BC
	protected override void OnHandleQteEnd()
	{
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in new List<CommonQteCustomOptionItem>(this.OptionItemList))
		{
			commonQteCustomOptionItem.PlayQteEnd();
		}
	}

	// Token: 0x06013E1F RID: 81439 RVA: 0x004FE514 File Offset: 0x004FC714
	public void OnOptionItemPlayEnded(CommonQteCustomOptionItem optionItem)
	{
		int num = this.OptionItemList.IndexOf(optionItem);
		if (num != -1)
		{
			this.OptionItemList.RemoveAt(num);
		}
		if (this.OptionItemList.Count == 0)
		{
			base.Destroy(null);
		}
	}

	// Token: 0x06013E20 RID: 81440 RVA: 0x004FE554 File Offset: 0x004FC754
	protected override void OnTickQteItem(float delta)
	{
		if (!this.CommonQteContext.IsPermanent)
		{
			CommonQteSelectOptionContext commonQteContext = this.CommonQteContext;
			float value = (commonQteContext != null) ? commonQteContext.GetRemainingTimeProgress() : 1f;
			foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in this.OptionItemList)
			{
				commonQteCustomOptionItem.SetProgress(value);
			}
		}
		CommonQteModel instance = CommonQteModel.Instance;
		if (instance != null && instance.IsRefreshMode)
		{
			foreach (CommonQteCustomOptionItem commonQteCustomOptionItem2 in this.OptionItemList)
			{
				commonQteCustomOptionItem2.RefreshUiOffset();
			}
			if (this.IsAttaching)
			{
				this.Reattach(this.CommonQteContext);
			}
		}
	}

	// Token: 0x06013E21 RID: 81441 RVA: 0x004FE634 File Offset: 0x004FC834
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x040095D0 RID: 38352
	private int PreloadQteId;

	// Token: 0x040095D1 RID: 38353
	private readonly List<CommonQteCustomOptionItem> OptionItemList = new List<CommonQteCustomOptionItem>();

	// Token: 0x02008C50 RID: 35920
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8CB RID: 186571
		OffsetPanel
	}
}
