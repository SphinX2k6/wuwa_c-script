using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007574 RID: 30068
	public struct IVisualNovelConfig : IFlatbufferObject
	{
		// Token: 0x1700E405 RID: 58373
		// (get) Token: 0x06036B22 RID: 224034 RVA: 0x0076D4C6 File Offset: 0x0076B6C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B23 RID: 224035 RVA: 0x0076D4D3 File Offset: 0x0076B6D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B24 RID: 224036 RVA: 0x0076D4DC File Offset: 0x0076B6DC
		public static IVisualNovelConfig GetRootAsIVisualNovelConfig(ByteBuffer _bb)
		{
			return IVisualNovelConfig.GetRootAsIVisualNovelConfig(_bb, default(IVisualNovelConfig));
		}

		// Token: 0x06036B25 RID: 224037 RVA: 0x0076D4F8 File Offset: 0x0076B6F8
		public static IVisualNovelConfig GetRootAsIVisualNovelConfig(ByteBuffer _bb, IVisualNovelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B26 RID: 224038 RVA: 0x0076D515 File Offset: 0x0076B715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B27 RID: 224039 RVA: 0x0076D524 File Offset: 0x0076B724
		public IVisualNovelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E406 RID: 58374
		// (get) Token: 0x06036B28 RID: 224040 RVA: 0x0076D534 File Offset: 0x0076B734
		public EVisualNovelSubType VisualNovelSubType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return (EVisualNovelSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E407 RID: 58375
		// (get) Token: 0x06036B29 RID: 224041 RVA: 0x0076D570 File Offset: 0x0076B770
		public bool EnableReadRecord
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E408 RID: 58376
		// (get) Token: 0x06036B2A RID: 224042 RVA: 0x0076D5B0 File Offset: 0x0076B7B0
		public bool HideControlUi
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E409 RID: 58377
		// (get) Token: 0x06036B2B RID: 224043 RVA: 0x0076D5F0 File Offset: 0x0076B7F0
		public int InitialBackgroundId
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

		// Token: 0x1700E40A RID: 58378
		// (get) Token: 0x06036B2C RID: 224044 RVA: 0x0076D630 File Offset: 0x0076B830
		public string InitialAudioEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036B2D RID: 224045 RVA: 0x0076D668 File Offset: 0x0076B868
		public Span<byte> GetInitialAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06036B2E RID: 224046 RVA: 0x0076D678 File Offset: 0x0076B878
		public byte[] GetInitialAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700E40B RID: 58379
		// (get) Token: 0x06036B2F RID: 224047 RVA: 0x0076D688 File Offset: 0x0076B888
		public ISolarSchoolTime? InitialTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISolarSchoolTime?(default(ISolarSchoolTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E40C RID: 58380
		// (get) Token: 0x06036B30 RID: 224048 RVA: 0x0076D6E8 File Offset: 0x0076B8E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036B31 RID: 224049 RVA: 0x0076D728 File Offset: 0x0076B928
		public static Offset<IVisualNovelConfig> CreateIVisualNovelConfig(FlatBufferBuilder builder, EVisualNovelSubType VisualNovelSubType = EVisualNovelSubType.SolarSchool, bool EnableReadRecord = false, bool HideControlUi = false, int InitialBackgroundId = 0, StringOffset InitialAudioEventOffset = default(StringOffset), Offset<ISolarSchoolTime> InitialTimeOffset = default(Offset<ISolarSchoolTime>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisualNovelConfig.AddInitialTime(builder, InitialTimeOffset);
			IVisualNovelConfig.AddInitialAudioEvent(builder, InitialAudioEventOffset);
			IVisualNovelConfig.AddInitialBackgroundId(builder, InitialBackgroundId);
			IVisualNovelConfig.AddNullMask(builder, NullMask);
			IVisualNovelConfig.AddHideControlUi(builder, HideControlUi);
			IVisualNovelConfig.AddEnableReadRecord(builder, EnableReadRecord);
			IVisualNovelConfig.AddVisualNovelSubType(builder, VisualNovelSubType);
			return IVisualNovelConfig.EndIVisualNovelConfig(builder);
		}

		// Token: 0x06036B32 RID: 224050 RVA: 0x0076D777 File Offset: 0x0076B977
		public static void StartIVisualNovelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036B33 RID: 224051 RVA: 0x0076D780 File Offset: 0x0076B980
		public static void AddVisualNovelSubType(FlatBufferBuilder builder, EVisualNovelSubType visualNovelSubType)
		{
			builder.AddByte(0, (byte)visualNovelSubType, 0);
		}

		// Token: 0x06036B34 RID: 224052 RVA: 0x0076D78B File Offset: 0x0076B98B
		public static void AddEnableReadRecord(FlatBufferBuilder builder, bool enableReadRecord)
		{
			builder.AddBool(1, enableReadRecord, false);
		}

		// Token: 0x06036B35 RID: 224053 RVA: 0x0076D796 File Offset: 0x0076B996
		public static void AddHideControlUi(FlatBufferBuilder builder, bool hideControlUi)
		{
			builder.AddBool(2, hideControlUi, false);
		}

		// Token: 0x06036B36 RID: 224054 RVA: 0x0076D7A1 File Offset: 0x0076B9A1
		public static void AddInitialBackgroundId(FlatBufferBuilder builder, int initialBackgroundId)
		{
			builder.AddInt(3, initialBackgroundId, 0);
		}

		// Token: 0x06036B37 RID: 224055 RVA: 0x0076D7AC File Offset: 0x0076B9AC
		public static void AddInitialAudioEvent(FlatBufferBuilder builder, StringOffset initialAudioEventOffset)
		{
			builder.AddOffset(4, initialAudioEventOffset.Value, 0);
		}

		// Token: 0x06036B38 RID: 224056 RVA: 0x0076D7BC File Offset: 0x0076B9BC
		public static void AddInitialTime(FlatBufferBuilder builder, Offset<ISolarSchoolTime> initialTimeOffset)
		{
			builder.AddOffset(5, initialTimeOffset.Value, 0);
		}

		// Token: 0x06036B39 RID: 224057 RVA: 0x0076D7CC File Offset: 0x0076B9CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036B3A RID: 224058 RVA: 0x0076D7D7 File Offset: 0x0076B9D7
		public static Offset<IVisualNovelConfig> EndIVisualNovelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelConfig>(builder.EndTable());
		}

		// Token: 0x06036B3B RID: 224059 RVA: 0x0076D7E4 File Offset: 0x0076B9E4
		public IVisualNovelConfigT UnPack()
		{
			IVisualNovelConfigT visualNovelConfigT = new IVisualNovelConfigT();
			this.UnPackTo(visualNovelConfigT);
			return visualNovelConfigT;
		}

		// Token: 0x06036B3C RID: 224060 RVA: 0x0076D800 File Offset: 0x0076BA00
		public void UnPackTo(IVisualNovelConfigT _o)
		{
			_o.VisualNovelSubType = this.VisualNovelSubType;
			_o.EnableReadRecord = this.EnableReadRecord;
			_o.HideControlUi = this.HideControlUi;
			_o.InitialBackgroundId = this.InitialBackgroundId;
			_o.InitialAudioEvent = this.InitialAudioEvent;
			_o.InitialTime = ((this.InitialTime != null) ? this.InitialTime.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036B3D RID: 224061 RVA: 0x0076D884 File Offset: 0x0076BA84
		public static Offset<IVisualNovelConfig> Pack(FlatBufferBuilder builder, IVisualNovelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelConfig>);
			}
			StringOffset initialAudioEventOffset = (_o.InitialAudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.InitialAudioEvent);
			Offset<ISolarSchoolTime> initialTimeOffset = (_o.InitialTime == null) ? default(Offset<ISolarSchoolTime>) : ISolarSchoolTime.Pack(builder, _o.InitialTime);
			return IVisualNovelConfig.CreateIVisualNovelConfig(builder, _o.VisualNovelSubType, _o.EnableReadRecord, _o.HideControlUi, _o.InitialBackgroundId, initialAudioEventOffset, initialTimeOffset, _o.NullMask);
		}

		// Token: 0x04012473 RID: 74867
		private Table __p;
	}
}
