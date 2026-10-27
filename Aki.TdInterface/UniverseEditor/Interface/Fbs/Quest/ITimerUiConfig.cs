using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DE RID: 16862
	public struct ITimerUiConfig : IFlatbufferObject
	{
		// Token: 0x1700779B RID: 30619
		// (get) Token: 0x06018DA8 RID: 101800 RVA: 0x00393903 File Offset: 0x00391B03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018DA9 RID: 101801 RVA: 0x00393910 File Offset: 0x00391B10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018DAA RID: 101802 RVA: 0x00393918 File Offset: 0x00391B18
		public static ITimerUiConfig GetRootAsITimerUiConfig(ByteBuffer _bb)
		{
			return ITimerUiConfig.GetRootAsITimerUiConfig(_bb, default(ITimerUiConfig));
		}

		// Token: 0x06018DAB RID: 101803 RVA: 0x00393934 File Offset: 0x00391B34
		public static ITimerUiConfig GetRootAsITimerUiConfig(ByteBuffer _bb, ITimerUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018DAC RID: 101804 RVA: 0x00393951 File Offset: 0x00391B51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018DAD RID: 101805 RVA: 0x00393960 File Offset: 0x00391B60
		public ITimerUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700779C RID: 30620
		// (get) Token: 0x06018DAE RID: 101806 RVA: 0x00393970 File Offset: 0x00391B70
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

		// Token: 0x1700779D RID: 30621
		// (get) Token: 0x06018DAF RID: 101807 RVA: 0x003939AC File Offset: 0x00391BAC
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

		// Token: 0x06018DB0 RID: 101808 RVA: 0x003939E3 File Offset: 0x00391BE3
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018DB1 RID: 101809 RVA: 0x003939F2 File Offset: 0x00391BF2
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018DB2 RID: 101810 RVA: 0x00393A00 File Offset: 0x00391C00
		public static Offset<ITimerUiConfig> CreateITimerUiConfig(FlatBufferBuilder builder, ETimerUiType UiType = ETimerUiType.Default, StringOffset TidTitleOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITimerUiConfig.AddTidTitle(builder, TidTitleOffset);
			ITimerUiConfig.AddUiType(builder, UiType);
			return ITimerUiConfig.EndITimerUiConfig(builder);
		}

		// Token: 0x06018DB3 RID: 101811 RVA: 0x00393A1D File Offset: 0x00391C1D
		public static void StartITimerUiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018DB4 RID: 101812 RVA: 0x00393A26 File Offset: 0x00391C26
		public static void AddUiType(FlatBufferBuilder builder, ETimerUiType uiType)
		{
			builder.AddByte(0, (byte)uiType, 0);
		}

		// Token: 0x06018DB5 RID: 101813 RVA: 0x00393A31 File Offset: 0x00391C31
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(1, tidTitleOffset.Value, 0);
		}

		// Token: 0x06018DB6 RID: 101814 RVA: 0x00393A41 File Offset: 0x00391C41
		public static Offset<ITimerUiConfig> EndITimerUiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimerUiConfig>(builder.EndTable());
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x00393A50 File Offset: 0x00391C50
		public ITimerUiConfigT UnPack()
		{
			ITimerUiConfigT timerUiConfigT = new ITimerUiConfigT();
			this.UnPackTo(timerUiConfigT);
			return timerUiConfigT;
		}

		// Token: 0x06018DB8 RID: 101816 RVA: 0x00393A6B File Offset: 0x00391C6B
		public void UnPackTo(ITimerUiConfigT _o)
		{
			_o.UiType = this.UiType;
			_o.TidTitle = this.TidTitle;
		}

		// Token: 0x06018DB9 RID: 101817 RVA: 0x00393A88 File Offset: 0x00391C88
		public static Offset<ITimerUiConfig> Pack(FlatBufferBuilder builder, ITimerUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimerUiConfig>);
			}
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			return ITimerUiConfig.CreateITimerUiConfig(builder, _o.UiType, tidTitleOffset);
		}

		// Token: 0x0400BE30 RID: 48688
		private Table __p;
	}
}
