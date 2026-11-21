using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720D RID: 29197
	public struct IModifyTipText : IFlatbufferObject
	{
		// Token: 0x1700D5B2 RID: 54706
		// (get) Token: 0x06032CCA RID: 208074 RVA: 0x006DC580 File Offset: 0x006DA780
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CCB RID: 208075 RVA: 0x006DC58D File Offset: 0x006DA78D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CCC RID: 208076 RVA: 0x006DC594 File Offset: 0x006DA794
		public static IModifyTipText GetRootAsIModifyTipText(ByteBuffer _bb)
		{
			return IModifyTipText.GetRootAsIModifyTipText(_bb, default(IModifyTipText));
		}

		// Token: 0x06032CCD RID: 208077 RVA: 0x006DC5B0 File Offset: 0x006DA7B0
		public static IModifyTipText GetRootAsIModifyTipText(ByteBuffer _bb, IModifyTipText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CCE RID: 208078 RVA: 0x006DC5CD File Offset: 0x006DA7CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CCF RID: 208079 RVA: 0x006DC5DC File Offset: 0x006DA7DC
		public IModifyTipText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5B3 RID: 54707
		// (get) Token: 0x06032CD0 RID: 208080 RVA: 0x006DC5EC File Offset: 0x006DA7EC
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5B4 RID: 54708
		// (get) Token: 0x06032CD1 RID: 208081 RVA: 0x006DC628 File Offset: 0x006DA828
		public float DelayTime
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

		// Token: 0x1700D5B5 RID: 54709
		// (get) Token: 0x06032CD2 RID: 208082 RVA: 0x006DC668 File Offset: 0x006DA868
		public string TipText
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

		// Token: 0x06032CD3 RID: 208083 RVA: 0x006DC69F File Offset: 0x006DA89F
		public Span<byte> GetTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06032CD4 RID: 208084 RVA: 0x006DC6AE File Offset: 0x006DA8AE
		public byte[] GetTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D5B6 RID: 54710
		// (get) Token: 0x06032CD5 RID: 208085 RVA: 0x006DC6BC File Offset: 0x006DA8BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CD6 RID: 208086 RVA: 0x006DC6F9 File Offset: 0x006DA8F9
		public static Offset<IModifyTipText> CreateIModifyTipText(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, StringOffset TipTextOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IModifyTipText.AddTipText(builder, TipTextOffset);
			IModifyTipText.AddDelayTime(builder, DelayTime);
			IModifyTipText.AddNullMask(builder, NullMask);
			IModifyTipText.AddType(builder, Type);
			return IModifyTipText.EndIModifyTipText(builder);
		}

		// Token: 0x06032CD7 RID: 208087 RVA: 0x006DC725 File Offset: 0x006DA925
		public static void StartIModifyTipText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032CD8 RID: 208088 RVA: 0x006DC72E File Offset: 0x006DA92E
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032CD9 RID: 208089 RVA: 0x006DC739 File Offset: 0x006DA939
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x06032CDA RID: 208090 RVA: 0x006DC74C File Offset: 0x006DA94C
		public static void AddTipText(FlatBufferBuilder builder, StringOffset tipTextOffset)
		{
			builder.AddOffset(2, tipTextOffset.Value, 0);
		}

		// Token: 0x06032CDB RID: 208091 RVA: 0x006DC75C File Offset: 0x006DA95C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032CDC RID: 208092 RVA: 0x006DC767 File Offset: 0x006DA967
		public static Offset<IModifyTipText> EndIModifyTipText(FlatBufferBuilder builder)
		{
			return new Offset<IModifyTipText>(builder.EndTable());
		}

		// Token: 0x06032CDD RID: 208093 RVA: 0x006DC774 File Offset: 0x006DA974
		public IModifyTipTextT UnPack()
		{
			IModifyTipTextT modifyTipTextT = new IModifyTipTextT();
			this.UnPackTo(modifyTipTextT);
			return modifyTipTextT;
		}

		// Token: 0x06032CDE RID: 208094 RVA: 0x006DC78F File Offset: 0x006DA98F
		public void UnPackTo(IModifyTipTextT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.TipText = this.TipText;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032CDF RID: 208095 RVA: 0x006DC7C4 File Offset: 0x006DA9C4
		public static Offset<IModifyTipText> Pack(FlatBufferBuilder builder, IModifyTipTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyTipText>);
			}
			StringOffset tipTextOffset = (_o.TipText == null) ? default(StringOffset) : builder.CreateString(_o.TipText);
			return IModifyTipText.CreateIModifyTipText(builder, _o.Type, _o.DelayTime, tipTextOffset, _o.NullMask);
		}

		// Token: 0x04012235 RID: 74293
		private Table __p;
	}
}
