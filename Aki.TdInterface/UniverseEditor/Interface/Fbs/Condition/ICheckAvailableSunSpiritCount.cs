using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004988 RID: 18824
	public struct ICheckAvailableSunSpiritCount : IFlatbufferObject
	{
		// Token: 0x170087F4 RID: 34804
		// (get) Token: 0x0601D58E RID: 120206 RVA: 0x004235A8 File Offset: 0x004217A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D58F RID: 120207 RVA: 0x004235B5 File Offset: 0x004217B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D590 RID: 120208 RVA: 0x004235BC File Offset: 0x004217BC
		public static ICheckAvailableSunSpiritCount GetRootAsICheckAvailableSunSpiritCount(ByteBuffer _bb)
		{
			return ICheckAvailableSunSpiritCount.GetRootAsICheckAvailableSunSpiritCount(_bb, default(ICheckAvailableSunSpiritCount));
		}

		// Token: 0x0601D591 RID: 120209 RVA: 0x004235D8 File Offset: 0x004217D8
		public static ICheckAvailableSunSpiritCount GetRootAsICheckAvailableSunSpiritCount(ByteBuffer _bb, ICheckAvailableSunSpiritCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x004235F5 File Offset: 0x004217F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x00423604 File Offset: 0x00421804
		public ICheckAvailableSunSpiritCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087F5 RID: 34805
		// (get) Token: 0x0601D594 RID: 120212 RVA: 0x00423614 File Offset: 0x00421814
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170087F6 RID: 34806
		// (get) Token: 0x0601D595 RID: 120213 RVA: 0x00423650 File Offset: 0x00421850
		public int AreaId
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

		// Token: 0x170087F7 RID: 34807
		// (get) Token: 0x0601D596 RID: 120214 RVA: 0x0042368C File Offset: 0x0042188C
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

		// Token: 0x170087F8 RID: 34808
		// (get) Token: 0x0601D597 RID: 120215 RVA: 0x004236C8 File Offset: 0x004218C8
		public int Count
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D598 RID: 120216 RVA: 0x00423705 File Offset: 0x00421905
		public static Offset<ICheckAvailableSunSpiritCount> CreateICheckAvailableSunSpiritCount(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0, ECompare Compare = ECompare.Eq, int Count = 0)
		{
			builder.StartTable(4);
			ICheckAvailableSunSpiritCount.AddCount(builder, Count);
			ICheckAvailableSunSpiritCount.AddAreaId(builder, AreaId);
			ICheckAvailableSunSpiritCount.AddCompare(builder, Compare);
			ICheckAvailableSunSpiritCount.AddType(builder, Type);
			return ICheckAvailableSunSpiritCount.EndICheckAvailableSunSpiritCount(builder);
		}

		// Token: 0x0601D599 RID: 120217 RVA: 0x00423731 File Offset: 0x00421931
		public static void StartICheckAvailableSunSpiritCount(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D59A RID: 120218 RVA: 0x0042373A File Offset: 0x0042193A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D59B RID: 120219 RVA: 0x00423745 File Offset: 0x00421945
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601D59C RID: 120220 RVA: 0x00423750 File Offset: 0x00421950
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601D59D RID: 120221 RVA: 0x0042375B File Offset: 0x0042195B
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x00423766 File Offset: 0x00421966
		public static Offset<ICheckAvailableSunSpiritCount> EndICheckAvailableSunSpiritCount(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAvailableSunSpiritCount>(builder.EndTable());
		}

		// Token: 0x0601D59F RID: 120223 RVA: 0x00423774 File Offset: 0x00421974
		public ICheckAvailableSunSpiritCountT UnPack()
		{
			ICheckAvailableSunSpiritCountT checkAvailableSunSpiritCountT = new ICheckAvailableSunSpiritCountT();
			this.UnPackTo(checkAvailableSunSpiritCountT);
			return checkAvailableSunSpiritCountT;
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x0042378F File Offset: 0x0042198F
		public void UnPackTo(ICheckAvailableSunSpiritCountT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.Compare = this.Compare;
			_o.Count = this.Count;
		}

		// Token: 0x0601D5A1 RID: 120225 RVA: 0x004237C4 File Offset: 0x004219C4
		public static Offset<ICheckAvailableSunSpiritCount> Pack(FlatBufferBuilder builder, ICheckAvailableSunSpiritCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAvailableSunSpiritCount>);
			}
			return ICheckAvailableSunSpiritCount.CreateICheckAvailableSunSpiritCount(builder, _o.Type, _o.AreaId, _o.Compare, _o.Count);
		}

		// Token: 0x0400D194 RID: 53652
		private Table __p;
	}
}
