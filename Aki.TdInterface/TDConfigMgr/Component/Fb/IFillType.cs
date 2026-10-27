using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C88 RID: 3208
	public class IFillType
	{
		// Token: 0x06004969 RID: 18793 RVA: 0x000B80B7 File Offset: 0x000B62B7
		[NullableContext(1)]
		public static IFillType Create(IFillType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFillType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x000B80D6 File Offset: 0x000B62D6
		public virtual EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x040029DF RID: 10719
		private IFillType Instance;
	}
}
