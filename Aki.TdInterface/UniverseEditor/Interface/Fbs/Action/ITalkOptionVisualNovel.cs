using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007355 RID: 29525
	public struct ITalkOptionVisualNovel : IFlatbufferObject
	{
		// Token: 0x1700E034 RID: 57396
		// (get) Token: 0x0603594E RID: 219470 RVA: 0x0074C017 File Offset: 0x0074A217
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603594F RID: 219471 RVA: 0x0074C024 File Offset: 0x0074A224
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035950 RID: 219472 RVA: 0x0074C02C File Offset: 0x0074A22C
		public static ITalkOptionVisualNovel GetRootAsITalkOptionVisualNovel(ByteBuffer _bb)
		{
			return ITalkOptionVisualNovel.GetRootAsITalkOptionVisualNovel(_bb, default(ITalkOptionVisualNovel));
		}

		// Token: 0x06035951 RID: 219473 RVA: 0x0074C048 File Offset: 0x0074A248
		public static ITalkOptionVisualNovel GetRootAsITalkOptionVisualNovel(ByteBuffer _bb, ITalkOptionVisualNovel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035952 RID: 219474 RVA: 0x0074C065 File Offset: 0x0074A265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035953 RID: 219475 RVA: 0x0074C074 File Offset: 0x0074A274
		public ITalkOptionVisualNovel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E035 RID: 57397
		// (get) Token: 0x06035954 RID: 219476 RVA: 0x0074C084 File Offset: 0x0074A284
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

		// Token: 0x1700E036 RID: 57398
		// (get) Token: 0x06035955 RID: 219477 RVA: 0x0074C0C0 File Offset: 0x0074A2C0
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

		// Token: 0x06035956 RID: 219478 RVA: 0x0074C0FC File Offset: 0x0074A2FC
		public TVisualNovelPerformance OptionPerformancesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E037 RID: 57399
		// (get) Token: 0x06035957 RID: 219479 RVA: 0x0074C13C File Offset: 0x0074A33C
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

		// Token: 0x06035958 RID: 219480 RVA: 0x0074C167 File Offset: 0x0074A367
		public Span<TVisualNovelPerformance> GetOptionPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(8, 1);
		}

		// Token: 0x06035959 RID: 219481 RVA: 0x0074C178 File Offset: 0x0074A378
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

		// Token: 0x0603595A RID: 219482 RVA: 0x0074C1E4 File Offset: 0x0074A3E4
		public TTable? OptionPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700E038 RID: 57400
		// (get) Token: 0x0603595B RID: 219483 RVA: 0x0074C22C File Offset: 0x0074A42C
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

		// Token: 0x1700E039 RID: 57401
		// (get) Token: 0x0603595C RID: 219484 RVA: 0x0074C258 File Offset: 0x0074A458
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

		// Token: 0x0603595D RID: 219485 RVA: 0x0074C295 File Offset: 0x0074A495
		public static Offset<ITalkOptionVisualNovel> CreateITalkOptionVisualNovel(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int PlotOptionId = 0, VectorOffset OptionPerformances_typeOffset = default(VectorOffset), VectorOffset OptionPerformancesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITalkOptionVisualNovel.AddOptionPerformances(builder, OptionPerformancesOffset);
			ITalkOptionVisualNovel.AddOptionPerformancesType(builder, OptionPerformances_typeOffset);
			ITalkOptionVisualNovel.AddPlotOptionId(builder, PlotOptionId);
			ITalkOptionVisualNovel.AddNullMask(builder, NullMask);
			ITalkOptionVisualNovel.AddType(builder, Type);
			return ITalkOptionVisualNovel.EndITalkOptionVisualNovel(builder);
		}

		// Token: 0x0603595E RID: 219486 RVA: 0x0074C2C9 File Offset: 0x0074A4C9
		public static void StartITalkOptionVisualNovel(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603595F RID: 219487 RVA: 0x0074C2D2 File Offset: 0x0074A4D2
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035960 RID: 219488 RVA: 0x0074C2DD File Offset: 0x0074A4DD
		public static void AddPlotOptionId(FlatBufferBuilder builder, int plotOptionId)
		{
			builder.AddInt(1, plotOptionId, 0);
		}

		// Token: 0x06035961 RID: 219489 RVA: 0x0074C2E8 File Offset: 0x0074A4E8
		public static void AddOptionPerformancesType(FlatBufferBuilder builder, VectorOffset optionPerformancesTypeOffset)
		{
			builder.AddOffset(2, optionPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06035962 RID: 219490 RVA: 0x0074C2F8 File Offset: 0x0074A4F8
		public static VectorOffset CreateOptionPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035963 RID: 219491 RVA: 0x0074C32F File Offset: 0x0074A52F
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035964 RID: 219492 RVA: 0x0074C349 File Offset: 0x0074A549
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035965 RID: 219493 RVA: 0x0074C367 File Offset: 0x0074A567
		public static VectorOffset CreateOptionPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035966 RID: 219494 RVA: 0x0074C380 File Offset: 0x0074A580
		public static void StartOptionPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035967 RID: 219495 RVA: 0x0074C38B File Offset: 0x0074A58B
		public static void AddOptionPerformances(FlatBufferBuilder builder, VectorOffset optionPerformancesOffset)
		{
			builder.AddOffset(3, optionPerformancesOffset.Value, 0);
		}

		// Token: 0x06035968 RID: 219496 RVA: 0x0074C39C File Offset: 0x0074A59C
		public static VectorOffset CreateOptionPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035969 RID: 219497 RVA: 0x0074C3D3 File Offset: 0x0074A5D3
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603596A RID: 219498 RVA: 0x0074C3ED File Offset: 0x0074A5ED
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603596B RID: 219499 RVA: 0x0074C40B File Offset: 0x0074A60B
		public static VectorOffset CreateOptionPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603596C RID: 219500 RVA: 0x0074C424 File Offset: 0x0074A624
		public static void StartOptionPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603596D RID: 219501 RVA: 0x0074C42F File Offset: 0x0074A62F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603596E RID: 219502 RVA: 0x0074C43A File Offset: 0x0074A63A
		public static Offset<ITalkOptionVisualNovel> EndITalkOptionVisualNovel(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionVisualNovel>(builder.EndTable());
		}

		// Token: 0x0603596F RID: 219503 RVA: 0x0074C448 File Offset: 0x0074A648
		public ITalkOptionVisualNovelT UnPack()
		{
			ITalkOptionVisualNovelT talkOptionVisualNovelT = new ITalkOptionVisualNovelT();
			this.UnPackTo(talkOptionVisualNovelT);
			return talkOptionVisualNovelT;
		}

		// Token: 0x06035970 RID: 219504 RVA: 0x0074C464 File Offset: 0x0074A664
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
				case TVisualNovelPerformance.IVisualNovelPerformanceUiShake:
					tvisualNovelPerformanceUnion.Value = ((this.OptionPerformances<IVisualNovelPerformanceUiShake>(i) != null) ? this.OptionPerformances<IVisualNovelPerformanceUiShake>(i).Value.UnPack() : null);
					break;
				}
				_o.OptionPerformances.Add(tvisualNovelPerformanceUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035971 RID: 219505 RVA: 0x0074C8EC File Offset: 0x0074AAEC
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
			return ITalkOptionVisualNovel.CreateITalkOptionVisualNovel(builder, _o.Type, _o.PlotOptionId, optionPerformances_typeOffset, optionPerformancesOffset, _o.NullMask);
		}

		// Token: 0x04012151 RID: 74065
		private Table __p;
	}
}
