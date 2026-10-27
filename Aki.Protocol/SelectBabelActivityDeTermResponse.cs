using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BD RID: 4541
	[NetMessage(EMessageId.SelectBabelActivityDeTermResponse)]
	public sealed class SelectBabelActivityDeTermResponse : IMessage<SelectBabelActivityDeTermResponse>, IMessage, IEquatable<SelectBabelActivityDeTermResponse>, IDeepCloneable<SelectBabelActivityDeTermResponse>, IBufferMessage
	{
		// Token: 0x060183B4 RID: 99252 RVA: 0x00387110 File Offset: 0x00385310
		[NullableContext(1)]
		public static SelectBabelActivityDeTermResponse Create()
		{
			return new SelectBabelActivityDeTermResponse();
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x060183B5 RID: 99253 RVA: 0x00387117 File Offset: 0x00385317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x060183B6 RID: 99254 RVA: 0x0038711A File Offset: 0x0038531A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectBabelActivityDeTermResponse.Descriptor;
			}
		}

		// Token: 0x060183B7 RID: 99255 RVA: 0x00387121 File Offset: 0x00385321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse()
		{
		}

		// Token: 0x060183B8 RID: 99256 RVA: 0x00387129 File Offset: 0x00385329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse(SelectBabelActivityDeTermResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183B9 RID: 99257 RVA: 0x0038714E File Offset: 0x0038534E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse Clone()
		{
			return new SelectBabelActivityDeTermResponse(this);
		}

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x060183BA RID: 99258 RVA: 0x00387156 File Offset: 0x00385356
		// (set) Token: 0x060183BB RID: 99259 RVA: 0x0038715E File Offset: 0x0038535E
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

		// Token: 0x060183BC RID: 99260 RVA: 0x00387167 File Offset: 0x00385367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectBabelActivityDeTermResponse);
		}

		// Token: 0x060183BD RID: 99261 RVA: 0x00387175 File Offset: 0x00385375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectBabelActivityDeTermResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183BE RID: 99262 RVA: 0x003871A4 File Offset: 0x003853A4
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

		// Token: 0x060183BF RID: 99263 RVA: 0x003871E9 File Offset: 0x003853E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183C0 RID: 99264 RVA: 0x003871F6 File Offset: 0x003853F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183C1 RID: 99265 RVA: 0x003871FF File Offset: 0x003853FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183C2 RID: 99266 RVA: 0x00387234 File Offset: 0x00385434
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

		// Token: 0x060183C3 RID: 99267 RVA: 0x00387272 File Offset: 0x00385472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectBabelActivityDeTermResponse other)
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

		// Token: 0x060183C4 RID: 99268 RVA: 0x003872A3 File Offset: 0x003854A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183C5 RID: 99269 RVA: 0x003872AC File Offset: 0x003854AC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FB1 RID: 36785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FB2 RID: 36786
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04008FB3 RID: 36787
		private ErrorCode errorCode_;
	}
}
