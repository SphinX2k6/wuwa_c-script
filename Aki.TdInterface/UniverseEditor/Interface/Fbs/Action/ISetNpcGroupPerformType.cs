using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007031 RID: 28721
	public struct ISetNpcGroupPerformType : IFlatbufferObject
	{
		// Token: 0x1700D548 RID: 54600
		// (get) Token: 0x06032CF0 RID: 208112 RVA: 0x006DAA1C File Offset: 0x006D8C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CF1 RID: 208113 RVA: 0x006DAA29 File Offset: 0x006D8C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CF2 RID: 208114 RVA: 0x006DAA30 File Offset: 0x006D8C30
		public static ISetNpcGroupPerformType GetRootAsISetNpcGroupPerformType(ByteBuffer _bb)
		{
			return ISetNpcGroupPerformType.GetRootAsISetNpcGroupPerformType(_bb, default(ISetNpcGroupPerformType));
		}

		// Token: 0x06032CF3 RID: 208115 RVA: 0x006DAA4C File Offset: 0x006D8C4C
		public static ISetNpcGroupPerformType GetRootAsISetNpcGroupPerformType(ByteBuffer _bb, ISetNpcGroupPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CF4 RID: 208116 RVA: 0x006DAA69 File Offset: 0x006D8C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CF5 RID: 208117 RVA: 0x006DAA78 File Offset: 0x006D8C78
		public ISetNpcGroupPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D549 RID: 54601
		// (get) Token: 0x06032CF6 RID: 208118 RVA: 0x006DAA88 File Offset: 0x006D8C88
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CF7 RID: 208119 RVA: 0x006DAAC4 File Offset: 0x006D8CC4
		public static Offset<ISetNpcGroupPerformType> CreateISetNpcGroupPerformType(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand)
		{
			builder.StartTable(1);
			ISetNpcGroupPerformType.AddType(builder, Type);
			return ISetNpcGroupPerformType.EndISetNpcGroupPerformType(builder);
		}

		// Token: 0x06032CF8 RID: 208120 RVA: 0x006DAADA File Offset: 0x006D8CDA
		public static void StartISetNpcGroupPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032CF9 RID: 208121 RVA: 0x006DAAE3 File Offset: 0x006D8CE3
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032CFA RID: 208122 RVA: 0x006DAAEE File Offset: 0x006D8CEE
		public static Offset<ISetNpcGroupPerformType> EndISetNpcGroupPerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcGroupPerformType>(builder.EndTable());
		}

		// Token: 0x06032CFB RID: 208123 RVA: 0x006DAAFC File Offset: 0x006D8CFC
		public ISetNpcGroupPerformTypeT UnPack()
		{
			ISetNpcGroupPerformTypeT setNpcGroupPerformTypeT = new ISetNpcGroupPerformTypeT();
			this.UnPackTo(setNpcGroupPerformTypeT);
			return setNpcGroupPerformTypeT;
		}

		// Token: 0x06032CFC RID: 208124 RVA: 0x006DAB17 File Offset: 0x006D8D17
		public void UnPackTo(ISetNpcGroupPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032CFD RID: 208125 RVA: 0x006DAB28 File Offset: 0x006D8D28
		public static Offset<ISetNpcGroupPerformType> Pack(FlatBufferBuilder builder, ISetNpcGroupPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcGroupPerformType>);
			}
			return ISetNpcGroupPerformType.CreateISetNpcGroupPerformType(builder, _o.Type);
		}

		// Token: 0x04011A62 RID: 72290
		private Table __p;
	}
}
