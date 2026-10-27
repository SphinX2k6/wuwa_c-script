using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3C RID: 3388
	[NetMessage(EMessageId.PickUpDropItemResponse)]
	public sealed class PickUpDropItemResponse : IMessage<PickUpDropItemResponse>, IMessage, IEquatable<PickUpDropItemResponse>, IDeepCloneable<PickUpDropItemResponse>, IBufferMessage
	{
		// Token: 0x0601248D RID: 74893 RVA: 0x002AB32E File Offset: 0x002A952E
		[NullableContext(1)]
		public static PickUpDropItemResponse Create()
		{
			return new PickUpDropItemResponse();
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0601248E RID: 74894 RVA: 0x002AB335 File Offset: 0x002A9535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0601248F RID: 74895 RVA: 0x002AB338 File Offset: 0x002A9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickUpDropItemResponse.Descriptor;
			}
		}

		// Token: 0x06012490 RID: 74896 RVA: 0x002AB33F File Offset: 0x002A953F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse()
		{
		}

		// Token: 0x06012491 RID: 74897 RVA: 0x002AB347 File Offset: 0x002A9547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse(PickUpDropItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012492 RID: 74898 RVA: 0x002AB36C File Offset: 0x002A956C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickUpDropItemResponse Clone()
		{
			return new PickUpDropItemResponse(this);
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x06012493 RID: 74899 RVA: 0x002AB374 File Offset: 0x002A9574
		// (set) Token: 0x06012494 RID: 74900 RVA: 0x002AB37C File Offset: 0x002A957C
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

		// Token: 0x06012495 RID: 74901 RVA: 0x002AB385 File Offset: 0x002A9585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickUpDropItemResponse);
		}

		// Token: 0x06012496 RID: 74902 RVA: 0x002AB393 File Offset: 0x002A9593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickUpDropItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012497 RID: 74903 RVA: 0x002AB3C4 File Offset: 0x002A95C4
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

		// Token: 0x06012498 RID: 74904 RVA: 0x002AB409 File Offset: 0x002A9609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012499 RID: 74905 RVA: 0x002AB416 File Offset: 0x002A9616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601249A RID: 74906 RVA: 0x002AB41F File Offset: 0x002A961F
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

		// Token: 0x0601249B RID: 74907 RVA: 0x002AB454 File Offset: 0x002A9654
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

		// Token: 0x0601249C RID: 74908 RVA: 0x002AB492 File Offset: 0x002A9692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PickUpDropItemResponse other)
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

		// Token: 0x0601249D RID: 74909 RVA: 0x002AB4C3 File Offset: 0x002A96C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601249E RID: 74910 RVA: 0x002AB4CC File Offset: 0x002A96CC
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

		// Token: 0x04007205 RID: 29189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007206 RID: 29190
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007207 RID: 29191
		private ErrorCode errorCode_;
	}
}
