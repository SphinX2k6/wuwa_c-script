using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007133 RID: 28979
	public struct ILiveStartInteractDanmakuConfig : IFlatbufferObject
	{
		// Token: 0x1700D429 RID: 54313
		// (get) Token: 0x0603257C RID: 206204 RVA: 0x006CE9A5 File Offset: 0x006CCBA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603257D RID: 206205 RVA: 0x006CE9B2 File Offset: 0x006CCBB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603257E RID: 206206 RVA: 0x006CE9BC File Offset: 0x006CCBBC
		public static ILiveStartInteractDanmakuConfig GetRootAsILiveStartInteractDanmakuConfig(ByteBuffer _bb)
		{
			return ILiveStartInteractDanmakuConfig.GetRootAsILiveStartInteractDanmakuConfig(_bb, default(ILiveStartInteractDanmakuConfig));
		}

		// Token: 0x0603257F RID: 206207 RVA: 0x006CE9D8 File Offset: 0x006CCBD8
		public static ILiveStartInteractDanmakuConfig GetRootAsILiveStartInteractDanmakuConfig(ByteBuffer _bb, ILiveStartInteractDanmakuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032580 RID: 206208 RVA: 0x006CE9F5 File Offset: 0x006CCBF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032581 RID: 206209 RVA: 0x006CEA04 File Offset: 0x006CCC04
		public ILiveStartInteractDanmakuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D42A RID: 54314
		// (get) Token: 0x06032582 RID: 206210 RVA: 0x006CEA14 File Offset: 0x006CCC14
		public ELiveDanmakuOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return (ELiveDanmakuOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032583 RID: 206211 RVA: 0x006CEA50 File Offset: 0x006CCC50
		public ILiveInteractDanmakuListenerGroup? ListenerGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILiveInteractDanmakuListenerGroup?(default(ILiveInteractDanmakuListenerGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D42B RID: 54315
		// (get) Token: 0x06032584 RID: 206212 RVA: 0x006CEAB0 File Offset: 0x006CCCB0
		public int ListenerGroupsLength
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

		// Token: 0x06032585 RID: 206213 RVA: 0x006CEADB File Offset: 0x006CCCDB
		public static Offset<ILiveStartInteractDanmakuConfig> CreateILiveStartInteractDanmakuConfig(FlatBufferBuilder builder, ELiveDanmakuOperationType Type = ELiveDanmakuOperationType.Load, VectorOffset ListenerGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILiveStartInteractDanmakuConfig.AddListenerGroups(builder, ListenerGroupsOffset);
			ILiveStartInteractDanmakuConfig.AddType(builder, Type);
			return ILiveStartInteractDanmakuConfig.EndILiveStartInteractDanmakuConfig(builder);
		}

		// Token: 0x06032586 RID: 206214 RVA: 0x006CEAF8 File Offset: 0x006CCCF8
		public static void StartILiveStartInteractDanmakuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032587 RID: 206215 RVA: 0x006CEB01 File Offset: 0x006CCD01
		public static void AddType(FlatBufferBuilder builder, ELiveDanmakuOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032588 RID: 206216 RVA: 0x006CEB0C File Offset: 0x006CCD0C
		public static void AddListenerGroups(FlatBufferBuilder builder, VectorOffset listenerGroupsOffset)
		{
			builder.AddOffset(1, listenerGroupsOffset.Value, 0);
		}

		// Token: 0x06032589 RID: 206217 RVA: 0x006CEB1C File Offset: 0x006CCD1C
		public static VectorOffset CreateListenerGroupsVector(FlatBufferBuilder builder, Offset<ILiveInteractDanmakuListenerGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603258A RID: 206218 RVA: 0x006CEB5C File Offset: 0x006CCD5C
		public static VectorOffset CreateListenerGroupsVectorBlock(FlatBufferBuilder builder, Offset<ILiveInteractDanmakuListenerGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILiveInteractDanmakuListenerGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603258B RID: 206219 RVA: 0x006CEB76 File Offset: 0x006CCD76
		public static VectorOffset CreateListenerGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILiveInteractDanmakuListenerGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILiveInteractDanmakuListenerGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603258C RID: 206220 RVA: 0x006CEB94 File Offset: 0x006CCD94
		public static VectorOffset CreateListenerGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILiveInteractDanmakuListenerGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603258D RID: 206221 RVA: 0x006CEBAD File Offset: 0x006CCDAD
		public static void StartListenerGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603258E RID: 206222 RVA: 0x006CEBB8 File Offset: 0x006CCDB8
		public static Offset<ILiveStartInteractDanmakuConfig> EndILiveStartInteractDanmakuConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveStartInteractDanmakuConfig>(builder.EndTable());
		}

		// Token: 0x0603258F RID: 206223 RVA: 0x006CEBC8 File Offset: 0x006CCDC8
		public ILiveStartInteractDanmakuConfigT UnPack()
		{
			ILiveStartInteractDanmakuConfigT liveStartInteractDanmakuConfigT = new ILiveStartInteractDanmakuConfigT();
			this.UnPackTo(liveStartInteractDanmakuConfigT);
			return liveStartInteractDanmakuConfigT;
		}

		// Token: 0x06032590 RID: 206224 RVA: 0x006CEBE4 File Offset: 0x006CCDE4
		public void UnPackTo(ILiveStartInteractDanmakuConfigT _o)
		{
			_o.Type = this.Type;
			_o.ListenerGroups = new List<ILiveInteractDanmakuListenerGroupT>();
			for (int i = 0; i < this.ListenerGroupsLength; i++)
			{
				_o.ListenerGroups.Add((this.ListenerGroups(i) != null) ? this.ListenerGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032591 RID: 206225 RVA: 0x006CEC50 File Offset: 0x006CCE50
		public static Offset<ILiveStartInteractDanmakuConfig> Pack(FlatBufferBuilder builder, ILiveStartInteractDanmakuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveStartInteractDanmakuConfig>);
			}
			VectorOffset listenerGroupsOffset = default(VectorOffset);
			if (_o.ListenerGroups != null)
			{
				Offset<ILiveInteractDanmakuListenerGroup>[] array = new Offset<ILiveInteractDanmakuListenerGroup>[_o.ListenerGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILiveInteractDanmakuListenerGroup.Pack(builder, _o.ListenerGroups[i]);
				}
				listenerGroupsOffset = ILiveStartInteractDanmakuConfig.CreateListenerGroupsVector(builder, array);
			}
			return ILiveStartInteractDanmakuConfig.CreateILiveStartInteractDanmakuConfig(builder, _o.Type, listenerGroupsOffset);
		}

		// Token: 0x04012117 RID: 74007
		private Table __p;
	}
}
