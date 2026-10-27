using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004455 RID: 17493
	public struct IDaemonHackPresetCode : IFlatbufferObject
	{
		// Token: 0x17007B4B RID: 31563
		// (get) Token: 0x0601A09E RID: 106654 RVA: 0x003B89EC File Offset: 0x003B6BEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A09F RID: 106655 RVA: 0x003B89F9 File Offset: 0x003B6BF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0A0 RID: 106656 RVA: 0x003B8A00 File Offset: 0x003B6C00
		public static IDaemonHackPresetCode GetRootAsIDaemonHackPresetCode(ByteBuffer _bb)
		{
			return IDaemonHackPresetCode.GetRootAsIDaemonHackPresetCode(_bb, default(IDaemonHackPresetCode));
		}

		// Token: 0x0601A0A1 RID: 106657 RVA: 0x003B8A1C File Offset: 0x003B6C1C
		public static IDaemonHackPresetCode GetRootAsIDaemonHackPresetCode(ByteBuffer _bb, IDaemonHackPresetCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0A2 RID: 106658 RVA: 0x003B8A39 File Offset: 0x003B6C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0A3 RID: 106659 RVA: 0x003B8A48 File Offset: 0x003B6C48
		public IDaemonHackPresetCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B4C RID: 31564
		// (get) Token: 0x0601A0A4 RID: 106660 RVA: 0x003B8A58 File Offset: 0x003B6C58
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

		// Token: 0x0601A0A5 RID: 106661 RVA: 0x003B8A8F File Offset: 0x003B6C8F
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A0A6 RID: 106662 RVA: 0x003B8A9E File Offset: 0x003B6C9E
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007B4D RID: 31565
		// (get) Token: 0x0601A0A7 RID: 106663 RVA: 0x003B8AAC File Offset: 0x003B6CAC
		public bool IsCorrect
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007B4E RID: 31566
		// (get) Token: 0x0601A0A8 RID: 106664 RVA: 0x003B8AEC File Offset: 0x003B6CEC
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

		// Token: 0x17007B4F RID: 31567
		// (get) Token: 0x0601A0A9 RID: 106665 RVA: 0x003B8B28 File Offset: 0x003B6D28
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

		// Token: 0x0601A0AA RID: 106666 RVA: 0x003B8B65 File Offset: 0x003B6D65
		public static Offset<IDaemonHackPresetCode> CreateIDaemonHackPresetCode(FlatBufferBuilder builder, StringOffset CodeOffset = default(StringOffset), bool IsCorrect = false, int Order = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDaemonHackPresetCode.AddOrder(builder, Order);
			IDaemonHackPresetCode.AddCode(builder, CodeOffset);
			IDaemonHackPresetCode.AddNullMask(builder, NullMask);
			IDaemonHackPresetCode.AddIsCorrect(builder, IsCorrect);
			return IDaemonHackPresetCode.EndIDaemonHackPresetCode(builder);
		}

		// Token: 0x0601A0AB RID: 106667 RVA: 0x003B8B91 File Offset: 0x003B6D91
		public static void StartIDaemonHackPresetCode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A0AC RID: 106668 RVA: 0x003B8B9A File Offset: 0x003B6D9A
		public static void AddCode(FlatBufferBuilder builder, StringOffset codeOffset)
		{
			builder.AddOffset(0, codeOffset.Value, 0);
		}

		// Token: 0x0601A0AD RID: 106669 RVA: 0x003B8BAA File Offset: 0x003B6DAA
		public static void AddIsCorrect(FlatBufferBuilder builder, bool isCorrect)
		{
			builder.AddBool(1, isCorrect, false);
		}

		// Token: 0x0601A0AE RID: 106670 RVA: 0x003B8BB5 File Offset: 0x003B6DB5
		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
			builder.AddInt(2, order, 0);
		}

		// Token: 0x0601A0AF RID: 106671 RVA: 0x003B8BC0 File Offset: 0x003B6DC0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A0B0 RID: 106672 RVA: 0x003B8BCB File Offset: 0x003B6DCB
		public static Offset<IDaemonHackPresetCode> EndIDaemonHackPresetCode(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHackPresetCode>(builder.EndTable());
		}

		// Token: 0x0601A0B1 RID: 106673 RVA: 0x003B8BD8 File Offset: 0x003B6DD8
		public IDaemonHackPresetCodeT UnPack()
		{
			IDaemonHackPresetCodeT daemonHackPresetCodeT = new IDaemonHackPresetCodeT();
			this.UnPackTo(daemonHackPresetCodeT);
			return daemonHackPresetCodeT;
		}

		// Token: 0x0601A0B2 RID: 106674 RVA: 0x003B8BF3 File Offset: 0x003B6DF3
		public void UnPackTo(IDaemonHackPresetCodeT _o)
		{
			_o.Code = this.Code;
			_o.IsCorrect = this.IsCorrect;
			_o.Order = this.Order;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A0B3 RID: 106675 RVA: 0x003B8C28 File Offset: 0x003B6E28
		public static Offset<IDaemonHackPresetCode> Pack(FlatBufferBuilder builder, IDaemonHackPresetCodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaemonHackPresetCode>);
			}
			StringOffset codeOffset = (_o.Code == null) ? default(StringOffset) : builder.CreateString(_o.Code);
			return IDaemonHackPresetCode.CreateIDaemonHackPresetCode(builder, codeOffset, _o.IsCorrect, _o.Order, _o.NullMask);
		}

		// Token: 0x0400C42A RID: 50218
		private Table __p;
	}
}
