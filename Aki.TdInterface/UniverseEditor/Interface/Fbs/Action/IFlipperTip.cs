using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E63 RID: 28259
	public struct IFlipperTip : IFlatbufferObject
	{
		// Token: 0x1700CF16 RID: 53014
		// (get) Token: 0x06030D05 RID: 199941 RVA: 0x0069FA51 File Offset: 0x0069DC51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D06 RID: 199942 RVA: 0x0069FA5E File Offset: 0x0069DC5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D07 RID: 199943 RVA: 0x0069FA68 File Offset: 0x0069DC68
		public static IFlipperTip GetRootAsIFlipperTip(ByteBuffer _bb)
		{
			return IFlipperTip.GetRootAsIFlipperTip(_bb, default(IFlipperTip));
		}

		// Token: 0x06030D08 RID: 199944 RVA: 0x0069FA84 File Offset: 0x0069DC84
		public static IFlipperTip GetRootAsIFlipperTip(ByteBuffer _bb, IFlipperTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D09 RID: 199945 RVA: 0x0069FAA1 File Offset: 0x0069DCA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D0A RID: 199946 RVA: 0x0069FAB0 File Offset: 0x0069DCB0
		public IFlipperTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF17 RID: 53015
		// (get) Token: 0x06030D0B RID: 199947 RVA: 0x0069FAC0 File Offset: 0x0069DCC0
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF18 RID: 53016
		// (get) Token: 0x06030D0C RID: 199948 RVA: 0x0069FAFC File Offset: 0x0069DCFC
		public string TidMainText
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

		// Token: 0x06030D0D RID: 199949 RVA: 0x0069FB33 File Offset: 0x0069DD33
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030D0E RID: 199950 RVA: 0x0069FB42 File Offset: 0x0069DD42
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CF19 RID: 53017
		// (get) Token: 0x06030D0F RID: 199951 RVA: 0x0069FB50 File Offset: 0x0069DD50
		public string TidSubText
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

		// Token: 0x06030D10 RID: 199952 RVA: 0x0069FB87 File Offset: 0x0069DD87
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030D11 RID: 199953 RVA: 0x0069FB96 File Offset: 0x0069DD96
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06030D12 RID: 199954 RVA: 0x0069FBA4 File Offset: 0x0069DDA4
		public static Offset<IFlipperTip> CreateIFlipperTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFlipperTip.AddTidSubText(builder, TidSubTextOffset);
			IFlipperTip.AddTidMainText(builder, TidMainTextOffset);
			IFlipperTip.AddType(builder, Type);
			return IFlipperTip.EndIFlipperTip(builder);
		}

		// Token: 0x06030D13 RID: 199955 RVA: 0x0069FBC8 File Offset: 0x0069DDC8
		public static void StartIFlipperTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030D14 RID: 199956 RVA: 0x0069FBD1 File Offset: 0x0069DDD1
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030D15 RID: 199957 RVA: 0x0069FBDC File Offset: 0x0069DDDC
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06030D16 RID: 199958 RVA: 0x0069FBEC File Offset: 0x0069DDEC
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06030D17 RID: 199959 RVA: 0x0069FBFC File Offset: 0x0069DDFC
		public static Offset<IFlipperTip> EndIFlipperTip(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperTip>(builder.EndTable());
		}

		// Token: 0x06030D18 RID: 199960 RVA: 0x0069FC0C File Offset: 0x0069DE0C
		public IFlipperTipT UnPack()
		{
			IFlipperTipT flipperTipT = new IFlipperTipT();
			this.UnPackTo(flipperTipT);
			return flipperTipT;
		}

		// Token: 0x06030D19 RID: 199961 RVA: 0x0069FC27 File Offset: 0x0069DE27
		public void UnPackTo(IFlipperTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06030D1A RID: 199962 RVA: 0x0069FC50 File Offset: 0x0069DE50
		public static Offset<IFlipperTip> Pack(FlatBufferBuilder builder, IFlipperTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return IFlipperTip.CreateIFlipperTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04011D2D RID: 73005
		private Table __p;
	}
}
