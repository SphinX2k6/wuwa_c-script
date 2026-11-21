using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120B RID: 4619
	public struct SolarSchoolViewInfo : IFlatbufferObject
	{
		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600E46C RID: 58476 RVA: 0x00347CA8 File Offset: 0x00345EA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x00347CB5 File Offset: 0x00345EB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x00347CBC File Offset: 0x00345EBC
		public static SolarSchoolViewInfo GetRootAsSolarSchoolViewInfo(ByteBuffer _bb)
		{
			return SolarSchoolViewInfo.GetRootAsSolarSchoolViewInfo(_bb, default(SolarSchoolViewInfo));
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x00347CD8 File Offset: 0x00345ED8
		public static SolarSchoolViewInfo GetRootAsSolarSchoolViewInfo(ByteBuffer _bb, SolarSchoolViewInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E470 RID: 58480 RVA: 0x00347CF5 File Offset: 0x00345EF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x00347D04 File Offset: 0x00345F04
		public SolarSchoolViewInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600E472 RID: 58482 RVA: 0x00347D14 File Offset: 0x00345F14
		public string ViewName
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

		// Token: 0x0600E473 RID: 58483 RVA: 0x00347D4B File Offset: 0x00345F4B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x00347D5A File Offset: 0x00345F5A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600E475 RID: 58485 RVA: 0x00347D74 File Offset: 0x00345F74
		public int ActivityId
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

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600E476 RID: 58486 RVA: 0x00347DB0 File Offset: 0x00345FB0
		public bool IsChildView
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600E477 RID: 58487 RVA: 0x00347DF0 File Offset: 0x00345FF0
		public bool AllowTip
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x00347E30 File Offset: 0x00346030
		public string AudioState
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

		// Token: 0x0600E479 RID: 58489 RVA: 0x00347E68 File Offset: 0x00346068
		public Span<byte> GetAudioStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00347E78 File Offset: 0x00346078
		public byte[] GetAudioStateArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400584B RID: 22603
		private Table __p;
	}
}
