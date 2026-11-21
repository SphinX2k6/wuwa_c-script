using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001188 RID: 4488
	public struct SceneItemAttribute : IFlatbufferObject
	{
		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600D76B RID: 55147 RVA: 0x00329644 File Offset: 0x00327844
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x00329651 File Offset: 0x00327851
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x00329658 File Offset: 0x00327858
		public static SceneItemAttribute GetRootAsSceneItemAttribute(ByteBuffer _bb)
		{
			return SceneItemAttribute.GetRootAsSceneItemAttribute(_bb, default(SceneItemAttribute));
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x00329674 File Offset: 0x00327874
		public static SceneItemAttribute GetRootAsSceneItemAttribute(ByteBuffer _bb, SceneItemAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x00329691 File Offset: 0x00327891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D770 RID: 55152 RVA: 0x003296A0 File Offset: 0x003278A0
		public SceneItemAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600D771 RID: 55153 RVA: 0x003296B0 File Offset: 0x003278B0
		public string Description
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D772 RID: 55154 RVA: 0x003296E7 File Offset: 0x003278E7
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D773 RID: 55155 RVA: 0x003296F6 File Offset: 0x003278F6
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600D774 RID: 55156 RVA: 0x00329710 File Offset: 0x00327910
		public int CreatorId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005799 RID: 22425
		private Table __p;
	}
}
