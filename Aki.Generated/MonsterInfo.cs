using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFD RID: 3837
	public struct MonsterInfo : IFlatbufferObject
	{
		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06009B4A RID: 39754 RVA: 0x002A5A3D File Offset: 0x002A3C3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x002A5A4A File Offset: 0x002A3C4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x002A5A54 File Offset: 0x002A3C54
		public static MonsterInfo GetRootAsMonsterInfo(ByteBuffer _bb)
		{
			return MonsterInfo.GetRootAsMonsterInfo(_bb, default(MonsterInfo));
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x002A5A70 File Offset: 0x002A3C70
		public static MonsterInfo GetRootAsMonsterInfo(ByteBuffer _bb, MonsterInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x002A5A8D File Offset: 0x002A3C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x002A5A9C File Offset: 0x002A3C9C
		public MonsterInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06009B50 RID: 39760 RVA: 0x002A5AAC File Offset: 0x002A3CAC
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

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06009B51 RID: 39761 RVA: 0x002A5AE8 File Offset: 0x002A3CE8
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

		// Token: 0x06009B52 RID: 39762 RVA: 0x002A5B1F File Offset: 0x002A3D1F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x002A5B2E File Offset: 0x002A3D2E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x002A5B48 File Offset: 0x002A3D48
		public int RarityId
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

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06009B55 RID: 39765 RVA: 0x002A5B84 File Offset: 0x002A3D84
		public string Icon
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

		// Token: 0x06009B56 RID: 39766 RVA: 0x002A5BBC File Offset: 0x002A3DBC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x002A5BCC File Offset: 0x002A3DCC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06009B58 RID: 39768 RVA: 0x002A5BE4 File Offset: 0x002A3DE4
		public string BigIcon
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

		// Token: 0x06009B59 RID: 39769 RVA: 0x002A5C1C File Offset: 0x002A3E1C
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x002A5C2C File Offset: 0x002A3E2C
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06009B5B RID: 39771 RVA: 0x002A5C44 File Offset: 0x002A3E44
		public string Tachine
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

		// Token: 0x06009B5C RID: 39772 RVA: 0x002A5C7C File Offset: 0x002A3E7C
		public Span<byte> GetTachineBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x002A5C8C File Offset: 0x002A3E8C
		public byte[] GetTachineArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x002A5CA4 File Offset: 0x002A3EA4
		public int ElementIdArray(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x002A5CE4 File Offset: 0x002A3EE4
		public int ElementIdArrayLength
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

		// Token: 0x06009B60 RID: 39776 RVA: 0x002A5D10 File Offset: 0x002A3F10
		public Span<int> GetElementIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x002A5D20 File Offset: 0x002A3F20
		public int[] GetElementIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06009B62 RID: 39778 RVA: 0x002A5D38 File Offset: 0x002A3F38
		public string MonsterEntityID
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

		// Token: 0x06009B63 RID: 39779 RVA: 0x002A5D70 File Offset: 0x002A3F70
		public Span<byte> GetMonsterEntityIDBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x002A5D80 File Offset: 0x002A3F80
		public byte[] GetMonsterEntityIDArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x002A5D98 File Offset: 0x002A3F98
		public string MonsterPose
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

		// Token: 0x06009B66 RID: 39782 RVA: 0x002A5DD0 File Offset: 0x002A3FD0
		public Span<byte> GetMonsterPoseBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x002A5DE0 File Offset: 0x002A3FE0
		public byte[] GetMonsterPoseArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06009B68 RID: 39784 RVA: 0x002A5DF8 File Offset: 0x002A3FF8
		public string UndiscoveredDes
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

		// Token: 0x06009B69 RID: 39785 RVA: 0x002A5E30 File Offset: 0x002A4030
		public Span<byte> GetUndiscoveredDesBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x002A5E40 File Offset: 0x002A4040
		public byte[] GetUndiscoveredDesArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x002A5E58 File Offset: 0x002A4058
		public string DiscoveredDes
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

		// Token: 0x06009B6C RID: 39788 RVA: 0x002A5E90 File Offset: 0x002A4090
		public Span<byte> GetDiscoveredDesBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x002A5EA0 File Offset: 0x002A40A0
		public byte[] GetDiscoveredDesArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x002A5EB8 File Offset: 0x002A40B8
		public int PerchId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x002A5EF8 File Offset: 0x002A40F8
		public int PerchIdLength
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

		// Token: 0x06009B70 RID: 39792 RVA: 0x002A5F24 File Offset: 0x002A4124
		public Span<int> GetPerchIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x002A5F34 File Offset: 0x002A4134
		public int[] GetPerchIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x002A5F4C File Offset: 0x002A414C
		[NullableContext(1)]
		public int[] ElementIdArray()
		{
			return this.GetElementIdArrayArray();
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x002A5F54 File Offset: 0x002A4154
		[NullableContext(1)]
		public IEnumerable<int> ElementIdArrayIter()
		{
			MonsterInfo.<ElementIdArrayIter>d__55 <ElementIdArrayIter>d__ = new MonsterInfo.<ElementIdArrayIter>d__55(-2);
			<ElementIdArrayIter>d__.<>3__<>4__this = this;
			return <ElementIdArrayIter>d__;
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x002A5F69 File Offset: 0x002A4169
		[NullableContext(1)]
		public int[] PerchId()
		{
			return this.GetPerchIdArray();
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x002A5F71 File Offset: 0x002A4171
		[NullableContext(1)]
		public IEnumerable<int> PerchIdIter()
		{
			MonsterInfo.<PerchIdIter>d__57 <PerchIdIter>d__ = new MonsterInfo.<PerchIdIter>d__57(-2);
			<PerchIdIter>d__.<>3__<>4__this = this;
			return <PerchIdIter>d__;
		}

		// Token: 0x040054A2 RID: 21666
		private Table __p;
	}
}
