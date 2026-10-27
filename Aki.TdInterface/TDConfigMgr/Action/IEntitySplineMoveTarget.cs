using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A14 RID: 6676
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntitySplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x06008F09 RID: 36617 RVA: 0x0014E428 File Offset: 0x0014C628
		[NullableContext(1)]
		private IEntitySplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntitySplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntitySplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntitySplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x0014E460 File Offset: 0x0014C660
		[NullableContext(1)]
		public static IEntitySplineMoveTarget Create([Nullable(2)] IEntitySplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x0014E473 File Offset: 0x0014C673
		[NullableContext(1)]
		public static IEntitySplineMoveTarget CreateFromSetValue([Nullable(2)] IEntitySplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x0014E486 File Offset: 0x0014C686
		[NullableContext(1)]
		public new IEntitySplineMoveTarget_SetValue ToSetValue()
		{
			return new IEntitySplineMoveTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				MoveDriveMode = this.MoveDriveMode
			};
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x06008F0D RID: 36621 RVA: 0x0014E4B1 File Offset: 0x0014C6B1
		// (set) Token: 0x06008F0E RID: 36622 RVA: 0x0014E4DC File Offset: 0x0014C6DC
		public override ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x06008F0F RID: 36623 RVA: 0x0014E4EA File Offset: 0x0014C6EA
		// (set) Token: 0x06008F10 RID: 36624 RVA: 0x0014E515 File Offset: 0x0014C715
		public virtual int EntityId
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

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x0014E523 File Offset: 0x0014C723
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x0014E54A File Offset: 0x0014C74A
		public virtual ISplineMoveDriveMode MoveDriveMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveDriveMode;
				}
				IEntitySplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveDriveMode;
			}
			set
			{
				this.GetOrCreatePoco().MoveDriveMode = value;
			}
		}

		// Token: 0x04005892 RID: 22674
		protected new IEntitySplineMoveTarget FbInstance;

		// Token: 0x04005893 RID: 22675
		protected new IEntitySplineMoveTarget_SetValue PocoInterface;
	}
}
