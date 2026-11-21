using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001272 RID: 4722
	public struct TowerDefencePhantomLevel : IFlatbufferObject
	{
		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600ED72 RID: 60786 RVA: 0x0035BCD0 File Offset: 0x00359ED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED73 RID: 60787 RVA: 0x0035BCDD File Offset: 0x00359EDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED74 RID: 60788 RVA: 0x0035BCE4 File Offset: 0x00359EE4
		public static TowerDefencePhantomLevel GetRootAsTowerDefencePhantomLevel(ByteBuffer _bb)
		{
			return TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(_bb, default(TowerDefencePhantomLevel));
		}

		// Token: 0x0600ED75 RID: 60789 RVA: 0x0035BD00 File Offset: 0x00359F00
		public static TowerDefencePhantomLevel GetRootAsTowerDefencePhantomLevel(ByteBuffer _bb, TowerDefencePhantomLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED76 RID: 60790 RVA: 0x0035BD1D File Offset: 0x00359F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED77 RID: 60791 RVA: 0x0035BD2C File Offset: 0x00359F2C
		public TowerDefencePhantomLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x0035BD3C File Offset: 0x00359F3C
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

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600ED79 RID: 60793 RVA: 0x0035BD78 File Offset: 0x00359F78
		public int GroupId
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

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600ED7A RID: 60794 RVA: 0x0035BDB4 File Offset: 0x00359FB4
		public int Level
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

		// Token: 0x0600ED7B RID: 60795 RVA: 0x0035BDF0 File Offset: 0x00359FF0
		public long SkillId(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600ED7C RID: 60796 RVA: 0x0035BE3C File Offset: 0x0035A03C
		public int SkillIdLength
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

		// Token: 0x0600ED7D RID: 60797 RVA: 0x0035BE68 File Offset: 0x0035A068
		public Span<long> GetSkillIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x0035BE7D File Offset: 0x0035A07D
		public long[] GetSkillIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600ED7F RID: 60799 RVA: 0x0035BEBC File Offset: 0x0035A0BC
		public string Title
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

		// Token: 0x0600ED80 RID: 60800 RVA: 0x0035BEF4 File Offset: 0x0035A0F4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x0035BF04 File Offset: 0x0035A104
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600ED82 RID: 60802 RVA: 0x0035BF1C File Offset: 0x0035A11C
		public string Description
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

		// Token: 0x0600ED83 RID: 60803 RVA: 0x0035BF54 File Offset: 0x0035A154
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x0035BF64 File Offset: 0x0035A164
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600ED85 RID: 60805 RVA: 0x0035BF7C File Offset: 0x0035A17C
		public int ExpLevel
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

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600ED86 RID: 60806 RVA: 0x0035BFBC File Offset: 0x0035A1BC
		public string UnlockDescription
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

		// Token: 0x0600ED87 RID: 60807 RVA: 0x0035BFF4 File Offset: 0x0035A1F4
		public Span<byte> GetUnlockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x0035C004 File Offset: 0x0035A204
		public byte[] GetUnlockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600ED89 RID: 60809 RVA: 0x0035C01C File Offset: 0x0035A21C
		public int PhantomSkill
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

		// Token: 0x0600ED8A RID: 60810 RVA: 0x0035C059 File Offset: 0x0035A259
		[NullableContext(1)]
		public long[] SkillId()
		{
			return this.GetSkillIdArray();
		}

		// Token: 0x0600ED8B RID: 60811 RVA: 0x0035C061 File Offset: 0x0035A261
		[NullableContext(1)]
		public IEnumerable<long> SkillIdIter()
		{
			TowerDefencePhantomLevel.<SkillIdIter>d__36 <SkillIdIter>d__ = new TowerDefencePhantomLevel.<SkillIdIter>d__36(-2);
			<SkillIdIter>d__.<>3__<>4__this = this;
			return <SkillIdIter>d__;
		}

		// Token: 0x040058C0 RID: 22720
		private Table __p;
	}
}
