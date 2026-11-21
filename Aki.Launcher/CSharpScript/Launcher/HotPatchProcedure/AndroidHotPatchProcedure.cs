using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001D6 RID: 470
	public class AndroidHotPatchProcedure : MobileHotPatchProcedure
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x0004E75D File Offset: 0x0004C95D
		[NullableContext(1)]
		public AndroidHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0004E768 File Offset: 0x0004C968
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private UniTask<List<string>> RequestAndroidPermissions(TArray<string> permissions)
		{
			AndroidHotPatchProcedure.<RequestAndroidPermissions>d__1 <RequestAndroidPermissions>d__;
			<RequestAndroidPermissions>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<string>>.Create();
			<RequestAndroidPermissions>d__.permissions = permissions;
			<RequestAndroidPermissions>d__.<>1__state = -1;
			<RequestAndroidPermissions>d__.<>t__builder.Start<AndroidHotPatchProcedure.<RequestAndroidPermissions>d__1>(ref <RequestAndroidPermissions>d__);
			return <RequestAndroidPermissions>d__.<>t__builder.Task;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		public override UniTask<bool> Start()
		{
			AndroidHotPatchProcedure.<Start>d__2 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<AndroidHotPatchProcedure.<Start>d__2>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}
	}
}
