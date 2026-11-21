using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019AF RID: 6575
[NullableContext(1)]
[Nullable(0)]
public class LevelUpIdentifyComponent : UiPanelBase
{
	// Token: 0x0601033A RID: 66362 RVA: 0x004BA62F File Offset: 0x004B882F
	public LevelUpIdentifyComponent(UUIItem uiItem)
	{
		this.ComponentItem = uiItem;
	}

	// Token: 0x0601033B RID: 66363 RVA: 0x004BA640 File Offset: 0x004B8840
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

	// Token: 0x0601033C RID: 66364 RVA: 0x004BA68B File Offset: 0x004B888B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0601033D RID: 66365 RVA: 0x004BA6C4 File Offset: 0x004B88C4
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionIdentifyItem, VisionSubPropViewData>(base.GetVerticalLayout(0), new Func<VisionIdentifyItem>(this.InitItem), null, false, true);
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0601033E RID: 66366 RVA: 0x004BA6F4 File Offset: 0x004B88F4
	private VisionIdentifyItem InitItem()
	{
		return new VisionIdentifyItem();
	}

	// Token: 0x0601033F RID: 66367 RVA: 0x004BA6FC File Offset: 0x004B88FC
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

	// Token: 0x06010340 RID: 66368 RVA: 0x004BA748 File Offset: 0x004B8948
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

	// Token: 0x04008FC5 RID: 36805
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<VisionIdentifyItem, VisionSubPropViewData> Layout;

	// Token: 0x04008FC6 RID: 36806
	[Nullable(2)]
	private readonly UUIItem ComponentItem;

	// Token: 0x04008FC7 RID: 36807
	[Nullable(2)]
	private string SourceViewName;

	// Token: 0x04008FC8 RID: 36808
	[Nullable(2)]
	private CustomPromise<bool> ReloadState;

	// Token: 0x02007BD3 RID: 31699
	[NullableContext(0)]
	private enum ELevelAttribute
	{
		// Token: 0x0402818B RID: 164235
		Layout,
		// Token: 0x0402818C RID: 164236
		Item
	}
}
