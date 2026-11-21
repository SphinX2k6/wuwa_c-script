using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D03 RID: 19715
	public struct IQuestSyncBlockContext : IFlatbufferObject
	{
		// Token: 0x17008D18 RID: 36120
		// (get) Token: 0x0601E81D RID: 124957 RVA: 0x0044594A File Offset: 0x00443B4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E81E RID: 124958 RVA: 0x00445957 File Offset: 0x00443B57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E81F RID: 124959 RVA: 0x00445960 File Offset: 0x00443B60
		public static IQuestSyncBlockContext GetRootAsIQuestSyncBlockContext(ByteBuffer _bb)
		{
			return IQuestSyncBlockContext.GetRootAsIQuestSyncBlockContext(_bb, default(IQuestSyncBlockContext));
		}

		// Token: 0x0601E820 RID: 124960 RVA: 0x0044597C File Offset: 0x00443B7C
		public static IQuestSyncBlockContext GetRootAsIQuestSyncBlockContext(ByteBuffer _bb, IQuestSyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E821 RID: 124961 RVA: 0x00445999 File Offset: 0x00443B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E822 RID: 124962 RVA: 0x004459A8 File Offset: 0x00443BA8
		public IQuestSyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D19 RID: 36121
		// (get) Token: 0x0601E823 RID: 124963 RVA: 0x004459B8 File Offset: 0x00443BB8
		public ESyncBlockContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESyncBlockContext.Quest;
				}
				return (ESyncBlockContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E824 RID: 124964 RVA: 0x004459F4 File Offset: 0x00443BF4
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D1A RID: 36122
		// (get) Token: 0x0601E825 RID: 124965 RVA: 0x00445A54 File Offset: 0x00443C54
		public int SyncBlockGroupsLength
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

		// Token: 0x0601E826 RID: 124966 RVA: 0x00445A7F File Offset: 0x00443C7F
		public static Offset<IQuestSyncBlockContext> CreateIQuestSyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestSyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			IQuestSyncBlockContext.AddType(builder, Type);
			return IQuestSyncBlockContext.EndIQuestSyncBlockContext(builder);
		}

		// Token: 0x0601E827 RID: 124967 RVA: 0x00445A9C File Offset: 0x00443C9C
		public static void StartIQuestSyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E828 RID: 124968 RVA: 0x00445AA5 File Offset: 0x00443CA5
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E829 RID: 124969 RVA: 0x00445AB0 File Offset: 0x00443CB0
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601E82A RID: 124970 RVA: 0x00445AC0 File Offset: 0x00443CC0
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E82B RID: 124971 RVA: 0x00445B00 File Offset: 0x00443D00
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E82C RID: 124972 RVA: 0x00445B1A File Offset: 0x00443D1A
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E82D RID: 124973 RVA: 0x00445B38 File Offset: 0x00443D38
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E82E RID: 124974 RVA: 0x00445B51 File Offset: 0x00443D51
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E82F RID: 124975 RVA: 0x00445B5C File Offset: 0x00443D5C
		public static Offset<IQuestSyncBlockContext> EndIQuestSyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestSyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601E830 RID: 124976 RVA: 0x00445B6C File Offset: 0x00443D6C
		public IQuestSyncBlockContextT UnPack()
		{
			IQuestSyncBlockContextT questSyncBlockContextT = new IQuestSyncBlockContextT();
			this.UnPackTo(questSyncBlockContextT);
			return questSyncBlockContextT;
		}

		// Token: 0x0601E831 RID: 124977 RVA: 0x00445B88 File Offset: 0x00443D88
		public void UnPackTo(IQuestSyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E832 RID: 124978 RVA: 0x00445BF4 File Offset: 0x00443DF4
		public static Offset<IQuestSyncBlockContext> Pack(FlatBufferBuilder builder, IQuestSyncBlockContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestSyncBlockContext>);
			}
			VectorOffset syncBlockGroupsOffset = default(VectorOffset);
			if (_o.SyncBlockGroups != null)
			{
				Offset<ISyncBlockGroup>[] array = new Offset<ISyncBlockGroup>[_o.SyncBlockGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISyncBlockGroup.Pack(builder, _o.SyncBlockGroups[i]);
				}
				syncBlockGroupsOffset = IQuestSyncBlockContext.CreateSyncBlockGroupsVector(builder, array);
			}
			return IQuestSyncBlockContext.CreateIQuestSyncBlockContext(builder, _o.Type, syncBlockGroupsOffset);
		}

		// Token: 0x0400D8C4 RID: 55492
		private Table __p;
	}
}
