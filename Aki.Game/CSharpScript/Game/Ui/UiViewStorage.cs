using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E8 RID: 18152
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewStorage : Singleton
	{
		// Token: 0x0602ECDA RID: 191706 RVA: 0x00AD5E54 File Offset: 0x00AD4054
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

		// Token: 0x0602ECDB RID: 191707 RVA: 0x00AD5E74 File Offset: 0x00AD4074
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

		// Token: 0x0602ECDC RID: 191708 RVA: 0x00AD5F58 File Offset: 0x00AD4158
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

		// Token: 0x17007687 RID: 30343
		// (get) Token: 0x0602ECDD RID: 191709 RVA: 0x00AD5FD2 File Offset: 0x00AD41D2
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

		// Token: 0x0602ECDE RID: 191710 RVA: 0x00AD5FF5 File Offset: 0x00AD41F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602ECDF RID: 191711 RVA: 0x00AD5FF7 File Offset: 0x00AD41F7
		public static void ResetStaticDefaultValue()
		{
			UiViewStorage instance = UiViewStorage._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiViewStorage._instance = null;
		}

		// Token: 0x0602ECE0 RID: 191712 RVA: 0x00AD6010 File Offset: 0x00AD4210
		static UiViewStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiViewStorage.CreateStaticDefaultValue), new Action(UiViewStorage.ResetStaticDefaultValue));
		}

		// Token: 0x0401976D RID: 104301
		private readonly Dictionary<EUiViewName, UiTsInfo> UiTsInfoMap = new Dictionary<EUiViewName, UiTsInfo>();

		// Token: 0x0401976E RID: 104302
		[Nullable(2)]
		private static UiViewStorage _instance;
	}
}
