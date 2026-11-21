using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004595 RID: 17813
	public struct ISurvivorsRougeConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007C93 RID: 31891
		// (get) Token: 0x06019FAE RID: 106414 RVA: 0x003B47C4 File Offset: 0x003B29C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FAF RID: 106415 RVA: 0x003B47D1 File Offset: 0x003B29D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FB0 RID: 106416 RVA: 0x003B47D8 File Offset: 0x003B29D8
		public static ISurvivorsRougeConditionStepBase GetRootAsISurvivorsRougeConditionStepBase(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepBase.GetRootAsISurvivorsRougeConditionStepBase(_bb, default(ISurvivorsRougeConditionStepBase));
		}

		// Token: 0x06019FB1 RID: 106417 RVA: 0x003B47F4 File Offset: 0x003B29F4
		public static ISurvivorsRougeConditionStepBase GetRootAsISurvivorsRougeConditionStepBase(ByteBuffer _bb, ISurvivorsRougeConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FB2 RID: 106418 RVA: 0x003B4811 File Offset: 0x003B2A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FB3 RID: 106419 RVA: 0x003B4820 File Offset: 0x003B2A20
		public ISurvivorsRougeConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C94 RID: 31892
		// (get) Token: 0x06019FB4 RID: 106420 RVA: 0x003B4830 File Offset: 0x003B2A30
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019FB5 RID: 106421 RVA: 0x003B486C File Offset: 0x003B2A6C
		public static Offset<ISurvivorsRougeConditionStepBase> CreateISurvivorsRougeConditionStepBase(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepBase.AddType(builder, Type);
			return ISurvivorsRougeConditionStepBase.EndISurvivorsRougeConditionStepBase(builder);
		}

		// Token: 0x06019FB6 RID: 106422 RVA: 0x003B4882 File Offset: 0x003B2A82
		public static void StartISurvivorsRougeConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019FB7 RID: 106423 RVA: 0x003B488B File Offset: 0x003B2A8B
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FB8 RID: 106424 RVA: 0x003B4896 File Offset: 0x003B2A96
		public static Offset<ISurvivorsRougeConditionStepBase> EndISurvivorsRougeConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06019FB9 RID: 106425 RVA: 0x003B48A4 File Offset: 0x003B2AA4
		public ISurvivorsRougeConditionStepBaseT UnPack()
		{
			ISurvivorsRougeConditionStepBaseT survivorsRougeConditionStepBaseT = new ISurvivorsRougeConditionStepBaseT();
			this.UnPackTo(survivorsRougeConditionStepBaseT);
			return survivorsRougeConditionStepBaseT;
		}

		// Token: 0x06019FBA RID: 106426 RVA: 0x003B48BF File Offset: 0x003B2ABF
		public void UnPackTo(ISurvivorsRougeConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019FBB RID: 106427 RVA: 0x003B48D0 File Offset: 0x003B2AD0
		public static Offset<ISurvivorsRougeConditionStepBase> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepBase>);
			}
			return ISurvivorsRougeConditionStepBase.CreateISurvivorsRougeConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C759 RID: 51033
		private Table __p;
	}
}
