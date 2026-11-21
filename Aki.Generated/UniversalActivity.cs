using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C0 RID: 4800
	public struct UniversalActivity : IFlatbufferObject
	{
		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x0600F450 RID: 62544 RVA: 0x0036AF92 File Offset: 0x00369192
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F451 RID: 62545 RVA: 0x0036AF9F File Offset: 0x0036919F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F452 RID: 62546 RVA: 0x0036AFA8 File Offset: 0x003691A8
		public static UniversalActivity GetRootAsUniversalActivity(ByteBuffer _bb)
		{
			return UniversalActivity.GetRootAsUniversalActivity(_bb, default(UniversalActivity));
		}

		// Token: 0x0600F453 RID: 62547 RVA: 0x0036AFC4 File Offset: 0x003691C4
		public static UniversalActivity GetRootAsUniversalActivity(ByteBuffer _bb, UniversalActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F454 RID: 62548 RVA: 0x0036AFE1 File Offset: 0x003691E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F455 RID: 62549 RVA: 0x0036AFF0 File Offset: 0x003691F0
		public UniversalActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x0600F456 RID: 62550 RVA: 0x0036B000 File Offset: 0x00369200
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

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x0600F457 RID: 62551 RVA: 0x0036B03C File Offset: 0x0036923C
		public string UiResource
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

		// Token: 0x0600F458 RID: 62552 RVA: 0x0036B073 File Offset: 0x00369273
		public Span<byte> GetUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F459 RID: 62553 RVA: 0x0036B082 File Offset: 0x00369282
		public byte[] GetUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x0600F45A RID: 62554 RVA: 0x0036B09C File Offset: 0x0036929C
		public int FunctionType
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

		// Token: 0x0600F45B RID: 62555 RVA: 0x0036B0D8 File Offset: 0x003692D8
		public string FunctionParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x0600F45C RID: 62556 RVA: 0x0036B114 File Offset: 0x00369314
		public int FunctionParamsLength
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

		// Token: 0x0600F45D RID: 62557 RVA: 0x0036B140 File Offset: 0x00369340
		[NullableContext(1)]
		public string[] FunctionParams()
		{
			return this.FunctionParamsIter().ToArray<string>();
		}

		// Token: 0x0600F45E RID: 62558 RVA: 0x0036B14D File Offset: 0x0036934D
		[NullableContext(1)]
		public IEnumerable<string> FunctionParamsIter()
		{
			UniversalActivity.<FunctionParamsIter>d__20 <FunctionParamsIter>d__ = new UniversalActivity.<FunctionParamsIter>d__20(-2);
			<FunctionParamsIter>d__.<>3__<>4__this = this;
			return <FunctionParamsIter>d__;
		}

		// Token: 0x04005916 RID: 22806
		private Table __p;
	}
}
