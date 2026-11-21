using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C1 RID: 1985
	[NetMessage(EMessageId.InfrArchiveReadResponse)]
	public sealed class InfrArchiveReadResponse : IMessage<InfrArchiveReadResponse>, IMessage, IEquatable<InfrArchiveReadResponse>, IDeepCloneable<InfrArchiveReadResponse>, IBufferMessage
	{
		// Token: 0x0600B2D6 RID: 45782 RVA: 0x001AC4B1 File Offset: 0x001AA6B1
		[NullableContext(1)]
		public static InfrArchiveReadResponse Create()
		{
			return new InfrArchiveReadResponse();
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600B2D7 RID: 45783 RVA: 0x001AC4B8 File Offset: 0x001AA6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x001AC4BB File Offset: 0x001AA6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveReadResponse.Descriptor;
			}
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x001AC4C2 File Offset: 0x001AA6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse()
		{
		}

		// Token: 0x0600B2DA RID: 45786 RVA: 0x001AC4CA File Offset: 0x001AA6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse(InfrArchiveReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x001AC4EF File Offset: 0x001AA6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse Clone()
		{
			return new InfrArchiveReadResponse(this);
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x001AC4F7 File Offset: 0x001AA6F7
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x001AC4FF File Offset: 0x001AA6FF
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

		// Token: 0x0600B2DE RID: 45790 RVA: 0x001AC508 File Offset: 0x001AA708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveReadResponse);
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x001AC516 File Offset: 0x001AA716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x001AC544 File Offset: 0x001AA744
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

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x001AC589 File Offset: 0x001AA789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x001AC596 File Offset: 0x001AA796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x001AC59F File Offset: 0x001AA79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x001AC5D4 File Offset: 0x001AA7D4
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

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x001AC612 File Offset: 0x001AA812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveReadResponse other)
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

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x001AC643 File Offset: 0x001AA843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x001AC64C File Offset: 0x001AA84C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005037 RID: 20535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005038 RID: 20536
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005039 RID: 20537
		private ErrorCode errorCode_;
	}
}
