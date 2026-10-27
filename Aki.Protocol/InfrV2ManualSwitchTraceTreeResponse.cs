using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000801 RID: 2049
	[NetMessage(EMessageId.InfrV2ManualSwitchTraceTreeResponse)]
	public sealed class InfrV2ManualSwitchTraceTreeResponse : IMessage<InfrV2ManualSwitchTraceTreeResponse>, IMessage, IEquatable<InfrV2ManualSwitchTraceTreeResponse>, IDeepCloneable<InfrV2ManualSwitchTraceTreeResponse>, IBufferMessage
	{
		// Token: 0x0600B770 RID: 46960 RVA: 0x001B5485 File Offset: 0x001B3685
		[NullableContext(1)]
		public static InfrV2ManualSwitchTraceTreeResponse Create()
		{
			return new InfrV2ManualSwitchTraceTreeResponse();
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x0600B771 RID: 46961 RVA: 0x001B548C File Offset: 0x001B368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x001B548F File Offset: 0x001B368F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualSwitchTraceTreeResponse.Descriptor;
			}
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x001B5496 File Offset: 0x001B3696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse()
		{
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x001B549E File Offset: 0x001B369E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse(InfrV2ManualSwitchTraceTreeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x001B54C3 File Offset: 0x001B36C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeResponse Clone()
		{
			return new InfrV2ManualSwitchTraceTreeResponse(this);
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x001B54CB File Offset: 0x001B36CB
		// (set) Token: 0x0600B777 RID: 46967 RVA: 0x001B54D3 File Offset: 0x001B36D3
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

		// Token: 0x0600B778 RID: 46968 RVA: 0x001B54DC File Offset: 0x001B36DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualSwitchTraceTreeResponse);
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x001B54EA File Offset: 0x001B36EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualSwitchTraceTreeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x001B5518 File Offset: 0x001B3718
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

		// Token: 0x0600B77B RID: 46971 RVA: 0x001B555D File Offset: 0x001B375D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x001B556A File Offset: 0x001B376A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x001B5573 File Offset: 0x001B3773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600B77E RID: 46974 RVA: 0x001B55A8 File Offset: 0x001B37A8
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

		// Token: 0x0600B77F RID: 46975 RVA: 0x001B55E6 File Offset: 0x001B37E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualSwitchTraceTreeResponse other)
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

		// Token: 0x0600B780 RID: 46976 RVA: 0x001B5617 File Offset: 0x001B3817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x001B5620 File Offset: 0x001B3820
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050FA RID: 20730
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050FB RID: 20731
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040050FC RID: 20732
		private ErrorCode errorCode_;
	}
}
