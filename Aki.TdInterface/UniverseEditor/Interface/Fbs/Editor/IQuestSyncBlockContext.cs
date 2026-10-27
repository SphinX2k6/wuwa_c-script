using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200489E RID: 18590
	public struct IQuestSyncBlockContext : IFlatbufferObject
	{
		// Token: 0x170086D0 RID: 34512
		// (get) Token: 0x0601D030 RID: 118832 RVA: 0x004191AE File Offset: 0x004173AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D031 RID: 118833 RVA: 0x004191BB File Offset: 0x004173BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D032 RID: 118834 RVA: 0x004191C4 File Offset: 0x004173C4
		public static IQuestSyncBlockContext GetRootAsIQuestSyncBlockContext(ByteBuffer _bb)
		{
			return IQuestSyncBlockContext.GetRootAsIQuestSyncBlockContext(_bb, default(IQuestSyncBlockContext));
		}

		// Token: 0x0601D033 RID: 118835 RVA: 0x004191E0 File Offset: 0x004173E0
		public static IQuestSyncBlockContext GetRootAsIQuestSyncBlockContext(ByteBuffer _bb, IQuestSyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D034 RID: 118836 RVA: 0x004191FD File Offset: 0x004173FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x0041920C File Offset: 0x0041740C
		public IQuestSyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086D1 RID: 34513
		// (get) Token: 0x0601D036 RID: 118838 RVA: 0x0041921C File Offset: 0x0041741C
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

		// Token: 0x0601D037 RID: 118839 RVA: 0x00419258 File Offset: 0x00417458
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170086D2 RID: 34514
		// (get) Token: 0x0601D038 RID: 118840 RVA: 0x004192B8 File Offset: 0x004174B8
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

		// Token: 0x0601D039 RID: 118841 RVA: 0x004192E3 File Offset: 0x004174E3
		public static Offset<IQuestSyncBlockContext> CreateIQuestSyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestSyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			IQuestSyncBlockContext.AddType(builder, Type);
			return IQuestSyncBlockContext.EndIQuestSyncBlockContext(builder);
		}

		// Token: 0x0601D03A RID: 118842 RVA: 0x00419300 File Offset: 0x00417500
		public static void StartIQuestSyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D03B RID: 118843 RVA: 0x00419309 File Offset: 0x00417509
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D03C RID: 118844 RVA: 0x00419314 File Offset: 0x00417514
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601D03D RID: 118845 RVA: 0x00419324 File Offset: 0x00417524
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D03E RID: 118846 RVA: 0x00419364 File Offset: 0x00417564
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D03F RID: 118847 RVA: 0x0041937E File Offset: 0x0041757E
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D040 RID: 118848 RVA: 0x0041939C File Offset: 0x0041759C
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D041 RID: 118849 RVA: 0x004193B5 File Offset: 0x004175B5
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D042 RID: 118850 RVA: 0x004193C0 File Offset: 0x004175C0
		public static Offset<IQuestSyncBlockContext> EndIQuestSyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestSyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601D043 RID: 118851 RVA: 0x004193D0 File Offset: 0x004175D0
		public IQuestSyncBlockContextT UnPack()
		{
			IQuestSyncBlockContextT questSyncBlockContextT = new IQuestSyncBlockContextT();
			this.UnPackTo(questSyncBlockContextT);
			return questSyncBlockContextT;
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x004193EC File Offset: 0x004175EC
		public void UnPackTo(IQuestSyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D045 RID: 118853 RVA: 0x00419458 File Offset: 0x00417658
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

		// Token: 0x0400CE8B RID: 52875
		private Table __p;
	}
}
