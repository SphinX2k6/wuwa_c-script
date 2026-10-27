using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001662 RID: 5730
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityTurnTo : ActionParams
	{
		// Token: 0x06007CEB RID: 31979 RVA: 0x0012C108 File Offset: 0x0012A308
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

		// Token: 0x06007CEC RID: 31980 RVA: 0x0012C140 File Offset: 0x0012A340
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

		// Token: 0x06007CED RID: 31981 RVA: 0x0012C153 File Offset: 0x0012A353
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

		// Token: 0x06007CEE RID: 31982 RVA: 0x0012C166 File Offset: 0x0012A366
		public EntityTurnTo_SetValue ToSetValue()
		{
			return new EntityTurnTo_SetValue
			{
				EntityId = this.EntityId,
				Target = this.Target,
				UseLookAtForSmallAngle = this.UseLookAtForSmallAngle
			};
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x06007CEF RID: 31983 RVA: 0x0012C191 File Offset: 0x0012A391
		// (set) Token: 0x06007CF0 RID: 31984 RVA: 0x0012C1BC File Offset: 0x0012A3BC
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

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x06007CF1 RID: 31985 RVA: 0x0012C1CA File Offset: 0x0012A3CA
		// (set) Token: 0x06007CF2 RID: 31986 RVA: 0x0012C1F1 File Offset: 0x0012A3F1
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

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x06007CF3 RID: 31987 RVA: 0x0012C200 File Offset: 0x0012A400
		// (set) Token: 0x06007CF4 RID: 31988 RVA: 0x0012C23A File Offset: 0x0012A43A
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

		// Token: 0x04004CC1 RID: 19649
		[Nullable(2)]
		protected new EntityTurnTo FbInstance;

		// Token: 0x04004CC2 RID: 19650
		[Nullable(2)]
		protected EntityTurnTo_SetValue PocoInterface;
	}
}
