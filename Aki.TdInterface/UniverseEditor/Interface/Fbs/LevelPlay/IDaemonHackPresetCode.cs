using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048BD RID: 18621
	public struct IDaemonHackPresetCode : IFlatbufferObject
	{
		// Token: 0x1700818A RID: 33162
		// (get) Token: 0x0601B86F RID: 112751 RVA: 0x003E4BF8 File Offset: 0x003E2DF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B870 RID: 112752 RVA: 0x003E4C05 File Offset: 0x003E2E05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B871 RID: 112753 RVA: 0x003E4C0C File Offset: 0x003E2E0C
		public static IDaemonHackPresetCode GetRootAsIDaemonHackPresetCode(ByteBuffer _bb)
		{
			return IDaemonHackPresetCode.GetRootAsIDaemonHackPresetCode(_bb, default(IDaemonHackPresetCode));
		}

		// Token: 0x0601B872 RID: 112754 RVA: 0x003E4C28 File Offset: 0x003E2E28
		public static IDaemonHackPresetCode GetRootAsIDaemonHackPresetCode(ByteBuffer _bb, IDaemonHackPresetCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B873 RID: 112755 RVA: 0x003E4C45 File Offset: 0x003E2E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x003E4C54 File Offset: 0x003E2E54
		public IDaemonHackPresetCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700818B RID: 33163
		// (get) Token: 0x0601B875 RID: 112757 RVA: 0x003E4C64 File Offset: 0x003E2E64
		public string Code
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B876 RID: 112758 RVA: 0x003E4C9B File Offset: 0x003E2E9B
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B877 RID: 112759 RVA: 0x003E4CAA File Offset: 0x003E2EAA
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700818C RID: 33164
		// (get) Token: 0x0601B878 RID: 112760 RVA: 0x003E4CB8 File Offset: 0x003E2EB8
		public bool IsCorrect
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700818D RID: 33165
		// (get) Token: 0x0601B879 RID: 112761 RVA: 0x003E4CF8 File Offset: 0x003E2EF8
		public int Order
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700818E RID: 33166
		// (get) Token: 0x0601B87A RID: 112762 RVA: 0x003E4D34 File Offset: 0x003E2F34
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

		// Token: 0x0601B87B RID: 112763 RVA: 0x003E4D71 File Offset: 0x003E2F71
		public static Offset<IDaemonHackPresetCode> CreateIDaemonHackPresetCode(FlatBufferBuilder builder, StringOffset CodeOffset = default(StringOffset), bool IsCorrect = false, int Order = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDaemonHackPresetCode.AddOrder(builder, Order);
			IDaemonHackPresetCode.AddCode(builder, CodeOffset);
			IDaemonHackPresetCode.AddNullMask(builder, NullMask);
			IDaemonHackPresetCode.AddIsCorrect(builder, IsCorrect);
			return IDaemonHackPresetCode.EndIDaemonHackPresetCode(builder);
		}

		// Token: 0x0601B87C RID: 112764 RVA: 0x003E4D9D File Offset: 0x003E2F9D
		public static void StartIDaemonHackPresetCode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B87D RID: 112765 RVA: 0x003E4DA6 File Offset: 0x003E2FA6
		public static void AddCode(FlatBufferBuilder builder, StringOffset codeOffset)
		{
			builder.AddOffset(0, codeOffset.Value, 0);
		}

		// Token: 0x0601B87E RID: 112766 RVA: 0x003E4DB6 File Offset: 0x003E2FB6
		public static void AddIsCorrect(FlatBufferBuilder builder, bool isCorrect)
		{
			builder.AddBool(1, isCorrect, false);
		}

		// Token: 0x0601B87F RID: 112767 RVA: 0x003E4DC1 File Offset: 0x003E2FC1
		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
			builder.AddInt(2, order, 0);
		}

		// Token: 0x0601B880 RID: 112768 RVA: 0x003E4DCC File Offset: 0x003E2FCC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B881 RID: 112769 RVA: 0x003E4DD7 File Offset: 0x003E2FD7
		public static Offset<IDaemonHackPresetCode> EndIDaemonHackPresetCode(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHackPresetCode>(builder.EndTable());
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x003E4DE4 File Offset: 0x003E2FE4
		public IDaemonHackPresetCodeT UnPack()
		{
			IDaemonHackPresetCodeT daemonHackPresetCodeT = new IDaemonHackPresetCodeT();
			this.UnPackTo(daemonHackPresetCodeT);
			return daemonHackPresetCodeT;
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x003E4DFF File Offset: 0x003E2FFF
		public void UnPackTo(IDaemonHackPresetCodeT _o)
		{
			_o.Code = this.Code;
			_o.IsCorrect = this.IsCorrect;
			_o.Order = this.Order;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x003E4E34 File Offset: 0x003E3034
		public static Offset<IDaemonHackPresetCode> Pack(FlatBufferBuilder builder, IDaemonHackPresetCodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaemonHackPresetCode>);
			}
			StringOffset codeOffset = (_o.Code == null) ? default(StringOffset) : builder.CreateString(_o.Code);
			return IDaemonHackPresetCode.CreateIDaemonHackPresetCode(builder, codeOffset, _o.IsCorrect, _o.Order, _o.NullMask);
		}

		// Token: 0x0400CE58 RID: 52824
		private Table __p;
	}
}
