using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCA RID: 3018
	public struct DangoBrawlOpponent : IFlatbufferObject
	{
		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x0020BAE4 File Offset: 0x00209CE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x0020BAF1 File Offset: 0x00209CF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0020BAF8 File Offset: 0x00209CF8
		public static DangoBrawlOpponent GetRootAsDangoBrawlOpponent(ByteBuffer _bb)
		{
			return DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(_bb, default(DangoBrawlOpponent));
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0020BB14 File Offset: 0x00209D14
		public static DangoBrawlOpponent GetRootAsDangoBrawlOpponent(ByteBuffer _bb, DangoBrawlOpponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x0020BB31 File Offset: 0x00209D31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x0020BB40 File Offset: 0x00209D40
		public DangoBrawlOpponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06005EAF RID: 24239 RVA: 0x0020BB50 File Offset: 0x00209D50
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06005EB0 RID: 24240 RVA: 0x0020BB8C File Offset: 0x00209D8C
		public string Name
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

		// Token: 0x06005EB1 RID: 24241 RVA: 0x0020BBC3 File Offset: 0x00209DC3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x0020BBD2 File Offset: 0x00209DD2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x0020BBEC File Offset: 0x00209DEC
		public int OccupationId
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x0020BC28 File Offset: 0x00209E28
		public int WobblePlateId
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x0020BC68 File Offset: 0x00209E68
		public string RoleIcon
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

		// Token: 0x06005EB6 RID: 24246 RVA: 0x0020BCA0 File Offset: 0x00209EA0
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x0020BCB0 File Offset: 0x00209EB0
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06005EB8 RID: 24248 RVA: 0x0020BCC8 File Offset: 0x00209EC8
		public string RoleBuffIcon
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

		// Token: 0x06005EB9 RID: 24249 RVA: 0x0020BD00 File Offset: 0x00209F00
		public Span<byte> GetRoleBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x0020BD10 File Offset: 0x00209F10
		public byte[] GetRoleBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x0020BD28 File Offset: 0x00209F28
		public string SpineAtlasPath
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

		// Token: 0x06005EBC RID: 24252 RVA: 0x0020BD60 File Offset: 0x00209F60
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x0020BD70 File Offset: 0x00209F70
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06005EBE RID: 24254 RVA: 0x0020BD88 File Offset: 0x00209F88
		public string SpineSkeletonDataPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0020BDC0 File Offset: 0x00209FC0
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0020BDD0 File Offset: 0x00209FD0
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x0020BDE8 File Offset: 0x00209FE8
		public string BlueprintPath
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

		// Token: 0x06005EC2 RID: 24258 RVA: 0x0020BE20 File Offset: 0x0020A020
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x0020BE30 File Offset: 0x0020A030
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x0020BE48 File Offset: 0x0020A048
		public string ABpPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x0020BE80 File Offset: 0x0020A080
		public Span<byte> GetABpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x0020BE90 File Offset: 0x0020A090
		public byte[] GetABpPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x0020BEA8 File Offset: 0x0020A0A8
		public string MontageIdle
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x0020BEE0 File Offset: 0x0020A0E0
		public Span<byte> GetMontageIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x0020BEF0 File Offset: 0x0020A0F0
		public byte[] GetMontageIdleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x0020BF08 File Offset: 0x0020A108
		public string MontageAttack
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

		// Token: 0x06005ECB RID: 24267 RVA: 0x0020BF40 File Offset: 0x0020A140
		public Span<byte> GetMontageAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x0020BF50 File Offset: 0x0020A150
		public byte[] GetMontageAttackArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x0020BF68 File Offset: 0x0020A168
		public string MontageAttackLoop
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x0020BFA0 File Offset: 0x0020A1A0
		public Span<byte> GetMontageAttackLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x0020BFB0 File Offset: 0x0020A1B0
		public byte[] GetMontageAttackLoopArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x0020BFC8 File Offset: 0x0020A1C8
		public string MontageAttackEnd
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0020C000 File Offset: 0x0020A200
		public Span<byte> GetMontageAttackEndBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x0020C010 File Offset: 0x0020A210
		public byte[] GetMontageAttackEndArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x0020C028 File Offset: 0x0020A228
		public string MontageSuccess
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x0020C060 File Offset: 0x0020A260
		public Span<byte> GetMontageSuccessBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x0020C070 File Offset: 0x0020A270
		public byte[] GetMontageSuccessArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06005ED6 RID: 24278 RVA: 0x0020C088 File Offset: 0x0020A288
		public string MontageFail
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

		// Token: 0x06005ED7 RID: 24279 RVA: 0x0020C0C0 File Offset: 0x0020A2C0
		public Span<byte> GetMontageFailBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0020C0D0 File Offset: 0x0020A2D0
		public byte[] GetMontageFailArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0020C0E8 File Offset: 0x0020A2E8
		public int TrashTalkIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06005EDA RID: 24282 RVA: 0x0020C128 File Offset: 0x0020A328
		public int TrashTalkIdListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0020C154 File Offset: 0x0020A354
		public Span<int> GetTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x0020C164 File Offset: 0x0020A364
		public int[] GetTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x0020C17C File Offset: 0x0020A37C
		public string AudioAttackStart
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x0020C1B4 File Offset: 0x0020A3B4
		public Span<byte> GetAudioAttackStartBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x0020C1C4 File Offset: 0x0020A3C4
		public byte[] GetAudioAttackStartArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x0020C1DC File Offset: 0x0020A3DC
		public string AudioRoundWin
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0020C214 File Offset: 0x0020A414
		public Span<byte> GetAudioRoundWinBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x0020C224 File Offset: 0x0020A424
		public byte[] GetAudioRoundWinArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x0020C23C File Offset: 0x0020A43C
		public string HitDAPath
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x0020C274 File Offset: 0x0020A474
		public Span<byte> GetHitDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x0020C284 File Offset: 0x0020A484
		public byte[] GetHitDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x0020C29C File Offset: 0x0020A49C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrashTalkIdListIter()或GetTrashTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrashTalkIdList()
		{
			DangoBrawlOpponent dangoBrawlOpponent = this;
			return dangoBrawlOpponent.GetTrashTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x0020C2C0 File Offset: 0x0020A4C0
		[NullableContext(1)]
		public readonly IEnumerable<int> TrashTalkIdListIter()
		{
			DangoBrawlOpponent.<TrashTalkIdListIter>d__84 <TrashTalkIdListIter>d__ = new DangoBrawlOpponent.<TrashTalkIdListIter>d__84(-2);
			<TrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <TrashTalkIdListIter>d__;
		}

		// Token: 0x04004BF4 RID: 19444
		private Table __p;
	}
}
