using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D0 RID: 208
	[NetMessage(EMessageId.AdviceSetResponse)]
	public sealed class AdviceSetResponse : IMessage<AdviceSetResponse>, IMessage, IEquatable<AdviceSetResponse>, IDeepCloneable<AdviceSetResponse>, IBufferMessage
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x0005699D File Offset: 0x00054B9D
		[NullableContext(1)]
		public static AdviceSetResponse Create()
		{
			return new AdviceSetResponse();
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000569A4 File Offset: 0x00054BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x000569A7 File Offset: 0x00054BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSetResponse.Descriptor;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000569AE File Offset: 0x00054BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000569B6 File Offset: 0x00054BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse(AdviceSetResponse other) : this()
		{
			this.isShow_ = other.isShow_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000569E7 File Offset: 0x00054BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetResponse Clone()
		{
			return new AdviceSetResponse(this);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x000569EF File Offset: 0x00054BEF
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x000569F7 File Offset: 0x00054BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00056A00 File Offset: 0x00054C00
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00056A08 File Offset: 0x00054C08
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

		// Token: 0x06002008 RID: 8200 RVA: 0x00056A11 File Offset: 0x00054C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSetResponse);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00056A1F File Offset: 0x00054C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSetResponse other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00056A60 File Offset: 0x00054C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
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

		// Token: 0x0600200B RID: 8203 RVA: 0x00056ABE File Offset: 0x00054CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00056ACB File Offset: 0x00054CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00056AD4 File Offset: 0x00054CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShow);
			}
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

		// Token: 0x0600200E RID: 8206 RVA: 0x00056B2C File Offset: 0x00054D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
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

		// Token: 0x0600200F RID: 8207 RVA: 0x00056B78 File Offset: 0x00054D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00056BC8 File Offset: 0x00054DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00056BD4 File Offset: 0x00054DD4
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x040023DC RID: 9180
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023DD RID: 9181
		public const int IsShowFieldNumber = 1;

		// Token: 0x040023DE RID: 9182
		private bool isShow_;

		// Token: 0x040023DF RID: 9183
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040023E0 RID: 9184
		private ErrorCode errorCode_;
	}
}
