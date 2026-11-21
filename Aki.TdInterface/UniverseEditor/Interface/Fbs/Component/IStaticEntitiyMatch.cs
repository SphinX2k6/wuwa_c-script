using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FCF RID: 24527
	public struct IStaticEntitiyMatch : IFlatbufferObject
	{
		// Token: 0x1700B5AD RID: 46509
		// (get) Token: 0x0602948D RID: 169101 RVA: 0x005A28A7 File Offset: 0x005A0AA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602948E RID: 169102 RVA: 0x005A28B4 File Offset: 0x005A0AB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602948F RID: 169103 RVA: 0x005A28BC File Offset: 0x005A0ABC
		public static IStaticEntitiyMatch GetRootAsIStaticEntitiyMatch(ByteBuffer _bb)
		{
			return IStaticEntitiyMatch.GetRootAsIStaticEntitiyMatch(_bb, default(IStaticEntitiyMatch));
		}

		// Token: 0x06029490 RID: 169104 RVA: 0x005A28D8 File Offset: 0x005A0AD8
		public static IStaticEntitiyMatch GetRootAsIStaticEntitiyMatch(ByteBuffer _bb, IStaticEntitiyMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029491 RID: 169105 RVA: 0x005A28F5 File Offset: 0x005A0AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029492 RID: 169106 RVA: 0x005A2904 File Offset: 0x005A0B04
		public IStaticEntitiyMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5AE RID: 46510
		// (get) Token: 0x06029493 RID: 169107 RVA: 0x005A2914 File Offset: 0x005A0B14
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

		// Token: 0x1700B5AF RID: 46511
		// (get) Token: 0x06029494 RID: 169108 RVA: 0x005A2974 File Offset: 0x005A0B74
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

		// Token: 0x1700B5B0 RID: 46512
		// (get) Token: 0x06029495 RID: 169109 RVA: 0x005A29B0 File Offset: 0x005A0BB0
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

		// Token: 0x06029496 RID: 169110 RVA: 0x005A29EC File Offset: 0x005A0BEC
		public static Offset<IStaticEntitiyMatch> CreateIStaticEntitiyMatch(FlatBufferBuilder builder, Offset<IEntityCategory> CategoryOffset = default(Offset<IEntityCategory>), EEntityCategory CategoryType = EEntityCategory.MonsterMatchType, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStaticEntitiyMatch.AddCategory(builder, CategoryOffset);
			IStaticEntitiyMatch.AddNullMask(builder, NullMask);
			IStaticEntitiyMatch.AddCategoryType(builder, CategoryType);
			return IStaticEntitiyMatch.EndIStaticEntitiyMatch(builder);
		}

		// Token: 0x06029497 RID: 169111 RVA: 0x005A2A10 File Offset: 0x005A0C10
		public static void StartIStaticEntitiyMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029498 RID: 169112 RVA: 0x005A2A19 File Offset: 0x005A0C19
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x06029499 RID: 169113 RVA: 0x005A2A29 File Offset: 0x005A0C29
		public static void AddCategoryType(FlatBufferBuilder builder, EEntityCategory categoryType)
		{
			builder.AddByte(1, (byte)categoryType, 0);
		}

		// Token: 0x0602949A RID: 169114 RVA: 0x005A2A34 File Offset: 0x005A0C34
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602949B RID: 169115 RVA: 0x005A2A3F File Offset: 0x005A0C3F
		public static Offset<IStaticEntitiyMatch> EndIStaticEntitiyMatch(FlatBufferBuilder builder)
		{
			return new Offset<IStaticEntitiyMatch>(builder.EndTable());
		}

		// Token: 0x0602949C RID: 169116 RVA: 0x005A2A4C File Offset: 0x005A0C4C
		public IStaticEntitiyMatchT UnPack()
		{
			IStaticEntitiyMatchT staticEntitiyMatchT = new IStaticEntitiyMatchT();
			this.UnPackTo(staticEntitiyMatchT);
			return staticEntitiyMatchT;
		}

		// Token: 0x0602949D RID: 169117 RVA: 0x005A2A68 File Offset: 0x005A0C68
		public void UnPackTo(IStaticEntitiyMatchT _o)
		{
			_o.Category = ((this.Category != null) ? this.Category.Value.UnPack() : null);
			_o.CategoryType = this.CategoryType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602949E RID: 169118 RVA: 0x005A2ABC File Offset: 0x005A0CBC
		public static Offset<IStaticEntitiyMatch> Pack(FlatBufferBuilder builder, IStaticEntitiyMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticEntitiyMatch>);
			}
			Offset<IEntityCategory> categoryOffset = (_o.Category == null) ? default(Offset<IEntityCategory>) : IEntityCategory.Pack(builder, _o.Category);
			return IStaticEntitiyMatch.CreateIStaticEntitiyMatch(builder, categoryOffset, _o.CategoryType, _o.NullMask);
		}

		// Token: 0x0400FCD2 RID: 64722
		private Table __p;
	}
}
