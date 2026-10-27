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
	// Token: 0x02006812 RID: 26642
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOccupationTitleItem : GridProxyAbstract<int>
	{
		// Token: 0x0604276D RID: 272237 RVA: 0x01025694 File Offset: 0x01023894
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

		// Token: 0x0604276E RID: 272238 RVA: 0x0102579D File Offset: 0x0102399D
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

		// Token: 0x0604276F RID: 272239 RVA: 0x010257D2 File Offset: 0x010239D2
		protected override void OnBeforeDestroy()
		{
			this.CancelLoadSpine();
		}

		// Token: 0x06042770 RID: 272240 RVA: 0x010257DC File Offset: 0x010239DC
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

		// Token: 0x06042771 RID: 272241 RVA: 0x010258E4 File Offset: 0x01023AE4
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

		// Token: 0x06042772 RID: 272242 RVA: 0x01025964 File Offset: 0x01023B64
		private void RefreshSpine(string atlasPath, string skeletonPath, string spineAnim)
		{
			this.RefreshSpineAsync(atlasPath, skeletonPath, spineAnim).Forget();
		}

		// Token: 0x06042773 RID: 272243 RVA: 0x01025974 File Offset: 0x01023B74
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

		// Token: 0x06042774 RID: 272244 RVA: 0x010259D0 File Offset: 0x01023BD0
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

		// Token: 0x06042775 RID: 272245 RVA: 0x01025A23 File Offset: 0x01023C23
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

		// Token: 0x06042776 RID: 272246 RVA: 0x01025A55 File Offset: 0x01023C55
		public void PlaySpine()
		{
			this.PlaySpineAnim(this.SpineAnim);
		}

		// Token: 0x06042777 RID: 272247 RVA: 0x01025A64 File Offset: 0x01023C64
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

		// Token: 0x06042778 RID: 272248 RVA: 0x01025AA0 File Offset: 0x01023CA0
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
			this.PlaySpine();
		}

		// Token: 0x06042779 RID: 272249 RVA: 0x01025AAF File Offset: 0x01023CAF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0604277A RID: 272250 RVA: 0x01025AB8 File Offset: 0x01023CB8
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

		// Token: 0x0604277B RID: 272251 RVA: 0x01025AE2 File Offset: 0x01023CE2
		private bool OnCanExecuteChange()
		{
			Func<int, bool> isCurrentOccupation = this.IsCurrentOccupation;
			return isCurrentOccupation == null || !isCurrentOccupation(this.OccupationId);
		}

		// Token: 0x0604277C RID: 272252 RVA: 0x01025AFE File Offset: 0x01023CFE
		private void OnToggleClick(EToggleState state)
		{
			Action<int, int> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.OccupationId);
		}

		// Token: 0x04022A2C RID: 141868
		private int OccupationId;

		// Token: 0x04022A2D RID: 141869
		[Nullable(2)]
		public Action<int, int> OnClickToggleBack;

		// Token: 0x04022A2E RID: 141870
		[Nullable(2)]
		public Func<int, bool> IsCurrentOccupation;

		// Token: 0x04022A2F RID: 141871
		private string LoadedAtlasPath = "";

		// Token: 0x04022A30 RID: 141872
		private string LoadedSkeletonPath = "";

		// Token: 0x04022A31 RID: 141873
		private string SpineAnim = "";

		// Token: 0x04022A32 RID: 141874
		private bool IsLoading;

		// Token: 0x04022A33 RID: 141875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x04022A34 RID: 141876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0200C99C RID: 51612
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403CE42 RID: 249410
			SprRole,
			// Token: 0x0403CE43 RID: 249411
			TxtMainTitle,
			// Token: 0x0403CE44 RID: 249412
			TxtSubTitle,
			// Token: 0x0403CE45 RID: 249413
			TogItem,
			// Token: 0x0403CE46 RID: 249414
			SpineRole
		}
	}
}
