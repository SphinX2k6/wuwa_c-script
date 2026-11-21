using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBA RID: 4026
	public struct PhantomBattleMapParam : IFlatbufferObject
	{
		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x0600AD93 RID: 44435 RVA: 0x002CDACE File Offset: 0x002CBCCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x002CDADB File Offset: 0x002CBCDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x002CDAE4 File Offset: 0x002CBCE4
		public static PhantomBattleMapParam GetRootAsPhantomBattleMapParam(ByteBuffer _bb)
		{
			return PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(_bb, default(PhantomBattleMapParam));
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x002CDB00 File Offset: 0x002CBD00
		public static PhantomBattleMapParam GetRootAsPhantomBattleMapParam(ByteBuffer _bb, PhantomBattleMapParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x002CDB1D File Offset: 0x002CBD1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x002CDB2C File Offset: 0x002CBD2C
		public PhantomBattleMapParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x0600AD99 RID: 44441 RVA: 0x002CDB3C File Offset: 0x002CBD3C
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

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600AD9A RID: 44442 RVA: 0x002CDB78 File Offset: 0x002CBD78
		public int MapId
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

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x002CDBB4 File Offset: 0x002CBDB4
		public int BigMapDefaultScale
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

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600AD9C RID: 44444 RVA: 0x002CDBF0 File Offset: 0x002CBDF0
		public int BigMapMinScale
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

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600AD9D RID: 44445 RVA: 0x002CDC30 File Offset: 0x002CBE30
		public int BigMapMaxScale
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

		// Token: 0x0600AD9E RID: 44446 RVA: 0x002CDC70 File Offset: 0x002CBE70
		public string TileRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600AD9F RID: 44447 RVA: 0x002CDCAC File Offset: 0x002CBEAC
		public int TileRangeLength
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

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600ADA0 RID: 44448 RVA: 0x002CDCD8 File Offset: 0x002CBED8
		public string MapName
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

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x002CDD10 File Offset: 0x002CBF10
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x002CDD20 File Offset: 0x002CBF20
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x002CDD38 File Offset: 0x002CBF38
		[NullableContext(1)]
		public string[] TileRange()
		{
			return this.TileRangeIter().ToArray<string>();
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x002CDD45 File Offset: 0x002CBF45
		[NullableContext(1)]
		public IEnumerable<string> TileRangeIter()
		{
			PhantomBattleMapParam.<TileRangeIter>d__26 <TileRangeIter>d__ = new PhantomBattleMapParam.<TileRangeIter>d__26(-2);
			<TileRangeIter>d__.<>3__<>4__this = this;
			return <TileRangeIter>d__;
		}

		// Token: 0x04005578 RID: 21880
		private Table __p;
	}
}
