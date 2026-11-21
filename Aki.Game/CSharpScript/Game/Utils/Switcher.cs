using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200347C RID: 13436
	[NullableContext(1)]
	[Nullable(0)]
	public class Switcher
	{
		// Token: 0x0602248D RID: 140429 RVA: 0x009B7539 File Offset: 0x009B5739
		[NullableContext(2)]
		public Switcher(bool defaultActive, Action<bool> cb = null)
		{
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0602248E RID: 140430 RVA: 0x009B755A File Offset: 0x009B575A
		public bool Active
		{
			get
			{
				return this.Handlers.Count > 0 != this.<defaultActive>P;
			}
		}

		// Token: 0x0602248F RID: 140431 RVA: 0x009B7578 File Offset: 0x009B5778
		public void SetActive(object handler, bool active)
		{
			bool active2 = this.Active;
			if (this.<defaultActive>P != active)
			{
				this.Handlers.Add(handler);
			}
			else
			{
				this.Handlers.Remove(handler);
			}
			if (active2 != this.Active)
			{
				Action<bool> action = this.<cb>P;
				if (action == null)
				{
					return;
				}
				action(this.Active);
			}
		}

		// Token: 0x04012E20 RID: 77344
		[CompilerGenerated]
		private bool <defaultActive>P = defaultActive;

		// Token: 0x04012E21 RID: 77345
		[Nullable(2)]
		[CompilerGenerated]
		private Action<bool> <cb>P = cb;

		// Token: 0x04012E22 RID: 77346
		private readonly HashSet<object> Handlers = new HashSet<object>();
	}
}
