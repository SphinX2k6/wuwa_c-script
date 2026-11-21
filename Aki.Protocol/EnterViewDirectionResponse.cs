using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000446 RID: 1094
	[NetMessage(EMessageId.EnterViewDirectionResponse)]
	public sealed class EnterViewDirectionResponse : IMessage<EnterViewDirectionResponse>, IMessage, IEquatable<EnterViewDirectionResponse>, IDeepCloneable<EnterViewDirectionResponse>, IBufferMessage
	{
		// Token: 0x06006924 RID: 26916 RVA: 0x000FE622 File Offset: 0x000FC822
		[NullableContext(1)]
		public static EnterViewDirectionResponse Create()
		{
			return new EnterViewDirectionResponse();
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x000FE629 File Offset: 0x000FC829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x000FE62C File Offset: 0x000FC82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionResponse.Descriptor;
			}
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x000FE633 File Offset: 0x000FC833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse()
		{
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x000FE63B File Offset: 0x000FC83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse(EnterViewDirectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x000FE660 File Offset: 0x000FC860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse Clone()
		{
			return new EnterViewDirectionResponse(this);
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x000FE668 File Offset: 0x000FC868
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x000FE670 File Offset: 0x000FC870
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

		// Token: 0x0600692C RID: 26924 RVA: 0x000FE679 File Offset: 0x000FC879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionResponse);
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x000FE687 File Offset: 0x000FC887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x000FE6B8 File Offset: 0x000FC8B8
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

		// Token: 0x0600692F RID: 26927 RVA: 0x000FE6FD File Offset: 0x000FC8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x000FE70A File Offset: 0x000FC90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x000FE713 File Offset: 0x000FC913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x000FE748 File Offset: 0x000FC948
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

		// Token: 0x06006933 RID: 26931 RVA: 0x000FE786 File Offset: 0x000FC986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterViewDirectionResponse other)
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

		// Token: 0x06006934 RID: 26932 RVA: 0x000FE7B7 File Offset: 0x000FC9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x000FE7C0 File Offset: 0x000FC9C0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A45 RID: 14917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A46 RID: 14918
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04003A47 RID: 14919
		private ErrorCode errorCode_;
	}
}
