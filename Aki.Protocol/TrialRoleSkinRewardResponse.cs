using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DD RID: 5341
	[NetMessage(EMessageId.TrialRoleSkinRewardResponse)]
	public sealed class TrialRoleSkinRewardResponse : IMessage<TrialRoleSkinRewardResponse>, IMessage, IEquatable<TrialRoleSkinRewardResponse>, IDeepCloneable<TrialRoleSkinRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C540 RID: 116032 RVA: 0x0041C648 File Offset: 0x0041A848
		[NullableContext(1)]
		public static TrialRoleSkinRewardResponse Create()
		{
			return new TrialRoleSkinRewardResponse();
		}

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x0601C541 RID: 116033 RVA: 0x0041C64F File Offset: 0x0041A84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x0601C542 RID: 116034 RVA: 0x0041C652 File Offset: 0x0041A852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleSkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C543 RID: 116035 RVA: 0x0041C659 File Offset: 0x0041A859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse()
		{
		}

		// Token: 0x0601C544 RID: 116036 RVA: 0x0041C661 File Offset: 0x0041A861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse(TrialRoleSkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C545 RID: 116037 RVA: 0x0041C686 File Offset: 0x0041A886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardResponse Clone()
		{
			return new TrialRoleSkinRewardResponse(this);
		}

		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x0601C546 RID: 116038 RVA: 0x0041C68E File Offset: 0x0041A88E
		// (set) Token: 0x0601C547 RID: 116039 RVA: 0x0041C696 File Offset: 0x0041A896
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

		// Token: 0x0601C548 RID: 116040 RVA: 0x0041C69F File Offset: 0x0041A89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleSkinRewardResponse);
		}

		// Token: 0x0601C549 RID: 116041 RVA: 0x0041C6AD File Offset: 0x0041A8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleSkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C54A RID: 116042 RVA: 0x0041C6DC File Offset: 0x0041A8DC
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

		// Token: 0x0601C54B RID: 116043 RVA: 0x0041C721 File Offset: 0x0041A921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C54C RID: 116044 RVA: 0x0041C72E File Offset: 0x0041A92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C54D RID: 116045 RVA: 0x0041C737 File Offset: 0x0041A937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C54E RID: 116046 RVA: 0x0041C76C File Offset: 0x0041A96C
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

		// Token: 0x0601C54F RID: 116047 RVA: 0x0041C7AA File Offset: 0x0041A9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleSkinRewardResponse other)
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

		// Token: 0x0601C550 RID: 116048 RVA: 0x0041C7DB File Offset: 0x0041A9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C551 RID: 116049 RVA: 0x0041C7E4 File Offset: 0x0041A9E4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3B9 RID: 41913
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3BA RID: 41914
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400A3BB RID: 41915
		private ErrorCode errorCode_;
	}
}
