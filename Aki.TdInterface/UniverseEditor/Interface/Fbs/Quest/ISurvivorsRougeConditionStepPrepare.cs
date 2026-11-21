using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AA RID: 17834
	public struct ISurvivorsRougeConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x17007CA7 RID: 31911
		// (get) Token: 0x0601A032 RID: 106546 RVA: 0x003B5321 File Offset: 0x003B3521
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A033 RID: 106547 RVA: 0x003B532E File Offset: 0x003B352E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A034 RID: 106548 RVA: 0x003B5338 File Offset: 0x003B3538
		public static ISurvivorsRougeConditionStepPrepare GetRootAsISurvivorsRougeConditionStepPrepare(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepPrepare.GetRootAsISurvivorsRougeConditionStepPrepare(_bb, default(ISurvivorsRougeConditionStepPrepare));
		}

		// Token: 0x0601A035 RID: 106549 RVA: 0x003B5354 File Offset: 0x003B3554
		public static ISurvivorsRougeConditionStepPrepare GetRootAsISurvivorsRougeConditionStepPrepare(ByteBuffer _bb, ISurvivorsRougeConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A036 RID: 106550 RVA: 0x003B5371 File Offset: 0x003B3571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A037 RID: 106551 RVA: 0x003B5380 File Offset: 0x003B3580
		public ISurvivorsRougeConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CA8 RID: 31912
		// (get) Token: 0x0601A038 RID: 106552 RVA: 0x003B5390 File Offset: 0x003B3590
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

		// Token: 0x0601A039 RID: 106553 RVA: 0x003B53CC File Offset: 0x003B35CC
		public static Offset<ISurvivorsRougeConditionStepPrepare> CreateISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepPrepare.AddType(builder, Type);
			return ISurvivorsRougeConditionStepPrepare.EndISurvivorsRougeConditionStepPrepare(builder);
		}

		// Token: 0x0601A03A RID: 106554 RVA: 0x003B53E2 File Offset: 0x003B35E2
		public static void StartISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A03B RID: 106555 RVA: 0x003B53EB File Offset: 0x003B35EB
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A03C RID: 106556 RVA: 0x003B53F6 File Offset: 0x003B35F6
		public static Offset<ISurvivorsRougeConditionStepPrepare> EndISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x0601A03D RID: 106557 RVA: 0x003B5404 File Offset: 0x003B3604
		public ISurvivorsRougeConditionStepPrepareT UnPack()
		{
			ISurvivorsRougeConditionStepPrepareT survivorsRougeConditionStepPrepareT = new ISurvivorsRougeConditionStepPrepareT();
			this.UnPackTo(survivorsRougeConditionStepPrepareT);
			return survivorsRougeConditionStepPrepareT;
		}

		// Token: 0x0601A03E RID: 106558 RVA: 0x003B541F File Offset: 0x003B361F
		public void UnPackTo(ISurvivorsRougeConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A03F RID: 106559 RVA: 0x003B5430 File Offset: 0x003B3630
		public static Offset<ISurvivorsRougeConditionStepPrepare> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepPrepare>);
			}
			return ISurvivorsRougeConditionStepPrepare.CreateISurvivorsRougeConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400C771 RID: 51057
		private Table __p;
	}
}
