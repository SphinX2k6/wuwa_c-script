using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDD RID: 24285
	public struct ISceneItemSeqEventCbType : IFlatbufferObject
	{
		// Token: 0x1700B376 RID: 45942
		// (get) Token: 0x06028B62 RID: 166754 RVA: 0x005909CB File Offset: 0x0058EBCB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B63 RID: 166755 RVA: 0x005909D8 File Offset: 0x0058EBD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B64 RID: 166756 RVA: 0x005909E0 File Offset: 0x0058EBE0
		public static ISceneItemSeqEventCbType GetRootAsISceneItemSeqEventCbType(ByteBuffer _bb)
		{
			return ISceneItemSeqEventCbType.GetRootAsISceneItemSeqEventCbType(_bb, default(ISceneItemSeqEventCbType));
		}

		// Token: 0x06028B65 RID: 166757 RVA: 0x005909FC File Offset: 0x0058EBFC
		public static ISceneItemSeqEventCbType GetRootAsISceneItemSeqEventCbType(ByteBuffer _bb, ISceneItemSeqEventCbType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B66 RID: 166758 RVA: 0x00590A19 File Offset: 0x0058EC19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B67 RID: 166759 RVA: 0x00590A28 File Offset: 0x0058EC28
		public ISceneItemSeqEventCbType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B377 RID: 45943
		// (get) Token: 0x06028B68 RID: 166760 RVA: 0x00590A38 File Offset: 0x0058EC38
		public ESceneItemSeqEventCbType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemSeqEventCbType.ANS;
				}
				return (ESceneItemSeqEventCbType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B378 RID: 45944
		// (get) Token: 0x06028B69 RID: 166761 RVA: 0x00590A74 File Offset: 0x0058EC74
		public string EventName
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

		// Token: 0x06028B6A RID: 166762 RVA: 0x00590AAB File Offset: 0x0058ECAB
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028B6B RID: 166763 RVA: 0x00590ABA File Offset: 0x0058ECBA
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B379 RID: 45945
		// (get) Token: 0x06028B6C RID: 166764 RVA: 0x00590AC8 File Offset: 0x0058ECC8
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028B6D RID: 166765 RVA: 0x00590B25 File Offset: 0x0058ED25
		public static Offset<ISceneItemSeqEventCbType> CreateISceneItemSeqEventCbType(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(3);
			ISceneItemSeqEventCbType.AddAction(builder, ActionOffset);
			ISceneItemSeqEventCbType.AddEventName(builder, EventNameOffset);
			ISceneItemSeqEventCbType.AddType(builder, Type);
			return ISceneItemSeqEventCbType.EndISceneItemSeqEventCbType(builder);
		}

		// Token: 0x06028B6E RID: 166766 RVA: 0x00590B49 File Offset: 0x0058ED49
		public static void StartISceneItemSeqEventCbType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028B6F RID: 166767 RVA: 0x00590B52 File Offset: 0x0058ED52
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028B70 RID: 166768 RVA: 0x00590B5D File Offset: 0x0058ED5D
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x06028B71 RID: 166769 RVA: 0x00590B6D File Offset: 0x0058ED6D
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x06028B72 RID: 166770 RVA: 0x00590B7D File Offset: 0x0058ED7D
		public static Offset<ISceneItemSeqEventCbType> EndISceneItemSeqEventCbType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemSeqEventCbType>(builder.EndTable());
		}

		// Token: 0x06028B73 RID: 166771 RVA: 0x00590B8C File Offset: 0x0058ED8C
		public ISceneItemSeqEventCbTypeT UnPack()
		{
			ISceneItemSeqEventCbTypeT sceneItemSeqEventCbTypeT = new ISceneItemSeqEventCbTypeT();
			this.UnPackTo(sceneItemSeqEventCbTypeT);
			return sceneItemSeqEventCbTypeT;
		}

		// Token: 0x06028B74 RID: 166772 RVA: 0x00590BA8 File Offset: 0x0058EDA8
		public void UnPackTo(ISceneItemSeqEventCbTypeT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x06028B75 RID: 166773 RVA: 0x00590BFC File Offset: 0x0058EDFC
		public static Offset<ISceneItemSeqEventCbType> Pack(FlatBufferBuilder builder, ISceneItemSeqEventCbTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemSeqEventCbType>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return ISceneItemSeqEventCbType.CreateISceneItemSeqEventCbType(builder, _o.Type, eventNameOffset, actionOffset);
		}

		// Token: 0x0400FB40 RID: 64320
		private Table __p;
	}
}
