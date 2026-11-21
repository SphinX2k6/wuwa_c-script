using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126C RID: 4716
	[NetMessage(EMessageId.SingleInstRechallengeResponse)]
	public sealed class SingleInstRechallengeResponse : IMessage<SingleInstRechallengeResponse>, IMessage, IEquatable<SingleInstRechallengeResponse>, IDeepCloneable<SingleInstRechallengeResponse>, IBufferMessage
	{
		// Token: 0x060192DA RID: 103130 RVA: 0x003AC299 File Offset: 0x003AA499
		[NullableContext(1)]
		public static SingleInstRechallengeResponse Create()
		{
			return new SingleInstRechallengeResponse();
		}

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x060192DB RID: 103131 RVA: 0x003AC2A0 File Offset: 0x003AA4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x060192DC RID: 103132 RVA: 0x003AC2A3 File Offset: 0x003AA4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleInstRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x060192DD RID: 103133 RVA: 0x003AC2AA File Offset: 0x003AA4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse()
		{
		}

		// Token: 0x060192DE RID: 103134 RVA: 0x003AC2B2 File Offset: 0x003AA4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse(SingleInstRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192DF RID: 103135 RVA: 0x003AC2D7 File Offset: 0x003AA4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeResponse Clone()
		{
			return new SingleInstRechallengeResponse(this);
		}

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x060192E0 RID: 103136 RVA: 0x003AC2DF File Offset: 0x003AA4DF
		// (set) Token: 0x060192E1 RID: 103137 RVA: 0x003AC2E7 File Offset: 0x003AA4E7
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

		// Token: 0x060192E2 RID: 103138 RVA: 0x003AC2F0 File Offset: 0x003AA4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleInstRechallengeResponse);
		}

		// Token: 0x060192E3 RID: 103139 RVA: 0x003AC2FE File Offset: 0x003AA4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleInstRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192E4 RID: 103140 RVA: 0x003AC32C File Offset: 0x003AA52C
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

		// Token: 0x060192E5 RID: 103141 RVA: 0x003AC371 File Offset: 0x003AA571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192E6 RID: 103142 RVA: 0x003AC37E File Offset: 0x003AA57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192E7 RID: 103143 RVA: 0x003AC387 File Offset: 0x003AA587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192E8 RID: 103144 RVA: 0x003AC3BC File Offset: 0x003AA5BC
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

		// Token: 0x060192E9 RID: 103145 RVA: 0x003AC3FA File Offset: 0x003AA5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleInstRechallengeResponse other)
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

		// Token: 0x060192EA RID: 103146 RVA: 0x003AC42B File Offset: 0x003AA62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192EB RID: 103147 RVA: 0x003AC434 File Offset: 0x003AA634
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009510 RID: 38160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009511 RID: 38161
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009512 RID: 38162
		private ErrorCode errorCode_;
	}
}
