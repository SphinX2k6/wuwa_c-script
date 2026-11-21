using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D15 RID: 3349
	public struct EntityAudioConfig : IFlatbufferObject
	{
		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x00242A91 File Offset: 0x00240C91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00242A9E File Offset: 0x00240C9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x00242AA8 File Offset: 0x00240CA8
		public static EntityAudioConfig GetRootAsEntityAudioConfig(ByteBuffer _bb)
		{
			return EntityAudioConfig.GetRootAsEntityAudioConfig(_bb, default(EntityAudioConfig));
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x00242AC4 File Offset: 0x00240CC4
		public static EntityAudioConfig GetRootAsEntityAudioConfig(ByteBuffer _bb, EntityAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00242AE1 File Offset: 0x00240CE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00242AF0 File Offset: 0x00240CF0
		public EntityAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06006F4D RID: 28493 RVA: 0x00242B00 File Offset: 0x00240D00
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

		// Token: 0x06006F4E RID: 28494 RVA: 0x00242B37 File Offset: 0x00240D37
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x00242B46 File Offset: 0x00240D46
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x00242B60 File Offset: 0x00240D60
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

		// Token: 0x06006F51 RID: 28497 RVA: 0x00242B97 File Offset: 0x00240D97
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x00242BA6 File Offset: 0x00240DA6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06006F53 RID: 28499 RVA: 0x00242BC0 File Offset: 0x00240DC0
		public bool EnableVb
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x00242C00 File Offset: 0x00240E00
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

		// Token: 0x06006F55 RID: 28501 RVA: 0x00242C38 File Offset: 0x00240E38
		public Span<byte> GetRtpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00242C48 File Offset: 0x00240E48
		public byte[] GetRtpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06006F57 RID: 28503 RVA: 0x00242C60 File Offset: 0x00240E60
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

		// Token: 0x06006F58 RID: 28504 RVA: 0x00242CA4 File Offset: 0x00240EA4
		public string BoneHiddenSwitch(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06006F59 RID: 28505 RVA: 0x00242CE0 File Offset: 0x00240EE0
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

		// Token: 0x06006F5A RID: 28506 RVA: 0x00242D0C File Offset: 0x00240F0C
		[NullableContext(1)]
		public string[] BoneHiddenSwitch()
		{
			return this.BoneHiddenSwitchIter().ToArray<string>();
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x00242D19 File Offset: 0x00240F19
		[NullableContext(1)]
		public IEnumerable<string> BoneHiddenSwitchIter()
		{
			EntityAudioConfig.<BoneHiddenSwitchIter>d__28 <BoneHiddenSwitchIter>d__ = new EntityAudioConfig.<BoneHiddenSwitchIter>d__28(-2);
			<BoneHiddenSwitchIter>d__.<>3__<>4__this = this;
			return <BoneHiddenSwitchIter>d__;
		}

		// Token: 0x04005255 RID: 21077
		private Table __p;
	}
}
