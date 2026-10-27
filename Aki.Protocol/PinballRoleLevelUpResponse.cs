using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5A RID: 3418
	[NetMessage(EMessageId.PinballRoleLevelUpResponse)]
	public sealed class PinballRoleLevelUpResponse : IMessage<PinballRoleLevelUpResponse>, IMessage, IEquatable<PinballRoleLevelUpResponse>, IDeepCloneable<PinballRoleLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06012708 RID: 75528 RVA: 0x002B0FA0 File Offset: 0x002AF1A0
		[NullableContext(1)]
		public static PinballRoleLevelUpResponse Create()
		{
			return new PinballRoleLevelUpResponse();
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x06012709 RID: 75529 RVA: 0x002B0FA7 File Offset: 0x002AF1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0601270A RID: 75530 RVA: 0x002B0FAA File Offset: 0x002AF1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601270B RID: 75531 RVA: 0x002B0FB1 File Offset: 0x002AF1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse()
		{
		}

		// Token: 0x0601270C RID: 75532 RVA: 0x002B0FB9 File Offset: 0x002AF1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse(PinballRoleLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601270D RID: 75533 RVA: 0x002B0FDE File Offset: 0x002AF1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse Clone()
		{
			return new PinballRoleLevelUpResponse(this);
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0601270E RID: 75534 RVA: 0x002B0FE6 File Offset: 0x002AF1E6
		// (set) Token: 0x0601270F RID: 75535 RVA: 0x002B0FEE File Offset: 0x002AF1EE
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

		// Token: 0x06012710 RID: 75536 RVA: 0x002B0FF7 File Offset: 0x002AF1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleLevelUpResponse);
		}

		// Token: 0x06012711 RID: 75537 RVA: 0x002B1005 File Offset: 0x002AF205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012712 RID: 75538 RVA: 0x002B1034 File Offset: 0x002AF234
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

		// Token: 0x06012713 RID: 75539 RVA: 0x002B1079 File Offset: 0x002AF279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012714 RID: 75540 RVA: 0x002B1086 File Offset: 0x002AF286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012715 RID: 75541 RVA: 0x002B108F File Offset: 0x002AF28F
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

		// Token: 0x06012716 RID: 75542 RVA: 0x002B10C4 File Offset: 0x002AF2C4
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

		// Token: 0x06012717 RID: 75543 RVA: 0x002B1102 File Offset: 0x002AF302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoleLevelUpResponse other)
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

		// Token: 0x06012718 RID: 75544 RVA: 0x002B1133 File Offset: 0x002AF333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012719 RID: 75545 RVA: 0x002B113C File Offset: 0x002AF33C
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

		// Token: 0x040072CA RID: 29386
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072CB RID: 29387
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040072CC RID: 29388
		private ErrorCode errorCode_;
	}
}
