using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BEB RID: 3051
	public struct AutoPilotCircles : IFlatbufferObject
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x001F9CC4 File Offset: 0x001F7EC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x001F9CD1 File Offset: 0x001F7ED1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x001F9CD8 File Offset: 0x001F7ED8
		public static AutoPilotCircles GetRootAsAutoPilotCircles(ByteBuffer _bb)
		{
			return AutoPilotCircles.GetRootAsAutoPilotCircles(_bb, default(AutoPilotCircles));
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x001F9CF4 File Offset: 0x001F7EF4
		public static AutoPilotCircles GetRootAsAutoPilotCircles(ByteBuffer _bb, AutoPilotCircles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x001F9D11 File Offset: 0x001F7F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x001F9D20 File Offset: 0x001F7F20
		public AutoPilotCircles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x001F9D30 File Offset: 0x001F7F30
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x001F9D6C File Offset: 0x001F7F6C
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

		// Token: 0x06004F02 RID: 20226 RVA: 0x001F9DA3 File Offset: 0x001F7FA3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x001F9DB2 File Offset: 0x001F7FB2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x001F9DCC File Offset: 0x001F7FCC
		public string Description
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

		// Token: 0x06004F05 RID: 20229 RVA: 0x001F9E03 File Offset: 0x001F8003
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x001F9E12 File Offset: 0x001F8012
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x001F9E2C File Offset: 0x001F802C
		public int CreatorId
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x001F9E6C File Offset: 0x001F806C
		public int MapId
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

		// Token: 0x06004F09 RID: 20233 RVA: 0x001F9EAC File Offset: 0x001F80AC
		public int WaySplines(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x001F9EEC File Offset: 0x001F80EC
		public int WaySplinesLength
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

		// Token: 0x06004F0B RID: 20235 RVA: 0x001F9F18 File Offset: 0x001F8118
		public Span<int> GetWaySplinesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x001F9F28 File Offset: 0x001F8128
		public int[] GetWaySplinesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x001F9F40 File Offset: 0x001F8140
		[NullableContext(1)]
		public int[] WaySplines()
		{
			return this.GetWaySplinesArray();
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x001F9F48 File Offset: 0x001F8148
		[NullableContext(1)]
		public IEnumerable<int> WaySplinesIter()
		{
			AutoPilotCircles.<WaySplinesIter>d__28 <WaySplinesIter>d__ = new AutoPilotCircles.<WaySplinesIter>d__28(-2);
			<WaySplinesIter>d__.<>3__<>4__this = this;
			return <WaySplinesIter>d__;
		}

		// Token: 0x040050D3 RID: 20691
		private Table __p;
	}
}
