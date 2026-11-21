using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E0F RID: 32271
	public struct IWaitUntilLevelSequenceReachMark : IFlatbufferObject
	{
		// Token: 0x1700F1B8 RID: 61880
		// (get) Token: 0x0603A517 RID: 238871 RVA: 0x007DB4E6 File Offset: 0x007D96E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A518 RID: 238872 RVA: 0x007DB4F3 File Offset: 0x007D96F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A519 RID: 238873 RVA: 0x007DB4FC File Offset: 0x007D96FC
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb)
		{
			return IWaitUntilLevelSequenceReachMark.GetRootAsIWaitUntilLevelSequenceReachMark(_bb, default(IWaitUntilLevelSequenceReachMark));
		}

		// Token: 0x0603A51A RID: 238874 RVA: 0x007DB518 File Offset: 0x007D9718
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb, IWaitUntilLevelSequenceReachMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A51B RID: 238875 RVA: 0x007DB535 File Offset: 0x007D9735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A51C RID: 238876 RVA: 0x007DB544 File Offset: 0x007D9744
		public IWaitUntilLevelSequenceReachMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1B9 RID: 61881
		// (get) Token: 0x0603A51D RID: 238877 RVA: 0x007DB554 File Offset: 0x007D9754
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1BA RID: 61882
		// (get) Token: 0x0603A51E RID: 238878 RVA: 0x007DB590 File Offset: 0x007D9790
		public string Mark
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

		// Token: 0x0603A51F RID: 238879 RVA: 0x007DB5C7 File Offset: 0x007D97C7
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603A520 RID: 238880 RVA: 0x007DB5D6 File Offset: 0x007D97D6
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603A521 RID: 238881 RVA: 0x007DB5E4 File Offset: 0x007D97E4
		public static Offset<IWaitUntilLevelSequenceReachMark> CreateIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder, int EntityId = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWaitUntilLevelSequenceReachMark.AddMark(builder, MarkOffset);
			IWaitUntilLevelSequenceReachMark.AddEntityId(builder, EntityId);
			return IWaitUntilLevelSequenceReachMark.EndIWaitUntilLevelSequenceReachMark(builder);
		}

		// Token: 0x0603A522 RID: 238882 RVA: 0x007DB601 File Offset: 0x007D9801
		public static void StartIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A523 RID: 238883 RVA: 0x007DB60A File Offset: 0x007D980A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0603A524 RID: 238884 RVA: 0x007DB615 File Offset: 0x007D9815
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x0603A525 RID: 238885 RVA: 0x007DB625 File Offset: 0x007D9825
		public static Offset<IWaitUntilLevelSequenceReachMark> EndIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			return new Offset<IWaitUntilLevelSequenceReachMark>(builder.EndTable());
		}

		// Token: 0x0603A526 RID: 238886 RVA: 0x007DB634 File Offset: 0x007D9834
		public IWaitUntilLevelSequenceReachMarkT UnPack()
		{
			IWaitUntilLevelSequenceReachMarkT waitUntilLevelSequenceReachMarkT = new IWaitUntilLevelSequenceReachMarkT();
			this.UnPackTo(waitUntilLevelSequenceReachMarkT);
			return waitUntilLevelSequenceReachMarkT;
		}

		// Token: 0x0603A527 RID: 238887 RVA: 0x007DB64F File Offset: 0x007D984F
		public void UnPackTo(IWaitUntilLevelSequenceReachMarkT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Mark = this.Mark;
		}

		// Token: 0x0603A528 RID: 238888 RVA: 0x007DB66C File Offset: 0x007D986C
		public static Offset<IWaitUntilLevelSequenceReachMark> Pack(FlatBufferBuilder builder, IWaitUntilLevelSequenceReachMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitUntilLevelSequenceReachMark>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return IWaitUntilLevelSequenceReachMark.CreateIWaitUntilLevelSequenceReachMark(builder, _o.EntityId, markOffset);
		}

		// Token: 0x040135BD RID: 79293
		private Table __p;
	}
}
