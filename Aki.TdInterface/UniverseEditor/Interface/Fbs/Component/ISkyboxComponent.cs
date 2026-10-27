using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591A RID: 22810
	public struct ISkyboxComponent : IFlatbufferObject
	{
		// Token: 0x1700AB0E RID: 43790
		// (get) Token: 0x060268FE RID: 157950 RVA: 0x0054FCE4 File Offset: 0x0054DEE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060268FF RID: 157951 RVA: 0x0054FCF1 File Offset: 0x0054DEF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026900 RID: 157952 RVA: 0x0054FCF8 File Offset: 0x0054DEF8
		public static ISkyboxComponent GetRootAsISkyboxComponent(ByteBuffer _bb)
		{
			return ISkyboxComponent.GetRootAsISkyboxComponent(_bb, default(ISkyboxComponent));
		}

		// Token: 0x06026901 RID: 157953 RVA: 0x0054FD14 File Offset: 0x0054DF14
		public static ISkyboxComponent GetRootAsISkyboxComponent(ByteBuffer _bb, ISkyboxComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026902 RID: 157954 RVA: 0x0054FD31 File Offset: 0x0054DF31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026903 RID: 157955 RVA: 0x0054FD40 File Offset: 0x0054DF40
		public ISkyboxComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB0F RID: 43791
		// (get) Token: 0x06026904 RID: 157956 RVA: 0x0054FD50 File Offset: 0x0054DF50
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AB10 RID: 43792
		// (get) Token: 0x06026905 RID: 157957 RVA: 0x0054FD90 File Offset: 0x0054DF90
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

		// Token: 0x06026906 RID: 157958 RVA: 0x0054FDC7 File Offset: 0x0054DFC7
		public Span<byte> GetWeatherDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026907 RID: 157959 RVA: 0x0054FDD6 File Offset: 0x0054DFD6
		public byte[] GetWeatherDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AB11 RID: 43793
		// (get) Token: 0x06026908 RID: 157960 RVA: 0x0054FDE4 File Offset: 0x0054DFE4
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

		// Token: 0x06026909 RID: 157961 RVA: 0x0054FE1B File Offset: 0x0054E01B
		public Span<byte> GetPPTODDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602690A RID: 157962 RVA: 0x0054FE2A File Offset: 0x0054E02A
		public byte[] GetPPTODDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AB12 RID: 43794
		// (get) Token: 0x0602690B RID: 157963 RVA: 0x0054FE38 File Offset: 0x0054E038
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

		// Token: 0x1700AB13 RID: 43795
		// (get) Token: 0x0602690C RID: 157964 RVA: 0x0054FE78 File Offset: 0x0054E078
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

		// Token: 0x1700AB14 RID: 43796
		// (get) Token: 0x0602690D RID: 157965 RVA: 0x0054FEBC File Offset: 0x0054E0BC
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

		// Token: 0x1700AB15 RID: 43797
		// (get) Token: 0x0602690E RID: 157966 RVA: 0x0054FF00 File Offset: 0x0054E100
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

		// Token: 0x0602690F RID: 157967 RVA: 0x0054FF40 File Offset: 0x0054E140
		public TTable? TriggerMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026910 RID: 157968 RVA: 0x0054FF88 File Offset: 0x0054E188
		public ISkyboxDistanceTrigger TriggerModeAsISkyboxDistanceTrigger()
		{
			return this.TriggerMode<ISkyboxDistanceTrigger>().Value;
		}

		// Token: 0x06026911 RID: 157969 RVA: 0x0054FFA4 File Offset: 0x0054E1A4
		public ISkyboxGlobalTrigger TriggerModeAsISkyboxGlobalTrigger()
		{
			return this.TriggerMode<ISkyboxGlobalTrigger>().Value;
		}

		// Token: 0x1700AB16 RID: 43798
		// (get) Token: 0x06026912 RID: 157970 RVA: 0x0054FFC0 File Offset: 0x0054E1C0
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

		// Token: 0x06026913 RID: 157971 RVA: 0x00550000 File Offset: 0x0054E200
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

		// Token: 0x06026914 RID: 157972 RVA: 0x00550060 File Offset: 0x0054E260
		public static void StartISkyboxComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06026915 RID: 157973 RVA: 0x0055006A File Offset: 0x0054E26A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026916 RID: 157974 RVA: 0x00550075 File Offset: 0x0054E275
		public static void AddWeatherDataAsset(FlatBufferBuilder builder, StringOffset weatherDataAssetOffset)
		{
			builder.AddOffset(1, weatherDataAssetOffset.Value, 0);
		}

		// Token: 0x06026917 RID: 157975 RVA: 0x00550085 File Offset: 0x0054E285
		public static void AddPPTODDataAsset(FlatBufferBuilder builder, StringOffset pPTODDataAssetOffset)
		{
			builder.AddOffset(2, pPTODDataAssetOffset.Value, 0);
		}

		// Token: 0x06026918 RID: 157976 RVA: 0x00550095 File Offset: 0x0054E295
		public static void AddSkyboxSetting(FlatBufferBuilder builder, int skyboxSetting)
		{
			builder.AddInt(3, skyboxSetting, 0);
		}

		// Token: 0x06026919 RID: 157977 RVA: 0x005500A0 File Offset: 0x0054E2A0
		public static void AddFadeTime(FlatBufferBuilder builder, float fadeTime)
		{
			builder.AddFloat(4, fadeTime, 0.0);
		}

		// Token: 0x0602691A RID: 157978 RVA: 0x005500B3 File Offset: 0x0054E2B3
		public static void AddPriority(FlatBufferBuilder builder, float priority)
		{
			builder.AddFloat(5, priority, 0.0);
		}

		// Token: 0x0602691B RID: 157979 RVA: 0x005500C6 File Offset: 0x0054E2C6
		public static void AddTriggerModeType(FlatBufferBuilder builder, TTriggerMode triggerModeType)
		{
			builder.AddByte(6, (byte)triggerModeType, 0);
		}

		// Token: 0x0602691C RID: 157980 RVA: 0x005500D1 File Offset: 0x0054E2D1
		public static void AddTriggerMode(FlatBufferBuilder builder, int triggerModeOffset)
		{
			builder.AddOffset(7, triggerModeOffset, 0);
		}

		// Token: 0x0602691D RID: 157981 RVA: 0x005500DC File Offset: 0x0054E2DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602691E RID: 157982 RVA: 0x005500E7 File Offset: 0x0054E2E7
		public static Offset<ISkyboxComponent> EndISkyboxComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISkyboxComponent>(builder.EndTable());
		}

		// Token: 0x0602691F RID: 157983 RVA: 0x005500F4 File Offset: 0x0054E2F4
		public ISkyboxComponentT UnPack()
		{
			ISkyboxComponentT skyboxComponentT = new ISkyboxComponentT();
			this.UnPackTo(skyboxComponentT);
			return skyboxComponentT;
		}

		// Token: 0x06026920 RID: 157984 RVA: 0x00550110 File Offset: 0x0054E310
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

		// Token: 0x06026921 RID: 157985 RVA: 0x0055020C File Offset: 0x0054E40C
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

		// Token: 0x0400EEC8 RID: 61128
		private Table __p;
	}
}
