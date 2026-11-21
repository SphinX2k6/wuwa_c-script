using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103E RID: 4158
	public struct PreOpenDetection : IFlatbufferObject
	{
		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600B960 RID: 47456 RVA: 0x002E797C File Offset: 0x002E5B7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x002E7989 File Offset: 0x002E5B89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x002E7990 File Offset: 0x002E5B90
		public static PreOpenDetection GetRootAsPreOpenDetection(ByteBuffer _bb)
		{
			return PreOpenDetection.GetRootAsPreOpenDetection(_bb, default(PreOpenDetection));
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x002E79AC File Offset: 0x002E5BAC
		public static PreOpenDetection GetRootAsPreOpenDetection(ByteBuffer _bb, PreOpenDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x002E79C9 File Offset: 0x002E5BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x002E79D8 File Offset: 0x002E5BD8
		public PreOpenDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600B966 RID: 47462 RVA: 0x002E79E8 File Offset: 0x002E5BE8
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

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600B967 RID: 47463 RVA: 0x002E7A24 File Offset: 0x002E5C24
		public int SoundAreaType
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

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600B968 RID: 47464 RVA: 0x002E7A60 File Offset: 0x002E5C60
		public int PlayType
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

		// Token: 0x0600B969 RID: 47465 RVA: 0x002E7A9C File Offset: 0x002E5C9C
		public int PlayTypeArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600B96A RID: 47466 RVA: 0x002E7ADC File Offset: 0x002E5CDC
		public int PlayTypeArrayLength
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

		// Token: 0x0600B96B RID: 47467 RVA: 0x002E7B08 File Offset: 0x002E5D08
		public Span<int> GetPlayTypeArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x002E7B18 File Offset: 0x002E5D18
		public int[] GetPlayTypeArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x002E7B30 File Offset: 0x002E5D30
		public int DetectionId
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

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0600B96E RID: 47470 RVA: 0x002E7B70 File Offset: 0x002E5D70
		public int ConditionGroup
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

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600B96F RID: 47471 RVA: 0x002E7BB0 File Offset: 0x002E5DB0
		public int TeleportEntityId
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

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600B970 RID: 47472 RVA: 0x002E7BF0 File Offset: 0x002E5DF0
		public int DungeonEntranceId
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

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600B971 RID: 47473 RVA: 0x002E7C30 File Offset: 0x002E5E30
		public int InstanceID
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

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600B972 RID: 47474 RVA: 0x002E7C70 File Offset: 0x002E5E70
		public bool Spoiler
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x002E7CB0 File Offset: 0x002E5EB0
		[NullableContext(1)]
		public int[] PlayTypeArray()
		{
			return this.GetPlayTypeArrayArray();
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x002E7CB8 File Offset: 0x002E5EB8
		[NullableContext(1)]
		public IEnumerable<int> PlayTypeArrayIter()
		{
			PreOpenDetection.<PlayTypeArrayIter>d__32 <PlayTypeArrayIter>d__ = new PreOpenDetection.<PlayTypeArrayIter>d__32(-2);
			<PlayTypeArrayIter>d__.<>3__<>4__this = this;
			return <PlayTypeArrayIter>d__;
		}

		// Token: 0x0400560B RID: 22027
		private Table __p;
	}
}
