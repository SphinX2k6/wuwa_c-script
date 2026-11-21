using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006431 RID: 25649
	public struct IGravityDirectionByEntityGravity : IFlatbufferObject
	{
		// Token: 0x1700BD65 RID: 48485
		// (get) Token: 0x0602B944 RID: 178500 RVA: 0x005EF032 File Offset: 0x005ED232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B945 RID: 178501 RVA: 0x005EF03F File Offset: 0x005ED23F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B946 RID: 178502 RVA: 0x005EF048 File Offset: 0x005ED248
		public static IGravityDirectionByEntityGravity GetRootAsIGravityDirectionByEntityGravity(ByteBuffer _bb)
		{
			return IGravityDirectionByEntityGravity.GetRootAsIGravityDirectionByEntityGravity(_bb, default(IGravityDirectionByEntityGravity));
		}

		// Token: 0x0602B947 RID: 178503 RVA: 0x005EF064 File Offset: 0x005ED264
		public static IGravityDirectionByEntityGravity GetRootAsIGravityDirectionByEntityGravity(ByteBuffer _bb, IGravityDirectionByEntityGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B948 RID: 178504 RVA: 0x005EF081 File Offset: 0x005ED281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B949 RID: 178505 RVA: 0x005EF090 File Offset: 0x005ED290
		public IGravityDirectionByEntityGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD66 RID: 48486
		// (get) Token: 0x0602B94A RID: 178506 RVA: 0x005EF0A0 File Offset: 0x005ED2A0
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

		// Token: 0x1700BD67 RID: 48487
		// (get) Token: 0x0602B94B RID: 178507 RVA: 0x005EF0DC File Offset: 0x005ED2DC
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

		// Token: 0x0602B94C RID: 178508 RVA: 0x005EF118 File Offset: 0x005ED318
		public static Offset<IGravityDirectionByEntityGravity> CreateIGravityDirectionByEntityGravity(FlatBufferBuilder builder, EGravityDirectionType Type = EGravityDirectionType.SelfRotation, int EntityId = 0)
		{
			builder.StartTable(2);
			IGravityDirectionByEntityGravity.AddEntityId(builder, EntityId);
			IGravityDirectionByEntityGravity.AddType(builder, Type);
			return IGravityDirectionByEntityGravity.EndIGravityDirectionByEntityGravity(builder);
		}

		// Token: 0x0602B94D RID: 178509 RVA: 0x005EF135 File Offset: 0x005ED335
		public static void StartIGravityDirectionByEntityGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B94E RID: 178510 RVA: 0x005EF13E File Offset: 0x005ED33E
		public static void AddType(FlatBufferBuilder builder, EGravityDirectionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B94F RID: 178511 RVA: 0x005EF149 File Offset: 0x005ED349
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602B950 RID: 178512 RVA: 0x005EF154 File Offset: 0x005ED354
		public static Offset<IGravityDirectionByEntityGravity> EndIGravityDirectionByEntityGravity(FlatBufferBuilder builder)
		{
			return new Offset<IGravityDirectionByEntityGravity>(builder.EndTable());
		}

		// Token: 0x0602B951 RID: 178513 RVA: 0x005EF164 File Offset: 0x005ED364
		public IGravityDirectionByEntityGravityT UnPack()
		{
			IGravityDirectionByEntityGravityT gravityDirectionByEntityGravityT = new IGravityDirectionByEntityGravityT();
			this.UnPackTo(gravityDirectionByEntityGravityT);
			return gravityDirectionByEntityGravityT;
		}

		// Token: 0x0602B952 RID: 178514 RVA: 0x005EF17F File Offset: 0x005ED37F
		public void UnPackTo(IGravityDirectionByEntityGravityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602B953 RID: 178515 RVA: 0x005EF19C File Offset: 0x005ED39C
		public static Offset<IGravityDirectionByEntityGravity> Pack(FlatBufferBuilder builder, IGravityDirectionByEntityGravityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityDirectionByEntityGravity>);
			}
			return IGravityDirectionByEntityGravity.CreateIGravityDirectionByEntityGravity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0401053D RID: 66877
		private Table __p;
	}
}
