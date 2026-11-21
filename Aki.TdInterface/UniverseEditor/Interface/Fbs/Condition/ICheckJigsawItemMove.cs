using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F80 RID: 20352
	public struct ICheckJigsawItemMove : IFlatbufferObject
	{
		// Token: 0x17009184 RID: 37252
		// (get) Token: 0x0601FB17 RID: 129815 RVA: 0x00467F20 File Offset: 0x00466120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB18 RID: 129816 RVA: 0x00467F2D File Offset: 0x0046612D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB19 RID: 129817 RVA: 0x00467F34 File Offset: 0x00466134
		public static ICheckJigsawItemMove GetRootAsICheckJigsawItemMove(ByteBuffer _bb)
		{
			return ICheckJigsawItemMove.GetRootAsICheckJigsawItemMove(_bb, default(ICheckJigsawItemMove));
		}

		// Token: 0x0601FB1A RID: 129818 RVA: 0x00467F50 File Offset: 0x00466150
		public static ICheckJigsawItemMove GetRootAsICheckJigsawItemMove(ByteBuffer _bb, ICheckJigsawItemMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB1B RID: 129819 RVA: 0x00467F6D File Offset: 0x0046616D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB1C RID: 129820 RVA: 0x00467F7C File Offset: 0x0046617C
		public ICheckJigsawItemMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009185 RID: 37253
		// (get) Token: 0x0601FB1D RID: 129821 RVA: 0x00467F8C File Offset: 0x0046618C
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

		// Token: 0x17009186 RID: 37254
		// (get) Token: 0x0601FB1E RID: 129822 RVA: 0x00467FC8 File Offset: 0x004661C8
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

		// Token: 0x17009187 RID: 37255
		// (get) Token: 0x0601FB1F RID: 129823 RVA: 0x00468004 File Offset: 0x00466204
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB20 RID: 129824 RVA: 0x00468040 File Offset: 0x00466240
		public static Offset<ICheckJigsawItemMove> CreateICheckJigsawItemMove(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex, int ItemEntityId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckJigsawItemMove.AddItemEntityId(builder, ItemEntityId);
			ICheckJigsawItemMove.AddCompare(builder, Compare);
			ICheckJigsawItemMove.AddType(builder, Type);
			return ICheckJigsawItemMove.EndICheckJigsawItemMove(builder);
		}

		// Token: 0x0601FB21 RID: 129825 RVA: 0x00468064 File Offset: 0x00466264
		public static void StartICheckJigsawItemMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FB22 RID: 129826 RVA: 0x0046806D File Offset: 0x0046626D
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB23 RID: 129827 RVA: 0x00468078 File Offset: 0x00466278
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x0601FB24 RID: 129828 RVA: 0x00468083 File Offset: 0x00466283
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601FB25 RID: 129829 RVA: 0x0046808E File Offset: 0x0046628E
		public static Offset<ICheckJigsawItemMove> EndICheckJigsawItemMove(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawItemMove>(builder.EndTable());
		}

		// Token: 0x0601FB26 RID: 129830 RVA: 0x0046809C File Offset: 0x0046629C
		public ICheckJigsawItemMoveT UnPack()
		{
			ICheckJigsawItemMoveT checkJigsawItemMoveT = new ICheckJigsawItemMoveT();
			this.UnPackTo(checkJigsawItemMoveT);
			return checkJigsawItemMoveT;
		}

		// Token: 0x0601FB27 RID: 129831 RVA: 0x004680B7 File Offset: 0x004662B7
		public void UnPackTo(ICheckJigsawItemMoveT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601FB28 RID: 129832 RVA: 0x004680E0 File Offset: 0x004662E0
		public static Offset<ICheckJigsawItemMove> Pack(FlatBufferBuilder builder, ICheckJigsawItemMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawItemMove>);
			}
			return ICheckJigsawItemMove.CreateICheckJigsawItemMove(builder, _o.Type, _o.ItemEntityId, _o.Compare);
		}

		// Token: 0x0400DE11 RID: 56849
		private Table __p;
	}
}
