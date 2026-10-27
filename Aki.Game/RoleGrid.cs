using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002787 RID: 10119
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RoleGrid : GridProxyAbstract<RoleGridContentData>
{
	// Token: 0x06014C21 RID: 85025 RVA: 0x00540C60 File Offset: 0x0053EE60
	protected override void OnStart()
	{
	}

	// Token: 0x06014C22 RID: 85026 RVA: 0x00540C62 File Offset: 0x0053EE62
	public override void Refresh(RoleGridContentData data, bool isSelected, int gridIndex)
	{
		this.RefreshMediumItemGrid(data);
	}

	// Token: 0x06014C23 RID: 85027 RVA: 0x00540C6C File Offset: 0x0053EE6C
	private UniTask RefreshMediumItemGrid(RoleGridContentData data)
	{
		RoleGrid.<RefreshMediumItemGrid>d__4 <RefreshMediumItemGrid>d__;
		<RefreshMediumItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMediumItemGrid>d__.<>4__this = this;
		<RefreshMediumItemGrid>d__.data = data;
		<RefreshMediumItemGrid>d__.<>1__state = -1;
		<RefreshMediumItemGrid>d__.<>t__builder.Start<RoleGrid.<RefreshMediumItemGrid>d__4>(ref <RefreshMediumItemGrid>d__);
		return <RefreshMediumItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x04009C1C RID: 39964
	[Nullable(2)]
	private CustomPromise LoadPromise;

	// Token: 0x04009C1D RID: 39965
	[Nullable(2)]
	private MediumItemGrid MediumItemGrid;
}
