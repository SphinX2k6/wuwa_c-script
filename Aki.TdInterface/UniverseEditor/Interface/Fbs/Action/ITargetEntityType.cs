using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735E RID: 29534
	public struct ITargetEntityType : IFlatbufferObject
	{
		// Token: 0x1700E04A RID: 57418
		// (get) Token: 0x060359B0 RID: 219568 RVA: 0x0074CF7A File Offset: 0x0074B17A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359B1 RID: 219569 RVA: 0x0074CF87 File Offset: 0x0074B187
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359B2 RID: 219570 RVA: 0x0074CF90 File Offset: 0x0074B190
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb)
		{
			return ITargetEntityType.GetRootAsITargetEntityType(_bb, default(ITargetEntityType));
		}

		// Token: 0x060359B3 RID: 219571 RVA: 0x0074CFAC File Offset: 0x0074B1AC
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb, ITargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359B4 RID: 219572 RVA: 0x0074CFC9 File Offset: 0x0074B1C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359B5 RID: 219573 RVA: 0x0074CFD8 File Offset: 0x0074B1D8
		public ITargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E04B RID: 57419
		// (get) Token: 0x060359B6 RID: 219574 RVA: 0x0074CFE8 File Offset: 0x0074B1E8
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060359B7 RID: 219575 RVA: 0x0074D024 File Offset: 0x0074B224
		public static Offset<ITargetEntityType> CreateITargetEntityType(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITargetEntityType.AddType(builder, Type);
			return ITargetEntityType.EndITargetEntityType(builder);
		}

		// Token: 0x060359B8 RID: 219576 RVA: 0x0074D03A File Offset: 0x0074B23A
		public static void StartITargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060359B9 RID: 219577 RVA: 0x0074D043 File Offset: 0x0074B243
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060359BA RID: 219578 RVA: 0x0074D04E File Offset: 0x0074B24E
		public static Offset<ITargetEntityType> EndITargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityType>(builder.EndTable());
		}

		// Token: 0x060359BB RID: 219579 RVA: 0x0074D05C File Offset: 0x0074B25C
		public ITargetEntityTypeT UnPack()
		{
			ITargetEntityTypeT targetEntityTypeT = new ITargetEntityTypeT();
			this.UnPackTo(targetEntityTypeT);
			return targetEntityTypeT;
		}

		// Token: 0x060359BC RID: 219580 RVA: 0x0074D077 File Offset: 0x0074B277
		public void UnPackTo(ITargetEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060359BD RID: 219581 RVA: 0x0074D088 File Offset: 0x0074B288
		public static Offset<ITargetEntityType> Pack(FlatBufferBuilder builder, ITargetEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityType>);
			}
			return ITargetEntityType.CreateITargetEntityType(builder, _o.Type);
		}

		// Token: 0x0401215D RID: 74077
		private Table __p;
	}
}
