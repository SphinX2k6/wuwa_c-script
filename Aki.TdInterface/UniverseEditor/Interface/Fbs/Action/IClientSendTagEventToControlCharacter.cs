using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A62 RID: 27234
	public struct IClientSendTagEventToControlCharacter : IFlatbufferObject
	{
		// Token: 0x1700C816 RID: 51222
		// (get) Token: 0x0602EB9D RID: 191389 RVA: 0x0065E6FB File Offset: 0x0065C8FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB9E RID: 191390 RVA: 0x0065E708 File Offset: 0x0065C908
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB9F RID: 191391 RVA: 0x0065E710 File Offset: 0x0065C910
		public static IClientSendTagEventToControlCharacter GetRootAsIClientSendTagEventToControlCharacter(ByteBuffer _bb)
		{
			return IClientSendTagEventToControlCharacter.GetRootAsIClientSendTagEventToControlCharacter(_bb, default(IClientSendTagEventToControlCharacter));
		}

		// Token: 0x0602EBA0 RID: 191392 RVA: 0x0065E72C File Offset: 0x0065C92C
		public static IClientSendTagEventToControlCharacter GetRootAsIClientSendTagEventToControlCharacter(ByteBuffer _bb, IClientSendTagEventToControlCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBA1 RID: 191393 RVA: 0x0065E749 File Offset: 0x0065C949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBA2 RID: 191394 RVA: 0x0065E758 File Offset: 0x0065C958
		public IClientSendTagEventToControlCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C817 RID: 51223
		// (get) Token: 0x0602EBA3 RID: 191395 RVA: 0x0065E768 File Offset: 0x0065C968
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

		// Token: 0x0602EBA4 RID: 191396 RVA: 0x0065E7A4 File Offset: 0x0065C9A4
		public string EventTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C818 RID: 51224
		// (get) Token: 0x0602EBA5 RID: 191397 RVA: 0x0065E7E0 File Offset: 0x0065C9E0
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

		// Token: 0x0602EBA6 RID: 191398 RVA: 0x0065E80B File Offset: 0x0065CA0B
		public static Offset<IClientSendTagEventToControlCharacter> CreateIClientSendTagEventToControlCharacter(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, VectorOffset EventTagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IClientSendTagEventToControlCharacter.AddEventTags(builder, EventTagsOffset);
			IClientSendTagEventToControlCharacter.AddType(builder, Type);
			return IClientSendTagEventToControlCharacter.EndIClientSendTagEventToControlCharacter(builder);
		}

		// Token: 0x0602EBA7 RID: 191399 RVA: 0x0065E828 File Offset: 0x0065CA28
		public static void StartIClientSendTagEventToControlCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EBA8 RID: 191400 RVA: 0x0065E831 File Offset: 0x0065CA31
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EBA9 RID: 191401 RVA: 0x0065E83C File Offset: 0x0065CA3C
		public static void AddEventTags(FlatBufferBuilder builder, VectorOffset eventTagsOffset)
		{
			builder.AddOffset(1, eventTagsOffset.Value, 0);
		}

		// Token: 0x0602EBAA RID: 191402 RVA: 0x0065E84C File Offset: 0x0065CA4C
		public static VectorOffset CreateEventTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EBAB RID: 191403 RVA: 0x0065E88C File Offset: 0x0065CA8C
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EBAC RID: 191404 RVA: 0x0065E8A6 File Offset: 0x0065CAA6
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EBAD RID: 191405 RVA: 0x0065E8C4 File Offset: 0x0065CAC4
		public static VectorOffset CreateEventTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EBAE RID: 191406 RVA: 0x0065E8DD File Offset: 0x0065CADD
		public static void StartEventTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EBAF RID: 191407 RVA: 0x0065E8E8 File Offset: 0x0065CAE8
		public static Offset<IClientSendTagEventToControlCharacter> EndIClientSendTagEventToControlCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IClientSendTagEventToControlCharacter>(builder.EndTable());
		}

		// Token: 0x0602EBB0 RID: 191408 RVA: 0x0065E8F8 File Offset: 0x0065CAF8
		public IClientSendTagEventToControlCharacterT UnPack()
		{
			IClientSendTagEventToControlCharacterT clientSendTagEventToControlCharacterT = new IClientSendTagEventToControlCharacterT();
			this.UnPackTo(clientSendTagEventToControlCharacterT);
			return clientSendTagEventToControlCharacterT;
		}

		// Token: 0x0602EBB1 RID: 191409 RVA: 0x0065E914 File Offset: 0x0065CB14
		public void UnPackTo(IClientSendTagEventToControlCharacterT _o)
		{
			_o.Type = this.Type;
			_o.EventTags = new List<string>();
			for (int i = 0; i < this.EventTagsLength; i++)
			{
				_o.EventTags.Add(this.EventTags(i));
			}
		}

		// Token: 0x0602EBB2 RID: 191410 RVA: 0x0065E95C File Offset: 0x0065CB5C
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

		// Token: 0x040117EA RID: 71658
		private Table __p;
	}
}
