using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B3 RID: 179
	[NetMessage(EMessageId.AddTemporaryTeleportResponse)]
	public sealed class AddTemporaryTeleportResponse : IMessage<AddTemporaryTeleportResponse>, IMessage, IEquatable<AddTemporaryTeleportResponse>, IDeepCloneable<AddTemporaryTeleportResponse>, IBufferMessage
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x00052394 File Offset: 0x00050594
		[NullableContext(1)]
		public static AddTemporaryTeleportResponse Create()
		{
			return new AddTemporaryTeleportResponse();
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0005239B File Offset: 0x0005059B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0005239E File Offset: 0x0005059E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportResponse.Descriptor;
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000523A5 File Offset: 0x000505A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse()
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000523AD File Offset: 0x000505AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse(AddTemporaryTeleportResponse other) : this()
		{
			this.code_ = other.code_;
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000523DE File Offset: 0x000505DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportResponse Clone()
		{
			return new AddTemporaryTeleportResponse(this);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000523E6 File Offset: 0x000505E6
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x000523EE File Offset: 0x000505EE
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000523F7 File Offset: 0x000505F7
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x000523FF File Offset: 0x000505FF
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

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00052408 File Offset: 0x00050608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportResponse);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00052416 File Offset: 0x00050616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00052454 File Offset: 0x00050654
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

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000524B2 File Offset: 0x000506B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000524BF File Offset: 0x000506BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x000524C8 File Offset: 0x000506C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00052524 File Offset: 0x00050724
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

		// Token: 0x06001DFD RID: 7677 RVA: 0x0005257C File Offset: 0x0005077C
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

		// Token: 0x06001DFE RID: 7678 RVA: 0x000525CC File Offset: 0x000507CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000525D8 File Offset: 0x000507D8
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
				if (num != 88U)
				{
					if (num != 120U)
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

		// Token: 0x0400238C RID: 9100
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400238D RID: 9101
		public const int CodeFieldNumber = 15;

		// Token: 0x0400238E RID: 9102
		private ErrorCode code_;

		// Token: 0x0400238F RID: 9103
		public const int TemporaryTeleportIdFieldNumber = 11;

		// Token: 0x04002390 RID: 9104
		private long temporaryTeleportId_;
	}
}
