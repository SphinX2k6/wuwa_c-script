using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F27 RID: 24359
	public struct ISkyboxComponent : IFlatbufferObject
	{
		// Token: 0x1700B442 RID: 46146
		// (get) Token: 0x06028E68 RID: 167528 RVA: 0x00596950 File Offset: 0x00594B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E69 RID: 167529 RVA: 0x0059695D File Offset: 0x00594B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E6A RID: 167530 RVA: 0x00596964 File Offset: 0x00594B64
		public static ISkyboxComponent GetRootAsISkyboxComponent(ByteBuffer _bb)
		{
			return ISkyboxComponent.GetRootAsISkyboxComponent(_bb, default(ISkyboxComponent));
		}

		// Token: 0x06028E6B RID: 167531 RVA: 0x00596980 File Offset: 0x00594B80
		public static ISkyboxComponent GetRootAsISkyboxComponent(ByteBuffer _bb, ISkyboxComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E6C RID: 167532 RVA: 0x0059699D File Offset: 0x00594B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E6D RID: 167533 RVA: 0x005969AC File Offset: 0x00594BAC
		public ISkyboxComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B443 RID: 46147
		// (get) Token: 0x06028E6E RID: 167534 RVA: 0x005969BC File Offset: 0x00594BBC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B444 RID: 46148
		// (get) Token: 0x06028E6F RID: 167535 RVA: 0x005969FC File Offset: 0x00594BFC
		public string WeatherDataAsset
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

		// Token: 0x06028E70 RID: 167536 RVA: 0x00596A33 File Offset: 0x00594C33
		public Span<byte> GetWeatherDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028E71 RID: 167537 RVA: 0x00596A42 File Offset: 0x00594C42
		public byte[] GetWeatherDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B445 RID: 46149
		// (get) Token: 0x06028E72 RID: 167538 RVA: 0x00596A50 File Offset: 0x00594C50
		public string PPTODDataAsset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E73 RID: 167539 RVA: 0x00596A87 File Offset: 0x00594C87
		public Span<byte> GetPPTODDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06028E74 RID: 167540 RVA: 0x00596A96 File Offset: 0x00594C96
		public byte[] GetPPTODDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B446 RID: 46150
		// (get) Token: 0x06028E75 RID: 167541 RVA: 0x00596AA4 File Offset: 0x00594CA4
		public int SkyboxSetting
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

		// Token: 0x1700B447 RID: 46151
		// (get) Token: 0x06028E76 RID: 167542 RVA: 0x00596AE4 File Offset: 0x00594CE4
		public float FadeTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B448 RID: 46152
		// (get) Token: 0x06028E77 RID: 167543 RVA: 0x00596B28 File Offset: 0x00594D28
		public float Priority
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B449 RID: 46153
		// (get) Token: 0x06028E78 RID: 167544 RVA: 0x00596B6C File Offset: 0x00594D6C
		public TTriggerMode TriggerModeType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TTriggerMode.NONE;
				}
				return (TTriggerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028E79 RID: 167545 RVA: 0x00596BAC File Offset: 0x00594DAC
		public TTable? TriggerMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028E7A RID: 167546 RVA: 0x00596BF4 File Offset: 0x00594DF4
		public ISkyboxDistanceTrigger TriggerModeAsISkyboxDistanceTrigger()
		{
			return this.TriggerMode<ISkyboxDistanceTrigger>().Value;
		}

		// Token: 0x06028E7B RID: 167547 RVA: 0x00596C10 File Offset: 0x00594E10
		public ISkyboxGlobalTrigger TriggerModeAsISkyboxGlobalTrigger()
		{
			return this.TriggerMode<ISkyboxGlobalTrigger>().Value;
		}

		// Token: 0x1700B44A RID: 46154
		// (get) Token: 0x06028E7C RID: 167548 RVA: 0x00596C2C File Offset: 0x00594E2C
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

		// Token: 0x06028E7D RID: 167549 RVA: 0x00596C6C File Offset: 0x00594E6C
		public static Offset<ISkyboxComponent> CreateISkyboxComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset WeatherDataAssetOffset = default(StringOffset), StringOffset PPTODDataAssetOffset = default(StringOffset), int SkyboxSetting = 0, float FadeTime = 0f, float Priority = 0f, TTriggerMode TriggerMode_type = TTriggerMode.NONE, int TriggerModeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ISkyboxComponent.AddTriggerMode(builder, TriggerModeOffset);
			ISkyboxComponent.AddPriority(builder, Priority);
			ISkyboxComponent.AddFadeTime(builder, FadeTime);
			ISkyboxComponent.AddSkyboxSetting(builder, SkyboxSetting);
			ISkyboxComponent.AddPPTODDataAsset(builder, PPTODDataAssetOffset);
			ISkyboxComponent.AddWeatherDataAsset(builder, WeatherDataAssetOffset);
			ISkyboxComponent.AddNullMask(builder, NullMask);
			ISkyboxComponent.AddTriggerModeType(builder, TriggerMode_type);
			ISkyboxComponent.AddDisabled(builder, Disabled);
			return ISkyboxComponent.EndISkyboxComponent(builder);
		}

		// Token: 0x06028E7E RID: 167550 RVA: 0x00596CCC File Offset: 0x00594ECC
		public static void StartISkyboxComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06028E7F RID: 167551 RVA: 0x00596CD6 File Offset: 0x00594ED6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028E80 RID: 167552 RVA: 0x00596CE1 File Offset: 0x00594EE1
		public static void AddWeatherDataAsset(FlatBufferBuilder builder, StringOffset weatherDataAssetOffset)
		{
			builder.AddOffset(1, weatherDataAssetOffset.Value, 0);
		}

		// Token: 0x06028E81 RID: 167553 RVA: 0x00596CF1 File Offset: 0x00594EF1
		public static void AddPPTODDataAsset(FlatBufferBuilder builder, StringOffset pPTODDataAssetOffset)
		{
			builder.AddOffset(2, pPTODDataAssetOffset.Value, 0);
		}

		// Token: 0x06028E82 RID: 167554 RVA: 0x00596D01 File Offset: 0x00594F01
		public static void AddSkyboxSetting(FlatBufferBuilder builder, int skyboxSetting)
		{
			builder.AddInt(3, skyboxSetting, 0);
		}

		// Token: 0x06028E83 RID: 167555 RVA: 0x00596D0C File Offset: 0x00594F0C
		public static void AddFadeTime(FlatBufferBuilder builder, float fadeTime)
		{
			builder.AddFloat(4, fadeTime, 0.0);
		}

		// Token: 0x06028E84 RID: 167556 RVA: 0x00596D1F File Offset: 0x00594F1F
		public static void AddPriority(FlatBufferBuilder builder, float priority)
		{
			builder.AddFloat(5, priority, 0.0);
		}

		// Token: 0x06028E85 RID: 167557 RVA: 0x00596D32 File Offset: 0x00594F32
		public static void AddTriggerModeType(FlatBufferBuilder builder, TTriggerMode triggerModeType)
		{
			builder.AddByte(6, (byte)triggerModeType, 0);
		}

		// Token: 0x06028E86 RID: 167558 RVA: 0x00596D3D File Offset: 0x00594F3D
		public static void AddTriggerMode(FlatBufferBuilder builder, int triggerModeOffset)
		{
			builder.AddOffset(7, triggerModeOffset, 0);
		}

		// Token: 0x06028E87 RID: 167559 RVA: 0x00596D48 File Offset: 0x00594F48
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06028E88 RID: 167560 RVA: 0x00596D53 File Offset: 0x00594F53
		public static Offset<ISkyboxComponent> EndISkyboxComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxComponent>(builder.EndTable());
		}

		// Token: 0x06028E89 RID: 167561 RVA: 0x00596D60 File Offset: 0x00594F60
		public ISkyboxComponentT UnPack()
		{
			ISkyboxComponentT skyboxComponentT = new ISkyboxComponentT();
			this.UnPackTo(skyboxComponentT);
			return skyboxComponentT;
		}

		// Token: 0x06028E8A RID: 167562 RVA: 0x00596D7C File Offset: 0x00594F7C
		public void UnPackTo(ISkyboxComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WeatherDataAsset = this.WeatherDataAsset;
			_o.PPTODDataAsset = this.PPTODDataAsset;
			_o.SkyboxSetting = this.SkyboxSetting;
			_o.FadeTime = this.FadeTime;
			_o.Priority = this.Priority;
			_o.TriggerMode = new TTriggerModeUnion();
			_o.TriggerMode.Type = this.TriggerModeType;
			TTriggerMode triggerModeType = this.TriggerModeType;
			if (triggerModeType != TTriggerMode.ISkyboxDistanceTrigger)
			{
				if (triggerModeType == TTriggerMode.ISkyboxGlobalTrigger)
				{
					_o.TriggerMode.Value = ((this.TriggerMode<ISkyboxGlobalTrigger>() != null) ? this.TriggerMode<ISkyboxGlobalTrigger>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TriggerMode.Value = ((this.TriggerMode<ISkyboxDistanceTrigger>() != null) ? this.TriggerMode<ISkyboxDistanceTrigger>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028E8B RID: 167563 RVA: 0x00596E78 File Offset: 0x00595078
		public static Offset<ISkyboxComponent> Pack(FlatBufferBuilder builder, ISkyboxComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkyboxComponent>);
			}
			StringOffset weatherDataAssetOffset = (_o.WeatherDataAsset == null) ? default(StringOffset) : builder.CreateString(_o.WeatherDataAsset);
			StringOffset pptoddataAssetOffset = (_o.PPTODDataAsset == null) ? default(StringOffset) : builder.CreateString(_o.PPTODDataAsset);
			TTriggerMode triggerMode_type = (_o.TriggerMode == null) ? TTriggerMode.NONE : _o.TriggerMode.Type;
			int triggerModeOffset = (_o.TriggerMode == null) ? 0 : TTriggerModeUnion.Pack(builder, _o.TriggerMode);
			return ISkyboxComponent.CreateISkyboxComponent(builder, _o.Disabled, weatherDataAssetOffset, pptoddataAssetOffset, _o.SkyboxSetting, _o.FadeTime, _o.Priority, triggerMode_type, triggerModeOffset, _o.NullMask);
		}

		// Token: 0x0400FBBD RID: 64445
		private Table __p;
	}
}
