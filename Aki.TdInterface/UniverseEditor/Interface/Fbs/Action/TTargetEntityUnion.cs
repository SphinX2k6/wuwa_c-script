using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008007 RID: 32775
	public class TTargetEntityUnion
	{
		// Token: 0x1700F327 RID: 62247
		// (get) Token: 0x0603AFB1 RID: 241585 RVA: 0x007EBA5E File Offset: 0x007E9C5E
		// (set) Token: 0x0603AFB2 RID: 241586 RVA: 0x007EBA66 File Offset: 0x007E9C66
		public TTargetEntity Type { get; set; }

		// Token: 0x1700F328 RID: 62248
		// (get) Token: 0x0603AFB3 RID: 241587 RVA: 0x007EBA6F File Offset: 0x007E9C6F
		// (set) Token: 0x0603AFB4 RID: 241588 RVA: 0x007EBA77 File Offset: 0x007E9C77
		public object Value { get; set; }

		// Token: 0x0603AFB5 RID: 241589 RVA: 0x007EBA80 File Offset: 0x007E9C80
		public TTargetEntityUnion()
		{
			this.Type = TTargetEntity.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFB6 RID: 241590 RVA: 0x007EBA96 File Offset: 0x007E9C96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFB7 RID: 241591 RVA: 0x007EBAA8 File Offset: 0x007E9CA8
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x0603AFB8 RID: 241592 RVA: 0x007EBAB0 File Offset: 0x007E9CB0
		public static TTargetEntityUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x0603AFB9 RID: 241593 RVA: 0x007EBAC5 File Offset: 0x007E9CC5
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x0603AFBA RID: 241594 RVA: 0x007EBACD File Offset: 0x007E9CCD
		public static TTargetEntityUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x0603AFBB RID: 241595 RVA: 0x007EBAE2 File Offset: 0x007E9CE2
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x0603AFBC RID: 241596 RVA: 0x007EBAEA File Offset: 0x007E9CEA
		public static TTargetEntityUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x0603AFBD RID: 241597 RVA: 0x007EBAFF File Offset: 0x007E9CFF
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x0603AFBE RID: 241598 RVA: 0x007EBB07 File Offset: 0x007E9D07
		public static TTargetEntityUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x0603AFBF RID: 241599 RVA: 0x007EBB1C File Offset: 0x007E9D1C
		public IVehicleEntityT AsIVehicleEntity()
		{
			return this.As<IVehicleEntityT>();
		}

		// Token: 0x0603AFC0 RID: 241600 RVA: 0x007EBB24 File Offset: 0x007E9D24
		public static TTargetEntityUnion FromIVehicleEntity(IVehicleEntityT _ivehicleentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IVehicleEntity,
				Value = _ivehicleentity
			};
		}

		// Token: 0x0603AFC1 RID: 241601 RVA: 0x007EBB3C File Offset: 0x007E9D3C
		public static int Pack(FlatBufferBuilder builder, TTargetEntityUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetEntity.IPlayerEntity:
				return IPlayerEntity.Pack(builder, _o.AsIPlayerEntity()).Value;
			case TTargetEntity.ISelfEntity:
				return ISelfEntity.Pack(builder, _o.AsISelfEntity()).Value;
			case TTargetEntity.ITargetEntity:
				return ITargetEntity.Pack(builder, _o.AsITargetEntity()).Value;
			case TTargetEntity.ITriggeredEntity:
				return ITriggeredEntity.Pack(builder, _o.AsITriggeredEntity()).Value;
			case TTargetEntity.IVehicleEntity:
				return IVehicleEntity.Pack(builder, _o.AsIVehicleEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
