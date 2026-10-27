using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F59 RID: 3929
	public struct PreOpenDetection : IFlatbufferObject
	{
		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0600B33F RID: 45887 RVA: 0x002CB130 File Offset: 0x002C9330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x002CB13D File Offset: 0x002C933D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x002CB144 File Offset: 0x002C9344
		public static PreOpenDetection GetRootAsPreOpenDetection(ByteBuffer _bb)
		{
			return PreOpenDetection.GetRootAsPreOpenDetection(_bb, default(PreOpenDetection));
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x002CB160 File Offset: 0x002C9360
		public static PreOpenDetection GetRootAsPreOpenDetection(ByteBuffer _bb, PreOpenDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x002CB17D File Offset: 0x002C937D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x002CB18C File Offset: 0x002C938C
		public PreOpenDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600B345 RID: 45893 RVA: 0x002CB19C File Offset: 0x002C939C
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

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x002CB1D8 File Offset: 0x002C93D8
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

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600B347 RID: 45895 RVA: 0x002CB214 File Offset: 0x002C9414
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

		// Token: 0x0600B348 RID: 45896 RVA: 0x002CB250 File Offset: 0x002C9450
		public int PlayTypeArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x002CB290 File Offset: 0x002C9490
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

		// Token: 0x0600B34A RID: 45898 RVA: 0x002CB2BC File Offset: 0x002C94BC
		public Span<int> GetPlayTypeArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x002CB2CC File Offset: 0x002C94CC
		public int[] GetPlayTypeArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x002CB2E4 File Offset: 0x002C94E4
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

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600B34D RID: 45901 RVA: 0x002CB324 File Offset: 0x002C9524
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

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x002CB364 File Offset: 0x002C9564
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

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600B34F RID: 45903 RVA: 0x002CB3A4 File Offset: 0x002C95A4
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

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x002CB3E4 File Offset: 0x002C95E4
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

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600B351 RID: 45905 RVA: 0x002CB424 File Offset: 0x002C9624
		public bool Spoiler
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x002CB464 File Offset: 0x002C9664
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlayTypeArrayIter()或GetPlayTypeArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlayTypeArray()
		{
			PreOpenDetection preOpenDetection = this;
			return preOpenDetection.GetPlayTypeArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x002CB488 File Offset: 0x002C9688
		[NullableContext(1)]
		public readonly IEnumerable<int> PlayTypeArrayIter()
		{
			PreOpenDetection.<PlayTypeArrayIter>d__32 <PlayTypeArrayIter>d__ = new PreOpenDetection.<PlayTypeArrayIter>d__32(-2);
			<PlayTypeArrayIter>d__.<>3__<>4__this = this;
			return <PlayTypeArrayIter>d__;
		}

		// Token: 0x04005026 RID: 20518
		private Table __p;
	}
}
