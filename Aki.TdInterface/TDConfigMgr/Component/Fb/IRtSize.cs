using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E30 RID: 3632
	public class IRtSize
	{
		// Token: 0x0600521D RID: 21021 RVA: 0x000CA57B File Offset: 0x000C877B
		[NullableContext(1)]
		public static IRtSize Create(IRtSize? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRtSize
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x000CA59A File Offset: 0x000C879A
		public virtual int Length
		{
			get
			{
				return this.Instance.Length;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x000CA5A7 File Offset: 0x000C87A7
		public virtual int Width
		{
			get
			{
				return this.Instance.Width;
			}
		}

		// Token: 0x04002F4D RID: 12109
		private IRtSize Instance;
	}
}
