using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F32 RID: 3890
	public struct MotorFightRole : IFlatbufferObject
	{
		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06009F47 RID: 40775 RVA: 0x002AE5AC File Offset: 0x002AC7AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x002AE5B9 File Offset: 0x002AC7B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x002AE5C0 File Offset: 0x002AC7C0
		public static MotorFightRole GetRootAsMotorFightRole(ByteBuffer _bb)
		{
			return MotorFightRole.GetRootAsMotorFightRole(_bb, default(MotorFightRole));
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x002AE5DC File Offset: 0x002AC7DC
		public static MotorFightRole GetRootAsMotorFightRole(ByteBuffer _bb, MotorFightRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x002AE5F9 File Offset: 0x002AC7F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x002AE608 File Offset: 0x002AC808
		public MotorFightRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06009F4D RID: 40781 RVA: 0x002AE618 File Offset: 0x002AC818
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

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06009F4E RID: 40782 RVA: 0x002AE654 File Offset: 0x002AC854
		public int ActivityId
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

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06009F4F RID: 40783 RVA: 0x002AE690 File Offset: 0x002AC890
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

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06009F50 RID: 40784 RVA: 0x002AE6CC File Offset: 0x002AC8CC
		public int UnlockCondition
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

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06009F51 RID: 40785 RVA: 0x002AE70C File Offset: 0x002AC90C
		public int TrialRole
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

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x002AE74C File Offset: 0x002AC94C
		public int Effect
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

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x002AE78C File Offset: 0x002AC98C
		public string BuffName
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

		// Token: 0x06009F54 RID: 40788 RVA: 0x002AE7C4 File Offset: 0x002AC9C4
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x002AE7D4 File Offset: 0x002AC9D4
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06009F56 RID: 40790 RVA: 0x002AE7EC File Offset: 0x002AC9EC
		public string BuffDesc
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

		// Token: 0x06009F57 RID: 40791 RVA: 0x002AE824 File Offset: 0x002ACA24
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x002AE834 File Offset: 0x002ACA34
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x002AE84C File Offset: 0x002ACA4C
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x002AE888 File Offset: 0x002ACA88
		public int BuffDescParamLength
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

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06009F5B RID: 40795 RVA: 0x002AE8B4 File Offset: 0x002ACAB4
		public string GenreDesc
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

		// Token: 0x06009F5C RID: 40796 RVA: 0x002AE8EC File Offset: 0x002ACAEC
		public Span<byte> GetGenreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x002AE8FC File Offset: 0x002ACAFC
		public byte[] GetGenreDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002AE914 File Offset: 0x002ACB14
		public string RolePicture
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

		// Token: 0x06009F5F RID: 40799 RVA: 0x002AE94C File Offset: 0x002ACB4C
		public Span<byte> GetRolePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x002AE95C File Offset: 0x002ACB5C
		public byte[] GetRolePictureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06009F61 RID: 40801 RVA: 0x002AE974 File Offset: 0x002ACB74
		public string RankRolePicture
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

		// Token: 0x06009F62 RID: 40802 RVA: 0x002AE9AC File Offset: 0x002ACBAC
		public Span<byte> GetRankRolePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x002AE9BC File Offset: 0x002ACBBC
		public byte[] GetRankRolePictureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06009F64 RID: 40804 RVA: 0x002AE9D4 File Offset: 0x002ACBD4
		public string MotorStandAnimPath
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

		// Token: 0x06009F65 RID: 40805 RVA: 0x002AEA0C File Offset: 0x002ACC0C
		public Span<byte> GetMotorStandAnimPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x002AEA1C File Offset: 0x002ACC1C
		public byte[] GetMotorStandAnimPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x002AEA34 File Offset: 0x002ACC34
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x002AEA41 File Offset: 0x002ACC41
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			MotorFightRole.<BuffDescParamIter>d__48 <BuffDescParamIter>d__ = new MotorFightRole.<BuffDescParamIter>d__48(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x040054DB RID: 21723
		private Table __p;
	}
}
