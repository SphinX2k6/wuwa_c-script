using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8C RID: 3724
	[NetMessage(EMessageId.RealmBetweenFullRewardResponse)]
	public sealed class RealmBetweenFullRewardResponse : IMessage<RealmBetweenFullRewardResponse>, IMessage, IEquatable<RealmBetweenFullRewardResponse>, IDeepCloneable<RealmBetweenFullRewardResponse>, IBufferMessage
	{
		// Token: 0x06014056 RID: 82006 RVA: 0x002EAC8E File Offset: 0x002E8E8E
		[NullableContext(1)]
		public static RealmBetweenFullRewardResponse Create()
		{
			return new RealmBetweenFullRewardResponse();
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x06014057 RID: 82007 RVA: 0x002EAC95 File Offset: 0x002E8E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x06014058 RID: 82008 RVA: 0x002EAC98 File Offset: 0x002E8E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenFullRewardResponse.Descriptor;
			}
		}

		// Token: 0x06014059 RID: 82009 RVA: 0x002EAC9F File Offset: 0x002E8E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse()
		{
		}

		// Token: 0x0601405A RID: 82010 RVA: 0x002EACA7 File Offset: 0x002E8EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse(RealmBetweenFullRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601405B RID: 82011 RVA: 0x002EACCC File Offset: 0x002E8ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardResponse Clone()
		{
			return new RealmBetweenFullRewardResponse(this);
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x0601405C RID: 82012 RVA: 0x002EACD4 File Offset: 0x002E8ED4
		// (set) Token: 0x0601405D RID: 82013 RVA: 0x002EACDC File Offset: 0x002E8EDC
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

		// Token: 0x0601405E RID: 82014 RVA: 0x002EACE5 File Offset: 0x002E8EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenFullRewardResponse);
		}

		// Token: 0x0601405F RID: 82015 RVA: 0x002EACF3 File Offset: 0x002E8EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenFullRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014060 RID: 82016 RVA: 0x002EAD24 File Offset: 0x002E8F24
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

		// Token: 0x06014061 RID: 82017 RVA: 0x002EAD69 File Offset: 0x002E8F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014062 RID: 82018 RVA: 0x002EAD76 File Offset: 0x002E8F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014063 RID: 82019 RVA: 0x002EAD7F File Offset: 0x002E8F7F
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

		// Token: 0x06014064 RID: 82020 RVA: 0x002EADB4 File Offset: 0x002E8FB4
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

		// Token: 0x06014065 RID: 82021 RVA: 0x002EADF2 File Offset: 0x002E8FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenFullRewardResponse other)
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

		// Token: 0x06014066 RID: 82022 RVA: 0x002EAE23 File Offset: 0x002E9023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014067 RID: 82023 RVA: 0x002EAE2C File Offset: 0x002E902C
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

		// Token: 0x04007A9C RID: 31388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A9D RID: 31389
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007A9E RID: 31390
		private ErrorCode errorCode_;
	}
}
