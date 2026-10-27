using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA0 RID: 3232
	public struct FloroRanchAudio : IFlatbufferObject
	{
		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x00238C2D File Offset: 0x00236E2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00238C3A File Offset: 0x00236E3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00238C44 File Offset: 0x00236E44
		public static FloroRanchAudio GetRootAsFloroRanchAudio(ByteBuffer _bb)
		{
			return FloroRanchAudio.GetRootAsFloroRanchAudio(_bb, default(FloroRanchAudio));
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00238C60 File Offset: 0x00236E60
		public static FloroRanchAudio GetRootAsFloroRanchAudio(ByteBuffer _bb, FloroRanchAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00238C7D File Offset: 0x00236E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00238C8C File Offset: 0x00236E8C
		public FloroRanchAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x00238C9C File Offset: 0x00236E9C
		public int Id
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

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600726A RID: 29290 RVA: 0x00238CD8 File Offset: 0x00236ED8
		public int CharacterType
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x00238D14 File Offset: 0x00236F14
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600726C RID: 29292 RVA: 0x00238D50 File Offset: 0x00236F50
		public string Text
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

		// Token: 0x0600726D RID: 29293 RVA: 0x00238D88 File Offset: 0x00236F88
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00238D98 File Offset: 0x00236F98
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600726F RID: 29295 RVA: 0x00238DB0 File Offset: 0x00236FB0
		public string AudioEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00238DE8 File Offset: 0x00236FE8
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00238DF8 File Offset: 0x00236FF8
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CFE RID: 19710
		private Table __p;
	}
}
