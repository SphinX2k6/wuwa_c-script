using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004453 RID: 17491
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageLogic : DropDownLogicBase
	{
		// Token: 0x0602C20B RID: 180747 RVA: 0x00C64F18 File Offset: 0x00C63118
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
			List<object> list2 = new List<object>(list.Count);
			foreach (global::LanguageDefine item in list)
			{
				list2.Add(item);
			}
			return list2;
		}

		// Token: 0x0602C20C RID: 180748 RVA: 0x00C650B4 File Offset: 0x00C632B4
		public override TableTextArgNew GetDataTextId(object data, MenuData menuData)
		{
			global::LanguageDefine languageDefine = (global::LanguageDefine)data;
			return new TableTextArgNew(menuData.OptionsNameList[languageDefine.LanguageType], Array.Empty<object>());
		}

		// Token: 0x0602C20D RID: 180749 RVA: 0x00C650E4 File Offset: 0x00C632E4
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

		// Token: 0x0602C20E RID: 180750 RVA: 0x00C651A4 File Offset: 0x00C633A4
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

		// Token: 0x04017C3E RID: 97342
		private readonly Dictionary<int, int> LanguageDefineTypeIndexMap = new Dictionary<int, int>();
	}
}
