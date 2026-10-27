using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AD RID: 21421
	public struct IHoldConfig : IFlatbufferObject
	{
		// Token: 0x17009D5E RID: 40286
		// (get) Token: 0x06023164 RID: 143716 RVA: 0x004DB687 File Offset: 0x004D9887
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023165 RID: 143717 RVA: 0x004DB694 File Offset: 0x004D9894
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023166 RID: 143718 RVA: 0x004DB69C File Offset: 0x004D989C
		public static IHoldConfig GetRootAsIHoldConfig(ByteBuffer _bb)
		{
			return IHoldConfig.GetRootAsIHoldConfig(_bb, default(IHoldConfig));
		}

		// Token: 0x06023167 RID: 143719 RVA: 0x004DB6B8 File Offset: 0x004D98B8
		public static IHoldConfig GetRootAsIHoldConfig(ByteBuffer _bb, IHoldConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023168 RID: 143720 RVA: 0x004DB6D5 File Offset: 0x004D98D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023169 RID: 143721 RVA: 0x004DB6E4 File Offset: 0x004D98E4
		public IHoldConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D5F RID: 40287
		// (get) Token: 0x0602316A RID: 143722 RVA: 0x004DB6F4 File Offset: 0x004D98F4
		public int HoldSwingFreq
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

		// Token: 0x17009D60 RID: 40288
		// (get) Token: 0x0602316B RID: 143723 RVA: 0x004DB730 File Offset: 0x004D9930
		public int HoldAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D61 RID: 40289
		// (get) Token: 0x0602316C RID: 143724 RVA: 0x004DB76C File Offset: 0x004D996C
		public IVectorInfo? HoldRotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D62 RID: 40290
		// (get) Token: 0x0602316D RID: 143725 RVA: 0x004DB7CC File Offset: 0x004D99CC
		public IVectorInfo? HoldOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D63 RID: 40291
		// (get) Token: 0x0602316E RID: 143726 RVA: 0x004DB82C File Offset: 0x004D9A2C
		public IVectorInfo? SecondaryOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D64 RID: 40292
		// (get) Token: 0x0602316F RID: 143727 RVA: 0x004DB88C File Offset: 0x004D9A8C
		public int HoldSwingRange
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D65 RID: 40293
		// (get) Token: 0x06023170 RID: 143728 RVA: 0x004DB8CC File Offset: 0x004D9ACC
		public string HoldCameraShake
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023171 RID: 143729 RVA: 0x004DB904 File Offset: 0x004D9B04
		public Span<byte> GetHoldCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06023172 RID: 143730 RVA: 0x004DB914 File Offset: 0x004D9B14
		public byte[] GetHoldCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009D66 RID: 40294
		// (get) Token: 0x06023173 RID: 143731 RVA: 0x004DB924 File Offset: 0x004D9B24
		public string HoldCameraStateTag
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023174 RID: 143732 RVA: 0x004DB95C File Offset: 0x004D9B5C
		public Span<byte> GetHoldCameraStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06023175 RID: 143733 RVA: 0x004DB96C File Offset: 0x004D9B6C
		public byte[] GetHoldCameraStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x06023176 RID: 143734 RVA: 0x004DB97C File Offset: 0x004D9B7C
		public static Offset<IHoldConfig> CreateIHoldConfig(FlatBufferBuilder builder, int HoldSwingFreq = 0, int HoldAngularVelocity = 0, Offset<IVectorInfo> HoldRotationOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> HoldOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SecondaryOffsetOffset = default(Offset<IVectorInfo>), int HoldSwingRange = 0, StringOffset HoldCameraShakeOffset = default(StringOffset), StringOffset HoldCameraStateTagOffset = default(StringOffset))
		{
			builder.StartTable(8);
			IHoldConfig.AddHoldCameraStateTag(builder, HoldCameraStateTagOffset);
			IHoldConfig.AddHoldCameraShake(builder, HoldCameraShakeOffset);
			IHoldConfig.AddHoldSwingRange(builder, HoldSwingRange);
			IHoldConfig.AddSecondaryOffset(builder, SecondaryOffsetOffset);
			IHoldConfig.AddHoldOffset(builder, HoldOffsetOffset);
			IHoldConfig.AddHoldRotation(builder, HoldRotationOffset);
			IHoldConfig.AddHoldAngularVelocity(builder, HoldAngularVelocity);
			IHoldConfig.AddHoldSwingFreq(builder, HoldSwingFreq);
			return IHoldConfig.EndIHoldConfig(builder);
		}

		// Token: 0x06023177 RID: 143735 RVA: 0x004DB9D3 File Offset: 0x004D9BD3
		public static void StartIHoldConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023178 RID: 143736 RVA: 0x004DB9DC File Offset: 0x004D9BDC
		public static void AddHoldSwingFreq(FlatBufferBuilder builder, int holdSwingFreq)
		{
			builder.AddInt(0, holdSwingFreq, 0);
		}

		// Token: 0x06023179 RID: 143737 RVA: 0x004DB9E7 File Offset: 0x004D9BE7
		public static void AddHoldAngularVelocity(FlatBufferBuilder builder, int holdAngularVelocity)
		{
			builder.AddInt(1, holdAngularVelocity, 0);
		}

		// Token: 0x0602317A RID: 143738 RVA: 0x004DB9F2 File Offset: 0x004D9BF2
		public static void AddHoldRotation(FlatBufferBuilder builder, Offset<IVectorInfo> holdRotationOffset)
		{
			builder.AddOffset(2, holdRotationOffset.Value, 0);
		}

		// Token: 0x0602317B RID: 143739 RVA: 0x004DBA02 File Offset: 0x004D9C02
		public static void AddHoldOffset(FlatBufferBuilder builder, Offset<IVectorInfo> holdOffsetOffset)
		{
			builder.AddOffset(3, holdOffsetOffset.Value, 0);
		}

		// Token: 0x0602317C RID: 143740 RVA: 0x004DBA12 File Offset: 0x004D9C12
		public static void AddSecondaryOffset(FlatBufferBuilder builder, Offset<IVectorInfo> secondaryOffsetOffset)
		{
			builder.AddOffset(4, secondaryOffsetOffset.Value, 0);
		}

		// Token: 0x0602317D RID: 143741 RVA: 0x004DBA22 File Offset: 0x004D9C22
		public static void AddHoldSwingRange(FlatBufferBuilder builder, int holdSwingRange)
		{
			builder.AddInt(5, holdSwingRange, 0);
		}

		// Token: 0x0602317E RID: 143742 RVA: 0x004DBA2D File Offset: 0x004D9C2D
		public static void AddHoldCameraShake(FlatBufferBuilder builder, StringOffset holdCameraShakeOffset)
		{
			builder.AddOffset(6, holdCameraShakeOffset.Value, 0);
		}

		// Token: 0x0602317F RID: 143743 RVA: 0x004DBA3D File Offset: 0x004D9C3D
		public static void AddHoldCameraStateTag(FlatBufferBuilder builder, StringOffset holdCameraStateTagOffset)
		{
			builder.AddOffset(7, holdCameraStateTagOffset.Value, 0);
		}

		// Token: 0x06023180 RID: 143744 RVA: 0x004DBA4D File Offset: 0x004D9C4D
		public static Offset<IHoldConfig> EndIHoldConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHoldConfig>(builder.EndTable());
		}

		// Token: 0x06023181 RID: 143745 RVA: 0x004DBA5C File Offset: 0x004D9C5C
		public IHoldConfigT UnPack()
		{
			IHoldConfigT holdConfigT = new IHoldConfigT();
			this.UnPackTo(holdConfigT);
			return holdConfigT;
		}

		// Token: 0x06023182 RID: 143746 RVA: 0x004DBA78 File Offset: 0x004D9C78
		public void UnPackTo(IHoldConfigT _o)
		{
			_o.HoldSwingFreq = this.HoldSwingFreq;
			_o.HoldAngularVelocity = this.HoldAngularVelocity;
			_o.HoldRotation = ((this.HoldRotation != null) ? this.HoldRotation.Value.UnPack() : null);
			_o.HoldOffset = ((this.HoldOffset != null) ? this.HoldOffset.Value.UnPack() : null);
			_o.SecondaryOffset = ((this.SecondaryOffset != null) ? this.SecondaryOffset.Value.UnPack() : null);
			_o.HoldSwingRange = this.HoldSwingRange;
			_o.HoldCameraShake = this.HoldCameraShake;
			_o.HoldCameraStateTag = this.HoldCameraStateTag;
		}

		// Token: 0x06023183 RID: 143747 RVA: 0x004DBB50 File Offset: 0x004D9D50
		public static Offset<IHoldConfig> Pack(FlatBufferBuilder builder, IHoldConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHoldConfig>);
			}
			Offset<IVectorInfo> holdRotationOffset = (_o.HoldRotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.HoldRotation);
			Offset<IVectorInfo> holdOffsetOffset = (_o.HoldOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.HoldOffset);
			Offset<IVectorInfo> secondaryOffsetOffset = (_o.SecondaryOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SecondaryOffset);
			StringOffset holdCameraShakeOffset = (_o.HoldCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.HoldCameraShake);
			StringOffset holdCameraStateTagOffset = (_o.HoldCameraStateTag == null) ? default(StringOffset) : builder.CreateString(_o.HoldCameraStateTag);
			return IHoldConfig.CreateIHoldConfig(builder, _o.HoldSwingFreq, _o.HoldAngularVelocity, holdRotationOffset, holdOffsetOffset, secondaryOffsetOffset, _o.HoldSwingRange, holdCameraShakeOffset, holdCameraStateTagOffset);
		}

		// Token: 0x0400E5A0 RID: 58784
		private Table __p;
	}
}
