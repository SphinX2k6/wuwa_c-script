using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C1 RID: 449
	[NetMessage(EMessageId.BoneVisibleChangeResponse)]
	public sealed class BoneVisibleChangeResponse : IMessage<BoneVisibleChangeResponse>, IMessage, IEquatable<BoneVisibleChangeResponse>, IDeepCloneable<BoneVisibleChangeResponse>, IBufferMessage
	{
		// Token: 0x060033E9 RID: 13289 RVA: 0x000837AC File Offset: 0x000819AC
		[NullableContext(1)]
		public static BoneVisibleChangeResponse Create()
		{
			return new BoneVisibleChangeResponse();
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x000837B3 File Offset: 0x000819B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x000837B6 File Offset: 0x000819B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeResponse.Descriptor;
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000837BD File Offset: 0x000819BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse()
		{
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000837C5 File Offset: 0x000819C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse(BoneVisibleChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000837EA File Offset: 0x000819EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeResponse Clone()
		{
			return new BoneVisibleChangeResponse(this);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x000837F2 File Offset: 0x000819F2
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x000837FA File Offset: 0x000819FA
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

		// Token: 0x060033F1 RID: 13297 RVA: 0x00083803 File Offset: 0x00081A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeResponse);
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00083811 File Offset: 0x00081A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00083840 File Offset: 0x00081A40
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

		// Token: 0x060033F4 RID: 13300 RVA: 0x00083885 File Offset: 0x00081A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00083892 File Offset: 0x00081A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x0008389B File Offset: 0x00081A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000838D0 File Offset: 0x00081AD0
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

		// Token: 0x060033F8 RID: 13304 RVA: 0x0008390E File Offset: 0x00081B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeResponse other)
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

		// Token: 0x060033F9 RID: 13305 RVA: 0x0008393F File Offset: 0x00081B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00083948 File Offset: 0x00081B48
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A30 RID: 10800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A31 RID: 10801
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002A32 RID: 10802
		private ErrorCode errorCode_;
	}
}
