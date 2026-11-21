using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA4 RID: 4004
	public struct PhantomBattleBuff : IFlatbufferObject
	{
		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x002C73B1 File Offset: 0x002C55B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x002C73BE File Offset: 0x002C55BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAAC RID: 43692 RVA: 0x002C73C8 File Offset: 0x002C55C8
		public static PhantomBattleBuff GetRootAsPhantomBattleBuff(ByteBuffer _bb)
		{
			return PhantomBattleBuff.GetRootAsPhantomBattleBuff(_bb, default(PhantomBattleBuff));
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x002C73E4 File Offset: 0x002C55E4
		public static PhantomBattleBuff GetRootAsPhantomBattleBuff(ByteBuffer _bb, PhantomBattleBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x002C7401 File Offset: 0x002C5601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x002C7410 File Offset: 0x002C5610
		public PhantomBattleBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600AAB0 RID: 43696 RVA: 0x002C7420 File Offset: 0x002C5620
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

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x002C745C File Offset: 0x002C565C
		public int TargetSelectType
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

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x002C7498 File Offset: 0x002C5698
		public string TargetSelectParams(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x002C74D4 File Offset: 0x002C56D4
		public int TargetSelectParamsLength
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

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x0600AAB4 RID: 43700 RVA: 0x002C7500 File Offset: 0x002C5700
		public int BuffShowType
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

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x0600AAB5 RID: 43701 RVA: 0x002C7540 File Offset: 0x002C5740
		public int EffectType
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

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x002C7580 File Offset: 0x002C5780
		public string EffectParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600AAB7 RID: 43703 RVA: 0x002C75BC File Offset: 0x002C57BC
		public int EffectParamsLength
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

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x002C75E8 File Offset: 0x002C57E8
		[NullableContext(1)]
		public string[] EffectParams()
		{
			return this.EffectParamsIter().ToArray<string>();
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x002C75F5 File Offset: 0x002C57F5
		[NullableContext(1)]
		public IEnumerable<string> EffectParamsIter()
		{
			PhantomBattleBuff.<EffectParamsIter>d__23 <EffectParamsIter>d__ = new PhantomBattleBuff.<EffectParamsIter>d__23(-2);
			<EffectParamsIter>d__.<>3__<>4__this = this;
			return <EffectParamsIter>d__;
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x002C760A File Offset: 0x002C580A
		[NullableContext(1)]
		public string[] TargetSelectParams()
		{
			return this.TargetSelectParamsIter().ToArray<string>();
		}

		// Token: 0x0600AABB RID: 43707 RVA: 0x002C7617 File Offset: 0x002C5817
		[NullableContext(1)]
		public IEnumerable<string> TargetSelectParamsIter()
		{
			PhantomBattleBuff.<TargetSelectParamsIter>d__25 <TargetSelectParamsIter>d__ = new PhantomBattleBuff.<TargetSelectParamsIter>d__25(-2);
			<TargetSelectParamsIter>d__.<>3__<>4__this = this;
			return <TargetSelectParamsIter>d__;
		}

		// Token: 0x0400555F RID: 21855
		private Table __p;
	}
}
