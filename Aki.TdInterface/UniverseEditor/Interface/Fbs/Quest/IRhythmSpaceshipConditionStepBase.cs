using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E7 RID: 17639
	public struct IRhythmSpaceshipConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007ADB RID: 31451
		// (get) Token: 0x06019856 RID: 104534 RVA: 0x003A3DD4 File Offset: 0x003A1FD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019857 RID: 104535 RVA: 0x003A3DE1 File Offset: 0x003A1FE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019858 RID: 104536 RVA: 0x003A3DE8 File Offset: 0x003A1FE8
		public static IRhythmSpaceshipConditionStepBase GetRootAsIRhythmSpaceshipConditionStepBase(ByteBuffer _bb)
		{
			return IRhythmSpaceshipConditionStepBase.GetRootAsIRhythmSpaceshipConditionStepBase(_bb, default(IRhythmSpaceshipConditionStepBase));
		}

		// Token: 0x06019859 RID: 104537 RVA: 0x003A3E04 File Offset: 0x003A2004
		public static IRhythmSpaceshipConditionStepBase GetRootAsIRhythmSpaceshipConditionStepBase(ByteBuffer _bb, IRhythmSpaceshipConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601985A RID: 104538 RVA: 0x003A3E21 File Offset: 0x003A2021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601985B RID: 104539 RVA: 0x003A3E30 File Offset: 0x003A2030
		public IRhythmSpaceshipConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ADC RID: 31452
		// (get) Token: 0x0601985C RID: 104540 RVA: 0x003A3E40 File Offset: 0x003A2040
		public ERhythmSpaceshipConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERhythmSpaceshipConditionStep.Interact;
				}
				return (ERhythmSpaceshipConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601985D RID: 104541 RVA: 0x003A3E7C File Offset: 0x003A207C
		public static Offset<IRhythmSpaceshipConditionStepBase> CreateIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep Type = ERhythmSpaceshipConditionStep.Interact)
		{
			builder.StartTable(1);
			IRhythmSpaceshipConditionStepBase.AddType(builder, Type);
			return IRhythmSpaceshipConditionStepBase.EndIRhythmSpaceshipConditionStepBase(builder);
		}

		// Token: 0x0601985E RID: 104542 RVA: 0x003A3E92 File Offset: 0x003A2092
		public static void StartIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601985F RID: 104543 RVA: 0x003A3E9B File Offset: 0x003A209B
		public static void AddType(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019860 RID: 104544 RVA: 0x003A3EA6 File Offset: 0x003A20A6
		public static Offset<IRhythmSpaceshipConditionStepBase> EndIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRhythmSpaceshipConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06019861 RID: 104545 RVA: 0x003A3EB4 File Offset: 0x003A20B4
		public IRhythmSpaceshipConditionStepBaseT UnPack()
		{
			IRhythmSpaceshipConditionStepBaseT rhythmSpaceshipConditionStepBaseT = new IRhythmSpaceshipConditionStepBaseT();
			this.UnPackTo(rhythmSpaceshipConditionStepBaseT);
			return rhythmSpaceshipConditionStepBaseT;
		}

		// Token: 0x06019862 RID: 104546 RVA: 0x003A3ECF File Offset: 0x003A20CF
		public void UnPackTo(IRhythmSpaceshipConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019863 RID: 104547 RVA: 0x003A3EE0 File Offset: 0x003A20E0
		public static Offset<IRhythmSpaceshipConditionStepBase> Pack(FlatBufferBuilder builder, IRhythmSpaceshipConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRhythmSpaceshipConditionStepBase>);
			}
			return IRhythmSpaceshipConditionStepBase.CreateIRhythmSpaceshipConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C625 RID: 50725
		private Table __p;
	}
}
