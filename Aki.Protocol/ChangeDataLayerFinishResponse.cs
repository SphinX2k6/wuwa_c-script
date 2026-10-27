using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000249 RID: 585
	[NetMessage(EMessageId.ChangeDataLayerFinishResponse)]
	public sealed class ChangeDataLayerFinishResponse : IMessage<ChangeDataLayerFinishResponse>, IMessage, IEquatable<ChangeDataLayerFinishResponse>, IDeepCloneable<ChangeDataLayerFinishResponse>, IBufferMessage
	{
		// Token: 0x06003E95 RID: 16021 RVA: 0x0009A639 File Offset: 0x00098839
		[NullableContext(1)]
		public static ChangeDataLayerFinishResponse Create()
		{
			return new ChangeDataLayerFinishResponse();
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06003E96 RID: 16022 RVA: 0x0009A640 File Offset: 0x00098840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x0009A643 File Offset: 0x00098843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeDataLayerFinishResponse.Descriptor;
			}
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x0009A64A File Offset: 0x0009884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse()
		{
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x0009A652 File Offset: 0x00098852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse(ChangeDataLayerFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x0009A677 File Offset: 0x00098877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishResponse Clone()
		{
			return new ChangeDataLayerFinishResponse(this);
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x0009A67F File Offset: 0x0009887F
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x0009A687 File Offset: 0x00098887
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

		// Token: 0x06003E9D RID: 16029 RVA: 0x0009A690 File Offset: 0x00098890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeDataLayerFinishResponse);
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x0009A69E File Offset: 0x0009889E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeDataLayerFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x0009A6CC File Offset: 0x000988CC
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

		// Token: 0x06003EA0 RID: 16032 RVA: 0x0009A711 File Offset: 0x00098911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0009A71E File Offset: 0x0009891E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x0009A727 File Offset: 0x00098927
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

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0009A75C File Offset: 0x0009895C
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

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0009A79A File Offset: 0x0009899A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeDataLayerFinishResponse other)
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

		// Token: 0x06003EA5 RID: 16037 RVA: 0x0009A7CB File Offset: 0x000989CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x0009A7D4 File Offset: 0x000989D4
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

		// Token: 0x04002CEB RID: 11499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CEC RID: 11500
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002CED RID: 11501
		private ErrorCode errorCode_;
	}
}
