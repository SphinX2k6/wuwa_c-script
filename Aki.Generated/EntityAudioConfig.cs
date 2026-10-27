using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C32 RID: 3122
	public struct EntityAudioConfig : IFlatbufferObject
	{
		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06006945 RID: 26949 RVA: 0x0022372D File Offset: 0x0022192D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x0022373A File Offset: 0x0022193A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00223744 File Offset: 0x00221944
		public static EntityAudioConfig GetRootAsEntityAudioConfig(ByteBuffer _bb)
		{
			return EntityAudioConfig.GetRootAsEntityAudioConfig(_bb, default(EntityAudioConfig));
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00223760 File Offset: 0x00221960
		public static EntityAudioConfig GetRootAsEntityAudioConfig(ByteBuffer _bb, EntityAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x0022377D File Offset: 0x0022197D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x0022378C File Offset: 0x0022198C
		public EntityAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x0022379C File Offset: 0x0022199C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x002237D3 File Offset: 0x002219D3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x002237E2 File Offset: 0x002219E2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x0600694E RID: 26958 RVA: 0x002237FC File Offset: 0x002219FC
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

		// Token: 0x0600694F RID: 26959 RVA: 0x00223833 File Offset: 0x00221A33
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00223842 File Offset: 0x00221A42
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06006951 RID: 26961 RVA: 0x0022385C File Offset: 0x00221A5C
		public bool EnableVb
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06006952 RID: 26962 RVA: 0x0022389C File Offset: 0x00221A9C
		public string RtpcName
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

		// Token: 0x06006953 RID: 26963 RVA: 0x002238D4 File Offset: 0x00221AD4
		public Span<byte> GetRtpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x002238E4 File Offset: 0x00221AE4
		public byte[] GetRtpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x002238FC File Offset: 0x00221AFC
		public float TriggerDistance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 500f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00223940 File Offset: 0x00221B40
		public string BoneHiddenSwitch(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x0022397C File Offset: 0x00221B7C
		public int BoneHiddenSwitchLength
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

		// Token: 0x06006958 RID: 26968 RVA: 0x002239A8 File Offset: 0x00221BA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BoneHiddenSwitchIter()或GetBoneHiddenSwitchBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BoneHiddenSwitch()
		{
			return this.BoneHiddenSwitchIter().ToArray<string>();
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x002239B5 File Offset: 0x00221BB5
		[NullableContext(1)]
		public readonly IEnumerable<string> BoneHiddenSwitchIter()
		{
			EntityAudioConfig.<BoneHiddenSwitchIter>d__28 <BoneHiddenSwitchIter>d__ = new EntityAudioConfig.<BoneHiddenSwitchIter>d__28(-2);
			<BoneHiddenSwitchIter>d__.<>3__<>4__this = this;
			return <BoneHiddenSwitchIter>d__;
		}

		// Token: 0x04004C72 RID: 19570
		private Table __p;
	}
}
