using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B80 RID: 2944
	public struct AbyssActivity : IFlatbufferObject
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x001E3E81 File Offset: 0x001E2081
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x001E3E8E File Offset: 0x001E208E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x001E3E98 File Offset: 0x001E2098
		public static AbyssActivity GetRootAsAbyssActivity(ByteBuffer _bb)
		{
			return AbyssActivity.GetRootAsAbyssActivity(_bb, default(AbyssActivity));
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x001E3EB4 File Offset: 0x001E20B4
		public static AbyssActivity GetRootAsAbyssActivity(ByteBuffer _bb, AbyssActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001E3ED1 File Offset: 0x001E20D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x001E3EE0 File Offset: 0x001E20E0
		public AbyssActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x001E3EF0 File Offset: 0x001E20F0
		public int ActivityId
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

		// Token: 0x0600453F RID: 17727 RVA: 0x001E3F2C File Offset: 0x001E212C
		public int DangoList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x001E3F6C File Offset: 0x001E216C
		public int DangoListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x001E3F97 File Offset: 0x001E2197
		public Span<int> GetDangoListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x001E3FA6 File Offset: 0x001E21A6
		public int[] GetDangoListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x001E3FC0 File Offset: 0x001E21C0
		public int ShopId
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x001E3FFC File Offset: 0x001E21FC
		public int MarkId
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x001E403C File Offset: 0x001E223C
		public string SceneActor
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

		// Token: 0x06004546 RID: 17734 RVA: 0x001E4074 File Offset: 0x001E2274
		public Span<byte> GetSceneActorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x001E4084 File Offset: 0x001E2284
		public byte[] GetSceneActorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x001E409C File Offset: 0x001E229C
		[NullableContext(1)]
		public int[] DangoList()
		{
			return this.GetDangoListArray();
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x001E40A4 File Offset: 0x001E22A4
		[NullableContext(1)]
		public IEnumerable<int> DangoListIter()
		{
			AbyssActivity.<DangoListIter>d__24 <DangoListIter>d__ = new AbyssActivity.<DangoListIter>d__24(-2);
			<DangoListIter>d__.<>3__<>4__this = this;
			return <DangoListIter>d__;
		}

		// Token: 0x0400504E RID: 20558
		private Table __p;
	}
}
