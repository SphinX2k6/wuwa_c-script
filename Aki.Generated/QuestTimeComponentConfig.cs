using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105F RID: 4191
	public struct QuestTimeComponentConfig : IFlatbufferObject
	{
		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x002EDCB0 File Offset: 0x002EBEB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC7A RID: 48250 RVA: 0x002EDCBD File Offset: 0x002EBEBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x002EDCC4 File Offset: 0x002EBEC4
		public static QuestTimeComponentConfig GetRootAsQuestTimeComponentConfig(ByteBuffer _bb)
		{
			return QuestTimeComponentConfig.GetRootAsQuestTimeComponentConfig(_bb, default(QuestTimeComponentConfig));
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x002EDCE0 File Offset: 0x002EBEE0
		public static QuestTimeComponentConfig GetRootAsQuestTimeComponentConfig(ByteBuffer _bb, QuestTimeComponentConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x002EDCFD File Offset: 0x002EBEFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x002EDD0C File Offset: 0x002EBF0C
		public QuestTimeComponentConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0600BC7F RID: 48255 RVA: 0x002EDD1C File Offset: 0x002EBF1C
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

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x002EDD58 File Offset: 0x002EBF58
		public IntVector2D? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0600BC81 RID: 48257 RVA: 0x002EDDB8 File Offset: 0x002EBFB8
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

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x002EDDF4 File Offset: 0x002EBFF4
		public int StatusType
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

		// Token: 0x0600BC83 RID: 48259 RVA: 0x002EDE34 File Offset: 0x002EC034
		public string ComponentIcon(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x002EDE70 File Offset: 0x002EC070
		public int ComponentIconLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x002EDE9C File Offset: 0x002EC09C
		public string MultiPersonAvatar(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x002EDED8 File Offset: 0x002EC0D8
		public int MultiPersonAvatarLength
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

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0600BC87 RID: 48263 RVA: 0x002EDF04 File Offset: 0x002EC104
		public string ComponentQualityFrame
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

		// Token: 0x0600BC88 RID: 48264 RVA: 0x002EDF3C File Offset: 0x002EC13C
		public Span<byte> GetComponentQualityFrameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x002EDF4C File Offset: 0x002EC14C
		public byte[] GetComponentQualityFrameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600BC8A RID: 48266 RVA: 0x002EDF64 File Offset: 0x002EC164
		public string ComponentQualityFrameHold
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

		// Token: 0x0600BC8B RID: 48267 RVA: 0x002EDF9C File Offset: 0x002EC19C
		public Span<byte> GetComponentQualityFrameHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x002EDFAC File Offset: 0x002EC1AC
		public byte[] GetComponentQualityFrameHoldArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600BC8D RID: 48269 RVA: 0x002EDFC4 File Offset: 0x002EC1C4
		public string HeadIconBgInTip
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

		// Token: 0x0600BC8E RID: 48270 RVA: 0x002EDFFC File Offset: 0x002EC1FC
		public Span<byte> GetHeadIconBgInTipBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BC8F RID: 48271 RVA: 0x002EE00C File Offset: 0x002EC20C
		public byte[] GetHeadIconBgInTipArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600BC90 RID: 48272 RVA: 0x002EE024 File Offset: 0x002EC224
		public string TipsQualityBg
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

		// Token: 0x0600BC91 RID: 48273 RVA: 0x002EE05C File Offset: 0x002EC25C
		public Span<byte> GetTipsQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x002EE06C File Offset: 0x002EC26C
		public byte[] GetTipsQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600BC93 RID: 48275 RVA: 0x002EE084 File Offset: 0x002EC284
		public string TipsTitle
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

		// Token: 0x0600BC94 RID: 48276 RVA: 0x002EE0BC File Offset: 0x002EC2BC
		public Span<byte> GetTipsTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x002EE0CC File Offset: 0x002EC2CC
		public byte[] GetTipsTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600BC96 RID: 48278 RVA: 0x002EE0E4 File Offset: 0x002EC2E4
		public string TipsDesc
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

		// Token: 0x0600BC97 RID: 48279 RVA: 0x002EE11C File Offset: 0x002EC31C
		public Span<byte> GetTipsDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x002EE12C File Offset: 0x002EC32C
		public byte[] GetTipsDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x002EE144 File Offset: 0x002EC344
		public string TipsArea
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

		// Token: 0x0600BC9A RID: 48282 RVA: 0x002EE17C File Offset: 0x002EC37C
		public Span<byte> GetTipsAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x002EE18C File Offset: 0x002EC38C
		public byte[] GetTipsAreaArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600BC9C RID: 48284 RVA: 0x002EE1A4 File Offset: 0x002EC3A4
		public string TipsStatusDesc
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

		// Token: 0x0600BC9D RID: 48285 RVA: 0x002EE1DC File Offset: 0x002EC3DC
		public Span<byte> GetTipsStatusDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x002EE1EC File Offset: 0x002EC3EC
		public byte[] GetTipsStatusDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x002EE204 File Offset: 0x002EC404
		public IntVector2D? AnimMovePoint(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600BCA0 RID: 48288 RVA: 0x002EE268 File Offset: 0x002EC468
		public int AnimMovePointLength
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

		// Token: 0x0600BCA1 RID: 48289 RVA: 0x002EE294 File Offset: 0x002EC494
		public int BranchFinishQuestNode(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x002EE2D4 File Offset: 0x002EC4D4
		public int BranchFinishQuestNodeLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BCA3 RID: 48291 RVA: 0x002EE300 File Offset: 0x002EC500
		public Span<int> GetBranchFinishQuestNodeBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x002EE310 File Offset: 0x002EC510
		public int[] GetBranchFinishQuestNodeArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600BCA5 RID: 48293 RVA: 0x002EE328 File Offset: 0x002EC528
		public string OnGoingDesc
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x002EE360 File Offset: 0x002EC560
		public Span<byte> GetOnGoingDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x002EE370 File Offset: 0x002EC570
		public byte[] GetOnGoingDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600BCA8 RID: 48296 RVA: 0x002EE388 File Offset: 0x002EC588
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600BCA9 RID: 48297 RVA: 0x002EE3CC File Offset: 0x002EC5CC
		public int PathSpeed
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x002EE410 File Offset: 0x002EC610
		public string HeadLoopEffect
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

		// Token: 0x0600BCAB RID: 48299 RVA: 0x002EE448 File Offset: 0x002EC648
		public Span<byte> GetHeadLoopEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x002EE458 File Offset: 0x002EC658
		public byte[] GetHeadLoopEffectArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x002EE470 File Offset: 0x002EC670
		[NullableContext(1)]
		public IntVector2D[] AnimMovePoint()
		{
			return this.AnimMovePointIter().ToArray<IntVector2D>();
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x002EE47D File Offset: 0x002EC67D
		[NullableContext(1)]
		public IEnumerable<IntVector2D> AnimMovePointIter()
		{
			QuestTimeComponentConfig.<AnimMovePointIter>d__75 <AnimMovePointIter>d__ = new QuestTimeComponentConfig.<AnimMovePointIter>d__75(-2);
			<AnimMovePointIter>d__.<>3__<>4__this = this;
			return <AnimMovePointIter>d__;
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x002EE492 File Offset: 0x002EC692
		[NullableContext(1)]
		public int[] BranchFinishQuestNode()
		{
			return this.GetBranchFinishQuestNodeArray();
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x002EE49A File Offset: 0x002EC69A
		[NullableContext(1)]
		public IEnumerable<int> BranchFinishQuestNodeIter()
		{
			QuestTimeComponentConfig.<BranchFinishQuestNodeIter>d__77 <BranchFinishQuestNodeIter>d__ = new QuestTimeComponentConfig.<BranchFinishQuestNodeIter>d__77(-2);
			<BranchFinishQuestNodeIter>d__.<>3__<>4__this = this;
			return <BranchFinishQuestNodeIter>d__;
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x002EE4AF File Offset: 0x002EC6AF
		[NullableContext(1)]
		public string[] ComponentIcon()
		{
			return this.ComponentIconIter().ToArray<string>();
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x002EE4BC File Offset: 0x002EC6BC
		[NullableContext(1)]
		public IEnumerable<string> ComponentIconIter()
		{
			QuestTimeComponentConfig.<ComponentIconIter>d__79 <ComponentIconIter>d__ = new QuestTimeComponentConfig.<ComponentIconIter>d__79(-2);
			<ComponentIconIter>d__.<>3__<>4__this = this;
			return <ComponentIconIter>d__;
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x002EE4D1 File Offset: 0x002EC6D1
		[NullableContext(1)]
		public string[] MultiPersonAvatar()
		{
			return this.MultiPersonAvatarIter().ToArray<string>();
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x002EE4DE File Offset: 0x002EC6DE
		[NullableContext(1)]
		public IEnumerable<string> MultiPersonAvatarIter()
		{
			QuestTimeComponentConfig.<MultiPersonAvatarIter>d__81 <MultiPersonAvatarIter>d__ = new QuestTimeComponentConfig.<MultiPersonAvatarIter>d__81(-2);
			<MultiPersonAvatarIter>d__.<>3__<>4__this = this;
			return <MultiPersonAvatarIter>d__;
		}

		// Token: 0x0400562D RID: 22061
		private Table __p;
	}
}
