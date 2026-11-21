using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DEF RID: 7663
	public class IMontageConfig
	{
		// Token: 0x0600A2AF RID: 41647 RVA: 0x00174218 File Offset: 0x00172418
		private IMontageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x00174250 File Offset: 0x00172450
		public static IMontageConfig Create([Nullable(2)] IMontageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x00174263 File Offset: 0x00172463
		public static IMontageConfig CreateFromSetValue([Nullable(2)] IMontageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x00174276 File Offset: 0x00172476
		public IMontageConfig_SetValue ToSetValue()
		{
			return new IMontageConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A2B3 RID: 41651 RVA: 0x00174289 File Offset: 0x00172489
		// (set) Token: 0x0600A2B4 RID: 41652 RVA: 0x001742B4 File Offset: 0x001724B4
		public virtual EMontageConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMontageConfigType.Asset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006296 RID: 25238
		[Nullable(2)]
		protected IMontageConfig FbInstance;

		// Token: 0x04006297 RID: 25239
		[Nullable(2)]
		protected IMontageConfig_SetValue PocoInterface;
	}
}
