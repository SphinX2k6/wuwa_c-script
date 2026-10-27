using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5C RID: 2652
	public class ITempleGuid
	{
		// Token: 0x06003D13 RID: 15635 RVA: 0x0009D0D9 File Offset: 0x0009B2D9
		[NullableContext(1)]
		public static ITempleGuid Create(ITempleGuid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x0009D0F8 File Offset: 0x0009B2F8
		public virtual int TempleGuid
		{
			get
			{
				return this.Instance.TempleGuid;
			}
		}

		// Token: 0x04002207 RID: 8711
		private ITempleGuid Instance;
	}
}
