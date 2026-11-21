using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559B RID: 21915
	public struct ICountDownTextTip : IFlatbufferObject
	{
		// Token: 0x17009CED RID: 40173
		// (get) Token: 0x06022DAB RID: 142763 RVA: 0x004CD09F File Offset: 0x004CB29F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DAC RID: 142764 RVA: 0x004CD0AC File Offset: 0x004CB2AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x004CD0B4 File Offset: 0x004CB2B4
		public static ICountDownTextTip GetRootAsICountDownTextTip(ByteBuffer _bb)
		{
			return ICountDownTextTip.GetRootAsICountDownTextTip(_bb, default(ICountDownTextTip));
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x004CD0D0 File Offset: 0x004CB2D0
		public static ICountDownTextTip GetRootAsICountDownTextTip(ByteBuffer _bb, ICountDownTextTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x004CD0ED File Offset: 0x004CB2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x004CD0FC File Offset: 0x004CB2FC
		public ICountDownTextTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CEE RID: 40174
		// (get) Token: 0x06022DB1 RID: 142769 RVA: 0x004CD10C File Offset: 0x004CB30C
		public ETrampleTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrampleTipType.CountDownTextTip;
				}
				return (ETrampleTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CEF RID: 40175
		// (get) Token: 0x06022DB2 RID: 142770 RVA: 0x004CD148 File Offset: 0x004CB348
		public string TidCountDownTip
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

		// Token: 0x06022DB3 RID: 142771 RVA: 0x004CD17F File Offset: 0x004CB37F
		public Span<byte> GetTidCountDownTipBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022DB4 RID: 142772 RVA: 0x004CD18E File Offset: 0x004CB38E
		public byte[] GetTidCountDownTipArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022DB5 RID: 142773 RVA: 0x004CD19C File Offset: 0x004CB39C
		public static Offset<ICountDownTextTip> CreateICountDownTextTip(FlatBufferBuilder builder, ETrampleTipType Type = ETrampleTipType.CountDownTextTip, StringOffset TidCountDownTipOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICountDownTextTip.AddTidCountDownTip(builder, TidCountDownTipOffset);
			ICountDownTextTip.AddType(builder, Type);
			return ICountDownTextTip.EndICountDownTextTip(builder);
		}

		// Token: 0x06022DB6 RID: 142774 RVA: 0x004CD1B9 File Offset: 0x004CB3B9
		public static void StartICountDownTextTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022DB7 RID: 142775 RVA: 0x004CD1C2 File Offset: 0x004CB3C2
		public static void AddType(FlatBufferBuilder builder, ETrampleTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022DB8 RID: 142776 RVA: 0x004CD1CD File Offset: 0x004CB3CD
		public static void AddTidCountDownTip(FlatBufferBuilder builder, StringOffset tidCountDownTipOffset)
		{
			builder.AddOffset(1, tidCountDownTipOffset.Value, 0);
		}

		// Token: 0x06022DB9 RID: 142777 RVA: 0x004CD1DD File Offset: 0x004CB3DD
		public static Offset<ICountDownTextTip> EndICountDownTextTip(FlatBufferBuilder builder)
		{
			return new Offset<ICountDownTextTip>(builder.EndTable());
		}

		// Token: 0x06022DBA RID: 142778 RVA: 0x004CD1EC File Offset: 0x004CB3EC
		public ICountDownTextTipT UnPack()
		{
			ICountDownTextTipT countDownTextTipT = new ICountDownTextTipT();
			this.UnPackTo(countDownTextTipT);
			return countDownTextTipT;
		}

		// Token: 0x06022DBB RID: 142779 RVA: 0x004CD207 File Offset: 0x004CB407
		public void UnPackTo(ICountDownTextTipT _o)
		{
			_o.Type = this.Type;
			_o.TidCountDownTip = this.TidCountDownTip;
		}

		// Token: 0x06022DBC RID: 142780 RVA: 0x004CD224 File Offset: 0x004CB424
		public static Offset<ICountDownTextTip> Pack(FlatBufferBuilder builder, ICountDownTextTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICountDownTextTip>);
			}
			StringOffset tidCountDownTipOffset = (_o.TidCountDownTip == null) ? default(StringOffset) : builder.CreateString(_o.TidCountDownTip);
			return ICountDownTextTip.CreateICountDownTextTip(builder, _o.Type, tidCountDownTipOffset);
		}

		// Token: 0x0400EC25 RID: 60453
		private Table __p;
	}
}
