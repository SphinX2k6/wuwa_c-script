using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F66 RID: 3942
	public struct NewbieCourseV2 : IFlatbufferObject
	{
		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600A479 RID: 42105 RVA: 0x002B9678 File Offset: 0x002B7878
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x002B9685 File Offset: 0x002B7885
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x002B968C File Offset: 0x002B788C
		public static NewbieCourseV2 GetRootAsNewbieCourseV2(ByteBuffer _bb)
		{
			return NewbieCourseV2.GetRootAsNewbieCourseV2(_bb, default(NewbieCourseV2));
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x002B96A8 File Offset: 0x002B78A8
		public static NewbieCourseV2 GetRootAsNewbieCourseV2(ByteBuffer _bb, NewbieCourseV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x002B96C5 File Offset: 0x002B78C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x002B96D4 File Offset: 0x002B78D4
		public NewbieCourseV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x002B96E4 File Offset: 0x002B78E4
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

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600A480 RID: 42112 RVA: 0x002B9720 File Offset: 0x002B7920
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

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x002B975C File Offset: 0x002B795C
		public int TargetLevel
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

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x0600A482 RID: 42114 RVA: 0x002B9798 File Offset: 0x002B7998
		public int Reward
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

		// Token: 0x0600A483 RID: 42115 RVA: 0x002B97D8 File Offset: 0x002B79D8
		public int WeaponPreviewList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x0600A484 RID: 42116 RVA: 0x002B9818 File Offset: 0x002B7A18
		public int WeaponPreviewListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x002B9844 File Offset: 0x002B7A44
		public Span<int> GetWeaponPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x002B9854 File Offset: 0x002B7A54
		public int[] GetWeaponPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x002B986C File Offset: 0x002B7A6C
		[NullableContext(1)]
		public int[] WeaponPreviewList()
		{
			return this.GetWeaponPreviewListArray();
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x002B9874 File Offset: 0x002B7A74
		[NullableContext(1)]
		public IEnumerable<int> WeaponPreviewListIter()
		{
			NewbieCourseV2.<WeaponPreviewListIter>d__22 <WeaponPreviewListIter>d__ = new NewbieCourseV2.<WeaponPreviewListIter>d__22(-2);
			<WeaponPreviewListIter>d__.<>3__<>4__this = this;
			return <WeaponPreviewListIter>d__;
		}

		// Token: 0x04005514 RID: 21780
		private Table __p;
	}
}
