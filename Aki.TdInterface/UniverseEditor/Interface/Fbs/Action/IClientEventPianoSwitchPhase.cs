using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A6 RID: 25510
	public struct IClientEventPianoSwitchPhase : IFlatbufferObject
	{
		// Token: 0x1700BE28 RID: 48680
		// (get) Token: 0x0602C213 RID: 180755 RVA: 0x0060F8A4 File Offset: 0x0060DAA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C214 RID: 180756 RVA: 0x0060F8B1 File Offset: 0x0060DAB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C215 RID: 180757 RVA: 0x0060F8B8 File Offset: 0x0060DAB8
		public static IClientEventPianoSwitchPhase GetRootAsIClientEventPianoSwitchPhase(ByteBuffer _bb)
		{
			return IClientEventPianoSwitchPhase.GetRootAsIClientEventPianoSwitchPhase(_bb, default(IClientEventPianoSwitchPhase));
		}

		// Token: 0x0602C216 RID: 180758 RVA: 0x0060F8D4 File Offset: 0x0060DAD4
		public static IClientEventPianoSwitchPhase GetRootAsIClientEventPianoSwitchPhase(ByteBuffer _bb, IClientEventPianoSwitchPhase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C217 RID: 180759 RVA: 0x0060F8F1 File Offset: 0x0060DAF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C218 RID: 180760 RVA: 0x0060F900 File Offset: 0x0060DB00
		public IClientEventPianoSwitchPhase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE29 RID: 48681
		// (get) Token: 0x0602C219 RID: 180761 RVA: 0x0060F910 File Offset: 0x0060DB10
		public EClientEventPianoEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return (EClientEventPianoEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C21A RID: 180762 RVA: 0x0060F94C File Offset: 0x0060DB4C
		public static Offset<IClientEventPianoSwitchPhase> CreateIClientEventPianoSwitchPhase(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventPianoSwitchPhase.AddType(builder, Type);
			return IClientEventPianoSwitchPhase.EndIClientEventPianoSwitchPhase(builder);
		}

		// Token: 0x0602C21B RID: 180763 RVA: 0x0060F962 File Offset: 0x0060DB62
		public static void StartIClientEventPianoSwitchPhase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C21C RID: 180764 RVA: 0x0060F96B File Offset: 0x0060DB6B
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C21D RID: 180765 RVA: 0x0060F976 File Offset: 0x0060DB76
		public static Offset<IClientEventPianoSwitchPhase> EndIClientEventPianoSwitchPhase(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoSwitchPhase>(builder.EndTable());
		}

		// Token: 0x0602C21E RID: 180766 RVA: 0x0060F984 File Offset: 0x0060DB84
		public IClientEventPianoSwitchPhaseT UnPack()
		{
			IClientEventPianoSwitchPhaseT clientEventPianoSwitchPhaseT = new IClientEventPianoSwitchPhaseT();
			this.UnPackTo(clientEventPianoSwitchPhaseT);
			return clientEventPianoSwitchPhaseT;
		}

		// Token: 0x0602C21F RID: 180767 RVA: 0x0060F99F File Offset: 0x0060DB9F
		public void UnPackTo(IClientEventPianoSwitchPhaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C220 RID: 180768 RVA: 0x0060F9B0 File Offset: 0x0060DBB0
		public static Offset<IClientEventPianoSwitchPhase> Pack(FlatBufferBuilder builder, IClientEventPianoSwitchPhaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoSwitchPhase>);
			}
			return IClientEventPianoSwitchPhase.CreateIClientEventPianoSwitchPhase(builder, _o.Type);
		}

		// Token: 0x0401097A RID: 67962
		private Table __p;
	}
}
