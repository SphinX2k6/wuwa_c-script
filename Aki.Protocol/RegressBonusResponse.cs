using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDA RID: 3802
	[NetMessage(EMessageId.RegressBonusResponse)]
	public sealed class RegressBonusResponse : IMessage<RegressBonusResponse>, IMessage, IEquatable<RegressBonusResponse>, IDeepCloneable<RegressBonusResponse>, IBufferMessage
	{
		// Token: 0x0601460B RID: 83467 RVA: 0x002F5F0C File Offset: 0x002F410C
		[NullableContext(1)]
		public static RegressBonusResponse Create()
		{
			return new RegressBonusResponse();
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x0601460C RID: 83468 RVA: 0x002F5F13 File Offset: 0x002F4113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x0601460D RID: 83469 RVA: 0x002F5F16 File Offset: 0x002F4116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusResponse.Descriptor;
			}
		}

		// Token: 0x0601460E RID: 83470 RVA: 0x002F5F1D File Offset: 0x002F411D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse()
		{
		}

		// Token: 0x0601460F RID: 83471 RVA: 0x002F5F3C File Offset: 0x002F413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse(RegressBonusResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014610 RID: 83472 RVA: 0x002F5F8E File Offset: 0x002F418E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse Clone()
		{
			return new RegressBonusResponse(this);
		}

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x06014611 RID: 83473 RVA: 0x002F5F96 File Offset: 0x002F4196
		// (set) Token: 0x06014612 RID: 83474 RVA: 0x002F5F9E File Offset: 0x002F419E
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

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x06014613 RID: 83475 RVA: 0x002F5FA7 File Offset: 0x002F41A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x06014614 RID: 83476 RVA: 0x002F5FAF File Offset: 0x002F41AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RegressBonusRewardInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06014615 RID: 83477 RVA: 0x002F5FB7 File Offset: 0x002F41B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusResponse);
		}

		// Token: 0x06014616 RID: 83478 RVA: 0x002F5FC8 File Offset: 0x002F41C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014617 RID: 83479 RVA: 0x002F602C File Offset: 0x002F422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014618 RID: 83480 RVA: 0x002F608D File Offset: 0x002F428D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014619 RID: 83481 RVA: 0x002F609A File Offset: 0x002F429A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601461A RID: 83482 RVA: 0x002F60A4 File Offset: 0x002F42A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, RegressBonusResponse._repeated_info_codec);
			this.ids_.WriteTo(ref output, RegressBonusResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601461B RID: 83483 RVA: 0x002F6104 File Offset: 0x002F4304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(RegressBonusResponse._repeated_ids_codec);
			num += this.info_.CalculateSize(RegressBonusResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601461C RID: 83484 RVA: 0x002F6168 File Offset: 0x002F4368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBonusResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.ids_.Add(other.ids_);
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601461D RID: 83485 RVA: 0x002F61C6 File Offset: 0x002F43C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601461E RID: 83486 RVA: 0x002F61D0 File Offset: 0x002F43D0
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
				if (num <= 72U)
				{
					if (num == 66U)
					{
						this.info_.AddEntriesFrom(ref input, RegressBonusResponse._repeated_info_codec);
						continue;
					}
					if (num == 72U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4B;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.ids_.AddEntriesFrom(ref input, RegressBonusResponse._repeated_ids_codec);
			}
		}

		// Token: 0x04007BAC RID: 31660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BAD RID: 31661
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007BAE RID: 31662
		private ErrorCode errorCode_;

		// Token: 0x04007BAF RID: 31663
		public const int IdsFieldNumber = 9;

		// Token: 0x04007BB0 RID: 31664
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007BB1 RID: 31665
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04007BB2 RID: 31666
		public const int InfoFieldNumber = 8;

		// Token: 0x04007BB3 RID: 31667
		private static readonly FieldCodec<RegressBonusRewardInfo> _repeated_info_codec = FieldCodec.ForMessage<RegressBonusRewardInfo>(66U, RegressBonusRewardInfo.Parser);

		// Token: 0x04007BB4 RID: 31668
		private readonly RepeatedField<RegressBonusRewardInfo> info_ = new RepeatedField<RegressBonusRewardInfo>();
	}
}
