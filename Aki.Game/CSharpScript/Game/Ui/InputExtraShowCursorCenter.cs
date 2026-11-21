using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E0 RID: 13792
	[NullableContext(1)]
	[Nullable(0)]
	public class InputExtraShowCursorCenter : Singleton
	{
		// Token: 0x060231C7 RID: 143815 RVA: 0x009FAB04 File Offset: 0x009F8D04
		public void RegisterExtraRefreshData(string tag, IExtraShowCursor data)
		{
			this.ExtraShowCursorDataMap[tag] = data;
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注册额外的显示鼠标数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060231C8 RID: 143816 RVA: 0x009FAB58 File Offset: 0x009F8D58
		public void UnRegisterExtraRefreshData(string tag)
		{
			this.ExtraShowCursorDataMap.Remove(tag);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "注销额外的显示鼠标数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060231C9 RID: 143817 RVA: 0x009FAB9C File Offset: 0x009F8D9C
		public bool CheckShowCursorData()
		{
			using (Dictionary<string, IExtraShowCursor>.ValueCollection.Enumerator enumerator = this.ExtraShowCursorDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsShowCursor())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060231CA RID: 143818 RVA: 0x009FABFC File Offset: 0x009F8DFC
		public bool HasExtraShowCursorData()
		{
			return this.ExtraShowCursorDataMap.Count > 0;
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x060231CB RID: 143819 RVA: 0x009FAC0C File Offset: 0x009F8E0C
		public static InputExtraShowCursorCenter Instance
		{
			get
			{
				if (InputExtraShowCursorCenter._instance == null)
				{
					InputExtraShowCursorCenter._instance = new InputExtraShowCursorCenter();
					InputExtraShowCursorCenter._instance.OnInit();
				}
				return InputExtraShowCursorCenter._instance;
			}
		}

		// Token: 0x060231CC RID: 143820 RVA: 0x009FAC2F File Offset: 0x009F8E2F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060231CD RID: 143821 RVA: 0x009FAC31 File Offset: 0x009F8E31
		public static void ResetStaticDefaultValue()
		{
			InputExtraShowCursorCenter instance = InputExtraShowCursorCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputExtraShowCursorCenter._instance = null;
		}

		// Token: 0x060231CE RID: 143822 RVA: 0x009FAC4A File Offset: 0x009F8E4A
		static InputExtraShowCursorCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputExtraShowCursorCenter.CreateStaticDefaultValue), new Action(InputExtraShowCursorCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04013D3B RID: 81211
		private readonly Dictionary<string, IExtraShowCursor> ExtraShowCursorDataMap = new Dictionary<string, IExtraShowCursor>();

		// Token: 0x04013D3C RID: 81212
		[Nullable(2)]
		private static InputExtraShowCursorCenter _instance;
	}
}
