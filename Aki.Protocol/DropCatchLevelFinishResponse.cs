using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040A RID: 1034
	[NetMessage(EMessageId.DropCatchLevelFinishResponse)]
	public sealed class DropCatchLevelFinishResponse : IMessage<DropCatchLevelFinishResponse>, IMessage, IEquatable<DropCatchLevelFinishResponse>, IDeepCloneable<DropCatchLevelFinishResponse>, IBufferMessage
	{
		// Token: 0x060063B1 RID: 25521 RVA: 0x000EFA93 File Offset: 0x000EDC93
		[NullableContext(1)]
		public static DropCatchLevelFinishResponse Create()
		{
			return new DropCatchLevelFinishResponse();
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x060063B2 RID: 25522 RVA: 0x000EFA9A File Offset: 0x000EDC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x000EFA9D File Offset: 0x000EDC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelFinishResponse.Descriptor;
			}
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x000EFAA4 File Offset: 0x000EDCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse()
		{
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x000EFAAC File Offset: 0x000EDCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse(DropCatchLevelFinishResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x000EFAD1 File Offset: 0x000EDCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelFinishResponse Clone()
		{
			return new DropCatchLevelFinishResponse(this);
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060063B7 RID: 25527 RVA: 0x000EFAD9 File Offset: 0x000EDCD9
		// (set) Token: 0x060063B8 RID: 25528 RVA: 0x000EFAE1 File Offset: 0x000EDCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x000EFAEA File Offset: 0x000EDCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelFinishResponse);
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x000EFAF8 File Offset: 0x000EDCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelFinishResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x000EFB28 File Offset: 0x000EDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x000EFB6D File Offset: 0x000EDD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x000EFB7A File Offset: 0x000EDD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x000EFB83 File Offset: 0x000EDD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x000EFBB8 File Offset: 0x000EDDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x000EFBF6 File Offset: 0x000EDDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x000EFC27 File Offset: 0x000EDE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x000EFC30 File Offset: 0x000EDE30
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003833 RID: 14387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003834 RID: 14388
		public const int ErrorFieldNumber = 15;

		// Token: 0x04003835 RID: 14389
		private ErrorCode error_;
	}
}
