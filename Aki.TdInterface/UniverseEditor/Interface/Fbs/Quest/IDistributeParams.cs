using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DDC RID: 15836
	public struct IDistributeParams : IFlatbufferObject
	{
		// Token: 0x17006D5A RID: 27994
		// (get) Token: 0x060161DD RID: 90589 RVA: 0x00332473 File Offset: 0x00330673
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161DE RID: 90590 RVA: 0x00332480 File Offset: 0x00330680
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161DF RID: 90591 RVA: 0x00332488 File Offset: 0x00330688
		public static IDistributeParams GetRootAsIDistributeParams(ByteBuffer _bb)
		{
			return IDistributeParams.GetRootAsIDistributeParams(_bb, default(IDistributeParams));
		}

		// Token: 0x060161E0 RID: 90592 RVA: 0x003324A4 File Offset: 0x003306A4
		public static IDistributeParams GetRootAsIDistributeParams(ByteBuffer _bb, IDistributeParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161E1 RID: 90593 RVA: 0x003324C1 File Offset: 0x003306C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161E2 RID: 90594 RVA: 0x003324D0 File Offset: 0x003306D0
		public IDistributeParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D5B RID: 27995
		// (get) Token: 0x060161E3 RID: 90595 RVA: 0x003324E0 File Offset: 0x003306E0
		public int InformationViewCheck
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D5C RID: 27996
		// (get) Token: 0x060161E4 RID: 90596 RVA: 0x0033251C File Offset: 0x0033071C
		public IItemConfig? UseItem
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006D5D RID: 27997
		// (get) Token: 0x060161E5 RID: 90597 RVA: 0x0033257C File Offset: 0x0033077C
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

		// Token: 0x060161E6 RID: 90598 RVA: 0x003325B8 File Offset: 0x003307B8
		public static Offset<IDistributeParams> CreateIDistributeParams(FlatBufferBuilder builder, int InformationViewCheck = 0, Offset<IItemConfig> UseItemOffset = default(Offset<IItemConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDistributeParams.AddUseItem(builder, UseItemOffset);
			IDistributeParams.AddInformationViewCheck(builder, InformationViewCheck);
			IDistributeParams.AddNullMask(builder, NullMask);
			return IDistributeParams.EndIDistributeParams(builder);
		}

		// Token: 0x060161E7 RID: 90599 RVA: 0x003325DC File Offset: 0x003307DC
		public static void StartIDistributeParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060161E8 RID: 90600 RVA: 0x003325E5 File Offset: 0x003307E5
		public static void AddInformationViewCheck(FlatBufferBuilder builder, int informationViewCheck)
		{
			builder.AddInt(0, informationViewCheck, 0);
		}

		// Token: 0x060161E9 RID: 90601 RVA: 0x003325F0 File Offset: 0x003307F0
		public static void AddUseItem(FlatBufferBuilder builder, Offset<IItemConfig> useItemOffset)
		{
			builder.AddOffset(1, useItemOffset.Value, 0);
		}

		// Token: 0x060161EA RID: 90602 RVA: 0x00332600 File Offset: 0x00330800
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060161EB RID: 90603 RVA: 0x0033260B File Offset: 0x0033080B
		public static Offset<IDistributeParams> EndIDistributeParams(FlatBufferBuilder builder)
		{
			return new Offset<IDistributeParams>(builder.EndTable());
		}

		// Token: 0x060161EC RID: 90604 RVA: 0x00332618 File Offset: 0x00330818
		public IDistributeParamsT UnPack()
		{
			IDistributeParamsT distributeParamsT = new IDistributeParamsT();
			this.UnPackTo(distributeParamsT);
			return distributeParamsT;
		}

		// Token: 0x060161ED RID: 90605 RVA: 0x00332634 File Offset: 0x00330834
		public void UnPackTo(IDistributeParamsT _o)
		{
			_o.InformationViewCheck = this.InformationViewCheck;
			_o.UseItem = ((this.UseItem != null) ? this.UseItem.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060161EE RID: 90606 RVA: 0x00332688 File Offset: 0x00330888
		public static Offset<IDistributeParams> Pack(FlatBufferBuilder builder, IDistributeParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDistributeParams>);
			}
			Offset<IItemConfig> useItemOffset = (_o.UseItem == null) ? default(Offset<IItemConfig>) : IItemConfig.Pack(builder, _o.UseItem);
			return IDistributeParams.CreateIDistributeParams(builder, _o.InformationViewCheck, useItemOffset, _o.NullMask);
		}

		// Token: 0x0400B723 RID: 46883
		private Table __p;
	}
}
