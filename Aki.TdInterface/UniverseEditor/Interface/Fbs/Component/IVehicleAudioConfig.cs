using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200611E RID: 24862
	public struct IVehicleAudioConfig : IFlatbufferObject
	{
		// Token: 0x1700B919 RID: 47385
		// (get) Token: 0x0602A270 RID: 172656 RVA: 0x005C0B23 File Offset: 0x005BED23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A271 RID: 172657 RVA: 0x005C0B30 File Offset: 0x005BED30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A272 RID: 172658 RVA: 0x005C0B38 File Offset: 0x005BED38
		public static IVehicleAudioConfig GetRootAsIVehicleAudioConfig(ByteBuffer _bb)
		{
			return IVehicleAudioConfig.GetRootAsIVehicleAudioConfig(_bb, default(IVehicleAudioConfig));
		}

		// Token: 0x0602A273 RID: 172659 RVA: 0x005C0B54 File Offset: 0x005BED54
		public static IVehicleAudioConfig GetRootAsIVehicleAudioConfig(ByteBuffer _bb, IVehicleAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A274 RID: 172660 RVA: 0x005C0B71 File Offset: 0x005BED71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A275 RID: 172661 RVA: 0x005C0B80 File Offset: 0x005BED80
		public IVehicleAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B91A RID: 47386
		// (get) Token: 0x0602A276 RID: 172662 RVA: 0x005C0B90 File Offset: 0x005BED90
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

		// Token: 0x1700B91B RID: 47387
		// (get) Token: 0x0602A277 RID: 172663 RVA: 0x005C0BD0 File Offset: 0x005BEDD0
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

		// Token: 0x1700B91C RID: 47388
		// (get) Token: 0x0602A278 RID: 172664 RVA: 0x005C0C10 File Offset: 0x005BEE10
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

		// Token: 0x0602A279 RID: 172665 RVA: 0x005C0C47 File Offset: 0x005BEE47
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602A27A RID: 172666 RVA: 0x005C0C56 File Offset: 0x005BEE56
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602A27B RID: 172667 RVA: 0x005C0C64 File Offset: 0x005BEE64
		public static Offset<IVehicleAudioConfig> CreateIVehicleAudioConfig(FlatBufferBuilder builder, float MinVehicleSpeed = 0f, float MaxVehicleSpeed = 0f, StringOffset AudioEventOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVehicleAudioConfig.AddAudioEvent(builder, AudioEventOffset);
			IVehicleAudioConfig.AddMaxVehicleSpeed(builder, MaxVehicleSpeed);
			IVehicleAudioConfig.AddMinVehicleSpeed(builder, MinVehicleSpeed);
			return IVehicleAudioConfig.EndIVehicleAudioConfig(builder);
		}

		// Token: 0x0602A27C RID: 172668 RVA: 0x005C0C88 File Offset: 0x005BEE88
		public static void StartIVehicleAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A27D RID: 172669 RVA: 0x005C0C91 File Offset: 0x005BEE91
		public static void AddMinVehicleSpeed(FlatBufferBuilder builder, float minVehicleSpeed)
		{
			builder.AddFloat(0, minVehicleSpeed, 0.0);
		}

		// Token: 0x0602A27E RID: 172670 RVA: 0x005C0CA4 File Offset: 0x005BEEA4
		public static void AddMaxVehicleSpeed(FlatBufferBuilder builder, float maxVehicleSpeed)
		{
			builder.AddFloat(1, maxVehicleSpeed, 0.0);
		}

		// Token: 0x0602A27F RID: 172671 RVA: 0x005C0CB7 File Offset: 0x005BEEB7
		public static void AddAudioEvent(FlatBufferBuilder builder, StringOffset audioEventOffset)
		{
			builder.AddOffset(2, audioEventOffset.Value, 0);
		}

		// Token: 0x0602A280 RID: 172672 RVA: 0x005C0CC7 File Offset: 0x005BEEC7
		public static Offset<IVehicleAudioConfig> EndIVehicleAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleAudioConfig>(builder.EndTable());
		}

		// Token: 0x0602A281 RID: 172673 RVA: 0x005C0CD4 File Offset: 0x005BEED4
		public IVehicleAudioConfigT UnPack()
		{
			IVehicleAudioConfigT vehicleAudioConfigT = new IVehicleAudioConfigT();
			this.UnPackTo(vehicleAudioConfigT);
			return vehicleAudioConfigT;
		}

		// Token: 0x0602A282 RID: 172674 RVA: 0x005C0CEF File Offset: 0x005BEEEF
		public void UnPackTo(IVehicleAudioConfigT _o)
		{
			_o.MinVehicleSpeed = this.MinVehicleSpeed;
			_o.MaxVehicleSpeed = this.MaxVehicleSpeed;
			_o.AudioEvent = this.AudioEvent;
		}

		// Token: 0x0602A283 RID: 172675 RVA: 0x005C0D18 File Offset: 0x005BEF18
		public static Offset<IVehicleAudioConfig> Pack(FlatBufferBuilder builder, IVehicleAudioConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleAudioConfig>);
			}
			StringOffset audioEventOffset = (_o.AudioEvent == null) ? default(StringOffset) : builder.CreateString(_o.AudioEvent);
			return IVehicleAudioConfig.CreateIVehicleAudioConfig(builder, _o.MinVehicleSpeed, _o.MaxVehicleSpeed, audioEventOffset);
		}

		// Token: 0x0400FF12 RID: 65298
		private Table __p;
	}
}
