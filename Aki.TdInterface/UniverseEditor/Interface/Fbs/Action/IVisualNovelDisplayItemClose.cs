using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007580 RID: 30080
	public struct IVisualNovelDisplayItemClose : IFlatbufferObject
	{
		// Token: 0x1700E41E RID: 58398
		// (get) Token: 0x06036B86 RID: 224134 RVA: 0x0076DF5E File Offset: 0x0076C15E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B87 RID: 224135 RVA: 0x0076DF6B File Offset: 0x0076C16B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B88 RID: 224136 RVA: 0x0076DF74 File Offset: 0x0076C174
		public static IVisualNovelDisplayItemClose GetRootAsIVisualNovelDisplayItemClose(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemClose.GetRootAsIVisualNovelDisplayItemClose(_bb, default(IVisualNovelDisplayItemClose));
		}

		// Token: 0x06036B89 RID: 224137 RVA: 0x0076DF90 File Offset: 0x0076C190
		public static IVisualNovelDisplayItemClose GetRootAsIVisualNovelDisplayItemClose(ByteBuffer _bb, IVisualNovelDisplayItemClose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B8A RID: 224138 RVA: 0x0076DFAD File Offset: 0x0076C1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B8B RID: 224139 RVA: 0x0076DFBC File Offset: 0x0076C1BC
		public IVisualNovelDisplayItemClose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E41F RID: 58399
		// (get) Token: 0x06036B8C RID: 224140 RVA: 0x0076DFCC File Offset: 0x0076C1CC
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

		// Token: 0x06036B8D RID: 224141 RVA: 0x0076E008 File Offset: 0x0076C208
		public static Offset<IVisualNovelDisplayItemClose> CreateIVisualNovelDisplayItemClose(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image)
		{
			builder.StartTable(1);
			IVisualNovelDisplayItemClose.AddType(builder, Type);
			return IVisualNovelDisplayItemClose.EndIVisualNovelDisplayItemClose(builder);
		}

		// Token: 0x06036B8E RID: 224142 RVA: 0x0076E01E File Offset: 0x0076C21E
		public static void StartIVisualNovelDisplayItemClose(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036B8F RID: 224143 RVA: 0x0076E027 File Offset: 0x0076C227
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B90 RID: 224144 RVA: 0x0076E032 File Offset: 0x0076C232
		public static Offset<IVisualNovelDisplayItemClose> EndIVisualNovelDisplayItemClose(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemClose>(builder.EndTable());
		}

		// Token: 0x06036B91 RID: 224145 RVA: 0x0076E040 File Offset: 0x0076C240
		public IVisualNovelDisplayItemCloseT UnPack()
		{
			IVisualNovelDisplayItemCloseT visualNovelDisplayItemCloseT = new IVisualNovelDisplayItemCloseT();
			this.UnPackTo(visualNovelDisplayItemCloseT);
			return visualNovelDisplayItemCloseT;
		}

		// Token: 0x06036B92 RID: 224146 RVA: 0x0076E05B File Offset: 0x0076C25B
		public void UnPackTo(IVisualNovelDisplayItemCloseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036B93 RID: 224147 RVA: 0x0076E06C File Offset: 0x0076C26C
		public static Offset<IVisualNovelDisplayItemClose> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemCloseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemClose>);
			}
			return IVisualNovelDisplayItemClose.CreateIVisualNovelDisplayItemClose(builder, _o.Type);
		}

		// Token: 0x04012488 RID: 74888
		private Table __p;
	}
}
