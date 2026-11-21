using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AC RID: 28844
	public struct ILifePointMaxStepRewardRuleItem : IFlatbufferObject
	{
		// Token: 0x1700D352 RID: 54098
		// (get) Token: 0x06032161 RID: 205153 RVA: 0x006C78BA File Offset: 0x006C5ABA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032162 RID: 205154 RVA: 0x006C78C7 File Offset: 0x006C5AC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032163 RID: 205155 RVA: 0x006C78D0 File Offset: 0x006C5AD0
		public static ILifePointMaxStepRewardRuleItem GetRootAsILifePointMaxStepRewardRuleItem(ByteBuffer _bb)
		{
			return ILifePointMaxStepRewardRuleItem.GetRootAsILifePointMaxStepRewardRuleItem(_bb, default(ILifePointMaxStepRewardRuleItem));
		}

		// Token: 0x06032164 RID: 205156 RVA: 0x006C78EC File Offset: 0x006C5AEC
		public static ILifePointMaxStepRewardRuleItem GetRootAsILifePointMaxStepRewardRuleItem(ByteBuffer _bb, ILifePointMaxStepRewardRuleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032165 RID: 205157 RVA: 0x006C7909 File Offset: 0x006C5B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032166 RID: 205158 RVA: 0x006C7918 File Offset: 0x006C5B18
		public ILifePointMaxStepRewardRuleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D353 RID: 54099
		// (get) Token: 0x06032167 RID: 205159 RVA: 0x006C7928 File Offset: 0x006C5B28
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

		// Token: 0x1700D354 RID: 54100
		// (get) Token: 0x06032168 RID: 205160 RVA: 0x006C7964 File Offset: 0x006C5B64
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

		// Token: 0x06032169 RID: 205161 RVA: 0x006C79A0 File Offset: 0x006C5BA0
		public static Offset<ILifePointMaxStepRewardRuleItem> CreateILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder, int PaintCount = 0, int AddStep = 0)
		{
			builder.StartTable(2);
			ILifePointMaxStepRewardRuleItem.AddAddStep(builder, AddStep);
			ILifePointMaxStepRewardRuleItem.AddPaintCount(builder, PaintCount);
			return ILifePointMaxStepRewardRuleItem.EndILifePointMaxStepRewardRuleItem(builder);
		}

		// Token: 0x0603216A RID: 205162 RVA: 0x006C79BD File Offset: 0x006C5BBD
		public static void StartILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603216B RID: 205163 RVA: 0x006C79C6 File Offset: 0x006C5BC6
		public static void AddPaintCount(FlatBufferBuilder builder, int paintCount)
		{
			builder.AddInt(0, paintCount, 0);
		}

		// Token: 0x0603216C RID: 205164 RVA: 0x006C79D1 File Offset: 0x006C5BD1
		public static void AddAddStep(FlatBufferBuilder builder, int addStep)
		{
			builder.AddInt(1, addStep, 0);
		}

		// Token: 0x0603216D RID: 205165 RVA: 0x006C79DC File Offset: 0x006C5BDC
		public static Offset<ILifePointMaxStepRewardRuleItem> EndILifePointMaxStepRewardRuleItem(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointMaxStepRewardRuleItem>(builder.EndTable());
		}

		// Token: 0x0603216E RID: 205166 RVA: 0x006C79EC File Offset: 0x006C5BEC
		public ILifePointMaxStepRewardRuleItemT UnPack()
		{
			ILifePointMaxStepRewardRuleItemT lifePointMaxStepRewardRuleItemT = new ILifePointMaxStepRewardRuleItemT();
			this.UnPackTo(lifePointMaxStepRewardRuleItemT);
			return lifePointMaxStepRewardRuleItemT;
		}

		// Token: 0x0603216F RID: 205167 RVA: 0x006C7A07 File Offset: 0x006C5C07
		public void UnPackTo(ILifePointMaxStepRewardRuleItemT _o)
		{
			_o.PaintCount = this.PaintCount;
			_o.AddStep = this.AddStep;
		}

		// Token: 0x06032170 RID: 205168 RVA: 0x006C7A24 File Offset: 0x006C5C24
		public static Offset<ILifePointMaxStepRewardRuleItem> Pack(FlatBufferBuilder builder, ILifePointMaxStepRewardRuleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePointMaxStepRewardRuleItem>);
			}
			return ILifePointMaxStepRewardRuleItem.CreateILifePointMaxStepRewardRuleItem(builder, _o.PaintCount, _o.AddStep);
		}

		// Token: 0x04012067 RID: 73831
		private Table __p;
	}
}
