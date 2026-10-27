using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E3 RID: 26595
	public struct IFlipperTip : IFlatbufferObject
	{
		// Token: 0x1700C560 RID: 50528
		// (get) Token: 0x0602E4BF RID: 189631 RVA: 0x0065230D File Offset: 0x0065050D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4C0 RID: 189632 RVA: 0x0065231A File Offset: 0x0065051A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4C1 RID: 189633 RVA: 0x00652324 File Offset: 0x00650524
		public static IFlipperTip GetRootAsIFlipperTip(ByteBuffer _bb)
		{
			return IFlipperTip.GetRootAsIFlipperTip(_bb, default(IFlipperTip));
		}

		// Token: 0x0602E4C2 RID: 189634 RVA: 0x00652340 File Offset: 0x00650540
		public static IFlipperTip GetRootAsIFlipperTip(ByteBuffer _bb, IFlipperTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4C3 RID: 189635 RVA: 0x0065235D File Offset: 0x0065055D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4C4 RID: 189636 RVA: 0x0065236C File Offset: 0x0065056C
		public IFlipperTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C561 RID: 50529
		// (get) Token: 0x0602E4C5 RID: 189637 RVA: 0x0065237C File Offset: 0x0065057C
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

		// Token: 0x1700C562 RID: 50530
		// (get) Token: 0x0602E4C6 RID: 189638 RVA: 0x006523B8 File Offset: 0x006505B8
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

		// Token: 0x0602E4C7 RID: 189639 RVA: 0x006523EF File Offset: 0x006505EF
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E4C8 RID: 189640 RVA: 0x006523FE File Offset: 0x006505FE
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C563 RID: 50531
		// (get) Token: 0x0602E4C9 RID: 189641 RVA: 0x0065240C File Offset: 0x0065060C
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

		// Token: 0x0602E4CA RID: 189642 RVA: 0x00652443 File Offset: 0x00650643
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E4CB RID: 189643 RVA: 0x00652452 File Offset: 0x00650652
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602E4CC RID: 189644 RVA: 0x00652460 File Offset: 0x00650660
		public static Offset<IFlipperTip> CreateIFlipperTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFlipperTip.AddTidSubText(builder, TidSubTextOffset);
			IFlipperTip.AddTidMainText(builder, TidMainTextOffset);
			IFlipperTip.AddType(builder, Type);
			return IFlipperTip.EndIFlipperTip(builder);
		}

		// Token: 0x0602E4CD RID: 189645 RVA: 0x00652484 File Offset: 0x00650684
		public static void StartIFlipperTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E4CE RID: 189646 RVA: 0x0065248D File Offset: 0x0065068D
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E4CF RID: 189647 RVA: 0x00652498 File Offset: 0x00650698
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602E4D0 RID: 189648 RVA: 0x006524A8 File Offset: 0x006506A8
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602E4D1 RID: 189649 RVA: 0x006524B8 File Offset: 0x006506B8
		public static Offset<IFlipperTip> EndIFlipperTip(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperTip>(builder.EndTable());
		}

		// Token: 0x0602E4D2 RID: 189650 RVA: 0x006524C8 File Offset: 0x006506C8
		public IFlipperTipT UnPack()
		{
			IFlipperTipT flipperTipT = new IFlipperTipT();
			this.UnPackTo(flipperTipT);
			return flipperTipT;
		}

		// Token: 0x0602E4D3 RID: 189651 RVA: 0x006524E3 File Offset: 0x006506E3
		public void UnPackTo(IFlipperTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602E4D4 RID: 189652 RVA: 0x0065250C File Offset: 0x0065070C
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

		// Token: 0x04010EFB RID: 69371
		private Table __p;
	}
}
