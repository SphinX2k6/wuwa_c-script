using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F0 RID: 18416
	public struct IVoxelInfo : IFlatbufferObject
	{
		// Token: 0x1700845B RID: 33883
		// (get) Token: 0x0601C7BA RID: 116666 RVA: 0x004078BE File Offset: 0x00405ABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7BB RID: 116667 RVA: 0x004078CB File Offset: 0x00405ACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7BC RID: 116668 RVA: 0x004078D4 File Offset: 0x00405AD4
		public static IVoxelInfo GetRootAsIVoxelInfo(ByteBuffer _bb)
		{
			return IVoxelInfo.GetRootAsIVoxelInfo(_bb, default(IVoxelInfo));
		}

		// Token: 0x0601C7BD RID: 116669 RVA: 0x004078F0 File Offset: 0x00405AF0
		public static IVoxelInfo GetRootAsIVoxelInfo(ByteBuffer _bb, IVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7BE RID: 116670 RVA: 0x0040790D File Offset: 0x00405B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7BF RID: 116671 RVA: 0x0040791C File Offset: 0x00405B1C
		public IVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700845C RID: 33884
		// (get) Token: 0x0601C7C0 RID: 116672 RVA: 0x0040792C File Offset: 0x00405B2C
		public int EnvType
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

		// Token: 0x0601C7C1 RID: 116673 RVA: 0x00407968 File Offset: 0x00405B68
		public static Offset<IVoxelInfo> CreateIVoxelInfo(FlatBufferBuilder builder, int EnvType = 0)
		{
			builder.StartTable(1);
			IVoxelInfo.AddEnvType(builder, EnvType);
			return IVoxelInfo.EndIVoxelInfo(builder);
		}

		// Token: 0x0601C7C2 RID: 116674 RVA: 0x0040797E File Offset: 0x00405B7E
		public static void StartIVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C7C3 RID: 116675 RVA: 0x00407987 File Offset: 0x00405B87
		public static void AddEnvType(FlatBufferBuilder builder, int envType)
		{
			builder.AddInt(0, envType, 0);
		}

		// Token: 0x0601C7C4 RID: 116676 RVA: 0x00407992 File Offset: 0x00405B92
		public static Offset<IVoxelInfo> EndIVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<IVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601C7C5 RID: 116677 RVA: 0x004079A0 File Offset: 0x00405BA0
		public IVoxelInfoT UnPack()
		{
			IVoxelInfoT voxelInfoT = new IVoxelInfoT();
			this.UnPackTo(voxelInfoT);
			return voxelInfoT;
		}

		// Token: 0x0601C7C6 RID: 116678 RVA: 0x004079BB File Offset: 0x00405BBB
		public void UnPackTo(IVoxelInfoT _o)
		{
			_o.EnvType = this.EnvType;
		}

		// Token: 0x0601C7C7 RID: 116679 RVA: 0x004079CC File Offset: 0x00405BCC
		public static Offset<IVoxelInfo> Pack(FlatBufferBuilder builder, IVoxelInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVoxelInfo>);
			}
			return IVoxelInfo.CreateIVoxelInfo(builder, _o.EnvType);
		}

		// Token: 0x0400CC88 RID: 52360
		private Table __p;
	}
}
