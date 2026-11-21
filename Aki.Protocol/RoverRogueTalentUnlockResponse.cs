using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001169 RID: 4457
	[NetMessage(EMessageId.RoverRogueTalentUnlockResponse)]
	public sealed class RoverRogueTalentUnlockResponse : IMessage<RoverRogueTalentUnlockResponse>, IMessage, IEquatable<RoverRogueTalentUnlockResponse>, IDeepCloneable<RoverRogueTalentUnlockResponse>, IBufferMessage
	{
		// Token: 0x06017D17 RID: 97559 RVA: 0x00377E60 File Offset: 0x00376060
		[NullableContext(1)]
		public static RoverRogueTalentUnlockResponse Create()
		{
			return new RoverRogueTalentUnlockResponse();
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x06017D18 RID: 97560 RVA: 0x00377E67 File Offset: 0x00376067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x06017D19 RID: 97561 RVA: 0x00377E6A File Offset: 0x0037606A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06017D1A RID: 97562 RVA: 0x00377E71 File Offset: 0x00376071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse()
		{
		}

		// Token: 0x06017D1B RID: 97563 RVA: 0x00377E79 File Offset: 0x00376079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse(RoverRogueTalentUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D1C RID: 97564 RVA: 0x00377E9E File Offset: 0x0037609E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockResponse Clone()
		{
			return new RoverRogueTalentUnlockResponse(this);
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x06017D1D RID: 97565 RVA: 0x00377EA6 File Offset: 0x003760A6
		// (set) Token: 0x06017D1E RID: 97566 RVA: 0x00377EAE File Offset: 0x003760AE
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

		// Token: 0x06017D1F RID: 97567 RVA: 0x00377EB7 File Offset: 0x003760B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockResponse);
		}

		// Token: 0x06017D20 RID: 97568 RVA: 0x00377EC5 File Offset: 0x003760C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D21 RID: 97569 RVA: 0x00377EF4 File Offset: 0x003760F4
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

		// Token: 0x06017D22 RID: 97570 RVA: 0x00377F39 File Offset: 0x00376139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D23 RID: 97571 RVA: 0x00377F46 File Offset: 0x00376146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D24 RID: 97572 RVA: 0x00377F4F File Offset: 0x0037614F
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

		// Token: 0x06017D25 RID: 97573 RVA: 0x00377F84 File Offset: 0x00376184
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

		// Token: 0x06017D26 RID: 97574 RVA: 0x00377FC2 File Offset: 0x003761C2
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

		// Token: 0x06017D27 RID: 97575 RVA: 0x00377FF3 File Offset: 0x003761F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D28 RID: 97576 RVA: 0x00377FFC File Offset: 0x003761FC
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

		// Token: 0x04008E1F RID: 36383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E20 RID: 36384
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008E21 RID: 36385
		private ErrorCode errorCode_;
	}
}
