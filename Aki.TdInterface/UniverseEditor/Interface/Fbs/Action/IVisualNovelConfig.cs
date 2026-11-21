using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D6A RID: 32106
	public struct IVisualNovelConfig : IFlatbufferObject
	{
		// Token: 0x1700F031 RID: 61489
		// (get) Token: 0x06039F3E RID: 237374 RVA: 0x007D0826 File Offset: 0x007CEA26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039F3F RID: 237375 RVA: 0x007D0833 File Offset: 0x007CEA33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039F40 RID: 237376 RVA: 0x007D083C File Offset: 0x007CEA3C
		public static IVisualNovelConfig GetRootAsIVisualNovelConfig(ByteBuffer _bb)
		{
			return IVisualNovelConfig.GetRootAsIVisualNovelConfig(_bb, default(IVisualNovelConfig));
		}

		// Token: 0x06039F41 RID: 237377 RVA: 0x007D0858 File Offset: 0x007CEA58
		public static IVisualNovelConfig GetRootAsIVisualNovelConfig(ByteBuffer _bb, IVisualNovelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039F42 RID: 237378 RVA: 0x007D0875 File Offset: 0x007CEA75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039F43 RID: 237379 RVA: 0x007D0884 File Offset: 0x007CEA84
		public IVisualNovelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F032 RID: 61490
		// (get) Token: 0x06039F44 RID: 237380 RVA: 0x007D0894 File Offset: 0x007CEA94
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

		// Token: 0x1700F033 RID: 61491
		// (get) Token: 0x06039F45 RID: 237381 RVA: 0x007D08D0 File Offset: 0x007CEAD0
		public bool EnableReadRecord
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F034 RID: 61492
		// (get) Token: 0x06039F46 RID: 237382 RVA: 0x007D0910 File Offset: 0x007CEB10
		public bool EnableFastForward
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F035 RID: 61493
		// (get) Token: 0x06039F47 RID: 237383 RVA: 0x007D0950 File Offset: 0x007CEB50
		public bool HideControlUi
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F036 RID: 61494
		// (get) Token: 0x06039F48 RID: 237384 RVA: 0x007D0990 File Offset: 0x007CEB90
		public int InitialBackgroundId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039F49 RID: 237385 RVA: 0x007D09D0 File Offset: 0x007CEBD0
		public string InitialAudioEvents(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700F037 RID: 61495
		// (get) Token: 0x06039F4A RID: 237386 RVA: 0x007D0A0C File Offset: 0x007CEC0C
		public int InitialAudioEventsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700F038 RID: 61496
		// (get) Token: 0x06039F4B RID: 237387 RVA: 0x007D0A38 File Offset: 0x007CEC38
		public ISolarSchoolTime? InitialTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ISolarSchoolTime?(default(ISolarSchoolTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F039 RID: 61497
		// (get) Token: 0x06039F4C RID: 237388 RVA: 0x007D0A98 File Offset: 0x007CEC98
		public float EndFadeOutTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F03A RID: 61498
		// (get) Token: 0x06039F4D RID: 237389 RVA: 0x007D0ADC File Offset: 0x007CECDC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039F4E RID: 237390 RVA: 0x007D0B1C File Offset: 0x007CED1C
		public static Offset<IVisualNovelConfig> CreateIVisualNovelConfig(FlatBufferBuilder builder, EVisualNovelSubType VisualNovelSubType = EVisualNovelSubType.SolarSchool, bool EnableReadRecord = false, bool EnableFastForward = false, bool HideControlUi = false, int InitialBackgroundId = 0, VectorOffset InitialAudioEventsOffset = default(VectorOffset), Offset<ISolarSchoolTime> InitialTimeOffset = default(Offset<ISolarSchoolTime>), float EndFadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(9);
			IVisualNovelConfig.AddEndFadeOutTime(builder, EndFadeOutTime);
			IVisualNovelConfig.AddInitialTime(builder, InitialTimeOffset);
			IVisualNovelConfig.AddInitialAudioEvents(builder, InitialAudioEventsOffset);
			IVisualNovelConfig.AddInitialBackgroundId(builder, InitialBackgroundId);
			IVisualNovelConfig.AddNullMask(builder, NullMask);
			IVisualNovelConfig.AddHideControlUi(builder, HideControlUi);
			IVisualNovelConfig.AddEnableFastForward(builder, EnableFastForward);
			IVisualNovelConfig.AddEnableReadRecord(builder, EnableReadRecord);
			IVisualNovelConfig.AddVisualNovelSubType(builder, VisualNovelSubType);
			return IVisualNovelConfig.EndIVisualNovelConfig(builder);
		}

		// Token: 0x06039F4F RID: 237391 RVA: 0x007D0B7C File Offset: 0x007CED7C
		public static void StartIVisualNovelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06039F50 RID: 237392 RVA: 0x007D0B86 File Offset: 0x007CED86
		public static void AddVisualNovelSubType(FlatBufferBuilder builder, EVisualNovelSubType visualNovelSubType)
		{
			builder.AddByte(0, (byte)visualNovelSubType, 0);
		}

		// Token: 0x06039F51 RID: 237393 RVA: 0x007D0B91 File Offset: 0x007CED91
		public static void AddEnableReadRecord(FlatBufferBuilder builder, bool enableReadRecord)
		{
			builder.AddBool(1, enableReadRecord, false);
		}

		// Token: 0x06039F52 RID: 237394 RVA: 0x007D0B9C File Offset: 0x007CED9C
		public static void AddEnableFastForward(FlatBufferBuilder builder, bool enableFastForward)
		{
			builder.AddBool(2, enableFastForward, false);
		}

		// Token: 0x06039F53 RID: 237395 RVA: 0x007D0BA7 File Offset: 0x007CEDA7
		public static void AddHideControlUi(FlatBufferBuilder builder, bool hideControlUi)
		{
			builder.AddBool(3, hideControlUi, false);
		}

		// Token: 0x06039F54 RID: 237396 RVA: 0x007D0BB2 File Offset: 0x007CEDB2
		public static void AddInitialBackgroundId(FlatBufferBuilder builder, int initialBackgroundId)
		{
			builder.AddInt(4, initialBackgroundId, 0);
		}

		// Token: 0x06039F55 RID: 237397 RVA: 0x007D0BBD File Offset: 0x007CEDBD
		public static void AddInitialAudioEvents(FlatBufferBuilder builder, VectorOffset initialAudioEventsOffset)
		{
			builder.AddOffset(5, initialAudioEventsOffset.Value, 0);
		}

		// Token: 0x06039F56 RID: 237398 RVA: 0x007D0BD0 File Offset: 0x007CEDD0
		public static VectorOffset CreateInitialAudioEventsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06039F57 RID: 237399 RVA: 0x007D0C10 File Offset: 0x007CEE10
		public static VectorOffset CreateInitialAudioEventsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06039F58 RID: 237400 RVA: 0x007D0C2A File Offset: 0x007CEE2A
		public static VectorOffset CreateInitialAudioEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06039F59 RID: 237401 RVA: 0x007D0C48 File Offset: 0x007CEE48
		public static VectorOffset CreateInitialAudioEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039F5A RID: 237402 RVA: 0x007D0C61 File Offset: 0x007CEE61
		public static void StartInitialAudioEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039F5B RID: 237403 RVA: 0x007D0C6C File Offset: 0x007CEE6C
		public static void AddInitialTime(FlatBufferBuilder builder, Offset<ISolarSchoolTime> initialTimeOffset)
		{
			builder.AddOffset(6, initialTimeOffset.Value, 0);
		}

		// Token: 0x06039F5C RID: 237404 RVA: 0x007D0C7C File Offset: 0x007CEE7C
		public static void AddEndFadeOutTime(FlatBufferBuilder builder, float endFadeOutTime)
		{
			builder.AddFloat(7, endFadeOutTime, 0.0);
		}

		// Token: 0x06039F5D RID: 237405 RVA: 0x007D0C8F File Offset: 0x007CEE8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06039F5E RID: 237406 RVA: 0x007D0C9A File Offset: 0x007CEE9A
		public static Offset<IVisualNovelConfig> EndIVisualNovelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelConfig>(builder.EndTable());
		}

		// Token: 0x06039F5F RID: 237407 RVA: 0x007D0CA8 File Offset: 0x007CEEA8
		public IVisualNovelConfigT UnPack()
		{
			IVisualNovelConfigT visualNovelConfigT = new IVisualNovelConfigT();
			this.UnPackTo(visualNovelConfigT);
			return visualNovelConfigT;
		}

		// Token: 0x06039F60 RID: 237408 RVA: 0x007D0CC4 File Offset: 0x007CEEC4
		public void UnPackTo(IVisualNovelConfigT _o)
		{
			_o.VisualNovelSubType = this.VisualNovelSubType;
			_o.EnableReadRecord = this.EnableReadRecord;
			_o.EnableFastForward = this.EnableFastForward;
			_o.HideControlUi = this.HideControlUi;
			_o.InitialBackgroundId = this.InitialBackgroundId;
			_o.InitialAudioEvents = new List<string>();
			for (int i = 0; i < this.InitialAudioEventsLength; i++)
			{
				_o.InitialAudioEvents.Add(this.InitialAudioEvents(i));
			}
			_o.InitialTime = ((this.InitialTime != null) ? this.InitialTime.Value.UnPack() : null);
			_o.EndFadeOutTime = this.EndFadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039F61 RID: 237409 RVA: 0x007D0D84 File Offset: 0x007CEF84
		public static Offset<IVisualNovelConfig> Pack(FlatBufferBuilder builder, IVisualNovelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelConfig>);
			}
			VectorOffset initialAudioEventsOffset = default(VectorOffset);
			if (_o.InitialAudioEvents != null)
			{
				StringOffset[] array = new StringOffset[_o.InitialAudioEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.InitialAudioEvents[i]);
				}
				initialAudioEventsOffset = IVisualNovelConfig.CreateInitialAudioEventsVector(builder, array);
			}
			Offset<ISolarSchoolTime> initialTimeOffset = (_o.InitialTime == null) ? default(Offset<ISolarSchoolTime>) : ISolarSchoolTime.Pack(builder, _o.InitialTime);
			return IVisualNovelConfig.CreateIVisualNovelConfig(builder, _o.VisualNovelSubType, _o.EnableReadRecord, _o.EnableFastForward, _o.HideControlUi, _o.InitialBackgroundId, initialAudioEventsOffset, initialTimeOffset, _o.EndFadeOutTime, _o.NullMask);
		}

		// Token: 0x040134A5 RID: 79013
		private Table __p;
	}
}
