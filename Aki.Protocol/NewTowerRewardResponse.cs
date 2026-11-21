using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B34 RID: 2868
	[NetMessage(EMessageId.NewTowerRewardResponse)]
	public sealed class NewTowerRewardResponse : IMessage<NewTowerRewardResponse>, IMessage, IEquatable<NewTowerRewardResponse>, IDeepCloneable<NewTowerRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F939 RID: 63801 RVA: 0x00245F81 File Offset: 0x00244181
		[NullableContext(1)]
		public static NewTowerRewardResponse Create()
		{
			return new NewTowerRewardResponse();
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600F93A RID: 63802 RVA: 0x00245F88 File Offset: 0x00244188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600F93B RID: 63803 RVA: 0x00245F8B File Offset: 0x0024418B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x00245F92 File Offset: 0x00244192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse()
		{
		}

		// Token: 0x0600F93D RID: 63805 RVA: 0x00245F9A File Offset: 0x0024419A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse(NewTowerRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F93E RID: 63806 RVA: 0x00245FBF File Offset: 0x002441BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse Clone()
		{
			return new NewTowerRewardResponse(this);
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600F93F RID: 63807 RVA: 0x00245FC7 File Offset: 0x002441C7
		// (set) Token: 0x0600F940 RID: 63808 RVA: 0x00245FCF File Offset: 0x002441CF
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

		// Token: 0x0600F941 RID: 63809 RVA: 0x00245FD8 File Offset: 0x002441D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRewardResponse);
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x00245FE6 File Offset: 0x002441E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F943 RID: 63811 RVA: 0x00246014 File Offset: 0x00244214
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

		// Token: 0x0600F944 RID: 63812 RVA: 0x00246059 File Offset: 0x00244259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F945 RID: 63813 RVA: 0x00246066 File Offset: 0x00244266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x0024606F File Offset: 0x0024426F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x002460A4 File Offset: 0x002442A4
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

		// Token: 0x0600F948 RID: 63816 RVA: 0x002460E2 File Offset: 0x002442E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRewardResponse other)
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

		// Token: 0x0600F949 RID: 63817 RVA: 0x00246113 File Offset: 0x00244313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F94A RID: 63818 RVA: 0x0024611C File Offset: 0x0024431C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006449 RID: 25673
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400644A RID: 25674
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400644B RID: 25675
		private ErrorCode errorCode_;
	}
}
