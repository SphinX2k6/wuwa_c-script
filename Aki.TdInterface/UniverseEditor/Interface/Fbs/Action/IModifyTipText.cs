using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD6 RID: 27350
	public struct IModifyTipText : IFlatbufferObject
	{
		// Token: 0x1700CAE7 RID: 51943
		// (get) Token: 0x0602FEFE RID: 196350 RVA: 0x00684FE4 File Offset: 0x006831E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FEFF RID: 196351 RVA: 0x00684FF1 File Offset: 0x006831F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF00 RID: 196352 RVA: 0x00684FF8 File Offset: 0x006831F8
		public static IModifyTipText GetRootAsIModifyTipText(ByteBuffer _bb)
		{
			return IModifyTipText.GetRootAsIModifyTipText(_bb, default(IModifyTipText));
		}

		// Token: 0x0602FF01 RID: 196353 RVA: 0x00685014 File Offset: 0x00683214
		public static IModifyTipText GetRootAsIModifyTipText(ByteBuffer _bb, IModifyTipText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF02 RID: 196354 RVA: 0x00685031 File Offset: 0x00683231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF03 RID: 196355 RVA: 0x00685040 File Offset: 0x00683240
		public IModifyTipText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAE8 RID: 51944
		// (get) Token: 0x0602FF04 RID: 196356 RVA: 0x00685050 File Offset: 0x00683250
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

		// Token: 0x1700CAE9 RID: 51945
		// (get) Token: 0x0602FF05 RID: 196357 RVA: 0x0068508C File Offset: 0x0068328C
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

		// Token: 0x1700CAEA RID: 51946
		// (get) Token: 0x0602FF06 RID: 196358 RVA: 0x006850CC File Offset: 0x006832CC
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

		// Token: 0x0602FF07 RID: 196359 RVA: 0x00685103 File Offset: 0x00683303
		public Span<byte> GetTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602FF08 RID: 196360 RVA: 0x00685112 File Offset: 0x00683312
		public byte[] GetTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CAEB RID: 51947
		// (get) Token: 0x0602FF09 RID: 196361 RVA: 0x00685120 File Offset: 0x00683320
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

		// Token: 0x0602FF0A RID: 196362 RVA: 0x0068515D File Offset: 0x0068335D
		public static Offset<IModifyTipText> CreateIModifyTipText(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, StringOffset TipTextOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IModifyTipText.AddTipText(builder, TipTextOffset);
			IModifyTipText.AddDelayTime(builder, DelayTime);
			IModifyTipText.AddNullMask(builder, NullMask);
			IModifyTipText.AddType(builder, Type);
			return IModifyTipText.EndIModifyTipText(builder);
		}

		// Token: 0x0602FF0B RID: 196363 RVA: 0x00685189 File Offset: 0x00683389
		public static void StartIModifyTipText(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FF0C RID: 196364 RVA: 0x00685192 File Offset: 0x00683392
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF0D RID: 196365 RVA: 0x0068519D File Offset: 0x0068339D
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602FF0E RID: 196366 RVA: 0x006851B0 File Offset: 0x006833B0
		public static void AddTipText(FlatBufferBuilder builder, StringOffset tipTextOffset)
		{
			builder.AddOffset(2, tipTextOffset.Value, 0);
		}

		// Token: 0x0602FF0F RID: 196367 RVA: 0x006851C0 File Offset: 0x006833C0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FF10 RID: 196368 RVA: 0x006851CB File Offset: 0x006833CB
		public static Offset<IModifyTipText> EndIModifyTipText(FlatBufferBuilder builder)
		{
			return new Offset<IModifyTipText>(builder.EndTable());
		}

		// Token: 0x0602FF11 RID: 196369 RVA: 0x006851D8 File Offset: 0x006833D8
		public IModifyTipTextT UnPack()
		{
			IModifyTipTextT modifyTipTextT = new IModifyTipTextT();
			this.UnPackTo(modifyTipTextT);
			return modifyTipTextT;
		}

		// Token: 0x0602FF12 RID: 196370 RVA: 0x006851F3 File Offset: 0x006833F3
		public void UnPackTo(IModifyTipTextT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.TipText = this.TipText;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FF13 RID: 196371 RVA: 0x00685228 File Offset: 0x00683428
		public static Offset<IModifyTipText> Pack(FlatBufferBuilder builder, IModifyTipTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyTipText>);
			}
			StringOffset tipTextOffset = (_o.TipText == null) ? default(StringOffset) : builder.CreateString(_o.TipText);
			return IModifyTipText.CreateIModifyTipText(builder, _o.Type, _o.DelayTime, tipTextOffset, _o.NullMask);
		}

		// Token: 0x04011324 RID: 70436
		private Table __p;
	}
}
