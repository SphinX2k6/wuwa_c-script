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
	// Token: 0x02006833 RID: 26675
	public class DangoBrawlRoleUnlockView : UiViewBase
	{
		// Token: 0x06042934 RID: 272692 RVA: 0x0102E6E2 File Offset: 0x0102C8E2
		[NullableContext(1)]
		public DangoBrawlRoleUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042935 RID: 272693 RVA: 0x0102E6F8 File Offset: 0x0102C8F8
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

		// Token: 0x06042936 RID: 272694 RVA: 0x0102E7E0 File Offset: 0x0102C9E0
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

		// Token: 0x06042937 RID: 272695 RVA: 0x0102E81A File Offset: 0x0102CA1A
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

		// Token: 0x06042938 RID: 272696 RVA: 0x0102E839 File Offset: 0x0102CA39
		private void RefreshView()
		{
			if (this.RoleId <= 0)
			{
				return;
			}
			this.RefreshOccupation();
			this.RefreshRoleSpine(this.RoleId);
		}

		// Token: 0x06042939 RID: 272697 RVA: 0x0102E858 File Offset: 0x0102CA58
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

		// Token: 0x0604293A RID: 272698 RVA: 0x0102E8F0 File Offset: 0x0102CAF0
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

		// Token: 0x0604293B RID: 272699 RVA: 0x0102E938 File Offset: 0x0102CB38
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

		// Token: 0x0604293C RID: 272700 RVA: 0x0102E984 File Offset: 0x0102CB84
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

		// Token: 0x0604293D RID: 272701 RVA: 0x0102E9CF File Offset: 0x0102CBCF
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

		// Token: 0x0604293E RID: 272702 RVA: 0x0102EA04 File Offset: 0x0102CC04
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

		// Token: 0x0604293F RID: 272703 RVA: 0x0102EA40 File Offset: 0x0102CC40
		private void OnClickBtnMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022AEB RID: 142059
		private int RoleId;

		// Token: 0x04022AEC RID: 142060
		[Nullable(2)]
		private Action OnCloseCallback;

		// Token: 0x04022AED RID: 142061
		[Nullable(1)]
		private string SpineAnim = "";

		// Token: 0x04022AEE RID: 142062
		private bool IsLoading;

		// Token: 0x04022AEF RID: 142063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x04022AF0 RID: 142064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0200C9E8 RID: 51688
		private enum EComponent
		{
			// Token: 0x0403D007 RID: 249863
			BtnMask,
			// Token: 0x0403D008 RID: 249864
			UISpineActor,
			// Token: 0x0403D009 RID: 249865
			TexType,
			// Token: 0x0403D00A RID: 249866
			TxtType
		}
	}
}
