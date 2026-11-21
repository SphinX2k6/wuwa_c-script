using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000293 RID: 659
[NullableContext(1)]
[Nullable(0)]
public class InputFilter
{
	// Token: 0x060028FF RID: 10495 RVA: 0x000FD858 File Offset: 0x000FBA58
	[NullableContext(2)]
	public InputFilter(IEnumerable<EInputAction> actions, IEnumerable<EInputAction> blockActions, IEnumerable<EInputAxis> axes, IEnumerable<EInputAxis> blockAxes)
	{
		this.Actions = new HashSet<EInputAction>(actions ?? Array.Empty<EInputAction>());
		this.BlockActions = new HashSet<EInputAction>(blockActions ?? Array.Empty<EInputAction>());
		this.Axes = new HashSet<EInputAxis>(axes ?? Array.Empty<EInputAxis>());
		this.BlockAxes = new HashSet<EInputAxis>(blockAxes ?? Array.Empty<EInputAxis>());
	}

	// Token: 0x06002900 RID: 10496 RVA: 0x000FD8C0 File Offset: 0x000FBAC0
	public bool ListenToAction(EInputAction action)
	{
		HashSet<EInputAction> actions = this.Actions;
		return actions != null && actions.Contains(action);
	}

	// Token: 0x06002901 RID: 10497 RVA: 0x000FD8D4 File Offset: 0x000FBAD4
	public bool ListenToAxis(EInputAxis axis)
	{
		HashSet<EInputAxis> axes = this.Axes;
		return axes != null && axes.Contains(axis);
	}

	// Token: 0x06002902 RID: 10498 RVA: 0x000FD8E8 File Offset: 0x000FBAE8
	public bool BlockAction(EInputAction action)
	{
		HashSet<EInputAction> blockActions = this.BlockActions;
		return blockActions != null && blockActions.Contains(action);
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x000FD8FC File Offset: 0x000FBAFC
	public bool BlockAxis(EInputAxis axis)
	{
		HashSet<EInputAxis> blockAxes = this.BlockAxes;
		return blockAxes != null && blockAxes.Contains(axis);
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x000FD910 File Offset: 0x000FBB10
	public InputFilter Union(InputFilter other)
	{
		InputFilter inputFilter = new InputFilter(this.Actions, this.BlockActions, this.Axes, this.BlockAxes);
		SetUtility.AddToSet<EInputAction>(inputFilter.Actions, other.Actions);
		SetUtility.AddToSet<EInputAction>(inputFilter.BlockActions, other.BlockActions);
		SetUtility.AddToSet<EInputAxis>(inputFilter.Axes, other.Axes);
		SetUtility.AddToSet<EInputAxis>(inputFilter.BlockAxes, other.BlockAxes);
		return inputFilter;
	}

	// Token: 0x04002749 RID: 10057
	public HashSet<EInputAction> Actions;

	// Token: 0x0400274A RID: 10058
	public HashSet<EInputAction> BlockActions;

	// Token: 0x0400274B RID: 10059
	public HashSet<EInputAxis> Axes;

	// Token: 0x0400274C RID: 10060
	public HashSet<EInputAxis> BlockAxes;
}
