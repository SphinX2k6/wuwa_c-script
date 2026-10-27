using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EA RID: 4330
	public struct SpringFestivalRewardTab : IFlatbufferObject
	{
		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x003202D2 File Offset: 0x0031E4D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x003202DF File Offset: 0x0031E4DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x003202E8 File Offset: 0x0031E4E8
		public static SpringFestivalRewardTab GetRootAsSpringFestivalRewardTab(ByteBuffer _bb)
		{
			return SpringFestivalRewardTab.GetRootAsSpringFestivalRewardTab(_bb, default(SpringFestivalRewardTab));
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x00320304 File Offset: 0x0031E504
		public static SpringFestivalRewardTab GetRootAsSpringFestivalRewardTab(ByteBuffer _bb, SpringFestivalRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x00320321 File Offset: 0x0031E521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8DF RID: 55519 RVA: 0x00320330 File Offset: 0x0031E530
		public SpringFestivalRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600D8E0 RID: 55520 RVA: 0x00320340 File Offset: 0x0031E540
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

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x0032037C File Offset: 0x0031E57C
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

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600D8E2 RID: 55522 RVA: 0x003203B8 File Offset: 0x0031E5B8
		public string Name
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

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x003203EF File Offset: 0x0031E5EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x003203FE File Offset: 0x0031E5FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600D8E5 RID: 55525 RVA: 0x00320418 File Offset: 0x0031E618
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400521E RID: 21022
		private Table __p;
	}
}
