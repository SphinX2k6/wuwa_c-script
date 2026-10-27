using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5B RID: 3931
	public struct ProjectorPattern : IFlatbufferObject
	{
		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0600B380 RID: 45952 RVA: 0x002CBA25 File Offset: 0x002C9C25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x002CBA32 File Offset: 0x002C9C32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x002CBA3C File Offset: 0x002C9C3C
		public static ProjectorPattern GetRootAsProjectorPattern(ByteBuffer _bb)
		{
			return ProjectorPattern.GetRootAsProjectorPattern(_bb, default(ProjectorPattern));
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x002CBA58 File Offset: 0x002C9C58
		public static ProjectorPattern GetRootAsProjectorPattern(ByteBuffer _bb, ProjectorPattern obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x002CBA75 File Offset: 0x002C9C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x002CBA84 File Offset: 0x002C9C84
		public ProjectorPattern __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x002CBA94 File Offset: 0x002C9C94
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

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600B387 RID: 45959 RVA: 0x002CBAD0 File Offset: 0x002C9CD0
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

		// Token: 0x0600B388 RID: 45960 RVA: 0x002CBB07 File Offset: 0x002C9D07
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x002CBB16 File Offset: 0x002C9D16
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600B38A RID: 45962 RVA: 0x002CBB30 File Offset: 0x002C9D30
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

		// Token: 0x0600B38B RID: 45963 RVA: 0x002CBB67 File Offset: 0x002C9D67
		public Span<byte> GetProjectedMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x002CBB76 File Offset: 0x002C9D76
		public byte[] GetProjectedMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600B38D RID: 45965 RVA: 0x002CBB90 File Offset: 0x002C9D90
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

		// Token: 0x0600B38E RID: 45966 RVA: 0x002CBBC8 File Offset: 0x002C9DC8
		public Span<byte> GetBackgroundDecalPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B38F RID: 45967 RVA: 0x002CBBD8 File Offset: 0x002C9DD8
		public byte[] GetBackgroundDecalPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005028 RID: 20520
		private Table __p;
	}
}
