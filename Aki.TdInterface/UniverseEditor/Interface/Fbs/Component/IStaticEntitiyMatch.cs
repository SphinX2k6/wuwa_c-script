using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C2 RID: 22978
	public struct IStaticEntitiyMatch : IFlatbufferObject
	{
		// Token: 0x1700AC77 RID: 44151
		// (get) Token: 0x06026F19 RID: 159513 RVA: 0x0055B9ED File Offset: 0x00559BED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F1A RID: 159514 RVA: 0x0055B9FA File Offset: 0x00559BFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F1B RID: 159515 RVA: 0x0055BA04 File Offset: 0x00559C04
		public static IStaticEntitiyMatch GetRootAsIStaticEntitiyMatch(ByteBuffer _bb)
		{
			return IStaticEntitiyMatch.GetRootAsIStaticEntitiyMatch(_bb, default(IStaticEntitiyMatch));
		}

		// Token: 0x06026F1C RID: 159516 RVA: 0x0055BA20 File Offset: 0x00559C20
		public static IStaticEntitiyMatch GetRootAsIStaticEntitiyMatch(ByteBuffer _bb, IStaticEntitiyMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F1D RID: 159517 RVA: 0x0055BA3D File Offset: 0x00559C3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F1E RID: 159518 RVA: 0x0055BA4C File Offset: 0x00559C4C
		public IStaticEntitiyMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC78 RID: 44152
		// (get) Token: 0x06026F1F RID: 159519 RVA: 0x0055BA5C File Offset: 0x00559C5C
		public IEntityCategory? Category
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC79 RID: 44153
		// (get) Token: 0x06026F20 RID: 159520 RVA: 0x0055BABC File Offset: 0x00559CBC
		public EEntityCategory CategoryType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEntityCategory.MonsterMatchType;
				}
				return (EEntityCategory)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC7A RID: 44154
		// (get) Token: 0x06026F21 RID: 159521 RVA: 0x0055BAF8 File Offset: 0x00559CF8
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

		// Token: 0x06026F22 RID: 159522 RVA: 0x0055BB34 File Offset: 0x00559D34
		public static Offset<IStaticEntitiyMatch> CreateIStaticEntitiyMatch(FlatBufferBuilder builder, Offset<IEntityCategory> CategoryOffset = default(Offset<IEntityCategory>), EEntityCategory CategoryType = EEntityCategory.MonsterMatchType, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStaticEntitiyMatch.AddCategory(builder, CategoryOffset);
			IStaticEntitiyMatch.AddNullMask(builder, NullMask);
			IStaticEntitiyMatch.AddCategoryType(builder, CategoryType);
			return IStaticEntitiyMatch.EndIStaticEntitiyMatch(builder);
		}

		// Token: 0x06026F23 RID: 159523 RVA: 0x0055BB58 File Offset: 0x00559D58
		public static void StartIStaticEntitiyMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026F24 RID: 159524 RVA: 0x0055BB61 File Offset: 0x00559D61
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x06026F25 RID: 159525 RVA: 0x0055BB71 File Offset: 0x00559D71
		public static void AddCategoryType(FlatBufferBuilder builder, EEntityCategory categoryType)
		{
			builder.AddByte(1, (byte)categoryType, 0);
		}

		// Token: 0x06026F26 RID: 159526 RVA: 0x0055BB7C File Offset: 0x00559D7C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026F27 RID: 159527 RVA: 0x0055BB87 File Offset: 0x00559D87
		public static Offset<IStaticEntitiyMatch> EndIStaticEntitiyMatch(FlatBufferBuilder builder)
		{
			return new Offset<IStaticEntitiyMatch>(builder.EndTable());
		}

		// Token: 0x06026F28 RID: 159528 RVA: 0x0055BB94 File Offset: 0x00559D94
		public IStaticEntitiyMatchT UnPack()
		{
			IStaticEntitiyMatchT staticEntitiyMatchT = new IStaticEntitiyMatchT();
			this.UnPackTo(staticEntitiyMatchT);
			return staticEntitiyMatchT;
		}

		// Token: 0x06026F29 RID: 159529 RVA: 0x0055BBB0 File Offset: 0x00559DB0
		public void UnPackTo(IStaticEntitiyMatchT _o)
		{
			_o.Category = ((this.Category != null) ? this.Category.Value.UnPack() : null);
			_o.CategoryType = this.CategoryType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026F2A RID: 159530 RVA: 0x0055BC04 File Offset: 0x00559E04
		public static Offset<IStaticEntitiyMatch> Pack(FlatBufferBuilder builder, IStaticEntitiyMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticEntitiyMatch>);
			}
			Offset<IEntityCategory> categoryOffset = (_o.Category == null) ? default(Offset<IEntityCategory>) : IEntityCategory.Pack(builder, _o.Category);
			return IStaticEntitiyMatch.CreateIStaticEntitiyMatch(builder, categoryOffset, _o.CategoryType, _o.NullMask);
		}

		// Token: 0x0400EFDC RID: 61404
		private Table __p;
	}
}
