using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131A RID: 4890
	public struct SpecialBarEffectPercentInfo : IFlatbufferObject
	{
		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0600F907 RID: 63751 RVA: 0x00375489 File Offset: 0x00373689
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x00375496 File Offset: 0x00373696
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x003754A0 File Offset: 0x003736A0
		public static SpecialBarEffectPercentInfo GetRootAsSpecialBarEffectPercentInfo(ByteBuffer _bb)
		{
			return SpecialBarEffectPercentInfo.GetRootAsSpecialBarEffectPercentInfo(_bb, default(SpecialBarEffectPercentInfo));
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x003754BC File Offset: 0x003736BC
		public static SpecialBarEffectPercentInfo GetRootAsSpecialBarEffectPercentInfo(ByteBuffer _bb, SpecialBarEffectPercentInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x003754D9 File Offset: 0x003736D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x003754E8 File Offset: 0x003736E8
		public SpecialBarEffectPercentInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x0600F90D RID: 63757 RVA: 0x003754F8 File Offset: 0x003736F8
		public int MinPercent
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

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x0600F90E RID: 63758 RVA: 0x00375534 File Offset: 0x00373734
		public int MaxPercent
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

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x0600F90F RID: 63759 RVA: 0x00375570 File Offset: 0x00373770
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x0600F910 RID: 63760 RVA: 0x003755B0 File Offset: 0x003737B0
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x0600F911 RID: 63761 RVA: 0x003755F4 File Offset: 0x003737F4
		public string FloatParameterName
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

		// Token: 0x0600F912 RID: 63762 RVA: 0x0037562C File Offset: 0x0037382C
		public Span<byte> GetFloatParameterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x0037563C File Offset: 0x0037383C
		public byte[] GetFloatParameterNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040059A0 RID: 22944
		private Table __p;
	}
}
