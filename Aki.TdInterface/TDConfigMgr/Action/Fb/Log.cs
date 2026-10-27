using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F1 RID: 9457
	[NullableContext(1)]
	[Nullable(0)]
	public class Log : ActionParams
	{
		// Token: 0x0600D332 RID: 54066 RVA: 0x001F5299 File Offset: 0x001F3499
		public static Log Create(ILog? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Log
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600D333 RID: 54067 RVA: 0x001F52B8 File Offset: 0x001F34B8
		public virtual string Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600D334 RID: 54068 RVA: 0x001F52C5 File Offset: 0x001F34C5
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x040073CF RID: 29647
		private ILog Instance;
	}
}
