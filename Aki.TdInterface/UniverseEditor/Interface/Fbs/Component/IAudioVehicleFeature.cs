using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDD RID: 20189
	public struct IAudioVehicleFeature : IFlatbufferObject
	{
		// Token: 0x170090E9 RID: 37097
		// (get) Token: 0x0601FD1F RID: 130335 RVA: 0x0046D874 File Offset: 0x0046BA74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD20 RID: 130336 RVA: 0x0046D881 File Offset: 0x0046BA81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD21 RID: 130337 RVA: 0x0046D888 File Offset: 0x0046BA88
		public static IAudioVehicleFeature GetRootAsIAudioVehicleFeature(ByteBuffer _bb)
		{
			return IAudioVehicleFeature.GetRootAsIAudioVehicleFeature(_bb, default(IAudioVehicleFeature));
		}

		// Token: 0x0601FD22 RID: 130338 RVA: 0x0046D8A4 File Offset: 0x0046BAA4
		public static IAudioVehicleFeature GetRootAsIAudioVehicleFeature(ByteBuffer _bb, IAudioVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD23 RID: 130339 RVA: 0x0046D8C1 File Offset: 0x0046BAC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD24 RID: 130340 RVA: 0x0046D8D0 File Offset: 0x0046BAD0
		public IAudioVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090EA RID: 37098
		// (get) Token: 0x0601FD25 RID: 130341 RVA: 0x0046D8E0 File Offset: 0x0046BAE0
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090EB RID: 37099
		// (get) Token: 0x0601FD26 RID: 130342 RVA: 0x0046D91C File Offset: 0x0046BB1C
		public IVehicleAudioConfig? AudioConfigs
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVehicleAudioConfig?(default(IVehicleAudioConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FD27 RID: 130343 RVA: 0x0046D979 File Offset: 0x0046BB79
		public static Offset<IAudioVehicleFeature> CreateIAudioVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, Offset<IVehicleAudioConfig> AudioConfigsOffset = default(Offset<IVehicleAudioConfig>))
		{
			builder.StartTable(2);
			IAudioVehicleFeature.AddAudioConfigs(builder, AudioConfigsOffset);
			IAudioVehicleFeature.AddType(builder, Type);
			return IAudioVehicleFeature.EndIAudioVehicleFeature(builder);
		}

		// Token: 0x0601FD28 RID: 130344 RVA: 0x0046D996 File Offset: 0x0046BB96
		public static void StartIAudioVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD29 RID: 130345 RVA: 0x0046D99F File Offset: 0x0046BB9F
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD2A RID: 130346 RVA: 0x0046D9AA File Offset: 0x0046BBAA
		public static void AddAudioConfigs(FlatBufferBuilder builder, Offset<IVehicleAudioConfig> audioConfigsOffset)
		{
			builder.AddOffset(1, audioConfigsOffset.Value, 0);
		}

		// Token: 0x0601FD2B RID: 130347 RVA: 0x0046D9BA File Offset: 0x0046BBBA
		public static Offset<IAudioVehicleFeature> EndIAudioVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IAudioVehicleFeature>(builder.EndTable());
		}

		// Token: 0x0601FD2C RID: 130348 RVA: 0x0046D9C8 File Offset: 0x0046BBC8
		public IAudioVehicleFeatureT UnPack()
		{
			IAudioVehicleFeatureT audioVehicleFeatureT = new IAudioVehicleFeatureT();
			this.UnPackTo(audioVehicleFeatureT);
			return audioVehicleFeatureT;
		}

		// Token: 0x0601FD2D RID: 130349 RVA: 0x0046D9E4 File Offset: 0x0046BBE4
		public void UnPackTo(IAudioVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.AudioConfigs = ((this.AudioConfigs != null) ? this.AudioConfigs.Value.UnPack() : null);
		}

		// Token: 0x0601FD2E RID: 130350 RVA: 0x0046DA2C File Offset: 0x0046BC2C
		public static Offset<IAudioVehicleFeature> Pack(FlatBufferBuilder builder, IAudioVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioVehicleFeature>);
			}
			Offset<IVehicleAudioConfig> audioConfigsOffset = (_o.AudioConfigs == null) ? default(Offset<IVehicleAudioConfig>) : IVehicleAudioConfig.Pack(builder, _o.AudioConfigs);
			return IAudioVehicleFeature.CreateIAudioVehicleFeature(builder, _o.Type, audioConfigsOffset);
		}

		// Token: 0x0400DCE5 RID: 56549
		private Table __p;
	}
}
