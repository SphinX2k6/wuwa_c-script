using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002888 RID: 10376
	public class IMontageConfig
	{
		// Token: 0x0600E5E0 RID: 58848 RVA: 0x0021CACF File Offset: 0x0021ACCF
		[NullableContext(1)]
		public static IMontageConfig Create(IMontageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x0600E5E1 RID: 58849 RVA: 0x0021CAEE File Offset: 0x0021ACEE
		public virtual EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04007F18 RID: 32536
		private IMontageConfig Instance;
	}
}
