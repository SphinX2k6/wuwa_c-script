using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004637 RID: 17975
	public struct ITimerUiConfig : IFlatbufferObject
	{
		// Token: 0x17007DC7 RID: 32199
		// (get) Token: 0x0601A4FE RID: 107774 RVA: 0x003BED57 File Offset: 0x003BCF57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A4FF RID: 107775 RVA: 0x003BED64 File Offset: 0x003BCF64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A500 RID: 107776 RVA: 0x003BED6C File Offset: 0x003BCF6C
		public static ITimerUiConfig GetRootAsITimerUiConfig(ByteBuffer _bb)
		{
			return ITimerUiConfig.GetRootAsITimerUiConfig(_bb, default(ITimerUiConfig));
		}

		// Token: 0x0601A501 RID: 107777 RVA: 0x003BED88 File Offset: 0x003BCF88
		public static ITimerUiConfig GetRootAsITimerUiConfig(ByteBuffer _bb, ITimerUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A502 RID: 107778 RVA: 0x003BEDA5 File Offset: 0x003BCFA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A503 RID: 107779 RVA: 0x003BEDB4 File Offset: 0x003BCFB4
		public ITimerUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DC8 RID: 32200
		// (get) Token: 0x0601A504 RID: 107780 RVA: 0x003BEDC4 File Offset: 0x003BCFC4
		public ETimerUiType UiType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimerUiType.Default;
				}
				return (ETimerUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007DC9 RID: 32201
		// (get) Token: 0x0601A505 RID: 107781 RVA: 0x003BEE00 File Offset: 0x003BD000
		public string TidTitle
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

		// Token: 0x0601A506 RID: 107782 RVA: 0x003BEE37 File Offset: 0x003BD037
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A507 RID: 107783 RVA: 0x003BEE46 File Offset: 0x003BD046
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A508 RID: 107784 RVA: 0x003BEE54 File Offset: 0x003BD054
		public static Offset<ITimerUiConfig> CreateITimerUiConfig(FlatBufferBuilder builder, ETimerUiType UiType = ETimerUiType.Default, StringOffset TidTitleOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITimerUiConfig.AddTidTitle(builder, TidTitleOffset);
			ITimerUiConfig.AddUiType(builder, UiType);
			return ITimerUiConfig.EndITimerUiConfig(builder);
		}

		// Token: 0x0601A509 RID: 107785 RVA: 0x003BEE71 File Offset: 0x003BD071
		public static void StartITimerUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A50A RID: 107786 RVA: 0x003BEE7A File Offset: 0x003BD07A
		public static void AddUiType(FlatBufferBuilder builder, ETimerUiType uiType)
		{
			builder.AddByte(0, (byte)uiType, 0);
		}

		// Token: 0x0601A50B RID: 107787 RVA: 0x003BEE85 File Offset: 0x003BD085
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(1, tidTitleOffset.Value, 0);
		}

		// Token: 0x0601A50C RID: 107788 RVA: 0x003BEE95 File Offset: 0x003BD095
		public static Offset<ITimerUiConfig> EndITimerUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimerUiConfig>(builder.EndTable());
		}

		// Token: 0x0601A50D RID: 107789 RVA: 0x003BEEA4 File Offset: 0x003BD0A4
		public ITimerUiConfigT UnPack()
		{
			ITimerUiConfigT timerUiConfigT = new ITimerUiConfigT();
			this.UnPackTo(timerUiConfigT);
			return timerUiConfigT;
		}

		// Token: 0x0601A50E RID: 107790 RVA: 0x003BEEBF File Offset: 0x003BD0BF
		public void UnPackTo(ITimerUiConfigT _o)
		{
			_o.UiType = this.UiType;
			_o.TidTitle = this.TidTitle;
		}

		// Token: 0x0601A50F RID: 107791 RVA: 0x003BEEDC File Offset: 0x003BD0DC
		public static Offset<ITimerUiConfig> Pack(FlatBufferBuilder builder, ITimerUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimerUiConfig>);
			}
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			return ITimerUiConfig.CreateITimerUiConfig(builder, _o.UiType, tidTitleOffset);
		}

		// Token: 0x0400C83A RID: 51258
		private Table __p;
	}
}
