using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B2D RID: 31533
	public struct ITalkOptionVisualNovel : IFlatbufferObject
	{
		// Token: 0x1700EC30 RID: 60464
		// (get) Token: 0x06038C81 RID: 232577 RVA: 0x007ADB9F File Offset: 0x007ABD9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C82 RID: 232578 RVA: 0x007ADBAC File Offset: 0x007ABDAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C83 RID: 232579 RVA: 0x007ADBB4 File Offset: 0x007ABDB4
		public static ITalkOptionVisualNovel GetRootAsITalkOptionVisualNovel(ByteBuffer _bb)
		{
			return ITalkOptionVisualNovel.GetRootAsITalkOptionVisualNovel(_bb, default(ITalkOptionVisualNovel));
		}

		// Token: 0x06038C84 RID: 232580 RVA: 0x007ADBD0 File Offset: 0x007ABDD0
		public static ITalkOptionVisualNovel GetRootAsITalkOptionVisualNovel(ByteBuffer _bb, ITalkOptionVisualNovel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C85 RID: 232581 RVA: 0x007ADBED File Offset: 0x007ABDED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C86 RID: 232582 RVA: 0x007ADBFC File Offset: 0x007ABDFC
		public ITalkOptionVisualNovel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC31 RID: 60465
		// (get) Token: 0x06038C87 RID: 232583 RVA: 0x007ADC0C File Offset: 0x007ABE0C
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC32 RID: 60466
		// (get) Token: 0x06038C88 RID: 232584 RVA: 0x007ADC48 File Offset: 0x007ABE48
		public int PlotOptionId
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

		// Token: 0x06038C89 RID: 232585 RVA: 0x007ADC84 File Offset: 0x007ABE84
		public TVisualNovelPerformance OptionPerformancesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EC33 RID: 60467
		// (get) Token: 0x06038C8A RID: 232586 RVA: 0x007ADCC4 File Offset: 0x007ABEC4
		public int OptionPerformancesTypeLength
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

		// Token: 0x06038C8B RID: 232587 RVA: 0x007ADCEF File Offset: 0x007ABEEF
		public Span<TVisualNovelPerformance> GetOptionPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(8, 1);
		}

		// Token: 0x06038C8C RID: 232588 RVA: 0x007ADD00 File Offset: 0x007ABF00
		public TVisualNovelPerformance[] GetOptionPerformancesTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVisualNovelPerformance[] array = new TVisualNovelPerformance[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVisualNovelPerformance)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06038C8D RID: 232589 RVA: 0x007ADD6C File Offset: 0x007ABF6C
		public TTable? OptionPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EC34 RID: 60468
		// (get) Token: 0x06038C8E RID: 232590 RVA: 0x007ADDB4 File Offset: 0x007ABFB4
		public int OptionPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700EC35 RID: 60469
		// (get) Token: 0x06038C8F RID: 232591 RVA: 0x007ADDE0 File Offset: 0x007ABFE0
		public ITalkOptionVisualNovelDoubleConfirm? DoubleConfirm
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITalkOptionVisualNovelDoubleConfirm?(default(ITalkOptionVisualNovelDoubleConfirm).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EC36 RID: 60470
		// (get) Token: 0x06038C90 RID: 232592 RVA: 0x007ADE40 File Offset: 0x007AC040
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038C91 RID: 232593 RVA: 0x007ADE7D File Offset: 0x007AC07D
		public static Offset<ITalkOptionVisualNovel> CreateITalkOptionVisualNovel(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int PlotOptionId = 0, VectorOffset OptionPerformances_typeOffset = default(VectorOffset), VectorOffset OptionPerformancesOffset = default(VectorOffset), Offset<ITalkOptionVisualNovelDoubleConfirm> DoubleConfirmOffset = default(Offset<ITalkOptionVisualNovelDoubleConfirm>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ITalkOptionVisualNovel.AddDoubleConfirm(builder, DoubleConfirmOffset);
			ITalkOptionVisualNovel.AddOptionPerformances(builder, OptionPerformancesOffset);
			ITalkOptionVisualNovel.AddOptionPerformancesType(builder, OptionPerformances_typeOffset);
			ITalkOptionVisualNovel.AddPlotOptionId(builder, PlotOptionId);
			ITalkOptionVisualNovel.AddNullMask(builder, NullMask);
			ITalkOptionVisualNovel.AddType(builder, Type);
			return ITalkOptionVisualNovel.EndITalkOptionVisualNovel(builder);
		}

		// Token: 0x06038C92 RID: 232594 RVA: 0x007ADEB9 File Offset: 0x007AC0B9
		public static void StartITalkOptionVisualNovel(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06038C93 RID: 232595 RVA: 0x007ADEC2 File Offset: 0x007AC0C2
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C94 RID: 232596 RVA: 0x007ADECD File Offset: 0x007AC0CD
		public static void AddPlotOptionId(FlatBufferBuilder builder, int plotOptionId)
		{
			builder.AddInt(1, plotOptionId, 0);
		}

		// Token: 0x06038C95 RID: 232597 RVA: 0x007ADED8 File Offset: 0x007AC0D8
		public static void AddOptionPerformancesType(FlatBufferBuilder builder, VectorOffset optionPerformancesTypeOffset)
		{
			builder.AddOffset(2, optionPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06038C96 RID: 232598 RVA: 0x007ADEE8 File Offset: 0x007AC0E8
		public static VectorOffset CreateOptionPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038C97 RID: 232599 RVA: 0x007ADF1F File Offset: 0x007AC11F
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038C98 RID: 232600 RVA: 0x007ADF39 File Offset: 0x007AC139
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038C99 RID: 232601 RVA: 0x007ADF57 File Offset: 0x007AC157
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038C9A RID: 232602 RVA: 0x007ADF70 File Offset: 0x007AC170
		public static void StartOptionPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038C9B RID: 232603 RVA: 0x007ADF7B File Offset: 0x007AC17B
		public static void AddOptionPerformances(FlatBufferBuilder builder, VectorOffset optionPerformancesOffset)
		{
			builder.AddOffset(3, optionPerformancesOffset.Value, 0);
		}

		// Token: 0x06038C9C RID: 232604 RVA: 0x007ADF8C File Offset: 0x007AC18C
		public static VectorOffset CreateOptionPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038C9D RID: 232605 RVA: 0x007ADFC3 File Offset: 0x007AC1C3
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038C9E RID: 232606 RVA: 0x007ADFDD File Offset: 0x007AC1DD
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038C9F RID: 232607 RVA: 0x007ADFFB File Offset: 0x007AC1FB
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038CA0 RID: 232608 RVA: 0x007AE014 File Offset: 0x007AC214
		public static void StartOptionPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038CA1 RID: 232609 RVA: 0x007AE01F File Offset: 0x007AC21F
		public static void AddDoubleConfirm(FlatBufferBuilder builder, Offset<ITalkOptionVisualNovelDoubleConfirm> doubleConfirmOffset)
		{
			builder.AddOffset(4, doubleConfirmOffset.Value, 0);
		}

		// Token: 0x06038CA2 RID: 232610 RVA: 0x007AE02F File Offset: 0x007AC22F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06038CA3 RID: 232611 RVA: 0x007AE03A File Offset: 0x007AC23A
		public static Offset<ITalkOptionVisualNovel> EndITalkOptionVisualNovel(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionVisualNovel>(builder.EndTable());
		}

		// Token: 0x06038CA4 RID: 232612 RVA: 0x007AE048 File Offset: 0x007AC248
		public ITalkOptionVisualNovelT UnPack()
		{
			ITalkOptionVisualNovelT talkOptionVisualNovelT = new ITalkOptionVisualNovelT();
			this.UnPackTo(talkOptionVisualNovelT);
			return talkOptionVisualNovelT;
		}

		// Token: 0x06038CA5 RID: 232613 RVA: 0x007AE064 File Offset: 0x007AC264
		public void UnPackTo(ITalkOptionVisualNovelT _o)
		{
			_o.Type = this.Type;
			_o.PlotOptionId = this.PlotOptionId;
			_o.OptionPerformances = new List<TVisualNovelPerformanceUnion>();
			for (int i = 0; i < this.OptionPerformancesLength; i++)
			{
				TVisualNovelPerformanceUnion tvisualNovelPerformanceUnion = new TVisualNovelPerformanceUnion();
				tvisualNovelPerformanceUnion.Type = this.OptionPerformancesType(i);
				switch (this.OptionPerformancesType(i))
				{
				case TVisualNovelPerformance.IVisualNovelPerformanceActivityAction:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceActivityAction>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceActivityAction>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceBackgroundMove>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceBackgroundMove>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceCgMove:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceCgMove>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceCgMove>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnter:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceEnter>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceEnter>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceEnterBlackScreen>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceEnterBlackScreen>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceExit:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceExit>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceExit>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceLeaveBlackScreen>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceLeaveBlackScreen>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceModifyRole:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceModifyRole>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceModifyRole>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceMove:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceMove>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceMove>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformancePlayScreenEffect>(i) != null) ? this.OptionPerformances<IVisualNovelPerformancePlayScreenEffect>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformancePortraitEffect>(i) != null) ? this.OptionPerformances<IVisualNovelPerformancePortraitEffect>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceRoleIntroduction>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceRoleIntroduction>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceSendAudioEvent>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceSendAudioEvent>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceStopScreenEffect>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceStopScreenEffect>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceSwitchAudioState>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceSwitchAudioState>(i).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceTransition:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceTransition>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceTransition>(i).Value.UnPack() : null);
					break;
				}
				_o.OptionPerformances.Add(tvisualNovelPerformanceUnion);
			}
			_o.DoubleConfirm = ((this.DoubleConfirm != null) ? this.DoubleConfirm.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038CA6 RID: 232614 RVA: 0x007AE4E0 File Offset: 0x007AC6E0
		public static Offset<ITalkOptionVisualNovel> Pack(FlatBufferBuilder builder, ITalkOptionVisualNovelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionVisualNovel>);
			}
			VectorOffset optionPerformances_typeOffset = default(VectorOffset);
			if (_o.OptionPerformances != null)
			{
				TVisualNovelPerformance[] array = new TVisualNovelPerformance[_o.OptionPerformances.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.OptionPerformances[i].Type;
				}
				optionPerformances_typeOffset = ITalkOptionVisualNovel.CreateOptionPerformancesTypeVector(builder, array);
			}
			VectorOffset optionPerformancesOffset = default(VectorOffset);
			if (_o.OptionPerformances != null)
			{
				int[] array2 = new int[_o.OptionPerformances.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVisualNovelPerformanceUnion.Pack(builder, _o.OptionPerformances[j]);
				}
				optionPerformancesOffset = ITalkOptionVisualNovel.CreateOptionPerformancesVector(builder, array2);
			}
			Offset<ITalkOptionVisualNovelDoubleConfirm> doubleConfirmOffset = (_o.DoubleConfirm == null) ? default(Offset<ITalkOptionVisualNovelDoubleConfirm>) : ITalkOptionVisualNovelDoubleConfirm.Pack(builder, _o.DoubleConfirm);
			return ITalkOptionVisualNovel.CreateITalkOptionVisualNovel(builder, _o.Type, _o.PlotOptionId, optionPerformances_typeOffset, optionPerformancesOffset, doubleConfirmOffset, _o.NullMask);
		}

		// Token: 0x04013157 RID: 78167
		private Table __p;
	}
}
