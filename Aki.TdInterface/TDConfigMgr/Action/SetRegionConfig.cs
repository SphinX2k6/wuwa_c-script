using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243F RID: 9279
	public class SetRegionConfig : ActionParams
	{
		// Token: 0x0600CA0D RID: 51725 RVA: 0x001CDA70 File Offset: 0x001CBC70
		private SetRegionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetRegionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetRegionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetRegionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA0E RID: 51726 RVA: 0x001CDAA8 File Offset: 0x001CBCA8
		public static SetRegionConfig Create([Nullable(2)] SetRegionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x001CDABB File Offset: 0x001CBCBB
		public static SetRegionConfig CreateFromSetValue([Nullable(2)] SetRegionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x001CDACE File Offset: 0x001CBCCE
		public SetRegionConfig_SetValue ToSetValue()
		{
			return new SetRegionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x001CDAE1 File Offset: 0x001CBCE1
		// (set) Token: 0x0600CA12 RID: 51730 RVA: 0x001CDB0C File Offset: 0x001CBD0C
		public virtual ERegionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERegionConfigType.Mpc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040077E1 RID: 30689
		[Nullable(2)]
		protected new SetRegionConfig FbInstance;

		// Token: 0x040077E2 RID: 30690
		[Nullable(2)]
		protected SetRegionConfig_SetValue PocoInterface;
	}
}
