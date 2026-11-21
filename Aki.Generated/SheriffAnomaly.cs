using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001197 RID: 4503
	public struct SheriffAnomaly : IFlatbufferObject
	{
		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600D86E RID: 55406 RVA: 0x0032B7E0 File Offset: 0x003299E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x0032B7ED File Offset: 0x003299ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x0032B7F4 File Offset: 0x003299F4
		public static SheriffAnomaly GetRootAsSheriffAnomaly(ByteBuffer _bb)
		{
			return SheriffAnomaly.GetRootAsSheriffAnomaly(_bb, default(SheriffAnomaly));
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x0032B810 File Offset: 0x00329A10
		public static SheriffAnomaly GetRootAsSheriffAnomaly(ByteBuffer _bb, SheriffAnomaly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x0032B82D File Offset: 0x00329A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x0032B83C File Offset: 0x00329A3C
		public SheriffAnomaly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600D874 RID: 55412 RVA: 0x0032B84C File Offset: 0x00329A4C
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600D875 RID: 55413 RVA: 0x0032B888 File Offset: 0x00329A88
		public int QuestionId
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

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600D876 RID: 55414 RVA: 0x0032B8C4 File Offset: 0x00329AC4
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

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600D877 RID: 55415 RVA: 0x0032B900 File Offset: 0x00329B00
		public int CriminalId
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

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600D878 RID: 55416 RVA: 0x0032B940 File Offset: 0x00329B40
		public int Type
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

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600D879 RID: 55417 RVA: 0x0032B980 File Offset: 0x00329B80
		public int UnlockConditionGroupId
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

		// Token: 0x0600D87A RID: 55418 RVA: 0x0032B9C0 File Offset: 0x00329BC0
		public int UnlockMarkIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600D87B RID: 55419 RVA: 0x0032BA00 File Offset: 0x00329C00
		public int UnlockMarkIdsLength
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

		// Token: 0x0600D87C RID: 55420 RVA: 0x0032BA2C File Offset: 0x00329C2C
		public Span<int> GetUnlockMarkIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x0032BA3C File Offset: 0x00329C3C
		public int[] GetUnlockMarkIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600D87E RID: 55422 RVA: 0x0032BA54 File Offset: 0x00329C54
		public string Name
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

		// Token: 0x0600D87F RID: 55423 RVA: 0x0032BA8C File Offset: 0x00329C8C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x0032BA9C File Offset: 0x00329C9C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600D881 RID: 55425 RVA: 0x0032BAB4 File Offset: 0x00329CB4
		public int SheriffZoneId
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

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600D882 RID: 55426 RVA: 0x0032BAF4 File Offset: 0x00329CF4
		public int MainBTId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600D883 RID: 55427 RVA: 0x0032BB34 File Offset: 0x00329D34
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600D884 RID: 55428 RVA: 0x0032BB74 File Offset: 0x00329D74
		public int ClueLessCount
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600D885 RID: 55429 RVA: 0x0032BBB4 File Offset: 0x00329DB4
		public string BTParamName
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

		// Token: 0x0600D886 RID: 55430 RVA: 0x0032BBEC File Offset: 0x00329DEC
		public Span<byte> GetBTParamNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x0032BBFC File Offset: 0x00329DFC
		public byte[] GetBTParamNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600D888 RID: 55432 RVA: 0x0032BC14 File Offset: 0x00329E14
		public int TextVisibleScale
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D889 RID: 55433 RVA: 0x0032BC51 File Offset: 0x00329E51
		[NullableContext(1)]
		public int[] UnlockMarkIds()
		{
			return this.GetUnlockMarkIdsArray();
		}

		// Token: 0x0600D88A RID: 55434 RVA: 0x0032BC59 File Offset: 0x00329E59
		[NullableContext(1)]
		public IEnumerable<int> UnlockMarkIdsIter()
		{
			SheriffAnomaly.<UnlockMarkIdsIter>d__44 <UnlockMarkIdsIter>d__ = new SheriffAnomaly.<UnlockMarkIdsIter>d__44(-2);
			<UnlockMarkIdsIter>d__.<>3__<>4__this = this;
			return <UnlockMarkIdsIter>d__;
		}

		// Token: 0x040057A9 RID: 22441
		private Table __p;
	}
}
