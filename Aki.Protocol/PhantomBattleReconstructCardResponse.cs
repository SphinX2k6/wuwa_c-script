using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C94 RID: 3220
	[NetMessage(EMessageId.PhantomBattleReconstructCardResponse)]
	public sealed class PhantomBattleReconstructCardResponse : IMessage<PhantomBattleReconstructCardResponse>, IMessage, IEquatable<PhantomBattleReconstructCardResponse>, IDeepCloneable<PhantomBattleReconstructCardResponse>, IBufferMessage
	{
		// Token: 0x06011795 RID: 71573 RVA: 0x0028FEC4 File Offset: 0x0028E0C4
		[NullableContext(1)]
		public static PhantomBattleReconstructCardResponse Create()
		{
			return new PhantomBattleReconstructCardResponse();
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x06011796 RID: 71574 RVA: 0x0028FECB File Offset: 0x0028E0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x06011797 RID: 71575 RVA: 0x0028FECE File Offset: 0x0028E0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardResponse.Descriptor;
			}
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x0028FED5 File Offset: 0x0028E0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardResponse()
		{
		}

		// Token: 0x06011799 RID: 71577 RVA: 0x0028FEE8 File Offset: 0x0028E0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardResponse(PhantomBattleReconstructCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.effectUid_ = other.effectUid_;
			this.selectedCardUid_ = other.selectedCardUid_.Clone();
			this.heapNum_ = other.heapNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601179A RID: 71578 RVA: 0x0028FF41 File Offset: 0x0028E141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardResponse Clone()
		{
			return new PhantomBattleReconstructCardResponse(this);
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0601179B RID: 71579 RVA: 0x0028FF49 File Offset: 0x0028E149
		// (set) Token: 0x0601179C RID: 71580 RVA: 0x0028FF51 File Offset: 0x0028E151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x0601179D RID: 71581 RVA: 0x0028FF5A File Offset: 0x0028E15A
		// (set) Token: 0x0601179E RID: 71582 RVA: 0x0028FF62 File Offset: 0x0028E162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectUid
		{
			get
			{
				return this.effectUid_;
			}
			set
			{
				this.effectUid_ = value;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0601179F RID: 71583 RVA: 0x0028FF6B File Offset: 0x0028E16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x060117A0 RID: 71584 RVA: 0x0028FF73 File Offset: 0x0028E173
		// (set) Token: 0x060117A1 RID: 71585 RVA: 0x0028FF7B File Offset: 0x0028E17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeapNum
		{
			get
			{
				return this.heapNum_;
			}
			set
			{
				this.heapNum_ = value;
			}
		}

		// Token: 0x060117A2 RID: 71586 RVA: 0x0028FF84 File Offset: 0x0028E184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardResponse);
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x0028FF94 File Offset: 0x0028E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && this.HeapNum == other.HeapNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x00290004 File Offset: 0x0028E204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EffectUid != 0)
			{
				num ^= this.EffectUid.GetHashCode();
			}
			num ^= this.selectedCardUid_.GetHashCode();
			if (this.HeapNum != 0)
			{
				num ^= this.HeapNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x00290089 File Offset: 0x0028E289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x00290096 File Offset: 0x0028E296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117A7 RID: 71591 RVA: 0x002900A0 File Offset: 0x0028E2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.HeapNum);
			}
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EffectUid);
			}
			this.selectedCardUid_.WriteTo(ref output, PhantomBattleReconstructCardResponse._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117A8 RID: 71592 RVA: 0x00290128 File Offset: 0x0028E328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.selectedCardUid_.CalculateSize(PhantomBattleReconstructCardResponse._repeated_selectedCardUid_codec);
			if (this.HeapNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeapNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060117A9 RID: 71593 RVA: 0x002901AC File Offset: 0x0028E3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReconstructCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EffectUid != 0)
			{
				this.EffectUid = other.EffectUid;
			}
			this.selectedCardUid_.Add(other.selectedCardUid_);
			if (other.HeapNum != 0)
			{
				this.HeapNum = other.HeapNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117AA RID: 71594 RVA: 0x00290221 File Offset: 0x0028E421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117AB RID: 71595 RVA: 0x0029022C File Offset: 0x0028E42C
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
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.HeapNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.selectedCardUid_.AddEntriesFrom(ref input, PhantomBattleReconstructCardResponse._repeated_selectedCardUid_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EA9 RID: 28329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EAA RID: 28330
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006EAB RID: 28331
		private ErrorCode errorCode_;

		// Token: 0x04006EAC RID: 28332
		public const int EffectUidFieldNumber = 13;

		// Token: 0x04006EAD RID: 28333
		private int effectUid_;

		// Token: 0x04006EAE RID: 28334
		public const int SelectedCardUidFieldNumber = 15;

		// Token: 0x04006EAF RID: 28335
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04006EB0 RID: 28336
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();

		// Token: 0x04006EB1 RID: 28337
		public const int HeapNumFieldNumber = 12;

		// Token: 0x04006EB2 RID: 28338
		private int heapNum_;
	}
}
