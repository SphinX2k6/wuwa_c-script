using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D97 RID: 23959
	public struct IEaseCurvePreset : IFlatbufferObject
	{
		// Token: 0x1700B371 RID: 45937
		// (get) Token: 0x0602900C RID: 167948 RVA: 0x005A1B29 File Offset: 0x0059FD29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602900D RID: 167949 RVA: 0x005A1B36 File Offset: 0x0059FD36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602900E RID: 167950 RVA: 0x005A1B40 File Offset: 0x0059FD40
		public static IEaseCurvePreset GetRootAsIEaseCurvePreset(ByteBuffer _bb)
		{
			return IEaseCurvePreset.GetRootAsIEaseCurvePreset(_bb, default(IEaseCurvePreset));
		}

		// Token: 0x0602900F RID: 167951 RVA: 0x005A1B5C File Offset: 0x0059FD5C
		public static IEaseCurvePreset GetRootAsIEaseCurvePreset(ByteBuffer _bb, IEaseCurvePreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029010 RID: 167952 RVA: 0x005A1B79 File Offset: 0x0059FD79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029011 RID: 167953 RVA: 0x005A1B88 File Offset: 0x0059FD88
		public IEaseCurvePreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B372 RID: 45938
		// (get) Token: 0x06029012 RID: 167954 RVA: 0x005A1B98 File Offset: 0x0059FD98
		public EEaseCurveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseCurveType.Preset;
				}
				return (EEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B373 RID: 45939
		// (get) Token: 0x06029013 RID: 167955 RVA: 0x005A1BD4 File Offset: 0x0059FDD4
		public EPresetEaseType PresetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPresetEaseType.Linear;
				}
				return (EPresetEaseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029014 RID: 167956 RVA: 0x005A1C10 File Offset: 0x0059FE10
		public static Offset<IEaseCurvePreset> CreateIEaseCurvePreset(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset, EPresetEaseType PresetType = EPresetEaseType.Linear)
		{
			builder.StartTable(2);
			IEaseCurvePreset.AddPresetType(builder, PresetType);
			IEaseCurvePreset.AddType(builder, Type);
			return IEaseCurvePreset.EndIEaseCurvePreset(builder);
		}

		// Token: 0x06029015 RID: 167957 RVA: 0x005A1C2D File Offset: 0x0059FE2D
		public static void StartIEaseCurvePreset(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029016 RID: 167958 RVA: 0x005A1C36 File Offset: 0x0059FE36
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029017 RID: 167959 RVA: 0x005A1C41 File Offset: 0x0059FE41
		public static void AddPresetType(FlatBufferBuilder builder, EPresetEaseType presetType)
		{
			builder.AddByte(1, (byte)presetType, 0);
		}

		// Token: 0x06029018 RID: 167960 RVA: 0x005A1C4C File Offset: 0x0059FE4C
		public static Offset<IEaseCurvePreset> EndIEaseCurvePreset(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurvePreset>(builder.EndTable());
		}

		// Token: 0x06029019 RID: 167961 RVA: 0x005A1C5C File Offset: 0x0059FE5C
		public IEaseCurvePresetT UnPack()
		{
			IEaseCurvePresetT easeCurvePresetT = new IEaseCurvePresetT();
			this.UnPackTo(easeCurvePresetT);
			return easeCurvePresetT;
		}

		// Token: 0x0602901A RID: 167962 RVA: 0x005A1C77 File Offset: 0x0059FE77
		public void UnPackTo(IEaseCurvePresetT _o)
		{
			_o.Type = this.Type;
			_o.PresetType = this.PresetType;
		}

		// Token: 0x0602901B RID: 167963 RVA: 0x005A1C94 File Offset: 0x0059FE94
		public static Offset<IEaseCurvePreset> Pack(FlatBufferBuilder builder, IEaseCurvePresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurvePreset>);
			}
			return IEaseCurvePreset.CreateIEaseCurvePreset(builder, _o.Type, _o.PresetType);
		}

		// Token: 0x0400F76B RID: 63339
		private Table __p;
	}
}
