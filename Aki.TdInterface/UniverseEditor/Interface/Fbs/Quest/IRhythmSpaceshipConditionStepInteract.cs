using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044ED RID: 17645
	public struct IRhythmSpaceshipConditionStepInteract : IFlatbufferObject
	{
		// Token: 0x17007AE0 RID: 31456
		// (get) Token: 0x06019874 RID: 104564 RVA: 0x003A4046 File Offset: 0x003A2246
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019875 RID: 104565 RVA: 0x003A4053 File Offset: 0x003A2253
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019876 RID: 104566 RVA: 0x003A405C File Offset: 0x003A225C
		public static IRhythmSpaceshipConditionStepInteract GetRootAsIRhythmSpaceshipConditionStepInteract(ByteBuffer _bb)
		{
			return IRhythmSpaceshipConditionStepInteract.GetRootAsIRhythmSpaceshipConditionStepInteract(_bb, default(IRhythmSpaceshipConditionStepInteract));
		}

		// Token: 0x06019877 RID: 104567 RVA: 0x003A4078 File Offset: 0x003A2278
		public static IRhythmSpaceshipConditionStepInteract GetRootAsIRhythmSpaceshipConditionStepInteract(ByteBuffer _bb, IRhythmSpaceshipConditionStepInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019878 RID: 104568 RVA: 0x003A4095 File Offset: 0x003A2295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019879 RID: 104569 RVA: 0x003A40A4 File Offset: 0x003A22A4
		public IRhythmSpaceshipConditionStepInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AE1 RID: 31457
		// (get) Token: 0x0601987A RID: 104570 RVA: 0x003A40B4 File Offset: 0x003A22B4
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

		// Token: 0x0601987B RID: 104571 RVA: 0x003A40F0 File Offset: 0x003A22F0
		public static Offset<IRhythmSpaceshipConditionStepInteract> CreateIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep Type = ERhythmSpaceshipConditionStep.Interact)
		{
			builder.StartTable(1);
			IRhythmSpaceshipConditionStepInteract.AddType(builder, Type);
			return IRhythmSpaceshipConditionStepInteract.EndIRhythmSpaceshipConditionStepInteract(builder);
		}

		// Token: 0x0601987C RID: 104572 RVA: 0x003A4106 File Offset: 0x003A2306
		public static void StartIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601987D RID: 104573 RVA: 0x003A410F File Offset: 0x003A230F
		public static void AddType(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601987E RID: 104574 RVA: 0x003A411A File Offset: 0x003A231A
		public static Offset<IRhythmSpaceshipConditionStepInteract> EndIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRhythmSpaceshipConditionStepInteract>(builder.EndTable());
		}

		// Token: 0x0601987F RID: 104575 RVA: 0x003A4128 File Offset: 0x003A2328
		public IRhythmSpaceshipConditionStepInteractT UnPack()
		{
			IRhythmSpaceshipConditionStepInteractT rhythmSpaceshipConditionStepInteractT = new IRhythmSpaceshipConditionStepInteractT();
			this.UnPackTo(rhythmSpaceshipConditionStepInteractT);
			return rhythmSpaceshipConditionStepInteractT;
		}

		// Token: 0x06019880 RID: 104576 RVA: 0x003A4143 File Offset: 0x003A2343
		public void UnPackTo(IRhythmSpaceshipConditionStepInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019881 RID: 104577 RVA: 0x003A4154 File Offset: 0x003A2354
		public static Offset<IRhythmSpaceshipConditionStepInteract> Pack(FlatBufferBuilder builder, IRhythmSpaceshipConditionStepInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRhythmSpaceshipConditionStepInteract>);
			}
			return IRhythmSpaceshipConditionStepInteract.CreateIRhythmSpaceshipConditionStepInteract(builder, _o.Type);
		}

		// Token: 0x0400C62D RID: 50733
		private Table __p;
	}
}
