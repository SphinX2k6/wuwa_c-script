using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E2 RID: 25570
	public struct IClientSendTagEventToControlCharacter : IFlatbufferObject
	{
		// Token: 0x1700BE7C RID: 48764
		// (get) Token: 0x0602C3C7 RID: 181191 RVA: 0x0061286F File Offset: 0x00610A6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C3C8 RID: 181192 RVA: 0x0061287C File Offset: 0x00610A7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C3C9 RID: 181193 RVA: 0x00612884 File Offset: 0x00610A84
		public static IClientSendTagEventToControlCharacter GetRootAsIClientSendTagEventToControlCharacter(ByteBuffer _bb)
		{
			return IClientSendTagEventToControlCharacter.GetRootAsIClientSendTagEventToControlCharacter(_bb, default(IClientSendTagEventToControlCharacter));
		}

		// Token: 0x0602C3CA RID: 181194 RVA: 0x006128A0 File Offset: 0x00610AA0
		public static IClientSendTagEventToControlCharacter GetRootAsIClientSendTagEventToControlCharacter(ByteBuffer _bb, IClientSendTagEventToControlCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C3CB RID: 181195 RVA: 0x006128BD File Offset: 0x00610ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C3CC RID: 181196 RVA: 0x006128CC File Offset: 0x00610ACC
		public IClientSendTagEventToControlCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE7D RID: 48765
		// (get) Token: 0x0602C3CD RID: 181197 RVA: 0x006128DC File Offset: 0x00610ADC
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C3CE RID: 181198 RVA: 0x00612918 File Offset: 0x00610B18
		public string EventTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE7E RID: 48766
		// (get) Token: 0x0602C3CF RID: 181199 RVA: 0x00612954 File Offset: 0x00610B54
		public int EventTagsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C3D0 RID: 181200 RVA: 0x0061297F File Offset: 0x00610B7F
		public static Offset<IClientSendTagEventToControlCharacter> CreateIClientSendTagEventToControlCharacter(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, VectorOffset EventTagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IClientSendTagEventToControlCharacter.AddEventTags(builder, EventTagsOffset);
			IClientSendTagEventToControlCharacter.AddType(builder, Type);
			return IClientSendTagEventToControlCharacter.EndIClientSendTagEventToControlCharacter(builder);
		}

		// Token: 0x0602C3D1 RID: 181201 RVA: 0x0061299C File Offset: 0x00610B9C
		public static void StartIClientSendTagEventToControlCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C3D2 RID: 181202 RVA: 0x006129A5 File Offset: 0x00610BA5
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C3D3 RID: 181203 RVA: 0x006129B0 File Offset: 0x00610BB0
		public static void AddEventTags(FlatBufferBuilder builder, VectorOffset eventTagsOffset)
		{
			builder.AddOffset(1, eventTagsOffset.Value, 0);
		}

		// Token: 0x0602C3D4 RID: 181204 RVA: 0x006129C0 File Offset: 0x00610BC0
		public static VectorOffset CreateEventTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C3D5 RID: 181205 RVA: 0x00612A00 File Offset: 0x00610C00
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3D6 RID: 181206 RVA: 0x00612A1A File Offset: 0x00610C1A
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C3D7 RID: 181207 RVA: 0x00612A38 File Offset: 0x00610C38
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C3D8 RID: 181208 RVA: 0x00612A51 File Offset: 0x00610C51
		public static void StartEventTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C3D9 RID: 181209 RVA: 0x00612A5C File Offset: 0x00610C5C
		public static Offset<IClientSendTagEventToControlCharacter> EndIClientSendTagEventToControlCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IClientSendTagEventToControlCharacter>(builder.EndTable());
		}

		// Token: 0x0602C3DA RID: 181210 RVA: 0x00612A6C File Offset: 0x00610C6C
		public IClientSendTagEventToControlCharacterT UnPack()
		{
			IClientSendTagEventToControlCharacterT clientSendTagEventToControlCharacterT = new IClientSendTagEventToControlCharacterT();
			this.UnPackTo(clientSendTagEventToControlCharacterT);
			return clientSendTagEventToControlCharacterT;
		}

		// Token: 0x0602C3DB RID: 181211 RVA: 0x00612A88 File Offset: 0x00610C88
		public void UnPackTo(IClientSendTagEventToControlCharacterT _o)
		{
			_o.Type = this.Type;
			_o.EventTags = new List<string>();
			for (int i = 0; i < this.EventTagsLength; i++)
			{
				_o.EventTags.Add(this.EventTags(i));
			}
		}

		// Token: 0x0602C3DC RID: 181212 RVA: 0x00612AD0 File Offset: 0x00610CD0
		public static Offset<IClientSendTagEventToControlCharacter> Pack(FlatBufferBuilder builder, IClientSendTagEventToControlCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSendTagEventToControlCharacter>);
			}
			VectorOffset eventTagsOffset = default(VectorOffset);
			if (_o.EventTags != null)
			{
				StringOffset[] array = new StringOffset[_o.EventTags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.EventTags[i]);
				}
				eventTagsOffset = IClientSendTagEventToControlCharacter.CreateEventTagsVector(builder, array);
			}
			return IClientSendTagEventToControlCharacter.CreateIClientSendTagEventToControlCharacter(builder, _o.Type, eventTagsOffset);
		}

		// Token: 0x040109C4 RID: 68036
		private Table __p;
	}
}
