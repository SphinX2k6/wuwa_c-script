using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004166 RID: 16742
	public struct ISurvivorsRougeConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x17007698 RID: 30360
		// (get) Token: 0x0601896A RID: 100714 RVA: 0x0038AD65 File Offset: 0x00388F65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601896B RID: 100715 RVA: 0x0038AD72 File Offset: 0x00388F72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601896C RID: 100716 RVA: 0x0038AD7C File Offset: 0x00388F7C
		public static ISurvivorsRougeConditionStepPrepare GetRootAsISurvivorsRougeConditionStepPrepare(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepPrepare.GetRootAsISurvivorsRougeConditionStepPrepare(_bb, default(ISurvivorsRougeConditionStepPrepare));
		}

		// Token: 0x0601896D RID: 100717 RVA: 0x0038AD98 File Offset: 0x00388F98
		public static ISurvivorsRougeConditionStepPrepare GetRootAsISurvivorsRougeConditionStepPrepare(ByteBuffer _bb, ISurvivorsRougeConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601896E RID: 100718 RVA: 0x0038ADB5 File Offset: 0x00388FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601896F RID: 100719 RVA: 0x0038ADC4 File Offset: 0x00388FC4
		public ISurvivorsRougeConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007699 RID: 30361
		// (get) Token: 0x06018970 RID: 100720 RVA: 0x0038ADD4 File Offset: 0x00388FD4
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

		// Token: 0x06018971 RID: 100721 RVA: 0x0038AE10 File Offset: 0x00389010
		public static Offset<ISurvivorsRougeConditionStepPrepare> CreateISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepPrepare.AddType(builder, Type);
			return ISurvivorsRougeConditionStepPrepare.EndISurvivorsRougeConditionStepPrepare(builder);
		}

		// Token: 0x06018972 RID: 100722 RVA: 0x0038AE26 File Offset: 0x00389026
		public static void StartISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018973 RID: 100723 RVA: 0x0038AE2F File Offset: 0x0038902F
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018974 RID: 100724 RVA: 0x0038AE3A File Offset: 0x0038903A
		public static Offset<ISurvivorsRougeConditionStepPrepare> EndISurvivorsRougeConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x0038AE48 File Offset: 0x00389048
		public ISurvivorsRougeConditionStepPrepareT UnPack()
		{
			ISurvivorsRougeConditionStepPrepareT survivorsRougeConditionStepPrepareT = new ISurvivorsRougeConditionStepPrepareT();
			this.UnPackTo(survivorsRougeConditionStepPrepareT);
			return survivorsRougeConditionStepPrepareT;
		}

		// Token: 0x06018976 RID: 100726 RVA: 0x0038AE63 File Offset: 0x00389063
		public void UnPackTo(ISurvivorsRougeConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018977 RID: 100727 RVA: 0x0038AE74 File Offset: 0x00389074
		public static Offset<ISurvivorsRougeConditionStepPrepare> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepPrepare>);
			}
			return ISurvivorsRougeConditionStepPrepare.CreateISurvivorsRougeConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400BD83 RID: 48515
		private Table __p;
	}
}
