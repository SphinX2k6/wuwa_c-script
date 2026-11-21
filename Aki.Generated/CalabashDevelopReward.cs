using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3C RID: 3132
	public struct CalabashDevelopReward : IFlatbufferObject
	{
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x0020D6AC File Offset: 0x0020B8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0020D6B9 File Offset: 0x0020B8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x0020D6C0 File Offset: 0x0020B8C0
		public static CalabashDevelopReward GetRootAsCalabashDevelopReward(ByteBuffer _bb)
		{
			return CalabashDevelopReward.GetRootAsCalabashDevelopReward(_bb, default(CalabashDevelopReward));
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x0020D6DC File Offset: 0x0020B8DC
		public static CalabashDevelopReward GetRootAsCalabashDevelopReward(ByteBuffer _bb, CalabashDevelopReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x0020D6F9 File Offset: 0x0020B8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0020D708 File Offset: 0x0020B908
		public CalabashDevelopReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x0020D718 File Offset: 0x0020B918
		public int MonsterId
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x0020D754 File Offset: 0x0020B954
		public int InteractAreaId
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

		// Token: 0x06005773 RID: 22387 RVA: 0x0020D790 File Offset: 0x0020B990
		public int DevelopCondition(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x0020D7D0 File Offset: 0x0020B9D0
		public int DevelopConditionLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x0020D7FB File Offset: 0x0020B9FB
		public Span<int> GetDevelopConditionBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x0020D80A File Offset: 0x0020BA0A
		public int[] GetDevelopConditionArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06005777 RID: 22391 RVA: 0x0020D824 File Offset: 0x0020BA24
		public int MonsterInfoId
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

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x0020D864 File Offset: 0x0020BA64
		public int AllExp
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

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x0020D8A4 File Offset: 0x0020BAA4
		public int SortId
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x0020D8E4 File Offset: 0x0020BAE4
		public int MonsterProbeId
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

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x0020D924 File Offset: 0x0020BB24
		public string HandBookBp
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

		// Token: 0x0600577C RID: 22396 RVA: 0x0020D95C File Offset: 0x0020BB5C
		public Span<byte> GetHandBookBpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x0020D96C File Offset: 0x0020BB6C
		public byte[] GetHandBookBpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x0020D984 File Offset: 0x0020BB84
		public int MonsterBodyType
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

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x0020D9C4 File Offset: 0x0020BBC4
		public string HandBookCamera
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

		// Token: 0x06005780 RID: 22400 RVA: 0x0020D9FC File Offset: 0x0020BBFC
		public Span<byte> GetHandBookCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x0020DA0C File Offset: 0x0020BC0C
		public byte[] GetHandBookCameraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x0020DA24 File Offset: 0x0020BC24
		public string MonsterNumber
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

		// Token: 0x06005783 RID: 22403 RVA: 0x0020DA5C File Offset: 0x0020BC5C
		public Span<byte> GetMonsterNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0020DA6C File Offset: 0x0020BC6C
		public byte[] GetMonsterNumberArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x0020DA84 File Offset: 0x0020BC84
		public int InteractionRadius
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

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06005786 RID: 22406 RVA: 0x0020DAC4 File Offset: 0x0020BCC4
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x0020DB04 File Offset: 0x0020BD04
		public bool AllowVision
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06005788 RID: 22408 RVA: 0x0020DB44 File Offset: 0x0020BD44
		public bool IsWorldInteractable
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x0020DB84 File Offset: 0x0020BD84
		public string SpecialSkillName
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

		// Token: 0x0600578A RID: 22410 RVA: 0x0020DBBC File Offset: 0x0020BDBC
		public Span<byte> GetSpecialSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x0020DBCC File Offset: 0x0020BDCC
		public byte[] GetSpecialSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x0020DBE4 File Offset: 0x0020BDE4
		public string SpecialSkillDescription
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

		// Token: 0x0600578D RID: 22413 RVA: 0x0020DC1C File Offset: 0x0020BE1C
		public Span<byte> GetSpecialSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x0020DC2C File Offset: 0x0020BE2C
		public byte[] GetSpecialSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x0020DC44 File Offset: 0x0020BE44
		public string SpecialSkillPicturePath
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

		// Token: 0x06005790 RID: 22416 RVA: 0x0020DC7C File Offset: 0x0020BE7C
		public Span<byte> GetSpecialSkillPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x0020DC8C File Offset: 0x0020BE8C
		public byte[] GetSpecialSkillPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x0020DCA4 File Offset: 0x0020BEA4
		public int VisionCoolDown
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x0020DCE4 File Offset: 0x0020BEE4
		public int InteractAreaList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x0020DD24 File Offset: 0x0020BF24
		public int InteractAreaListLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x0020DD50 File Offset: 0x0020BF50
		public Span<int> GetInteractAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x0020DD60 File Offset: 0x0020BF60
		public int[] GetInteractAreaListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x0020DD78 File Offset: 0x0020BF78
		public int ItemAccess
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x0020DDB5 File Offset: 0x0020BFB5
		[NullableContext(1)]
		public int[] DevelopCondition()
		{
			return this.GetDevelopConditionArray();
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x0020DDBD File Offset: 0x0020BFBD
		[NullableContext(1)]
		public IEnumerable<int> DevelopConditionIter()
		{
			CalabashDevelopReward.<DevelopConditionIter>d__69 <DevelopConditionIter>d__ = new CalabashDevelopReward.<DevelopConditionIter>d__69(-2);
			<DevelopConditionIter>d__.<>3__<>4__this = this;
			return <DevelopConditionIter>d__;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x0020DDD2 File Offset: 0x0020BFD2
		[NullableContext(1)]
		public int[] InteractAreaList()
		{
			return this.GetInteractAreaListArray();
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x0020DDDA File Offset: 0x0020BFDA
		[NullableContext(1)]
		public IEnumerable<int> InteractAreaListIter()
		{
			CalabashDevelopReward.<InteractAreaListIter>d__71 <InteractAreaListIter>d__ = new CalabashDevelopReward.<InteractAreaListIter>d__71(-2);
			<InteractAreaListIter>d__.<>3__<>4__this = this;
			return <InteractAreaListIter>d__;
		}

		// Token: 0x0400513A RID: 20794
		private Table __p;
	}
}
