using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000928 RID: 2344
	[NetMessage(EMessageId.LinkageCheckInRewardResponse)]
	public sealed class LinkageCheckInRewardResponse : IMessage<LinkageCheckInRewardResponse>, IMessage, IEquatable<LinkageCheckInRewardResponse>, IDeepCloneable<LinkageCheckInRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CEBF RID: 52927 RVA: 0x001E73D8 File Offset: 0x001E55D8
		[NullableContext(1)]
		public static LinkageCheckInRewardResponse Create()
		{
			return new LinkageCheckInRewardResponse();
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600CEC0 RID: 52928 RVA: 0x001E73DF File Offset: 0x001E55DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600CEC1 RID: 52929 RVA: 0x001E73E2 File Offset: 0x001E55E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CEC2 RID: 52930 RVA: 0x001E73E9 File Offset: 0x001E55E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse()
		{
		}

		// Token: 0x0600CEC3 RID: 52931 RVA: 0x001E73F1 File Offset: 0x001E55F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse(LinkageCheckInRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEC4 RID: 52932 RVA: 0x001E7416 File Offset: 0x001E5616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse Clone()
		{
			return new LinkageCheckInRewardResponse(this);
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600CEC5 RID: 52933 RVA: 0x001E741E File Offset: 0x001E561E
		// (set) Token: 0x0600CEC6 RID: 52934 RVA: 0x001E7426 File Offset: 0x001E5626
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

		// Token: 0x0600CEC7 RID: 52935 RVA: 0x001E742F File Offset: 0x001E562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInRewardResponse);
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x001E743D File Offset: 0x001E563D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x001E746C File Offset: 0x001E566C
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

		// Token: 0x0600CECA RID: 52938 RVA: 0x001E74B1 File Offset: 0x001E56B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x001E74BE File Offset: 0x001E56BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x001E74C7 File Offset: 0x001E56C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x001E74FC File Offset: 0x001E56FC
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

		// Token: 0x0600CECE RID: 52942 RVA: 0x001E753A File Offset: 0x001E573A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageCheckInRewardResponse other)
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

		// Token: 0x0600CECF RID: 52943 RVA: 0x001E756B File Offset: 0x001E576B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x001E7574 File Offset: 0x001E5774
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005757 RID: 22359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005758 RID: 22360
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005759 RID: 22361
		private ErrorCode errorCode_;
	}
}
