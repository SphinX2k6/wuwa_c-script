using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E58 RID: 3672
	public struct InstanceGameplayMode : IFlatbufferObject
	{
		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x00282614 File Offset: 0x00280814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00282621 File Offset: 0x00280821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00282628 File Offset: 0x00280828
		public static InstanceGameplayMode GetRootAsInstanceGameplayMode(ByteBuffer _bb)
		{
			return InstanceGameplayMode.GetRootAsInstanceGameplayMode(_bb, default(InstanceGameplayMode));
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x00282644 File Offset: 0x00280844
		public static InstanceGameplayMode GetRootAsInstanceGameplayMode(ByteBuffer _bb, InstanceGameplayMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x00282661 File Offset: 0x00280861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x00282670 File Offset: 0x00280870
		public InstanceGameplayMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00282680 File Offset: 0x00280880
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

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06008BAC RID: 35756 RVA: 0x002826BC File Offset: 0x002808BC
		public bool DisableAllPlayerRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x002826FC File Offset: 0x002808FC
		public int DefaultCameraMode
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

		// Token: 0x06008BAE RID: 35758 RVA: 0x00282738 File Offset: 0x00280938
		public int CameraParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06008BAF RID: 35759 RVA: 0x00282778 File Offset: 0x00280978
		public int CameraParamsLength
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

		// Token: 0x06008BB0 RID: 35760 RVA: 0x002827A4 File Offset: 0x002809A4
		public Span<int> GetCameraParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x002827B4 File Offset: 0x002809B4
		public int[] GetCameraParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x002827CC File Offset: 0x002809CC
		[NullableContext(1)]
		public int[] CameraParams()
		{
			return this.GetCameraParamsArray();
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x002827D4 File Offset: 0x002809D4
		[NullableContext(1)]
		public IEnumerable<int> CameraParamsIter()
		{
			InstanceGameplayMode.<CameraParamsIter>d__20 <CameraParamsIter>d__ = new InstanceGameplayMode.<CameraParamsIter>d__20(-2);
			<CameraParamsIter>d__.<>3__<>4__this = this;
			return <CameraParamsIter>d__;
		}

		// Token: 0x040053E0 RID: 21472
		private Table __p;
	}
}
