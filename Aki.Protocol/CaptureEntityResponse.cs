using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023D RID: 573
	[NetMessage(EMessageId.CaptureEntityResponse)]
	public sealed class CaptureEntityResponse : IMessage<CaptureEntityResponse>, IMessage, IEquatable<CaptureEntityResponse>, IDeepCloneable<CaptureEntityResponse>, IBufferMessage
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x000998C1 File Offset: 0x00097AC1
		[NullableContext(1)]
		public static CaptureEntityResponse Create()
		{
			return new CaptureEntityResponse();
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x000998C8 File Offset: 0x00097AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x000998CB File Offset: 0x00097ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureEntityResponse.Descriptor;
			}
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000998D2 File Offset: 0x00097AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse()
		{
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000998DA File Offset: 0x00097ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse(CaptureEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x0009990B File Offset: 0x00097B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureEntityResponse Clone()
		{
			return new CaptureEntityResponse(this);
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x00099913 File Offset: 0x00097B13
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x0009991B File Offset: 0x00097B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x00099924 File Offset: 0x00097B24
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x0009992C File Offset: 0x00097B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00099935 File Offset: 0x00097B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureEntityResponse);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00099943 File Offset: 0x00097B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00099984 File Offset: 0x00097B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000999E2 File Offset: 0x00097BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x000999EF File Offset: 0x00097BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x000999F8 File Offset: 0x00097BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00099A54 File Offset: 0x00097C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x00099AAC File Offset: 0x00097CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureEntityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00099AFC File Offset: 0x00097CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00099B08 File Offset: 0x00097D08
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D21 RID: 11553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D22 RID: 11554
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x04002D23 RID: 11555
		private ErrorCode errCode_;

		// Token: 0x04002D24 RID: 11556
		public const int IdFieldNumber = 13;

		// Token: 0x04002D25 RID: 11557
		private long id_;
	}
}
