using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C46 RID: 19526
	public struct IEntityVoxelInfo : IFlatbufferObject
	{
		// Token: 0x17008A86 RID: 35462
		// (get) Token: 0x0601DF15 RID: 122645 RVA: 0x00432D8A File Offset: 0x00430F8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF16 RID: 122646 RVA: 0x00432D97 File Offset: 0x00430F97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF17 RID: 122647 RVA: 0x00432DA0 File Offset: 0x00430FA0
		public static IEntityVoxelInfo GetRootAsIEntityVoxelInfo(ByteBuffer _bb)
		{
			return IEntityVoxelInfo.GetRootAsIEntityVoxelInfo(_bb, default(IEntityVoxelInfo));
		}

		// Token: 0x0601DF18 RID: 122648 RVA: 0x00432DBC File Offset: 0x00430FBC
		public static IEntityVoxelInfo GetRootAsIEntityVoxelInfo(ByteBuffer _bb, IEntityVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF19 RID: 122649 RVA: 0x00432DD9 File Offset: 0x00430FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF1A RID: 122650 RVA: 0x00432DE8 File Offset: 0x00430FE8
		public IEntityVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A87 RID: 35463
		// (get) Token: 0x0601DF1B RID: 122651 RVA: 0x00432DF8 File Offset: 0x00430FF8
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

		// Token: 0x17008A88 RID: 35464
		// (get) Token: 0x0601DF1C RID: 122652 RVA: 0x00432E34 File Offset: 0x00431034
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

		// Token: 0x0601DF1D RID: 122653 RVA: 0x00432E91 File Offset: 0x00431091
		public static Offset<IEntityVoxelInfo> CreateIEntityVoxelInfo(FlatBufferBuilder builder, int EntityId = 0, Offset<IVoxelInfo> VoxelInfoOffset = default(Offset<IVoxelInfo>))
		{
			builder.StartTable(2);
			IEntityVoxelInfo.AddVoxelInfo(builder, VoxelInfoOffset);
			IEntityVoxelInfo.AddEntityId(builder, EntityId);
			return IEntityVoxelInfo.EndIEntityVoxelInfo(builder);
		}

		// Token: 0x0601DF1E RID: 122654 RVA: 0x00432EAE File Offset: 0x004310AE
		public static void StartIEntityVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF1F RID: 122655 RVA: 0x00432EB7 File Offset: 0x004310B7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601DF20 RID: 122656 RVA: 0x00432EC2 File Offset: 0x004310C2
		public static void AddVoxelInfo(FlatBufferBuilder builder, Offset<IVoxelInfo> voxelInfoOffset)
		{
			builder.AddOffset(1, voxelInfoOffset.Value, 0);
		}

		// Token: 0x0601DF21 RID: 122657 RVA: 0x00432ED2 File Offset: 0x004310D2
		public static Offset<IEntityVoxelInfo> EndIEntityVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601DF22 RID: 122658 RVA: 0x00432EE0 File Offset: 0x004310E0
		public IEntityVoxelInfoT UnPack()
		{
			IEntityVoxelInfoT entityVoxelInfoT = new IEntityVoxelInfoT();
			this.UnPackTo(entityVoxelInfoT);
			return entityVoxelInfoT;
		}

		// Token: 0x0601DF23 RID: 122659 RVA: 0x00432EFC File Offset: 0x004310FC
		public void UnPackTo(IEntityVoxelInfoT _o)
		{
			_o.EntityId = this.EntityId;
			_o.VoxelInfo = ((this.VoxelInfo != null) ? this.VoxelInfo.Value.UnPack() : null);
		}

		// Token: 0x0601DF24 RID: 122660 RVA: 0x00432F44 File Offset: 0x00431144
		public static Offset<IEntityVoxelInfo> Pack(FlatBufferBuilder builder, IEntityVoxelInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityVoxelInfo>);
			}
			Offset<IVoxelInfo> voxelInfoOffset = (_o.VoxelInfo == null) ? default(Offset<IVoxelInfo>) : IVoxelInfo.Pack(builder, _o.VoxelInfo);
			return IEntityVoxelInfo.CreateIEntityVoxelInfo(builder, _o.EntityId, voxelInfoOffset);
		}

		// Token: 0x0400D6B0 RID: 54960
		private Table __p;
	}
}
