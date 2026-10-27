using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F20 RID: 3872
	[NetMessage(EMessageId.ReportPlayerResponse)]
	public sealed class ReportPlayerResponse : IMessage<ReportPlayerResponse>, IMessage, IEquatable<ReportPlayerResponse>, IDeepCloneable<ReportPlayerResponse>, IBufferMessage
	{
		// Token: 0x06014B96 RID: 84886 RVA: 0x00301F4E File Offset: 0x0030014E
		[NullableContext(1)]
		public static ReportPlayerResponse Create()
		{
			return new ReportPlayerResponse();
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x06014B97 RID: 84887 RVA: 0x00301F55 File Offset: 0x00300155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x06014B98 RID: 84888 RVA: 0x00301F58 File Offset: 0x00300158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06014B99 RID: 84889 RVA: 0x00301F5F File Offset: 0x0030015F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse()
		{
		}

		// Token: 0x06014B9A RID: 84890 RVA: 0x00301F67 File Offset: 0x00300167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse(ReportPlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.reportCount_ = other.reportCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B9B RID: 84891 RVA: 0x00301F98 File Offset: 0x00300198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerResponse Clone()
		{
			return new ReportPlayerResponse(this);
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x06014B9C RID: 84892 RVA: 0x00301FA0 File Offset: 0x003001A0
		// (set) Token: 0x06014B9D RID: 84893 RVA: 0x00301FA8 File Offset: 0x003001A8
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

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x06014B9E RID: 84894 RVA: 0x00301FB1 File Offset: 0x003001B1
		// (set) Token: 0x06014B9F RID: 84895 RVA: 0x00301FB9 File Offset: 0x003001B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportCount
		{
			get
			{
				return this.reportCount_;
			}
			set
			{
				this.reportCount_ = value;
			}
		}

		// Token: 0x06014BA0 RID: 84896 RVA: 0x00301FC2 File Offset: 0x003001C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerResponse);
		}

		// Token: 0x06014BA1 RID: 84897 RVA: 0x00301FD0 File Offset: 0x003001D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ReportCount == other.ReportCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BA2 RID: 84898 RVA: 0x00302010 File Offset: 0x00300210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ReportCount != 0)
			{
				num ^= this.ReportCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014BA3 RID: 84899 RVA: 0x0030206E File Offset: 0x0030026E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BA4 RID: 84900 RVA: 0x0030207B File Offset: 0x0030027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BA5 RID: 84901 RVA: 0x00302084 File Offset: 0x00300284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ReportCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ReportCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BA6 RID: 84902 RVA: 0x003020E0 File Offset: 0x003002E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ReportCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014BA7 RID: 84903 RVA: 0x00302138 File Offset: 0x00300338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportPlayerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ReportCount != 0)
			{
				this.ReportCount = other.ReportCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014BA8 RID: 84904 RVA: 0x00302188 File Offset: 0x00300388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BA9 RID: 84905 RVA: 0x00302194 File Offset: 0x00300394
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReportCount = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D35 RID: 32053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D36 RID: 32054
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007D37 RID: 32055
		private ErrorCode errorCode_;

		// Token: 0x04007D38 RID: 32056
		public const int ReportCountFieldNumber = 6;

		// Token: 0x04007D39 RID: 32057
		private int reportCount_;
	}
}
