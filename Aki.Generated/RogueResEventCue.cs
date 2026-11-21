using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EA RID: 4330
	public struct RogueResEventCue : IFlatbufferObject
	{
		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600C896 RID: 51350 RVA: 0x0030849D File Offset: 0x0030669D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x003084AA File Offset: 0x003066AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x003084B4 File Offset: 0x003066B4
		public static RogueResEventCue GetRootAsRogueResEventCue(ByteBuffer _bb)
		{
			return RogueResEventCue.GetRootAsRogueResEventCue(_bb, default(RogueResEventCue));
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x003084D0 File Offset: 0x003066D0
		public static RogueResEventCue GetRootAsRogueResEventCue(ByteBuffer _bb, RogueResEventCue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x003084ED File Offset: 0x003066ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x003084FC File Offset: 0x003066FC
		public RogueResEventCue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600C89C RID: 51356 RVA: 0x0030850C File Offset: 0x0030670C
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

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600C89D RID: 51357 RVA: 0x00308548 File Offset: 0x00306748
		public string Type
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

		// Token: 0x0600C89E RID: 51358 RVA: 0x0030857F File Offset: 0x0030677F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x0030858E File Offset: 0x0030678E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600C8A0 RID: 51360 RVA: 0x003085A8 File Offset: 0x003067A8
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600C8A1 RID: 51361 RVA: 0x003085E8 File Offset: 0x003067E8
		public string FxColor
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

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x00308620 File Offset: 0x00306820
		public Span<byte> GetFxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x00308630 File Offset: 0x00306830
		public byte[] GetFxColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600C8A4 RID: 51364 RVA: 0x00308648 File Offset: 0x00306848
		public string SpriteColor
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

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x00308680 File Offset: 0x00306880
		public Span<byte> GetSpriteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x00308690 File Offset: 0x00306890
		public byte[] GetSpriteColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x003086A8 File Offset: 0x003068A8
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x003086E0 File Offset: 0x003068E0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x003086F0 File Offset: 0x003068F0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040056D2 RID: 22226
		private Table __p;
	}
}
