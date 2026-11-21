using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005933 RID: 22835
	public struct IHoldConfig : IFlatbufferObject
	{
		// Token: 0x1700A596 RID: 42390
		// (get) Token: 0x06025218 RID: 152088 RVA: 0x0051855B File Offset: 0x0051675B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025219 RID: 152089 RVA: 0x00518568 File Offset: 0x00516768
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602521A RID: 152090 RVA: 0x00518570 File Offset: 0x00516770
		public static IHoldConfig GetRootAsIHoldConfig(ByteBuffer _bb)
		{
			return IHoldConfig.GetRootAsIHoldConfig(_bb, default(IHoldConfig));
		}

		// Token: 0x0602521B RID: 152091 RVA: 0x0051858C File Offset: 0x0051678C
		public static IHoldConfig GetRootAsIHoldConfig(ByteBuffer _bb, IHoldConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602521C RID: 152092 RVA: 0x005185A9 File Offset: 0x005167A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602521D RID: 152093 RVA: 0x005185B8 File Offset: 0x005167B8
		public IHoldConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A597 RID: 42391
		// (get) Token: 0x0602521E RID: 152094 RVA: 0x005185C8 File Offset: 0x005167C8
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

		// Token: 0x1700A598 RID: 42392
		// (get) Token: 0x0602521F RID: 152095 RVA: 0x00518604 File Offset: 0x00516804
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

		// Token: 0x1700A599 RID: 42393
		// (get) Token: 0x06025220 RID: 152096 RVA: 0x00518640 File Offset: 0x00516840
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

		// Token: 0x1700A59A RID: 42394
		// (get) Token: 0x06025221 RID: 152097 RVA: 0x005186A0 File Offset: 0x005168A0
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

		// Token: 0x1700A59B RID: 42395
		// (get) Token: 0x06025222 RID: 152098 RVA: 0x00518700 File Offset: 0x00516900
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

		// Token: 0x1700A59C RID: 42396
		// (get) Token: 0x06025223 RID: 152099 RVA: 0x00518760 File Offset: 0x00516960
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

		// Token: 0x1700A59D RID: 42397
		// (get) Token: 0x06025224 RID: 152100 RVA: 0x005187A0 File Offset: 0x005169A0
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

		// Token: 0x06025225 RID: 152101 RVA: 0x005187D8 File Offset: 0x005169D8
		public Span<byte> GetHoldCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06025226 RID: 152102 RVA: 0x005187E8 File Offset: 0x005169E8
		public byte[] GetHoldCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700A59E RID: 42398
		// (get) Token: 0x06025227 RID: 152103 RVA: 0x005187F8 File Offset: 0x005169F8
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

		// Token: 0x06025228 RID: 152104 RVA: 0x00518830 File Offset: 0x00516A30
		public Span<byte> GetHoldCameraStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06025229 RID: 152105 RVA: 0x00518840 File Offset: 0x00516A40
		public byte[] GetHoldCameraStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0602522A RID: 152106 RVA: 0x00518850 File Offset: 0x00516A50
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

		// Token: 0x0602522B RID: 152107 RVA: 0x005188A7 File Offset: 0x00516AA7
		public static void StartIHoldConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602522C RID: 152108 RVA: 0x005188B0 File Offset: 0x00516AB0
		public static void AddHoldSwingFreq(FlatBufferBuilder builder, int holdSwingFreq)
		{
			builder.AddInt(0, holdSwingFreq, 0);
		}

		// Token: 0x0602522D RID: 152109 RVA: 0x005188BB File Offset: 0x00516ABB
		public static void AddHoldAngularVelocity(FlatBufferBuilder builder, int holdAngularVelocity)
		{
			builder.AddInt(1, holdAngularVelocity, 0);
		}

		// Token: 0x0602522E RID: 152110 RVA: 0x005188C6 File Offset: 0x00516AC6
		public static void AddHoldRotation(FlatBufferBuilder builder, Offset<IVectorInfo> holdRotationOffset)
		{
			builder.AddOffset(2, holdRotationOffset.Value, 0);
		}

		// Token: 0x0602522F RID: 152111 RVA: 0x005188D6 File Offset: 0x00516AD6
		public static void AddHoldOffset(FlatBufferBuilder builder, Offset<IVectorInfo> holdOffsetOffset)
		{
			builder.AddOffset(3, holdOffsetOffset.Value, 0);
		}

		// Token: 0x06025230 RID: 152112 RVA: 0x005188E6 File Offset: 0x00516AE6
		public static void AddSecondaryOffset(FlatBufferBuilder builder, Offset<IVectorInfo> secondaryOffsetOffset)
		{
			builder.AddOffset(4, secondaryOffsetOffset.Value, 0);
		}

		// Token: 0x06025231 RID: 152113 RVA: 0x005188F6 File Offset: 0x00516AF6
		public static void AddHoldSwingRange(FlatBufferBuilder builder, int holdSwingRange)
		{
			builder.AddInt(5, holdSwingRange, 0);
		}

		// Token: 0x06025232 RID: 152114 RVA: 0x00518901 File Offset: 0x00516B01
		public static void AddHoldCameraShake(FlatBufferBuilder builder, StringOffset holdCameraShakeOffset)
		{
			builder.AddOffset(6, holdCameraShakeOffset.Value, 0);
		}

		// Token: 0x06025233 RID: 152115 RVA: 0x00518911 File Offset: 0x00516B11
		public static void AddHoldCameraStateTag(FlatBufferBuilder builder, StringOffset holdCameraStateTagOffset)
		{
			builder.AddOffset(7, holdCameraStateTagOffset.Value, 0);
		}

		// Token: 0x06025234 RID: 152116 RVA: 0x00518921 File Offset: 0x00516B21
		public static Offset<IHoldConfig> EndIHoldConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHoldConfig>(builder.EndTable());
		}

		// Token: 0x06025235 RID: 152117 RVA: 0x00518930 File Offset: 0x00516B30
		public IHoldConfigT UnPack()
		{
			IHoldConfigT holdConfigT = new IHoldConfigT();
			this.UnPackTo(holdConfigT);
			return holdConfigT;
		}

		// Token: 0x06025236 RID: 152118 RVA: 0x0051894C File Offset: 0x00516B4C
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

		// Token: 0x06025237 RID: 152119 RVA: 0x00518A24 File Offset: 0x00516C24
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

		// Token: 0x0400F1D0 RID: 61904
		private Table __p;
	}
}
