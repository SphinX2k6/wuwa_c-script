using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBD RID: 4029
	public struct PhantomBattleNPC : IFlatbufferObject
	{
		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x0600ADC8 RID: 44488 RVA: 0x002CE250 File Offset: 0x002CC450
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x002CE25D File Offset: 0x002CC45D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x002CE264 File Offset: 0x002CC464
		public static PhantomBattleNPC GetRootAsPhantomBattleNPC(ByteBuffer _bb)
		{
			return PhantomBattleNPC.GetRootAsPhantomBattleNPC(_bb, default(PhantomBattleNPC));
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x002CE280 File Offset: 0x002CC480
		public static PhantomBattleNPC GetRootAsPhantomBattleNPC(ByteBuffer _bb, PhantomBattleNPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x002CE29D File Offset: 0x002CC49D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADCD RID: 44493 RVA: 0x002CE2AC File Offset: 0x002CC4AC
		public PhantomBattleNPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x002CE2BC File Offset: 0x002CC4BC
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

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600ADCF RID: 44495 RVA: 0x002CE2F8 File Offset: 0x002CC4F8
		public int GroupId
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

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x002CE334 File Offset: 0x002CC534
		public int BTId
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

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x002CE370 File Offset: 0x002CC570
		public int CardGroupId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x002CE3B0 File Offset: 0x002CC5B0
		public int CardGroupIdLength
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

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x002CE3DC File Offset: 0x002CC5DC
		public Span<int> GetCardGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x002CE3EC File Offset: 0x002CC5EC
		public int[] GetCardGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x002CE404 File Offset: 0x002CC604
		[NullableContext(1)]
		public int[] CardGroupId()
		{
			return this.GetCardGroupIdArray();
		}

		// Token: 0x0600ADD6 RID: 44502 RVA: 0x002CE40C File Offset: 0x002CC60C
		[NullableContext(1)]
		public IEnumerable<int> CardGroupIdIter()
		{
			PhantomBattleNPC.<CardGroupIdIter>d__20 <CardGroupIdIter>d__ = new PhantomBattleNPC.<CardGroupIdIter>d__20(-2);
			<CardGroupIdIter>d__.<>3__<>4__this = this;
			return <CardGroupIdIter>d__;
		}

		// Token: 0x0400557B RID: 21883
		private Table __p;
	}
}
