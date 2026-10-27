using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045D RID: 1117
	[NetMessage(EMessageId.EnterViewDirectionResponse)]
	public sealed class EnterViewDirectionResponse : IMessage<EnterViewDirectionResponse>, IMessage, IEquatable<EnterViewDirectionResponse>, IDeepCloneable<EnterViewDirectionResponse>, IBufferMessage
	{
		// Token: 0x06006AB2 RID: 27314 RVA: 0x0010168A File Offset: 0x000FF88A
		[NullableContext(1)]
		public static EnterViewDirectionResponse Create()
		{
			return new EnterViewDirectionResponse();
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x00101691 File Offset: 0x000FF891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x00101694 File Offset: 0x000FF894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterViewDirectionResponse.Descriptor;
			}
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x0010169B File Offset: 0x000FF89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse()
		{
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x001016A3 File Offset: 0x000FF8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse(EnterViewDirectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x001016C8 File Offset: 0x000FF8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterViewDirectionResponse Clone()
		{
			return new EnterViewDirectionResponse(this);
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x001016D0 File Offset: 0x000FF8D0
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x001016D8 File Offset: 0x000FF8D8
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

		// Token: 0x06006ABA RID: 27322 RVA: 0x001016E1 File Offset: 0x000FF8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterViewDirectionResponse);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x001016EF File Offset: 0x000FF8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterViewDirectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x00101720 File Offset: 0x000FF920
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

		// Token: 0x06006ABD RID: 27325 RVA: 0x00101765 File Offset: 0x000FF965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x00101772 File Offset: 0x000FF972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0010177B File Offset: 0x000FF97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x001017B0 File Offset: 0x000FF9B0
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

		// Token: 0x06006AC1 RID: 27329 RVA: 0x001017EE File Offset: 0x000FF9EE
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

		// Token: 0x06006AC2 RID: 27330 RVA: 0x0010181F File Offset: 0x000FFA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00101828 File Offset: 0x000FFA28
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A57 RID: 14935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A58 RID: 14936
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003A59 RID: 14937
		private ErrorCode errorCode_;
	}
}
