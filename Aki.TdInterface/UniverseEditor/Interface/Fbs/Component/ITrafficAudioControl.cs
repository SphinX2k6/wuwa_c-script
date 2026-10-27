using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC0 RID: 23232
	public struct ITrafficAudioControl : IFlatbufferObject
	{
		// Token: 0x1700AEF5 RID: 44789
		// (get) Token: 0x06027960 RID: 162144 RVA: 0x00571C3D File Offset: 0x0056FE3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027961 RID: 162145 RVA: 0x00571C4A File Offset: 0x0056FE4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027962 RID: 162146 RVA: 0x00571C54 File Offset: 0x0056FE54
		public static ITrafficAudioControl GetRootAsITrafficAudioControl(ByteBuffer _bb)
		{
			return ITrafficAudioControl.GetRootAsITrafficAudioControl(_bb, default(ITrafficAudioControl));
		}

		// Token: 0x06027963 RID: 162147 RVA: 0x00571C70 File Offset: 0x0056FE70
		public static ITrafficAudioControl GetRootAsITrafficAudioControl(ByteBuffer _bb, ITrafficAudioControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027964 RID: 162148 RVA: 0x00571C8D File Offset: 0x0056FE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027965 RID: 162149 RVA: 0x00571C9C File Offset: 0x0056FE9C
		public ITrafficAudioControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEF6 RID: 44790
		// (get) Token: 0x06027966 RID: 162150 RVA: 0x00571CAC File Offset: 0x0056FEAC
		public EAudioControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioControlType.Gramophone;
				}
				return (EAudioControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AEF7 RID: 44791
		// (get) Token: 0x06027967 RID: 162151 RVA: 0x00571CE8 File Offset: 0x0056FEE8
		public string EngineAudio
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

		// Token: 0x06027968 RID: 162152 RVA: 0x00571D1F File Offset: 0x0056FF1F
		public Span<byte> GetEngineAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027969 RID: 162153 RVA: 0x00571D2E File Offset: 0x0056FF2E
		public byte[] GetEngineAudioArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AEF8 RID: 44792
		// (get) Token: 0x0602796A RID: 162154 RVA: 0x00571D3C File Offset: 0x0056FF3C
		public string BrakingAudio
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

		// Token: 0x0602796B RID: 162155 RVA: 0x00571D73 File Offset: 0x0056FF73
		public Span<byte> GetBrakingAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602796C RID: 162156 RVA: 0x00571D82 File Offset: 0x0056FF82
		public byte[] GetBrakingAudioArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AEF9 RID: 44793
		// (get) Token: 0x0602796D RID: 162157 RVA: 0x00571D90 File Offset: 0x0056FF90
		public string BrakingShortAudio
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

		// Token: 0x0602796E RID: 162158 RVA: 0x00571DC8 File Offset: 0x0056FFC8
		public Span<byte> GetBrakingShortAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602796F RID: 162159 RVA: 0x00571DD8 File Offset: 0x0056FFD8
		public byte[] GetBrakingShortAudioArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AEFA RID: 44794
		// (get) Token: 0x06027970 RID: 162160 RVA: 0x00571DE8 File Offset: 0x0056FFE8
		public string HornAudio
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

		// Token: 0x06027971 RID: 162161 RVA: 0x00571E20 File Offset: 0x00570020
		public Span<byte> GetHornAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06027972 RID: 162162 RVA: 0x00571E30 File Offset: 0x00570030
		public byte[] GetHornAudioArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06027973 RID: 162163 RVA: 0x00571E3F File Offset: 0x0057003F
		public static Offset<ITrafficAudioControl> CreateITrafficAudioControl(FlatBufferBuilder builder, EAudioControlType Type = EAudioControlType.Gramophone, StringOffset EngineAudioOffset = default(StringOffset), StringOffset BrakingAudioOffset = default(StringOffset), StringOffset BrakingShortAudioOffset = default(StringOffset), StringOffset HornAudioOffset = default(StringOffset))
		{
			builder.StartTable(5);
			ITrafficAudioControl.AddHornAudio(builder, HornAudioOffset);
			ITrafficAudioControl.AddBrakingShortAudio(builder, BrakingShortAudioOffset);
			ITrafficAudioControl.AddBrakingAudio(builder, BrakingAudioOffset);
			ITrafficAudioControl.AddEngineAudio(builder, EngineAudioOffset);
			ITrafficAudioControl.AddType(builder, Type);
			return ITrafficAudioControl.EndITrafficAudioControl(builder);
		}

		// Token: 0x06027974 RID: 162164 RVA: 0x00571E73 File Offset: 0x00570073
		public static void StartITrafficAudioControl(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027975 RID: 162165 RVA: 0x00571E7C File Offset: 0x0057007C
		public static void AddType(FlatBufferBuilder builder, EAudioControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027976 RID: 162166 RVA: 0x00571E87 File Offset: 0x00570087
		public static void AddEngineAudio(FlatBufferBuilder builder, StringOffset engineAudioOffset)
		{
			builder.AddOffset(1, engineAudioOffset.Value, 0);
		}

		// Token: 0x06027977 RID: 162167 RVA: 0x00571E97 File Offset: 0x00570097
		public static void AddBrakingAudio(FlatBufferBuilder builder, StringOffset brakingAudioOffset)
		{
			builder.AddOffset(2, brakingAudioOffset.Value, 0);
		}

		// Token: 0x06027978 RID: 162168 RVA: 0x00571EA7 File Offset: 0x005700A7
		public static void AddBrakingShortAudio(FlatBufferBuilder builder, StringOffset brakingShortAudioOffset)
		{
			builder.AddOffset(3, brakingShortAudioOffset.Value, 0);
		}

		// Token: 0x06027979 RID: 162169 RVA: 0x00571EB7 File Offset: 0x005700B7
		public static void AddHornAudio(FlatBufferBuilder builder, StringOffset hornAudioOffset)
		{
			builder.AddOffset(4, hornAudioOffset.Value, 0);
		}

		// Token: 0x0602797A RID: 162170 RVA: 0x00571EC7 File Offset: 0x005700C7
		public static Offset<ITrafficAudioControl> EndITrafficAudioControl(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficAudioControl>(builder.EndTable());
		}

		// Token: 0x0602797B RID: 162171 RVA: 0x00571ED4 File Offset: 0x005700D4
		public ITrafficAudioControlT UnPack()
		{
			ITrafficAudioControlT trafficAudioControlT = new ITrafficAudioControlT();
			this.UnPackTo(trafficAudioControlT);
			return trafficAudioControlT;
		}

		// Token: 0x0602797C RID: 162172 RVA: 0x00571EEF File Offset: 0x005700EF
		public void UnPackTo(ITrafficAudioControlT _o)
		{
			_o.Type = this.Type;
			_o.EngineAudio = this.EngineAudio;
			_o.BrakingAudio = this.BrakingAudio;
			_o.BrakingShortAudio = this.BrakingShortAudio;
			_o.HornAudio = this.HornAudio;
		}

		// Token: 0x0602797D RID: 162173 RVA: 0x00571F30 File Offset: 0x00570130
		public static Offset<ITrafficAudioControl> Pack(FlatBufferBuilder builder, ITrafficAudioControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficAudioControl>);
			}
			StringOffset engineAudioOffset = (_o.EngineAudio == null) ? default(StringOffset) : builder.CreateString(_o.EngineAudio);
			StringOffset brakingAudioOffset = (_o.BrakingAudio == null) ? default(StringOffset) : builder.CreateString(_o.BrakingAudio);
			StringOffset brakingShortAudioOffset = (_o.BrakingShortAudio == null) ? default(StringOffset) : builder.CreateString(_o.BrakingShortAudio);
			StringOffset hornAudioOffset = (_o.HornAudio == null) ? default(StringOffset) : builder.CreateString(_o.HornAudio);
			return ITrafficAudioControl.CreateITrafficAudioControl(builder, _o.Type, engineAudioOffset, brakingAudioOffset, brakingShortAudioOffset, hornAudioOffset);
		}

		// Token: 0x0400F189 RID: 61833
		private Table __p;
	}
}
