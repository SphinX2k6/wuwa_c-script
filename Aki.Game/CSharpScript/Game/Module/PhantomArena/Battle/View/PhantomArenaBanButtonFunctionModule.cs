using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005242 RID: 21058
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBanButtonFunctionModule
	{
		// Token: 0x06035CA7 RID: 220327 RVA: 0x00CBA224 File Offset: 0x00CB8424
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

		// Token: 0x06035CA8 RID: 220328 RVA: 0x00CBA25C File Offset: 0x00CB845C
		private void OnBanButton(UUIButtonComponent button, string reason)
		{
			HashSet<string> hashSet;
			if (this.ButtonMap.TryGetValue(button, out hashSet) && hashSet != null)
			{
				hashSet.Add(reason);
				this.RefreshButtonState(button);
			}
		}

		// Token: 0x06035CA9 RID: 220329 RVA: 0x00CBA28C File Offset: 0x00CB848C
		private void OnResumeButton(UUIButtonComponent button, string reason)
		{
			HashSet<string> hashSet;
			if (this.ButtonMap.TryGetValue(button, out hashSet) && hashSet != null)
			{
				hashSet.Remove(reason);
				this.RefreshButtonState(button);
			}
		}

		// Token: 0x06035CAA RID: 220330 RVA: 0x00CBA2BB File Offset: 0x00CB84BB
		public void RegisterButton(UUIButtonComponent button)
		{
			this.ButtonMap[button] = new HashSet<string>();
		}

		// Token: 0x06035CAB RID: 220331 RVA: 0x00CBA2D0 File Offset: 0x00CB84D0
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

		// Token: 0x06035CAC RID: 220332 RVA: 0x00CBA310 File Offset: 0x00CB8510
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

		// Token: 0x06035CAD RID: 220333 RVA: 0x00CBA350 File Offset: 0x00CB8550
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

		// Token: 0x06035CAE RID: 220334 RVA: 0x00CBA3D4 File Offset: 0x00CB85D4
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

		// Token: 0x0401C85A RID: 116826
		protected Dictionary<UUIButtonComponent, HashSet<string>> ButtonMap = new Dictionary<UUIButtonComponent, HashSet<string>>();
	}
}
