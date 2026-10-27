using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E18 RID: 3608
	public struct MonsterInfo : IFlatbufferObject
	{
		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600952A RID: 38186 RVA: 0x00287C75 File Offset: 0x00285E75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x00287C82 File Offset: 0x00285E82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x00287C8C File Offset: 0x00285E8C
		public static MonsterInfo GetRootAsMonsterInfo(ByteBuffer _bb)
		{
			return MonsterInfo.GetRootAsMonsterInfo(_bb, default(MonsterInfo));
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00287CA8 File Offset: 0x00285EA8
		public static MonsterInfo GetRootAsMonsterInfo(ByteBuffer _bb, MonsterInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00287CC5 File Offset: 0x00285EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x00287CD4 File Offset: 0x00285ED4
		public MonsterInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00287CE4 File Offset: 0x00285EE4
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

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06009531 RID: 38193 RVA: 0x00287D20 File Offset: 0x00285F20
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

		// Token: 0x06009532 RID: 38194 RVA: 0x00287D57 File Offset: 0x00285F57
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x00287D66 File Offset: 0x00285F66
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00287D80 File Offset: 0x00285F80
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

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x00287DBC File Offset: 0x00285FBC
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

		// Token: 0x06009536 RID: 38198 RVA: 0x00287DF4 File Offset: 0x00285FF4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x00287E04 File Offset: 0x00286004
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x00287E1C File Offset: 0x0028601C
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

		// Token: 0x06009539 RID: 38201 RVA: 0x00287E54 File Offset: 0x00286054
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x00287E64 File Offset: 0x00286064
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600953B RID: 38203 RVA: 0x00287E7C File Offset: 0x0028607C
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

		// Token: 0x0600953C RID: 38204 RVA: 0x00287EB4 File Offset: 0x002860B4
		public Span<byte> GetTachineBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00287EC4 File Offset: 0x002860C4
		public byte[] GetTachineArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x00287EDC File Offset: 0x002860DC
		public int ElementIdArray(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600953F RID: 38207 RVA: 0x00287F1C File Offset: 0x0028611C
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

		// Token: 0x06009540 RID: 38208 RVA: 0x00287F48 File Offset: 0x00286148
		public Span<int> GetElementIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x00287F58 File Offset: 0x00286158
		public int[] GetElementIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x00287F70 File Offset: 0x00286170
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

		// Token: 0x06009543 RID: 38211 RVA: 0x00287FA8 File Offset: 0x002861A8
		public Span<byte> GetMonsterEntityIDBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x00287FB8 File Offset: 0x002861B8
		public byte[] GetMonsterEntityIDArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x00287FD0 File Offset: 0x002861D0
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

		// Token: 0x06009546 RID: 38214 RVA: 0x00288008 File Offset: 0x00286208
		public Span<byte> GetMonsterPoseBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00288018 File Offset: 0x00286218
		public byte[] GetMonsterPoseArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x00288030 File Offset: 0x00286230
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

		// Token: 0x06009549 RID: 38217 RVA: 0x00288068 File Offset: 0x00286268
		public Span<byte> GetUndiscoveredDesBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00288078 File Offset: 0x00286278
		public byte[] GetUndiscoveredDesArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600954B RID: 38219 RVA: 0x00288090 File Offset: 0x00286290
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

		// Token: 0x0600954C RID: 38220 RVA: 0x002880C8 File Offset: 0x002862C8
		public Span<byte> GetDiscoveredDesBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x002880D8 File Offset: 0x002862D8
		public byte[] GetDiscoveredDesArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x002880F0 File Offset: 0x002862F0
		public int PerchId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600954F RID: 38223 RVA: 0x00288130 File Offset: 0x00286330
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

		// Token: 0x06009550 RID: 38224 RVA: 0x0028815C File Offset: 0x0028635C
		public Span<int> GetPerchIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x0028816C File Offset: 0x0028636C
		public int[] GetPerchIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00288184 File Offset: 0x00286384
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementIdArrayIter()或GetElementIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ElementIdArray()
		{
			MonsterInfo monsterInfo = this;
			return monsterInfo.GetElementIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x002881A8 File Offset: 0x002863A8
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementIdArrayIter()
		{
			MonsterInfo.<ElementIdArrayIter>d__55 <ElementIdArrayIter>d__ = new MonsterInfo.<ElementIdArrayIter>d__55(-2);
			<ElementIdArrayIter>d__.<>3__<>4__this = this;
			return <ElementIdArrayIter>d__;
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x002881C0 File Offset: 0x002863C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PerchIdIter()或GetPerchIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PerchId()
		{
			MonsterInfo monsterInfo = this;
			return monsterInfo.GetPerchIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x002881E4 File Offset: 0x002863E4
		[NullableContext(1)]
		public readonly IEnumerable<int> PerchIdIter()
		{
			MonsterInfo.<PerchIdIter>d__57 <PerchIdIter>d__ = new MonsterInfo.<PerchIdIter>d__57(-2);
			<PerchIdIter>d__.<>3__<>4__this = this;
			return <PerchIdIter>d__;
		}

		// Token: 0x04004EBD RID: 20157
		private Table __p;
	}
}
