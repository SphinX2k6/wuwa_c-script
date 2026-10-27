using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004223 RID: 16931
	public struct ITrapDefenseConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007847 RID: 30791
		// (get) Token: 0x0601907E RID: 102526 RVA: 0x0039A1CA File Offset: 0x003983CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601907F RID: 102527 RVA: 0x0039A1D7 File Offset: 0x003983D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019080 RID: 102528 RVA: 0x0039A1E0 File Offset: 0x003983E0
		public static ITrapDefenseConditionStepBase GetRootAsITrapDefenseConditionStepBase(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepBase.GetRootAsITrapDefenseConditionStepBase(_bb, default(ITrapDefenseConditionStepBase));
		}

		// Token: 0x06019081 RID: 102529 RVA: 0x0039A1FC File Offset: 0x003983FC
		public static ITrapDefenseConditionStepBase GetRootAsITrapDefenseConditionStepBase(ByteBuffer _bb, ITrapDefenseConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019082 RID: 102530 RVA: 0x0039A219 File Offset: 0x00398419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019083 RID: 102531 RVA: 0x0039A228 File Offset: 0x00398428
		public ITrapDefenseConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007848 RID: 30792
		// (get) Token: 0x06019084 RID: 102532 RVA: 0x0039A238 File Offset: 0x00398438
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019085 RID: 102533 RVA: 0x0039A274 File Offset: 0x00398474
		public static Offset<ITrapDefenseConditionStepBase> CreateITrapDefenseConditionStepBase(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepBase.AddType(builder, Type);
			return ITrapDefenseConditionStepBase.EndITrapDefenseConditionStepBase(builder);
		}

		// Token: 0x06019086 RID: 102534 RVA: 0x0039A28A File Offset: 0x0039848A
		public static void StartITrapDefenseConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019087 RID: 102535 RVA: 0x0039A293 File Offset: 0x00398493
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019088 RID: 102536 RVA: 0x0039A29E File Offset: 0x0039849E
		public static Offset<ITrapDefenseConditionStepBase> EndITrapDefenseConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06019089 RID: 102537 RVA: 0x0039A2AC File Offset: 0x003984AC
		public ITrapDefenseConditionStepBaseT UnPack()
		{
			ITrapDefenseConditionStepBaseT trapDefenseConditionStepBaseT = new ITrapDefenseConditionStepBaseT();
			this.UnPackTo(trapDefenseConditionStepBaseT);
			return trapDefenseConditionStepBaseT;
		}

		// Token: 0x0601908A RID: 102538 RVA: 0x0039A2C7 File Offset: 0x003984C7
		public void UnPackTo(ITrapDefenseConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601908B RID: 102539 RVA: 0x0039A2D8 File Offset: 0x003984D8
		public static Offset<ITrapDefenseConditionStepBase> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepBase>);
			}
			return ITrapDefenseConditionStepBase.CreateITrapDefenseConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400BEA4 RID: 48804
		private Table __p;
	}
}
