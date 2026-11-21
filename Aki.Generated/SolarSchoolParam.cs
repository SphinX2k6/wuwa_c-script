using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F4 RID: 4596
	public struct SolarSchoolParam : IFlatbufferObject
	{
		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x0034347C File Offset: 0x0034167C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E277 RID: 57975 RVA: 0x00343489 File Offset: 0x00341689
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E278 RID: 57976 RVA: 0x00343490 File Offset: 0x00341690
		public static SolarSchoolParam GetRootAsSolarSchoolParam(ByteBuffer _bb)
		{
			return SolarSchoolParam.GetRootAsSolarSchoolParam(_bb, default(SolarSchoolParam));
		}

		// Token: 0x0600E279 RID: 57977 RVA: 0x003434AC File Offset: 0x003416AC
		public static SolarSchoolParam GetRootAsSolarSchoolParam(ByteBuffer _bb, SolarSchoolParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E27A RID: 57978 RVA: 0x003434C9 File Offset: 0x003416C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x003434D8 File Offset: 0x003416D8
		public SolarSchoolParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600E27C RID: 57980 RVA: 0x003434E8 File Offset: 0x003416E8
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

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600E27D RID: 57981 RVA: 0x00343524 File Offset: 0x00341724
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

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600E27E RID: 57982 RVA: 0x00343560 File Offset: 0x00341760
		public string Key
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E27F RID: 57983 RVA: 0x00343597 File Offset: 0x00341797
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E280 RID: 57984 RVA: 0x003435A6 File Offset: 0x003417A6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600E281 RID: 57985 RVA: 0x003435C0 File Offset: 0x003417C0
		public int IntValue
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

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x00343600 File Offset: 0x00341800
		public string StringValue
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

		// Token: 0x0600E283 RID: 57987 RVA: 0x00343638 File Offset: 0x00341838
		public Span<byte> GetStringValueBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E284 RID: 57988 RVA: 0x00343648 File Offset: 0x00341848
		public byte[] GetStringValueArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E285 RID: 57989 RVA: 0x00343660 File Offset: 0x00341860
		public int IntArrayValue(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600E286 RID: 57990 RVA: 0x003436A0 File Offset: 0x003418A0
		public int IntArrayValueLength
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

		// Token: 0x0600E287 RID: 57991 RVA: 0x003436CC File Offset: 0x003418CC
		public Span<int> GetIntArrayValueBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x003436DC File Offset: 0x003418DC
		public int[] GetIntArrayValueArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600E289 RID: 57993 RVA: 0x003436F4 File Offset: 0x003418F4
		public string Comments
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x0034372C File Offset: 0x0034192C
		public Span<byte> GetCommentsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x0034373C File Offset: 0x0034193C
		public byte[] GetCommentsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x00343754 File Offset: 0x00341954
		[NullableContext(1)]
		public int[] IntArrayValue()
		{
			return this.GetIntArrayValueArray();
		}

		// Token: 0x0600E28D RID: 57997 RVA: 0x0034375C File Offset: 0x0034195C
		[NullableContext(1)]
		public IEnumerable<int> IntArrayValueIter()
		{
			SolarSchoolParam.<IntArrayValueIter>d__32 <IntArrayValueIter>d__ = new SolarSchoolParam.<IntArrayValueIter>d__32(-2);
			<IntArrayValueIter>d__.<>3__<>4__this = this;
			return <IntArrayValueIter>d__;
		}

		// Token: 0x04005832 RID: 22578
		private Table __p;
	}
}
