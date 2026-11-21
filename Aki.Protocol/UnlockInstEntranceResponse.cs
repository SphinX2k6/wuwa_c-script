using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FE RID: 5374
	[NetMessage(EMessageId.UnlockInstEntranceResponse)]
	public sealed class UnlockInstEntranceResponse : IMessage<UnlockInstEntranceResponse>, IMessage, IEquatable<UnlockInstEntranceResponse>, IDeepCloneable<UnlockInstEntranceResponse>, IBufferMessage
	{
		// Token: 0x0601C7C8 RID: 116680 RVA: 0x00421739 File Offset: 0x0041F939
		[NullableContext(1)]
		public static UnlockInstEntranceResponse Create()
		{
			return new UnlockInstEntranceResponse();
		}

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x0601C7C9 RID: 116681 RVA: 0x00421740 File Offset: 0x0041F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x0601C7CA RID: 116682 RVA: 0x00421743 File Offset: 0x0041F943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInstEntranceResponse.Descriptor;
			}
		}

		// Token: 0x0601C7CB RID: 116683 RVA: 0x0042174A File Offset: 0x0041F94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse()
		{
		}

		// Token: 0x0601C7CC RID: 116684 RVA: 0x00421752 File Offset: 0x0041F952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse(UnlockInstEntranceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7CD RID: 116685 RVA: 0x00421777 File Offset: 0x0041F977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceResponse Clone()
		{
			return new UnlockInstEntranceResponse(this);
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x0601C7CE RID: 116686 RVA: 0x0042177F File Offset: 0x0041F97F
		// (set) Token: 0x0601C7CF RID: 116687 RVA: 0x00421787 File Offset: 0x0041F987
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

		// Token: 0x0601C7D0 RID: 116688 RVA: 0x00421790 File Offset: 0x0041F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInstEntranceResponse);
		}

		// Token: 0x0601C7D1 RID: 116689 RVA: 0x0042179E File Offset: 0x0041F99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInstEntranceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7D2 RID: 116690 RVA: 0x004217CC File Offset: 0x0041F9CC
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

		// Token: 0x0601C7D3 RID: 116691 RVA: 0x00421811 File Offset: 0x0041FA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7D4 RID: 116692 RVA: 0x0042181E File Offset: 0x0041FA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7D5 RID: 116693 RVA: 0x00421827 File Offset: 0x0041FA27
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

		// Token: 0x0601C7D6 RID: 116694 RVA: 0x0042185C File Offset: 0x0041FA5C
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

		// Token: 0x0601C7D7 RID: 116695 RVA: 0x0042189A File Offset: 0x0041FA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInstEntranceResponse other)
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

		// Token: 0x0601C7D8 RID: 116696 RVA: 0x004218CB File Offset: 0x0041FACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7D9 RID: 116697 RVA: 0x004218D4 File Offset: 0x0041FAD4
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

		// Token: 0x0400A45D RID: 42077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A45E RID: 42078
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400A45F RID: 42079
		private ErrorCode errorCode_;
	}
}
