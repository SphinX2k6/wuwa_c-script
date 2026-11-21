using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001042 RID: 4162
	public struct ProjectorPattern : IFlatbufferObject
	{
		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x002E86D9 File Offset: 0x002E68D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x002E86E6 File Offset: 0x002E68E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9BF RID: 47551 RVA: 0x002E86F0 File Offset: 0x002E68F0
		public static ProjectorPattern GetRootAsProjectorPattern(ByteBuffer _bb)
		{
			return ProjectorPattern.GetRootAsProjectorPattern(_bb, default(ProjectorPattern));
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x002E870C File Offset: 0x002E690C
		public static ProjectorPattern GetRootAsProjectorPattern(ByteBuffer _bb, ProjectorPattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x002E8729 File Offset: 0x002E6929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x002E8738 File Offset: 0x002E6938
		public ProjectorPattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x002E8748 File Offset: 0x002E6948
		public int ProjectorPatternId
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

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x002E8784 File Offset: 0x002E6984
		public string Description
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x002E87BB File Offset: 0x002E69BB
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x002E87CA File Offset: 0x002E69CA
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x002E87E4 File Offset: 0x002E69E4
		public string ProjectedMeshPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x002E881B File Offset: 0x002E6A1B
		public Span<byte> GetProjectedMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x002E882A File Offset: 0x002E6A2A
		public byte[] GetProjectedMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600B9CA RID: 47562 RVA: 0x002E8844 File Offset: 0x002E6A44
		public string BackgroundDecalPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B9CB RID: 47563 RVA: 0x002E887C File Offset: 0x002E6A7C
		public Span<byte> GetBackgroundDecalPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B9CC RID: 47564 RVA: 0x002E888C File Offset: 0x002E6A8C
		public byte[] GetBackgroundDecalPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400560F RID: 22031
		private Table __p;
	}
}
