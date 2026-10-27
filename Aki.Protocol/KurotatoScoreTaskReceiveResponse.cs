using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BC RID: 2236
	[NetMessage(EMessageId.KurotatoScoreTaskReceiveResponse)]
	public sealed class KurotatoScoreTaskReceiveResponse : IMessage<KurotatoScoreTaskReceiveResponse>, IMessage, IEquatable<KurotatoScoreTaskReceiveResponse>, IDeepCloneable<KurotatoScoreTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C64D RID: 50765 RVA: 0x001D5519 File Offset: 0x001D3719
		[NullableContext(1)]
		public static KurotatoScoreTaskReceiveResponse Create()
		{
			return new KurotatoScoreTaskReceiveResponse();
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x0600C64E RID: 50766 RVA: 0x001D5520 File Offset: 0x001D3720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600C64F RID: 50767 RVA: 0x001D5523 File Offset: 0x001D3723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoScoreTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C650 RID: 50768 RVA: 0x001D552A File Offset: 0x001D372A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse()
		{
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x001D5532 File Offset: 0x001D3732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse(KurotatoScoreTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x001D5557 File Offset: 0x001D3757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoScoreTaskReceiveResponse Clone()
		{
			return new KurotatoScoreTaskReceiveResponse(this);
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600C653 RID: 50771 RVA: 0x001D555F File Offset: 0x001D375F
		// (set) Token: 0x0600C654 RID: 50772 RVA: 0x001D5567 File Offset: 0x001D3767
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

		// Token: 0x0600C655 RID: 50773 RVA: 0x001D5570 File Offset: 0x001D3770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoScoreTaskReceiveResponse);
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x001D557E File Offset: 0x001D377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoScoreTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x001D55AC File Offset: 0x001D37AC
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

		// Token: 0x0600C658 RID: 50776 RVA: 0x001D55F1 File Offset: 0x001D37F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x001D55FE File Offset: 0x001D37FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x001D5607 File Offset: 0x001D3807
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

		// Token: 0x0600C65B RID: 50779 RVA: 0x001D563C File Offset: 0x001D383C
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

		// Token: 0x0600C65C RID: 50780 RVA: 0x001D567A File Offset: 0x001D387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoScoreTaskReceiveResponse other)
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

		// Token: 0x0600C65D RID: 50781 RVA: 0x001D56AB File Offset: 0x001D38AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x001D56B4 File Offset: 0x001D38B4
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

		// Token: 0x04005529 RID: 21801
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400552A RID: 21802
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400552B RID: 21803
		private ErrorCode errorCode_;
	}
}
