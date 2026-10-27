using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FC RID: 27132
	public struct ILifePointMaxStepRewardRuleItem : IFlatbufferObject
	{
		// Token: 0x1700C952 RID: 51538
		// (get) Token: 0x0602F7A1 RID: 194465 RVA: 0x00677562 File Offset: 0x00675762
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7A2 RID: 194466 RVA: 0x0067756F File Offset: 0x0067576F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7A3 RID: 194467 RVA: 0x00677578 File Offset: 0x00675778
		public static ILifePointMaxStepRewardRuleItem GetRootAsILifePointMaxStepRewardRuleItem(ByteBuffer _bb)
		{
			return ILifePointMaxStepRewardRuleItem.GetRootAsILifePointMaxStepRewardRuleItem(_bb, default(ILifePointMaxStepRewardRuleItem));
		}

		// Token: 0x0602F7A4 RID: 194468 RVA: 0x00677594 File Offset: 0x00675794
		public static ILifePointMaxStepRewardRuleItem GetRootAsILifePointMaxStepRewardRuleItem(ByteBuffer _bb, ILifePointMaxStepRewardRuleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7A5 RID: 194469 RVA: 0x006775B1 File Offset: 0x006757B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7A6 RID: 194470 RVA: 0x006775C0 File Offset: 0x006757C0
		public ILifePointMaxStepRewardRuleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C953 RID: 51539
		// (get) Token: 0x0602F7A7 RID: 194471 RVA: 0x006775D0 File Offset: 0x006757D0
		public int PaintCount
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

		// Token: 0x1700C954 RID: 51540
		// (get) Token: 0x0602F7A8 RID: 194472 RVA: 0x0067760C File Offset: 0x0067580C
		public int AddStep
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

		// Token: 0x0602F7A9 RID: 194473 RVA: 0x00677648 File Offset: 0x00675848
		public static Offset<ILifePointMaxStepRewardRuleItem> CreateILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder, int PaintCount = 0, int AddStep = 0)
		{
			builder.StartTable(2);
			ILifePointMaxStepRewardRuleItem.AddAddStep(builder, AddStep);
			ILifePointMaxStepRewardRuleItem.AddPaintCount(builder, PaintCount);
			return ILifePointMaxStepRewardRuleItem.EndILifePointMaxStepRewardRuleItem(builder);
		}

		// Token: 0x0602F7AA RID: 194474 RVA: 0x00677665 File Offset: 0x00675865
		public static void StartILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F7AB RID: 194475 RVA: 0x0067766E File Offset: 0x0067586E
		public static void AddPaintCount(FlatBufferBuilder builder, int paintCount)
		{
			builder.AddInt(0, paintCount, 0);
		}

		// Token: 0x0602F7AC RID: 194476 RVA: 0x00677679 File Offset: 0x00675879
		public static void AddAddStep(FlatBufferBuilder builder, int addStep)
		{
			builder.AddInt(1, addStep, 0);
		}

		// Token: 0x0602F7AD RID: 194477 RVA: 0x00677684 File Offset: 0x00675884
		public static Offset<ILifePointMaxStepRewardRuleItem> EndILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointMaxStepRewardRuleItem>(builder.EndTable());
		}

		// Token: 0x0602F7AE RID: 194478 RVA: 0x00677694 File Offset: 0x00675894
		public ILifePointMaxStepRewardRuleItemT UnPack()
		{
			ILifePointMaxStepRewardRuleItemT lifePointMaxStepRewardRuleItemT = new ILifePointMaxStepRewardRuleItemT();
			this.UnPackTo(lifePointMaxStepRewardRuleItemT);
			return lifePointMaxStepRewardRuleItemT;
		}

		// Token: 0x0602F7AF RID: 194479 RVA: 0x006776AF File Offset: 0x006758AF
		public void UnPackTo(ILifePointMaxStepRewardRuleItemT _o)
		{
			_o.PaintCount = this.PaintCount;
			_o.AddStep = this.AddStep;
		}

		// Token: 0x0602F7B0 RID: 194480 RVA: 0x006776CC File Offset: 0x006758CC
		public static Offset<ILifePointMaxStepRewardRuleItem> Pack(FlatBufferBuilder builder, ILifePointMaxStepRewardRuleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePointMaxStepRewardRuleItem>);
			}
			return ILifePointMaxStepRewardRuleItem.CreateILifePointMaxStepRewardRuleItem(builder, _o.PaintCount, _o.AddStep);
		}

		// Token: 0x040111FD RID: 70141
		private Table __p;
	}
}
