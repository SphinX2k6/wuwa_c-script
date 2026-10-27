using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000246 RID: 582
	[NetMessage(EMessageId.ChangeCardResponse)]
	public sealed class ChangeCardResponse : IMessage<ChangeCardResponse>, IMessage, IEquatable<ChangeCardResponse>, IDeepCloneable<ChangeCardResponse>, IBufferMessage
	{
		// Token: 0x06003E57 RID: 15959 RVA: 0x00099DB1 File Offset: 0x00097FB1
		[NullableContext(1)]
		public static ChangeCardResponse Create()
		{
			return new ChangeCardResponse();
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x00099DB8 File Offset: 0x00097FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x00099DBB File Offset: 0x00097FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeCardResponse.Descriptor;
			}
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00099DC2 File Offset: 0x00097FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse()
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x00099DCA File Offset: 0x00097FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse(ChangeCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00099DEF File Offset: 0x00097FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardResponse Clone()
		{
			return new ChangeCardResponse(this);
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x00099DF7 File Offset: 0x00097FF7
		// (set) Token: 0x06003E5E RID: 15966 RVA: 0x00099DFF File Offset: 0x00097FFF
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

		// Token: 0x06003E5F RID: 15967 RVA: 0x00099E08 File Offset: 0x00098008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeCardResponse);
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00099E16 File Offset: 0x00098016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00099E44 File Offset: 0x00098044
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

		// Token: 0x06003E62 RID: 15970 RVA: 0x00099E89 File Offset: 0x00098089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00099E96 File Offset: 0x00098096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00099E9F File Offset: 0x0009809F
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

		// Token: 0x06003E65 RID: 15973 RVA: 0x00099ED0 File Offset: 0x000980D0
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

		// Token: 0x06003E66 RID: 15974 RVA: 0x00099F0E File Offset: 0x0009810E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeCardResponse other)
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

		// Token: 0x06003E67 RID: 15975 RVA: 0x00099F3F File Offset: 0x0009813F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00099F48 File Offset: 0x00098148
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

		// Token: 0x04002CDA RID: 11482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CDB RID: 11483
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002CDC RID: 11484
		private ErrorCode errorCode_;
	}
}
