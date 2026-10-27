using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C98 RID: 7320
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenGravity : ISetTeleControlConfig
	{
		// Token: 0x06009D13 RID: 40211 RVA: 0x00167F20 File Offset: 0x00166120
		private IOpenGravity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenGravity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenGravity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenGravity_SetValue());
			}
			return result;
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x00167F58 File Offset: 0x00166158
		public static IOpenGravity Create([Nullable(2)] IOpenGravity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x00167F6B File Offset: 0x0016616B
		public static IOpenGravity CreateFromSetValue([Nullable(2)] IOpenGravity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x00167F7E File Offset: 0x0016617E
		public new IOpenGravity_SetValue ToSetValue()
		{
			return new IOpenGravity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x00167FA9 File Offset: 0x001661A9
		// (set) Token: 0x06009D18 RID: 40216 RVA: 0x00167FD4 File Offset: 0x001661D4
		public override ESetTeleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009D19 RID: 40217 RVA: 0x00167FE2 File Offset: 0x001661E2
		// (set) Token: 0x06009D1A RID: 40218 RVA: 0x0016800D File Offset: 0x0016620D
		public override int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x0016801C File Offset: 0x0016621C
		// (set) Token: 0x06009D1C RID: 40220 RVA: 0x00168056 File Offset: 0x00166256
		public virtual int? PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				IOpenGravity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x04005F25 RID: 24357
		[Nullable(2)]
		protected new IOpenGravity FbInstance;

		// Token: 0x04005F26 RID: 24358
		[Nullable(2)]
		protected new IOpenGravity_SetValue PocoInterface;
	}
}
