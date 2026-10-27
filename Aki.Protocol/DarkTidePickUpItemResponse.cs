using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B0 RID: 944
	[NetMessage(EMessageId.DarkTidePickUpItemResponse)]
	public sealed class DarkTidePickUpItemResponse : IMessage<DarkTidePickUpItemResponse>, IMessage, IEquatable<DarkTidePickUpItemResponse>, IDeepCloneable<DarkTidePickUpItemResponse>, IBufferMessage
	{
		// Token: 0x06005CB6 RID: 23734 RVA: 0x000E1380 File Offset: 0x000DF580
		[NullableContext(1)]
		public static DarkTidePickUpItemResponse Create()
		{
			return new DarkTidePickUpItemResponse();
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x000E1387 File Offset: 0x000DF587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06005CB8 RID: 23736 RVA: 0x000E138A File Offset: 0x000DF58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePickUpItemResponse.Descriptor;
			}
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x000E1391 File Offset: 0x000DF591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemResponse()
		{
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x000E1399 File Offset: 0x000DF599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemResponse(DarkTidePickUpItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x000E13BE File Offset: 0x000DF5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePickUpItemResponse Clone()
		{
			return new DarkTidePickUpItemResponse(this);
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06005CBC RID: 23740 RVA: 0x000E13C6 File Offset: 0x000DF5C6
		// (set) Token: 0x06005CBD RID: 23741 RVA: 0x000E13CE File Offset: 0x000DF5CE
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

		// Token: 0x06005CBE RID: 23742 RVA: 0x000E13D7 File Offset: 0x000DF5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePickUpItemResponse);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x000E13E5 File Offset: 0x000DF5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePickUpItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x000E1414 File Offset: 0x000DF614
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

		// Token: 0x06005CC1 RID: 23745 RVA: 0x000E1459 File Offset: 0x000DF659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x000E1466 File Offset: 0x000DF666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x000E146F File Offset: 0x000DF66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x000E14A4 File Offset: 0x000DF6A4
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

		// Token: 0x06005CC5 RID: 23749 RVA: 0x000E14E2 File Offset: 0x000DF6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePickUpItemResponse other)
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

		// Token: 0x06005CC6 RID: 23750 RVA: 0x000E1513 File Offset: 0x000DF713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x000E151C File Offset: 0x000DF71C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400365E RID: 13918
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400365F RID: 13919
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003660 RID: 13920
		private ErrorCode errorCode_;
	}
}
