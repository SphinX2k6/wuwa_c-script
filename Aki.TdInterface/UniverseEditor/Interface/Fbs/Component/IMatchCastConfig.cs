using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA7 RID: 23207
	public struct IMatchCastConfig : IFlatbufferObject
	{
		// Token: 0x1700A914 RID: 43284
		// (get) Token: 0x0602609D RID: 155805 RVA: 0x005365B4 File Offset: 0x005347B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602609E RID: 155806 RVA: 0x005365C1 File Offset: 0x005347C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602609F RID: 155807 RVA: 0x005365C8 File Offset: 0x005347C8
		public static IMatchCastConfig GetRootAsIMatchCastConfig(ByteBuffer _bb)
		{
			return IMatchCastConfig.GetRootAsIMatchCastConfig(_bb, default(IMatchCastConfig));
		}

		// Token: 0x060260A0 RID: 155808 RVA: 0x005365E4 File Offset: 0x005347E4
		public static IMatchCastConfig GetRootAsIMatchCastConfig(ByteBuffer _bb, IMatchCastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260A1 RID: 155809 RVA: 0x00536601 File Offset: 0x00534801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260A2 RID: 155810 RVA: 0x00536610 File Offset: 0x00534810
		public IMatchCastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A915 RID: 43285
		// (get) Token: 0x060260A3 RID: 155811 RVA: 0x00536620 File Offset: 0x00534820
		public int Time
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

		// Token: 0x1700A916 RID: 43286
		// (get) Token: 0x060260A4 RID: 155812 RVA: 0x0053665C File Offset: 0x0053485C
		public string Spline
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060260A5 RID: 155813 RVA: 0x00536693 File Offset: 0x00534893
		public Span<byte> GetSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060260A6 RID: 155814 RVA: 0x005366A2 File Offset: 0x005348A2
		public byte[] GetSplineArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060260A7 RID: 155815 RVA: 0x005366B0 File Offset: 0x005348B0
		public IMatchSequence? MatchSequence(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMatchSequence?(default(IMatchSequence).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A917 RID: 43287
		// (get) Token: 0x060260A8 RID: 155816 RVA: 0x00536710 File Offset: 0x00534910
		public int MatchSequenceLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A918 RID: 43288
		// (get) Token: 0x060260A9 RID: 155817 RVA: 0x0053673C File Offset: 0x0053493C
		public string SpeedCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060260AA RID: 155818 RVA: 0x00536774 File Offset: 0x00534974
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060260AB RID: 155819 RVA: 0x00536784 File Offset: 0x00534984
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A919 RID: 43289
		// (get) Token: 0x060260AC RID: 155820 RVA: 0x00536794 File Offset: 0x00534994
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060260AD RID: 155821 RVA: 0x005367D1 File Offset: 0x005349D1
		public static Offset<IMatchCastConfig> CreateIMatchCastConfig(FlatBufferBuilder builder, int Time = 0, StringOffset SplineOffset = default(StringOffset), VectorOffset MatchSequenceOffset = default(VectorOffset), StringOffset SpeedCurveOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IMatchCastConfig.AddSpeedCurve(builder, SpeedCurveOffset);
			IMatchCastConfig.AddMatchSequence(builder, MatchSequenceOffset);
			IMatchCastConfig.AddSpline(builder, SplineOffset);
			IMatchCastConfig.AddTime(builder, Time);
			IMatchCastConfig.AddNullMask(builder, NullMask);
			return IMatchCastConfig.EndIMatchCastConfig(builder);
		}

		// Token: 0x060260AE RID: 155822 RVA: 0x00536805 File Offset: 0x00534A05
		public static void StartIMatchCastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060260AF RID: 155823 RVA: 0x0053680E File Offset: 0x00534A0E
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x060260B0 RID: 155824 RVA: 0x00536819 File Offset: 0x00534A19
		public static void AddSpline(FlatBufferBuilder builder, StringOffset splineOffset)
		{
			builder.AddOffset(1, splineOffset.Value, 0);
		}

		// Token: 0x060260B1 RID: 155825 RVA: 0x00536829 File Offset: 0x00534A29
		public static void AddMatchSequence(FlatBufferBuilder builder, VectorOffset matchSequenceOffset)
		{
			builder.AddOffset(2, matchSequenceOffset.Value, 0);
		}

		// Token: 0x060260B2 RID: 155826 RVA: 0x0053683C File Offset: 0x00534A3C
		public static VectorOffset CreateMatchSequenceVector(FlatBufferBuilder builder, Offset<IMatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060260B3 RID: 155827 RVA: 0x0053687C File Offset: 0x00534A7C
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, Offset<IMatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x060260B4 RID: 155828 RVA: 0x00536896 File Offset: 0x00534A96
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMatchSequence>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x060260B5 RID: 155829 RVA: 0x005368B4 File Offset: 0x00534AB4
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMatchSequence>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060260B6 RID: 155830 RVA: 0x005368CD File Offset: 0x00534ACD
		public static void StartMatchSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060260B7 RID: 155831 RVA: 0x005368D8 File Offset: 0x00534AD8
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(3, speedCurveOffset.Value, 0);
		}

		// Token: 0x060260B8 RID: 155832 RVA: 0x005368E8 File Offset: 0x00534AE8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060260B9 RID: 155833 RVA: 0x005368F3 File Offset: 0x00534AF3
		public static Offset<IMatchCastConfig> EndIMatchCastConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMatchCastConfig>(builder.EndTable());
		}

		// Token: 0x060260BA RID: 155834 RVA: 0x00536900 File Offset: 0x00534B00
		public IMatchCastConfigT UnPack()
		{
			IMatchCastConfigT matchCastConfigT = new IMatchCastConfigT();
			this.UnPackTo(matchCastConfigT);
			return matchCastConfigT;
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x0053691C File Offset: 0x00534B1C
		public void UnPackTo(IMatchCastConfigT _o)
		{
			_o.Time = this.Time;
			_o.Spline = this.Spline;
			_o.MatchSequence = new List<IMatchSequenceT>();
			for (int i = 0; i < this.MatchSequenceLength; i++)
			{
				_o.MatchSequence.Add((this.MatchSequence(i) != null) ? this.MatchSequence(i).Value.UnPack() : null);
			}
			_o.SpeedCurve = this.SpeedCurve;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x005369AC File Offset: 0x00534BAC
		public static Offset<IMatchCastConfig> Pack(FlatBufferBuilder builder, IMatchCastConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchCastConfig>);
			}
			StringOffset splineOffset = (_o.Spline == null) ? default(StringOffset) : builder.CreateString(_o.Spline);
			VectorOffset matchSequenceOffset = default(VectorOffset);
			if (_o.MatchSequence != null)
			{
				Offset<IMatchSequence>[] array = new Offset<IMatchSequence>[_o.MatchSequence.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMatchSequence.Pack(builder, _o.MatchSequence[i]);
				}
				matchSequenceOffset = IMatchCastConfig.CreateMatchSequenceVector(builder, array);
			}
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return IMatchCastConfig.CreateIMatchCastConfig(builder, _o.Time, splineOffset, matchSequenceOffset, speedCurveOffset, _o.NullMask);
		}

		// Token: 0x0400F444 RID: 62532
		private Table __p;
	}
}
