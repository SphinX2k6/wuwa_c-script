using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116F RID: 4463
	public struct RoverRogueBlessRole : IFlatbufferObject
	{
		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600D4FC RID: 54524 RVA: 0x00324310 File Offset: 0x00322510
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x0032431D File Offset: 0x0032251D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x00324324 File Offset: 0x00322524
		public static RoverRogueBlessRole GetRootAsRoverRogueBlessRole(ByteBuffer _bb)
		{
			return RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(_bb, default(RoverRogueBlessRole));
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x00324340 File Offset: 0x00322540
		public static RoverRogueBlessRole GetRootAsRoverRogueBlessRole(ByteBuffer _bb, RoverRogueBlessRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D500 RID: 54528 RVA: 0x0032435D File Offset: 0x0032255D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x0032436C File Offset: 0x0032256C
		public RoverRogueBlessRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600D502 RID: 54530 RVA: 0x0032437C File Offset: 0x0032257C
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

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600D503 RID: 54531 RVA: 0x003243B8 File Offset: 0x003225B8
		public int UnlockInsId
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

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600D504 RID: 54532 RVA: 0x003243F4 File Offset: 0x003225F4
		public int ActivityId
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

		// Token: 0x0600D505 RID: 54533 RVA: 0x00324430 File Offset: 0x00322630
		public DicIntInt? BlessRoleWeightChange(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x00324494 File Offset: 0x00322694
		public int BlessRoleWeightChangeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600D507 RID: 54535 RVA: 0x003244C0 File Offset: 0x003226C0
		public int BaseWeight
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x00324500 File Offset: 0x00322700
		public string BlessRoleName
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

		// Token: 0x0600D509 RID: 54537 RVA: 0x00324538 File Offset: 0x00322738
		public Span<byte> GetBlessRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D50A RID: 54538 RVA: 0x00324548 File Offset: 0x00322748
		public byte[] GetBlessRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600D50B RID: 54539 RVA: 0x00324560 File Offset: 0x00322760
		public string UnlockDesc
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

		// Token: 0x0600D50C RID: 54540 RVA: 0x00324598 File Offset: 0x00322798
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x003245A8 File Offset: 0x003227A8
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x003245C0 File Offset: 0x003227C0
		public int SortId
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

		// Token: 0x0600D50F RID: 54543 RVA: 0x00324600 File Offset: 0x00322800
		public int EnableRoleType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600D510 RID: 54544 RVA: 0x00324640 File Offset: 0x00322840
		public int EnableRoleTypeLength
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

		// Token: 0x0600D511 RID: 54545 RVA: 0x0032466C File Offset: 0x0032286C
		public Span<int> GetEnableRoleTypeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x0032467C File Offset: 0x0032287C
		public int[] GetEnableRoleTypeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600D513 RID: 54547 RVA: 0x00324694 File Offset: 0x00322894
		public string RoleIcon
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

		// Token: 0x0600D514 RID: 54548 RVA: 0x003246CC File Offset: 0x003228CC
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x003246DC File Offset: 0x003228DC
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600D516 RID: 54550 RVA: 0x003246F4 File Offset: 0x003228F4
		public string IconPath
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

		// Token: 0x0600D517 RID: 54551 RVA: 0x0032472C File Offset: 0x0032292C
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D518 RID: 54552 RVA: 0x0032473C File Offset: 0x0032293C
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600D519 RID: 54553 RVA: 0x00324754 File Offset: 0x00322954
		public string Stand
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

		// Token: 0x0600D51A RID: 54554 RVA: 0x0032478C File Offset: 0x0032298C
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x0032479C File Offset: 0x0032299C
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600D51C RID: 54556 RVA: 0x003247B4 File Offset: 0x003229B4
		public string UnlockStand
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

		// Token: 0x0600D51D RID: 54557 RVA: 0x003247EC File Offset: 0x003229EC
		public Span<byte> GetUnlockStandBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x003247FC File Offset: 0x003229FC
		public byte[] GetUnlockStandArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600D51F RID: 54559 RVA: 0x00324814 File Offset: 0x00322A14
		public string SkillStand
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

		// Token: 0x0600D520 RID: 54560 RVA: 0x0032484C File Offset: 0x00322A4C
		public Span<byte> GetSkillStandBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x0032485C File Offset: 0x00322A5C
		public byte[] GetSkillStandArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600D522 RID: 54562 RVA: 0x00324874 File Offset: 0x00322A74
		public string SkillDesc
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

		// Token: 0x0600D523 RID: 54563 RVA: 0x003248AC File Offset: 0x00322AAC
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x003248BC File Offset: 0x00322ABC
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600D525 RID: 54565 RVA: 0x003248D4 File Offset: 0x00322AD4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600D526 RID: 54566 RVA: 0x00324914 File Offset: 0x00322B14
		public int PortalBallEntityId
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

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600D527 RID: 54567 RVA: 0x00324954 File Offset: 0x00322B54
		public string BlessSelectDesc
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

		// Token: 0x0600D528 RID: 54568 RVA: 0x0032498C File Offset: 0x00322B8C
		public Span<byte> GetBlessSelectDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D529 RID: 54569 RVA: 0x0032499C File Offset: 0x00322B9C
		public byte[] GetBlessSelectDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D52A RID: 54570 RVA: 0x003249B4 File Offset: 0x00322BB4
		public int BlessVoice(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600D52B RID: 54571 RVA: 0x003249F4 File Offset: 0x00322BF4
		public int BlessVoiceLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x00324A20 File Offset: 0x00322C20
		public Span<int> GetBlessVoiceBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600D52D RID: 54573 RVA: 0x00324A30 File Offset: 0x00322C30
		public int[] GetBlessVoiceArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x00324A48 File Offset: 0x00322C48
		[NullableContext(1)]
		public Dictionary<int, int> BlessRoleWeightChange()
		{
			return this.BlessRoleWeightChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x00324A9E File Offset: 0x00322C9E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BlessRoleWeightChangeIter()
		{
			RoverRogueBlessRole.<BlessRoleWeightChangeIter>d__72 <BlessRoleWeightChangeIter>d__ = new RoverRogueBlessRole.<BlessRoleWeightChangeIter>d__72(-2);
			<BlessRoleWeightChangeIter>d__.<>3__<>4__this = this;
			return <BlessRoleWeightChangeIter>d__;
		}

		// Token: 0x0600D530 RID: 54576 RVA: 0x00324AB3 File Offset: 0x00322CB3
		[NullableContext(1)]
		public int[] BlessVoice()
		{
			return this.GetBlessVoiceArray();
		}

		// Token: 0x0600D531 RID: 54577 RVA: 0x00324ABB File Offset: 0x00322CBB
		[NullableContext(1)]
		public IEnumerable<int> BlessVoiceIter()
		{
			RoverRogueBlessRole.<BlessVoiceIter>d__74 <BlessVoiceIter>d__ = new RoverRogueBlessRole.<BlessVoiceIter>d__74(-2);
			<BlessVoiceIter>d__.<>3__<>4__this = this;
			return <BlessVoiceIter>d__;
		}

		// Token: 0x0600D532 RID: 54578 RVA: 0x00324AD0 File Offset: 0x00322CD0
		[NullableContext(1)]
		public int[] EnableRoleType()
		{
			return this.GetEnableRoleTypeArray();
		}

		// Token: 0x0600D533 RID: 54579 RVA: 0x00324AD8 File Offset: 0x00322CD8
		[NullableContext(1)]
		public IEnumerable<int> EnableRoleTypeIter()
		{
			RoverRogueBlessRole.<EnableRoleTypeIter>d__76 <EnableRoleTypeIter>d__ = new RoverRogueBlessRole.<EnableRoleTypeIter>d__76(-2);
			<EnableRoleTypeIter>d__.<>3__<>4__this = this;
			return <EnableRoleTypeIter>d__;
		}

		// Token: 0x0600D534 RID: 54580 RVA: 0x00324AF0 File Offset: 0x00322CF0
		public int? GetBlessRoleWeightChange(int key)
		{
			this.EnsureBlessRoleWeightChangeCacheIfNeeded();
			int value;
			if (!this.BlessRoleWeightChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D535 RID: 54581 RVA: 0x00324B24 File Offset: 0x00322D24
		private void EnsureBlessRoleWeightChangeCacheIfNeeded()
		{
			if (this.BlessRoleWeightChangeCache != null)
			{
				return;
			}
			this.BlessRoleWeightChangeCache = this.BlessRoleWeightChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D536 RID: 54582 RVA: 0x00324B8A File Offset: 0x00322D8A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBlessRoleWeightChangeFrozenDict()
		{
			this.EnsureBlessRoleWeightChangeCacheIfNeeded();
			return this.BlessRoleWeightChangeCache;
		}

		// Token: 0x0400577C RID: 22396
		private Table __p;

		// Token: 0x0400577D RID: 22397
		[Nullable(2)]
		private FrozenDictionary<int, int> BlessRoleWeightChangeCache;
	}
}
