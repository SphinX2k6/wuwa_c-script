using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769C RID: 30364
	public struct ISafePos : IFlatbufferObject
	{
		// Token: 0x1700DEC4 RID: 57028
		// (get) Token: 0x06035431 RID: 218161 RVA: 0x007258C8 File Offset: 0x00723AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035432 RID: 218162 RVA: 0x007258D5 File Offset: 0x00723AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035433 RID: 218163 RVA: 0x007258DC File Offset: 0x00723ADC
		public static ISafePos GetRootAsISafePos(ByteBuffer _bb)
		{
			return ISafePos.GetRootAsISafePos(_bb, default(ISafePos));
		}

		// Token: 0x06035434 RID: 218164 RVA: 0x007258F8 File Offset: 0x00723AF8
		public static ISafePos GetRootAsISafePos(ByteBuffer _bb, ISafePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035435 RID: 218165 RVA: 0x00725915 File Offset: 0x00723B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035436 RID: 218166 RVA: 0x00725924 File Offset: 0x00723B24
		public ISafePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEC5 RID: 57029
		// (get) Token: 0x06035437 RID: 218167 RVA: 0x00725934 File Offset: 0x00723B34
		public ETeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportType.FixedPos;
				}
				return (ETeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DEC6 RID: 57030
		// (get) Token: 0x06035438 RID: 218168 RVA: 0x00725970 File Offset: 0x00723B70
		public int FinalSafePosEntityId
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

		// Token: 0x1700DEC7 RID: 57031
		// (get) Token: 0x06035439 RID: 218169 RVA: 0x007259AC File Offset: 0x00723BAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603543A RID: 218170 RVA: 0x007259E8 File Offset: 0x00723BE8
		public static Offset<ISafePos> CreateISafePos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, int FinalSafePosEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISafePos.AddFinalSafePosEntityId(builder, FinalSafePosEntityId);
			ISafePos.AddNullMask(builder, NullMask);
			ISafePos.AddType(builder, Type);
			return ISafePos.EndISafePos(builder);
		}

		// Token: 0x0603543B RID: 218171 RVA: 0x00725A0C File Offset: 0x00723C0C
		public static void StartISafePos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603543C RID: 218172 RVA: 0x00725A15 File Offset: 0x00723C15
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603543D RID: 218173 RVA: 0x00725A20 File Offset: 0x00723C20
		public static void AddFinalSafePosEntityId(FlatBufferBuilder builder, int finalSafePosEntityId)
		{
			builder.AddInt(1, finalSafePosEntityId, 0);
		}

		// Token: 0x0603543E RID: 218174 RVA: 0x00725A2B File Offset: 0x00723C2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603543F RID: 218175 RVA: 0x00725A36 File Offset: 0x00723C36
		public static Offset<ISafePos> EndISafePos(FlatBufferBuilder builder)
		{
			return new Offset<ISafePos>(builder.EndTable());
		}

		// Token: 0x06035440 RID: 218176 RVA: 0x00725A44 File Offset: 0x00723C44
		public ISafePosT UnPack()
		{
			ISafePosT safePosT = new ISafePosT();
			this.UnPackTo(safePosT);
			return safePosT;
		}

		// Token: 0x06035441 RID: 218177 RVA: 0x00725A5F File Offset: 0x00723C5F
		public void UnPackTo(ISafePosT _o)
		{
			_o.Type = this.Type;
			_o.FinalSafePosEntityId = this.FinalSafePosEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035442 RID: 218178 RVA: 0x00725A88 File Offset: 0x00723C88
		public static Offset<ISafePos> Pack(FlatBufferBuilder builder, ISafePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISafePos>);
			}
			return ISafePos.CreateISafePos(builder, _o.Type, _o.FinalSafePosEntityId, _o.NullMask);
		}

		// Token: 0x04012887 RID: 75911
		private Table __p;
	}
}
