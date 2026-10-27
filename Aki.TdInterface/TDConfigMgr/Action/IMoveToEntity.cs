using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C38 RID: 7224
	[NullableContext(2)]
	[Nullable(0)]
	public class IMoveToEntity : IMoveSceneItemType
	{
		// Token: 0x06009AF7 RID: 39671 RVA: 0x00164278 File Offset: 0x00162478
		[NullableContext(1)]
		private IMoveToEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveToEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveToEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveToEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x001642B0 File Offset: 0x001624B0
		[NullableContext(1)]
		public static IMoveToEntity Create([Nullable(2)] IMoveToEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveToEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x001642C3 File Offset: 0x001624C3
		[NullableContext(1)]
		public static IMoveToEntity CreateFromSetValue([Nullable(2)] IMoveToEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveToEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x001642D6 File Offset: 0x001624D6
		[NullableContext(1)]
		public new IMoveToEntity_SetValue ToSetValue()
		{
			return new IMoveToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				MoveMotion = this.MoveMotion
			};
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06009AFB RID: 39675 RVA: 0x00164301 File Offset: 0x00162501
		// (set) Token: 0x06009AFC RID: 39676 RVA: 0x0016432C File Offset: 0x0016252C
		public override EMoveSceneItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x0016433A File Offset: 0x0016253A
		// (set) Token: 0x06009AFE RID: 39678 RVA: 0x00164365 File Offset: 0x00162565
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

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x00164373 File Offset: 0x00162573
		// (set) Token: 0x06009B00 RID: 39680 RVA: 0x0016439A File Offset: 0x0016259A
		public virtual ISceneItemMoveMotionType MoveMotion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveMotion;
				}
				IMoveToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveMotion;
			}
			set
			{
				this.GetOrCreatePoco().MoveMotion = value;
			}
		}

		// Token: 0x04005E2F RID: 24111
		protected new IMoveToEntity FbInstance;

		// Token: 0x04005E30 RID: 24112
		protected new IMoveToEntity_SetValue PocoInterface;
	}
}
