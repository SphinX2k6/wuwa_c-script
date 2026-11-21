using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A95 RID: 19093
	public struct IAddAllItem : IFlatbufferObject
	{
		// Token: 0x170085C2 RID: 34242
		// (get) Token: 0x0601CB26 RID: 117542 RVA: 0x0040BEA2 File Offset: 0x0040A0A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CB27 RID: 117543 RVA: 0x0040BEAF File Offset: 0x0040A0AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CB28 RID: 117544 RVA: 0x0040BEB8 File Offset: 0x0040A0B8
		public static IAddAllItem GetRootAsIAddAllItem(ByteBuffer _bb)
		{
			return IAddAllItem.GetRootAsIAddAllItem(_bb, default(IAddAllItem));
		}

		// Token: 0x0601CB29 RID: 117545 RVA: 0x0040BED4 File Offset: 0x0040A0D4
		public static IAddAllItem GetRootAsIAddAllItem(ByteBuffer _bb, IAddAllItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CB2A RID: 117546 RVA: 0x0040BEF1 File Offset: 0x0040A0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CB2B RID: 117547 RVA: 0x0040BF00 File Offset: 0x0040A100
		public IAddAllItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085C3 RID: 34243
		// (get) Token: 0x0601CB2C RID: 117548 RVA: 0x0040BF10 File Offset: 0x0040A110
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CB2D RID: 117549 RVA: 0x0040BF4C File Offset: 0x0040A14C
		public static Offset<IAddAllItem> CreateIAddAllItem(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllItem.AddType(builder, Type);
			return IAddAllItem.EndIAddAllItem(builder);
		}

		// Token: 0x0601CB2E RID: 117550 RVA: 0x0040BF62 File Offset: 0x0040A162
		public static void StartIAddAllItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CB2F RID: 117551 RVA: 0x0040BF6B File Offset: 0x0040A16B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB30 RID: 117552 RVA: 0x0040BF76 File Offset: 0x0040A176
		public static Offset<IAddAllItem> EndIAddAllItem(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllItem>(builder.EndTable());
		}

		// Token: 0x0601CB31 RID: 117553 RVA: 0x0040BF84 File Offset: 0x0040A184
		public IAddAllItemT UnPack()
		{
			IAddAllItemT addAllItemT = new IAddAllItemT();
			this.UnPackTo(addAllItemT);
			return addAllItemT;
		}

		// Token: 0x0601CB32 RID: 117554 RVA: 0x0040BF9F File Offset: 0x0040A19F
		public void UnPackTo(IAddAllItemT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CB33 RID: 117555 RVA: 0x0040BFB0 File Offset: 0x0040A1B0
		public static Offset<IAddAllItem> Pack(FlatBufferBuilder builder, IAddAllItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllItem>);
			}
			return IAddAllItem.CreateIAddAllItem(builder, _o.Type);
		}

		// Token: 0x0400D1D5 RID: 53717
		private Table __p;
	}
}
