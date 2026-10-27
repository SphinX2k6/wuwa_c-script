using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004886 RID: 18566
	public struct ILevelPlaySyncBlockContext : IFlatbufferObject
	{
		// Token: 0x170086A4 RID: 34468
		// (get) Token: 0x0601CF56 RID: 118614 RVA: 0x004178C8 File Offset: 0x00415AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF57 RID: 118615 RVA: 0x004178D5 File Offset: 0x00415AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF58 RID: 118616 RVA: 0x004178DC File Offset: 0x00415ADC
		public static ILevelPlaySyncBlockContext GetRootAsILevelPlaySyncBlockContext(ByteBuffer _bb)
		{
			return ILevelPlaySyncBlockContext.GetRootAsILevelPlaySyncBlockContext(_bb, default(ILevelPlaySyncBlockContext));
		}

		// Token: 0x0601CF59 RID: 118617 RVA: 0x004178F8 File Offset: 0x00415AF8
		public static ILevelPlaySyncBlockContext GetRootAsILevelPlaySyncBlockContext(ByteBuffer _bb, ILevelPlaySyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF5A RID: 118618 RVA: 0x00417915 File Offset: 0x00415B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF5B RID: 118619 RVA: 0x00417924 File Offset: 0x00415B24
		public ILevelPlaySyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086A5 RID: 34469
		// (get) Token: 0x0601CF5C RID: 118620 RVA: 0x00417934 File Offset: 0x00415B34
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

		// Token: 0x0601CF5D RID: 118621 RVA: 0x00417970 File Offset: 0x00415B70
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170086A6 RID: 34470
		// (get) Token: 0x0601CF5E RID: 118622 RVA: 0x004179D0 File Offset: 0x00415BD0
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

		// Token: 0x0601CF5F RID: 118623 RVA: 0x004179FB File Offset: 0x00415BFB
		public static Offset<ILevelPlaySyncBlockContext> CreateILevelPlaySyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlaySyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			ILevelPlaySyncBlockContext.AddType(builder, Type);
			return ILevelPlaySyncBlockContext.EndILevelPlaySyncBlockContext(builder);
		}

		// Token: 0x0601CF60 RID: 118624 RVA: 0x00417A18 File Offset: 0x00415C18
		public static void StartILevelPlaySyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CF61 RID: 118625 RVA: 0x00417A21 File Offset: 0x00415C21
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF62 RID: 118626 RVA: 0x00417A2C File Offset: 0x00415C2C
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601CF63 RID: 118627 RVA: 0x00417A3C File Offset: 0x00415C3C
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CF64 RID: 118628 RVA: 0x00417A7C File Offset: 0x00415C7C
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF65 RID: 118629 RVA: 0x00417A96 File Offset: 0x00415C96
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CF66 RID: 118630 RVA: 0x00417AB4 File Offset: 0x00415CB4
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CF67 RID: 118631 RVA: 0x00417ACD File Offset: 0x00415CCD
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CF68 RID: 118632 RVA: 0x00417AD8 File Offset: 0x00415CD8
		public static Offset<ILevelPlaySyncBlockContext> EndILevelPlaySyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlaySyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601CF69 RID: 118633 RVA: 0x00417AE8 File Offset: 0x00415CE8
		public ILevelPlaySyncBlockContextT UnPack()
		{
			ILevelPlaySyncBlockContextT levelPlaySyncBlockContextT = new ILevelPlaySyncBlockContextT();
			this.UnPackTo(levelPlaySyncBlockContextT);
			return levelPlaySyncBlockContextT;
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x00417B04 File Offset: 0x00415D04
		public void UnPackTo(ILevelPlaySyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x00417B70 File Offset: 0x00415D70
		public static Offset<ILevelPlaySyncBlockContext> Pack(FlatBufferBuilder builder, ILevelPlaySyncBlockContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlaySyncBlockContext>);
			}
			VectorOffset syncBlockGroupsOffset = default(VectorOffset);
			if (_o.SyncBlockGroups != null)
			{
				Offset<ISyncBlockGroup>[] array = new Offset<ISyncBlockGroup>[_o.SyncBlockGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISyncBlockGroup.Pack(builder, _o.SyncBlockGroups[i]);
				}
				syncBlockGroupsOffset = ILevelPlaySyncBlockContext.CreateSyncBlockGroupsVector(builder, array);
			}
			return ILevelPlaySyncBlockContext.CreateILevelPlaySyncBlockContext(builder, _o.Type, syncBlockGroupsOffset);
		}

		// Token: 0x0400CE6C RID: 52844
		private Table __p;
	}
}
