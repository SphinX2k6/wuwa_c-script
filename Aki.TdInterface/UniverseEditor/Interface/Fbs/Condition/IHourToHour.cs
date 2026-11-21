using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005133 RID: 20787
	public struct IHourToHour : IFlatbufferObject
	{
		// Token: 0x170094F7 RID: 38135
		// (get) Token: 0x06020B07 RID: 133895 RVA: 0x004878C6 File Offset: 0x00485AC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B08 RID: 133896 RVA: 0x004878D3 File Offset: 0x00485AD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B09 RID: 133897 RVA: 0x004878DC File Offset: 0x00485ADC
		public static IHourToHour GetRootAsIHourToHour(ByteBuffer _bb)
		{
			return IHourToHour.GetRootAsIHourToHour(_bb, default(IHourToHour));
		}

		// Token: 0x06020B0A RID: 133898 RVA: 0x004878F8 File Offset: 0x00485AF8
		public static IHourToHour GetRootAsIHourToHour(ByteBuffer _bb, IHourToHour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B0B RID: 133899 RVA: 0x00487915 File Offset: 0x00485B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B0C RID: 133900 RVA: 0x00487924 File Offset: 0x00485B24
		public IHourToHour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094F8 RID: 38136
		// (get) Token: 0x06020B0D RID: 133901 RVA: 0x00487934 File Offset: 0x00485B34
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

		// Token: 0x170094F9 RID: 38137
		// (get) Token: 0x06020B0E RID: 133902 RVA: 0x00487994 File Offset: 0x00485B94
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

		// Token: 0x06020B0F RID: 133903 RVA: 0x004879F1 File Offset: 0x00485BF1
		public static Offset<IHourToHour> CreateIHourToHour(FlatBufferBuilder builder, Offset<IHour> StartOffset = default(Offset<IHour>), Offset<IHour> EndOffset = default(Offset<IHour>))
		{
			builder.StartTable(2);
			IHourToHour.AddEnd(builder, EndOffset);
			IHourToHour.AddStart(builder, StartOffset);
			return IHourToHour.EndIHourToHour(builder);
		}

		// Token: 0x06020B10 RID: 133904 RVA: 0x00487A0E File Offset: 0x00485C0E
		public static void StartIHourToHour(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B11 RID: 133905 RVA: 0x00487A17 File Offset: 0x00485C17
		public static void AddStart(FlatBufferBuilder builder, Offset<IHour> startOffset)
		{
			builder.AddOffset(0, startOffset.Value, 0);
		}

		// Token: 0x06020B12 RID: 133906 RVA: 0x00487A27 File Offset: 0x00485C27
		public static void AddEnd(FlatBufferBuilder builder, Offset<IHour> endOffset)
		{
			builder.AddOffset(1, endOffset.Value, 0);
		}

		// Token: 0x06020B13 RID: 133907 RVA: 0x00487A37 File Offset: 0x00485C37
		public static Offset<IHourToHour> EndIHourToHour(FlatBufferBuilder builder)
		{
			return new Offset<IHourToHour>(builder.EndTable());
		}

		// Token: 0x06020B14 RID: 133908 RVA: 0x00487A44 File Offset: 0x00485C44
		public IHourToHourT UnPack()
		{
			IHourToHourT hourToHourT = new IHourToHourT();
			this.UnPackTo(hourToHourT);
			return hourToHourT;
		}

		// Token: 0x06020B15 RID: 133909 RVA: 0x00487A60 File Offset: 0x00485C60
		public void UnPackTo(IHourToHourT _o)
		{
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
		}

		// Token: 0x06020B16 RID: 133910 RVA: 0x00487ACC File Offset: 0x00485CCC
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

		// Token: 0x0400E104 RID: 57604
		private Table __p;
	}
}
