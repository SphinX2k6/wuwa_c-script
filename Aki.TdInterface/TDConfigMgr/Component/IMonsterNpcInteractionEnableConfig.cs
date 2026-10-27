using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050A RID: 1290
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionEnableConfig
	{
		// Token: 0x06001A32 RID: 6706 RVA: 0x0004CA1C File Offset: 0x0004AC1C
		private IMonsterNpcInteractionEnableConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionEnableConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionEnableConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionEnableConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0004CA54 File Offset: 0x0004AC54
		public static IMonsterNpcInteractionEnableConfig Create([Nullable(2)] IMonsterNpcInteractionEnableConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionEnableConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0004CA67 File Offset: 0x0004AC67
		public static IMonsterNpcInteractionEnableConfig CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionEnableConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionEnableConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0004CA7A File Offset: 0x0004AC7A
		public IMonsterNpcInteractionEnableConfig_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionEnableConfig_SetValue
			{
				Interactions = this.Interactions
			};
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0004CA8D File Offset: 0x0004AC8D
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		public virtual List<IMonsterNpcInteractionConfig> Interactions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interactions;
				}
				IMonsterNpcInteractionEnableConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Interactions;
			}
			set
			{
				this.GetOrCreatePoco().Interactions = value;
			}
		}

		// Token: 0x0400130B RID: 4875
		[Nullable(2)]
		protected IMonsterNpcInteractionEnableConfig FbInstance;

		// Token: 0x0400130C RID: 4876
		[Nullable(2)]
		protected IMonsterNpcInteractionEnableConfig_SetValue PocoInterface;
	}
}
