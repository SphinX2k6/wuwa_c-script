using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF4 RID: 24052
	public struct IGravityDirectionByEntityGravity : IFlatbufferObject
	{
		// Token: 0x1700B3FF RID: 46079
		// (get) Token: 0x060292BA RID: 168634 RVA: 0x005A6302 File Offset: 0x005A4502
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292BB RID: 168635 RVA: 0x005A630F File Offset: 0x005A450F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292BC RID: 168636 RVA: 0x005A6318 File Offset: 0x005A4518
		public static IGravityDirectionByEntityGravity GetRootAsIGravityDirectionByEntityGravity(ByteBuffer _bb)
		{
			return IGravityDirectionByEntityGravity.GetRootAsIGravityDirectionByEntityGravity(_bb, default(IGravityDirectionByEntityGravity));
		}

		// Token: 0x060292BD RID: 168637 RVA: 0x005A6334 File Offset: 0x005A4534
		public static IGravityDirectionByEntityGravity GetRootAsIGravityDirectionByEntityGravity(ByteBuffer _bb, IGravityDirectionByEntityGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292BE RID: 168638 RVA: 0x005A6351 File Offset: 0x005A4551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292BF RID: 168639 RVA: 0x005A6360 File Offset: 0x005A4560
		public IGravityDirectionByEntityGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B400 RID: 46080
		// (get) Token: 0x060292C0 RID: 168640 RVA: 0x005A6370 File Offset: 0x005A4570
		public EGravityDirectionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGravityDirectionType.SelfRotation;
				}
				return (EGravityDirectionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B401 RID: 46081
		// (get) Token: 0x060292C1 RID: 168641 RVA: 0x005A63AC File Offset: 0x005A45AC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060292C2 RID: 168642 RVA: 0x005A63E8 File Offset: 0x005A45E8
		public static Offset<IGravityDirectionByEntityGravity> CreateIGravityDirectionByEntityGravity(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, int EntityId = 0)
		{
			builder.StartTable(2);
			IGravityDirectionByEntityGravity.AddEntityId(builder, EntityId);
			IGravityDirectionByEntityGravity.AddType(builder, Type);
			return IGravityDirectionByEntityGravity.EndIGravityDirectionByEntityGravity(builder);
		}

		// Token: 0x060292C3 RID: 168643 RVA: 0x005A6405 File Offset: 0x005A4605
		public static void StartIGravityDirectionByEntityGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060292C4 RID: 168644 RVA: 0x005A640E File Offset: 0x005A460E
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060292C5 RID: 168645 RVA: 0x005A6419 File Offset: 0x005A4619
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060292C6 RID: 168646 RVA: 0x005A6424 File Offset: 0x005A4624
		public static Offset<IGravityDirectionByEntityGravity> EndIGravityDirectionByEntityGravity(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionByEntityGravity>(builder.EndTable());
		}

		// Token: 0x060292C7 RID: 168647 RVA: 0x005A6434 File Offset: 0x005A4634
		public IGravityDirectionByEntityGravityT UnPack()
		{
			IGravityDirectionByEntityGravityT gravityDirectionByEntityGravityT = new IGravityDirectionByEntityGravityT();
			this.UnPackTo(gravityDirectionByEntityGravityT);
			return gravityDirectionByEntityGravityT;
		}

		// Token: 0x060292C8 RID: 168648 RVA: 0x005A644F File Offset: 0x005A464F
		public void UnPackTo(IGravityDirectionByEntityGravityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060292C9 RID: 168649 RVA: 0x005A646C File Offset: 0x005A466C
		public static Offset<IGravityDirectionByEntityGravity> Pack(FlatBufferBuilder builder, IGravityDirectionByEntityGravityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionByEntityGravity>);
			}
			return IGravityDirectionByEntityGravity.CreateIGravityDirectionByEntityGravity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400F7E2 RID: 63458
		private Table __p;
	}
}
