using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

// Token: 0x02000EEC RID: 3820
public class ProjectionPhotoViewParams : TPartialMultipleView
{
	// Token: 0x04002B76 RID: 11126
	public long EntityId;

	// Token: 0x04002B77 RID: 11127
	public int PbDataId;

	// Token: 0x04002B78 RID: 11128
	[Nullable(1)]
	public IProjectionMachine Config;

	// Token: 0x04002B79 RID: 11129
	[Nullable(2)]
	public Action<bool> FinishCallback;
}
