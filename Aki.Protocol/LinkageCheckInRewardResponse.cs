using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000917 RID: 2327
	[NetMessage(EMessageId.LinkageCheckInRewardResponse)]
	public sealed class LinkageCheckInRewardResponse : IMessage<LinkageCheckInRewardResponse>, IMessage, IEquatable<LinkageCheckInRewardResponse>, IDeepCloneable<LinkageCheckInRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CDA3 RID: 52643 RVA: 0x001E5108 File Offset: 0x001E3308
		[NullableContext(1)]
		public static LinkageCheckInRewardResponse Create()
		{
			return new LinkageCheckInRewardResponse();
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600CDA4 RID: 52644 RVA: 0x001E510F File Offset: 0x001E330F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600CDA5 RID: 52645 RVA: 0x001E5112 File Offset: 0x001E3312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x001E5119 File Offset: 0x001E3319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse()
		{
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x001E5121 File Offset: 0x001E3321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse(LinkageCheckInRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x001E5146 File Offset: 0x001E3346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardResponse Clone()
		{
			return new LinkageCheckInRewardResponse(this);
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x001E514E File Offset: 0x001E334E
		// (set) Token: 0x0600CDAA RID: 52650 RVA: 0x001E5156 File Offset: 0x001E3356
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

		// Token: 0x0600CDAB RID: 52651 RVA: 0x001E515F File Offset: 0x001E335F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInRewardResponse);
		}

		// Token: 0x0600CDAC RID: 52652 RVA: 0x001E516D File Offset: 0x001E336D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x001E519C File Offset: 0x001E339C
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

		// Token: 0x0600CDAE RID: 52654 RVA: 0x001E51E1 File Offset: 0x001E33E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x001E51EE File Offset: 0x001E33EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x001E51F7 File Offset: 0x001E33F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x001E522C File Offset: 0x001E342C
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

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x001E526A File Offset: 0x001E346A
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

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x001E529B File Offset: 0x001E349B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x001E52A4 File Offset: 0x001E34A4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400575E RID: 22366
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400575F RID: 22367
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005760 RID: 22368
		private ErrorCode errorCode_;
	}
}
