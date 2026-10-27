using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F79 RID: 20345
	public struct IChantConfig : IFlatbufferObject
	{
		// Token: 0x17009307 RID: 37639
		// (get) Token: 0x060204B1 RID: 132273 RVA: 0x0047E458 File Offset: 0x0047C658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060204B2 RID: 132274 RVA: 0x0047E465 File Offset: 0x0047C665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060204B3 RID: 132275 RVA: 0x0047E46C File Offset: 0x0047C66C
		public static IChantConfig GetRootAsIChantConfig(ByteBuffer _bb)
		{
			return IChantConfig.GetRootAsIChantConfig(_bb, default(IChantConfig));
		}

		// Token: 0x060204B4 RID: 132276 RVA: 0x0047E488 File Offset: 0x0047C688
		public static IChantConfig GetRootAsIChantConfig(ByteBuffer _bb, IChantConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060204B5 RID: 132277 RVA: 0x0047E4A5 File Offset: 0x0047C6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060204B6 RID: 132278 RVA: 0x0047E4B4 File Offset: 0x0047C6B4
		public IChantConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009308 RID: 37640
		// (get) Token: 0x060204B7 RID: 132279 RVA: 0x0047E4C4 File Offset: 0x0047C6C4
		public int ChantTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009309 RID: 37641
		// (get) Token: 0x060204B8 RID: 132280 RVA: 0x0047E500 File Offset: 0x0047C700
		public string ChantCameraShake
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

		// Token: 0x060204B9 RID: 132281 RVA: 0x0047E537 File Offset: 0x0047C737
		public Span<byte> GetChantCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060204BA RID: 132282 RVA: 0x0047E546 File Offset: 0x0047C746
		public byte[] GetChantCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700930A RID: 37642
		// (get) Token: 0x060204BB RID: 132283 RVA: 0x0047E554 File Offset: 0x0047C754
		public string ChantCameraStateTag
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

		// Token: 0x060204BC RID: 132284 RVA: 0x0047E58B File Offset: 0x0047C78B
		public Span<byte> GetChantCameraStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060204BD RID: 132285 RVA: 0x0047E59A File Offset: 0x0047C79A
		public byte[] GetChantCameraStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060204BE RID: 132286 RVA: 0x0047E5A8 File Offset: 0x0047C7A8
		public static Offset<IChantConfig> CreateIChantConfig(FlatBufferBuilder builder, int ChantTime = 0, StringOffset ChantCameraShakeOffset = default(StringOffset), StringOffset ChantCameraStateTagOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IChantConfig.AddChantCameraStateTag(builder, ChantCameraStateTagOffset);
			IChantConfig.AddChantCameraShake(builder, ChantCameraShakeOffset);
			IChantConfig.AddChantTime(builder, ChantTime);
			return IChantConfig.EndIChantConfig(builder);
		}

		// Token: 0x060204BF RID: 132287 RVA: 0x0047E5CC File Offset: 0x0047C7CC
		public static void StartIChantConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060204C0 RID: 132288 RVA: 0x0047E5D5 File Offset: 0x0047C7D5
		public static void AddChantTime(FlatBufferBuilder builder, int chantTime)
		{
			builder.AddInt(0, chantTime, 0);
		}

		// Token: 0x060204C1 RID: 132289 RVA: 0x0047E5E0 File Offset: 0x0047C7E0
		public static void AddChantCameraShake(FlatBufferBuilder builder, StringOffset chantCameraShakeOffset)
		{
			builder.AddOffset(1, chantCameraShakeOffset.Value, 0);
		}

		// Token: 0x060204C2 RID: 132290 RVA: 0x0047E5F0 File Offset: 0x0047C7F0
		public static void AddChantCameraStateTag(FlatBufferBuilder builder, StringOffset chantCameraStateTagOffset)
		{
			builder.AddOffset(2, chantCameraStateTagOffset.Value, 0);
		}

		// Token: 0x060204C3 RID: 132291 RVA: 0x0047E600 File Offset: 0x0047C800
		public static Offset<IChantConfig> EndIChantConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChantConfig>(builder.EndTable());
		}

		// Token: 0x060204C4 RID: 132292 RVA: 0x0047E610 File Offset: 0x0047C810
		public IChantConfigT UnPack()
		{
			IChantConfigT chantConfigT = new IChantConfigT();
			this.UnPackTo(chantConfigT);
			return chantConfigT;
		}

		// Token: 0x060204C5 RID: 132293 RVA: 0x0047E62B File Offset: 0x0047C82B
		public void UnPackTo(IChantConfigT _o)
		{
			_o.ChantTime = this.ChantTime;
			_o.ChantCameraShake = this.ChantCameraShake;
			_o.ChantCameraStateTag = this.ChantCameraStateTag;
		}

		// Token: 0x060204C6 RID: 132294 RVA: 0x0047E654 File Offset: 0x0047C854
		public static Offset<IChantConfig> Pack(FlatBufferBuilder builder, IChantConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChantConfig>);
			}
			StringOffset chantCameraShakeOffset = (_o.ChantCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.ChantCameraShake);
			StringOffset chantCameraStateTagOffset = (_o.ChantCameraStateTag == null) ? default(StringOffset) : builder.CreateString(_o.ChantCameraStateTag);
			return IChantConfig.CreateIChantConfig(builder, _o.ChantTime, chantCameraShakeOffset, chantCameraStateTagOffset);
		}

		// Token: 0x0400DE1F RID: 56863
		private Table __p;
	}
}
