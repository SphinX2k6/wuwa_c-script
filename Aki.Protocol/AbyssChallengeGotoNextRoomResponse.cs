using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000015 RID: 21
	[NetMessage(EMessageId.AbyssChallengeGotoNextRoomResponse)]
	public sealed class AbyssChallengeGotoNextRoomResponse : IMessage<AbyssChallengeGotoNextRoomResponse>, IMessage, IEquatable<AbyssChallengeGotoNextRoomResponse>, IDeepCloneable<AbyssChallengeGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x0002D4A5 File Offset: 0x0002B6A5
		[NullableContext(1)]
		public static AbyssChallengeGotoNextRoomResponse Create()
		{
			return new AbyssChallengeGotoNextRoomResponse();
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0002D4AF File Offset: 0x0002B6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0002D4B6 File Offset: 0x0002B6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse()
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0002D4BE File Offset: 0x0002B6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse(AbyssChallengeGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0002D4E3 File Offset: 0x0002B6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse Clone()
		{
			return new AbyssChallengeGotoNextRoomResponse(this);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0002D4EB File Offset: 0x0002B6EB
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0002D4F3 File Offset: 0x0002B6F3
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

		// Token: 0x06001036 RID: 4150 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeGotoNextRoomResponse);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0002D50A File Offset: 0x0002B70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002D538 File Offset: 0x0002B738
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

		// Token: 0x06001039 RID: 4153 RVA: 0x0002D57D File Offset: 0x0002B77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0002D58A File Offset: 0x0002B78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0002D593 File Offset: 0x0002B793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
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

		// Token: 0x0600103D RID: 4157 RVA: 0x0002D606 File Offset: 0x0002B806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeGotoNextRoomResponse other)
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

		// Token: 0x0600103E RID: 4158 RVA: 0x0002D637 File Offset: 0x0002B837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0002D640 File Offset: 0x0002B840
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001F3F RID: 7999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F40 RID: 8000
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04001F41 RID: 8001
		private ErrorCode errorCode_;
	}
}
