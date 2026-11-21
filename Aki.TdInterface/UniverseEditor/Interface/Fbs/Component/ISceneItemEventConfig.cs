using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ECB RID: 24267
	public struct ISceneItemEventConfig : IFlatbufferObject
	{
		// Token: 0x1700B348 RID: 45896
		// (get) Token: 0x06028AB0 RID: 166576 RVA: 0x0058F222 File Offset: 0x0058D422
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028AB1 RID: 166577 RVA: 0x0058F22F File Offset: 0x0058D42F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028AB2 RID: 166578 RVA: 0x0058F238 File Offset: 0x0058D438
		public static ISceneItemEventConfig GetRootAsISceneItemEventConfig(ByteBuffer _bb)
		{
			return ISceneItemEventConfig.GetRootAsISceneItemEventConfig(_bb, default(ISceneItemEventConfig));
		}

		// Token: 0x06028AB3 RID: 166579 RVA: 0x0058F254 File Offset: 0x0058D454
		public static ISceneItemEventConfig GetRootAsISceneItemEventConfig(ByteBuffer _bb, ISceneItemEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028AB4 RID: 166580 RVA: 0x0058F271 File Offset: 0x0058D471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028AB5 RID: 166581 RVA: 0x0058F280 File Offset: 0x0058D480
		public ISceneItemEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B349 RID: 45897
		// (get) Token: 0x06028AB6 RID: 166582 RVA: 0x0058F290 File Offset: 0x0058D490
		public string EntityStateTagName
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

		// Token: 0x06028AB7 RID: 166583 RVA: 0x0058F2C7 File Offset: 0x0058D4C7
		public Span<byte> GetEntityStateTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028AB8 RID: 166584 RVA: 0x0058F2D6 File Offset: 0x0058D4D6
		public byte[] GetEntityStateTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028AB9 RID: 166585 RVA: 0x0058F2E4 File Offset: 0x0058D4E4
		public ISceneItemSequenceEventData? SequenceEvents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneItemSequenceEventData?(default(ISceneItemSequenceEventData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B34A RID: 45898
		// (get) Token: 0x06028ABA RID: 166586 RVA: 0x0058F344 File Offset: 0x0058D544
		public int SequenceEventsLength
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

		// Token: 0x1700B34B RID: 45899
		// (get) Token: 0x06028ABB RID: 166587 RVA: 0x0058F370 File Offset: 0x0058D570
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028ABC RID: 166588 RVA: 0x0058F3AC File Offset: 0x0058D5AC
		public static Offset<ISceneItemEventConfig> CreateISceneItemEventConfig(FlatBufferBuilder builder, StringOffset EntityStateTagNameOffset = default(StringOffset), VectorOffset SequenceEventsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemEventConfig.AddSequenceEvents(builder, SequenceEventsOffset);
			ISceneItemEventConfig.AddEntityStateTagName(builder, EntityStateTagNameOffset);
			ISceneItemEventConfig.AddNullMask(builder, NullMask);
			return ISceneItemEventConfig.EndISceneItemEventConfig(builder);
		}

		// Token: 0x06028ABD RID: 166589 RVA: 0x0058F3D0 File Offset: 0x0058D5D0
		public static void StartISceneItemEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028ABE RID: 166590 RVA: 0x0058F3D9 File Offset: 0x0058D5D9
		public static void AddEntityStateTagName(FlatBufferBuilder builder, StringOffset entityStateTagNameOffset)
		{
			builder.AddOffset(0, entityStateTagNameOffset.Value, 0);
		}

		// Token: 0x06028ABF RID: 166591 RVA: 0x0058F3E9 File Offset: 0x0058D5E9
		public static void AddSequenceEvents(FlatBufferBuilder builder, VectorOffset sequenceEventsOffset)
		{
			builder.AddOffset(1, sequenceEventsOffset.Value, 0);
		}

		// Token: 0x06028AC0 RID: 166592 RVA: 0x0058F3FC File Offset: 0x0058D5FC
		public static VectorOffset CreateSequenceEventsVector(FlatBufferBuilder builder, Offset<ISceneItemSequenceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028AC1 RID: 166593 RVA: 0x0058F43C File Offset: 0x0058D63C
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, Offset<ISceneItemSequenceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneItemSequenceEventData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028AC2 RID: 166594 RVA: 0x0058F456 File Offset: 0x0058D656
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneItemSequenceEventData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneItemSequenceEventData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028AC3 RID: 166595 RVA: 0x0058F474 File Offset: 0x0058D674
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneItemSequenceEventData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028AC4 RID: 166596 RVA: 0x0058F48D File Offset: 0x0058D68D
		public static void StartSequenceEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028AC5 RID: 166597 RVA: 0x0058F498 File Offset: 0x0058D698
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028AC6 RID: 166598 RVA: 0x0058F4A3 File Offset: 0x0058D6A3
		public static Offset<ISceneItemEventConfig> EndISceneItemEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemEventConfig>(builder.EndTable());
		}

		// Token: 0x06028AC7 RID: 166599 RVA: 0x0058F4B0 File Offset: 0x0058D6B0
		public ISceneItemEventConfigT UnPack()
		{
			ISceneItemEventConfigT sceneItemEventConfigT = new ISceneItemEventConfigT();
			this.UnPackTo(sceneItemEventConfigT);
			return sceneItemEventConfigT;
		}

		// Token: 0x06028AC8 RID: 166600 RVA: 0x0058F4CC File Offset: 0x0058D6CC
		public void UnPackTo(ISceneItemEventConfigT _o)
		{
			_o.EntityStateTagName = this.EntityStateTagName;
			_o.SequenceEvents = new List<ISceneItemSequenceEventDataT>();
			for (int i = 0; i < this.SequenceEventsLength; i++)
			{
				_o.SequenceEvents.Add((this.SequenceEvents(i) != null) ? this.SequenceEvents(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028AC9 RID: 166601 RVA: 0x0058F544 File Offset: 0x0058D744
		public static Offset<ISceneItemEventConfig> Pack(FlatBufferBuilder builder, ISceneItemEventConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemEventConfig>);
			}
			StringOffset entityStateTagNameOffset = (_o.EntityStateTagName == null) ? default(StringOffset) : builder.CreateString(_o.EntityStateTagName);
			VectorOffset sequenceEventsOffset = default(VectorOffset);
			if (_o.SequenceEvents != null)
			{
				Offset<ISceneItemSequenceEventData>[] array = new Offset<ISceneItemSequenceEventData>[_o.SequenceEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneItemSequenceEventData.Pack(builder, _o.SequenceEvents[i]);
				}
				sequenceEventsOffset = ISceneItemEventConfig.CreateSequenceEventsVector(builder, array);
			}
			return ISceneItemEventConfig.CreateISceneItemEventConfig(builder, entityStateTagNameOffset, sequenceEventsOffset, _o.NullMask);
		}

		// Token: 0x0400FB26 RID: 64294
		private Table __p;
	}
}
