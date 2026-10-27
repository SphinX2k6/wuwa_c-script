using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B08 RID: 23304
	public struct IVehicleAudioConfig : IFlatbufferObject
	{
		// Token: 0x1700AFD1 RID: 45009
		// (get) Token: 0x06027CAC RID: 162988 RVA: 0x005790CF File Offset: 0x005772CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027CAD RID: 162989 RVA: 0x005790DC File Offset: 0x005772DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027CAE RID: 162990 RVA: 0x005790E4 File Offset: 0x005772E4
		public static IVehicleAudioConfig GetRootAsIVehicleAudioConfig(ByteBuffer _bb)
		{
			return IVehicleAudioConfig.GetRootAsIVehicleAudioConfig(_bb, default(IVehicleAudioConfig));
		}

		// Token: 0x06027CAF RID: 162991 RVA: 0x00579100 File Offset: 0x00577300
		public static IVehicleAudioConfig GetRootAsIVehicleAudioConfig(ByteBuffer _bb, IVehicleAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027CB0 RID: 162992 RVA: 0x0057911D File Offset: 0x0057731D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027CB1 RID: 162993 RVA: 0x0057912C File Offset: 0x0057732C
		public IVehicleAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFD2 RID: 45010
		// (get) Token: 0x06027CB2 RID: 162994 RVA: 0x0057913C File Offset: 0x0057733C
		public float MinVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFD3 RID: 45011
		// (get) Token: 0x06027CB3 RID: 162995 RVA: 0x0057917C File Offset: 0x0057737C
		public float MaxVehicleSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFD4 RID: 45012
		// (get) Token: 0x06027CB4 RID: 162996 RVA: 0x005791BC File Offset: 0x005773BC
		public string AudioEvent
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

		// Token: 0x06027CB5 RID: 162997 RVA: 0x005791F3 File Offset: 0x005773F3
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027CB6 RID: 162998 RVA: 0x00579202 File Offset: 0x00577402
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06027CB7 RID: 162999 RVA: 0x00579210 File Offset: 0x00577410
		public static Offset<IVehicleAudioConfig> CreateIVehicleAudioConfig(FlatBufferBuilder builder, float MinVehicleSpeed = 0f, float MaxVehicleSpeed = 0f, StringOffset AudioEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVehicleAudioConfig.AddAudioEvent(builder, AudioEventOffset);
			IVehicleAudioConfig.AddMaxVehicleSpeed(builder, MaxVehicleSpeed);
			IVehicleAudioConfig.AddMinVehicleSpeed(builder, MinVehicleSpeed);
			return IVehicleAudioConfig.EndIVehicleAudioConfig(builder);
		}

		// Token: 0x06027CB8 RID: 163000 RVA: 0x00579234 File Offset: 0x00577434
		public static void StartIVehicleAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027CB9 RID: 163001 RVA: 0x0057923D File Offset: 0x0057743D
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(0, minVehicleSpeed, 0.0);
		}

		// Token: 0x06027CBA RID: 163002 RVA: 0x00579250 File Offset: 0x00577450
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(1, maxVehicleSpeed, 0.0);
		}

		// Token: 0x06027CBB RID: 163003 RVA: 0x00579263 File Offset: 0x00577463
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(2, audioEventOffset.Value, 0);
		}

		// Token: 0x06027CBC RID: 163004 RVA: 0x00579273 File Offset: 0x00577473
		public static Offset<IVehicleAudioConfig> EndIVehicleAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleAudioConfig>(builder.EndTable());
		}

		// Token: 0x06027CBD RID: 163005 RVA: 0x00579280 File Offset: 0x00577480
		public IVehicleAudioConfigT UnPack()
		{
			IVehicleAudioConfigT vehicleAudioConfigT = new IVehicleAudioConfigT();
			this.UnPackTo(vehicleAudioConfigT);
			return vehicleAudioConfigT;
		}

		// Token: 0x06027CBE RID: 163006 RVA: 0x0057929B File Offset: 0x0057749B
		public void UnPackTo(IVehicleAudioConfigT _o)
		{
			_o.MinVehicleSpeed = this.MinVehicleSpeed;
			_o.MaxVehicleSpeed = this.MaxVehicleSpeed;
			_o.AudioEvent = this.AudioEvent;
		}

		// Token: 0x06027CBF RID: 163007 RVA: 0x005792C4 File Offset: 0x005774C4
		public static Offset<IVehicleAudioConfig> Pack(FlatBufferBuilder builder, IVehicleAudioConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleAudioConfig>);
			}
			StringOffset audioEventOffset = (_o.AudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.AudioEvent);
			return IVehicleAudioConfig.CreateIVehicleAudioConfig(builder, _o.MinVehicleSpeed, _o.MaxVehicleSpeed, audioEventOffset);
		}

		// Token: 0x0400F20C RID: 61964
		private Table __p;
	}
}
