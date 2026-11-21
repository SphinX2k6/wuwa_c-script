using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A4 RID: 420
	[NetMessage(EMessageId.BirthdayShowSetResponse)]
	public sealed class BirthdayShowSetResponse : IMessage<BirthdayShowSetResponse>, IMessage, IEquatable<BirthdayShowSetResponse>, IDeepCloneable<BirthdayShowSetResponse>, IBufferMessage
	{
		// Token: 0x06003184 RID: 12676 RVA: 0x0007E0BD File Offset: 0x0007C2BD
		[NullableContext(1)]
		public static BirthdayShowSetResponse Create()
		{
			return new BirthdayShowSetResponse();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x0007E0C7 File Offset: 0x0007C2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayShowSetResponse.Descriptor;
			}
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0007E0CE File Offset: 0x0007C2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse()
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x0007E0D6 File Offset: 0x0007C2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse(BirthdayShowSetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x0007E0FB File Offset: 0x0007C2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse Clone()
		{
			return new BirthdayShowSetResponse(this);
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x0007E103 File Offset: 0x0007C303
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x0007E10B File Offset: 0x0007C30B
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

		// Token: 0x0600318C RID: 12684 RVA: 0x0007E114 File Offset: 0x0007C314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayShowSetResponse);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0007E122 File Offset: 0x0007C322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayShowSetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0007E150 File Offset: 0x0007C350
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

		// Token: 0x0600318F RID: 12687 RVA: 0x0007E195 File Offset: 0x0007C395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0007E1A2 File Offset: 0x0007C3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0007E1AB File Offset: 0x0007C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0007E1DC File Offset: 0x0007C3DC
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

		// Token: 0x06003193 RID: 12691 RVA: 0x0007E21A File Offset: 0x0007C41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayShowSetResponse other)
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

		// Token: 0x06003194 RID: 12692 RVA: 0x0007E24B File Offset: 0x0007C44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x0007E254 File Offset: 0x0007C454
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400298A RID: 10634
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400298B RID: 10635
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400298C RID: 10636
		private ErrorCode errorCode_;
	}
}
