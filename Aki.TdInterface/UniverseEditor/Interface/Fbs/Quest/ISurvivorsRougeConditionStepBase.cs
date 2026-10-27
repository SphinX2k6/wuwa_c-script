using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004151 RID: 16721
	public struct ISurvivorsRougeConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007684 RID: 30340
		// (get) Token: 0x060188E6 RID: 100582 RVA: 0x0038A208 File Offset: 0x00388408
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060188E7 RID: 100583 RVA: 0x0038A215 File Offset: 0x00388415
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060188E8 RID: 100584 RVA: 0x0038A21C File Offset: 0x0038841C
		public static ISurvivorsRougeConditionStepBase GetRootAsISurvivorsRougeConditionStepBase(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepBase.GetRootAsISurvivorsRougeConditionStepBase(_bb, default(ISurvivorsRougeConditionStepBase));
		}

		// Token: 0x060188E9 RID: 100585 RVA: 0x0038A238 File Offset: 0x00388438
		public static ISurvivorsRougeConditionStepBase GetRootAsISurvivorsRougeConditionStepBase(ByteBuffer _bb, ISurvivorsRougeConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060188EA RID: 100586 RVA: 0x0038A255 File Offset: 0x00388455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060188EB RID: 100587 RVA: 0x0038A264 File Offset: 0x00388464
		public ISurvivorsRougeConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007685 RID: 30341
		// (get) Token: 0x060188EC RID: 100588 RVA: 0x0038A274 File Offset: 0x00388474
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

		// Token: 0x060188ED RID: 100589 RVA: 0x0038A2B0 File Offset: 0x003884B0
		public static Offset<ISurvivorsRougeConditionStepBase> CreateISurvivorsRougeConditionStepBase(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepBase.AddType(builder, Type);
			return ISurvivorsRougeConditionStepBase.EndISurvivorsRougeConditionStepBase(builder);
		}

		// Token: 0x060188EE RID: 100590 RVA: 0x0038A2C6 File Offset: 0x003884C6
		public static void StartISurvivorsRougeConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060188EF RID: 100591 RVA: 0x0038A2CF File Offset: 0x003884CF
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060188F0 RID: 100592 RVA: 0x0038A2DA File Offset: 0x003884DA
		public static Offset<ISurvivorsRougeConditionStepBase> EndISurvivorsRougeConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepBase>(builder.EndTable());
		}

		// Token: 0x060188F1 RID: 100593 RVA: 0x0038A2E8 File Offset: 0x003884E8
		public ISurvivorsRougeConditionStepBaseT UnPack()
		{
			ISurvivorsRougeConditionStepBaseT survivorsRougeConditionStepBaseT = new ISurvivorsRougeConditionStepBaseT();
			this.UnPackTo(survivorsRougeConditionStepBaseT);
			return survivorsRougeConditionStepBaseT;
		}

		// Token: 0x060188F2 RID: 100594 RVA: 0x0038A303 File Offset: 0x00388503
		public void UnPackTo(ISurvivorsRougeConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060188F3 RID: 100595 RVA: 0x0038A314 File Offset: 0x00388514
		public static Offset<ISurvivorsRougeConditionStepBase> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepBase>);
			}
			return ISurvivorsRougeConditionStepBase.CreateISurvivorsRougeConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400BD6B RID: 48491
		private Table __p;
	}
}
