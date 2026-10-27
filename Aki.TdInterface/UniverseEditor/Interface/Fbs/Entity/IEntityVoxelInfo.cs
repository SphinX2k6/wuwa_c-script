using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047DE RID: 18398
	public struct IEntityVoxelInfo : IFlatbufferObject
	{
		// Token: 0x1700843B RID: 33851
		// (get) Token: 0x0601C718 RID: 116504 RVA: 0x0040643A File Offset: 0x0040463A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C719 RID: 116505 RVA: 0x00406447 File Offset: 0x00404647
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C71A RID: 116506 RVA: 0x00406450 File Offset: 0x00404650
		public static IEntityVoxelInfo GetRootAsIEntityVoxelInfo(ByteBuffer _bb)
		{
			return IEntityVoxelInfo.GetRootAsIEntityVoxelInfo(_bb, default(IEntityVoxelInfo));
		}

		// Token: 0x0601C71B RID: 116507 RVA: 0x0040646C File Offset: 0x0040466C
		public static IEntityVoxelInfo GetRootAsIEntityVoxelInfo(ByteBuffer _bb, IEntityVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C71C RID: 116508 RVA: 0x00406489 File Offset: 0x00404689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C71D RID: 116509 RVA: 0x00406498 File Offset: 0x00404698
		public IEntityVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700843C RID: 33852
		// (get) Token: 0x0601C71E RID: 116510 RVA: 0x004064A8 File Offset: 0x004046A8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700843D RID: 33853
		// (get) Token: 0x0601C71F RID: 116511 RVA: 0x004064E4 File Offset: 0x004046E4
		public IVoxelInfo? VoxelInfo
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVoxelInfo?(default(IVoxelInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C720 RID: 116512 RVA: 0x00406541 File Offset: 0x00404741
		public static Offset<IEntityVoxelInfo> CreateIEntityVoxelInfo(FlatBufferBuilder builder, int EntityId = 0, Offset<IVoxelInfo> VoxelInfoOffset = default(Offset<IVoxelInfo>))
		{
			builder.StartTable(2);
			IEntityVoxelInfo.AddVoxelInfo(builder, VoxelInfoOffset);
			IEntityVoxelInfo.AddEntityId(builder, EntityId);
			return IEntityVoxelInfo.EndIEntityVoxelInfo(builder);
		}

		// Token: 0x0601C721 RID: 116513 RVA: 0x0040655E File Offset: 0x0040475E
		public static void StartIEntityVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C722 RID: 116514 RVA: 0x00406567 File Offset: 0x00404767
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601C723 RID: 116515 RVA: 0x00406572 File Offset: 0x00404772
		public static void AddVoxelInfo(FlatBufferBuilder builder, Offset<IVoxelInfo> voxelInfoOffset)
		{
			builder.AddOffset(1, voxelInfoOffset.Value, 0);
		}

		// Token: 0x0601C724 RID: 116516 RVA: 0x00406582 File Offset: 0x00404782
		public static Offset<IEntityVoxelInfo> EndIEntityVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x00406590 File Offset: 0x00404790
		public IEntityVoxelInfoT UnPack()
		{
			IEntityVoxelInfoT entityVoxelInfoT = new IEntityVoxelInfoT();
			this.UnPackTo(entityVoxelInfoT);
			return entityVoxelInfoT;
		}

		// Token: 0x0601C726 RID: 116518 RVA: 0x004065AC File Offset: 0x004047AC
		public void UnPackTo(IEntityVoxelInfoT _o)
		{
			_o.EntityId = this.EntityId;
			_o.VoxelInfo = ((this.VoxelInfo != null) ? this.VoxelInfo.Value.UnPack() : null);
		}

		// Token: 0x0601C727 RID: 116519 RVA: 0x004065F4 File Offset: 0x004047F4
		public static Offset<IEntityVoxelInfo> Pack(FlatBufferBuilder builder, IEntityVoxelInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityVoxelInfo>);
			}
			Offset<IVoxelInfo> voxelInfoOffset = (_o.VoxelInfo == null) ? default(Offset<IVoxelInfo>) : IVoxelInfo.Pack(builder, _o.VoxelInfo);
			return IEntityVoxelInfo.CreateIEntityVoxelInfo(builder, _o.EntityId, voxelInfoOffset);
		}

		// Token: 0x0400CC75 RID: 52341
		private Table __p;
	}
}
