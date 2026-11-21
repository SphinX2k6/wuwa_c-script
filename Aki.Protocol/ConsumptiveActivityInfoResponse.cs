using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EA RID: 746
	[NetMessage(EMessageId.ConsumptiveActivityInfoResponse)]
	public sealed class ConsumptiveActivityInfoResponse : IMessage<ConsumptiveActivityInfoResponse>, IMessage, IEquatable<ConsumptiveActivityInfoResponse>, IDeepCloneable<ConsumptiveActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x06004C18 RID: 19480 RVA: 0x000B9A5E File Offset: 0x000B7C5E
		[NullableContext(1)]
		public static ConsumptiveActivityInfoResponse Create()
		{
			return new ConsumptiveActivityInfoResponse();
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x000B9A65 File Offset: 0x000B7C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x000B9A68 File Offset: 0x000B7C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x000B9A6F File Offset: 0x000B7C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse()
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x000B9A78 File Offset: 0x000B7C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse(ConsumptiveActivityInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.consumptiveActivityInfo_ = ((other.consumptiveActivityInfo_ != null) ? other.consumptiveActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x000B9AC4 File Offset: 0x000B7CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoResponse Clone()
		{
			return new ConsumptiveActivityInfoResponse(this);
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x000B9ACC File Offset: 0x000B7CCC
		// (set) Token: 0x06004C1F RID: 19487 RVA: 0x000B9AD4 File Offset: 0x000B7CD4
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x000B9ADD File Offset: 0x000B7CDD
		// (set) Token: 0x06004C21 RID: 19489 RVA: 0x000B9AE5 File Offset: 0x000B7CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo ConsumptiveActivityInfo
		{
			get
			{
				return this.consumptiveActivityInfo_;
			}
			set
			{
				this.consumptiveActivityInfo_ = value;
			}
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x000B9AEE File Offset: 0x000B7CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfoResponse);
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x000B9AFC File Offset: 0x000B7CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ConsumptiveActivityInfo, other.ConsumptiveActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x000B9B4C File Offset: 0x000B7D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.consumptiveActivityInfo_ != null)
			{
				num ^= this.ConsumptiveActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x000B9BA7 File Offset: 0x000B7DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x000B9BB4 File Offset: 0x000B7DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x000B9BC0 File Offset: 0x000B7DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.consumptiveActivityInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ConsumptiveActivityInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x000B9C1C File Offset: 0x000B7E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.consumptiveActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConsumptiveActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x000B9C74 File Offset: 0x000B7E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.consumptiveActivityInfo_ != null)
			{
				if (this.consumptiveActivityInfo_ == null)
				{
					this.ConsumptiveActivityInfo = new ConsumptiveActivityInfo();
				}
				this.ConsumptiveActivityInfo.MergeFrom(other.ConsumptiveActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x000B9CDC File Offset: 0x000B7EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x000B9CE8 File Offset: 0x000B7EE8
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
				if (num != 98U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.consumptiveActivityInfo_ == null)
					{
						this.ConsumptiveActivityInfo = new ConsumptiveActivityInfo();
					}
					input.ReadMessage(this.ConsumptiveActivityInfo);
				}
			}
		}

		// Token: 0x0400313F RID: 12607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003140 RID: 12608
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003141 RID: 12609
		private ErrorCode errorCode_;

		// Token: 0x04003142 RID: 12610
		public const int ConsumptiveActivityInfoFieldNumber = 12;

		// Token: 0x04003143 RID: 12611
		private ConsumptiveActivityInfo consumptiveActivityInfo_;
	}
}
