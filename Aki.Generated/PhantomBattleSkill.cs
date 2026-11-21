using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC0 RID: 4032
	public struct PhantomBattleSkill : IFlatbufferObject
	{
		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x002CE574 File Offset: 0x002CC774
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x002CE581 File Offset: 0x002CC781
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x002CE588 File Offset: 0x002CC788
		public static PhantomBattleSkill GetRootAsPhantomBattleSkill(ByteBuffer _bb)
		{
			return PhantomBattleSkill.GetRootAsPhantomBattleSkill(_bb, default(PhantomBattleSkill));
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x002CE5A4 File Offset: 0x002CC7A4
		public static PhantomBattleSkill GetRootAsPhantomBattleSkill(ByteBuffer _bb, PhantomBattleSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x002CE5C1 File Offset: 0x002CC7C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x002CE5D0 File Offset: 0x002CC7D0
		public PhantomBattleSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0600ADEB RID: 44523 RVA: 0x002CE5E0 File Offset: 0x002CC7E0
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

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x002CE61C File Offset: 0x002CC81C
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

		// Token: 0x0600ADED RID: 44525 RVA: 0x002CE653 File Offset: 0x002CC853
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x002CE662 File Offset: 0x002CC862
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x002CE67C File Offset: 0x002CC87C
		public string Desc
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

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x002CE6B3 File Offset: 0x002CC8B3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x002CE6C2 File Offset: 0x002CC8C2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x002CE6DC File Offset: 0x002CC8DC
		public int ExecuteTimes
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x002CE71C File Offset: 0x002CC91C
		public int CostDurability
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x002CE75C File Offset: 0x002CC95C
		public string DescParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x002CE798 File Offset: 0x002CC998
		public int DescParamsLength
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

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x002CE7C4 File Offset: 0x002CC9C4
		public int TargetSelectType
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

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x002CE804 File Offset: 0x002CCA04
		public string TargetSelectParams(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x002CE840 File Offset: 0x002CCA40
		public int TargetSelectParamsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x002CE86C File Offset: 0x002CCA6C
		public int BattlePower
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

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x002CE8AC File Offset: 0x002CCAAC
		public int CostConsume
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

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x002CE8EC File Offset: 0x002CCAEC
		public int EffectType
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

		// Token: 0x0600ADFC RID: 44540 RVA: 0x002CE92C File Offset: 0x002CCB2C
		public string EffectParams(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x002CE968 File Offset: 0x002CCB68
		public int EffectParamsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x002CE994 File Offset: 0x002CCB94
		public int ActivateCondition
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ADFF RID: 44543 RVA: 0x002CE9D1 File Offset: 0x002CCBD1
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600AE00 RID: 44544 RVA: 0x002CE9DE File Offset: 0x002CCBDE
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			PhantomBattleSkill.<DescParamsIter>d__42 <DescParamsIter>d__ = new PhantomBattleSkill.<DescParamsIter>d__42(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x002CE9F3 File Offset: 0x002CCBF3
		[NullableContext(1)]
		public string[] EffectParams()
		{
			return this.EffectParamsIter().ToArray<string>();
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x002CEA00 File Offset: 0x002CCC00
		[NullableContext(1)]
		public IEnumerable<string> EffectParamsIter()
		{
			PhantomBattleSkill.<EffectParamsIter>d__44 <EffectParamsIter>d__ = new PhantomBattleSkill.<EffectParamsIter>d__44(-2);
			<EffectParamsIter>d__.<>3__<>4__this = this;
			return <EffectParamsIter>d__;
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x002CEA15 File Offset: 0x002CCC15
		[NullableContext(1)]
		public string[] TargetSelectParams()
		{
			return this.TargetSelectParamsIter().ToArray<string>();
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x002CEA22 File Offset: 0x002CCC22
		[NullableContext(1)]
		public IEnumerable<string> TargetSelectParamsIter()
		{
			PhantomBattleSkill.<TargetSelectParamsIter>d__46 <TargetSelectParamsIter>d__ = new PhantomBattleSkill.<TargetSelectParamsIter>d__46(-2);
			<TargetSelectParamsIter>d__.<>3__<>4__this = this;
			return <TargetSelectParamsIter>d__;
		}

		// Token: 0x0400557E RID: 21886
		private Table __p;
	}
}
