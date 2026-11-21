using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A7 RID: 935
	[NetMessage(EMessageId.DeconstructTrapResponse)]
	public sealed class DeconstructTrapResponse : IMessage<DeconstructTrapResponse>, IMessage, IEquatable<DeconstructTrapResponse>, IDeepCloneable<DeconstructTrapResponse>, IBufferMessage
	{
		// Token: 0x06005C39 RID: 23609 RVA: 0x000E050D File Offset: 0x000DE70D
		[NullableContext(1)]
		public static DeconstructTrapResponse Create()
		{
			return new DeconstructTrapResponse();
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x000E0514 File Offset: 0x000DE714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x000E0517 File Offset: 0x000DE717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeconstructTrapResponse.Descriptor;
			}
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x000E051E File Offset: 0x000DE71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse()
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x000E0526 File Offset: 0x000DE726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse(DeconstructTrapResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x000E054B File Offset: 0x000DE74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapResponse Clone()
		{
			return new DeconstructTrapResponse(this);
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x000E0553 File Offset: 0x000DE753
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x000E055B File Offset: 0x000DE75B
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

		// Token: 0x06005C41 RID: 23617 RVA: 0x000E0564 File Offset: 0x000DE764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeconstructTrapResponse);
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x000E0572 File Offset: 0x000DE772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeconstructTrapResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x000E05A0 File Offset: 0x000DE7A0
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

		// Token: 0x06005C44 RID: 23620 RVA: 0x000E05E5 File Offset: 0x000DE7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x000E05F2 File Offset: 0x000DE7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x000E05FB File Offset: 0x000DE7FB
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

		// Token: 0x06005C47 RID: 23623 RVA: 0x000E0630 File Offset: 0x000DE830
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

		// Token: 0x06005C48 RID: 23624 RVA: 0x000E066E File Offset: 0x000DE86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeconstructTrapResponse other)
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

		// Token: 0x06005C49 RID: 23625 RVA: 0x000E069F File Offset: 0x000DE89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x000E06A8 File Offset: 0x000DE8A8
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

		// Token: 0x04003690 RID: 13968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003691 RID: 13969
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003692 RID: 13970
		private ErrorCode errorCode_;
	}
}
