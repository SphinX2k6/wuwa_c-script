using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F6 RID: 9462
	public class ISetAreaTimeBase
	{
		// Token: 0x0600D344 RID: 54084 RVA: 0x001F53C4 File Offset: 0x001F35C4
		[NullableContext(1)]
		public static ISetAreaTimeBase Create(ISetAreaTimeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600D345 RID: 54085 RVA: 0x001F53E3 File Offset: 0x001F35E3
		public virtual ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x040073D4 RID: 29652
		private ISetAreaTimeBase Instance;
	}
}
