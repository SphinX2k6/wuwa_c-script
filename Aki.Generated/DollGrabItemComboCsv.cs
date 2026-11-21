using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD7 RID: 3287
	public struct DollGrabItemComboCsv : IFlatbufferObject
	{
		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06006878 RID: 26744 RVA: 0x002339B8 File Offset: 0x00231BB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x002339C5 File Offset: 0x00231BC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x002339CC File Offset: 0x00231BCC
		public static DollGrabItemComboCsv GetRootAsDollGrabItemComboCsv(ByteBuffer _bb)
		{
			return DollGrabItemComboCsv.GetRootAsDollGrabItemComboCsv(_bb, default(DollGrabItemComboCsv));
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x002339E8 File Offset: 0x00231BE8
		public static DollGrabItemComboCsv GetRootAsDollGrabItemComboCsv(ByteBuffer _bb, DollGrabItemComboCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00233A05 File Offset: 0x00231C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x00233A14 File Offset: 0x00231C14
		public DollGrabItemComboCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600687E RID: 26750 RVA: 0x00233A24 File Offset: 0x00231C24
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x00233A60 File Offset: 0x00231C60
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

		// Token: 0x06006880 RID: 26752 RVA: 0x00233A97 File Offset: 0x00231C97
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x00233AA6 File Offset: 0x00231CA6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x00233AC0 File Offset: 0x00231CC0
		public int MainItemId
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

		// Token: 0x06006883 RID: 26755 RVA: 0x00233AFC File Offset: 0x00231CFC
		public int PartItemIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06006884 RID: 26756 RVA: 0x00233B3C File Offset: 0x00231D3C
		public int PartItemIdsLength
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

		// Token: 0x06006885 RID: 26757 RVA: 0x00233B68 File Offset: 0x00231D68
		public Span<int> GetPartItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x00233B78 File Offset: 0x00231D78
		public int[] GetPartItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x00233B90 File Offset: 0x00231D90
		[NullableContext(1)]
		public int[] PartItemIds()
		{
			return this.GetPartItemIdsArray();
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x00233B98 File Offset: 0x00231D98
		[NullableContext(1)]
		public IEnumerable<int> PartItemIdsIter()
		{
			DollGrabItemComboCsv.<PartItemIdsIter>d__22 <PartItemIdsIter>d__ = new DollGrabItemComboCsv.<PartItemIdsIter>d__22(-2);
			<PartItemIdsIter>d__.<>3__<>4__this = this;
			return <PartItemIdsIter>d__;
		}

		// Token: 0x04005204 RID: 20996
		private Table __p;
	}
}
