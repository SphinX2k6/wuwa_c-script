using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C03 RID: 27651
	public struct IOpenGravity : IFlatbufferObject
	{
		// Token: 0x1700CD9F RID: 52639
		// (get) Token: 0x060309C6 RID: 199110 RVA: 0x0069940C File Offset: 0x0069760C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309C7 RID: 199111 RVA: 0x00699419 File Offset: 0x00697619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309C8 RID: 199112 RVA: 0x00699420 File Offset: 0x00697620
		public static IOpenGravity GetRootAsIOpenGravity(ByteBuffer _bb)
		{
			return IOpenGravity.GetRootAsIOpenGravity(_bb, default(IOpenGravity));
		}

		// Token: 0x060309C9 RID: 199113 RVA: 0x0069943C File Offset: 0x0069763C
		public static IOpenGravity GetRootAsIOpenGravity(ByteBuffer _bb, IOpenGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309CA RID: 199114 RVA: 0x00699459 File Offset: 0x00697659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309CB RID: 199115 RVA: 0x00699468 File Offset: 0x00697668
		public IOpenGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDA0 RID: 52640
		// (get) Token: 0x060309CC RID: 199116 RVA: 0x00699478 File Offset: 0x00697678
		public ESetTeleControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return (ESetTeleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDA1 RID: 52641
		// (get) Token: 0x060309CD RID: 199117 RVA: 0x006994B4 File Offset: 0x006976B4
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

		// Token: 0x1700CDA2 RID: 52642
		// (get) Token: 0x060309CE RID: 199118 RVA: 0x006994F0 File Offset: 0x006976F0
		public int PositionEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDA3 RID: 52643
		// (get) Token: 0x060309CF RID: 199119 RVA: 0x0069952C File Offset: 0x0069772C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060309D0 RID: 199120 RVA: 0x00699569 File Offset: 0x00697769
		public static Offset<IOpenGravity> CreateIOpenGravity(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0, int PositionEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenGravity.AddPositionEntityId(builder, PositionEntityId);
			IOpenGravity.AddEntityId(builder, EntityId);
			IOpenGravity.AddNullMask(builder, NullMask);
			IOpenGravity.AddType(builder, Type);
			return IOpenGravity.EndIOpenGravity(builder);
		}

		// Token: 0x060309D1 RID: 199121 RVA: 0x00699595 File Offset: 0x00697795
		public static void StartIOpenGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060309D2 RID: 199122 RVA: 0x0069959E File Offset: 0x0069779E
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309D3 RID: 199123 RVA: 0x006995A9 File Offset: 0x006977A9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060309D4 RID: 199124 RVA: 0x006995B4 File Offset: 0x006977B4
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x060309D5 RID: 199125 RVA: 0x006995BF File Offset: 0x006977BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060309D6 RID: 199126 RVA: 0x006995CA File Offset: 0x006977CA
		public static Offset<IOpenGravity> EndIOpenGravity(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGravity>(builder.EndTable());
		}

		// Token: 0x060309D7 RID: 199127 RVA: 0x006995D8 File Offset: 0x006977D8
		public IOpenGravityT UnPack()
		{
			IOpenGravityT openGravityT = new IOpenGravityT();
			this.UnPackTo(openGravityT);
			return openGravityT;
		}

		// Token: 0x060309D8 RID: 199128 RVA: 0x006995F3 File Offset: 0x006977F3
		public void UnPackTo(IOpenGravityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PositionEntityId = this.PositionEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060309D9 RID: 199129 RVA: 0x00699628 File Offset: 0x00697828
		public static Offset<IOpenGravity> Pack(FlatBufferBuilder builder, IOpenGravityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGravity>);
			}
			return IOpenGravity.CreateIOpenGravity(builder, _o.Type, _o.EntityId, _o.PositionEntityId, _o.NullMask);
		}

		// Token: 0x04011500 RID: 70912
		private Table __p;
	}
}
