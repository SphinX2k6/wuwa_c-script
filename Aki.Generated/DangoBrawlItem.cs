using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA3 RID: 3235
	public struct DangoBrawlItem : IFlatbufferObject
	{
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x002289C4 File Offset: 0x00226BC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x002289D1 File Offset: 0x00226BD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x002289D8 File Offset: 0x00226BD8
		public static DangoBrawlItem GetRootAsDangoBrawlItem(ByteBuffer _bb)
		{
			return DangoBrawlItem.GetRootAsDangoBrawlItem(_bb, default(DangoBrawlItem));
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x002289F4 File Offset: 0x00226BF4
		public static DangoBrawlItem GetRootAsDangoBrawlItem(ByteBuffer _bb, DangoBrawlItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00228A11 File Offset: 0x00226C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x00228A20 File Offset: 0x00226C20
		public DangoBrawlItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600635D RID: 25437 RVA: 0x00228A30 File Offset: 0x00226C30
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

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600635E RID: 25438 RVA: 0x00228A6C File Offset: 0x00226C6C
		public int ShapeTemplateId
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600635F RID: 25439 RVA: 0x00228AA8 File Offset: 0x00226CA8
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x00228AE4 File Offset: 0x00226CE4
		public bool IsSpeItem
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x00228B24 File Offset: 0x00226D24
		public int SubType
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

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x00228B64 File Offset: 0x00226D64
		public int ActiveSkill
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00228BA4 File Offset: 0x00226DA4
		public ProAddEntry? AddAttr(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x00228C08 File Offset: 0x00226E08
		public int AddAttrLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06006365 RID: 25445 RVA: 0x00228C34 File Offset: 0x00226E34
		public int Price
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06006366 RID: 25446 RVA: 0x00228C74 File Offset: 0x00226E74
		public int Damage
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06006367 RID: 25447 RVA: 0x00228CB4 File Offset: 0x00226EB4
		public int Cd
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

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x00228CF4 File Offset: 0x00226EF4
		public int Cost
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

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x00228D34 File Offset: 0x00226F34
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x00228D74 File Offset: 0x00226F74
		public int OccupationId
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

		// Token: 0x0600636B RID: 25451 RVA: 0x00228DB4 File Offset: 0x00226FB4
		public int ItemTags(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x00228DF4 File Offset: 0x00226FF4
		public int ItemTagsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00228E20 File Offset: 0x00227020
		public Span<int> GetItemTagsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00228E30 File Offset: 0x00227030
		public int[] GetItemTagsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x00228E48 File Offset: 0x00227048
		public int EffectItemTag(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x00228E88 File Offset: 0x00227088
		public int EffectItemTagLength
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

		// Token: 0x06006371 RID: 25457 RVA: 0x00228EB4 File Offset: 0x002270B4
		public Span<int> GetEffectItemTagBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00228EC4 File Offset: 0x002270C4
		public int[] GetEffectItemTagArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06006373 RID: 25459 RVA: 0x00228EDC File Offset: 0x002270DC
		public bool EffectNoSameItem
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x00228F1C File Offset: 0x0022711C
		public string Icon
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

		// Token: 0x06006375 RID: 25461 RVA: 0x00228F54 File Offset: 0x00227154
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00228F64 File Offset: 0x00227164
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06006377 RID: 25463 RVA: 0x00228F7C File Offset: 0x0022717C
		public string IconHandBook
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

		// Token: 0x06006378 RID: 25464 RVA: 0x00228FB4 File Offset: 0x002271B4
		public Span<byte> GetIconHandBookBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00228FC4 File Offset: 0x002271C4
		public byte[] GetIconHandBookArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x00228FDC File Offset: 0x002271DC
		public string IconRaycast
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

		// Token: 0x0600637B RID: 25467 RVA: 0x00229014 File Offset: 0x00227214
		public Span<byte> GetIconRaycastBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00229024 File Offset: 0x00227224
		public byte[] GetIconRaycastArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x0022903C File Offset: 0x0022723C
		public float IconBackpackScale
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x00229080 File Offset: 0x00227280
		public float IconShopScale
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600637F RID: 25471 RVA: 0x002290C4 File Offset: 0x002272C4
		public float IconCombineScale
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x00229108 File Offset: 0x00227308
		public float IconHandBookScale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x0022914C File Offset: 0x0022734C
		public float IconHandBookScale2
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x00229190 File Offset: 0x00227390
		public float IconOccupationScale
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06006383 RID: 25475 RVA: 0x002291D4 File Offset: 0x002273D4
		public float IconOccupationScale2
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x00229218 File Offset: 0x00227418
		public float IconRoleScale
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x0022925C File Offset: 0x0022745C
		public float IconBattleScale
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x002292A0 File Offset: 0x002274A0
		public float IconRoleDetailScale
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x002292E4 File Offset: 0x002274E4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0022931C File Offset: 0x0022751C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x0022932C File Offset: 0x0022752C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00229344 File Offset: 0x00227544
		public string SpeEffectDesc(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x00229380 File Offset: 0x00227580
		public int SpeEffectDescLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x002293AC File Offset: 0x002275AC
		public StringArray? SpeEffectDescParam(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x00229410 File Offset: 0x00227610
		public int SpeEffectDescParamLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x0022943C File Offset: 0x0022763C
		public string StarDesc
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00229474 File Offset: 0x00227674
		public Span<byte> GetStarDescBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00229484 File Offset: 0x00227684
		public byte[] GetStarDescArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0022949C File Offset: 0x0022769C
		public string StarDescParam(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x002294D8 File Offset: 0x002276D8
		public int StarDescParamLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06006393 RID: 25491 RVA: 0x00229504 File Offset: 0x00227704
		public bool IsShowInHandBook
		{
			get
			{
				int num = this.__p.__offset(72);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x00229544 File Offset: 0x00227744
		public int UIAnimShowType
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x00229584 File Offset: 0x00227784
		public string UIAnimSeqName
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x002295BC File Offset: 0x002277BC
		public Span<byte> GetUIAnimSeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x002295CC File Offset: 0x002277CC
		public byte[] GetUIAnimSeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x002295E4 File Offset: 0x002277E4
		public int UINiagaraType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06006399 RID: 25497 RVA: 0x00229624 File Offset: 0x00227824
		public string UINiagaraPath
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0022965C File Offset: 0x0022785C
		public Span<byte> GetUINiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x0022966C File Offset: 0x0022786C
		public byte[] GetUINiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x00229684 File Offset: 0x00227884
		public int RecommendOccupation(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600639D RID: 25501 RVA: 0x002296C4 File Offset: 0x002278C4
		public int RecommendOccupationLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x002296F0 File Offset: 0x002278F0
		public Span<int> GetRecommendOccupationBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x00229700 File Offset: 0x00227900
		public int[] GetRecommendOccupationArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060063A0 RID: 25504 RVA: 0x00229718 File Offset: 0x00227918
		public bool IsBlockSell
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x00229758 File Offset: 0x00227958
		public IntArray? CDMaskRange(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x002297BC File Offset: 0x002279BC
		public int CDMaskRangeLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x002297E8 File Offset: 0x002279E8
		[NullableContext(1)]
		public ProAddEntry[] AddAttr()
		{
			return this.AddAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x002297F5 File Offset: 0x002279F5
		[NullableContext(1)]
		public IEnumerable<ProAddEntry> AddAttrIter()
		{
			DangoBrawlItem.<AddAttrIter>d__121 <AddAttrIter>d__ = new DangoBrawlItem.<AddAttrIter>d__121(-2);
			<AddAttrIter>d__.<>3__<>4__this = this;
			return <AddAttrIter>d__;
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x0022980A File Offset: 0x00227A0A
		[NullableContext(1)]
		public IntArray[] CDMaskRange()
		{
			return this.CDMaskRangeIter().ToArray<IntArray>();
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x00229817 File Offset: 0x00227A17
		[NullableContext(1)]
		public IEnumerable<IntArray> CDMaskRangeIter()
		{
			DangoBrawlItem.<CDMaskRangeIter>d__123 <CDMaskRangeIter>d__ = new DangoBrawlItem.<CDMaskRangeIter>d__123(-2);
			<CDMaskRangeIter>d__.<>3__<>4__this = this;
			return <CDMaskRangeIter>d__;
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x0022982C File Offset: 0x00227A2C
		[NullableContext(1)]
		public int[] EffectItemTag()
		{
			return this.GetEffectItemTagArray();
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x00229834 File Offset: 0x00227A34
		[NullableContext(1)]
		public IEnumerable<int> EffectItemTagIter()
		{
			DangoBrawlItem.<EffectItemTagIter>d__125 <EffectItemTagIter>d__ = new DangoBrawlItem.<EffectItemTagIter>d__125(-2);
			<EffectItemTagIter>d__.<>3__<>4__this = this;
			return <EffectItemTagIter>d__;
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x00229849 File Offset: 0x00227A49
		[NullableContext(1)]
		public int[] ItemTags()
		{
			return this.GetItemTagsArray();
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x00229851 File Offset: 0x00227A51
		[NullableContext(1)]
		public IEnumerable<int> ItemTagsIter()
		{
			DangoBrawlItem.<ItemTagsIter>d__127 <ItemTagsIter>d__ = new DangoBrawlItem.<ItemTagsIter>d__127(-2);
			<ItemTagsIter>d__.<>3__<>4__this = this;
			return <ItemTagsIter>d__;
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x00229866 File Offset: 0x00227A66
		[NullableContext(1)]
		public int[] RecommendOccupation()
		{
			return this.GetRecommendOccupationArray();
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0022986E File Offset: 0x00227A6E
		[NullableContext(1)]
		public IEnumerable<int> RecommendOccupationIter()
		{
			DangoBrawlItem.<RecommendOccupationIter>d__129 <RecommendOccupationIter>d__ = new DangoBrawlItem.<RecommendOccupationIter>d__129(-2);
			<RecommendOccupationIter>d__.<>3__<>4__this = this;
			return <RecommendOccupationIter>d__;
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00229883 File Offset: 0x00227A83
		[NullableContext(1)]
		public string[] SpeEffectDesc()
		{
			return this.SpeEffectDescIter().ToArray<string>();
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x00229890 File Offset: 0x00227A90
		[NullableContext(1)]
		public IEnumerable<string> SpeEffectDescIter()
		{
			DangoBrawlItem.<SpeEffectDescIter>d__131 <SpeEffectDescIter>d__ = new DangoBrawlItem.<SpeEffectDescIter>d__131(-2);
			<SpeEffectDescIter>d__.<>3__<>4__this = this;
			return <SpeEffectDescIter>d__;
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x002298A5 File Offset: 0x00227AA5
		[NullableContext(1)]
		public StringArray[] SpeEffectDescParam()
		{
			return this.SpeEffectDescParamIter().ToArray<StringArray>();
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x002298B2 File Offset: 0x00227AB2
		[NullableContext(1)]
		public IEnumerable<StringArray> SpeEffectDescParamIter()
		{
			DangoBrawlItem.<SpeEffectDescParamIter>d__133 <SpeEffectDescParamIter>d__ = new DangoBrawlItem.<SpeEffectDescParamIter>d__133(-2);
			<SpeEffectDescParamIter>d__.<>3__<>4__this = this;
			return <SpeEffectDescParamIter>d__;
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x002298C7 File Offset: 0x00227AC7
		[NullableContext(1)]
		public string[] StarDescParam()
		{
			return this.StarDescParamIter().ToArray<string>();
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x002298D4 File Offset: 0x00227AD4
		[NullableContext(1)]
		public IEnumerable<string> StarDescParamIter()
		{
			DangoBrawlItem.<StarDescParamIter>d__135 <StarDescParamIter>d__ = new DangoBrawlItem.<StarDescParamIter>d__135(-2);
			<StarDescParamIter>d__.<>3__<>4__this = this;
			return <StarDescParamIter>d__;
		}

		// Token: 0x040051CC RID: 20940
		private Table __p;
	}
}
