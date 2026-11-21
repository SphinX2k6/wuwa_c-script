using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x02005258 RID: 21080
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleSpineItem : UiPanelBase
	{
		// Token: 0x06034793 RID: 214931 RVA: 0x00EAF12C File Offset: 0x00EAD32C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034794 RID: 214932 RVA: 0x00EAF198 File Offset: 0x00EAD398
		public void RefreshRole(int roleId, string spineAnim = "Idle_Fight", bool bLoop = true)
		{
			PinballRoleSpineItem.<>c__DisplayClass7_0 CS$<>8__locals1 = new PinballRoleSpineItem.<>c__DisplayClass7_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.roleId = roleId;
			CS$<>8__locals1.spineAnim = spineAnim;
			CS$<>8__locals1.bLoop = bLoop;
			UiAsyncTask task = new UiAsyncTask("PinballRoleSpineItem", delegate()
			{
				PinballRoleSpineItem.<>c__DisplayClass7_0.<<RefreshRole>b__0>d <<RefreshRole>b__0>d;
				<<RefreshRole>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshRole>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshRole>b__0>d.<>1__state = -1;
				<<RefreshRole>b__0>d.<>t__builder.Start<PinballRoleSpineItem.<>c__DisplayClass7_0.<<RefreshRole>b__0>d>(ref <<RefreshRole>b__0>d);
				return <<RefreshRole>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06034795 RID: 214933 RVA: 0x00EAF1EC File Offset: 0x00EAD3EC
		public UniTask RefreshRoleAsync(int roleId, string spineAnim = "Idle_Fight", bool bLoop = true)
		{
			PinballRoleSpineItem.<RefreshRoleAsync>d__8 <RefreshRoleAsync>d__;
			<RefreshRoleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleAsync>d__.<>4__this = this;
			<RefreshRoleAsync>d__.roleId = roleId;
			<RefreshRoleAsync>d__.spineAnim = spineAnim;
			<RefreshRoleAsync>d__.bLoop = bLoop;
			<RefreshRoleAsync>d__.<>1__state = -1;
			<RefreshRoleAsync>d__.<>t__builder.Start<PinballRoleSpineItem.<RefreshRoleAsync>d__8>(ref <RefreshRoleAsync>d__);
			return <RefreshRoleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034796 RID: 214934 RVA: 0x00EAF248 File Offset: 0x00EAD448
		[NullableContext(0)]
		public UniTask<bool> LoadRoleSpineAsync(int roleId)
		{
			PinballRoleSpineItem.<LoadRoleSpineAsync>d__9 <LoadRoleSpineAsync>d__;
			<LoadRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadRoleSpineAsync>d__.<>4__this = this;
			<LoadRoleSpineAsync>d__.roleId = roleId;
			<LoadRoleSpineAsync>d__.<>1__state = -1;
			<LoadRoleSpineAsync>d__.<>t__builder.Start<PinballRoleSpineItem.<LoadRoleSpineAsync>d__9>(ref <LoadRoleSpineAsync>d__);
			return <LoadRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034797 RID: 214935 RVA: 0x00EAF293 File Offset: 0x00EAD493
		public void CancelLoadRoleSpine()
		{
			if (this.SpineAtlasPromise != null)
			{
				this.SpineAtlasPromise.CancelAsyncLoad();
				this.SpineAtlasPromise = null;
			}
			if (this.SpineSkeletonDataPromise != null)
			{
				this.SpineSkeletonDataPromise.CancelAsyncLoad();
				this.SpineSkeletonDataPromise = null;
			}
		}

		// Token: 0x06034798 RID: 214936 RVA: 0x00EAF2C9 File Offset: 0x00EAD4C9
		public void SetSpineAnim(string anim, bool bLoop = true)
		{
			if (this.IsLoading)
			{
				return;
			}
			base.GetSpine(0).SetAnimation(0, anim, bLoop);
			base.GetSpine(1).SetAnimation(0, anim, bLoop);
		}

		// Token: 0x0401BD70 RID: 114032
		protected int RoleId;

		// Token: 0x0401BD71 RID: 114033
		protected string RoleSpineAnim;

		// Token: 0x0401BD72 RID: 114034
		private bool IsLoading;

		// Token: 0x0401BD73 RID: 114035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x0401BD74 RID: 114036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0200AEAE RID: 44718
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035F70 RID: 221040
			RoleShadowSpine,
			// Token: 0x04035F71 RID: 221041
			RoleSpine
		}
	}
}
