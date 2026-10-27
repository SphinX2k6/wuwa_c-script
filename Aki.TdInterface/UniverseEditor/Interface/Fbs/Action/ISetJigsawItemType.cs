using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007013 RID: 28691
	public struct ISetJigsawItemType : IFlatbufferObject
	{
		// Token: 0x1700D50E RID: 54542
		// (get) Token: 0x06032BF1 RID: 207857 RVA: 0x006D8BAF File Offset: 0x006D6DAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BF2 RID: 207858 RVA: 0x006D8BBC File Offset: 0x006D6DBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BF3 RID: 207859 RVA: 0x006D8BC4 File Offset: 0x006D6DC4
		public static ISetJigsawItemType GetRootAsISetJigsawItemType(ByteBuffer _bb)
		{
			return ISetJigsawItemType.GetRootAsISetJigsawItemType(_bb, default(ISetJigsawItemType));
		}

		// Token: 0x06032BF4 RID: 207860 RVA: 0x006D8BE0 File Offset: 0x006D6DE0
		public static ISetJigsawItemType GetRootAsISetJigsawItemType(ByteBuffer _bb, ISetJigsawItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BF5 RID: 207861 RVA: 0x006D8BFD File Offset: 0x006D6DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BF6 RID: 207862 RVA: 0x006D8C0C File Offset: 0x006D6E0C
		public ISetJigsawItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D50F RID: 54543
		// (get) Token: 0x06032BF7 RID: 207863 RVA: 0x006D8C1C File Offset: 0x006D6E1C
		public ESetJigsawItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return (ESetJigsawItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032BF8 RID: 207864 RVA: 0x006D8C58 File Offset: 0x006D6E58
		public static Offset<ISetJigsawItemType> CreateISetJigsawItemType(FlatBufferBuilder builder, ESetJigsawItemType Type = ESetJigsawItemType.MoveJigsawItem)
		{
			builder.StartTable(1);
			ISetJigsawItemType.AddType(builder, Type);
			return ISetJigsawItemType.EndISetJigsawItemType(builder);
		}

		// Token: 0x06032BF9 RID: 207865 RVA: 0x006D8C6E File Offset: 0x006D6E6E
		public static void StartISetJigsawItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BFA RID: 207866 RVA: 0x006D8C77 File Offset: 0x006D6E77
		public static void AddType(FlatBufferBuilder builder, ESetJigsawItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032BFB RID: 207867 RVA: 0x006D8C82 File Offset: 0x006D6E82
		public static Offset<ISetJigsawItemType> EndISetJigsawItemType(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawItemType>(builder.EndTable());
		}

		// Token: 0x06032BFC RID: 207868 RVA: 0x006D8C90 File Offset: 0x006D6E90
		public ISetJigsawItemTypeT UnPack()
		{
			ISetJigsawItemTypeT setJigsawItemTypeT = new ISetJigsawItemTypeT();
			this.UnPackTo(setJigsawItemTypeT);
			return setJigsawItemTypeT;
		}

		// Token: 0x06032BFD RID: 207869 RVA: 0x006D8CAB File Offset: 0x006D6EAB
		public void UnPackTo(ISetJigsawItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032BFE RID: 207870 RVA: 0x006D8CBC File Offset: 0x006D6EBC
		public static Offset<ISetJigsawItemType> Pack(FlatBufferBuilder builder, ISetJigsawItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawItemType>);
			}
			return ISetJigsawItemType.CreateISetJigsawItemType(builder, _o.Type);
		}

		// Token: 0x04011A37 RID: 72247
		private Table __p;
	}
}
