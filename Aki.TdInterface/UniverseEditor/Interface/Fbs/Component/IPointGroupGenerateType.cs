using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005760 RID: 22368
	public struct IPointGroupGenerateType : IFlatbufferObject
	{
		// Token: 0x1700A6DB RID: 42715
		// (get) Token: 0x060257C5 RID: 153541 RVA: 0x0052C006 File Offset: 0x0052A206
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060257C6 RID: 153542 RVA: 0x0052C013 File Offset: 0x0052A213
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060257C7 RID: 153543 RVA: 0x0052C01C File Offset: 0x0052A21C
		public static IPointGroupGenerateType GetRootAsIPointGroupGenerateType(ByteBuffer _bb)
		{
			return IPointGroupGenerateType.GetRootAsIPointGroupGenerateType(_bb, default(IPointGroupGenerateType));
		}

		// Token: 0x060257C8 RID: 153544 RVA: 0x0052C038 File Offset: 0x0052A238
		public static IPointGroupGenerateType GetRootAsIPointGroupGenerateType(ByteBuffer _bb, IPointGroupGenerateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060257C9 RID: 153545 RVA: 0x0052C055 File Offset: 0x0052A255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060257CA RID: 153546 RVA: 0x0052C064 File Offset: 0x0052A264
		public IPointGroupGenerateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6DC RID: 42716
		// (get) Token: 0x060257CB RID: 153547 RVA: 0x0052C074 File Offset: 0x0052A274
		public EPointGroupGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointGroupGenerateType.Layer;
				}
				return (EPointGroupGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060257CC RID: 153548 RVA: 0x0052C0B0 File Offset: 0x0052A2B0
		public static Offset<IPointGroupGenerateType> CreateIPointGroupGenerateType(FlatBufferBuilder builder, EPointGroupGenerateType Type = EPointGroupGenerateType.Layer)
		{
			builder.StartTable(1);
			IPointGroupGenerateType.AddType(builder, Type);
			return IPointGroupGenerateType.EndIPointGroupGenerateType(builder);
		}

		// Token: 0x060257CD RID: 153549 RVA: 0x0052C0C6 File Offset: 0x0052A2C6
		public static void StartIPointGroupGenerateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060257CE RID: 153550 RVA: 0x0052C0CF File Offset: 0x0052A2CF
		public static void AddType(FlatBufferBuilder builder, EPointGroupGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060257CF RID: 153551 RVA: 0x0052C0DA File Offset: 0x0052A2DA
		public static Offset<IPointGroupGenerateType> EndIPointGroupGenerateType(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroupGenerateType>(builder.EndTable());
		}

		// Token: 0x060257D0 RID: 153552 RVA: 0x0052C0E8 File Offset: 0x0052A2E8
		public IPointGroupGenerateTypeT UnPack()
		{
			IPointGroupGenerateTypeT pointGroupGenerateTypeT = new IPointGroupGenerateTypeT();
			this.UnPackTo(pointGroupGenerateTypeT);
			return pointGroupGenerateTypeT;
		}

		// Token: 0x060257D1 RID: 153553 RVA: 0x0052C103 File Offset: 0x0052A303
		public void UnPackTo(IPointGroupGenerateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060257D2 RID: 153554 RVA: 0x0052C114 File Offset: 0x0052A314
		public static Offset<IPointGroupGenerateType> Pack(FlatBufferBuilder builder, IPointGroupGenerateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointGroupGenerateType>);
			}
			return IPointGroupGenerateType.CreateIPointGroupGenerateType(builder, _o.Type);
		}

		// Token: 0x0400EC01 RID: 60417
		private Table __p;
	}
}
