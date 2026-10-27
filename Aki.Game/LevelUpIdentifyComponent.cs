using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024C8 RID: 9416
[NullableContext(1)]
[Nullable(0)]
public class LevelUpIdentifyComponent : UiPanelBase
{
	// Token: 0x06012E7B RID: 77435 RVA: 0x004ACA2F File Offset: 0x004AAC2F
	public LevelUpIdentifyComponent(UUIItem uiItem)
	{
		this.ComponentItem = uiItem;
	}

	// Token: 0x06012E7C RID: 77436 RVA: 0x004ACA40 File Offset: 0x004AAC40
	public UniTask Init(string sourceView)
	{
		LevelUpIdentifyComponent.<Init>d__6 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.sourceView = sourceView;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<LevelUpIdentifyComponent.<Init>d__6>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012E7D RID: 77437 RVA: 0x004ACA8B File Offset: 0x004AAC8B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012E7E RID: 77438 RVA: 0x004ACAC4 File Offset: 0x004AACC4
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionIdentifyItem, VisionSubPropViewData>(base.GetVerticalLayout(0), new Func<VisionIdentifyItem>(this.InitItem), null, false, true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06012E7F RID: 77439 RVA: 0x004ACAF4 File Offset: 0x004AACF4
	private VisionIdentifyItem InitItem()
	{
		return new VisionIdentifyItem();
	}

	// Token: 0x06012E80 RID: 77440 RVA: 0x004ACAFC File Offset: 0x004AACFC
	public UniTask PlayUpdateAnimation(int[] needPlayIndex)
	{
		LevelUpIdentifyComponent.<PlayUpdateAnimation>d__10 <PlayUpdateAnimation>d__;
		<PlayUpdateAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayUpdateAnimation>d__.<>4__this = this;
		<PlayUpdateAnimation>d__.needPlayIndex = needPlayIndex;
		<PlayUpdateAnimation>d__.<>1__state = -1;
		<PlayUpdateAnimation>d__.<>t__builder.Start<LevelUpIdentifyComponent.<PlayUpdateAnimation>d__10>(ref <PlayUpdateAnimation>d__);
		return <PlayUpdateAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06012E81 RID: 77441 RVA: 0x004ACB48 File Offset: 0x004AAD48
	public void Update([Nullable(new byte[]
	{
		1,
		2
	})] VisionSubPropData[] data, bool ifPreCache)
	{
		this.ReloadState = new CustomPromise<bool>();
		if (data.Length != 0)
		{
			List<VisionSubPropViewData> list = new List<VisionSubPropViewData>();
			foreach (VisionSubPropData data2 in data)
			{
				VisionSubPropViewData item = new VisionSubPropViewData
				{
					Data = data2,
					SourceView = this.SourceViewName,
					IfPreCache = ifPreCache
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, delegate
			{
				if (this.ReloadState != null && !this.ReloadState.IsFulfilled)
				{
					this.ReloadState.SetResult(true);
				}
			}, false);
		}
	}

	// Token: 0x04008E7B RID: 36475
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<VisionIdentifyItem, VisionSubPropViewData> Layout;

	// Token: 0x04008E7C RID: 36476
	[Nullable(2)]
	private readonly UUIItem ComponentItem;

	// Token: 0x04008E7D RID: 36477
	[Nullable(2)]
	private string SourceViewName;

	// Token: 0x04008E7E RID: 36478
	[Nullable(2)]
	private CustomPromise<bool> ReloadState;

	// Token: 0x02008A4A RID: 35402
	[NullableContext(0)]
	private enum ELevelAttribute
	{
		// Token: 0x0402CE6D RID: 183917
		Layout,
		// Token: 0x0402CE6E RID: 183918
		Item
	}
}
