using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F61 RID: 3937
	public struct NewbieCarnivalParam : IFlatbufferObject
	{
		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0600A416 RID: 42006 RVA: 0x002B8A39 File Offset: 0x002B6C39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x002B8A46 File Offset: 0x002B6C46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x002B8A50 File Offset: 0x002B6C50
		public static NewbieCarnivalParam GetRootAsNewbieCarnivalParam(ByteBuffer _bb)
		{
			return NewbieCarnivalParam.GetRootAsNewbieCarnivalParam(_bb, default(NewbieCarnivalParam));
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x002B8A6C File Offset: 0x002B6C6C
		public static NewbieCarnivalParam GetRootAsNewbieCarnivalParam(ByteBuffer _bb, NewbieCarnivalParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x002B8A89 File Offset: 0x002B6C89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x002B8A98 File Offset: 0x002B6C98
		public NewbieCarnivalParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x0600A41C RID: 42012 RVA: 0x002B8AA8 File Offset: 0x002B6CA8
		public int ActivityId
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

		// Token: 0x0600A41D RID: 42013 RVA: 0x002B8AE4 File Offset: 0x002B6CE4
		public int Roles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x0600A41E RID: 42014 RVA: 0x002B8B24 File Offset: 0x002B6D24
		public int RolesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x002B8B4F File Offset: 0x002B6D4F
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x002B8B5E File Offset: 0x002B6D5E
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x002B8B78 File Offset: 0x002B6D78
		public int PayGifts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600A422 RID: 42018 RVA: 0x002B8BB8 File Offset: 0x002B6DB8
		public int PayGiftsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x002B8BE3 File Offset: 0x002B6DE3
		public Span<int> GetPayGiftsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x002B8BF2 File Offset: 0x002B6DF2
		public int[] GetPayGiftsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x002B8C0C File Offset: 0x002B6E0C
		public int GachaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600A426 RID: 42022 RVA: 0x002B8C4C File Offset: 0x002B6E4C
		public int GachaIdsLength
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

		// Token: 0x0600A427 RID: 42023 RVA: 0x002B8C78 File Offset: 0x002B6E78
		public Span<int> GetGachaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x002B8C88 File Offset: 0x002B6E88
		public int[] GetGachaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x0600A429 RID: 42025 RVA: 0x002B8CA0 File Offset: 0x002B6EA0
		public int RoleTask
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

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0600A42A RID: 42026 RVA: 0x002B8CE0 File Offset: 0x002B6EE0
		public int AllCount
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

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600A42B RID: 42027 RVA: 0x002B8D20 File Offset: 0x002B6F20
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x002B8D5D File Offset: 0x002B6F5D
		[NullableContext(1)]
		public int[] GachaIds()
		{
			return this.GetGachaIdsArray();
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x002B8D65 File Offset: 0x002B6F65
		[NullableContext(1)]
		public IEnumerable<int> GachaIdsIter()
		{
			NewbieCarnivalParam.<GachaIdsIter>d__32 <GachaIdsIter>d__ = new NewbieCarnivalParam.<GachaIdsIter>d__32(-2);
			<GachaIdsIter>d__.<>3__<>4__this = this;
			return <GachaIdsIter>d__;
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x002B8D7A File Offset: 0x002B6F7A
		[NullableContext(1)]
		public int[] PayGifts()
		{
			return this.GetPayGiftsArray();
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x002B8D82 File Offset: 0x002B6F82
		[NullableContext(1)]
		public IEnumerable<int> PayGiftsIter()
		{
			NewbieCarnivalParam.<PayGiftsIter>d__34 <PayGiftsIter>d__ = new NewbieCarnivalParam.<PayGiftsIter>d__34(-2);
			<PayGiftsIter>d__.<>3__<>4__this = this;
			return <PayGiftsIter>d__;
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x002B8D97 File Offset: 0x002B6F97
		[NullableContext(1)]
		public int[] Roles()
		{
			return this.GetRolesArray();
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x002B8D9F File Offset: 0x002B6F9F
		[NullableContext(1)]
		public IEnumerable<int> RolesIter()
		{
			NewbieCarnivalParam.<RolesIter>d__36 <RolesIter>d__ = new NewbieCarnivalParam.<RolesIter>d__36(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x0400550F RID: 21775
		private Table __p;
	}
}
