using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE3 RID: 3043
	public struct AreaTerminal : IFlatbufferObject
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06004E2B RID: 20011 RVA: 0x001F7EE0 File Offset: 0x001F60E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x001F7EED File Offset: 0x001F60ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x001F7EF4 File Offset: 0x001F60F4
		public static AreaTerminal GetRootAsAreaTerminal(ByteBuffer _bb)
		{
			return AreaTerminal.GetRootAsAreaTerminal(_bb, default(AreaTerminal));
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x001F7F10 File Offset: 0x001F6110
		public static AreaTerminal GetRootAsAreaTerminal(ByteBuffer _bb, AreaTerminal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x001F7F2D File Offset: 0x001F612D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x001F7F3C File Offset: 0x001F613C
		public AreaTerminal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06004E31 RID: 20017 RVA: 0x001F7F4C File Offset: 0x001F614C
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x001F7F88 File Offset: 0x001F6188
		public int Country
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x001F7FC4 File Offset: 0x001F61C4
		public string Name
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

		// Token: 0x06004E34 RID: 20020 RVA: 0x001F7FFB File Offset: 0x001F61FB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x001F800A File Offset: 0x001F620A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x001F8024 File Offset: 0x001F6224
		public string TagName
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

		// Token: 0x06004E37 RID: 20023 RVA: 0x001F805C File Offset: 0x001F625C
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x001F806C File Offset: 0x001F626C
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x001F8084 File Offset: 0x001F6284
		public string Desc
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

		// Token: 0x06004E3A RID: 20026 RVA: 0x001F80BC File Offset: 0x001F62BC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x001F80CC File Offset: 0x001F62CC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x001F80E4 File Offset: 0x001F62E4
		public string Icon
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

		// Token: 0x06004E3D RID: 20029 RVA: 0x001F811C File Offset: 0x001F631C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x001F812C File Offset: 0x001F632C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06004E3F RID: 20031 RVA: 0x001F8144 File Offset: 0x001F6344
		public string TexBgLock
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

		// Token: 0x06004E40 RID: 20032 RVA: 0x001F817C File Offset: 0x001F637C
		public Span<byte> GetTexBgLockBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x001F818C File Offset: 0x001F638C
		public byte[] GetTexBgLockArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x001F81A4 File Offset: 0x001F63A4
		public string TexBg
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

		// Token: 0x06004E43 RID: 20035 RVA: 0x001F81DC File Offset: 0x001F63DC
		public Span<byte> GetTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x001F81EC File Offset: 0x001F63EC
		public byte[] GetTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x001F8204 File Offset: 0x001F6404
		public int SortId
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06004E46 RID: 20038 RVA: 0x001F8244 File Offset: 0x001F6444
		public int GroupId
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

		// Token: 0x06004E47 RID: 20039 RVA: 0x001F8284 File Offset: 0x001F6484
		public int Area(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x001F82C4 File Offset: 0x001F64C4
		public int AreaLength
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

		// Token: 0x06004E49 RID: 20041 RVA: 0x001F82F0 File Offset: 0x001F64F0
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x001F8300 File Offset: 0x001F6500
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06004E4B RID: 20043 RVA: 0x001F8318 File Offset: 0x001F6518
		public string AreaForbiddenTips
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

		// Token: 0x06004E4C RID: 20044 RVA: 0x001F8350 File Offset: 0x001F6550
		public Span<byte> GetAreaForbiddenTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x001F8360 File Offset: 0x001F6560
		public byte[] GetAreaForbiddenTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x001F8378 File Offset: 0x001F6578
		public int AreaMapGroup(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x001F83B8 File Offset: 0x001F65B8
		public int AreaMapGroupLength
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

		// Token: 0x06004E50 RID: 20048 RVA: 0x001F83E4 File Offset: 0x001F65E4
		public Span<int> GetAreaMapGroupBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x001F83F4 File Offset: 0x001F65F4
		public int[] GetAreaMapGroupArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x001F840C File Offset: 0x001F660C
		public string UnlockButtonText
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

		// Token: 0x06004E53 RID: 20051 RVA: 0x001F8444 File Offset: 0x001F6644
		public Span<byte> GetUnlockButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x001F8454 File Offset: 0x001F6654
		public byte[] GetUnlockButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x001F846C File Offset: 0x001F666C
		public int GamePlayType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x001F84AC File Offset: 0x001F66AC
		public int GamePlayId
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x001F84EC File Offset: 0x001F66EC
		public int RewardPreview
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

		// Token: 0x06004E58 RID: 20056 RVA: 0x001F8529 File Offset: 0x001F6729
		[NullableContext(1)]
		public int[] Area()
		{
			return this.GetAreaArray();
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x001F8531 File Offset: 0x001F6731
		[NullableContext(1)]
		public IEnumerable<int> AreaIter()
		{
			AreaTerminal.<AreaIter>d__65 <AreaIter>d__ = new AreaTerminal.<AreaIter>d__65(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x001F8546 File Offset: 0x001F6746
		[NullableContext(1)]
		public int[] AreaMapGroup()
		{
			return this.GetAreaMapGroupArray();
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x001F854E File Offset: 0x001F674E
		[NullableContext(1)]
		public IEnumerable<int> AreaMapGroupIter()
		{
			AreaTerminal.<AreaMapGroupIter>d__67 <AreaMapGroupIter>d__ = new AreaTerminal.<AreaMapGroupIter>d__67(-2);
			<AreaMapGroupIter>d__.<>3__<>4__this = this;
			return <AreaMapGroupIter>d__;
		}

		// Token: 0x040050C8 RID: 20680
		private Table __p;
	}
}
