using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A6 RID: 16550
	public struct IRhythmSpaceshipConditionStepBase : IFlatbufferObject
	{
		// Token: 0x170074D5 RID: 29909
		// (get) Token: 0x060181B5 RID: 98741 RVA: 0x00379E84 File Offset: 0x00378084
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060181B6 RID: 98742 RVA: 0x00379E91 File Offset: 0x00378091
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060181B7 RID: 98743 RVA: 0x00379E98 File Offset: 0x00378098
		public static IRhythmSpaceshipConditionStepBase GetRootAsIRhythmSpaceshipConditionStepBase(ByteBuffer _bb)
		{
			return IRhythmSpaceshipConditionStepBase.GetRootAsIRhythmSpaceshipConditionStepBase(_bb, default(IRhythmSpaceshipConditionStepBase));
		}

		// Token: 0x060181B8 RID: 98744 RVA: 0x00379EB4 File Offset: 0x003780B4
		public static IRhythmSpaceshipConditionStepBase GetRootAsIRhythmSpaceshipConditionStepBase(ByteBuffer _bb, IRhythmSpaceshipConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060181B9 RID: 98745 RVA: 0x00379ED1 File Offset: 0x003780D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060181BA RID: 98746 RVA: 0x00379EE0 File Offset: 0x003780E0
		public IRhythmSpaceshipConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074D6 RID: 29910
		// (get) Token: 0x060181BB RID: 98747 RVA: 0x00379EF0 File Offset: 0x003780F0
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

		// Token: 0x060181BC RID: 98748 RVA: 0x00379F2C File Offset: 0x0037812C
		public static Offset<IRhythmSpaceshipConditionStepBase> CreateIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep Type = ERhythmSpaceshipConditionStep.Interact)
		{
			builder.StartTable(1);
			IRhythmSpaceshipConditionStepBase.AddType(builder, Type);
			return IRhythmSpaceshipConditionStepBase.EndIRhythmSpaceshipConditionStepBase(builder);
		}

		// Token: 0x060181BD RID: 98749 RVA: 0x00379F42 File Offset: 0x00378142
		public static void StartIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060181BE RID: 98750 RVA: 0x00379F4B File Offset: 0x0037814B
		public static void AddType(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060181BF RID: 98751 RVA: 0x00379F56 File Offset: 0x00378156
		public static Offset<IRhythmSpaceshipConditionStepBase> EndIRhythmSpaceshipConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRhythmSpaceshipConditionStepBase>(builder.EndTable());
		}

		// Token: 0x060181C0 RID: 98752 RVA: 0x00379F64 File Offset: 0x00378164
		public IRhythmSpaceshipConditionStepBaseT UnPack()
		{
			IRhythmSpaceshipConditionStepBaseT rhythmSpaceshipConditionStepBaseT = new IRhythmSpaceshipConditionStepBaseT();
			this.UnPackTo(rhythmSpaceshipConditionStepBaseT);
			return rhythmSpaceshipConditionStepBaseT;
		}

		// Token: 0x060181C1 RID: 98753 RVA: 0x00379F7F File Offset: 0x0037817F
		public void UnPackTo(IRhythmSpaceshipConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060181C2 RID: 98754 RVA: 0x00379F90 File Offset: 0x00378190
		public static Offset<IRhythmSpaceshipConditionStepBase> Pack(FlatBufferBuilder builder, IRhythmSpaceshipConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRhythmSpaceshipConditionStepBase>);
			}
			return IRhythmSpaceshipConditionStepBase.CreateIRhythmSpaceshipConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400BC3C RID: 48188
		private Table __p;
	}
}
