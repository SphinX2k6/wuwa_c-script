using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007367 RID: 29543
	public struct IOpenGravity : IFlatbufferObject
	{
		// Token: 0x1700D8AD RID: 55469
		// (get) Token: 0x060338E6 RID: 211174 RVA: 0x006F2DA0 File Offset: 0x006F0FA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338E7 RID: 211175 RVA: 0x006F2DAD File Offset: 0x006F0FAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338E8 RID: 211176 RVA: 0x006F2DB4 File Offset: 0x006F0FB4
		public static IOpenGravity GetRootAsIOpenGravity(ByteBuffer _bb)
		{
			return IOpenGravity.GetRootAsIOpenGravity(_bb, default(IOpenGravity));
		}

		// Token: 0x060338E9 RID: 211177 RVA: 0x006F2DD0 File Offset: 0x006F0FD0
		public static IOpenGravity GetRootAsIOpenGravity(ByteBuffer _bb, IOpenGravity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338EA RID: 211178 RVA: 0x006F2DED File Offset: 0x006F0FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338EB RID: 211179 RVA: 0x006F2DFC File Offset: 0x006F0FFC
		public IOpenGravity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8AE RID: 55470
		// (get) Token: 0x060338EC RID: 211180 RVA: 0x006F2E0C File Offset: 0x006F100C
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

		// Token: 0x1700D8AF RID: 55471
		// (get) Token: 0x060338ED RID: 211181 RVA: 0x006F2E48 File Offset: 0x006F1048
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

		// Token: 0x1700D8B0 RID: 55472
		// (get) Token: 0x060338EE RID: 211182 RVA: 0x006F2E84 File Offset: 0x006F1084
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

		// Token: 0x1700D8B1 RID: 55473
		// (get) Token: 0x060338EF RID: 211183 RVA: 0x006F2EC0 File Offset: 0x006F10C0
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

		// Token: 0x060338F0 RID: 211184 RVA: 0x006F2EFD File Offset: 0x006F10FD
		public static Offset<IOpenGravity> CreateIOpenGravity(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0, int PositionEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenGravity.AddPositionEntityId(builder, PositionEntityId);
			IOpenGravity.AddEntityId(builder, EntityId);
			IOpenGravity.AddNullMask(builder, NullMask);
			IOpenGravity.AddType(builder, Type);
			return IOpenGravity.EndIOpenGravity(builder);
		}

		// Token: 0x060338F1 RID: 211185 RVA: 0x006F2F29 File Offset: 0x006F1129
		public static void StartIOpenGravity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060338F2 RID: 211186 RVA: 0x006F2F32 File Offset: 0x006F1132
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060338F3 RID: 211187 RVA: 0x006F2F3D File Offset: 0x006F113D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060338F4 RID: 211188 RVA: 0x006F2F48 File Offset: 0x006F1148
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x060338F5 RID: 211189 RVA: 0x006F2F53 File Offset: 0x006F1153
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060338F6 RID: 211190 RVA: 0x006F2F5E File Offset: 0x006F115E
		public static Offset<IOpenGravity> EndIOpenGravity(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGravity>(builder.EndTable());
		}

		// Token: 0x060338F7 RID: 211191 RVA: 0x006F2F6C File Offset: 0x006F116C
		public IOpenGravityT UnPack()
		{
			IOpenGravityT openGravityT = new IOpenGravityT();
			this.UnPackTo(openGravityT);
			return openGravityT;
		}

		// Token: 0x060338F8 RID: 211192 RVA: 0x006F2F87 File Offset: 0x006F1187
		public void UnPackTo(IOpenGravityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PositionEntityId = this.PositionEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060338F9 RID: 211193 RVA: 0x006F2FBC File Offset: 0x006F11BC
		public static Offset<IOpenGravity> Pack(FlatBufferBuilder builder, IOpenGravityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGravity>);
			}
			return IOpenGravity.CreateIOpenGravity(builder, _o.Type, _o.EntityId, _o.PositionEntityId, _o.NullMask);
		}

		// Token: 0x04012450 RID: 74832
		private Table __p;
	}
}
