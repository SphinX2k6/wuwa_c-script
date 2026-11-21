using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129C RID: 4764
	[Obfuscation]
	public struct TrapDefenseMonster : IFlatbufferObject
	{
		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x0600F167 RID: 61799 RVA: 0x003647C7 File Offset: 0x003629C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F168 RID: 61800 RVA: 0x003647D4 File Offset: 0x003629D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F169 RID: 61801 RVA: 0x003647DC File Offset: 0x003629DC
		public static TrapDefenseMonster GetRootAsTrapDefenseMonster(ByteBuffer _bb)
		{
			return TrapDefenseMonster.GetRootAsTrapDefenseMonster(_bb, default(TrapDefenseMonster));
		}

		// Token: 0x0600F16A RID: 61802 RVA: 0x003647F8 File Offset: 0x003629F8
		public static TrapDefenseMonster GetRootAsTrapDefenseMonster(ByteBuffer _bb, TrapDefenseMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F16B RID: 61803 RVA: 0x00364815 File Offset: 0x00362A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F16C RID: 61804 RVA: 0x00364824 File Offset: 0x00362A24
		public TrapDefenseMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x0600F16D RID: 61805 RVA: 0x00364834 File Offset: 0x00362A34
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

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x0600F16E RID: 61806 RVA: 0x00364870 File Offset: 0x00362A70
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

		// Token: 0x0600F16F RID: 61807 RVA: 0x003648A7 File Offset: 0x00362AA7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F170 RID: 61808 RVA: 0x003648B6 File Offset: 0x00362AB6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x0600F171 RID: 61809 RVA: 0x003648D0 File Offset: 0x00362AD0
		public string Desc
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

		// Token: 0x0600F172 RID: 61810 RVA: 0x00364907 File Offset: 0x00362B07
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F173 RID: 61811 RVA: 0x00364916 File Offset: 0x00362B16
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F174 RID: 61812 RVA: 0x00364930 File Offset: 0x00362B30
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x0600F175 RID: 61813 RVA: 0x0036496C File Offset: 0x00362B6C
		public int DescArgsLength
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

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x0600F176 RID: 61814 RVA: 0x00364998 File Offset: 0x00362B98
		public int MonsterType
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

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0600F177 RID: 61815 RVA: 0x003649D8 File Offset: 0x00362BD8
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600F178 RID: 61816 RVA: 0x00364A18 File Offset: 0x00362C18
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0600F179 RID: 61817 RVA: 0x00364A58 File Offset: 0x00362C58
		public int InitBuffsLength
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

		// Token: 0x0600F17A RID: 61818 RVA: 0x00364A84 File Offset: 0x00362C84
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600F17B RID: 61819 RVA: 0x00364A94 File Offset: 0x00362C94
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0600F17C RID: 61820 RVA: 0x00364AAC File Offset: 0x00362CAC
		public int DropGold
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

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0600F17D RID: 61821 RVA: 0x00364AEC File Offset: 0x00362CEC
		public int Deathrattle
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

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0600F17E RID: 61822 RVA: 0x00364B2C File Offset: 0x00362D2C
		public int CampDamage
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

		// Token: 0x0600F17F RID: 61823 RVA: 0x00364B6C File Offset: 0x00362D6C
		public int Tag(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0600F180 RID: 61824 RVA: 0x00364BAC File Offset: 0x00362DAC
		public int TagLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F181 RID: 61825 RVA: 0x00364BD8 File Offset: 0x00362DD8
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600F182 RID: 61826 RVA: 0x00364BE8 File Offset: 0x00362DE8
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600F183 RID: 61827 RVA: 0x00364C00 File Offset: 0x00362E00
		public string TagDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0600F184 RID: 61828 RVA: 0x00364C3C File Offset: 0x00362E3C
		public int TagDescLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F185 RID: 61829 RVA: 0x00364C68 File Offset: 0x00362E68
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0600F186 RID: 61830 RVA: 0x00364CA8 File Offset: 0x00362EA8
		public int AttrShowLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F187 RID: 61831 RVA: 0x00364CD4 File Offset: 0x00362ED4
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600F188 RID: 61832 RVA: 0x00364CE4 File Offset: 0x00362EE4
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0600F189 RID: 61833 RVA: 0x00364CFC File Offset: 0x00362EFC
		public int Sort
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

		// Token: 0x0600F18A RID: 61834 RVA: 0x00364D39 File Offset: 0x00362F39
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x0600F18B RID: 61835 RVA: 0x00364D41 File Offset: 0x00362F41
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			TrapDefenseMonster.<AttrShowIter>d__52 <AttrShowIter>d__ = new TrapDefenseMonster.<AttrShowIter>d__52(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600F18C RID: 61836 RVA: 0x00364D56 File Offset: 0x00362F56
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600F18D RID: 61837 RVA: 0x00364D63 File Offset: 0x00362F63
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			TrapDefenseMonster.<DescArgsIter>d__54 <DescArgsIter>d__ = new TrapDefenseMonster.<DescArgsIter>d__54(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600F18E RID: 61838 RVA: 0x00364D78 File Offset: 0x00362F78
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x0600F18F RID: 61839 RVA: 0x00364D80 File Offset: 0x00362F80
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			TrapDefenseMonster.<InitBuffsIter>d__56 <InitBuffsIter>d__ = new TrapDefenseMonster.<InitBuffsIter>d__56(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x00364D95 File Offset: 0x00362F95
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x0600F191 RID: 61841 RVA: 0x00364D9D File Offset: 0x00362F9D
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			TrapDefenseMonster.<TagIter>d__58 <TagIter>d__ = new TrapDefenseMonster.<TagIter>d__58(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600F192 RID: 61842 RVA: 0x00364DB2 File Offset: 0x00362FB2
		[NullableContext(1)]
		public string[] TagDesc()
		{
			return this.TagDescIter().ToArray<string>();
		}

		// Token: 0x0600F193 RID: 61843 RVA: 0x00364DBF File Offset: 0x00362FBF
		[NullableContext(1)]
		public IEnumerable<string> TagDescIter()
		{
			TrapDefenseMonster.<TagDescIter>d__60 <TagDescIter>d__ = new TrapDefenseMonster.<TagDescIter>d__60(-2);
			<TagDescIter>d__.<>3__<>4__this = this;
			return <TagDescIter>d__;
		}

		// Token: 0x040058EF RID: 22767
		private Table __p;
	}
}
