using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048AA RID: 18602
	public struct ISyncBlockContext : IFlatbufferObject
	{
		// Token: 0x170086E2 RID: 34530
		// (get) Token: 0x0601D096 RID: 118934 RVA: 0x00419C6B File Offset: 0x00417E6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D097 RID: 118935 RVA: 0x00419C78 File Offset: 0x00417E78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D098 RID: 118936 RVA: 0x00419C80 File Offset: 0x00417E80
		public static ISyncBlockContext GetRootAsISyncBlockContext(ByteBuffer _bb)
		{
			return ISyncBlockContext.GetRootAsISyncBlockContext(_bb, default(ISyncBlockContext));
		}

		// Token: 0x0601D099 RID: 118937 RVA: 0x00419C9C File Offset: 0x00417E9C
		public static ISyncBlockContext GetRootAsISyncBlockContext(ByteBuffer _bb, ISyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D09A RID: 118938 RVA: 0x00419CB9 File Offset: 0x00417EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D09B RID: 118939 RVA: 0x00419CC8 File Offset: 0x00417EC8
		public ISyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086E3 RID: 34531
		// (get) Token: 0x0601D09C RID: 118940 RVA: 0x00419CD8 File Offset: 0x00417ED8
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

		// Token: 0x0601D09D RID: 118941 RVA: 0x00419D14 File Offset: 0x00417F14
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170086E4 RID: 34532
		// (get) Token: 0x0601D09E RID: 118942 RVA: 0x00419D74 File Offset: 0x00417F74
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

		// Token: 0x0601D09F RID: 118943 RVA: 0x00419D9F File Offset: 0x00417F9F
		public static Offset<ISyncBlockContext> CreateISyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			ISyncBlockContext.AddType(builder, Type);
			return ISyncBlockContext.EndISyncBlockContext(builder);
		}

		// Token: 0x0601D0A0 RID: 118944 RVA: 0x00419DBC File Offset: 0x00417FBC
		public static void StartISyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x00419DC5 File Offset: 0x00417FC5
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0A2 RID: 118946 RVA: 0x00419DD0 File Offset: 0x00417FD0
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601D0A3 RID: 118947 RVA: 0x00419DE0 File Offset: 0x00417FE0
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D0A4 RID: 118948 RVA: 0x00419E20 File Offset: 0x00418020
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0A5 RID: 118949 RVA: 0x00419E3A File Offset: 0x0041803A
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0A6 RID: 118950 RVA: 0x00419E58 File Offset: 0x00418058
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x00419E71 File Offset: 0x00418071
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x00419E7C File Offset: 0x0041807C
		public static Offset<ISyncBlockContext> EndISyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601D0A9 RID: 118953 RVA: 0x00419E8C File Offset: 0x0041808C
		public ISyncBlockContextT UnPack()
		{
			ISyncBlockContextT syncBlockContextT = new ISyncBlockContextT();
			this.UnPackTo(syncBlockContextT);
			return syncBlockContextT;
		}

		// Token: 0x0601D0AA RID: 118954 RVA: 0x00419EA8 File Offset: 0x004180A8
		public void UnPackTo(ISyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D0AB RID: 118955 RVA: 0x00419F14 File Offset: 0x00418114
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

		// Token: 0x0400CE96 RID: 52886
		private Table __p;
	}
}
