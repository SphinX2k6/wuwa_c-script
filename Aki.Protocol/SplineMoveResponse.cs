using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126E RID: 4718
	[NetMessage(EMessageId.SplineMoveResponse)]
	public sealed class SplineMoveResponse : IMessage<SplineMoveResponse>, IMessage, IEquatable<SplineMoveResponse>, IDeepCloneable<SplineMoveResponse>, IBufferMessage
	{
		// Token: 0x0601921C RID: 102940 RVA: 0x003A7DCB File Offset: 0x003A5FCB
		[NullableContext(1)]
		public static SplineMoveResponse Create()
		{
			return new SplineMoveResponse();
		}

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x0601921D RID: 102941 RVA: 0x003A7DD2 File Offset: 0x003A5FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x0601921E RID: 102942 RVA: 0x003A7DD5 File Offset: 0x003A5FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveResponse.Descriptor;
			}
		}

		// Token: 0x0601921F RID: 102943 RVA: 0x003A7DDC File Offset: 0x003A5FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse()
		{
		}

		// Token: 0x06019220 RID: 102944 RVA: 0x003A7DE4 File Offset: 0x003A5FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse(SplineMoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019221 RID: 102945 RVA: 0x003A7E09 File Offset: 0x003A6009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveResponse Clone()
		{
			return new SplineMoveResponse(this);
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x06019222 RID: 102946 RVA: 0x003A7E11 File Offset: 0x003A6011
		// (set) Token: 0x06019223 RID: 102947 RVA: 0x003A7E19 File Offset: 0x003A6019
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

		// Token: 0x06019224 RID: 102948 RVA: 0x003A7E22 File Offset: 0x003A6022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveResponse);
		}

		// Token: 0x06019225 RID: 102949 RVA: 0x003A7E30 File Offset: 0x003A6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019226 RID: 102950 RVA: 0x003A7E60 File Offset: 0x003A6060
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

		// Token: 0x06019227 RID: 102951 RVA: 0x003A7EA5 File Offset: 0x003A60A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019228 RID: 102952 RVA: 0x003A7EB2 File Offset: 0x003A60B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019229 RID: 102953 RVA: 0x003A7EBB File Offset: 0x003A60BB
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

		// Token: 0x0601922A RID: 102954 RVA: 0x003A7EF0 File Offset: 0x003A60F0
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

		// Token: 0x0601922B RID: 102955 RVA: 0x003A7F2E File Offset: 0x003A612E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveResponse other)
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

		// Token: 0x0601922C RID: 102956 RVA: 0x003A7F5F File Offset: 0x003A615F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601922D RID: 102957 RVA: 0x003A7F68 File Offset: 0x003A6168
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

		// Token: 0x040093EE RID: 37870
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093EF RID: 37871
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040093F0 RID: 37872
		private ErrorCode errorCode_;
	}
}
