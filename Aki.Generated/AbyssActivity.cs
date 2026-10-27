using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAB RID: 2731
	public struct AbyssActivity : IFlatbufferObject
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x001C4AED File Offset: 0x001C2CED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x001C4AFA File Offset: 0x001C2CFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x001C4B04 File Offset: 0x001C2D04
		public static AbyssActivity GetRootAsAbyssActivity(ByteBuffer _bb)
		{
			return AbyssActivity.GetRootAsAbyssActivity(_bb, default(AbyssActivity));
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x001C4B20 File Offset: 0x001C2D20
		public static AbyssActivity GetRootAsAbyssActivity(ByteBuffer _bb, AbyssActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x001C4B3D File Offset: 0x001C2D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x001C4B4C File Offset: 0x001C2D4C
		public AbyssActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x001C4B5C File Offset: 0x001C2D5C
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

		// Token: 0x06004041 RID: 16449 RVA: 0x001C4B98 File Offset: 0x001C2D98
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
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x001C4BD8 File Offset: 0x001C2DD8
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

		// Token: 0x06004043 RID: 16451 RVA: 0x001C4C03 File Offset: 0x001C2E03
		public Span<int> GetDangoListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x001C4C12 File Offset: 0x001C2E12
		public int[] GetDangoListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06004045 RID: 16453 RVA: 0x001C4C2C File Offset: 0x001C2E2C
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
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x001C4C68 File Offset: 0x001C2E68
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
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x001C4CA8 File Offset: 0x001C2EA8
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

		// Token: 0x06004048 RID: 16456 RVA: 0x001C4CE0 File Offset: 0x001C2EE0
		public Span<byte> GetSceneActorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x001C4CF0 File Offset: 0x001C2EF0
		public byte[] GetSceneActorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x001C4D08 File Offset: 0x001C2F08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DangoListIter()或GetDangoListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DangoList()
		{
			AbyssActivity abyssActivity = this;
			return abyssActivity.GetDangoListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x001C4D2C File Offset: 0x001C2F2C
		[NullableContext(1)]
		public readonly IEnumerable<int> DangoListIter()
		{
			AbyssActivity.<DangoListIter>d__24 <DangoListIter>d__ = new AbyssActivity.<DangoListIter>d__24(-2);
			<DangoListIter>d__.<>3__<>4__this = this;
			return <DangoListIter>d__;
		}

		// Token: 0x04004A7B RID: 19067
		private Table __p;
	}
}
