using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02004212 RID: 16914
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBanButtonFunctionModule
	{
		// Token: 0x0602ABA2 RID: 175010 RVA: 0x00C07864 File Offset: 0x00C05A64
		private void RefreshButtonState(UUIButtonComponent button)
		{
			HashSet<string> hashSet;
			if (this.ButtonMap.TryGetValue(button, out hashSet))
			{
				if (hashSet != null && hashSet.Count > 0)
				{
					button.SetSelfInteractive(false);
					return;
				}
				button.SetSelfInteractive(true);
			}
		}

		// Token: 0x0602ABA3 RID: 175011 RVA: 0x00C0789C File Offset: 0x00C05A9C
		private void OnBanButton(UUIButtonComponent button, string reason)
		{
			HashSet<string> hashSet;
			if (this.ButtonMap.TryGetValue(button, out hashSet) && hashSet != null)
			{
				hashSet.Add(reason);
				this.RefreshButtonState(button);
			}
		}

		// Token: 0x0602ABA4 RID: 175012 RVA: 0x00C078CC File Offset: 0x00C05ACC
		private void OnResumeButton(UUIButtonComponent button, string reason)
		{
			HashSet<string> hashSet;
			if (this.ButtonMap.TryGetValue(button, out hashSet) && hashSet != null)
			{
				hashSet.Remove(reason);
				this.RefreshButtonState(button);
			}
		}

		// Token: 0x0602ABA5 RID: 175013 RVA: 0x00C078FB File Offset: 0x00C05AFB
		public void RegisterButton(UUIButtonComponent button)
		{
			this.ButtonMap[button] = new HashSet<string>();
		}

		// Token: 0x0602ABA6 RID: 175014 RVA: 0x00C07910 File Offset: 0x00C05B10
		public void BanButton(UUIButtonComponent button, string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "外部禁用单个按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnBanButton(button, reason);
		}

		// Token: 0x0602ABA7 RID: 175015 RVA: 0x00C07950 File Offset: 0x00C05B50
		public void ResumeButton(UUIButtonComponent button, string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "外部恢复单个按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnResumeButton(button, reason);
		}

		// Token: 0x0602ABA8 RID: 175016 RVA: 0x00C07990 File Offset: 0x00C05B90
		public void BanButtonList(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "外部禁用全部按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (UUIButtonComponent button in this.ButtonMap.Keys)
			{
				this.OnBanButton(button, reason);
			}
		}

		// Token: 0x0602ABA9 RID: 175017 RVA: 0x00C07A14 File Offset: 0x00C05C14
		public void ResumeButtonList(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "外部恢复全部按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (UUIButtonComponent button in this.ButtonMap.Keys)
			{
				this.OnResumeButton(button, reason);
			}
		}

		// Token: 0x0401728F RID: 94863
		protected Dictionary<UUIButtonComponent, HashSet<string>> ButtonMap = new Dictionary<UUIButtonComponent, HashSet<string>>();
	}
}
