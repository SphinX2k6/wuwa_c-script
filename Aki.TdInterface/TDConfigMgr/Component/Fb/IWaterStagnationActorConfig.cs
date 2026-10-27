using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2A RID: 3626
	public class IWaterStagnationActorConfig
	{
		// Token: 0x060051FC RID: 20988 RVA: 0x000CA06E File Offset: 0x000C826E
		[NullableContext(1)]
		public static IWaterStagnationActorConfig Create(IWaterStagnationActorConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaterStagnationActorConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x000CA08D File Offset: 0x000C828D
		public virtual int SeqRefEntity
		{
			get
			{
				return this.Instance.SeqRefEntity;
			}
		}

		// Token: 0x04002F39 RID: 12089
		private IWaterStagnationActorConfig Instance;
	}
}
