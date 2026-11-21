using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE9 RID: 3305
	public struct DrinksRequireList : IFlatbufferObject
	{
		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x002386E4 File Offset: 0x002368E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x002386F1 File Offset: 0x002368F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x002386F8 File Offset: 0x002368F8
		public static DrinksRequireList GetRootAsDrinksRequireList(ByteBuffer _bb)
		{
			return DrinksRequireList.GetRootAsDrinksRequireList(_bb, default(DrinksRequireList));
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x00238714 File Offset: 0x00236914
		public static DrinksRequireList GetRootAsDrinksRequireList(ByteBuffer _bb, DrinksRequireList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x00238731 File Offset: 0x00236931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x00238740 File Offset: 0x00236940
		public DrinksRequireList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06006A83 RID: 27267 RVA: 0x00238750 File Offset: 0x00236950
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

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x0023878C File Offset: 0x0023698C
		public int RoleId
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x002387C8 File Offset: 0x002369C8
		public int ScoreMax
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x00238804 File Offset: 0x00236A04
		public int FlavorRequire
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x00238844 File Offset: 0x00236A44
		public int DrinkNeedV2
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

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x00238884 File Offset: 0x00236A84
		public string DrinkNeedKey
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

		// Token: 0x06006A89 RID: 27273 RVA: 0x002388BC File Offset: 0x00236ABC
		public Span<byte> GetDrinkNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x002388CC File Offset: 0x00236ACC
		public byte[] GetDrinkNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06006A8B RID: 27275 RVA: 0x002388E4 File Offset: 0x00236AE4
		public int DrinkLikePoint
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x00238924 File Offset: 0x00236B24
		public int BatchingNeedV2
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06006A8D RID: 27277 RVA: 0x00238964 File Offset: 0x00236B64
		public string BatchingNeedKey
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x0023899C File Offset: 0x00236B9C
		public Span<byte> GetBatchingNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x002389AC File Offset: 0x00236BAC
		public byte[] GetBatchingNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x002389C4 File Offset: 0x00236BC4
		public int BatchingLikePoint
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06006A91 RID: 27281 RVA: 0x00238A04 File Offset: 0x00236C04
		public int OrnamentNeedV2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x00238A44 File Offset: 0x00236C44
		public string OrnamentNeedKey
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00238A7C File Offset: 0x00236C7C
		public Span<byte> GetOrnamentNeedKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x00238A8C File Offset: 0x00236C8C
		public byte[] GetOrnamentNeedKeyArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x00238AA4 File Offset: 0x00236CA4
		public int OrnaLike
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x00238AE4 File Offset: 0x00236CE4
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x00238B24 File Offset: 0x00236D24
		public int RoleLikeSetting(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x00238B64 File Offset: 0x00236D64
		public int RoleLikeSettingLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00238B90 File Offset: 0x00236D90
		public Span<int> GetRoleLikeSettingBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00238BA0 File Offset: 0x00236DA0
		public int[] GetRoleLikeSettingArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x00238BB8 File Offset: 0x00236DB8
		public string ScriptName
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x00238BF0 File Offset: 0x00236DF0
		public Span<byte> GetScriptNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x00238C00 File Offset: 0x00236E00
		public byte[] GetScriptNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06006A9E RID: 27294 RVA: 0x00238C18 File Offset: 0x00236E18
		public int ScriptId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x00238C58 File Offset: 0x00236E58
		public int ScriptStateId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x00238C95 File Offset: 0x00236E95
		[NullableContext(1)]
		public int[] RoleLikeSetting()
		{
			return this.GetRoleLikeSettingArray();
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00238C9D File Offset: 0x00236E9D
		[NullableContext(1)]
		public IEnumerable<int> RoleLikeSettingIter()
		{
			DrinksRequireList.<RoleLikeSettingIter>d__56 <RoleLikeSettingIter>d__ = new DrinksRequireList.<RoleLikeSettingIter>d__56(-2);
			<RoleLikeSettingIter>d__.<>3__<>4__this = this;
			return <RoleLikeSettingIter>d__;
		}

		// Token: 0x04005225 RID: 21029
		private Table __p;
	}
}
