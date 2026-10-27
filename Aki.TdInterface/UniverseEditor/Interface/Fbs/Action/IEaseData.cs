using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006624 RID: 26148
	public struct IEaseData : IFlatbufferObject
	{
		// Token: 0x1700C242 RID: 49730
		// (get) Token: 0x0602D677 RID: 185975 RVA: 0x0063887C File Offset: 0x00636A7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D678 RID: 185976 RVA: 0x00638889 File Offset: 0x00636A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D679 RID: 185977 RVA: 0x00638890 File Offset: 0x00636A90
		public static IEaseData GetRootAsIEaseData(ByteBuffer _bb)
		{
			return IEaseData.GetRootAsIEaseData(_bb, default(IEaseData));
		}

		// Token: 0x0602D67A RID: 185978 RVA: 0x006388AC File Offset: 0x00636AAC
		public static IEaseData GetRootAsIEaseData(ByteBuffer _bb, IEaseData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D67B RID: 185979 RVA: 0x006388C9 File Offset: 0x00636AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D67C RID: 185980 RVA: 0x006388D8 File Offset: 0x00636AD8
		public IEaseData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C243 RID: 49731
		// (get) Token: 0x0602D67D RID: 185981 RVA: 0x006388E8 File Offset: 0x00636AE8
		public EEaseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseType.Linear;
				}
				return (EEaseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C244 RID: 49732
		// (get) Token: 0x0602D67E RID: 185982 RVA: 0x00638924 File Offset: 0x00636B24
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D67F RID: 185983 RVA: 0x00638964 File Offset: 0x00636B64
		public static Offset<IEaseData> CreateIEaseData(FlatBufferBuilder builder, EEaseType Type = EEaseType.Linear, float Duration = 0f)
		{
			builder.StartTable(2);
			IEaseData.AddDuration(builder, Duration);
			IEaseData.AddType(builder, Type);
			return IEaseData.EndIEaseData(builder);
		}

		// Token: 0x0602D680 RID: 185984 RVA: 0x00638981 File Offset: 0x00636B81
		public static void StartIEaseData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D681 RID: 185985 RVA: 0x0063898A File Offset: 0x00636B8A
		public static void AddType(FlatBufferBuilder builder, EEaseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D682 RID: 185986 RVA: 0x00638995 File Offset: 0x00636B95
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602D683 RID: 185987 RVA: 0x006389A8 File Offset: 0x00636BA8
		public static Offset<IEaseData> EndIEaseData(FlatBufferBuilder builder)
		{
			return new Offset<IEaseData>(builder.EndTable());
		}

		// Token: 0x0602D684 RID: 185988 RVA: 0x006389B8 File Offset: 0x00636BB8
		public IEaseDataT UnPack()
		{
			IEaseDataT easeDataT = new IEaseDataT();
			this.UnPackTo(easeDataT);
			return easeDataT;
		}

		// Token: 0x0602D685 RID: 185989 RVA: 0x006389D3 File Offset: 0x00636BD3
		public void UnPackTo(IEaseDataT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
		}

		// Token: 0x0602D686 RID: 185990 RVA: 0x006389F0 File Offset: 0x00636BF0
		public static Offset<IEaseData> Pack(FlatBufferBuilder builder, IEaseDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseData>);
			}
			return IEaseData.CreateIEaseData(builder, _o.Type, _o.Duration);
		}

		// Token: 0x04010CB4 RID: 68788
		private Table __p;
	}
}
