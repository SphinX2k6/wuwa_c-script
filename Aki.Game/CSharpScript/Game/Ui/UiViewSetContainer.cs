using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200465D RID: 18013
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewSetContainer : UiViewContainer
	{
		// Token: 0x0602E80A RID: 190474 RVA: 0x00ABE8C4 File Offset: 0x00ABCAC4
		public UiViewSetContainer(Dictionary<EUiViewName, UiViewBase> map)
		{
			this.Map = map;
		}

		// Token: 0x0602E80B RID: 190475 RVA: 0x00ABE8D4 File Offset: 0x00ABCAD4
		[NullableContext(0)]
		public override UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view)
		{
			UiViewSetContainer.<OpenViewAsync>d__2 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.view = view;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiViewSetContainer.<OpenViewAsync>d__2>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E80C RID: 190476 RVA: 0x00ABE920 File Offset: 0x00ABCB20
		public override UniTask CloseViewAsync(UiViewBase view)
		{
			UiViewSetContainer.<CloseViewAsync>d__3 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.view = view;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiViewSetContainer.<CloseViewAsync>d__3>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E80D RID: 190477 RVA: 0x00ABE96C File Offset: 0x00ABCB6C
		public override void ClearContainer(bool isSeamlessTravel)
		{
			List<EUiViewName> list = new List<EUiViewName>();
			foreach (KeyValuePair<EUiViewName, UiViewBase> keyValuePair in this.Map)
			{
				UiViewBase value = keyValuePair.Value;
				value.IsExistInLeaveLevel = true;
				if (!value.ViewInfo.IsPermanent)
				{
					base.TryCatchViewDestroyCompatible(value);
					list.Add(keyValuePair.Key);
				}
			}
			foreach (EUiViewName key in list)
			{
				this.Map.Remove(key);
			}
		}

		// Token: 0x0602E80E RID: 190478 RVA: 0x00ABEA34 File Offset: 0x00ABCC34
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewSetContainer.<PreOpenViewAsync>d__5 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewSetContainer.<PreOpenViewAsync>d__5>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E80F RID: 190479 RVA: 0x00ABEA78 File Offset: 0x00ABCC78
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewSetContainer.<OpenViewAfterPreOpenedAsync>d__6 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewSetContainer.<OpenViewAfterPreOpenedAsync>d__6>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04018E3D RID: 101949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Dictionary<EUiViewName, UiViewBase> Map;
	}
}
