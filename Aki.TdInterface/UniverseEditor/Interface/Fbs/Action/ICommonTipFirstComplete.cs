using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006498 RID: 25752
	public struct ICommonTipFirstComplete : IFlatbufferObject
	{
		// Token: 0x1700BFA3 RID: 49059
		// (get) Token: 0x0602CA16 RID: 182806 RVA: 0x00620C1D File Offset: 0x0061EE1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA17 RID: 182807 RVA: 0x00620C2A File Offset: 0x0061EE2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA18 RID: 182808 RVA: 0x00620C34 File Offset: 0x0061EE34
		public static ICommonTipFirstComplete GetRootAsICommonTipFirstComplete(ByteBuffer _bb)
		{
			return ICommonTipFirstComplete.GetRootAsICommonTipFirstComplete(_bb, default(ICommonTipFirstComplete));
		}

		// Token: 0x0602CA19 RID: 182809 RVA: 0x00620C50 File Offset: 0x0061EE50
		public static ICommonTipFirstComplete GetRootAsICommonTipFirstComplete(ByteBuffer _bb, ICommonTipFirstComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA1A RID: 182810 RVA: 0x00620C6D File Offset: 0x0061EE6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA1B RID: 182811 RVA: 0x00620C7C File Offset: 0x0061EE7C
		public ICommonTipFirstComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFA4 RID: 49060
		// (get) Token: 0x0602CA1C RID: 182812 RVA: 0x00620C8C File Offset: 0x0061EE8C
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

		// Token: 0x1700BFA5 RID: 49061
		// (get) Token: 0x0602CA1D RID: 182813 RVA: 0x00620CC8 File Offset: 0x0061EEC8
		public string TidText
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

		// Token: 0x0602CA1E RID: 182814 RVA: 0x00620CFF File Offset: 0x0061EEFF
		public Span<byte> GetTidTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CA1F RID: 182815 RVA: 0x00620D0E File Offset: 0x0061EF0E
		public byte[] GetTidTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CA20 RID: 182816 RVA: 0x00620D1C File Offset: 0x0061EF1C
		public static Offset<ICommonTipFirstComplete> CreateICommonTipFirstComplete(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICommonTipFirstComplete.AddTidText(builder, TidTextOffset);
			ICommonTipFirstComplete.AddType(builder, Type);
			return ICommonTipFirstComplete.EndICommonTipFirstComplete(builder);
		}

		// Token: 0x0602CA21 RID: 182817 RVA: 0x00620D39 File Offset: 0x0061EF39
		public static void StartICommonTipFirstComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CA22 RID: 182818 RVA: 0x00620D42 File Offset: 0x0061EF42
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA23 RID: 182819 RVA: 0x00620D4D File Offset: 0x0061EF4D
		public static void AddTidText(FlatBufferBuilder builder, StringOffset tidTextOffset)
		{
			builder.AddOffset(1, tidTextOffset.Value, 0);
		}

		// Token: 0x0602CA24 RID: 182820 RVA: 0x00620D5D File Offset: 0x0061EF5D
		public static Offset<ICommonTipFirstComplete> EndICommonTipFirstComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipFirstComplete>(builder.EndTable());
		}

		// Token: 0x0602CA25 RID: 182821 RVA: 0x00620D6C File Offset: 0x0061EF6C
		public ICommonTipFirstCompleteT UnPack()
		{
			ICommonTipFirstCompleteT commonTipFirstCompleteT = new ICommonTipFirstCompleteT();
			this.UnPackTo(commonTipFirstCompleteT);
			return commonTipFirstCompleteT;
		}

		// Token: 0x0602CA26 RID: 182822 RVA: 0x00620D87 File Offset: 0x0061EF87
		public void UnPackTo(ICommonTipFirstCompleteT _o)
		{
			_o.Type = this.Type;
			_o.TidText = this.TidText;
		}

		// Token: 0x0602CA27 RID: 182823 RVA: 0x00620DA4 File Offset: 0x0061EFA4
		public static Offset<ICommonTipFirstComplete> Pack(FlatBufferBuilder builder, ICommonTipFirstCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipFirstComplete>);
			}
			StringOffset tidTextOffset = (_o.TidText == null) ? default(StringOffset) : builder.CreateString(_o.TidText);
			return ICommonTipFirstComplete.CreateICommonTipFirstComplete(builder, _o.Type, tidTextOffset);
		}

		// Token: 0x04010AA5 RID: 68261
		private Table __p;
	}
}
