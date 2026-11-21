using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED2 RID: 28370
	public struct IFocusOnQuestMapMark : IFlatbufferObject
	{
		// Token: 0x1700D014 RID: 53268
		// (get) Token: 0x06031159 RID: 201049 RVA: 0x006A7DB0 File Offset: 0x006A5FB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603115A RID: 201050 RVA: 0x006A7DBD File Offset: 0x006A5FBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603115B RID: 201051 RVA: 0x006A7DC4 File Offset: 0x006A5FC4
		public static IFocusOnQuestMapMark GetRootAsIFocusOnQuestMapMark(ByteBuffer _bb)
		{
			return IFocusOnQuestMapMark.GetRootAsIFocusOnQuestMapMark(_bb, default(IFocusOnQuestMapMark));
		}

		// Token: 0x0603115C RID: 201052 RVA: 0x006A7DE0 File Offset: 0x006A5FE0
		public static IFocusOnQuestMapMark GetRootAsIFocusOnQuestMapMark(ByteBuffer _bb, IFocusOnQuestMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603115D RID: 201053 RVA: 0x006A7DFD File Offset: 0x006A5FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603115E RID: 201054 RVA: 0x006A7E0C File Offset: 0x006A600C
		public IFocusOnQuestMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D015 RID: 53269
		// (get) Token: 0x0603115F RID: 201055 RVA: 0x006A7E1C File Offset: 0x006A601C
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

		// Token: 0x1700D016 RID: 53270
		// (get) Token: 0x06031160 RID: 201056 RVA: 0x006A7E58 File Offset: 0x006A6058
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

		// Token: 0x06031161 RID: 201057 RVA: 0x006A7E94 File Offset: 0x006A6094
		public static Offset<IFocusOnQuestMapMark> CreateIFocusOnQuestMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom, int QuestId = 0)
		{
			builder.StartTable(2);
			IFocusOnQuestMapMark.AddQuestId(builder, QuestId);
			IFocusOnQuestMapMark.AddType(builder, Type);
			return IFocusOnQuestMapMark.EndIFocusOnQuestMapMark(builder);
		}

		// Token: 0x06031162 RID: 201058 RVA: 0x006A7EB1 File Offset: 0x006A60B1
		public static void StartIFocusOnQuestMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031163 RID: 201059 RVA: 0x006A7EBA File Offset: 0x006A60BA
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031164 RID: 201060 RVA: 0x006A7EC5 File Offset: 0x006A60C5
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x06031165 RID: 201061 RVA: 0x006A7ED0 File Offset: 0x006A60D0
		public static Offset<IFocusOnQuestMapMark> EndIFocusOnQuestMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnQuestMapMark>(builder.EndTable());
		}

		// Token: 0x06031166 RID: 201062 RVA: 0x006A7EE0 File Offset: 0x006A60E0
		public IFocusOnQuestMapMarkT UnPack()
		{
			IFocusOnQuestMapMarkT focusOnQuestMapMarkT = new IFocusOnQuestMapMarkT();
			this.UnPackTo(focusOnQuestMapMarkT);
			return focusOnQuestMapMarkT;
		}

		// Token: 0x06031167 RID: 201063 RVA: 0x006A7EFB File Offset: 0x006A60FB
		public void UnPackTo(IFocusOnQuestMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x06031168 RID: 201064 RVA: 0x006A7F18 File Offset: 0x006A6118
		public static Offset<IFocusOnQuestMapMark> Pack(FlatBufferBuilder builder, IFocusOnQuestMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnQuestMapMark>);
			}
			return IFocusOnQuestMapMark.CreateIFocusOnQuestMapMark(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x04011DD1 RID: 73169
		private Table __p;
	}
}
