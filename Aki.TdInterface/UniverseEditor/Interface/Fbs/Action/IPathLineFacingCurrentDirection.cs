using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C63 RID: 27747
	public struct IPathLineFacingCurrentDirection : IFlatbufferObject
	{
		// Token: 0x1700CEA1 RID: 52897
		// (get) Token: 0x06030E2D RID: 200237 RVA: 0x006A3B72 File Offset: 0x006A1D72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E2E RID: 200238 RVA: 0x006A3B7F File Offset: 0x006A1D7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E2F RID: 200239 RVA: 0x006A3B88 File Offset: 0x006A1D88
		public static IPathLineFacingCurrentDirection GetRootAsIPathLineFacingCurrentDirection(ByteBuffer _bb)
		{
			return IPathLineFacingCurrentDirection.GetRootAsIPathLineFacingCurrentDirection(_bb, default(IPathLineFacingCurrentDirection));
		}

		// Token: 0x06030E30 RID: 200240 RVA: 0x006A3BA4 File Offset: 0x006A1DA4
		public static IPathLineFacingCurrentDirection GetRootAsIPathLineFacingCurrentDirection(ByteBuffer _bb, IPathLineFacingCurrentDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E31 RID: 200241 RVA: 0x006A3BC1 File Offset: 0x006A1DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E32 RID: 200242 RVA: 0x006A3BD0 File Offset: 0x006A1DD0
		public IPathLineFacingCurrentDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEA2 RID: 52898
		// (get) Token: 0x06030E33 RID: 200243 RVA: 0x006A3BE0 File Offset: 0x006A1DE0
		public EPathLineFacingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathLineFacingType.Current;
				}
				return (EPathLineFacingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEA3 RID: 52899
		// (get) Token: 0x06030E34 RID: 200244 RVA: 0x006A3C1C File Offset: 0x006A1E1C
		public float YawOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEA4 RID: 52900
		// (get) Token: 0x06030E35 RID: 200245 RVA: 0x006A3C5C File Offset: 0x006A1E5C
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

		// Token: 0x06030E36 RID: 200246 RVA: 0x006A3C98 File Offset: 0x006A1E98
		public static Offset<IPathLineFacingCurrentDirection> CreateIPathLineFacingCurrentDirection(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current, float YawOffset = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPathLineFacingCurrentDirection.AddYawOffset(builder, YawOffset);
			IPathLineFacingCurrentDirection.AddNullMask(builder, NullMask);
			IPathLineFacingCurrentDirection.AddType(builder, Type);
			return IPathLineFacingCurrentDirection.EndIPathLineFacingCurrentDirection(builder);
		}

		// Token: 0x06030E37 RID: 200247 RVA: 0x006A3CBC File Offset: 0x006A1EBC
		public static void StartIPathLineFacingCurrentDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030E38 RID: 200248 RVA: 0x006A3CC5 File Offset: 0x006A1EC5
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E39 RID: 200249 RVA: 0x006A3CD0 File Offset: 0x006A1ED0
		public static void AddYawOffset(FlatBufferBuilder builder, float yawOffset)
		{
			builder.AddFloat(1, yawOffset, 0.0);
		}

		// Token: 0x06030E3A RID: 200250 RVA: 0x006A3CE3 File Offset: 0x006A1EE3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06030E3B RID: 200251 RVA: 0x006A3CEE File Offset: 0x006A1EEE
		public static Offset<IPathLineFacingCurrentDirection> EndIPathLineFacingCurrentDirection(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingCurrentDirection>(builder.EndTable());
		}

		// Token: 0x06030E3C RID: 200252 RVA: 0x006A3CFC File Offset: 0x006A1EFC
		public IPathLineFacingCurrentDirectionT UnPack()
		{
			IPathLineFacingCurrentDirectionT pathLineFacingCurrentDirectionT = new IPathLineFacingCurrentDirectionT();
			this.UnPackTo(pathLineFacingCurrentDirectionT);
			return pathLineFacingCurrentDirectionT;
		}

		// Token: 0x06030E3D RID: 200253 RVA: 0x006A3D17 File Offset: 0x006A1F17
		public void UnPackTo(IPathLineFacingCurrentDirectionT _o)
		{
			_o.Type = this.Type;
			_o.YawOffset = this.YawOffset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030E3E RID: 200254 RVA: 0x006A3D40 File Offset: 0x006A1F40
		public static Offset<IPathLineFacingCurrentDirection> Pack(FlatBufferBuilder builder, IPathLineFacingCurrentDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingCurrentDirection>);
			}
			return IPathLineFacingCurrentDirection.CreateIPathLineFacingCurrentDirection(builder, _o.Type, _o.YawOffset, _o.NullMask);
		}

		// Token: 0x040115A7 RID: 71079
		private Table __p;
	}
}
