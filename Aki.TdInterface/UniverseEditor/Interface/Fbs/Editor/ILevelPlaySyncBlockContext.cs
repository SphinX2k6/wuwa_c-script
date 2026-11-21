using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CEB RID: 19691
	public struct ILevelPlaySyncBlockContext : IFlatbufferObject
	{
		// Token: 0x17008CEC RID: 36076
		// (get) Token: 0x0601E743 RID: 124739 RVA: 0x00444064 File Offset: 0x00442264
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E744 RID: 124740 RVA: 0x00444071 File Offset: 0x00442271
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E745 RID: 124741 RVA: 0x00444078 File Offset: 0x00442278
		public static ILevelPlaySyncBlockContext GetRootAsILevelPlaySyncBlockContext(ByteBuffer _bb)
		{
			return ILevelPlaySyncBlockContext.GetRootAsILevelPlaySyncBlockContext(_bb, default(ILevelPlaySyncBlockContext));
		}

		// Token: 0x0601E746 RID: 124742 RVA: 0x00444094 File Offset: 0x00442294
		public static ILevelPlaySyncBlockContext GetRootAsILevelPlaySyncBlockContext(ByteBuffer _bb, ILevelPlaySyncBlockContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E747 RID: 124743 RVA: 0x004440B1 File Offset: 0x004422B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E748 RID: 124744 RVA: 0x004440C0 File Offset: 0x004422C0
		public ILevelPlaySyncBlockContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CED RID: 36077
		// (get) Token: 0x0601E749 RID: 124745 RVA: 0x004440D0 File Offset: 0x004422D0
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

		// Token: 0x0601E74A RID: 124746 RVA: 0x0044410C File Offset: 0x0044230C
		public ISyncBlockGroup? SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008CEE RID: 36078
		// (get) Token: 0x0601E74B RID: 124747 RVA: 0x0044416C File Offset: 0x0044236C
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

		// Token: 0x0601E74C RID: 124748 RVA: 0x00444197 File Offset: 0x00442397
		public static Offset<ILevelPlaySyncBlockContext> CreateILevelPlaySyncBlockContext(FlatBufferBuilder builder, ESyncBlockContext Type = ESyncBlockContext.Quest, VectorOffset SyncBlockGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlaySyncBlockContext.AddSyncBlockGroups(builder, SyncBlockGroupsOffset);
			ILevelPlaySyncBlockContext.AddType(builder, Type);
			return ILevelPlaySyncBlockContext.EndILevelPlaySyncBlockContext(builder);
		}

		// Token: 0x0601E74D RID: 124749 RVA: 0x004441B4 File Offset: 0x004423B4
		public static void StartILevelPlaySyncBlockContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E74E RID: 124750 RVA: 0x004441BD File Offset: 0x004423BD
		public static void AddType(FlatBufferBuilder builder, ESyncBlockContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E74F RID: 124751 RVA: 0x004441C8 File Offset: 0x004423C8
		public static void AddSyncBlockGroups(FlatBufferBuilder builder, VectorOffset syncBlockGroupsOffset)
		{
			builder.AddOffset(1, syncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601E750 RID: 124752 RVA: 0x004441D8 File Offset: 0x004423D8
		public static VectorOffset CreateSyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E751 RID: 124753 RVA: 0x00444218 File Offset: 0x00442418
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E752 RID: 124754 RVA: 0x00444232 File Offset: 0x00442432
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E753 RID: 124755 RVA: 0x00444250 File Offset: 0x00442450
		public static VectorOffset CreateSyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E754 RID: 124756 RVA: 0x00444269 File Offset: 0x00442469
		public static void StartSyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E755 RID: 124757 RVA: 0x00444274 File Offset: 0x00442474
		public static Offset<ILevelPlaySyncBlockContext> EndILevelPlaySyncBlockContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlaySyncBlockContext>(builder.EndTable());
		}

		// Token: 0x0601E756 RID: 124758 RVA: 0x00444284 File Offset: 0x00442484
		public ILevelPlaySyncBlockContextT UnPack()
		{
			ILevelPlaySyncBlockContextT levelPlaySyncBlockContextT = new ILevelPlaySyncBlockContextT();
			this.UnPackTo(levelPlaySyncBlockContextT);
			return levelPlaySyncBlockContextT;
		}

		// Token: 0x0601E757 RID: 124759 RVA: 0x004442A0 File Offset: 0x004424A0
		public void UnPackTo(ILevelPlaySyncBlockContextT _o)
		{
			_o.Type = this.Type;
			_o.SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int i = 0; i < this.SyncBlockGroupsLength; i++)
			{
				_o.SyncBlockGroups.Add((this.SyncBlockGroups(i) != null) ? this.SyncBlockGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E758 RID: 124760 RVA: 0x0044430C File Offset: 0x0044250C
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

		// Token: 0x0400D8A5 RID: 55461
		private Table __p;
	}
}
