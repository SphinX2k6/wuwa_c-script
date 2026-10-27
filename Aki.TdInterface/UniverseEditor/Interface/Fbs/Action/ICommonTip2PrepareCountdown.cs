using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006483 RID: 25731
	public struct ICommonTip2PrepareCountdown : IFlatbufferObject
	{
		// Token: 0x1700BF7B RID: 49019
		// (get) Token: 0x0602C96A RID: 182634 RVA: 0x0061FBAB File Offset: 0x0061DDAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C96B RID: 182635 RVA: 0x0061FBB8 File Offset: 0x0061DDB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C96C RID: 182636 RVA: 0x0061FBC0 File Offset: 0x0061DDC0
		public static ICommonTip2PrepareCountdown GetRootAsICommonTip2PrepareCountdown(ByteBuffer _bb)
		{
			return ICommonTip2PrepareCountdown.GetRootAsICommonTip2PrepareCountdown(_bb, default(ICommonTip2PrepareCountdown));
		}

		// Token: 0x0602C96D RID: 182637 RVA: 0x0061FBDC File Offset: 0x0061DDDC
		public static ICommonTip2PrepareCountdown GetRootAsICommonTip2PrepareCountdown(ByteBuffer _bb, ICommonTip2PrepareCountdown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C96E RID: 182638 RVA: 0x0061FBF9 File Offset: 0x0061DDF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C96F RID: 182639 RVA: 0x0061FC08 File Offset: 0x0061DE08
		public ICommonTip2PrepareCountdown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF7C RID: 49020
		// (get) Token: 0x0602C970 RID: 182640 RVA: 0x0061FC18 File Offset: 0x0061DE18
		public ECommonTip2Type Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return (ECommonTip2Type)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF7D RID: 49021
		// (get) Token: 0x0602C971 RID: 182641 RVA: 0x0061FC54 File Offset: 0x0061DE54
		public int CountDownNum
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF7E RID: 49022
		// (get) Token: 0x0602C972 RID: 182642 RVA: 0x0061FC90 File Offset: 0x0061DE90
		public string TidCountDownTxt
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

		// Token: 0x0602C973 RID: 182643 RVA: 0x0061FCC7 File Offset: 0x0061DEC7
		public Span<byte> GetTidCountDownTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C974 RID: 182644 RVA: 0x0061FCD6 File Offset: 0x0061DED6
		public byte[] GetTidCountDownTxtArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BF7F RID: 49023
		// (get) Token: 0x0602C975 RID: 182645 RVA: 0x0061FCE4 File Offset: 0x0061DEE4
		public ECountDownUiStyle UiStyle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECountDownUiStyle.Common;
				}
				return (ECountDownUiStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF80 RID: 49024
		// (get) Token: 0x0602C976 RID: 182646 RVA: 0x0061FD24 File Offset: 0x0061DF24
		public bool IsBlockPlayer
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF81 RID: 49025
		// (get) Token: 0x0602C977 RID: 182647 RVA: 0x0061FD64 File Offset: 0x0061DF64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C978 RID: 182648 RVA: 0x0061FDA1 File Offset: 0x0061DFA1
		public static Offset<ICommonTip2PrepareCountdown> CreateICommonTip2PrepareCountdown(FlatBufferBuilder builder, ECommonTip2Type Type = ECommonTip2Type.PrepareCountdown, int CountDownNum = 0, StringOffset TidCountDownTxtOffset = default(StringOffset), ECountDownUiStyle UiStyle = ECountDownUiStyle.Common, bool IsBlockPlayer = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICommonTip2PrepareCountdown.AddTidCountDownTxt(builder, TidCountDownTxtOffset);
			ICommonTip2PrepareCountdown.AddCountDownNum(builder, CountDownNum);
			ICommonTip2PrepareCountdown.AddNullMask(builder, NullMask);
			ICommonTip2PrepareCountdown.AddIsBlockPlayer(builder, IsBlockPlayer);
			ICommonTip2PrepareCountdown.AddUiStyle(builder, UiStyle);
			ICommonTip2PrepareCountdown.AddType(builder, Type);
			return ICommonTip2PrepareCountdown.EndICommonTip2PrepareCountdown(builder);
		}

		// Token: 0x0602C979 RID: 182649 RVA: 0x0061FDDD File Offset: 0x0061DFDD
		public static void StartICommonTip2PrepareCountdown(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602C97A RID: 182650 RVA: 0x0061FDE6 File Offset: 0x0061DFE6
		public static void AddType(FlatBufferBuilder builder, ECommonTip2Type type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C97B RID: 182651 RVA: 0x0061FDF1 File Offset: 0x0061DFF1
		public static void AddCountDownNum(FlatBufferBuilder builder, int countDownNum)
		{
			builder.AddInt(1, countDownNum, 0);
		}

		// Token: 0x0602C97C RID: 182652 RVA: 0x0061FDFC File Offset: 0x0061DFFC
		public static void AddTidCountDownTxt(FlatBufferBuilder builder, StringOffset tidCountDownTxtOffset)
		{
			builder.AddOffset(2, tidCountDownTxtOffset.Value, 0);
		}

		// Token: 0x0602C97D RID: 182653 RVA: 0x0061FE0C File Offset: 0x0061E00C
		public static void AddUiStyle(FlatBufferBuilder builder, ECountDownUiStyle uiStyle)
		{
			builder.AddByte(3, (byte)uiStyle, 0);
		}

		// Token: 0x0602C97E RID: 182654 RVA: 0x0061FE17 File Offset: 0x0061E017
		public static void AddIsBlockPlayer(FlatBufferBuilder builder, bool isBlockPlayer)
		{
			builder.AddBool(4, isBlockPlayer, false);
		}

		// Token: 0x0602C97F RID: 182655 RVA: 0x0061FE22 File Offset: 0x0061E022
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602C980 RID: 182656 RVA: 0x0061FE2D File Offset: 0x0061E02D
		public static Offset<ICommonTip2PrepareCountdown> EndICommonTip2PrepareCountdown(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2PrepareCountdown>(builder.EndTable());
		}

		// Token: 0x0602C981 RID: 182657 RVA: 0x0061FE3C File Offset: 0x0061E03C
		public ICommonTip2PrepareCountdownT UnPack()
		{
			ICommonTip2PrepareCountdownT commonTip2PrepareCountdownT = new ICommonTip2PrepareCountdownT();
			this.UnPackTo(commonTip2PrepareCountdownT);
			return commonTip2PrepareCountdownT;
		}

		// Token: 0x0602C982 RID: 182658 RVA: 0x0061FE58 File Offset: 0x0061E058
		public void UnPackTo(ICommonTip2PrepareCountdownT _o)
		{
			_o.Type = this.Type;
			_o.CountDownNum = this.CountDownNum;
			_o.TidCountDownTxt = this.TidCountDownTxt;
			_o.UiStyle = this.UiStyle;
			_o.IsBlockPlayer = this.IsBlockPlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C983 RID: 182659 RVA: 0x0061FEB0 File Offset: 0x0061E0B0
		public static Offset<ICommonTip2PrepareCountdown> Pack(FlatBufferBuilder builder, ICommonTip2PrepareCountdownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2PrepareCountdown>);
			}
			StringOffset tidCountDownTxtOffset = (_o.TidCountDownTxt == null) ? default(StringOffset) : builder.CreateString(_o.TidCountDownTxt);
			return ICommonTip2PrepareCountdown.CreateICommonTip2PrepareCountdown(builder, _o.Type, _o.CountDownNum, tidCountDownTxtOffset, _o.UiStyle, _o.IsBlockPlayer, _o.NullMask);
		}

		// Token: 0x04010A89 RID: 68233
		private Table __p;
	}
}
