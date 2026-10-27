using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA4 RID: 3236
	[NetMessage(EMessageId.PhantomBattleReconstructCardResponse)]
	public sealed class PhantomBattleReconstructCardResponse : IMessage<PhantomBattleReconstructCardResponse>, IMessage, IEquatable<PhantomBattleReconstructCardResponse>, IDeepCloneable<PhantomBattleReconstructCardResponse>, IBufferMessage
	{
		// Token: 0x06011895 RID: 71829 RVA: 0x00291C2F File Offset: 0x0028FE2F
		[NullableContext(1)]
		public static PhantomBattleReconstructCardResponse Create()
		{
			return new PhantomBattleReconstructCardResponse();
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x06011896 RID: 71830 RVA: 0x00291C36 File Offset: 0x0028FE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x06011897 RID: 71831 RVA: 0x00291C39 File Offset: 0x0028FE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardResponse.Descriptor;
			}
		}

		// Token: 0x06011898 RID: 71832 RVA: 0x00291C40 File Offset: 0x0028FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardResponse()
		{
		}

		// Token: 0x06011899 RID: 71833 RVA: 0x00291C54 File Offset: 0x0028FE54
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

		// Token: 0x0601189A RID: 71834 RVA: 0x00291CAD File Offset: 0x0028FEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardResponse Clone()
		{
			return new PhantomBattleReconstructCardResponse(this);
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0601189B RID: 71835 RVA: 0x00291CB5 File Offset: 0x0028FEB5
		// (set) Token: 0x0601189C RID: 71836 RVA: 0x00291CBD File Offset: 0x0028FEBD
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

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0601189D RID: 71837 RVA: 0x00291CC6 File Offset: 0x0028FEC6
		// (set) Token: 0x0601189E RID: 71838 RVA: 0x00291CCE File Offset: 0x0028FECE
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

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0601189F RID: 71839 RVA: 0x00291CD7 File Offset: 0x0028FED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x060118A0 RID: 71840 RVA: 0x00291CDF File Offset: 0x0028FEDF
		// (set) Token: 0x060118A1 RID: 71841 RVA: 0x00291CE7 File Offset: 0x0028FEE7
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

		// Token: 0x060118A2 RID: 71842 RVA: 0x00291CF0 File Offset: 0x0028FEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardResponse);
		}

		// Token: 0x060118A3 RID: 71843 RVA: 0x00291D00 File Offset: 0x0028FF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && this.HeapNum == other.HeapNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118A4 RID: 71844 RVA: 0x00291D70 File Offset: 0x0028FF70
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

		// Token: 0x060118A5 RID: 71845 RVA: 0x00291DF5 File Offset: 0x0028FFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118A6 RID: 71846 RVA: 0x00291E02 File Offset: 0x00290002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118A7 RID: 71847 RVA: 0x00291E0C File Offset: 0x0029000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectUid);
			}
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HeapNum);
			}
			this.selectedCardUid_.WriteTo(ref output, PhantomBattleReconstructCardResponse._repeated_selectedCardUid_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118A8 RID: 71848 RVA: 0x00291E94 File Offset: 0x00290094
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

		// Token: 0x060118A9 RID: 71849 RVA: 0x00291F18 File Offset: 0x00290118
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

		// Token: 0x060118AA RID: 71850 RVA: 0x00291F8D File Offset: 0x0029018D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118AB RID: 71851 RVA: 0x00291F98 File Offset: 0x00290198
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.HeapNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.selectedCardUid_.AddEntriesFrom(ref input, PhantomBattleReconstructCardResponse._repeated_selectedCardUid_codec);
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E95 RID: 28309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E96 RID: 28310
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006E97 RID: 28311
		private ErrorCode errorCode_;

		// Token: 0x04006E98 RID: 28312
		public const int EffectUidFieldNumber = 5;

		// Token: 0x04006E99 RID: 28313
		private int effectUid_;

		// Token: 0x04006E9A RID: 28314
		public const int SelectedCardUidFieldNumber = 9;

		// Token: 0x04006E9B RID: 28315
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006E9C RID: 28316
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();

		// Token: 0x04006E9D RID: 28317
		public const int HeapNumFieldNumber = 8;

		// Token: 0x04006E9E RID: 28318
		private int heapNum_;
	}
}
