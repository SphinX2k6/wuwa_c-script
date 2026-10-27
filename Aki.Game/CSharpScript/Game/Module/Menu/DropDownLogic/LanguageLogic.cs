using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02005470 RID: 21616
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageLogic : DropDownLogicBase
	{
		// Token: 0x060372C2 RID: 225986 RVA: 0x00D15B00 File Offset: 0x00D13D00
		public override IReadOnlyList<object> GetDropDownDataList()
		{
			List<global::LanguageDefine> list = new List<global::LanguageDefine>();
			this.LanguageDefineTypeIndexMap.Clear();
			Dictionary<int, int> languageSortIdMap = new Dictionary<int, int>();
			int targetConfig = MenuController.Instance.GetTargetConfig(EFunction.TEXTLANGUAGE);
			foreach (global::LanguageDefine languageDefine in MenuTool.GetLanguageDefineData())
			{
				int languageType = languageDefine.LanguageType;
				Aki.Config.LanguageDefine? languageDefineById = LanguageConfig.Instance.GetLanguageDefineById(languageType);
				if (languageDefineById == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.TextLanguageSearch;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "设置系统语言定义不存在,请检查s.设置系统 LanguageDefine";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("语言类型Id", languageType);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (languageType == targetConfig || languageDefineById.Value.IsShow)
				{
					list.Add(languageDefine);
					languageSortIdMap[languageType] = languageDefineById.Value.SortId;
				}
			}
			list.Sort(delegate(global::LanguageDefine a, global::LanguageDefine b)
			{
				int num;
				if (!languageSortIdMap.TryGetValue(a.LanguageType, out num))
				{
					num = 0;
				}
				int num2;
				if (!languageSortIdMap.TryGetValue(b.LanguageType, out num2))
				{
					num2 = 0;
				}
				return num - num2;
			});
			for (int i = 0; i < list.Count; i++)
			{
				this.LanguageDefineTypeIndexMap[list[i].LanguageType] = i;
			}
			return list.Cast<object>().ToList<object>();
		}

		// Token: 0x060372C3 RID: 225987 RVA: 0x00D15C5C File Offset: 0x00D13E5C
		public override TableTextArgNew GetDataTextId(object data, MenuData menuData)
		{
			global::LanguageDefine languageDefine = (global::LanguageDefine)data;
			return new TableTextArgNew(menuData.OptionsNameList[languageDefine.LanguageType], Array.Empty<object>());
		}

		// Token: 0x060372C4 RID: 225988 RVA: 0x00D15C8C File Offset: 0x00D13E8C
		public unsafe override void TriggerSelectChange(object data, MenuData menuData)
		{
			int targetConfig = MenuController.Instance.GetTargetConfig(menuData.FunctionId);
			global::LanguageDefine languageDefine = (global::LanguageDefine)data;
			if (targetConfig == languageDefine.LanguageType)
			{
				return;
			}
			GameSettingsManager.Instance.HandleValueChange(menuData.FunctionId, languageDefine.LanguageType, EGameSettingsApplyReason.WhenUi);
			MenuModel.Instance.IsEdited = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TextLanguageSearch;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "设置语言";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("选择语言", GameSettingsManager.Instance.GetLanguageCodeById(languageDefine.LanguageType));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实际语言", LanguageSystem.Instance.PackageLanguage);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060372C5 RID: 225989 RVA: 0x00D15D4C File Offset: 0x00D13F4C
		public override int GetDefaultIndex(MenuData menuData)
		{
			int targetConfig = MenuController.Instance.GetTargetConfig(menuData.FunctionId);
			int result;
			if (!this.LanguageDefineTypeIndexMap.TryGetValue(targetConfig, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0401D1A5 RID: 119205
		private readonly Dictionary<int, int> LanguageDefineTypeIndexMap = new Dictionary<int, int>();
	}
}
