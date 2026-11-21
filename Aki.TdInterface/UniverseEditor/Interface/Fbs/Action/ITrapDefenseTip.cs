using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C5F RID: 31839
	public struct ITrapDefenseTip : IFlatbufferObject
	{
		// Token: 0x1700EE50 RID: 61008
		// (get) Token: 0x06039633 RID: 235059 RVA: 0x007BF58A File Offset: 0x007BD78A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039634 RID: 235060 RVA: 0x007BF597 File Offset: 0x007BD797
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039635 RID: 235061 RVA: 0x007BF5A0 File Offset: 0x007BD7A0
		public static ITrapDefenseTip GetRootAsITrapDefenseTip(ByteBuffer _bb)
		{
			return ITrapDefenseTip.GetRootAsITrapDefenseTip(_bb, default(ITrapDefenseTip));
		}

		// Token: 0x06039636 RID: 235062 RVA: 0x007BF5BC File Offset: 0x007BD7BC
		public static ITrapDefenseTip GetRootAsITrapDefenseTip(ByteBuffer _bb, ITrapDefenseTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039637 RID: 235063 RVA: 0x007BF5D9 File Offset: 0x007BD7D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039638 RID: 235064 RVA: 0x007BF5E8 File Offset: 0x007BD7E8
		public ITrapDefenseTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE51 RID: 61009
		// (get) Token: 0x06039639 RID: 235065 RVA: 0x007BF5F8 File Offset: 0x007BD7F8
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

		// Token: 0x1700EE52 RID: 61010
		// (get) Token: 0x0603963A RID: 235066 RVA: 0x007BF634 File Offset: 0x007BD834
		public string MainText
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

		// Token: 0x0603963B RID: 235067 RVA: 0x007BF66B File Offset: 0x007BD86B
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603963C RID: 235068 RVA: 0x007BF67A File Offset: 0x007BD87A
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700EE53 RID: 61011
		// (get) Token: 0x0603963D RID: 235069 RVA: 0x007BF688 File Offset: 0x007BD888
		public ETrapDefenseTipType TipType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETrapDefenseTipType.OpenNewAreaTip;
				}
				return (ETrapDefenseTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603963E RID: 235070 RVA: 0x007BF6C4 File Offset: 0x007BD8C4
		public static Offset<ITrapDefenseTip> CreateITrapDefenseTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset), ETrapDefenseTipType TipType = ETrapDefenseTipType.OpenNewAreaTip)
		{
			builder.StartTable(3);
			ITrapDefenseTip.AddMainText(builder, MainTextOffset);
			ITrapDefenseTip.AddTipType(builder, TipType);
			ITrapDefenseTip.AddType(builder, Type);
			return ITrapDefenseTip.EndITrapDefenseTip(builder);
		}

		// Token: 0x0603963F RID: 235071 RVA: 0x007BF6E8 File Offset: 0x007BD8E8
		public static void StartITrapDefenseTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039640 RID: 235072 RVA: 0x007BF6F1 File Offset: 0x007BD8F1
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039641 RID: 235073 RVA: 0x007BF6FC File Offset: 0x007BD8FC
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x06039642 RID: 235074 RVA: 0x007BF70C File Offset: 0x007BD90C
		public static void AddTipType(FlatBufferBuilder builder, ETrapDefenseTipType tipType)
		{
			builder.AddByte(2, (byte)tipType, 0);
		}

		// Token: 0x06039643 RID: 235075 RVA: 0x007BF717 File Offset: 0x007BD917
		public static Offset<ITrapDefenseTip> EndITrapDefenseTip(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseTip>(builder.EndTable());
		}

		// Token: 0x06039644 RID: 235076 RVA: 0x007BF724 File Offset: 0x007BD924
		public ITrapDefenseTipT UnPack()
		{
			ITrapDefenseTipT trapDefenseTipT = new ITrapDefenseTipT();
			this.UnPackTo(trapDefenseTipT);
			return trapDefenseTipT;
		}

		// Token: 0x06039645 RID: 235077 RVA: 0x007BF73F File Offset: 0x007BD93F
		public void UnPackTo(ITrapDefenseTipT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.TipType = this.TipType;
		}

		// Token: 0x06039646 RID: 235078 RVA: 0x007BF768 File Offset: 0x007BD968
		public static Offset<ITrapDefenseTip> Pack(FlatBufferBuilder builder, ITrapDefenseTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseTip>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			return ITrapDefenseTip.CreateITrapDefenseTip(builder, _o.Type, mainTextOffset, _o.TipType);
		}

		// Token: 0x0401331E RID: 78622
		private Table __p;
	}
}
