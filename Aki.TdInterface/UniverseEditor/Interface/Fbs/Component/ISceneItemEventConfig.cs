using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BE RID: 22718
	public struct ISceneItemEventConfig : IFlatbufferObject
	{
		// Token: 0x1700AA18 RID: 43544
		// (get) Token: 0x0602654E RID: 157006 RVA: 0x005486D6 File Offset: 0x005468D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602654F RID: 157007 RVA: 0x005486E3 File Offset: 0x005468E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026550 RID: 157008 RVA: 0x005486EC File Offset: 0x005468EC
		public static ISceneItemEventConfig GetRootAsISceneItemEventConfig(ByteBuffer _bb)
		{
			return ISceneItemEventConfig.GetRootAsISceneItemEventConfig(_bb, default(ISceneItemEventConfig));
		}

		// Token: 0x06026551 RID: 157009 RVA: 0x00548708 File Offset: 0x00546908
		public static ISceneItemEventConfig GetRootAsISceneItemEventConfig(ByteBuffer _bb, ISceneItemEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026552 RID: 157010 RVA: 0x00548725 File Offset: 0x00546925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026553 RID: 157011 RVA: 0x00548734 File Offset: 0x00546934
		public ISceneItemEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA19 RID: 43545
		// (get) Token: 0x06026554 RID: 157012 RVA: 0x00548744 File Offset: 0x00546944
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

		// Token: 0x06026555 RID: 157013 RVA: 0x0054877B File Offset: 0x0054697B
		public Span<byte> GetEntityStateTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026556 RID: 157014 RVA: 0x0054878A File Offset: 0x0054698A
		public byte[] GetEntityStateTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026557 RID: 157015 RVA: 0x00548798 File Offset: 0x00546998
		public ISceneItemSequenceEventData? SequenceEvents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneItemSequenceEventData?(default(ISceneItemSequenceEventData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA1A RID: 43546
		// (get) Token: 0x06026558 RID: 157016 RVA: 0x005487F8 File Offset: 0x005469F8
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

		// Token: 0x1700AA1B RID: 43547
		// (get) Token: 0x06026559 RID: 157017 RVA: 0x00548824 File Offset: 0x00546A24
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

		// Token: 0x0602655A RID: 157018 RVA: 0x00548860 File Offset: 0x00546A60
		public static Offset<ISceneItemEventConfig> CreateISceneItemEventConfig(FlatBufferBuilder builder, StringOffset EntityStateTagNameOffset = default(StringOffset), VectorOffset SequenceEventsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemEventConfig.AddSequenceEvents(builder, SequenceEventsOffset);
			ISceneItemEventConfig.AddEntityStateTagName(builder, EntityStateTagNameOffset);
			ISceneItemEventConfig.AddNullMask(builder, NullMask);
			return ISceneItemEventConfig.EndISceneItemEventConfig(builder);
		}

		// Token: 0x0602655B RID: 157019 RVA: 0x00548884 File Offset: 0x00546A84
		public static void StartISceneItemEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602655C RID: 157020 RVA: 0x0054888D File Offset: 0x00546A8D
		public static void AddEntityStateTagName(FlatBufferBuilder builder, StringOffset entityStateTagNameOffset)
		{
			builder.AddOffset(0, entityStateTagNameOffset.Value, 0);
		}

		// Token: 0x0602655D RID: 157021 RVA: 0x0054889D File Offset: 0x00546A9D
		public static void AddSequenceEvents(FlatBufferBuilder builder, VectorOffset sequenceEventsOffset)
		{
			builder.AddOffset(1, sequenceEventsOffset.Value, 0);
		}

		// Token: 0x0602655E RID: 157022 RVA: 0x005488B0 File Offset: 0x00546AB0
		public static VectorOffset CreateSequenceEventsVector(FlatBufferBuilder builder, Offset<ISceneItemSequenceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602655F RID: 157023 RVA: 0x005488F0 File Offset: 0x00546AF0
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, Offset<ISceneItemSequenceEventData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneItemSequenceEventData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026560 RID: 157024 RVA: 0x0054890A File Offset: 0x00546B0A
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneItemSequenceEventData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneItemSequenceEventData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026561 RID: 157025 RVA: 0x00548928 File Offset: 0x00546B28
		public static VectorOffset CreateSequenceEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneItemSequenceEventData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026562 RID: 157026 RVA: 0x00548941 File Offset: 0x00546B41
		public static void StartSequenceEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026563 RID: 157027 RVA: 0x0054894C File Offset: 0x00546B4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026564 RID: 157028 RVA: 0x00548957 File Offset: 0x00546B57
		public static Offset<ISceneItemEventConfig> EndISceneItemEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemEventConfig>(builder.EndTable());
		}

		// Token: 0x06026565 RID: 157029 RVA: 0x00548964 File Offset: 0x00546B64
		public ISceneItemEventConfigT UnPack()
		{
			ISceneItemEventConfigT sceneItemEventConfigT = new ISceneItemEventConfigT();
			this.UnPackTo(sceneItemEventConfigT);
			return sceneItemEventConfigT;
		}

		// Token: 0x06026566 RID: 157030 RVA: 0x00548980 File Offset: 0x00546B80
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

		// Token: 0x06026567 RID: 157031 RVA: 0x005489F8 File Offset: 0x00546BF8
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

		// Token: 0x0400EE33 RID: 60979
		private Table __p;
	}
}
