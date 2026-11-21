using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D0F RID: 19727
	public struct ISyncBlockContext : IFlatbufferObject
	{
		// Token: 0x17008D2A RID: 36138
		// (get) Token: 0x0601E883 RID: 125059 RVA: 0x00446407 File Offset: 0x00444607
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E884 RID: 125060 RVA: 0x00446414 File Offset: 0x00444614
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E885 RID: 125061 RVA: 0x0044641C File Offset: 0x0044461C
		public static ISyncBlockContext GetRootAsISyncBlockContext(ByteBuffer _bb)
		{
			return ISyncBlockContext.GetRootAsISyncBlockContext(_bb, default(ISyncBlockContext));
		}

		// Token: 0x0601E886 RID: 125062 RVA: 0x00446438 File Offset: 0x00444638
		public static ISyncBlockContext GetRootAsISyncBlockContext(ByteBuffer _bb, ISyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E887 RID: 125063 RVA: 0x00446455 File Offset: 0x00444655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E888 RID: 125064 RVA: 0x00446464 File Offset: 0x00444664
		public ISyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D2B RID: 36139
		// (get) Token: 0x0601E889 RID: 125065 RVA: 0x00446474 File Offset: 0x00444674
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

		// Token: 0x0601E88A RID: 125066 RVA: 0x004464B0 File Offset: 0x004446B0
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008D2C RID: 36140
		// (get) Token: 0x0601E88B RID: 125067 RVA: 0x00446510 File Offset: 0x00444710
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

		// Token: 0x0601E88C RID: 125068 RVA: 0x0044653B File Offset: 0x0044473B
		public static Offset<ISyncBlockContext> CreateISyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			ISyncBlockContext.AddType(builder, Type);
			return ISyncBlockContext.EndISyncBlockContext(builder);
		}

		// Token: 0x0601E88D RID: 125069 RVA: 0x00446558 File Offset: 0x00444758
		public static void StartISyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E88E RID: 125070 RVA: 0x00446561 File Offset: 0x00444761
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E88F RID: 125071 RVA: 0x0044656C File Offset: 0x0044476C
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601E890 RID: 125072 RVA: 0x0044657C File Offset: 0x0044477C
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E891 RID: 125073 RVA: 0x004465BC File Offset: 0x004447BC
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E892 RID: 125074 RVA: 0x004465D6 File Offset: 0x004447D6
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E893 RID: 125075 RVA: 0x004465F4 File Offset: 0x004447F4
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E894 RID: 125076 RVA: 0x0044660D File Offset: 0x0044480D
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E895 RID: 125077 RVA: 0x00446618 File Offset: 0x00444818
		public static Offset<ISyncBlockContext> EndISyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601E896 RID: 125078 RVA: 0x00446628 File Offset: 0x00444828
		public ISyncBlockContextT UnPack()
		{
			ISyncBlockContextT syncBlockContextT = new ISyncBlockContextT();
			this.UnPackTo(syncBlockContextT);
			return syncBlockContextT;
		}

		// Token: 0x0601E897 RID: 125079 RVA: 0x00446644 File Offset: 0x00444844
		public void UnPackTo(ISyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E898 RID: 125080 RVA: 0x004466B0 File Offset: 0x004448B0
		public static Offset<ISyncBlockContext> Pack(FlatBufferBuilder builder, ISyncBlockContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncBlockContext>);
			}
			VectorOffset syncBlockGroupsOffset = default(VectorOffset);
			if (_o.SyncBlockGroups != null)
			{
				Offset<ISyncBlockGroup>[] array = new Offset<ISyncBlockGroup>[_o.SyncBlockGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISyncBlockGroup.Pack(builder, _o.SyncBlockGroups[i]);
				}
				syncBlockGroupsOffset = ISyncBlockContext.CreateSyncBlockGroupsVector(builder, array);
			}
			return ISyncBlockContext.CreateISyncBlockContext(builder, _o.Type, syncBlockGroupsOffset);
		}

		// Token: 0x0400D8CF RID: 55503
		private Table __p;
	}
}
