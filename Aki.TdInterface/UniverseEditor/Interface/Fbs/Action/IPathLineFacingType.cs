using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C69 RID: 27753
	public struct IPathLineFacingType : IFlatbufferObject
	{
		// Token: 0x1700CEAD RID: 52909
		// (get) Token: 0x06030E5D RID: 200285 RVA: 0x006A4022 File Offset: 0x006A2222
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E5E RID: 200286 RVA: 0x006A402F File Offset: 0x006A222F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E5F RID: 200287 RVA: 0x006A4038 File Offset: 0x006A2238
		public static IPathLineFacingType GetRootAsIPathLineFacingType(ByteBuffer _bb)
		{
			return IPathLineFacingType.GetRootAsIPathLineFacingType(_bb, default(IPathLineFacingType));
		}

		// Token: 0x06030E60 RID: 200288 RVA: 0x006A4054 File Offset: 0x006A2254
		public static IPathLineFacingType GetRootAsIPathLineFacingType(ByteBuffer _bb, IPathLineFacingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E61 RID: 200289 RVA: 0x006A4071 File Offset: 0x006A2271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E62 RID: 200290 RVA: 0x006A4080 File Offset: 0x006A2280
		public IPathLineFacingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEAE RID: 52910
		// (get) Token: 0x06030E63 RID: 200291 RVA: 0x006A4090 File Offset: 0x006A2290
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

		// Token: 0x06030E64 RID: 200292 RVA: 0x006A40CC File Offset: 0x006A22CC
		public static Offset<IPathLineFacingType> CreateIPathLineFacingType(FlatBufferBuilder builder, EPathLineFacingType Type = EPathLineFacingType.Current)
		{
			builder.StartTable(1);
			IPathLineFacingType.AddType(builder, Type);
			return IPathLineFacingType.EndIPathLineFacingType(builder);
		}

		// Token: 0x06030E65 RID: 200293 RVA: 0x006A40E2 File Offset: 0x006A22E2
		public static void StartIPathLineFacingType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030E66 RID: 200294 RVA: 0x006A40EB File Offset: 0x006A22EB
		public static void AddType(FlatBufferBuilder builder, EPathLineFacingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E67 RID: 200295 RVA: 0x006A40F6 File Offset: 0x006A22F6
		public static Offset<IPathLineFacingType> EndIPathLineFacingType(FlatBufferBuilder builder)
		{
			return new Offset<IPathLineFacingType>(builder.EndTable());
		}

		// Token: 0x06030E68 RID: 200296 RVA: 0x006A4104 File Offset: 0x006A2304
		public IPathLineFacingTypeT UnPack()
		{
			IPathLineFacingTypeT pathLineFacingTypeT = new IPathLineFacingTypeT();
			this.UnPackTo(pathLineFacingTypeT);
			return pathLineFacingTypeT;
		}

		// Token: 0x06030E69 RID: 200297 RVA: 0x006A411F File Offset: 0x006A231F
		public void UnPackTo(IPathLineFacingTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030E6A RID: 200298 RVA: 0x006A4130 File Offset: 0x006A2330
		public static Offset<IPathLineFacingType> Pack(FlatBufferBuilder builder, IPathLineFacingTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathLineFacingType>);
			}
			return IPathLineFacingType.CreateIPathLineFacingType(builder, _o.Type);
		}

		// Token: 0x040115AE RID: 71086
		private Table __p;
	}
}
