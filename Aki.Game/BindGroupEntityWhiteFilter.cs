using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034BB RID: 13499
[NullableContext(1)]
[Nullable(0)]
public sealed class BindGroupEntityWhiteFilter : EntityToLoadFilter
{
	// Token: 0x170028C3 RID: 10435
	// (get) Token: 0x0601D661 RID: 120417 RVA: 0x00833C9E File Offset: 0x00831E9E
	public override string DebugName
	{
		get
		{
			return "BindGroupEntityWhiteFilter";
		}
	}

	// Token: 0x170028C4 RID: 10436
	// (get) Token: 0x0601D662 RID: 120418 RVA: 0x00833CA5 File Offset: 0x00831EA5
	public override EFilterType FilterType
	{
		get
		{
			return EFilterType.BindGroup;
		}
	}

	// Token: 0x0601D663 RID: 120419 RVA: 0x00833CA8 File Offset: 0x00831EA8
	public BindGroupEntityWhiteFilter()
	{
		this.TargetCriteriaInternal = new Func<EntityHandle, bool>(this.TargetCriteriaFunc);
	}

	// Token: 0x0601D664 RID: 120420 RVA: 0x00833CD0 File Offset: 0x00831ED0
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

	// Token: 0x0601D665 RID: 120421 RVA: 0x00833DD8 File Offset: 0x00831FD8
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, new Action<IReadOnlyList<long>>(this.OnEntityRemovedFromBindGroup));
	}

	// Token: 0x0601D666 RID: 120422 RVA: 0x00833DFC File Offset: 0x00831FFC
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<IReadOnlyList<long>>(EEventName.RemoveEntityFromBindGroup, new Action<IReadOnlyList<long>>(this.OnEntityRemovedFromBindGroup));
		base.Cleanup();
	}

	// Token: 0x0601D667 RID: 120423 RVA: 0x00833E20 File Offset: 0x00832020
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

	// Token: 0x0601D668 RID: 120424 RVA: 0x00833EB8 File Offset: 0x008320B8
	private void OnEntityRemovedFromBindGroup(IReadOnlyList<long> creatureDataIds)
	{
		foreach (long creatureDataId in creatureDataIds)
		{
			this.CleanWhitelist(creatureDataId);
		}
	}

	// Token: 0x0400E7AA RID: 59306
	private readonly HashSet<long> WhiteListForBindGroups = new HashSet<long>();
}
