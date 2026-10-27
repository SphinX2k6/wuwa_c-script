using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001232 RID: 4658
	public sealed class SingleProcessedFoodFormulaInfo : IMessage<SingleProcessedFoodFormulaInfo>, IMessage, IEquatable<SingleProcessedFoodFormulaInfo>, IDeepCloneable<SingleProcessedFoodFormulaInfo>, IBufferMessage
	{
		// Token: 0x06018D2B RID: 101675 RVA: 0x0039CA5B File Offset: 0x0039AC5B
		[NullableContext(1)]
		public static SingleProcessedFoodFormulaInfo Create()
		{
			return new SingleProcessedFoodFormulaInfo();
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x06018D2C RID: 101676 RVA: 0x0039CA62 File Offset: 0x0039AC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleProcessedFoodFormulaInfo> Parser
		{
			get
			{
				return SingleProcessedFoodFormulaInfo._parser;
			}
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x06018D2D RID: 101677 RVA: 0x0039CA69 File Offset: 0x0039AC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x06018D2E RID: 101678 RVA: 0x0039CA6C File Offset: 0x0039AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleProcessedFoodFormulaInfo.Descriptor;
			}
		}

		// Token: 0x06018D2F RID: 101679 RVA: 0x0039CA73 File Offset: 0x0039AC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo()
		{
		}

		// Token: 0x06018D30 RID: 101680 RVA: 0x0039CA94 File Offset: 0x0039AC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo(SingleProcessedFoodFormulaInfo other) : this()
		{
			this.id_ = other.id_;
			this.lockState_ = other.lockState_;
			this.interations_ = other.interations_.Clone();
			this.unlockParams_ = other.unlockParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D31 RID: 101681 RVA: 0x0039CAF2 File Offset: 0x0039ACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo Clone()
		{
			return new SingleProcessedFoodFormulaInfo(this);
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x06018D32 RID: 101682 RVA: 0x0039CAFA File Offset: 0x0039ACFA
		// (set) Token: 0x06018D33 RID: 101683 RVA: 0x0039CB02 File Offset: 0x0039AD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x06018D34 RID: 101684 RVA: 0x0039CB0B File Offset: 0x0039AD0B
		// (set) Token: 0x06018D35 RID: 101685 RVA: 0x0039CB13 File Offset: 0x0039AD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LockState
		{
			get
			{
				return this.lockState_;
			}
			set
			{
				this.lockState_ = value;
			}
		}

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x06018D36 RID: 101686 RVA: 0x0039CB1C File Offset: 0x0039AD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Interations
		{
			get
			{
				return this.interations_;
			}
		}

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x06018D37 RID: 101687 RVA: 0x0039CB24 File Offset: 0x0039AD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockParams
		{
			get
			{
				return this.unlockParams_;
			}
		}

		// Token: 0x06018D38 RID: 101688 RVA: 0x0039CB2C File Offset: 0x0039AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleProcessedFoodFormulaInfo);
		}

		// Token: 0x06018D39 RID: 101689 RVA: 0x0039CB3C File Offset: 0x0039AD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleProcessedFoodFormulaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LockState == other.LockState && this.interations_.Equals(other.interations_) && this.unlockParams_.Equals(other.unlockParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D3A RID: 101690 RVA: 0x0039CBB0 File Offset: 0x0039ADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LockState)
			{
				num ^= this.LockState.GetHashCode();
			}
			num ^= this.interations_.GetHashCode();
			num ^= this.unlockParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D3B RID: 101691 RVA: 0x0039CC24 File Offset: 0x0039AE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D3C RID: 101692 RVA: 0x0039CC31 File Offset: 0x0039AE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D3D RID: 101693 RVA: 0x0039CC3C File Offset: 0x0039AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.LockState)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.LockState);
			}
			this.interations_.WriteTo(ref output, SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			this.unlockParams_.WriteTo(ref output, SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D3E RID: 101694 RVA: 0x0039CCB8 File Offset: 0x0039AEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LockState)
			{
				num += 2;
			}
			num += this.interations_.CalculateSize(SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			num += this.unlockParams_.CalculateSize(SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D3F RID: 101695 RVA: 0x0039CD28 File Offset: 0x0039AF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleProcessedFoodFormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LockState)
			{
				this.LockState = other.LockState;
			}
			this.interations_.Add(other.interations_);
			this.unlockParams_.Add(other.unlockParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D40 RID: 101696 RVA: 0x0039CD9A File Offset: 0x0039AF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D41 RID: 101697 RVA: 0x0039CDA4 File Offset: 0x0039AFA4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LockState = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						goto IL_5D;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_5D;
					}
					if (num == 32U || num == 34U)
					{
						this.unlockParams_.AddEntriesFrom(ref input, SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5D:
				this.interations_.AddEntriesFrom(ref input, SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			}
		}

		// Token: 0x0400926E RID: 37486
		private static readonly MessageParser<SingleProcessedFoodFormulaInfo> _parser = new MessageParser<SingleProcessedFoodFormulaInfo>(() => new SingleProcessedFoodFormulaInfo());

		// Token: 0x0400926F RID: 37487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009270 RID: 37488
		public const int IdFieldNumber = 1;

		// Token: 0x04009271 RID: 37489
		private int id_;

		// Token: 0x04009272 RID: 37490
		public const int LockStateFieldNumber = 2;

		// Token: 0x04009273 RID: 37491
		private bool lockState_;

		// Token: 0x04009274 RID: 37492
		public const int InterationsFieldNumber = 3;

		// Token: 0x04009275 RID: 37493
		private static readonly FieldCodec<int> _repeated_interations_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009276 RID: 37494
		private readonly RepeatedField<int> interations_ = new RepeatedField<int>();

		// Token: 0x04009277 RID: 37495
		public const int UnlockParamsFieldNumber = 4;

		// Token: 0x04009278 RID: 37496
		private static readonly FieldCodec<int> _repeated_unlockParams_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009279 RID: 37497
		private readonly RepeatedField<int> unlockParams_ = new RepeatedField<int>();
	}
}
