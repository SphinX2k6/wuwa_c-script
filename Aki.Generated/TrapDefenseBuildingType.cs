using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001294 RID: 4756
	public struct TrapDefenseBuildingType : IFlatbufferObject
	{
		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0600F09C RID: 61596 RVA: 0x00362C60 File Offset: 0x00360E60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F09D RID: 61597 RVA: 0x00362C6D File Offset: 0x00360E6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F09E RID: 61598 RVA: 0x00362C74 File Offset: 0x00360E74
		public static TrapDefenseBuildingType GetRootAsTrapDefenseBuildingType(ByteBuffer _bb)
		{
			return TrapDefenseBuildingType.GetRootAsTrapDefenseBuildingType(_bb, default(TrapDefenseBuildingType));
		}

		// Token: 0x0600F09F RID: 61599 RVA: 0x00362C90 File Offset: 0x00360E90
		public static TrapDefenseBuildingType GetRootAsTrapDefenseBuildingType(ByteBuffer _bb, TrapDefenseBuildingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F0A0 RID: 61600 RVA: 0x00362CAD File Offset: 0x00360EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F0A1 RID: 61601 RVA: 0x00362CBC File Offset: 0x00360EBC
		public TrapDefenseBuildingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0600F0A2 RID: 61602 RVA: 0x00362CCC File Offset: 0x00360ECC
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

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0600F0A3 RID: 61603 RVA: 0x00362D08 File Offset: 0x00360F08
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

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0600F0A4 RID: 61604 RVA: 0x00362D44 File Offset: 0x00360F44
		public int SortId
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

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0600F0A5 RID: 61605 RVA: 0x00362D80 File Offset: 0x00360F80
		public string Name
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

		// Token: 0x0600F0A6 RID: 61606 RVA: 0x00362DB8 File Offset: 0x00360FB8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F0A7 RID: 61607 RVA: 0x00362DC8 File Offset: 0x00360FC8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x00362DE0 File Offset: 0x00360FE0
		public int TemplateId
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

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x0600F0A9 RID: 61609 RVA: 0x00362E20 File Offset: 0x00361020
		public int DamageType
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

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x0600F0AA RID: 61610 RVA: 0x00362E60 File Offset: 0x00361060
		public int PlacementType
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

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x00362EA0 File Offset: 0x003610A0
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0600F0AC RID: 61612 RVA: 0x00362EE0 File Offset: 0x003610E0
		public int InitMaxLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0600F0AD RID: 61613 RVA: 0x00362F20 File Offset: 0x00361120
		public bool IsInitUnlocked
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x00362F60 File Offset: 0x00361160
		public int BranchCount
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F0AF RID: 61615 RVA: 0x00362FA0 File Offset: 0x003611A0
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x00362FE0 File Offset: 0x003611E0
		public int AttrShowLength
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

		// Token: 0x0600F0B1 RID: 61617 RVA: 0x0036300C File Offset: 0x0036120C
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600F0B2 RID: 61618 RVA: 0x0036301C File Offset: 0x0036121C
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0600F0B3 RID: 61619 RVA: 0x00363034 File Offset: 0x00361234
		public string Icon
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

		// Token: 0x0600F0B4 RID: 61620 RVA: 0x0036306C File Offset: 0x0036126C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600F0B5 RID: 61621 RVA: 0x0036307C File Offset: 0x0036127C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x0600F0B6 RID: 61622 RVA: 0x00363094 File Offset: 0x00361294
		public string VideoName
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

		// Token: 0x0600F0B7 RID: 61623 RVA: 0x003630CC File Offset: 0x003612CC
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600F0B8 RID: 61624 RVA: 0x003630DC File Offset: 0x003612DC
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x0600F0B9 RID: 61625 RVA: 0x003630F4 File Offset: 0x003612F4
		public string VideoPath
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

		// Token: 0x0600F0BA RID: 61626 RVA: 0x0036312C File Offset: 0x0036132C
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600F0BB RID: 61627 RVA: 0x0036313C File Offset: 0x0036133C
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x0600F0BC RID: 61628 RVA: 0x00363154 File Offset: 0x00361354
		public bool CanRotate
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00363194 File Offset: 0x00361394
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x0600F0BE RID: 61630 RVA: 0x0036319C File Offset: 0x0036139C
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			TrapDefenseBuildingType.<AttrShowIter>d__52 <AttrShowIter>d__ = new TrapDefenseBuildingType.<AttrShowIter>d__52(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x040058E6 RID: 22758
		private Table __p;
	}
}
