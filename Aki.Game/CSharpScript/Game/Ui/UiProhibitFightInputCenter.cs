using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004698 RID: 18072
	[NullableContext(1)]
	[Nullable(0)]
	public class UiProhibitFightInputCenter : Singleton
	{
		// Token: 0x0602E9C0 RID: 190912 RVA: 0x00ACAAF8 File Offset: 0x00AC8CF8
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

		// Token: 0x0602E9C1 RID: 190913 RVA: 0x00ACAB3C File Offset: 0x00AC8D3C
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

		// Token: 0x0602E9C2 RID: 190914 RVA: 0x00ACAB80 File Offset: 0x00AC8D80
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

		// Token: 0x0602E9C3 RID: 190915 RVA: 0x00ACABF0 File Offset: 0x00AC8DF0
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

		// Token: 0x17007632 RID: 30258
		// (get) Token: 0x0602E9C4 RID: 190916 RVA: 0x00ACAC10 File Offset: 0x00AC8E10
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

		// Token: 0x0602E9C5 RID: 190917 RVA: 0x00ACAC33 File Offset: 0x00AC8E33
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E9C6 RID: 190918 RVA: 0x00ACAC35 File Offset: 0x00AC8E35
		public static void ResetStaticDefaultValue()
		{
			UiProhibitFightInputCenter instance = UiProhibitFightInputCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiProhibitFightInputCenter._instance = null;
		}

		// Token: 0x0602E9C7 RID: 190919 RVA: 0x00ACAC4E File Offset: 0x00AC8E4E
		static UiProhibitFightInputCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiProhibitFightInputCenter.CreateStaticDefaultValue), new Action(UiProhibitFightInputCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401964C RID: 104012
		private readonly Dictionary<string, IUiProhibitRefreshData> ExtraUiProhibitRefreshDataMap = new Dictionary<string, IUiProhibitRefreshData>();

		// Token: 0x0401964D RID: 104013
		[Nullable(2)]
		private static UiProhibitFightInputCenter _instance;
	}
}
