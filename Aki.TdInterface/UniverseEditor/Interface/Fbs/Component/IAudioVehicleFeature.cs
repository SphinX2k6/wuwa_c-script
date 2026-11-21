using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540C RID: 21516
	public struct IAudioVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700985C RID: 39004
		// (get) Token: 0x06021A63 RID: 137827 RVA: 0x004A3644 File Offset: 0x004A1844
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A64 RID: 137828 RVA: 0x004A3651 File Offset: 0x004A1851
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A65 RID: 137829 RVA: 0x004A3658 File Offset: 0x004A1858
		public static IAudioVehicleFeature GetRootAsIAudioVehicleFeature(ByteBuffer _bb)
		{
			return IAudioVehicleFeature.GetRootAsIAudioVehicleFeature(_bb, default(IAudioVehicleFeature));
		}

		// Token: 0x06021A66 RID: 137830 RVA: 0x004A3674 File Offset: 0x004A1874
		public static IAudioVehicleFeature GetRootAsIAudioVehicleFeature(ByteBuffer _bb, IAudioVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A67 RID: 137831 RVA: 0x004A3691 File Offset: 0x004A1891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A68 RID: 137832 RVA: 0x004A36A0 File Offset: 0x004A18A0
		public IAudioVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700985D RID: 39005
		// (get) Token: 0x06021A69 RID: 137833 RVA: 0x004A36B0 File Offset: 0x004A18B0
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

		// Token: 0x1700985E RID: 39006
		// (get) Token: 0x06021A6A RID: 137834 RVA: 0x004A36EC File Offset: 0x004A18EC
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

		// Token: 0x06021A6B RID: 137835 RVA: 0x004A3749 File Offset: 0x004A1949
		public static Offset<IAudioVehicleFeature> CreateIAudioVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, Offset<IVehicleAudioConfig> AudioConfigsOffset = default(Offset<IVehicleAudioConfig>))
		{
			builder.StartTable(2);
			IAudioVehicleFeature.AddAudioConfigs(builder, AudioConfigsOffset);
			IAudioVehicleFeature.AddType(builder, Type);
			return IAudioVehicleFeature.EndIAudioVehicleFeature(builder);
		}

		// Token: 0x06021A6C RID: 137836 RVA: 0x004A3766 File Offset: 0x004A1966
		public static void StartIAudioVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021A6D RID: 137837 RVA: 0x004A376F File Offset: 0x004A196F
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021A6E RID: 137838 RVA: 0x004A377A File Offset: 0x004A197A
		public static void AddAudioConfigs(FlatBufferBuilder builder, Offset<IVehicleAudioConfig> audioConfigsOffset)
		{
			builder.AddOffset(1, audioConfigsOffset.Value, 0);
		}

		// Token: 0x06021A6F RID: 137839 RVA: 0x004A378A File Offset: 0x004A198A
		public static Offset<IAudioVehicleFeature> EndIAudioVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IAudioVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06021A70 RID: 137840 RVA: 0x004A3798 File Offset: 0x004A1998
		public IAudioVehicleFeatureT UnPack()
		{
			IAudioVehicleFeatureT audioVehicleFeatureT = new IAudioVehicleFeatureT();
			this.UnPackTo(audioVehicleFeatureT);
			return audioVehicleFeatureT;
		}

		// Token: 0x06021A71 RID: 137841 RVA: 0x004A37B4 File Offset: 0x004A19B4
		public void UnPackTo(IAudioVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.AudioConfigs = ((this.AudioConfigs != null) ? this.AudioConfigs.Value.UnPack() : null);
		}

		// Token: 0x06021A72 RID: 137842 RVA: 0x004A37FC File Offset: 0x004A19FC
		public static Offset<IAudioVehicleFeature> Pack(FlatBufferBuilder builder, IAudioVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioVehicleFeature>);
			}
			Offset<IVehicleAudioConfig> audioConfigsOffset = (_o.AudioConfigs == null) ? default(Offset<IVehicleAudioConfig>) : IVehicleAudioConfig.Pack(builder, _o.AudioConfigs);
			return IAudioVehicleFeature.CreateIAudioVehicleFeature(builder, _o.Type, audioConfigsOffset);
		}

		// Token: 0x0400E88C RID: 59532
		private Table __p;
	}
}
