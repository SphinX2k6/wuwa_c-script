using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081A RID: 2074
	[NetMessage(EMessageId.InstTeleportToResetPointResponse)]
	public sealed class InstTeleportToResetPointResponse : IMessage<InstTeleportToResetPointResponse>, IMessage, IEquatable<InstTeleportToResetPointResponse>, IDeepCloneable<InstTeleportToResetPointResponse>, IBufferMessage
	{
		// Token: 0x0600B9DB RID: 47579 RVA: 0x001BB63E File Offset: 0x001B983E
		[NullableContext(1)]
		public static InstTeleportToResetPointResponse Create()
		{
			return new InstTeleportToResetPointResponse();
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x001BB645 File Offset: 0x001B9845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x0600B9DD RID: 47581 RVA: 0x001BB648 File Offset: 0x001B9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTeleportToResetPointResponse.Descriptor;
			}
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x001BB64F File Offset: 0x001B984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse()
		{
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x001BB657 File Offset: 0x001B9857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse(InstTeleportToResetPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x001BB67C File Offset: 0x001B987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointResponse Clone()
		{
			return new InstTeleportToResetPointResponse(this);
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x001BB684 File Offset: 0x001B9884
		// (set) Token: 0x0600B9E2 RID: 47586 RVA: 0x001BB68C File Offset: 0x001B988C
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

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x001BB695 File Offset: 0x001B9895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTeleportToResetPointResponse);
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x001BB6A3 File Offset: 0x001B98A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTeleportToResetPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x001BB6D4 File Offset: 0x001B98D4
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

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x001BB719 File Offset: 0x001B9919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x001BB726 File Offset: 0x001B9926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x001BB72F File Offset: 0x001B992F
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

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x001BB764 File Offset: 0x001B9964
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

		// Token: 0x0600B9EA RID: 47594 RVA: 0x001BB7A2 File Offset: 0x001B99A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstTeleportToResetPointResponse other)
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

		// Token: 0x0600B9EB RID: 47595 RVA: 0x001BB7D3 File Offset: 0x001B99D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x001BB7DC File Offset: 0x001B99DC
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

		// Token: 0x04005231 RID: 21041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005232 RID: 21042
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005233 RID: 21043
		private ErrorCode errorCode_;
	}
}
