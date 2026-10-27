using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112F RID: 4399
	[NetMessage(EMessageId.RoverRogueTalentUnlockResponse)]
	public sealed class RoverRogueTalentUnlockResponse : IMessage<RoverRogueTalentUnlockResponse>, IMessage, IEquatable<RoverRogueTalentUnlockResponse>, IDeepCloneable<RoverRogueTalentUnlockResponse>, IBufferMessage
	{
		// Token: 0x06017776 RID: 96118 RVA: 0x00368B10 File Offset: 0x00366D10
		[NullableContext(1)]
		public static RoverRogueTalentUnlockResponse Create()
		{
			return new RoverRogueTalentUnlockResponse();
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x06017777 RID: 96119 RVA: 0x00368B17 File Offset: 0x00366D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x06017778 RID: 96120 RVA: 0x00368B1A File Offset: 0x00366D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06017779 RID: 96121 RVA: 0x00368B21 File Offset: 0x00366D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse()
		{
		}

		// Token: 0x0601777A RID: 96122 RVA: 0x00368B29 File Offset: 0x00366D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse(RoverRogueTalentUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x00368B4E File Offset: 0x00366D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse Clone()
		{
			return new RoverRogueTalentUnlockResponse(this);
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x0601777C RID: 96124 RVA: 0x00368B56 File Offset: 0x00366D56
		// (set) Token: 0x0601777D RID: 96125 RVA: 0x00368B5E File Offset: 0x00366D5E
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

		// Token: 0x0601777E RID: 96126 RVA: 0x00368B67 File Offset: 0x00366D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockResponse);
		}

		// Token: 0x0601777F RID: 96127 RVA: 0x00368B75 File Offset: 0x00366D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017780 RID: 96128 RVA: 0x00368BA4 File Offset: 0x00366DA4
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

		// Token: 0x06017781 RID: 96129 RVA: 0x00368BE9 File Offset: 0x00366DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017782 RID: 96130 RVA: 0x00368BF6 File Offset: 0x00366DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017783 RID: 96131 RVA: 0x00368BFF File Offset: 0x00366DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017784 RID: 96132 RVA: 0x00368C34 File Offset: 0x00366E34
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

		// Token: 0x06017785 RID: 96133 RVA: 0x00368C72 File Offset: 0x00366E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentUnlockResponse other)
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

		// Token: 0x06017786 RID: 96134 RVA: 0x00368CA3 File Offset: 0x00366EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017787 RID: 96135 RVA: 0x00368CAC File Offset: 0x00366EAC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008B8C RID: 35724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B8D RID: 35725
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008B8E RID: 35726
		private ErrorCode errorCode_;
	}
}
