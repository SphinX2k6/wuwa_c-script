using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005762 RID: 22370
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOccupationTitleItem : GridProxyAbstract<int>
	{
		// Token: 0x060372C2 RID: 225986 RVA: 0x00F66BD8 File Offset: 0x00F64DD8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060372C3 RID: 225987 RVA: 0x00F66CE1 File Offset: 0x00F64EE1
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Unbind();
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		}

		// Token: 0x060372C4 RID: 225988 RVA: 0x00F66D16 File Offset: 0x00F64F16
		protected override void OnBeforeDestroy()
		{
			this.CancelLoadSpine();
		}

		// Token: 0x060372C5 RID: 225989 RVA: 0x00F66D20 File Offset: 0x00F64F20
		public override void Refresh(int id, bool isSelected, int gridIndex)
		{
			this.OccupationId = id;
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(this.OccupationId);
			int iconTitleLength = occupationConfigById.Value.IconTitleLength;
			int j = 0;
			if (iconTitleLength > 1)
			{
				j = (int)PlayerInfoModel.Instance.GetPlayerGender();
			}
			string path = occupationConfigById.Value.IconTitle(j);
			this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), occupationConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), occupationConfigById.Value.RoleName, Array.Empty<object>());
			ValueTuple<string, string> spineAtlasAndDataPath = this.GetSpineAtlasAndDataPath(occupationConfigById.Value);
			string item = spineAtlasAndDataPath.Item1;
			string item2 = spineAtlasAndDataPath.Item2;
			string spineAnim = occupationConfigById.Value.SpineAnim ?? "";
			this.RefreshSpine(item, item2, spineAnim);
			this.SetToggleState(isSelected);
		}

		// Token: 0x060372C6 RID: 225990 RVA: 0x00F66E28 File Offset: 0x00F65028
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, string> GetSpineAtlasAndDataPath(DangoBrawlOccupation config)
		{
			int spineAtlasPathsLength = config.SpineAtlasPathsLength;
			int spineSkeletonDataPathsLength = config.SpineSkeletonDataPathsLength;
			if (spineAtlasPathsLength <= 0 || spineSkeletonDataPathsLength <= 0)
			{
				return new ValueTuple<string, string>("", "");
			}
			int num = 0;
			if (spineAtlasPathsLength > 1)
			{
				num = (int)PlayerInfoModel.Instance.GetPlayerGender();
				if (num < 0 || num >= spineAtlasPathsLength)
				{
					num = 0;
				}
			}
			int j = (num < spineSkeletonDataPathsLength) ? num : 0;
			return new ValueTuple<string, string>(config.SpineAtlasPaths(num) ?? "", config.SpineSkeletonDataPaths(j) ?? "");
		}

		// Token: 0x060372C7 RID: 225991 RVA: 0x00F66EA8 File Offset: 0x00F650A8
		private void RefreshSpine(string atlasPath, string skeletonPath, string spineAnim)
		{
			this.RefreshSpineAsync(atlasPath, skeletonPath, spineAnim).Forget();
		}

		// Token: 0x060372C8 RID: 225992 RVA: 0x00F66EB8 File Offset: 0x00F650B8
		private UniTask RefreshSpineAsync(string atlasPath, string skeletonPath, string spineAnim)
		{
			DangoBrawlOccupationTitleItem.<RefreshSpineAsync>d__16 <RefreshSpineAsync>d__;
			<RefreshSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpineAsync>d__.<>4__this = this;
			<RefreshSpineAsync>d__.atlasPath = atlasPath;
			<RefreshSpineAsync>d__.skeletonPath = skeletonPath;
			<RefreshSpineAsync>d__.spineAnim = spineAnim;
			<RefreshSpineAsync>d__.<>1__state = -1;
			<RefreshSpineAsync>d__.<>t__builder.Start<DangoBrawlOccupationTitleItem.<RefreshSpineAsync>d__16>(ref <RefreshSpineAsync>d__);
			return <RefreshSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060372C9 RID: 225993 RVA: 0x00F66F14 File Offset: 0x00F65114
		[return: Nullable(0)]
		private UniTask<bool> LoadSpineAsync(string atlasPath, string skeletonPath)
		{
			DangoBrawlOccupationTitleItem.<LoadSpineAsync>d__17 <LoadSpineAsync>d__;
			<LoadSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadSpineAsync>d__.<>4__this = this;
			<LoadSpineAsync>d__.atlasPath = atlasPath;
			<LoadSpineAsync>d__.skeletonPath = skeletonPath;
			<LoadSpineAsync>d__.<>1__state = -1;
			<LoadSpineAsync>d__.<>t__builder.Start<DangoBrawlOccupationTitleItem.<LoadSpineAsync>d__17>(ref <LoadSpineAsync>d__);
			return <LoadSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060372CA RID: 225994 RVA: 0x00F66F67 File Offset: 0x00F65167
		private void CancelLoadSpine()
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

		// Token: 0x060372CB RID: 225995 RVA: 0x00F66F99 File Offset: 0x00F65199
		public void PlaySpine()
		{
			this.PlaySpineAnim(this.SpineAnim);
		}

		// Token: 0x060372CC RID: 225996 RVA: 0x00F66FA8 File Offset: 0x00F651A8
		private void PlaySpineAnim(string anim)
		{
			if (this.IsLoading || string.IsNullOrEmpty(anim))
			{
				return;
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			spine.SetAnimation(0, anim, true);
		}

		// Token: 0x060372CD RID: 225997 RVA: 0x00F66FE4 File Offset: 0x00F651E4
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
			this.PlaySpine();
		}

		// Token: 0x060372CE RID: 225998 RVA: 0x00F66FF3 File Offset: 0x00F651F3
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x060372CF RID: 225999 RVA: 0x00F66FFC File Offset: 0x00F651FC
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state2, false, false, false);
		}

		// Token: 0x060372D0 RID: 226000 RVA: 0x00F67026 File Offset: 0x00F65226
		private bool OnCanExecuteChange()
		{
			Func<int, bool> isCurrentOccupation = this.IsCurrentOccupation;
			return isCurrentOccupation == null || !isCurrentOccupation(this.OccupationId);
		}

		// Token: 0x060372D1 RID: 226001 RVA: 0x00F67042 File Offset: 0x00F65242
		private void OnToggleClick(EToggleState state)
		{
			Action<int, int> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.OccupationId);
		}

		// Token: 0x0401D289 RID: 119433
		private int OccupationId;

		// Token: 0x0401D28A RID: 119434
		[Nullable(2)]
		public Action<int, int> OnClickToggleBack;

		// Token: 0x0401D28B RID: 119435
		[Nullable(2)]
		public Func<int, bool> IsCurrentOccupation;

		// Token: 0x0401D28C RID: 119436
		private string LoadedAtlasPath = "";

		// Token: 0x0401D28D RID: 119437
		private string LoadedSkeletonPath = "";

		// Token: 0x0401D28E RID: 119438
		private string SpineAnim = "";

		// Token: 0x0401D28F RID: 119439
		private bool IsLoading;

		// Token: 0x0401D290 RID: 119440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x0401D291 RID: 119441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0200B369 RID: 45929
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403772F RID: 227119
			SprRole,
			// Token: 0x04037730 RID: 227120
			TxtMainTitle,
			// Token: 0x04037731 RID: 227121
			TxtSubTitle,
			// Token: 0x04037732 RID: 227122
			TogItem,
			// Token: 0x04037733 RID: 227123
			SpineRole
		}
	}
}
