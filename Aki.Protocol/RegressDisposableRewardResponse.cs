using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE0 RID: 3808
	[NetMessage(EMessageId.RegressDisposableRewardResponse)]
	public sealed class RegressDisposableRewardResponse : IMessage<RegressDisposableRewardResponse>, IMessage, IEquatable<RegressDisposableRewardResponse>, IDeepCloneable<RegressDisposableRewardResponse>, IBufferMessage
	{
		// Token: 0x0601469A RID: 83610 RVA: 0x002F7896 File Offset: 0x002F5A96
		[NullableContext(1)]
		public static RegressDisposableRewardResponse Create()
		{
			return new RegressDisposableRewardResponse();
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x0601469B RID: 83611 RVA: 0x002F789D File Offset: 0x002F5A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x0601469C RID: 83612 RVA: 0x002F78A0 File Offset: 0x002F5AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressDisposableRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601469D RID: 83613 RVA: 0x002F78A7 File Offset: 0x002F5AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse()
		{
		}

		// Token: 0x0601469E RID: 83614 RVA: 0x002F78AF File Offset: 0x002F5AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse(RegressDisposableRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601469F RID: 83615 RVA: 0x002F78D4 File Offset: 0x002F5AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressDisposableRewardResponse Clone()
		{
			return new RegressDisposableRewardResponse(this);
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x060146A0 RID: 83616 RVA: 0x002F78DC File Offset: 0x002F5ADC
		// (set) Token: 0x060146A1 RID: 83617 RVA: 0x002F78E4 File Offset: 0x002F5AE4
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

		// Token: 0x060146A2 RID: 83618 RVA: 0x002F78ED File Offset: 0x002F5AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressDisposableRewardResponse);
		}

		// Token: 0x060146A3 RID: 83619 RVA: 0x002F78FB File Offset: 0x002F5AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressDisposableRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146A4 RID: 83620 RVA: 0x002F792C File Offset: 0x002F5B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146A5 RID: 83621 RVA: 0x002F7971 File Offset: 0x002F5B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146A6 RID: 83622 RVA: 0x002F797E File Offset: 0x002F5B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146A7 RID: 83623 RVA: 0x002F7987 File Offset: 0x002F5B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146A8 RID: 83624 RVA: 0x002F79BC File Offset: 0x002F5BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146A9 RID: 83625 RVA: 0x002F79FA File Offset: 0x002F5BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressDisposableRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146AA RID: 83626 RVA: 0x002F7A2B File Offset: 0x002F5C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146AB RID: 83627 RVA: 0x002F7A34 File Offset: 0x002F5C34
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007BF0 RID: 31728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BF1 RID: 31729
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007BF2 RID: 31730
		private ErrorCode errorCode_;
	}
}
