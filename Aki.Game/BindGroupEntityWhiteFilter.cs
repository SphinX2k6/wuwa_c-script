using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A2F RID: 10799
[NullableContext(1)]
[Nullable(0)]
public sealed class BindGroupEntityWhiteFilter : EntityToLoadFilter
{
	// Token: 0x17002C5B RID: 11355
	// (get) Token: 0x0601B360 RID: 111456 RVA: 0x0085B146 File Offset: 0x00859346
	public override string DebugName
	{
		get
		{
			return "BindGroupEntityWhiteFilter";
		}
	}

	// Token: 0x17002C5C RID: 11356
	// (get) Token: 0x0601B361 RID: 111457 RVA: 0x0085B14D File Offset: 0x0085934D
	public override EFilterType FilterType
	{
		get
		{
			return EFilterType.BindGroup;
		}
	}

	// Token: 0x0601B362 RID: 111458 RVA: 0x0085B150 File Offset: 0x00859350
	public BindGroupEntityWhiteFilter()
	{
		this.TargetCriteriaInternal = new Func<EntityHandle, bool>(this.TargetCriteriaFunc);
	}

	// Token: 0x0601B363 RID: 111459 RVA: 0x0085B178 File Offset: 0x00859378
	private unsafe bool TargetCriteriaFunc(EntityHandle entityHandle)
	{
		IReadOnlyList<long> bindGroup = CreatureGroupController.Instance.GetBindGroup(entityHandle.CreatureDataId);
		if (bindGroup == null)
		{
			return false;
		}
		foreach (long item in bindGroup)
		{
			this.WhiteListForBindGroups.Add(item);
		}
		if (CreatureModel.Instance.EnableEntityLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.XY;
			string message = "预加载实体:加入实体组白名单";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", entityHandle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("group", string.Join<long>(",", bindGroup));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("whiteList", this.WhiteListForBindGroups);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return this.WhiteListForBindGroups.Contains(entityHandle.CreatureDataId);
	}

	// Token: 0x0601B364 RID: 111460 RVA: 0x0085B280 File Offset: 0x00859480
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, new Action<IReadOnlyList<long>>(this.OnEntityRemovedFromBindGroup));
	}

	// Token: 0x0601B365 RID: 111461 RVA: 0x0085B2A4 File Offset: 0x008594A4
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, new Action<IReadOnlyList<long>>(this.OnEntityRemovedFromBindGroup));
		base.Cleanup();
	}

	// Token: 0x0601B366 RID: 111462 RVA: 0x0085B2C8 File Offset: 0x008594C8
	private unsafe void CleanWhitelist(long creatureDataId)
	{
		if (this.WhiteListForBindGroups.Remove(creatureDataId))
		{
			if (CreatureModel.Instance.EnableEntityLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预加载实体:清除实体组白名单";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", creatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("whiteList", this.WhiteListForBindGroups);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			EventSystem.Instance.Emit<object>(EEventName.FilterCriteriaChanged, this);
		}
	}

	// Token: 0x0601B367 RID: 111463 RVA: 0x0085B360 File Offset: 0x00859560
	private void OnEntityRemovedFromBindGroup(IReadOnlyList<long> creatureDataIds)
	{
		foreach (long creatureDataId in creatureDataIds)
		{
			this.CleanWhitelist(creatureDataId);
		}
	}

	// Token: 0x0400EC5E RID: 60510
	private readonly HashSet<long> WhiteListForBindGroups = new HashSet<long>();
}
