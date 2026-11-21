using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECA RID: 3786
	[NetMessage(EMessageId.RegressBonusResponse)]
	public sealed class RegressBonusResponse : IMessage<RegressBonusResponse>, IMessage, IEquatable<RegressBonusResponse>, IDeepCloneable<RegressBonusResponse>, IBufferMessage
	{
		// Token: 0x06014526 RID: 83238 RVA: 0x002F4858 File Offset: 0x002F2A58
		[NullableContext(1)]
		public static RegressBonusResponse Create()
		{
			return new RegressBonusResponse();
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x06014527 RID: 83239 RVA: 0x002F485F File Offset: 0x002F2A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x06014528 RID: 83240 RVA: 0x002F4862 File Offset: 0x002F2A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusResponse.Descriptor;
			}
		}

		// Token: 0x06014529 RID: 83241 RVA: 0x002F4869 File Offset: 0x002F2A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse()
		{
		}

		// Token: 0x0601452A RID: 83242 RVA: 0x002F4888 File Offset: 0x002F2A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse(RegressBonusResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601452B RID: 83243 RVA: 0x002F48DA File Offset: 0x002F2ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusResponse Clone()
		{
			return new RegressBonusResponse(this);
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x0601452C RID: 83244 RVA: 0x002F48E2 File Offset: 0x002F2AE2
		// (set) Token: 0x0601452D RID: 83245 RVA: 0x002F48EA File Offset: 0x002F2AEA
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

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x0601452E RID: 83246 RVA: 0x002F48F3 File Offset: 0x002F2AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x0601452F RID: 83247 RVA: 0x002F48FB File Offset: 0x002F2AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RegressBonusRewardInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06014530 RID: 83248 RVA: 0x002F4903 File Offset: 0x002F2B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusResponse);
		}

		// Token: 0x06014531 RID: 83249 RVA: 0x002F4914 File Offset: 0x002F2B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014532 RID: 83250 RVA: 0x002F4978 File Offset: 0x002F2B78
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

		// Token: 0x06014533 RID: 83251 RVA: 0x002F49D9 File Offset: 0x002F2BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014534 RID: 83252 RVA: 0x002F49E6 File Offset: 0x002F2BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014535 RID: 83253 RVA: 0x002F49F0 File Offset: 0x002F2BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, RegressBonusResponse._repeated_ids_codec);
			this.info_.WriteTo(ref output, RegressBonusResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014536 RID: 83254 RVA: 0x002F4A50 File Offset: 0x002F2C50
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

		// Token: 0x06014537 RID: 83255 RVA: 0x002F4AB4 File Offset: 0x002F2CB4
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

		// Token: 0x06014538 RID: 83256 RVA: 0x002F4B12 File Offset: 0x002F2D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014539 RID: 83257 RVA: 0x002F4B1C File Offset: 0x002F2D1C
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_46;
					}
					if (num == 106U)
					{
						this.info_.AddEntriesFrom(ref input, RegressBonusResponse._repeated_info_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.ids_.AddEntriesFrom(ref input, RegressBonusResponse._repeated_ids_codec);
			}
		}

		// Token: 0x04007BD6 RID: 31702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BD7 RID: 31703
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007BD8 RID: 31704
		private ErrorCode errorCode_;

		// Token: 0x04007BD9 RID: 31705
		public const int IdsFieldNumber = 4;

		// Token: 0x04007BDA RID: 31706
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007BDB RID: 31707
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04007BDC RID: 31708
		public const int InfoFieldNumber = 13;

		// Token: 0x04007BDD RID: 31709
		private static readonly FieldCodec<RegressBonusRewardInfo> _repeated_info_codec = FieldCodec.ForMessage<RegressBonusRewardInfo>(106U, RegressBonusRewardInfo.Parser);

		// Token: 0x04007BDE RID: 31710
		private readonly RepeatedField<RegressBonusRewardInfo> info_ = new RepeatedField<RegressBonusRewardInfo>();
	}
}
