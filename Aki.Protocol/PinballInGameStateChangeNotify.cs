using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4C RID: 3404
	[NetMessage(EMessageId.PinballInGameStateChangeNotify)]
	public sealed class PinballInGameStateChangeNotify : IMessage<PinballInGameStateChangeNotify>, IMessage, IEquatable<PinballInGameStateChangeNotify>, IDeepCloneable<PinballInGameStateChangeNotify>, IBufferMessage
	{
		// Token: 0x060125C9 RID: 75209 RVA: 0x002ADC70 File Offset: 0x002ABE70
		[NullableContext(1)]
		public static PinballInGameStateChangeNotify Create()
		{
			return new PinballInGameStateChangeNotify();
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x060125CA RID: 75210 RVA: 0x002ADC77 File Offset: 0x002ABE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x060125CB RID: 75211 RVA: 0x002ADC7A File Offset: 0x002ABE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x060125CC RID: 75212 RVA: 0x002ADC81 File Offset: 0x002ABE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify()
		{
		}

		// Token: 0x060125CD RID: 75213 RVA: 0x002ADC8C File Offset: 0x002ABE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify(PinballInGameStateChangeNotify other) : this()
		{
			this.inGameState_ = other.inGameState_;
			this.changeReason_ = other.changeReason_;
			PinballInGameStateChangeNotify.StateInfoPbOneofCase stateInfoPbCase = other.StateInfoPbCase;
			if (stateInfoPbCase != PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				if (stateInfoPbCase == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
				{
					this.SettlePreSubmitPb = other.SettlePreSubmitPb.Clone();
				}
			}
			else
			{
				this.InProgressPb = other.InProgressPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125CE RID: 75214 RVA: 0x002ADCFF File Offset: 0x002ABEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify Clone()
		{
			return new PinballInGameStateChangeNotify(this);
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x060125CF RID: 75215 RVA: 0x002ADD07 File Offset: 0x002ABF07
		// (set) Token: 0x060125D0 RID: 75216 RVA: 0x002ADD0F File Offset: 0x002ABF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStatePb InGameState
		{
			get
			{
				return this.inGameState_;
			}
			set
			{
				this.inGameState_ = value;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x060125D1 RID: 75217 RVA: 0x002ADD18 File Offset: 0x002ABF18
		// (set) Token: 0x060125D2 RID: 75218 RVA: 0x002ADD20 File Offset: 0x002ABF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStateChangeReasonPb ChangeReason
		{
			get
			{
				return this.changeReason_;
			}
			set
			{
				this.changeReason_ = value;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x060125D3 RID: 75219 RVA: 0x002ADD29 File Offset: 0x002ABF29
		// (set) Token: 0x060125D4 RID: 75220 RVA: 0x002ADD42 File Offset: 0x002ABF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb InProgressPb
		{
			get
			{
				if (this.stateInfoPbCase_ != PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
				{
					return null;
				}
				return (PinballInProgressPb)this.stateInfoPb_;
			}
			set
			{
				this.stateInfoPb_ = value;
				this.stateInfoPbCase_ = ((value == null) ? PinballInGameStateChangeNotify.StateInfoPbOneofCase.None : PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb);
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x060125D5 RID: 75221 RVA: 0x002ADD59 File Offset: 0x002ABF59
		// (set) Token: 0x060125D6 RID: 75222 RVA: 0x002ADD72 File Offset: 0x002ABF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb SettlePreSubmitPb
		{
			get
			{
				if (this.stateInfoPbCase_ != PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
				{
					return null;
				}
				return (PinballSettlePreSubmitPb)this.stateInfoPb_;
			}
			set
			{
				this.stateInfoPb_ = value;
				this.stateInfoPbCase_ = ((value == null) ? PinballInGameStateChangeNotify.StateInfoPbOneofCase.None : PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb);
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x060125D7 RID: 75223 RVA: 0x002ADD89 File Offset: 0x002ABF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify.StateInfoPbOneofCase StateInfoPbCase
		{
			get
			{
				return this.stateInfoPbCase_;
			}
		}

		// Token: 0x060125D8 RID: 75224 RVA: 0x002ADD91 File Offset: 0x002ABF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStateInfoPb()
		{
			this.stateInfoPbCase_ = PinballInGameStateChangeNotify.StateInfoPbOneofCase.None;
			this.stateInfoPb_ = null;
		}

		// Token: 0x060125D9 RID: 75225 RVA: 0x002ADDA1 File Offset: 0x002ABFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameStateChangeNotify);
		}

		// Token: 0x060125DA RID: 75226 RVA: 0x002ADDB0 File Offset: 0x002ABFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameStateChangeNotify other)
		{
			return other != null && (other == this || (this.InGameState == other.InGameState && this.ChangeReason == other.ChangeReason && object.Equals(this.InProgressPb, other.InProgressPb) && object.Equals(this.SettlePreSubmitPb, other.SettlePreSubmitPb) && this.StateInfoPbCase == other.StateInfoPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125DB RID: 75227 RVA: 0x002ADE34 File Offset: 0x002AC034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InGameState != PinballInGameStatePb.NotInitiated)
			{
				num ^= this.InGameState.GetHashCode();
			}
			if (this.ChangeReason != PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive)
			{
				num ^= this.ChangeReason.GetHashCode();
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				num ^= this.InProgressPb.GetHashCode();
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				num ^= this.SettlePreSubmitPb.GetHashCode();
			}
			num ^= (int)this.stateInfoPbCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060125DC RID: 75228 RVA: 0x002ADED1 File Offset: 0x002AC0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125DD RID: 75229 RVA: 0x002ADEDE File Offset: 0x002AC0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125DE RID: 75230 RVA: 0x002ADEE8 File Offset: 0x002AC0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChangeReason != PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ChangeReason);
			}
			if (this.InGameState != PinballInGameStatePb.NotInitiated)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.InGameState);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InProgressPb);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SettlePreSubmitPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125DF RID: 75231 RVA: 0x002ADF80 File Offset: 0x002AC180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InGameState != PinballInGameStatePb.NotInitiated)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.InGameState);
			}
			if (this.ChangeReason != PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChangeReason);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InProgressPb);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SettlePreSubmitPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060125E0 RID: 75232 RVA: 0x002AE00C File Offset: 0x002AC20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameStateChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InGameState != PinballInGameStatePb.NotInitiated)
			{
				this.InGameState = other.InGameState;
			}
			if (other.ChangeReason != PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive)
			{
				this.ChangeReason = other.ChangeReason;
			}
			PinballInGameStateChangeNotify.StateInfoPbOneofCase stateInfoPbCase = other.StateInfoPbCase;
			if (stateInfoPbCase != PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				if (stateInfoPbCase == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
				{
					if (this.SettlePreSubmitPb == null)
					{
						this.SettlePreSubmitPb = new PinballSettlePreSubmitPb();
					}
					this.SettlePreSubmitPb.MergeFrom(other.SettlePreSubmitPb);
				}
			}
			else
			{
				if (this.InProgressPb == null)
				{
					this.InProgressPb = new PinballInProgressPb();
				}
				this.InProgressPb.MergeFrom(other.InProgressPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125E1 RID: 75233 RVA: 0x002AE0B9 File Offset: 0x002AC2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125E2 RID: 75234 RVA: 0x002AE0C4 File Offset: 0x002AC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 96U)
				{
					if (num == 80U)
					{
						this.ChangeReason = (PinballStateChangeReasonPb)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.InGameState = (PinballInGameStatePb)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						PinballInProgressPb pinballInProgressPb = new PinballInProgressPb();
						if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
						{
							pinballInProgressPb.MergeFrom(this.InProgressPb);
						}
						input.ReadMessage(pinballInProgressPb);
						this.InProgressPb = pinballInProgressPb;
						continue;
					}
					if (num == 114U)
					{
						PinballSettlePreSubmitPb pinballSettlePreSubmitPb = new PinballSettlePreSubmitPb();
						if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
						{
							pinballSettlePreSubmitPb.MergeFrom(this.SettlePreSubmitPb);
						}
						input.ReadMessage(pinballSettlePreSubmitPb);
						this.SettlePreSubmitPb = pinballSettlePreSubmitPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400725B RID: 29275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400725C RID: 29276
		public const int InGameStateFieldNumber = 12;

		// Token: 0x0400725D RID: 29277
		private PinballInGameStatePb inGameState_;

		// Token: 0x0400725E RID: 29278
		public const int ChangeReasonFieldNumber = 10;

		// Token: 0x0400725F RID: 29279
		private PinballStateChangeReasonPb changeReason_;

		// Token: 0x04007260 RID: 29280
		public const int InProgressPbFieldNumber = 13;

		// Token: 0x04007261 RID: 29281
		public const int SettlePreSubmitPbFieldNumber = 14;

		// Token: 0x04007262 RID: 29282
		private object stateInfoPb_;

		// Token: 0x04007263 RID: 29283
		private PinballInGameStateChangeNotify.StateInfoPbOneofCase stateInfoPbCase_;

		// Token: 0x020018D1 RID: 6353
		public enum StateInfoPbOneofCase
		{
			// Token: 0x0400C8D7 RID: 51415
			None,
			// Token: 0x0400C8D8 RID: 51416
			InProgressPb = 13,
			// Token: 0x0400C8D9 RID: 51417
			SettlePreSubmitPb
		}
	}
}
