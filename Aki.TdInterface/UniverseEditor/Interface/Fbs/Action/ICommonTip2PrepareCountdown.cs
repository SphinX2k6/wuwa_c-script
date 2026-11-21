using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEE RID: 27374
	public struct ICommonTip2PrepareCountdown : IFlatbufferObject
	{
		// Token: 0x1700C908 RID: 51464
		// (get) Token: 0x0602F0E4 RID: 192740 RVA: 0x0066B77F File Offset: 0x0066997F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0E5 RID: 192741 RVA: 0x0066B78C File Offset: 0x0066998C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0E6 RID: 192742 RVA: 0x0066B794 File Offset: 0x00669994
		public static ICommonTip2PrepareCountdown GetRootAsICommonTip2PrepareCountdown(ByteBuffer _bb)
		{
			return ICommonTip2PrepareCountdown.GetRootAsICommonTip2PrepareCountdown(_bb, default(ICommonTip2PrepareCountdown));
		}

		// Token: 0x0602F0E7 RID: 192743 RVA: 0x0066B7B0 File Offset: 0x006699B0
		public static ICommonTip2PrepareCountdown GetRootAsICommonTip2PrepareCountdown(ByteBuffer _bb, ICommonTip2PrepareCountdown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0E8 RID: 192744 RVA: 0x0066B7CD File Offset: 0x006699CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0E9 RID: 192745 RVA: 0x0066B7DC File Offset: 0x006699DC
		public ICommonTip2PrepareCountdown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C909 RID: 51465
		// (get) Token: 0x0602F0EA RID: 192746 RVA: 0x0066B7EC File Offset: 0x006699EC
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

		// Token: 0x1700C90A RID: 51466
		// (get) Token: 0x0602F0EB RID: 192747 RVA: 0x0066B828 File Offset: 0x00669A28
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

		// Token: 0x1700C90B RID: 51467
		// (get) Token: 0x0602F0EC RID: 192748 RVA: 0x0066B864 File Offset: 0x00669A64
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

		// Token: 0x0602F0ED RID: 192749 RVA: 0x0066B89B File Offset: 0x00669A9B
		public Span<byte> GetTidCountDownTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F0EE RID: 192750 RVA: 0x0066B8AA File Offset: 0x00669AAA
		public byte[] GetTidCountDownTxtArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C90C RID: 51468
		// (get) Token: 0x0602F0EF RID: 192751 RVA: 0x0066B8B8 File Offset: 0x00669AB8
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

		// Token: 0x1700C90D RID: 51469
		// (get) Token: 0x0602F0F0 RID: 192752 RVA: 0x0066B8F8 File Offset: 0x00669AF8
		public bool IsBlockPlayer
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C90E RID: 51470
		// (get) Token: 0x0602F0F1 RID: 192753 RVA: 0x0066B938 File Offset: 0x00669B38
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

		// Token: 0x0602F0F2 RID: 192754 RVA: 0x0066B975 File Offset: 0x00669B75
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

		// Token: 0x0602F0F3 RID: 192755 RVA: 0x0066B9B1 File Offset: 0x00669BB1
		public static void StartICommonTip2PrepareCountdown(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602F0F4 RID: 192756 RVA: 0x0066B9BA File Offset: 0x00669BBA
		public static void AddType(FlatBufferBuilder builder, ECommonTip2Type type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F0F5 RID: 192757 RVA: 0x0066B9C5 File Offset: 0x00669BC5
		public static void AddCountDownNum(FlatBufferBuilder builder, int countDownNum)
		{
			builder.AddInt(1, countDownNum, 0);
		}

		// Token: 0x0602F0F6 RID: 192758 RVA: 0x0066B9D0 File Offset: 0x00669BD0
		public static void AddTidCountDownTxt(FlatBufferBuilder builder, StringOffset tidCountDownTxtOffset)
		{
			builder.AddOffset(2, tidCountDownTxtOffset.Value, 0);
		}

		// Token: 0x0602F0F7 RID: 192759 RVA: 0x0066B9E0 File Offset: 0x00669BE0
		public static void AddUiStyle(FlatBufferBuilder builder, ECountDownUiStyle uiStyle)
		{
			builder.AddByte(3, (byte)uiStyle, 0);
		}

		// Token: 0x0602F0F8 RID: 192760 RVA: 0x0066B9EB File Offset: 0x00669BEB
		public static void AddIsBlockPlayer(FlatBufferBuilder builder, bool isBlockPlayer)
		{
			builder.AddBool(4, isBlockPlayer, false);
		}

		// Token: 0x0602F0F9 RID: 192761 RVA: 0x0066B9F6 File Offset: 0x00669BF6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602F0FA RID: 192762 RVA: 0x0066BA01 File Offset: 0x00669C01
		public static Offset<ICommonTip2PrepareCountdown> EndICommonTip2PrepareCountdown(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2PrepareCountdown>(builder.EndTable());
		}

		// Token: 0x0602F0FB RID: 192763 RVA: 0x0066BA10 File Offset: 0x00669C10
		public ICommonTip2PrepareCountdownT UnPack()
		{
			ICommonTip2PrepareCountdownT commonTip2PrepareCountdownT = new ICommonTip2PrepareCountdownT();
			this.UnPackTo(commonTip2PrepareCountdownT);
			return commonTip2PrepareCountdownT;
		}

		// Token: 0x0602F0FC RID: 192764 RVA: 0x0066BA2C File Offset: 0x00669C2C
		public void UnPackTo(ICommonTip2PrepareCountdownT _o)
		{
			_o.Type = this.Type;
			_o.CountDownNum = this.CountDownNum;
			_o.TidCountDownTxt = this.TidCountDownTxt;
			_o.UiStyle = this.UiStyle;
			_o.IsBlockPlayer = this.IsBlockPlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F0FD RID: 192765 RVA: 0x0066BA84 File Offset: 0x00669C84
		public static Offset<ICommonTip2PrepareCountdown> Pack(FlatBufferBuilder builder, ICommonTip2PrepareCountdownT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2PrepareCountdown>);
			}
			StringOffset tidCountDownTxtOffset = (_o.TidCountDownTxt == null) ? default(StringOffset) : builder.CreateString(_o.TidCountDownTxt);
			return ICommonTip2PrepareCountdown.CreateICommonTip2PrepareCountdown(builder, _o.Type, _o.CountDownNum, tidCountDownTxtOffset, _o.UiStyle, _o.IsBlockPlayer, _o.NullMask);
		}

		// Token: 0x0401189A RID: 71834
		private Table __p;
	}
}
