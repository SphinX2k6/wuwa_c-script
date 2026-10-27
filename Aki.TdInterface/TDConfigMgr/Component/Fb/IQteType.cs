using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7C RID: 3452
	public class IQteType
	{
		// Token: 0x06004E8C RID: 20108 RVA: 0x000C2DF5 File Offset: 0x000C0FF5
		[NullableContext(1)]
		public static IQteType Create(IQteType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x000C2E14 File Offset: 0x000C1014
		public virtual EQteType Type
		{
			get
			{
				return (EQteType)this.Instance.Type;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x000C2E21 File Offset: 0x000C1021
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x04002D17 RID: 11543
		private IQteType Instance;
	}
}
