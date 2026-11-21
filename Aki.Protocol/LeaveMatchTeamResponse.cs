using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DE RID: 2270
	[NetMessage(EMessageId.LeaveMatchTeamResponse)]
	public sealed class LeaveMatchTeamResponse : IMessage<LeaveMatchTeamResponse>, IMessage, IEquatable<LeaveMatchTeamResponse>, IDeepCloneable<LeaveMatchTeamResponse>, IBufferMessage
	{
		// Token: 0x0600C918 RID: 51480 RVA: 0x001DB67E File Offset: 0x001D987E
		[NullableContext(1)]
		public static LeaveMatchTeamResponse Create()
		{
			return new LeaveMatchTeamResponse();
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600C919 RID: 51481 RVA: 0x001DB685 File Offset: 0x001D9885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600C91A RID: 51482 RVA: 0x001DB688 File Offset: 0x001D9888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600C91B RID: 51483 RVA: 0x001DB68F File Offset: 0x001D988F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse()
		{
		}

		// Token: 0x0600C91C RID: 51484 RVA: 0x001DB697 File Offset: 0x001D9897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse(LeaveMatchTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x001DB6BC File Offset: 0x001D98BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse Clone()
		{
			return new LeaveMatchTeamResponse(this);
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600C91E RID: 51486 RVA: 0x001DB6C4 File Offset: 0x001D98C4
		// (set) Token: 0x0600C91F RID: 51487 RVA: 0x001DB6CC File Offset: 0x001D98CC
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

		// Token: 0x0600C920 RID: 51488 RVA: 0x001DB6D5 File Offset: 0x001D98D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamResponse);
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x001DB6E3 File Offset: 0x001D98E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C922 RID: 51490 RVA: 0x001DB714 File Offset: 0x001D9914
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

		// Token: 0x0600C923 RID: 51491 RVA: 0x001DB759 File Offset: 0x001D9959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x001DB766 File Offset: 0x001D9966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C925 RID: 51493 RVA: 0x001DB76F File Offset: 0x001D996F
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

		// Token: 0x0600C926 RID: 51494 RVA: 0x001DB7A4 File Offset: 0x001D99A4
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

		// Token: 0x0600C927 RID: 51495 RVA: 0x001DB7E2 File Offset: 0x001D99E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMatchTeamResponse other)
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

		// Token: 0x0600C928 RID: 51496 RVA: 0x001DB813 File Offset: 0x001D9A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C929 RID: 51497 RVA: 0x001DB81C File Offset: 0x001D9A1C
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

		// Token: 0x0400561F RID: 22047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005620 RID: 22048
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005621 RID: 22049
		private ErrorCode errorCode_;
	}
}
