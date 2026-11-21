using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C9 RID: 13769
	[NullableContext(1)]
	[Nullable(0)]
	public class UiProhibitFightInputCenter : Singleton
	{
		// Token: 0x0602310C RID: 143628 RVA: 0x009F93CC File Offset: 0x009F75CC
		public void RegisterExtraRefreshData(string tag, IUiProhibitRefreshData data)
		{
			this.ExtraUiProhibitRefreshDataMap[tag] = data;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注册禁止战斗输入额外的输入刷新数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602310D RID: 143629 RVA: 0x009F9410 File Offset: 0x009F7610
		public void UnRegisterExtraRefreshData(string tag)
		{
			this.ExtraUiProhibitRefreshDataMap.Remove(tag);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注销禁止战斗输入额外的输入刷新数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602310E RID: 143630 RVA: 0x009F9454 File Offset: 0x009F7654
		public string CheckExtraRefreshData()
		{
			foreach (KeyValuePair<string, IUiProhibitRefreshData> keyValuePair in this.ExtraUiProhibitRefreshDataMap)
			{
				string key = keyValuePair.Key;
				if (keyValuePair.Value.CheckCondition())
				{
					return key;
				}
			}
			return "";
		}

		// Token: 0x0602310F RID: 143631 RVA: 0x009F94C4 File Offset: 0x009F76C4
		[return: Nullable(2)]
		public IUiProhibitRefreshData GetExtraRefreshData(string tag)
		{
			IUiProhibitRefreshData result;
			if (this.ExtraUiProhibitRefreshDataMap.TryGetValue(tag, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06023110 RID: 143632 RVA: 0x009F94E4 File Offset: 0x009F76E4
		public static UiProhibitFightInputCenter Instance
		{
			get
			{
				if (UiProhibitFightInputCenter._instance == null)
				{
					UiProhibitFightInputCenter._instance = new UiProhibitFightInputCenter();
					UiProhibitFightInputCenter._instance.OnInit();
				}
				return UiProhibitFightInputCenter._instance;
			}
		}

		// Token: 0x06023111 RID: 143633 RVA: 0x009F9507 File Offset: 0x009F7707
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023112 RID: 143634 RVA: 0x009F9509 File Offset: 0x009F7709
		public static void ResetStaticDefaultValue()
		{
			UiProhibitFightInputCenter instance = UiProhibitFightInputCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiProhibitFightInputCenter._instance = null;
		}

		// Token: 0x06023113 RID: 143635 RVA: 0x009F9522 File Offset: 0x009F7722
		static UiProhibitFightInputCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiProhibitFightInputCenter.CreateStaticDefaultValue), new Action(UiProhibitFightInputCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04013CF1 RID: 81137
		private readonly Dictionary<string, IUiProhibitRefreshData> ExtraUiProhibitRefreshDataMap = new Dictionary<string, IUiProhibitRefreshData>();

		// Token: 0x04013CF2 RID: 81138
		[Nullable(2)]
		private static UiProhibitFightInputCenter _instance;
	}
}
