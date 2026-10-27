using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B15 RID: 2837
	[NetMessage(EMessageId.NewHandInItemResponse)]
	public sealed class NewHandInItemResponse : IMessage<NewHandInItemResponse>, IMessage, IEquatable<NewHandInItemResponse>, IDeepCloneable<NewHandInItemResponse>, IBufferMessage
	{
		// Token: 0x0600F660 RID: 63072 RVA: 0x0023EEB6 File Offset: 0x0023D0B6
		[NullableContext(1)]
		public static NewHandInItemResponse Create()
		{
			return new NewHandInItemResponse();
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600F661 RID: 63073 RVA: 0x0023EEBD File Offset: 0x0023D0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600F662 RID: 63074 RVA: 0x0023EEC0 File Offset: 0x0023D0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemResponse.Descriptor;
			}
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x0023EEC7 File Offset: 0x0023D0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse()
		{
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x0023EECF File Offset: 0x0023D0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse(NewHandInItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F665 RID: 63077 RVA: 0x0023EEF4 File Offset: 0x0023D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemResponse Clone()
		{
			return new NewHandInItemResponse(this);
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600F666 RID: 63078 RVA: 0x0023EEFC File Offset: 0x0023D0FC
		// (set) Token: 0x0600F667 RID: 63079 RVA: 0x0023EF04 File Offset: 0x0023D104
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

		// Token: 0x0600F668 RID: 63080 RVA: 0x0023EF0D File Offset: 0x0023D10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemResponse);
		}

		// Token: 0x0600F669 RID: 63081 RVA: 0x0023EF1B File Offset: 0x0023D11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F66A RID: 63082 RVA: 0x0023EF4C File Offset: 0x0023D14C
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

		// Token: 0x0600F66B RID: 63083 RVA: 0x0023EF91 File Offset: 0x0023D191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F66C RID: 63084 RVA: 0x0023EF9E File Offset: 0x0023D19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F66D RID: 63085 RVA: 0x0023EFA7 File Offset: 0x0023D1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F66E RID: 63086 RVA: 0x0023EFDC File Offset: 0x0023D1DC
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

		// Token: 0x0600F66F RID: 63087 RVA: 0x0023F01A File Offset: 0x0023D21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewHandInItemResponse other)
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

		// Token: 0x0600F670 RID: 63088 RVA: 0x0023F04B File Offset: 0x0023D24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F671 RID: 63089 RVA: 0x0023F054 File Offset: 0x0023D254
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062F4 RID: 25332
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062F5 RID: 25333
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040062F6 RID: 25334
		private ErrorCode errorCode_;
	}
}
