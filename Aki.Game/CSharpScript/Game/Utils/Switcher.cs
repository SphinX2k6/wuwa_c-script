using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004554 RID: 17748
	[NullableContext(1)]
	[Nullable(0)]
	public class Switcher
	{
		// Token: 0x0602DDAB RID: 187819 RVA: 0x00A8BE21 File Offset: 0x00A8A021
		[NullableContext(2)]
		public Switcher(bool defaultActive, Action<bool> cb = null)
		{
		}

		// Token: 0x17007554 RID: 30036
		// (get) Token: 0x0602DDAC RID: 187820 RVA: 0x00A8BE42 File Offset: 0x00A8A042
		public bool Active
		{
			get
			{
				return this.Handlers.Count > 0 != this.<defaultActive>P;
			}
		}

		// Token: 0x0602DDAD RID: 187821 RVA: 0x00A8BE60 File Offset: 0x00A8A060
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

		// Token: 0x040187E6 RID: 100326
		[CompilerGenerated]
		private bool <defaultActive>P = defaultActive;

		// Token: 0x040187E7 RID: 100327
		[Nullable(2)]
		[CompilerGenerated]
		private Action<bool> <cb>P = cb;

		// Token: 0x040187E8 RID: 100328
		private readonly HashSet<object> Handlers = new HashSet<object>();
	}
}
