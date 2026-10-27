using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C40 RID: 19520
	public struct IHourToHour : IFlatbufferObject
	{
		// Token: 0x17008DCE RID: 36302
		// (get) Token: 0x0601EF03 RID: 126723 RVA: 0x00453FEA File Offset: 0x004521EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF04 RID: 126724 RVA: 0x00453FF7 File Offset: 0x004521F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF05 RID: 126725 RVA: 0x00454000 File Offset: 0x00452200
		public static IHourToHour GetRootAsIHourToHour(ByteBuffer _bb)
		{
			return IHourToHour.GetRootAsIHourToHour(_bb, default(IHourToHour));
		}

		// Token: 0x0601EF06 RID: 126726 RVA: 0x0045401C File Offset: 0x0045221C
		public static IHourToHour GetRootAsIHourToHour(ByteBuffer _bb, IHourToHour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF07 RID: 126727 RVA: 0x00454039 File Offset: 0x00452239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF08 RID: 126728 RVA: 0x00454048 File Offset: 0x00452248
		public IHourToHour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DCF RID: 36303
		// (get) Token: 0x0601EF09 RID: 126729 RVA: 0x00454058 File Offset: 0x00452258
		public IHour? Start
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IHour?(default(IHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008DD0 RID: 36304
		// (get) Token: 0x0601EF0A RID: 126730 RVA: 0x004540B8 File Offset: 0x004522B8
		public IHour? End
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

		// Token: 0x0601EF0B RID: 126731 RVA: 0x00454115 File Offset: 0x00452315
		public static Offset<IHourToHour> CreateIHourToHour(FlatBufferBuilder builder, Offset<IHour> StartOffset = default(Offset<IHour>), Offset<IHour> EndOffset = default(Offset<IHour>))
		{
			builder.StartTable(2);
			IHourToHour.AddEnd(builder, EndOffset);
			IHourToHour.AddStart(builder, StartOffset);
			return IHourToHour.EndIHourToHour(builder);
		}

		// Token: 0x0601EF0C RID: 126732 RVA: 0x00454132 File Offset: 0x00452332
		public static void StartIHourToHour(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EF0D RID: 126733 RVA: 0x0045413B File Offset: 0x0045233B
		public static void AddStart(FlatBufferBuilder builder, Offset<IHour> startOffset)
		{
			builder.AddOffset(0, startOffset.Value, 0);
		}

		// Token: 0x0601EF0E RID: 126734 RVA: 0x0045414B File Offset: 0x0045234B
		public static void AddEnd(FlatBufferBuilder builder, Offset<IHour> endOffset)
		{
			builder.AddOffset(1, endOffset.Value, 0);
		}

		// Token: 0x0601EF0F RID: 126735 RVA: 0x0045415B File Offset: 0x0045235B
		public static Offset<IHourToHour> EndIHourToHour(FlatBufferBuilder builder)
		{
			return new Offset<IHourToHour>(builder.EndTable());
		}

		// Token: 0x0601EF10 RID: 126736 RVA: 0x00454168 File Offset: 0x00452368
		public IHourToHourT UnPack()
		{
			IHourToHourT hourToHourT = new IHourToHourT();
			this.UnPackTo(hourToHourT);
			return hourToHourT;
		}

		// Token: 0x0601EF11 RID: 126737 RVA: 0x00454184 File Offset: 0x00452384
		public void UnPackTo(IHourToHourT _o)
		{
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
		}

		// Token: 0x0601EF12 RID: 126738 RVA: 0x004541F0 File Offset: 0x004523F0
		public static Offset<IHourToHour> Pack(FlatBufferBuilder builder, IHourToHourT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHourToHour>);
			}
			Offset<IHour> startOffset = (_o.Start == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.Start);
			Offset<IHour> endOffset = (_o.End == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.End);
			return IHourToHour.CreateIHourToHour(builder, startOffset, endOffset);
		}

		// Token: 0x0400D5E5 RID: 54757
		private Table __p;
	}
}
