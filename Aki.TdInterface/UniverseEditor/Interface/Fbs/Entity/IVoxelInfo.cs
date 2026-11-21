using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C58 RID: 19544
	public struct IVoxelInfo : IFlatbufferObject
	{
		// Token: 0x17008AA6 RID: 35494
		// (get) Token: 0x0601DFB7 RID: 122807 RVA: 0x0043420E File Offset: 0x0043240E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFB8 RID: 122808 RVA: 0x0043421B File Offset: 0x0043241B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFB9 RID: 122809 RVA: 0x00434224 File Offset: 0x00432424
		public static IVoxelInfo GetRootAsIVoxelInfo(ByteBuffer _bb)
		{
			return IVoxelInfo.GetRootAsIVoxelInfo(_bb, default(IVoxelInfo));
		}

		// Token: 0x0601DFBA RID: 122810 RVA: 0x00434240 File Offset: 0x00432440
		public static IVoxelInfo GetRootAsIVoxelInfo(ByteBuffer _bb, IVoxelInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFBB RID: 122811 RVA: 0x0043425D File Offset: 0x0043245D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFBC RID: 122812 RVA: 0x0043426C File Offset: 0x0043246C
		public IVoxelInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AA7 RID: 35495
		// (get) Token: 0x0601DFBD RID: 122813 RVA: 0x0043427C File Offset: 0x0043247C
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

		// Token: 0x0601DFBE RID: 122814 RVA: 0x004342B8 File Offset: 0x004324B8
		public static Offset<IVoxelInfo> CreateIVoxelInfo(FlatBufferBuilder builder, int EnvType = 0)
		{
			builder.StartTable(1);
			IVoxelInfo.AddEnvType(builder, EnvType);
			return IVoxelInfo.EndIVoxelInfo(builder);
		}

		// Token: 0x0601DFBF RID: 122815 RVA: 0x004342CE File Offset: 0x004324CE
		public static void StartIVoxelInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DFC0 RID: 122816 RVA: 0x004342D7 File Offset: 0x004324D7
		public static void AddEnvType(FlatBufferBuilder builder, int envType)
		{
			builder.AddInt(0, envType, 0);
		}

		// Token: 0x0601DFC1 RID: 122817 RVA: 0x004342E2 File Offset: 0x004324E2
		public static Offset<IVoxelInfo> EndIVoxelInfo(FlatBufferBuilder builder)
		{
			return new Offset<IVoxelInfo>(builder.EndTable());
		}

		// Token: 0x0601DFC2 RID: 122818 RVA: 0x004342F0 File Offset: 0x004324F0
		public IVoxelInfoT UnPack()
		{
			IVoxelInfoT voxelInfoT = new IVoxelInfoT();
			this.UnPackTo(voxelInfoT);
			return voxelInfoT;
		}

		// Token: 0x0601DFC3 RID: 122819 RVA: 0x0043430B File Offset: 0x0043250B
		public void UnPackTo(IVoxelInfoT _o)
		{
			_o.EnvType = this.EnvType;
		}

		// Token: 0x0601DFC4 RID: 122820 RVA: 0x0043431C File Offset: 0x0043251C
		public static Offset<IVoxelInfo> Pack(FlatBufferBuilder builder, IVoxelInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVoxelInfo>);
			}
			return IVoxelInfo.CreateIVoxelInfo(builder, _o.EnvType);
		}

		// Token: 0x0400D6C3 RID: 54979
		private Table __p;
	}
}
