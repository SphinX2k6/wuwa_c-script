using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F7 RID: 4599
	[NetMessage(EMessageId.SelectBabelActivityDeTermResponse)]
	public sealed class SelectBabelActivityDeTermResponse : IMessage<SelectBabelActivityDeTermResponse>, IMessage, IEquatable<SelectBabelActivityDeTermResponse>, IDeepCloneable<SelectBabelActivityDeTermResponse>, IBufferMessage
	{
		// Token: 0x06018955 RID: 100693 RVA: 0x00396440 File Offset: 0x00394640
		[NullableContext(1)]
		public static SelectBabelActivityDeTermResponse Create()
		{
			return new SelectBabelActivityDeTermResponse();
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x06018956 RID: 100694 RVA: 0x00396447 File Offset: 0x00394647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x06018957 RID: 100695 RVA: 0x0039644A File Offset: 0x0039464A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectBabelActivityDeTermResponse.Descriptor;
			}
		}

		// Token: 0x06018958 RID: 100696 RVA: 0x00396451 File Offset: 0x00394651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse()
		{
		}

		// Token: 0x06018959 RID: 100697 RVA: 0x00396459 File Offset: 0x00394659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse(SelectBabelActivityDeTermResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601895A RID: 100698 RVA: 0x0039647E File Offset: 0x0039467E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermResponse Clone()
		{
			return new SelectBabelActivityDeTermResponse(this);
		}

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x0601895B RID: 100699 RVA: 0x00396486 File Offset: 0x00394686
		// (set) Token: 0x0601895C RID: 100700 RVA: 0x0039648E File Offset: 0x0039468E
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

		// Token: 0x0601895D RID: 100701 RVA: 0x00396497 File Offset: 0x00394697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectBabelActivityDeTermResponse);
		}

		// Token: 0x0601895E RID: 100702 RVA: 0x003964A5 File Offset: 0x003946A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectBabelActivityDeTermResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601895F RID: 100703 RVA: 0x003964D4 File Offset: 0x003946D4
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

		// Token: 0x06018960 RID: 100704 RVA: 0x00396519 File Offset: 0x00394719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018961 RID: 100705 RVA: 0x00396526 File Offset: 0x00394726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018962 RID: 100706 RVA: 0x0039652F File Offset: 0x0039472F
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

		// Token: 0x06018963 RID: 100707 RVA: 0x00396564 File Offset: 0x00394764
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

		// Token: 0x06018964 RID: 100708 RVA: 0x003965A2 File Offset: 0x003947A2
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

		// Token: 0x06018965 RID: 100709 RVA: 0x003965D3 File Offset: 0x003947D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018966 RID: 100710 RVA: 0x003965DC File Offset: 0x003947DC
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

		// Token: 0x04009244 RID: 37444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009245 RID: 37445
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009246 RID: 37446
		private ErrorCode errorCode_;
	}
}
