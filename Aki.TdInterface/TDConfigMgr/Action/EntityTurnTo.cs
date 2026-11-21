using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D2 RID: 6098
	public class EntityTurnTo : ActionParams
	{
		// Token: 0x060083C9 RID: 33737 RVA: 0x0013B1B4 File Offset: 0x001393B4
		private EntityTurnTo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityTurnTo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityTurnTo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityTurnTo_SetValue());
			}
			return result;
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0013B1EC File Offset: 0x001393EC
		public static EntityTurnTo Create([Nullable(2)] EntityTurnTo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityTurnTo
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0013B1FF File Offset: 0x001393FF
		public static EntityTurnTo CreateFromSetValue([Nullable(2)] EntityTurnTo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityTurnTo
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0013B212 File Offset: 0x00139412
		public EntityTurnTo_SetValue ToSetValue()
		{
			return new EntityTurnTo_SetValue
			{
				EntityId = this.EntityId,
				Target = this.Target,
				UseLookAtForSmallAngle = this.UseLookAtForSmallAngle
			};
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x060083CD RID: 33741 RVA: 0x0013B23D File Offset: 0x0013943D
		// (set) Token: 0x060083CE RID: 33742 RVA: 0x0013B268 File Offset: 0x00139468
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

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x060083CF RID: 33743 RVA: 0x0013B276 File Offset: 0x00139476
		// (set) Token: 0x060083D0 RID: 33744 RVA: 0x0013B29D File Offset: 0x0013949D
		public virtual IActorTurnToData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				EntityTurnTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x060083D1 RID: 33745 RVA: 0x0013B2AC File Offset: 0x001394AC
		// (set) Token: 0x060083D2 RID: 33746 RVA: 0x0013B2E6 File Offset: 0x001394E6
		public virtual bool? UseLookAtForSmallAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseLookAtForSmallAngle;
				}
				EntityTurnTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseLookAtForSmallAngle;
			}
			set
			{
				this.GetOrCreatePoco().UseLookAtForSmallAngle = value;
			}
		}

		// Token: 0x040050BC RID: 20668
		[Nullable(2)]
		protected new EntityTurnTo FbInstance;

		// Token: 0x040050BD RID: 20669
		[Nullable(2)]
		protected EntityTurnTo_SetValue PocoInterface;
	}
}
