using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005783 RID: 22403
	public class DangoBrawlRoleUnlockView : UiViewBase
	{
		// Token: 0x06037488 RID: 226440 RVA: 0x00F6FC1E File Offset: 0x00F6DE1E
		[NullableContext(1)]
		public DangoBrawlRoleUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037489 RID: 226441 RVA: 0x00F6FC34 File Offset: 0x00F6DE34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603748A RID: 226442 RVA: 0x00F6FD1C File Offset: 0x00F6DF1C
		protected override void OnStart()
		{
			DangoBrawlRoleUnlockViewOpenData dangoBrawlRoleUnlockViewOpenData = this.OpenParam as DangoBrawlRoleUnlockViewOpenData;
			if (dangoBrawlRoleUnlockViewOpenData != null)
			{
				this.RoleId = dangoBrawlRoleUnlockViewOpenData.RoleId;
				this.OnCloseCallback = dangoBrawlRoleUnlockViewOpenData.OnCloseCallback;
			}
			this.RefreshView();
		}

		// Token: 0x0603748B RID: 226443 RVA: 0x00F6FD56 File Offset: 0x00F6DF56
		protected override void OnBeforeDestroy()
		{
			this.CancelLoadRoleSpine();
			Action onCloseCallback = this.OnCloseCallback;
			this.OnCloseCallback = null;
			if (onCloseCallback == null)
			{
				return;
			}
			onCloseCallback();
		}

		// Token: 0x0603748C RID: 226444 RVA: 0x00F6FD75 File Offset: 0x00F6DF75
		private void RefreshView()
		{
			if (this.RoleId <= 0)
			{
				return;
			}
			this.RefreshOccupation();
			this.RefreshRoleSpine(this.RoleId);
		}

		// Token: 0x0603748D RID: 226445 RVA: 0x00F6FD94 File Offset: 0x00F6DF94
		private void RefreshOccupation()
		{
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(this.RoleId);
			if (roleConfigById == null)
			{
				return;
			}
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(roleConfigById.Value.OccupationId);
			if (occupationConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), occupationConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x0603748E RID: 226446 RVA: 0x00F6FE2C File Offset: 0x00F6E02C
		private void RefreshRoleSpine(int roleId)
		{
			DangoBrawlRoleUnlockView.<>c__DisplayClass13_0 CS$<>8__locals1 = new DangoBrawlRoleUnlockView.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.roleId = roleId;
			UiAsyncTask task = new UiAsyncTask("DangoBrawlRoleUnlockView", delegate()
			{
				DangoBrawlRoleUnlockView.<>c__DisplayClass13_0.<<RefreshRoleSpine>b__0>d <<RefreshRoleSpine>b__0>d;
				<<RefreshRoleSpine>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshRoleSpine>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshRoleSpine>b__0>d.<>1__state = -1;
				<<RefreshRoleSpine>b__0>d.<>t__builder.Start<DangoBrawlRoleUnlockView.<>c__DisplayClass13_0.<<RefreshRoleSpine>b__0>d>(ref <<RefreshRoleSpine>b__0>d);
				return <<RefreshRoleSpine>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603748F RID: 226447 RVA: 0x00F6FE74 File Offset: 0x00F6E074
		private UniTask RefreshRoleSpineAsync(int roleId)
		{
			DangoBrawlRoleUnlockView.<RefreshRoleSpineAsync>d__14 <RefreshRoleSpineAsync>d__;
			<RefreshRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpineAsync>d__.<>4__this = this;
			<RefreshRoleSpineAsync>d__.roleId = roleId;
			<RefreshRoleSpineAsync>d__.<>1__state = -1;
			<RefreshRoleSpineAsync>d__.<>t__builder.Start<DangoBrawlRoleUnlockView.<RefreshRoleSpineAsync>d__14>(ref <RefreshRoleSpineAsync>d__);
			return <RefreshRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037490 RID: 226448 RVA: 0x00F6FEC0 File Offset: 0x00F6E0C0
		private UniTask<bool> LoadRoleSpineAsync(int roleId)
		{
			DangoBrawlRoleUnlockView.<LoadRoleSpineAsync>d__15 <LoadRoleSpineAsync>d__;
			<LoadRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadRoleSpineAsync>d__.<>4__this = this;
			<LoadRoleSpineAsync>d__.roleId = roleId;
			<LoadRoleSpineAsync>d__.<>1__state = -1;
			<LoadRoleSpineAsync>d__.<>t__builder.Start<DangoBrawlRoleUnlockView.<LoadRoleSpineAsync>d__15>(ref <LoadRoleSpineAsync>d__);
			return <LoadRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037491 RID: 226449 RVA: 0x00F6FF0B File Offset: 0x00F6E10B
		private void CancelLoadRoleSpine()
		{
			LoadAsyncPromise<USpineAtlasAsset> spineAtlasPromise = this.SpineAtlasPromise;
			if (spineAtlasPromise != null)
			{
				spineAtlasPromise.CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineSkeletonDataAsset> spineSkeletonDataPromise = this.SpineSkeletonDataPromise;
			if (spineSkeletonDataPromise != null)
			{
				spineSkeletonDataPromise.CancelAsyncLoad();
			}
			this.SpineAtlasPromise = null;
			this.SpineSkeletonDataPromise = null;
		}

		// Token: 0x06037492 RID: 226450 RVA: 0x00F6FF40 File Offset: 0x00F6E140
		[NullableContext(1)]
		private void PlaySpineAnim(string anim)
		{
			if (this.IsLoading || string.IsNullOrEmpty(anim))
			{
				return;
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			spine.SetAnimation(0, anim, true);
		}

		// Token: 0x06037493 RID: 226451 RVA: 0x00F6FF7C File Offset: 0x00F6E17C
		private void OnClickBtnMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D348 RID: 119624
		private int RoleId;

		// Token: 0x0401D349 RID: 119625
		[Nullable(2)]
		private Action OnCloseCallback;

		// Token: 0x0401D34A RID: 119626
		[Nullable(1)]
		private string SpineAnim = "";

		// Token: 0x0401D34B RID: 119627
		private bool IsLoading;

		// Token: 0x0401D34C RID: 119628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x0401D34D RID: 119629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0200B3B4 RID: 46004
		private enum EComponent
		{
			// Token: 0x040378F1 RID: 227569
			BtnMask,
			// Token: 0x040378F2 RID: 227570
			UISpineActor,
			// Token: 0x040378F3 RID: 227571
			TexType,
			// Token: 0x040378F4 RID: 227572
			TxtType
		}
	}
}
