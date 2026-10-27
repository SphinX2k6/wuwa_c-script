using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E11 RID: 3601
	public struct MonsterDetection : IFlatbufferObject
	{
		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x060094A0 RID: 38048 RVA: 0x002869F9 File Offset: 0x00284BF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00286A06 File Offset: 0x00284C06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00286A10 File Offset: 0x00284C10
		public static MonsterDetection GetRootAsMonsterDetection(ByteBuffer _bb)
		{
			return MonsterDetection.GetRootAsMonsterDetection(_bb, default(MonsterDetection));
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00286A2C File Offset: 0x00284C2C
		public static MonsterDetection GetRootAsMonsterDetection(ByteBuffer _bb, MonsterDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00286A49 File Offset: 0x00284C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00286A58 File Offset: 0x00284C58
		public MonsterDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x00286A68 File Offset: 0x00284C68
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

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x060094A7 RID: 38055 RVA: 0x00286AA4 File Offset: 0x00284CA4
		public string BlueprintType
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

		// Token: 0x060094A8 RID: 38056 RVA: 0x00286ADB File Offset: 0x00284CDB
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00286AEA File Offset: 0x00284CEA
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x00286B04 File Offset: 0x00284D04
		public int MarkId
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

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x00286B40 File Offset: 0x00284D40
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

		// Token: 0x060094AC RID: 38060 RVA: 0x00286B78 File Offset: 0x00284D78
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00286B88 File Offset: 0x00284D88
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x060094AE RID: 38062 RVA: 0x00286BA0 File Offset: 0x00284DA0
		public int ShowReward
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

		// Token: 0x060094AF RID: 38063 RVA: 0x00286BE0 File Offset: 0x00284DE0
		public string BlueprintTypeList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x060094B0 RID: 38064 RVA: 0x00286C1C File Offset: 0x00284E1C
		public int BlueprintTypeListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x060094B1 RID: 38065 RVA: 0x00286C48 File Offset: 0x00284E48
		public int EntityConfigId
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

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x00286C88 File Offset: 0x00284E88
		public int DangerType
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x060094B3 RID: 38067 RVA: 0x00286CC8 File Offset: 0x00284EC8
		public int TypeDescription2
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

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x00286D08 File Offset: 0x00284F08
		public string AttributesDescriptionLock
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

		// Token: 0x060094B5 RID: 38069 RVA: 0x00286D40 File Offset: 0x00284F40
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00286D50 File Offset: 0x00284F50
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x060094B7 RID: 38071 RVA: 0x00286D68 File Offset: 0x00284F68
		public string AttributesDescriptionUnlock
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

		// Token: 0x060094B8 RID: 38072 RVA: 0x00286DA0 File Offset: 0x00284FA0
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00286DB0 File Offset: 0x00284FB0
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x060094BA RID: 38074 RVA: 0x00286DC8 File Offset: 0x00284FC8
		public string BigIcon
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

		// Token: 0x060094BB RID: 38075 RVA: 0x00286E00 File Offset: 0x00285000
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00286E10 File Offset: 0x00285010
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x060094BD RID: 38077 RVA: 0x00286E28 File Offset: 0x00285028
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

		// Token: 0x060094BE RID: 38078 RVA: 0x00286E60 File Offset: 0x00285060
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00286E70 File Offset: 0x00285070
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x060094C0 RID: 38080 RVA: 0x00286E88 File Offset: 0x00285088
		public string TemporaryIconUnLock
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

		// Token: 0x060094C1 RID: 38081 RVA: 0x00286EC0 File Offset: 0x002850C0
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00286ED0 File Offset: 0x002850D0
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x060094C3 RID: 38083 RVA: 0x00286EE8 File Offset: 0x002850E8
		public string TemporaryIconlock
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

		// Token: 0x060094C4 RID: 38084 RVA: 0x00286F20 File Offset: 0x00285120
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00286F30 File Offset: 0x00285130
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x00286F48 File Offset: 0x00285148
		public int BeginTimeStamp
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

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x060094C7 RID: 38087 RVA: 0x00286F88 File Offset: 0x00285188
		public int LockCon
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

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x060094C8 RID: 38088 RVA: 0x00286FC8 File Offset: 0x002851C8
		public int MonsterInfoId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x060094C9 RID: 38089 RVA: 0x00287008 File Offset: 0x00285208
		public int NightMareDetectionId
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

		// Token: 0x060094CA RID: 38090 RVA: 0x00287045 File Offset: 0x00285245
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlueprintTypeListIter()或GetBlueprintTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BlueprintTypeList()
		{
			return this.BlueprintTypeListIter().ToArray<string>();
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00287052 File Offset: 0x00285252
		[NullableContext(1)]
		public readonly IEnumerable<string> BlueprintTypeListIter()
		{
			MonsterDetection.<BlueprintTypeListIter>d__64 <BlueprintTypeListIter>d__ = new MonsterDetection.<BlueprintTypeListIter>d__64(-2);
			<BlueprintTypeListIter>d__.<>3__<>4__this = this;
			return <BlueprintTypeListIter>d__;
		}

		// Token: 0x04004EB6 RID: 20150
		private Table __p;
	}
}
