using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E83 RID: 20099
	public struct IAimPart : IFlatbufferObject
	{
		// Token: 0x17008FFE RID: 36862
		// (get) Token: 0x0601F990 RID: 129424 RVA: 0x00466B5C File Offset: 0x00464D5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F991 RID: 129425 RVA: 0x00466B69 File Offset: 0x00464D69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F992 RID: 129426 RVA: 0x00466B70 File Offset: 0x00464D70
		public static IAimPart GetRootAsIAimPart(ByteBuffer _bb)
		{
			return IAimPart.GetRootAsIAimPart(_bb, default(IAimPart));
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x00466B8C File Offset: 0x00464D8C
		public static IAimPart GetRootAsIAimPart(ByteBuffer _bb, IAimPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x00466BA9 File Offset: 0x00464DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x00466BB8 File Offset: 0x00464DB8
		public IAimPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FFF RID: 36863
		// (get) Token: 0x0601F996 RID: 129430 RVA: 0x00466BC8 File Offset: 0x00464DC8
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

		// Token: 0x0601F997 RID: 129431 RVA: 0x00466BFF File Offset: 0x00464DFF
		public Span<byte> GetBoneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601F998 RID: 129432 RVA: 0x00466C0E File Offset: 0x00464E0E
		public byte[] GetBoneNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009000 RID: 36864
		// (get) Token: 0x0601F999 RID: 129433 RVA: 0x00466C1C File Offset: 0x00464E1C
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

		// Token: 0x17009001 RID: 36865
		// (get) Token: 0x0601F99A RID: 129434 RVA: 0x00466C7C File Offset: 0x00464E7C
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

		// Token: 0x17009002 RID: 36866
		// (get) Token: 0x0601F99B RID: 129435 RVA: 0x00466CB8 File Offset: 0x00464EB8
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

		// Token: 0x17009003 RID: 36867
		// (get) Token: 0x0601F99C RID: 129436 RVA: 0x00466CF8 File Offset: 0x00464EF8
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

		// Token: 0x17009004 RID: 36868
		// (get) Token: 0x0601F99D RID: 129437 RVA: 0x00466D38 File Offset: 0x00464F38
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

		// Token: 0x17009005 RID: 36869
		// (get) Token: 0x0601F99E RID: 129438 RVA: 0x00466D7C File Offset: 0x00464F7C
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

		// Token: 0x0601F99F RID: 129439 RVA: 0x00466DC0 File Offset: 0x00464FC0
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

		// Token: 0x0601F9A0 RID: 129440 RVA: 0x00466E0F File Offset: 0x0046500F
		public static void StartIAimPart(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601F9A1 RID: 129441 RVA: 0x00466E18 File Offset: 0x00465018
		public static void AddBoneName(FlatBufferBuilder builder, StringOffset boneNameOffset)
		{
			builder.AddOffset(0, boneNameOffset.Value, 0);
		}

		// Token: 0x0601F9A2 RID: 129442 RVA: 0x00466E28 File Offset: 0x00465028
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0601F9A3 RID: 129443 RVA: 0x00466E38 File Offset: 0x00465038
		public static void AddRadiusIn(FlatBufferBuilder builder, int radiusIn)
		{
			builder.AddInt(2, radiusIn, 0);
		}

		// Token: 0x0601F9A4 RID: 129444 RVA: 0x00466E43 File Offset: 0x00465043
		public static void AddRadiusOut(FlatBufferBuilder builder, int radiusOut)
		{
			builder.AddInt(3, radiusOut, 0);
		}

		// Token: 0x0601F9A5 RID: 129445 RVA: 0x00466E4E File Offset: 0x0046504E
		public static void AddRadiusOutOnStart(FlatBufferBuilder builder, int radiusOutOnStart)
		{
			builder.AddInt(4, radiusOutOnStart, 0);
		}

		// Token: 0x0601F9A6 RID: 129446 RVA: 0x00466E59 File Offset: 0x00465059
		public static void AddMobileCorrect(FlatBufferBuilder builder, float mobileCorrect)
		{
			builder.AddFloat(5, mobileCorrect, 0.0);
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x00466E6C File Offset: 0x0046506C
		public static void AddGamePadCorrect(FlatBufferBuilder builder, float gamePadCorrect)
		{
			builder.AddFloat(6, gamePadCorrect, 0.0);
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x00466E7F File Offset: 0x0046507F
		public static Offset<IAimPart> EndIAimPart(FlatBufferBuilder builder)
		{
			return new Offset<IAimPart>(builder.EndTable());
		}

		// Token: 0x0601F9A9 RID: 129449 RVA: 0x00466E8C File Offset: 0x0046508C
		public IAimPartT UnPack()
		{
			IAimPartT aimPartT = new IAimPartT();
			this.UnPackTo(aimPartT);
			return aimPartT;
		}

		// Token: 0x0601F9AA RID: 129450 RVA: 0x00466EA8 File Offset: 0x004650A8
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

		// Token: 0x0601F9AB RID: 129451 RVA: 0x00466F2C File Offset: 0x0046512C
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

		// Token: 0x0400DC42 RID: 56386
		private Table __p;
	}
}
