using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDE RID: 3294
	public struct DragonPool : IFlatbufferObject
	{
		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x00234D80 File Offset: 0x00232F80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00234D8D File Offset: 0x00232F8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00234D94 File Offset: 0x00232F94
		public static DragonPool GetRootAsDragonPool(ByteBuffer _bb)
		{
			return DragonPool.GetRootAsDragonPool(_bb, default(DragonPool));
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00234DB0 File Offset: 0x00232FB0
		public static DragonPool GetRootAsDragonPool(ByteBuffer _bb, DragonPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00234DCD File Offset: 0x00232FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x00234DDC File Offset: 0x00232FDC
		public DragonPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x00234DEC File Offset: 0x00232FEC
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

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x00234E28 File Offset: 0x00233028
		public int CoreId
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

		// Token: 0x0600691A RID: 26906 RVA: 0x00234E64 File Offset: 0x00233064
		public int Goal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600691B RID: 26907 RVA: 0x00234EA4 File Offset: 0x002330A4
		public int GoalLength
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

		// Token: 0x0600691C RID: 26908 RVA: 0x00234ECF File Offset: 0x002330CF
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00234EDE File Offset: 0x002330DE
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x00234EF8 File Offset: 0x002330F8
		public int DropIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600691F RID: 26911 RVA: 0x00234F38 File Offset: 0x00233138
		public int DropIdsLength
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

		// Token: 0x06006920 RID: 26912 RVA: 0x00234F64 File Offset: 0x00233164
		public Span<int> GetDropIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00234F74 File Offset: 0x00233174
		public int[] GetDropIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00234F8C File Offset: 0x0023318C
		public int DarkCoastDeliveryList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06006923 RID: 26915 RVA: 0x00234FCC File Offset: 0x002331CC
		public int DarkCoastDeliveryListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00234FF8 File Offset: 0x002331F8
		public Span<int> GetDarkCoastDeliveryListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00235008 File Offset: 0x00233208
		public int[] GetDarkCoastDeliveryListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x00235020 File Offset: 0x00233220
		public bool AutoTake
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00235060 File Offset: 0x00233260
		public string CanLevelUpTips(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x0023509C File Offset: 0x0023329C
		public int CanLevelUpTipsLength
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

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06006929 RID: 26921 RVA: 0x002350C8 File Offset: 0x002332C8
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00235108 File Offset: 0x00233308
		public int PlotStateList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x00235148 File Offset: 0x00233348
		public int PlotStateListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00235174 File Offset: 0x00233374
		public Span<int> GetPlotStateListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x00235184 File Offset: 0x00233384
		public int[] GetPlotStateListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x0023519C File Offset: 0x0023339C
		[NullableContext(1)]
		public string[] CanLevelUpTips()
		{
			return this.CanLevelUpTipsIter().ToArray<string>();
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x002351A9 File Offset: 0x002333A9
		[NullableContext(1)]
		public IEnumerable<string> CanLevelUpTipsIter()
		{
			DragonPool.<CanLevelUpTipsIter>d__40 <CanLevelUpTipsIter>d__ = new DragonPool.<CanLevelUpTipsIter>d__40(-2);
			<CanLevelUpTipsIter>d__.<>3__<>4__this = this;
			return <CanLevelUpTipsIter>d__;
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x002351BE File Offset: 0x002333BE
		[NullableContext(1)]
		public int[] DarkCoastDeliveryList()
		{
			return this.GetDarkCoastDeliveryListArray();
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x002351C6 File Offset: 0x002333C6
		[NullableContext(1)]
		public IEnumerable<int> DarkCoastDeliveryListIter()
		{
			DragonPool.<DarkCoastDeliveryListIter>d__42 <DarkCoastDeliveryListIter>d__ = new DragonPool.<DarkCoastDeliveryListIter>d__42(-2);
			<DarkCoastDeliveryListIter>d__.<>3__<>4__this = this;
			return <DarkCoastDeliveryListIter>d__;
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x002351DB File Offset: 0x002333DB
		[NullableContext(1)]
		public int[] DropIds()
		{
			return this.GetDropIdsArray();
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x002351E3 File Offset: 0x002333E3
		[NullableContext(1)]
		public IEnumerable<int> DropIdsIter()
		{
			DragonPool.<DropIdsIter>d__44 <DropIdsIter>d__ = new DragonPool.<DropIdsIter>d__44(-2);
			<DropIdsIter>d__.<>3__<>4__this = this;
			return <DropIdsIter>d__;
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x002351F8 File Offset: 0x002333F8
		[NullableContext(1)]
		public int[] Goal()
		{
			return this.GetGoalArray();
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00235200 File Offset: 0x00233400
		[NullableContext(1)]
		public IEnumerable<int> GoalIter()
		{
			DragonPool.<GoalIter>d__46 <GoalIter>d__ = new DragonPool.<GoalIter>d__46(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00235215 File Offset: 0x00233415
		[NullableContext(1)]
		public int[] PlotStateList()
		{
			return this.GetPlotStateListArray();
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x0023521D File Offset: 0x0023341D
		[NullableContext(1)]
		public IEnumerable<int> PlotStateListIter()
		{
			DragonPool.<PlotStateListIter>d__48 <PlotStateListIter>d__ = new DragonPool.<PlotStateListIter>d__48(-2);
			<PlotStateListIter>d__.<>3__<>4__this = this;
			return <PlotStateListIter>d__;
		}

		// Token: 0x0400520B RID: 21003
		private Table __p;
	}
}
