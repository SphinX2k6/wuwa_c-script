using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108D RID: 4237
	public struct SceneItemAttribute : IFlatbufferObject
	{
		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x0030A050 File Offset: 0x00308250
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF99 RID: 53145 RVA: 0x0030A05D File Offset: 0x0030825D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF9A RID: 53146 RVA: 0x0030A064 File Offset: 0x00308264
		public static SceneItemAttribute GetRootAsSceneItemAttribute(ByteBuffer _bb)
		{
			return SceneItemAttribute.GetRootAsSceneItemAttribute(_bb, default(SceneItemAttribute));
		}

		// Token: 0x0600CF9B RID: 53147 RVA: 0x0030A080 File Offset: 0x00308280
		public static SceneItemAttribute GetRootAsSceneItemAttribute(ByteBuffer _bb, SceneItemAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x0030A09D File Offset: 0x0030829D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF9D RID: 53149 RVA: 0x0030A0AC File Offset: 0x003082AC
		public SceneItemAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600CF9E RID: 53150 RVA: 0x0030A0BC File Offset: 0x003082BC
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

		// Token: 0x0600CF9F RID: 53151 RVA: 0x0030A0F3 File Offset: 0x003082F3
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x0030A102 File Offset: 0x00308302
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600CFA1 RID: 53153 RVA: 0x0030A11C File Offset: 0x0030831C
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

		// Token: 0x0400519A RID: 20890
		private Table __p;
	}
}
