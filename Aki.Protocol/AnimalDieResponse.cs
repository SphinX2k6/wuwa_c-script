using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E6 RID: 230
	[NetMessage(EMessageId.AnimalDieResponse)]
	public sealed class AnimalDieResponse : IMessage<AnimalDieResponse>, IMessage, IEquatable<AnimalDieResponse>, IDeepCloneable<AnimalDieResponse>, IBufferMessage
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x0005AB73 File Offset: 0x00058D73
		[NullableContext(1)]
		public static AnimalDieResponse Create()
		{
			return new AnimalDieResponse();
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0005AB7A File Offset: 0x00058D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0005AB7D File Offset: 0x00058D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieResponse.Descriptor;
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0005AB84 File Offset: 0x00058D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse()
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0005AB8C File Offset: 0x00058D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse(AnimalDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0005ABB1 File Offset: 0x00058DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse Clone()
		{
			return new AnimalDieResponse(this);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0005ABB9 File Offset: 0x00058DB9
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x0005ABC1 File Offset: 0x00058DC1
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

		// Token: 0x060021EF RID: 8687 RVA: 0x0005ABCA File Offset: 0x00058DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieResponse);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0005ABD8 File Offset: 0x00058DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0005AC08 File Offset: 0x00058E08
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

		// Token: 0x060021F2 RID: 8690 RVA: 0x0005AC4D File Offset: 0x00058E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0005AC5A File Offset: 0x00058E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0005AC63 File Offset: 0x00058E63
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

		// Token: 0x060021F5 RID: 8693 RVA: 0x0005AC98 File Offset: 0x00058E98
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

		// Token: 0x060021F6 RID: 8694 RVA: 0x0005ACD6 File Offset: 0x00058ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieResponse other)
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

		// Token: 0x060021F7 RID: 8695 RVA: 0x0005AD07 File Offset: 0x00058F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0005AD10 File Offset: 0x00058F10
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

		// Token: 0x040024AA RID: 9386
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024AB RID: 9387
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040024AC RID: 9388
		private ErrorCode errorCode_;
	}
}
