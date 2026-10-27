using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C43 RID: 19523
	public struct IHourToHourCondition : IFlatbufferObject
	{
		// Token: 0x17008DD3 RID: 36307
		// (get) Token: 0x0601EF19 RID: 126745 RVA: 0x004542F7 File Offset: 0x004524F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF1A RID: 126746 RVA: 0x00454304 File Offset: 0x00452504
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF1B RID: 126747 RVA: 0x0045430C File Offset: 0x0045250C
		public static IHourToHourCondition GetRootAsIHourToHourCondition(ByteBuffer _bb)
		{
			return IHourToHourCondition.GetRootAsIHourToHourCondition(_bb, default(IHourToHourCondition));
		}

		// Token: 0x0601EF1C RID: 126748 RVA: 0x00454328 File Offset: 0x00452528
		public static IHourToHourCondition GetRootAsIHourToHourCondition(ByteBuffer _bb, IHourToHourCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF1D RID: 126749 RVA: 0x00454345 File Offset: 0x00452545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF1E RID: 126750 RVA: 0x00454354 File Offset: 0x00452554
		public IHourToHourCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DD4 RID: 36308
		// (get) Token: 0x0601EF1F RID: 126751 RVA: 0x00454364 File Offset: 0x00452564
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

		// Token: 0x17008DD5 RID: 36309
		// (get) Token: 0x0601EF20 RID: 126752 RVA: 0x004543A0 File Offset: 0x004525A0
		public IHour? Start
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHour?(default(IHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008DD6 RID: 36310
		// (get) Token: 0x0601EF21 RID: 126753 RVA: 0x00454400 File Offset: 0x00452600
		public IHour? End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IHour?(default(IHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008DD7 RID: 36311
		// (get) Token: 0x0601EF22 RID: 126754 RVA: 0x00454460 File Offset: 0x00452660
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF23 RID: 126755 RVA: 0x0045449D File Offset: 0x0045269D
		public static Offset<IHourToHourCondition> CreateIHourToHourCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IHour> StartOffset = default(Offset<IHour>), Offset<IHour> EndOffset = default(Offset<IHour>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			IHourToHourCondition.AddEnd(builder, EndOffset);
			IHourToHourCondition.AddStart(builder, StartOffset);
			IHourToHourCondition.AddCompare(builder, Compare);
			IHourToHourCondition.AddType(builder, Type);
			return IHourToHourCondition.EndIHourToHourCondition(builder);
		}

		// Token: 0x0601EF24 RID: 126756 RVA: 0x004544C9 File Offset: 0x004526C9
		public static void StartIHourToHourCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EF25 RID: 126757 RVA: 0x004544D2 File Offset: 0x004526D2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF26 RID: 126758 RVA: 0x004544DD File Offset: 0x004526DD
		public static void AddStart(FlatBufferBuilder builder, Offset<IHour> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x0601EF27 RID: 126759 RVA: 0x004544ED File Offset: 0x004526ED
		public static void AddEnd(FlatBufferBuilder builder, Offset<IHour> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x0601EF28 RID: 126760 RVA: 0x004544FD File Offset: 0x004526FD
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601EF29 RID: 126761 RVA: 0x00454508 File Offset: 0x00452708
		public static Offset<IHourToHourCondition> EndIHourToHourCondition(FlatBufferBuilder builder)
		{
			return new Offset<IHourToHourCondition>(builder.EndTable());
		}

		// Token: 0x0601EF2A RID: 126762 RVA: 0x00454518 File Offset: 0x00452718
		public IHourToHourConditionT UnPack()
		{
			IHourToHourConditionT hourToHourConditionT = new IHourToHourConditionT();
			this.UnPackTo(hourToHourConditionT);
			return hourToHourConditionT;
		}

		// Token: 0x0601EF2B RID: 126763 RVA: 0x00454534 File Offset: 0x00452734
		public void UnPackTo(IHourToHourConditionT _o)
		{
			_o.Type = this.Type;
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x0601EF2C RID: 126764 RVA: 0x004545B8 File Offset: 0x004527B8
		public static Offset<IHourToHourCondition> Pack(FlatBufferBuilder builder, IHourToHourConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHourToHourCondition>);
			}
			Offset<IHour> startOffset = (_o.Start == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.Start);
			Offset<IHour> endOffset = (_o.End == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.End);
			return IHourToHourCondition.CreateIHourToHourCondition(builder, _o.Type, startOffset, endOffset, _o.Compare);
		}

		// Token: 0x0400D5E8 RID: 54760
		private Table __p;
	}
}
