using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200358E RID: 13710
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewSetContainer : UiViewContainer
	{
		// Token: 0x06022F54 RID: 143188 RVA: 0x009EBF44 File Offset: 0x009EA144
		public UiViewSetContainer(Dictionary<EUiViewName, UiViewBase> map)
		{
			this.Map = map;
		}

		// Token: 0x06022F55 RID: 143189 RVA: 0x009EBF54 File Offset: 0x009EA154
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

		// Token: 0x06022F56 RID: 143190 RVA: 0x009EBFA0 File Offset: 0x009EA1A0
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

		// Token: 0x06022F57 RID: 143191 RVA: 0x009EBFEC File Offset: 0x009EA1EC
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

		// Token: 0x06022F58 RID: 143192 RVA: 0x009EC0B4 File Offset: 0x009EA2B4
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewSetContainer.<PreOpenViewAsync>d__5 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewSetContainer.<PreOpenViewAsync>d__5>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F59 RID: 143193 RVA: 0x009EC0F8 File Offset: 0x009EA2F8
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewSetContainer.<OpenViewAfterPreOpenedAsync>d__6 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewSetContainer.<OpenViewAfterPreOpenedAsync>d__6>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04013496 RID: 78998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Dictionary<EUiViewName, UiViewBase> Map;
	}
}
