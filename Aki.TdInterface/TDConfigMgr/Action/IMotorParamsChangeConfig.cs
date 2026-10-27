using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C1C RID: 7196
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorParamsChangeConfig
	{
		// Token: 0x06009A6B RID: 39531 RVA: 0x00163364 File Offset: 0x00161564
		private IMotorParamsChangeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorParamsChangeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorParamsChangeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorParamsChangeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x0016339C File Offset: 0x0016159C
		public static IMotorParamsChangeConfig Create([Nullable(2)] IMotorParamsChangeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorParamsChangeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x001633AF File Offset: 0x001615AF
		public static IMotorParamsChangeConfig CreateFromSetValue([Nullable(2)] IMotorParamsChangeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorParamsChangeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x001633C2 File Offset: 0x001615C2
		public IMotorParamsChangeConfig_SetValue ToSetValue()
		{
			return new IMotorParamsChangeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x06009A6F RID: 39535 RVA: 0x001633D5 File Offset: 0x001615D5
		// (set) Token: 0x06009A70 RID: 39536 RVA: 0x00163400 File Offset: 0x00161600
		public virtual EMotorParamsChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorParamsChangeType.SpeedUp;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005DEF RID: 24047
		[Nullable(2)]
		protected IMotorParamsChangeConfig FbInstance;

		// Token: 0x04005DF0 RID: 24048
		[Nullable(2)]
		protected IMotorParamsChangeConfig_SetValue PocoInterface;
	}
}
