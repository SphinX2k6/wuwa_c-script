using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3C RID: 3388
	[NetMessage(EMessageId.PinballInGameStateChangeNotify)]
	public sealed class PinballInGameStateChangeNotify : IMessage<PinballInGameStateChangeNotify>, IMessage, IEquatable<PinballInGameStateChangeNotify>, IDeepCloneable<PinballInGameStateChangeNotify>, IBufferMessage
	{
		// Token: 0x060124CD RID: 74957 RVA: 0x002AC054 File Offset: 0x002AA254
		[NullableContext(1)]
		public static PinballInGameStateChangeNotify Create()
		{
			return new PinballInGameStateChangeNotify();
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x060124CE RID: 74958 RVA: 0x002AC05B File Offset: 0x002AA25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x060124CF RID: 74959 RVA: 0x002AC05E File Offset: 0x002AA25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x060124D0 RID: 74960 RVA: 0x002AC065 File Offset: 0x002AA265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify()
		{
		}

		// Token: 0x060124D1 RID: 74961 RVA: 0x002AC070 File Offset: 0x002AA270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify(PinballInGameStateChangeNotify other) : this()
		{
			this.inGameState_ = other.inGameState_;
			this.changeReason_ = other.changeReason_;
			PinballInGameStateChangeNotify.StateInfoPbOneofCase stateInfoPbCase = other.StateInfoPbCase;
			if (stateInfoPbCase != PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				if (stateInfoPbCase == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
				{
					this.InProgressPb = other.InProgressPb.Clone();
				}
			}
			else
			{
				this.SettlePreSubmitPb = other.SettlePreSubmitPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124D2 RID: 74962 RVA: 0x002AC0E1 File Offset: 0x002AA2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify Clone()
		{
			return new PinballInGameStateChangeNotify(this);
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x060124D3 RID: 74963 RVA: 0x002AC0E9 File Offset: 0x002AA2E9
		// (set) Token: 0x060124D4 RID: 74964 RVA: 0x002AC0F1 File Offset: 0x002AA2F1
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

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x060124D5 RID: 74965 RVA: 0x002AC0FA File Offset: 0x002AA2FA
		// (set) Token: 0x060124D6 RID: 74966 RVA: 0x002AC102 File Offset: 0x002AA302
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x060124D7 RID: 74967 RVA: 0x002AC10B File Offset: 0x002AA30B
		// (set) Token: 0x060124D8 RID: 74968 RVA: 0x002AC124 File Offset: 0x002AA324
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

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x060124D9 RID: 74969 RVA: 0x002AC13B File Offset: 0x002AA33B
		// (set) Token: 0x060124DA RID: 74970 RVA: 0x002AC154 File Offset: 0x002AA354
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

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x060124DB RID: 74971 RVA: 0x002AC16B File Offset: 0x002AA36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStateChangeNotify.StateInfoPbOneofCase StateInfoPbCase
		{
			get
			{
				return this.stateInfoPbCase_;
			}
		}

		// Token: 0x060124DC RID: 74972 RVA: 0x002AC173 File Offset: 0x002AA373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStateInfoPb()
		{
			this.stateInfoPbCase_ = PinballInGameStateChangeNotify.StateInfoPbOneofCase.None;
			this.stateInfoPb_ = null;
		}

		// Token: 0x060124DD RID: 74973 RVA: 0x002AC183 File Offset: 0x002AA383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameStateChangeNotify);
		}

		// Token: 0x060124DE RID: 74974 RVA: 0x002AC194 File Offset: 0x002AA394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameStateChangeNotify other)
		{
			return other != null && (other == this || (this.InGameState == other.InGameState && this.ChangeReason == other.ChangeReason && object.Equals(this.InProgressPb, other.InProgressPb) && object.Equals(this.SettlePreSubmitPb, other.SettlePreSubmitPb) && this.StateInfoPbCase == other.StateInfoPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124DF RID: 74975 RVA: 0x002AC218 File Offset: 0x002AA418
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

		// Token: 0x060124E0 RID: 74976 RVA: 0x002AC2B5 File Offset: 0x002AA4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124E1 RID: 74977 RVA: 0x002AC2C2 File Offset: 0x002AA4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124E2 RID: 74978 RVA: 0x002AC2CC File Offset: 0x002AA4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InGameState != PinballInGameStatePb.NotInitiated)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.InGameState);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SettlePreSubmitPb);
			}
			if (this.stateInfoPbCase_ == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.InProgressPb);
			}
			if (this.ChangeReason != PinballStateChangeReasonPb.SettlePreSubmitAllTeamDeadNoRevive)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ChangeReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124E3 RID: 74979 RVA: 0x002AC364 File Offset: 0x002AA564
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

		// Token: 0x060124E4 RID: 74980 RVA: 0x002AC3F0 File Offset: 0x002AA5F0
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
			if (stateInfoPbCase != PinballInGameStateChangeNotify.StateInfoPbOneofCase.SettlePreSubmitPb)
			{
				if (stateInfoPbCase == PinballInGameStateChangeNotify.StateInfoPbOneofCase.InProgressPb)
				{
					if (this.InProgressPb == null)
					{
						this.InProgressPb = new PinballInProgressPb();
					}
					this.InProgressPb.MergeFrom(other.InProgressPb);
				}
			}
			else
			{
				if (this.SettlePreSubmitPb == null)
				{
					this.SettlePreSubmitPb = new PinballSettlePreSubmitPb();
				}
				this.SettlePreSubmitPb.MergeFrom(other.SettlePreSubmitPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060124E5 RID: 74981 RVA: 0x002AC49B File Offset: 0x002AA69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124E6 RID: 74982 RVA: 0x002AC4A4 File Offset: 0x002AA6A4
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
				if (num <= 90U)
				{
					if (num == 56U)
					{
						this.InGameState = (PinballInGameStatePb)input.ReadEnum();
						continue;
					}
					if (num == 90U)
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
				else
				{
					if (num == 98U)
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
					if (num == 112U)
					{
						this.ChangeReason = (PinballStateChangeReasonPb)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007273 RID: 29299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007274 RID: 29300
		public const int InGameStateFieldNumber = 7;

		// Token: 0x04007275 RID: 29301
		private PinballInGameStatePb inGameState_;

		// Token: 0x04007276 RID: 29302
		public const int ChangeReasonFieldNumber = 14;

		// Token: 0x04007277 RID: 29303
		private PinballStateChangeReasonPb changeReason_;

		// Token: 0x04007278 RID: 29304
		public const int InProgressPbFieldNumber = 12;

		// Token: 0x04007279 RID: 29305
		public const int SettlePreSubmitPbFieldNumber = 11;

		// Token: 0x0400727A RID: 29306
		private object stateInfoPb_;

		// Token: 0x0400727B RID: 29307
		private PinballInGameStateChangeNotify.StateInfoPbOneofCase stateInfoPbCase_;

		// Token: 0x02001949 RID: 6473
		public enum StateInfoPbOneofCase
		{
			// Token: 0x0400CE02 RID: 52738
			None,
			// Token: 0x0400CE03 RID: 52739
			InProgressPb = 12,
			// Token: 0x0400CE04 RID: 52740
			SettlePreSubmitPb = 11
		}
	}
}
