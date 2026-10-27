using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D0 RID: 22736
	public struct ISceneItemSeqEventCbType : IFlatbufferObject
	{
		// Token: 0x1700AA46 RID: 43590
		// (get) Token: 0x06026600 RID: 157184 RVA: 0x00549E7F File Offset: 0x0054807F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026601 RID: 157185 RVA: 0x00549E8C File Offset: 0x0054808C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026602 RID: 157186 RVA: 0x00549E94 File Offset: 0x00548094
		public static ISceneItemSeqEventCbType GetRootAsISceneItemSeqEventCbType(ByteBuffer _bb)
		{
			return ISceneItemSeqEventCbType.GetRootAsISceneItemSeqEventCbType(_bb, default(ISceneItemSeqEventCbType));
		}

		// Token: 0x06026603 RID: 157187 RVA: 0x00549EB0 File Offset: 0x005480B0
		public static ISceneItemSeqEventCbType GetRootAsISceneItemSeqEventCbType(ByteBuffer _bb, ISceneItemSeqEventCbType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026604 RID: 157188 RVA: 0x00549ECD File Offset: 0x005480CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026605 RID: 157189 RVA: 0x00549EDC File Offset: 0x005480DC
		public ISceneItemSeqEventCbType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA47 RID: 43591
		// (get) Token: 0x06026606 RID: 157190 RVA: 0x00549EEC File Offset: 0x005480EC
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

		// Token: 0x1700AA48 RID: 43592
		// (get) Token: 0x06026607 RID: 157191 RVA: 0x00549F28 File Offset: 0x00548128
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

		// Token: 0x06026608 RID: 157192 RVA: 0x00549F5F File Offset: 0x0054815F
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026609 RID: 157193 RVA: 0x00549F6E File Offset: 0x0054816E
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AA49 RID: 43593
		// (get) Token: 0x0602660A RID: 157194 RVA: 0x00549F7C File Offset: 0x0054817C
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

		// Token: 0x0602660B RID: 157195 RVA: 0x00549FD9 File Offset: 0x005481D9
		public static Offset<ISceneItemSeqEventCbType> CreateISceneItemSeqEventCbType(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(3);
			ISceneItemSeqEventCbType.AddAction(builder, ActionOffset);
			ISceneItemSeqEventCbType.AddEventName(builder, EventNameOffset);
			ISceneItemSeqEventCbType.AddType(builder, Type);
			return ISceneItemSeqEventCbType.EndISceneItemSeqEventCbType(builder);
		}

		// Token: 0x0602660C RID: 157196 RVA: 0x00549FFD File Offset: 0x005481FD
		public static void StartISceneItemSeqEventCbType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602660D RID: 157197 RVA: 0x0054A006 File Offset: 0x00548206
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x0054A011 File Offset: 0x00548211
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x0602660F RID: 157199 RVA: 0x0054A021 File Offset: 0x00548221
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x06026610 RID: 157200 RVA: 0x0054A031 File Offset: 0x00548231
		public static Offset<ISceneItemSeqEventCbType> EndISceneItemSeqEventCbType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemSeqEventCbType>(builder.EndTable());
		}

		// Token: 0x06026611 RID: 157201 RVA: 0x0054A040 File Offset: 0x00548240
		public ISceneItemSeqEventCbTypeT UnPack()
		{
			ISceneItemSeqEventCbTypeT sceneItemSeqEventCbTypeT = new ISceneItemSeqEventCbTypeT();
			this.UnPackTo(sceneItemSeqEventCbTypeT);
			return sceneItemSeqEventCbTypeT;
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x0054A05C File Offset: 0x0054825C
		public void UnPackTo(ISceneItemSeqEventCbTypeT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x0054A0B0 File Offset: 0x005482B0
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

		// Token: 0x0400EE4D RID: 61005
		private Table __p;
	}
}
