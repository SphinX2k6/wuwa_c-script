using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E7 RID: 4327
	public struct RogueResEvent : IFlatbufferObject
	{
		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600C84C RID: 51276 RVA: 0x00307B71 File Offset: 0x00305D71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x00307B7E File Offset: 0x00305D7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x00307B88 File Offset: 0x00305D88
		public static RogueResEvent GetRootAsRogueResEvent(ByteBuffer _bb)
		{
			return RogueResEvent.GetRootAsRogueResEvent(_bb, default(RogueResEvent));
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x00307BA4 File Offset: 0x00305DA4
		public static RogueResEvent GetRootAsRogueResEvent(ByteBuffer _bb, RogueResEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x00307BC1 File Offset: 0x00305DC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x00307BD0 File Offset: 0x00305DD0
		public RogueResEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600C852 RID: 51282 RVA: 0x00307BE0 File Offset: 0x00305DE0
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

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600C853 RID: 51283 RVA: 0x00307C1C File Offset: 0x00305E1C
		public string TextId
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

		// Token: 0x0600C854 RID: 51284 RVA: 0x00307C53 File Offset: 0x00305E53
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C855 RID: 51285 RVA: 0x00307C62 File Offset: 0x00305E62
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600C856 RID: 51286 RVA: 0x00307C7C File Offset: 0x00305E7C
		public string Title
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

		// Token: 0x0600C857 RID: 51287 RVA: 0x00307CB3 File Offset: 0x00305EB3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x00307CC2 File Offset: 0x00305EC2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600C859 RID: 51289 RVA: 0x00307CDC File Offset: 0x00305EDC
		public int Condition
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

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600C85A RID: 51290 RVA: 0x00307D1C File Offset: 0x00305F1C
		public int EventType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x00307D5C File Offset: 0x00305F5C
		public int Args(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600C85C RID: 51292 RVA: 0x00307D9C File Offset: 0x00305F9C
		public int ArgsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x00307DC8 File Offset: 0x00305FC8
		public Span<int> GetArgsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C85E RID: 51294 RVA: 0x00307DD8 File Offset: 0x00305FD8
		public int[] GetArgsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600C85F RID: 51295 RVA: 0x00307DF0 File Offset: 0x00305FF0
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C860 RID: 51296 RVA: 0x00307E28 File Offset: 0x00306028
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x00307E38 File Offset: 0x00306038
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x00307E50 File Offset: 0x00306050
		public int FlowId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600C863 RID: 51299 RVA: 0x00307E90 File Offset: 0x00306090
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600C864 RID: 51300 RVA: 0x00307ED0 File Offset: 0x003060D0
		public bool IsCopyCamera
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x00307F10 File Offset: 0x00306110
		[NullableContext(1)]
		public int[] Args()
		{
			return this.GetArgsArray();
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x00307F18 File Offset: 0x00306118
		[NullableContext(1)]
		public IEnumerable<int> ArgsIter()
		{
			RogueResEvent.<ArgsIter>d__38 <ArgsIter>d__ = new RogueResEvent.<ArgsIter>d__38(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x040056CF RID: 22223
		private Table __p;
	}
}
