using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED8 RID: 3800
	[NetMessage(EMessageId.RegressTaskResponse)]
	public sealed class RegressTaskResponse : IMessage<RegressTaskResponse>, IMessage, IEquatable<RegressTaskResponse>, IDeepCloneable<RegressTaskResponse>, IBufferMessage
	{
		// Token: 0x06014653 RID: 83539 RVA: 0x002F7606 File Offset: 0x002F5806
		[NullableContext(1)]
		public static RegressTaskResponse Create()
		{
			return new RegressTaskResponse();
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x06014654 RID: 83540 RVA: 0x002F760D File Offset: 0x002F580D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x06014655 RID: 83541 RVA: 0x002F7610 File Offset: 0x002F5810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTaskResponse.Descriptor;
			}
		}

		// Token: 0x06014656 RID: 83542 RVA: 0x002F7617 File Offset: 0x002F5817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse()
		{
		}

		// Token: 0x06014657 RID: 83543 RVA: 0x002F761F File Offset: 0x002F581F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse(RegressTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014658 RID: 83544 RVA: 0x002F7644 File Offset: 0x002F5844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskResponse Clone()
		{
			return new RegressTaskResponse(this);
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x06014659 RID: 83545 RVA: 0x002F764C File Offset: 0x002F584C
		// (set) Token: 0x0601465A RID: 83546 RVA: 0x002F7654 File Offset: 0x002F5854
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

		// Token: 0x0601465B RID: 83547 RVA: 0x002F765D File Offset: 0x002F585D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTaskResponse);
		}

		// Token: 0x0601465C RID: 83548 RVA: 0x002F766B File Offset: 0x002F586B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601465D RID: 83549 RVA: 0x002F769C File Offset: 0x002F589C
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

		// Token: 0x0601465E RID: 83550 RVA: 0x002F76E1 File Offset: 0x002F58E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601465F RID: 83551 RVA: 0x002F76EE File Offset: 0x002F58EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014660 RID: 83552 RVA: 0x002F76F7 File Offset: 0x002F58F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014661 RID: 83553 RVA: 0x002F772C File Offset: 0x002F592C
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

		// Token: 0x06014662 RID: 83554 RVA: 0x002F776A File Offset: 0x002F596A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTaskResponse other)
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

		// Token: 0x06014663 RID: 83555 RVA: 0x002F779B File Offset: 0x002F599B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014664 RID: 83556 RVA: 0x002F77A4 File Offset: 0x002F59A4
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C41 RID: 31809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C42 RID: 31810
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007C43 RID: 31811
		private ErrorCode errorCode_;
	}
}
