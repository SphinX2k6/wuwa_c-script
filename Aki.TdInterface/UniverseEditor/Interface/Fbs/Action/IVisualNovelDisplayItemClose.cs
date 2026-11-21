using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D76 RID: 32118
	public struct IVisualNovelDisplayItemClose : IFlatbufferObject
	{
		// Token: 0x1700F04E RID: 61518
		// (get) Token: 0x06039FAE RID: 237486 RVA: 0x007D1502 File Offset: 0x007CF702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039FAF RID: 237487 RVA: 0x007D150F File Offset: 0x007CF70F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039FB0 RID: 237488 RVA: 0x007D1518 File Offset: 0x007CF718
		public static IVisualNovelDisplayItemClose GetRootAsIVisualNovelDisplayItemClose(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemClose.GetRootAsIVisualNovelDisplayItemClose(_bb, default(IVisualNovelDisplayItemClose));
		}

		// Token: 0x06039FB1 RID: 237489 RVA: 0x007D1534 File Offset: 0x007CF734
		public static IVisualNovelDisplayItemClose GetRootAsIVisualNovelDisplayItemClose(ByteBuffer _bb, IVisualNovelDisplayItemClose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039FB2 RID: 237490 RVA: 0x007D1551 File Offset: 0x007CF751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039FB3 RID: 237491 RVA: 0x007D1560 File Offset: 0x007CF760
		public IVisualNovelDisplayItemClose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F04F RID: 61519
		// (get) Token: 0x06039FB4 RID: 237492 RVA: 0x007D1570 File Offset: 0x007CF770
		public EVisualNovelDisplayItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelDisplayItemType.Image;
				}
				return (EVisualNovelDisplayItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039FB5 RID: 237493 RVA: 0x007D15AC File Offset: 0x007CF7AC
		public static Offset<IVisualNovelDisplayItemClose> CreateIVisualNovelDisplayItemClose(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image)
		{
			builder.StartTable(1);
			IVisualNovelDisplayItemClose.AddType(builder, Type);
			return IVisualNovelDisplayItemClose.EndIVisualNovelDisplayItemClose(builder);
		}

		// Token: 0x06039FB6 RID: 237494 RVA: 0x007D15C2 File Offset: 0x007CF7C2
		public static void StartIVisualNovelDisplayItemClose(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039FB7 RID: 237495 RVA: 0x007D15CB File Offset: 0x007CF7CB
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039FB8 RID: 237496 RVA: 0x007D15D6 File Offset: 0x007CF7D6
		public static Offset<IVisualNovelDisplayItemClose> EndIVisualNovelDisplayItemClose(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemClose>(builder.EndTable());
		}

		// Token: 0x06039FB9 RID: 237497 RVA: 0x007D15E4 File Offset: 0x007CF7E4
		public IVisualNovelDisplayItemCloseT UnPack()
		{
			IVisualNovelDisplayItemCloseT visualNovelDisplayItemCloseT = new IVisualNovelDisplayItemCloseT();
			this.UnPackTo(visualNovelDisplayItemCloseT);
			return visualNovelDisplayItemCloseT;
		}

		// Token: 0x06039FBA RID: 237498 RVA: 0x007D15FF File Offset: 0x007CF7FF
		public void UnPackTo(IVisualNovelDisplayItemCloseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039FBB RID: 237499 RVA: 0x007D1610 File Offset: 0x007CF810
		public static Offset<IVisualNovelDisplayItemClose> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemCloseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemClose>);
			}
			return IVisualNovelDisplayItemClose.CreateIVisualNovelDisplayItemClose(builder, _o.Type);
		}

		// Token: 0x040134BC RID: 79036
		private Table __p;
	}
}
