using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000212 RID: 530
	[NullableContext(1)]
	[Nullable(0)]
	public class AndroidDiffPatchProcedure : MobileDiffPatchProcedure
	{
		// Token: 0x06000DC3 RID: 3523 RVA: 0x00053417 File Offset: 0x00051617
		public AndroidDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00053424 File Offset: 0x00051624
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private UniTask<List<string>> RequestAndroidPermissions(TArray<string> permissions)
		{
			AndroidDiffPatchProcedure.<RequestAndroidPermissions>d__1 <RequestAndroidPermissions>d__;
			<RequestAndroidPermissions>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<string>>.Create();
			<RequestAndroidPermissions>d__.permissions = permissions;
			<RequestAndroidPermissions>d__.<>1__state = -1;
			<RequestAndroidPermissions>d__.<>t__builder.Start<AndroidDiffPatchProcedure.<RequestAndroidPermissions>d__1>(ref <RequestAndroidPermissions>d__);
			return <RequestAndroidPermissions>d__.<>t__builder.Task;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00053468 File Offset: 0x00051668
		public UniTask RequestPermission()
		{
			AndroidDiffPatchProcedure.<RequestPermission>d__2 <RequestPermission>d__;
			<RequestPermission>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestPermission>d__.<>4__this = this;
			<RequestPermission>d__.<>1__state = -1;
			<RequestPermission>d__.<>t__builder.Start<AndroidDiffPatchProcedure.<RequestPermission>d__2>(ref <RequestPermission>d__);
			return <RequestPermission>d__.<>t__builder.Task;
		}
	}
}
