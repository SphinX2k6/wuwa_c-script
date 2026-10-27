using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684C RID: 26700
	public struct IFocusOnQuestMapMark : IFlatbufferObject
	{
		// Token: 0x1700C650 RID: 50768
		// (get) Token: 0x0602E8D1 RID: 190673 RVA: 0x00659E70 File Offset: 0x00658070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8D2 RID: 190674 RVA: 0x00659E7D File Offset: 0x0065807D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8D3 RID: 190675 RVA: 0x00659E84 File Offset: 0x00658084
		public static IFocusOnQuestMapMark GetRootAsIFocusOnQuestMapMark(ByteBuffer _bb)
		{
			return IFocusOnQuestMapMark.GetRootAsIFocusOnQuestMapMark(_bb, default(IFocusOnQuestMapMark));
		}

		// Token: 0x0602E8D4 RID: 190676 RVA: 0x00659EA0 File Offset: 0x006580A0
		public static IFocusOnQuestMapMark GetRootAsIFocusOnQuestMapMark(ByteBuffer _bb, IFocusOnQuestMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8D5 RID: 190677 RVA: 0x00659EBD File Offset: 0x006580BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8D6 RID: 190678 RVA: 0x00659ECC File Offset: 0x006580CC
		public IFocusOnQuestMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C651 RID: 50769
		// (get) Token: 0x0602E8D7 RID: 190679 RVA: 0x00659EDC File Offset: 0x006580DC
		public EMapMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkType.Custom;
				}
				return (EMapMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C652 RID: 50770
		// (get) Token: 0x0602E8D8 RID: 190680 RVA: 0x00659F18 File Offset: 0x00658118
		public int QuestId
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

		// Token: 0x0602E8D9 RID: 190681 RVA: 0x00659F54 File Offset: 0x00658154
		public static Offset<IFocusOnQuestMapMark> CreateIFocusOnQuestMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom, int QuestId = 0)
		{
			builder.StartTable(2);
			IFocusOnQuestMapMark.AddQuestId(builder, QuestId);
			IFocusOnQuestMapMark.AddType(builder, Type);
			return IFocusOnQuestMapMark.EndIFocusOnQuestMapMark(builder);
		}

		// Token: 0x0602E8DA RID: 190682 RVA: 0x00659F71 File Offset: 0x00658171
		public static void StartIFocusOnQuestMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E8DB RID: 190683 RVA: 0x00659F7A File Offset: 0x0065817A
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E8DC RID: 190684 RVA: 0x00659F85 File Offset: 0x00658185
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0602E8DD RID: 190685 RVA: 0x00659F90 File Offset: 0x00658190
		public static Offset<IFocusOnQuestMapMark> EndIFocusOnQuestMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnQuestMapMark>(builder.EndTable());
		}

		// Token: 0x0602E8DE RID: 190686 RVA: 0x00659FA0 File Offset: 0x006581A0
		public IFocusOnQuestMapMarkT UnPack()
		{
			IFocusOnQuestMapMarkT focusOnQuestMapMarkT = new IFocusOnQuestMapMarkT();
			this.UnPackTo(focusOnQuestMapMarkT);
			return focusOnQuestMapMarkT;
		}

		// Token: 0x0602E8DF RID: 190687 RVA: 0x00659FBB File Offset: 0x006581BB
		public void UnPackTo(IFocusOnQuestMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0602E8E0 RID: 190688 RVA: 0x00659FD8 File Offset: 0x006581D8
		public static Offset<IFocusOnQuestMapMark> Pack(FlatBufferBuilder builder, IFocusOnQuestMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnQuestMapMark>);
			}
			return IFocusOnQuestMapMark.CreateIFocusOnQuestMapMark(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x04010F97 RID: 69527
		private Table __p;
	}
}
