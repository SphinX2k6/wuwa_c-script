using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AC RID: 16556
	public struct IRhythmSpaceshipConditionStepInteract : IFlatbufferObject
	{
		// Token: 0x170074DA RID: 29914
		// (get) Token: 0x060181D3 RID: 98771 RVA: 0x0037A0F6 File Offset: 0x003782F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060181D4 RID: 98772 RVA: 0x0037A103 File Offset: 0x00378303
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060181D5 RID: 98773 RVA: 0x0037A10C File Offset: 0x0037830C
		public static IRhythmSpaceshipConditionStepInteract GetRootAsIRhythmSpaceshipConditionStepInteract(ByteBuffer _bb)
		{
			return IRhythmSpaceshipConditionStepInteract.GetRootAsIRhythmSpaceshipConditionStepInteract(_bb, default(IRhythmSpaceshipConditionStepInteract));
		}

		// Token: 0x060181D6 RID: 98774 RVA: 0x0037A128 File Offset: 0x00378328
		public static IRhythmSpaceshipConditionStepInteract GetRootAsIRhythmSpaceshipConditionStepInteract(ByteBuffer _bb, IRhythmSpaceshipConditionStepInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060181D7 RID: 98775 RVA: 0x0037A145 File Offset: 0x00378345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060181D8 RID: 98776 RVA: 0x0037A154 File Offset: 0x00378354
		public IRhythmSpaceshipConditionStepInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074DB RID: 29915
		// (get) Token: 0x060181D9 RID: 98777 RVA: 0x0037A164 File Offset: 0x00378364
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

		// Token: 0x060181DA RID: 98778 RVA: 0x0037A1A0 File Offset: 0x003783A0
		public static Offset<IRhythmSpaceshipConditionStepInteract> CreateIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep Type = ERhythmSpaceshipConditionStep.Interact)
		{
			builder.StartTable(1);
			IRhythmSpaceshipConditionStepInteract.AddType(builder, Type);
			return IRhythmSpaceshipConditionStepInteract.EndIRhythmSpaceshipConditionStepInteract(builder);
		}

		// Token: 0x060181DB RID: 98779 RVA: 0x0037A1B6 File Offset: 0x003783B6
		public static void StartIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060181DC RID: 98780 RVA: 0x0037A1BF File Offset: 0x003783BF
		public static void AddType(FlatBufferBuilder builder, ERhythmSpaceshipConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060181DD RID: 98781 RVA: 0x0037A1CA File Offset: 0x003783CA
		public static Offset<IRhythmSpaceshipConditionStepInteract> EndIRhythmSpaceshipConditionStepInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRhythmSpaceshipConditionStepInteract>(builder.EndTable());
		}

		// Token: 0x060181DE RID: 98782 RVA: 0x0037A1D8 File Offset: 0x003783D8
		public IRhythmSpaceshipConditionStepInteractT UnPack()
		{
			IRhythmSpaceshipConditionStepInteractT rhythmSpaceshipConditionStepInteractT = new IRhythmSpaceshipConditionStepInteractT();
			this.UnPackTo(rhythmSpaceshipConditionStepInteractT);
			return rhythmSpaceshipConditionStepInteractT;
		}

		// Token: 0x060181DF RID: 98783 RVA: 0x0037A1F3 File Offset: 0x003783F3
		public void UnPackTo(IRhythmSpaceshipConditionStepInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060181E0 RID: 98784 RVA: 0x0037A204 File Offset: 0x00378404
		public static Offset<IRhythmSpaceshipConditionStepInteract> Pack(FlatBufferBuilder builder, IRhythmSpaceshipConditionStepInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRhythmSpaceshipConditionStepInteract>);
			}
			return IRhythmSpaceshipConditionStepInteract.CreateIRhythmSpaceshipConditionStepInteract(builder, _o.Type);
		}

		// Token: 0x0400BC44 RID: 48196
		private Table __p;
	}
}
