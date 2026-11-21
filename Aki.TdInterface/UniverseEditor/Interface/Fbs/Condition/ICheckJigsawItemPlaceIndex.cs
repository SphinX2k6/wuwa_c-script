using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F83 RID: 20355
	public struct ICheckJigsawItemPlaceIndex : IFlatbufferObject
	{
		// Token: 0x1700918B RID: 37259
		// (get) Token: 0x0601FB31 RID: 129841 RVA: 0x004681B0 File Offset: 0x004663B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB32 RID: 129842 RVA: 0x004681BD File Offset: 0x004663BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB33 RID: 129843 RVA: 0x004681C4 File Offset: 0x004663C4
		public static ICheckJigsawItemPlaceIndex GetRootAsICheckJigsawItemPlaceIndex(ByteBuffer _bb)
		{
			return ICheckJigsawItemPlaceIndex.GetRootAsICheckJigsawItemPlaceIndex(_bb, default(ICheckJigsawItemPlaceIndex));
		}

		// Token: 0x0601FB34 RID: 129844 RVA: 0x004681E0 File Offset: 0x004663E0
		public static ICheckJigsawItemPlaceIndex GetRootAsICheckJigsawItemPlaceIndex(ByteBuffer _bb, ICheckJigsawItemPlaceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB35 RID: 129845 RVA: 0x004681FD File Offset: 0x004663FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB36 RID: 129846 RVA: 0x0046820C File Offset: 0x0046640C
		public ICheckJigsawItemPlaceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700918C RID: 37260
		// (get) Token: 0x0601FB37 RID: 129847 RVA: 0x0046821C File Offset: 0x0046641C
		public ECheckJigsawInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
				}
				return (ECheckJigsawInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700918D RID: 37261
		// (get) Token: 0x0601FB38 RID: 129848 RVA: 0x00468258 File Offset: 0x00466458
		public int ItemEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700918E RID: 37262
		// (get) Token: 0x0601FB39 RID: 129849 RVA: 0x00468294 File Offset: 0x00466494
		public int FoundationEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700918F RID: 37263
		// (get) Token: 0x0601FB3A RID: 129850 RVA: 0x004682D0 File Offset: 0x004664D0
		public IPieceIndex? PlaceIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009190 RID: 37264
		// (get) Token: 0x0601FB3B RID: 129851 RVA: 0x00468330 File Offset: 0x00466530
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB3C RID: 129852 RVA: 0x0046836D File Offset: 0x0046656D
		public static Offset<ICheckJigsawItemPlaceIndex> CreateICheckJigsawItemPlaceIndex(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex, int ItemEntityId = 0, int FoundationEntityId = 0, Offset<IPieceIndex> PlaceIndexOffset = default(Offset<IPieceIndex>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(5);
			ICheckJigsawItemPlaceIndex.AddPlaceIndex(builder, PlaceIndexOffset);
			ICheckJigsawItemPlaceIndex.AddFoundationEntityId(builder, FoundationEntityId);
			ICheckJigsawItemPlaceIndex.AddItemEntityId(builder, ItemEntityId);
			ICheckJigsawItemPlaceIndex.AddCompare(builder, Compare);
			ICheckJigsawItemPlaceIndex.AddType(builder, Type);
			return ICheckJigsawItemPlaceIndex.EndICheckJigsawItemPlaceIndex(builder);
		}

		// Token: 0x0601FB3D RID: 129853 RVA: 0x004683A1 File Offset: 0x004665A1
		public static void StartICheckJigsawItemPlaceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601FB3E RID: 129854 RVA: 0x004683AA File Offset: 0x004665AA
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB3F RID: 129855 RVA: 0x004683B5 File Offset: 0x004665B5
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x0601FB40 RID: 129856 RVA: 0x004683C0 File Offset: 0x004665C0
		public static void AddFoundationEntityId(FlatBufferBuilder builder, int foundationEntityId)
		{
			builder.AddInt(2, foundationEntityId, 0);
		}

		// Token: 0x0601FB41 RID: 129857 RVA: 0x004683CB File Offset: 0x004665CB
		public static void AddPlaceIndex(FlatBufferBuilder builder, Offset<IPieceIndex> placeIndexOffset)
		{
			builder.AddOffset(3, placeIndexOffset.Value, 0);
		}

		// Token: 0x0601FB42 RID: 129858 RVA: 0x004683DB File Offset: 0x004665DB
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x0601FB43 RID: 129859 RVA: 0x004683E6 File Offset: 0x004665E6
		public static Offset<ICheckJigsawItemPlaceIndex> EndICheckJigsawItemPlaceIndex(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawItemPlaceIndex>(builder.EndTable());
		}

		// Token: 0x0601FB44 RID: 129860 RVA: 0x004683F4 File Offset: 0x004665F4
		public ICheckJigsawItemPlaceIndexT UnPack()
		{
			ICheckJigsawItemPlaceIndexT checkJigsawItemPlaceIndexT = new ICheckJigsawItemPlaceIndexT();
			this.UnPackTo(checkJigsawItemPlaceIndexT);
			return checkJigsawItemPlaceIndexT;
		}

		// Token: 0x0601FB45 RID: 129861 RVA: 0x00468410 File Offset: 0x00466610
		public void UnPackTo(ICheckJigsawItemPlaceIndexT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.FoundationEntityId = this.FoundationEntityId;
			_o.PlaceIndex = ((this.PlaceIndex != null) ? this.PlaceIndex.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x0601FB46 RID: 129862 RVA: 0x0046847C File Offset: 0x0046667C
		public static Offset<ICheckJigsawItemPlaceIndex> Pack(FlatBufferBuilder builder, ICheckJigsawItemPlaceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawItemPlaceIndex>);
			}
			Offset<IPieceIndex> placeIndexOffset = (_o.PlaceIndex == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.PlaceIndex);
			return ICheckJigsawItemPlaceIndex.CreateICheckJigsawItemPlaceIndex(builder, _o.Type, _o.ItemEntityId, _o.FoundationEntityId, placeIndexOffset, _o.Compare);
		}

		// Token: 0x0400DE15 RID: 56853
		private Table __p;
	}
}
