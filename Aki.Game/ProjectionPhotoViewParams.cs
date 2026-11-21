using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x020003A1 RID: 929
public class ProjectionPhotoViewParams : TPartialMultipleView
{
	// Token: 0x04002C0F RID: 11279
	public long EntityId;

	// Token: 0x04002C10 RID: 11280
	public int PbDataId;

	// Token: 0x04002C11 RID: 11281
	[Nullable(1)]
	public IProjectionMachine Config;

	// Token: 0x04002C12 RID: 11282
	[Nullable(2)]
	public Action<bool> FinishCallback;
}
