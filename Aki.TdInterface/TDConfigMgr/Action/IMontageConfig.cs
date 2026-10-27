using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C00 RID: 7168
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageConfig
	{
		// Token: 0x0600997F RID: 39295 RVA: 0x001612CC File Offset: 0x0015F4CC
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

		// Token: 0x06009980 RID: 39296 RVA: 0x00161304 File Offset: 0x0015F504
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

		// Token: 0x06009981 RID: 39297 RVA: 0x00161317 File Offset: 0x0015F517
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

		// Token: 0x06009982 RID: 39298 RVA: 0x0016132A File Offset: 0x0015F52A
		public IMontageConfig_SetValue ToSetValue()
		{
			return new IMontageConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x0016133D File Offset: 0x0015F53D
		// (set) Token: 0x06009984 RID: 39300 RVA: 0x00161368 File Offset: 0x0015F568
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

		// Token: 0x04005D6F RID: 23919
		[Nullable(2)]
		protected IMontageConfig FbInstance;

		// Token: 0x04005D70 RID: 23920
		[Nullable(2)]
		protected IMontageConfig_SetValue PocoInterface;
	}
}
