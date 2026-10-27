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
		// Token: 0x06001003 RID: 4099 RVA: 0x0002CEF5 File Offset: 0x0002B0F5
		[NullableContext(1)]
		public static AbyssChallengeGotoNextRoomResponse Create()
		{
			return new AbyssChallengeGotoNextRoomResponse();
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0002CEFC File Offset: 0x0002B0FC
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
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0002CEFF File Offset: 0x0002B0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0002CF06 File Offset: 0x0002B106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0002CF0E File Offset: 0x0002B10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse(AbyssChallengeGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0002CF33 File Offset: 0x0002B133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeGotoNextRoomResponse Clone()
		{
			return new AbyssChallengeGotoNextRoomResponse(this);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0002CF3B File Offset: 0x0002B13B
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0002CF43 File Offset: 0x0002B143
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

		// Token: 0x0600100B RID: 4107 RVA: 0x0002CF4C File Offset: 0x0002B14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeGotoNextRoomResponse);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002CF5A File Offset: 0x0002B15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002CF88 File Offset: 0x0002B188
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

		// Token: 0x0600100E RID: 4110 RVA: 0x0002CFCD File Offset: 0x0002B1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002CFDA File Offset: 0x0002B1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0002CFE3 File Offset: 0x0002B1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0002D014 File Offset: 0x0002B214
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

		// Token: 0x06001012 RID: 4114 RVA: 0x0002D052 File Offset: 0x0002B252
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

		// Token: 0x06001013 RID: 4115 RVA: 0x0002D083 File Offset: 0x0002B283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0002D08C File Offset: 0x0002B28C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001EE9 RID: 7913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EEA RID: 7914
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04001EEB RID: 7915
		private ErrorCode errorCode_;
	}
}
