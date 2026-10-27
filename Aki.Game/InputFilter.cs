using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000DE1 RID: 3553
[NullableContext(1)]
[Nullable(0)]
public class InputFilter
{
	// Token: 0x06005575 RID: 21877 RVA: 0x000F6360 File Offset: 0x000F4560
	[NullableContext(2)]
	public InputFilter(IEnumerable<EInputAction> actions, IEnumerable<EInputAction> blockActions, IEnumerable<EInputAxis> axes, IEnumerable<EInputAxis> blockAxes)
	{
		this.Actions = new HashSet<EInputAction>(actions ?? Enumerable.Empty<EInputAction>());
		this.BlockActions = new HashSet<EInputAction>(blockActions ?? Enumerable.Empty<EInputAction>());
		this.Axes = new HashSet<EInputAxis>(axes ?? Enumerable.Empty<EInputAxis>());
		this.BlockAxes = new HashSet<EInputAxis>(blockAxes ?? Enumerable.Empty<EInputAxis>());
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x000F63C8 File Offset: 0x000F45C8
	public bool ListenToAction(EInputAction action)
	{
		HashSet<EInputAction> actions = this.Actions;
		return actions != null && actions.Contains(action);
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x000F63DC File Offset: 0x000F45DC
	public bool ListenToAxis(EInputAxis axis)
	{
		HashSet<EInputAxis> axes = this.Axes;
		return axes != null && axes.Contains(axis);
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x000F63F0 File Offset: 0x000F45F0
	public bool BlockAction(EInputAction action)
	{
		HashSet<EInputAction> blockActions = this.BlockActions;
		return blockActions != null && blockActions.Contains(action);
	}

	// Token: 0x06005579 RID: 21881 RVA: 0x000F6404 File Offset: 0x000F4604
	public bool BlockAxis(EInputAxis axis)
	{
		HashSet<EInputAxis> blockAxes = this.BlockAxes;
		return blockAxes != null && blockAxes.Contains(axis);
	}

	// Token: 0x0600557A RID: 21882 RVA: 0x000F6418 File Offset: 0x000F4618
	public InputFilter Union(InputFilter other)
	{
		InputFilter inputFilter = new InputFilter(this.Actions, this.BlockActions, this.Axes, this.BlockAxes);
		SetUtility.AddToSet<EInputAction>(inputFilter.Actions, other.Actions);
		SetUtility.AddToSet<EInputAction>(inputFilter.BlockActions, other.BlockActions);
		SetUtility.AddToSet<EInputAxis>(inputFilter.Axes, other.Axes);
		SetUtility.AddToSet<EInputAxis>(inputFilter.BlockAxes, other.BlockAxes);
		return inputFilter;
	}

	// Token: 0x040026C1 RID: 9921
	public HashSet<EInputAction> Actions;

	// Token: 0x040026C2 RID: 9922
	public HashSet<EInputAction> BlockActions;

	// Token: 0x040026C3 RID: 9923
	public HashSet<EInputAxis> Axes;

	// Token: 0x040026C4 RID: 9924
	public HashSet<EInputAxis> BlockAxes;
}
