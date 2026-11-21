using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AFB RID: 6907
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCustomOptionPanel : CommonQteItemBase<CommonQteSelectOptionContext>
{
	// Token: 0x060112F8 RID: 70392 RVA: 0x0050D11E File Offset: 0x0050B31E
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060112F9 RID: 70393 RVA: 0x0050D147 File Offset: 0x0050B347
	public override void SetPreloadQte(int qteId)
	{
		this.PreloadQteId = qteId;
	}

	// Token: 0x060112FA RID: 70394 RVA: 0x0050D150 File Offset: 0x0050B350
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCustomOptionPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCustomOptionPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060112FB RID: 70395 RVA: 0x0050D193 File Offset: 0x0050B393
	protected override void OnStart()
	{
		base.OnStart();
		base.SetUiActive(false);
	}

	// Token: 0x060112FC RID: 70396 RVA: 0x0050D1A4 File Offset: 0x0050B3A4
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in this.OptionItemList)
		{
			commonQteCustomOptionItem.Destroy(null);
		}
		this.OptionItemList.Clear();
	}

	// Token: 0x060112FD RID: 70397 RVA: 0x0050D208 File Offset: 0x0050B408
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteSelectOptionContext;
	}

	// Token: 0x060112FE RID: 70398 RVA: 0x0050D214 File Offset: 0x0050B414
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

	// Token: 0x060112FF RID: 70399 RVA: 0x0050D290 File Offset: 0x0050B490
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

	// Token: 0x06011300 RID: 70400 RVA: 0x0050D2F8 File Offset: 0x0050B4F8
	protected override void OnHandleQteEnd()
	{
		foreach (CommonQteCustomOptionItem commonQteCustomOptionItem in new List<CommonQteCustomOptionItem>(this.OptionItemList))
		{
			commonQteCustomOptionItem.PlayQteEnd();
		}
	}

	// Token: 0x06011301 RID: 70401 RVA: 0x0050D350 File Offset: 0x0050B550
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

	// Token: 0x06011302 RID: 70402 RVA: 0x0050D390 File Offset: 0x0050B590
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

	// Token: 0x06011303 RID: 70403 RVA: 0x0050D470 File Offset: 0x0050B670
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x04009727 RID: 38695
	private int PreloadQteId;

	// Token: 0x04009728 RID: 38696
	private readonly List<CommonQteCustomOptionItem> OptionItemList = new List<CommonQteCustomOptionItem>();

	// Token: 0x02007DD9 RID: 32217
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BE2 RID: 166882
		OffsetPanel
	}
}
