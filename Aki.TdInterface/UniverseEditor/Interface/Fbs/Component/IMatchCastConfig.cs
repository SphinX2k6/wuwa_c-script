using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005521 RID: 21793
	public struct IMatchCastConfig : IFlatbufferObject
	{
		// Token: 0x1700A0DA RID: 41178
		// (get) Token: 0x06023FE3 RID: 147427 RVA: 0x004F9490 File Offset: 0x004F7690
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023FE4 RID: 147428 RVA: 0x004F949D File Offset: 0x004F769D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023FE5 RID: 147429 RVA: 0x004F94A4 File Offset: 0x004F76A4
		public static IMatchCastConfig GetRootAsIMatchCastConfig(ByteBuffer _bb)
		{
			return IMatchCastConfig.GetRootAsIMatchCastConfig(_bb, default(IMatchCastConfig));
		}

		// Token: 0x06023FE6 RID: 147430 RVA: 0x004F94C0 File Offset: 0x004F76C0
		public static IMatchCastConfig GetRootAsIMatchCastConfig(ByteBuffer _bb, IMatchCastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023FE7 RID: 147431 RVA: 0x004F94DD File Offset: 0x004F76DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023FE8 RID: 147432 RVA: 0x004F94EC File Offset: 0x004F76EC
		public IMatchCastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0DB RID: 41179
		// (get) Token: 0x06023FE9 RID: 147433 RVA: 0x004F94FC File Offset: 0x004F76FC
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

		// Token: 0x1700A0DC RID: 41180
		// (get) Token: 0x06023FEA RID: 147434 RVA: 0x004F9538 File Offset: 0x004F7738
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

		// Token: 0x06023FEB RID: 147435 RVA: 0x004F956F File Offset: 0x004F776F
		public Span<byte> GetSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023FEC RID: 147436 RVA: 0x004F957E File Offset: 0x004F777E
		public byte[] GetSplineArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023FED RID: 147437 RVA: 0x004F958C File Offset: 0x004F778C
		public IMatchSequence? MatchSequence(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMatchSequence?(default(IMatchSequence).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0DD RID: 41181
		// (get) Token: 0x06023FEE RID: 147438 RVA: 0x004F95EC File Offset: 0x004F77EC
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

		// Token: 0x1700A0DE RID: 41182
		// (get) Token: 0x06023FEF RID: 147439 RVA: 0x004F9618 File Offset: 0x004F7818
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

		// Token: 0x06023FF0 RID: 147440 RVA: 0x004F9650 File Offset: 0x004F7850
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06023FF1 RID: 147441 RVA: 0x004F9660 File Offset: 0x004F7860
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A0DF RID: 41183
		// (get) Token: 0x06023FF2 RID: 147442 RVA: 0x004F9670 File Offset: 0x004F7870
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

		// Token: 0x06023FF3 RID: 147443 RVA: 0x004F96AD File Offset: 0x004F78AD
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

		// Token: 0x06023FF4 RID: 147444 RVA: 0x004F96E1 File Offset: 0x004F78E1
		public static void StartIMatchCastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023FF5 RID: 147445 RVA: 0x004F96EA File Offset: 0x004F78EA
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x06023FF6 RID: 147446 RVA: 0x004F96F5 File Offset: 0x004F78F5
		public static void AddSpline(FlatBufferBuilder builder, StringOffset splineOffset)
		{
			builder.AddOffset(1, splineOffset.Value, 0);
		}

		// Token: 0x06023FF7 RID: 147447 RVA: 0x004F9705 File Offset: 0x004F7905
		public static void AddMatchSequence(FlatBufferBuilder builder, VectorOffset matchSequenceOffset)
		{
			builder.AddOffset(2, matchSequenceOffset.Value, 0);
		}

		// Token: 0x06023FF8 RID: 147448 RVA: 0x004F9718 File Offset: 0x004F7918
		public static VectorOffset CreateMatchSequenceVector(FlatBufferBuilder builder, Offset<IMatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023FF9 RID: 147449 RVA: 0x004F9758 File Offset: 0x004F7958
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, Offset<IMatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FFA RID: 147450 RVA: 0x004F9772 File Offset: 0x004F7972
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMatchSequence>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FFB RID: 147451 RVA: 0x004F9790 File Offset: 0x004F7990
		public static VectorOffset CreateMatchSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMatchSequence>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023FFC RID: 147452 RVA: 0x004F97A9 File Offset: 0x004F79A9
		public static void StartMatchSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023FFD RID: 147453 RVA: 0x004F97B4 File Offset: 0x004F79B4
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(3, speedCurveOffset.Value, 0);
		}

		// Token: 0x06023FFE RID: 147454 RVA: 0x004F97C4 File Offset: 0x004F79C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023FFF RID: 147455 RVA: 0x004F97CF File Offset: 0x004F79CF
		public static Offset<IMatchCastConfig> EndIMatchCastConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMatchCastConfig>(builder.EndTable());
		}

		// Token: 0x06024000 RID: 147456 RVA: 0x004F97DC File Offset: 0x004F79DC
		public IMatchCastConfigT UnPack()
		{
			IMatchCastConfigT matchCastConfigT = new IMatchCastConfigT();
			this.UnPackTo(matchCastConfigT);
			return matchCastConfigT;
		}

		// Token: 0x06024001 RID: 147457 RVA: 0x004F97F8 File Offset: 0x004F79F8
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

		// Token: 0x06024002 RID: 147458 RVA: 0x004F9888 File Offset: 0x004F7A88
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

		// Token: 0x0400E813 RID: 59411
		private Table __p;
	}
}
