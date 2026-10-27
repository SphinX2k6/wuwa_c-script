using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F15 RID: 28437
	public struct ISafePos : IFlatbufferObject
	{
		// Token: 0x1700D368 RID: 54120
		// (get) Token: 0x060323D9 RID: 205785 RVA: 0x006C9960 File Offset: 0x006C7B60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323DA RID: 205786 RVA: 0x006C996D File Offset: 0x006C7B6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323DB RID: 205787 RVA: 0x006C9974 File Offset: 0x006C7B74
		public static ISafePos GetRootAsISafePos(ByteBuffer _bb)
		{
			return ISafePos.GetRootAsISafePos(_bb, default(ISafePos));
		}

		// Token: 0x060323DC RID: 205788 RVA: 0x006C9990 File Offset: 0x006C7B90
		public static ISafePos GetRootAsISafePos(ByteBuffer _bb, ISafePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323DD RID: 205789 RVA: 0x006C99AD File Offset: 0x006C7BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323DE RID: 205790 RVA: 0x006C99BC File Offset: 0x006C7BBC
		public ISafePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D369 RID: 54121
		// (get) Token: 0x060323DF RID: 205791 RVA: 0x006C99CC File Offset: 0x006C7BCC
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

		// Token: 0x1700D36A RID: 54122
		// (get) Token: 0x060323E0 RID: 205792 RVA: 0x006C9A08 File Offset: 0x006C7C08
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

		// Token: 0x1700D36B RID: 54123
		// (get) Token: 0x060323E1 RID: 205793 RVA: 0x006C9A44 File Offset: 0x006C7C44
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

		// Token: 0x060323E2 RID: 205794 RVA: 0x006C9A80 File Offset: 0x006C7C80
		public static Offset<ISafePos> CreateISafePos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, int FinalSafePosEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISafePos.AddFinalSafePosEntityId(builder, FinalSafePosEntityId);
			ISafePos.AddNullMask(builder, NullMask);
			ISafePos.AddType(builder, Type);
			return ISafePos.EndISafePos(builder);
		}

		// Token: 0x060323E3 RID: 205795 RVA: 0x006C9AA4 File Offset: 0x006C7CA4
		public static void StartISafePos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060323E4 RID: 205796 RVA: 0x006C9AAD File Offset: 0x006C7CAD
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060323E5 RID: 205797 RVA: 0x006C9AB8 File Offset: 0x006C7CB8
		public static void AddFinalSafePosEntityId(FlatBufferBuilder builder, int finalSafePosEntityId)
		{
			builder.AddInt(1, finalSafePosEntityId, 0);
		}

		// Token: 0x060323E6 RID: 205798 RVA: 0x006C9AC3 File Offset: 0x006C7CC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060323E7 RID: 205799 RVA: 0x006C9ACE File Offset: 0x006C7CCE
		public static Offset<ISafePos> EndISafePos(FlatBufferBuilder builder)
		{
			return new Offset<ISafePos>(builder.EndTable());
		}

		// Token: 0x060323E8 RID: 205800 RVA: 0x006C9ADC File Offset: 0x006C7CDC
		public ISafePosT UnPack()
		{
			ISafePosT safePosT = new ISafePosT();
			this.UnPackTo(safePosT);
			return safePosT;
		}

		// Token: 0x060323E9 RID: 205801 RVA: 0x006C9AF7 File Offset: 0x006C7CF7
		public void UnPackTo(ISafePosT _o)
		{
			_o.Type = this.Type;
			_o.FinalSafePosEntityId = this.FinalSafePosEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060323EA RID: 205802 RVA: 0x006C9B20 File Offset: 0x006C7D20
		public static Offset<ISafePos> Pack(FlatBufferBuilder builder, ISafePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISafePos>);
			}
			return ISafePos.CreateISafePos(builder, _o.Type, _o.FinalSafePosEntityId, _o.NullMask);
		}

		// Token: 0x040118FF RID: 71935
		private Table __p;
	}
}
