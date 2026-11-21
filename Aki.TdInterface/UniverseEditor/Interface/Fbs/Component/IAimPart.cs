using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005394 RID: 21396
	public struct IAimPart : IFlatbufferObject
	{
		// Token: 0x17009737 RID: 38711
		// (get) Token: 0x060215DB RID: 136667 RVA: 0x0049AB74 File Offset: 0x00498D74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060215DC RID: 136668 RVA: 0x0049AB81 File Offset: 0x00498D81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060215DD RID: 136669 RVA: 0x0049AB88 File Offset: 0x00498D88
		public static IAimPart GetRootAsIAimPart(ByteBuffer _bb)
		{
			return IAimPart.GetRootAsIAimPart(_bb, default(IAimPart));
		}

		// Token: 0x060215DE RID: 136670 RVA: 0x0049ABA4 File Offset: 0x00498DA4
		public static IAimPart GetRootAsIAimPart(ByteBuffer _bb, IAimPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060215DF RID: 136671 RVA: 0x0049ABC1 File Offset: 0x00498DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060215E0 RID: 136672 RVA: 0x0049ABD0 File Offset: 0x00498DD0
		public IAimPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009738 RID: 38712
		// (get) Token: 0x060215E1 RID: 136673 RVA: 0x0049ABE0 File Offset: 0x00498DE0
		public string BoneName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060215E2 RID: 136674 RVA: 0x0049AC17 File Offset: 0x00498E17
		public Span<byte> GetBoneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060215E3 RID: 136675 RVA: 0x0049AC26 File Offset: 0x00498E26
		public byte[] GetBoneNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009739 RID: 38713
		// (get) Token: 0x060215E4 RID: 136676 RVA: 0x0049AC34 File Offset: 0x00498E34
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700973A RID: 38714
		// (get) Token: 0x060215E5 RID: 136677 RVA: 0x0049AC94 File Offset: 0x00498E94
		public int RadiusIn
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700973B RID: 38715
		// (get) Token: 0x060215E6 RID: 136678 RVA: 0x0049ACD0 File Offset: 0x00498ED0
		public int RadiusOut
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

		// Token: 0x1700973C RID: 38716
		// (get) Token: 0x060215E7 RID: 136679 RVA: 0x0049AD10 File Offset: 0x00498F10
		public int RadiusOutOnStart
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700973D RID: 38717
		// (get) Token: 0x060215E8 RID: 136680 RVA: 0x0049AD50 File Offset: 0x00498F50
		public float MobileCorrect
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

		// Token: 0x1700973E RID: 38718
		// (get) Token: 0x060215E9 RID: 136681 RVA: 0x0049AD94 File Offset: 0x00498F94
		public float GamePadCorrect
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060215EA RID: 136682 RVA: 0x0049ADD8 File Offset: 0x00498FD8
		public static Offset<IAimPart> CreateIAimPart(FlatBufferBuilder builder, StringOffset BoneNameOffset = default(StringOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), int RadiusIn = 0, int RadiusOut = 0, int RadiusOutOnStart = 0, float MobileCorrect = 0f, float GamePadCorrect = 0f)
		{
			builder.StartTable(7);
			IAimPart.AddGamePadCorrect(builder, GamePadCorrect);
			IAimPart.AddMobileCorrect(builder, MobileCorrect);
			IAimPart.AddRadiusOutOnStart(builder, RadiusOutOnStart);
			IAimPart.AddRadiusOut(builder, RadiusOut);
			IAimPart.AddRadiusIn(builder, RadiusIn);
			IAimPart.AddOffset(builder, OffsetOffset);
			IAimPart.AddBoneName(builder, BoneNameOffset);
			return IAimPart.EndIAimPart(builder);
		}

		// Token: 0x060215EB RID: 136683 RVA: 0x0049AE27 File Offset: 0x00499027
		public static void StartIAimPart(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060215EC RID: 136684 RVA: 0x0049AE30 File Offset: 0x00499030
		public static void AddBoneName(FlatBufferBuilder builder, StringOffset boneNameOffset)
		{
			builder.AddOffset(0, boneNameOffset.Value, 0);
		}

		// Token: 0x060215ED RID: 136685 RVA: 0x0049AE40 File Offset: 0x00499040
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060215EE RID: 136686 RVA: 0x0049AE50 File Offset: 0x00499050
		public static void AddRadiusIn(FlatBufferBuilder builder, int radiusIn)
		{
			builder.AddInt(2, radiusIn, 0);
		}

		// Token: 0x060215EF RID: 136687 RVA: 0x0049AE5B File Offset: 0x0049905B
		public static void AddRadiusOut(FlatBufferBuilder builder, int radiusOut)
		{
			builder.AddInt(3, radiusOut, 0);
		}

		// Token: 0x060215F0 RID: 136688 RVA: 0x0049AE66 File Offset: 0x00499066
		public static void AddRadiusOutOnStart(FlatBufferBuilder builder, int radiusOutOnStart)
		{
			builder.AddInt(4, radiusOutOnStart, 0);
		}

		// Token: 0x060215F1 RID: 136689 RVA: 0x0049AE71 File Offset: 0x00499071
		public static void AddMobileCorrect(FlatBufferBuilder builder, float mobileCorrect)
		{
			builder.AddFloat(5, mobileCorrect, 0.0);
		}

		// Token: 0x060215F2 RID: 136690 RVA: 0x0049AE84 File Offset: 0x00499084
		public static void AddGamePadCorrect(FlatBufferBuilder builder, float gamePadCorrect)
		{
			builder.AddFloat(6, gamePadCorrect, 0.0);
		}

		// Token: 0x060215F3 RID: 136691 RVA: 0x0049AE97 File Offset: 0x00499097
		public static Offset<IAimPart> EndIAimPart(FlatBufferBuilder builder)
		{
			return new Offset<IAimPart>(builder.EndTable());
		}

		// Token: 0x060215F4 RID: 136692 RVA: 0x0049AEA4 File Offset: 0x004990A4
		public IAimPartT UnPack()
		{
			IAimPartT aimPartT = new IAimPartT();
			this.UnPackTo(aimPartT);
			return aimPartT;
		}

		// Token: 0x060215F5 RID: 136693 RVA: 0x0049AEC0 File Offset: 0x004990C0
		public void UnPackTo(IAimPartT _o)
		{
			_o.BoneName = this.BoneName;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.RadiusIn = this.RadiusIn;
			_o.RadiusOut = this.RadiusOut;
			_o.RadiusOutOnStart = this.RadiusOutOnStart;
			_o.MobileCorrect = this.MobileCorrect;
			_o.GamePadCorrect = this.GamePadCorrect;
		}

		// Token: 0x060215F6 RID: 136694 RVA: 0x0049AF44 File Offset: 0x00499144
		public static Offset<IAimPart> Pack(FlatBufferBuilder builder, IAimPartT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAimPart>);
			}
			StringOffset boneNameOffset = (_o.BoneName == null) ? default(StringOffset) : builder.CreateString(_o.BoneName);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IAimPart.CreateIAimPart(builder, boneNameOffset, offsetOffset, _o.RadiusIn, _o.RadiusOut, _o.RadiusOutOnStart, _o.MobileCorrect, _o.GamePadCorrect);
		}

		// Token: 0x0400E7BC RID: 59324
		private Table __p;
	}
}
