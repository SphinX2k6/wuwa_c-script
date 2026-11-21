using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003618 RID: 13848
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewStorage : Singleton
	{
		// Token: 0x06023415 RID: 144405 RVA: 0x00A0392C File Offset: 0x00A01B2C
		[NullableContext(2)]
		public UiTsInfo GetUiTsInfo(EUiViewName viewName)
		{
			UiTsInfo result;
			if (this.UiTsInfoMap.TryGetValue(viewName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06023416 RID: 144406 RVA: 0x00A0394C File Offset: 0x00A01B4C
		public unsafe void RegisterUiTsInfo(TUiTsInfo[] uiViewTsInfoList)
		{
			foreach (TUiTsInfo tuiTsInfo in uiViewTsInfoList)
			{
				EUiViewName viewName = tuiTsInfo.ViewName;
				try
				{
					UiTsInfo value = new UiTsInfo
					{
						Ctor = tuiTsInfo.CreateUiView,
						ResourceId = tuiTsInfo.ResourceId,
						SourceType = tuiTsInfo.SourceType
					};
					this.UiTsInfoMap[viewName] = value;
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiManager;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[RegisterUiTsInfo]流程执行异常 1";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("error", ex.Message);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", viewName);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x06023417 RID: 144407 RVA: 0x00A03A30 File Offset: 0x00A01C30
		public void RegisterUiViewInfoDynamicData([TupleElementNames(new string[]
		{
			"ViewName",
			"DynamicDataCtor"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1
		})] ValueTuple<EUiViewName, TViewInfoDynamicData>[] uiViewAbilitiesList)
		{
			foreach (ValueTuple<EUiViewName, TViewInfoDynamicData> valueTuple in uiViewAbilitiesList)
			{
				EUiViewName item = valueTuple.Item1;
				UiTsInfo uiTsInfo;
				if (!this.UiTsInfoMap.TryGetValue(item, out uiTsInfo))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCore;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[RegisterUiViewAbilities]界面信息不存在";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName", item);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					uiTsInfo.DynamicDataCtor = valueTuple.Item2;
				}
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06023418 RID: 144408 RVA: 0x00A03AAA File Offset: 0x00A01CAA
		public static UiViewStorage Instance
		{
			get
			{
				if (UiViewStorage._instance == null)
				{
					UiViewStorage._instance = new UiViewStorage();
					UiViewStorage._instance.OnInit();
				}
				return UiViewStorage._instance;
			}
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x00A03ACD File Offset: 0x00A01CCD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602341A RID: 144410 RVA: 0x00A03ACF File Offset: 0x00A01CCF
		public static void ResetStaticDefaultValue()
		{
			UiViewStorage instance = UiViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiViewStorage._instance = null;
		}

		// Token: 0x0602341B RID: 144411 RVA: 0x00A03AE8 File Offset: 0x00A01CE8
		static UiViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiViewStorage.CreateStaticDefaultValue), new Action(UiViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x04013E0B RID: 81419
		private readonly Dictionary<EUiViewName, UiTsInfo> UiTsInfoMap = new Dictionary<EUiViewName, UiTsInfo>();

		// Token: 0x04013E0C RID: 81420
		[Nullable(2)]
		private static UiViewStorage _instance;
	}
}
