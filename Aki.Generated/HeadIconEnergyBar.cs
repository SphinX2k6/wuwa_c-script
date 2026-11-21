using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0C RID: 3596
	public struct HeadIconEnergyBar : IFlatbufferObject
	{
		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600845C RID: 33884 RVA: 0x002720A5 File Offset: 0x002702A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x002720B2 File Offset: 0x002702B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x002720BC File Offset: 0x002702BC
		public static HeadIconEnergyBar GetRootAsHeadIconEnergyBar(ByteBuffer _bb)
		{
			return HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(_bb, default(HeadIconEnergyBar));
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x002720D8 File Offset: 0x002702D8
		public static HeadIconEnergyBar GetRootAsHeadIconEnergyBar(ByteBuffer _bb, HeadIconEnergyBar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x002720F5 File Offset: 0x002702F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x00272104 File Offset: 0x00270304
		public HeadIconEnergyBar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06008462 RID: 33890 RVA: 0x00272114 File Offset: 0x00270314
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

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x00272150 File Offset: 0x00270350
		public int Type
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

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06008464 RID: 33892 RVA: 0x0027218C File Offset: 0x0027038C
		public int AttributeId
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x002721C8 File Offset: 0x002703C8
		public string PrefabPath
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

		// Token: 0x06008466 RID: 33894 RVA: 0x00272200 File Offset: 0x00270400
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x00272210 File Offset: 0x00270410
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06008468 RID: 33896 RVA: 0x00272228 File Offset: 0x00270428
		public float EffectCd
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06008469 RID: 33897 RVA: 0x0027226C File Offset: 0x0027046C
		public bool PlayIncreaseEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x0600846A RID: 33898 RVA: 0x002722AC File Offset: 0x002704AC
		public bool PlayDecreaseEffect
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x002722EC File Offset: 0x002704EC
		public bool FormationVisible
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x0027232C File Offset: 0x0027052C
		public int Params(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x0027236C File Offset: 0x0027056C
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x00272398 File Offset: 0x00270598
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600846F RID: 33903 RVA: 0x002723A8 File Offset: 0x002705A8
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x002723C0 File Offset: 0x002705C0
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x002723C8 File Offset: 0x002705C8
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			HeadIconEnergyBar.<ParamsIter>d__32 <ParamsIter>d__ = new HeadIconEnergyBar.<ParamsIter>d__32(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005384 RID: 21380
		private Table __p;
	}
}
