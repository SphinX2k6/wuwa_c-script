using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B2 RID: 178
	[NetMessage(EMessageId.AddTemporaryTeleportResponse)]
	public sealed class AddTemporaryTeleportResponse : IMessage<AddTemporaryTeleportResponse>, IMessage, IEquatable<AddTemporaryTeleportResponse>, IDeepCloneable<AddTemporaryTeleportResponse>, IBufferMessage
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x000516E0 File Offset: 0x0004F8E0
		[NullableContext(1)]
		public static AddTemporaryTeleportResponse Create()
		{
			return new AddTemporaryTeleportResponse();
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000516E7 File Offset: 0x0004F8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000516EA File Offset: 0x0004F8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportResponse.Descriptor;
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000516F1 File Offset: 0x0004F8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse()
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000516F9 File Offset: 0x0004F8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse(AddTemporaryTeleportResponse other) : this()
		{
			this.code_ = other.code_;
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0005172A File Offset: 0x0004F92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse Clone()
		{
			return new AddTemporaryTeleportResponse(this);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00051732 File Offset: 0x0004F932
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0005173A File Offset: 0x0004F93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00051743 File Offset: 0x0004F943
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0005174B File Offset: 0x0004F94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00051754 File Offset: 0x0004F954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportResponse);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00051762 File Offset: 0x0004F962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000517A0 File Offset: 0x0004F9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000517FE File Offset: 0x0004F9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0005180B File Offset: 0x0004FA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00051814 File Offset: 0x0004FA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00051870 File Offset: 0x0004FA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000518C8 File Offset: 0x0004FAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTemporaryTeleportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00051918 File Offset: 0x0004FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00051924 File Offset: 0x0004FB24
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002329 RID: 9001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400232A RID: 9002
		public const int CodeFieldNumber = 7;

		// Token: 0x0400232B RID: 9003
		private ErrorCode code_;

		// Token: 0x0400232C RID: 9004
		public const int TemporaryTeleportIdFieldNumber = 6;

		// Token: 0x0400232D RID: 9005
		private long temporaryTeleportId_;
	}
}
