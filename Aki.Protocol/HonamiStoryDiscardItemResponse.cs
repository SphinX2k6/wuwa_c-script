using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000772 RID: 1906
	[NetMessage(EMessageId.HonamiStoryDiscardItemResponse)]
	public sealed class HonamiStoryDiscardItemResponse : IMessage<HonamiStoryDiscardItemResponse>, IMessage, IEquatable<HonamiStoryDiscardItemResponse>, IDeepCloneable<HonamiStoryDiscardItemResponse>, IBufferMessage
	{
		// Token: 0x0600AC4D RID: 44109 RVA: 0x0019E41C File Offset: 0x0019C61C
		[NullableContext(1)]
		public static HonamiStoryDiscardItemResponse Create()
		{
			return new HonamiStoryDiscardItemResponse();
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x0019E423 File Offset: 0x0019C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600AC4F RID: 44111 RVA: 0x0019E426 File Offset: 0x0019C626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDiscardItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x0019E42D File Offset: 0x0019C62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse()
		{
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x0019E435 File Offset: 0x0019C635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse(HonamiStoryDiscardItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x0019E45A File Offset: 0x0019C65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse Clone()
		{
			return new HonamiStoryDiscardItemResponse(this);
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x0019E462 File Offset: 0x0019C662
		// (set) Token: 0x0600AC54 RID: 44116 RVA: 0x0019E46A File Offset: 0x0019C66A
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

		// Token: 0x0600AC55 RID: 44117 RVA: 0x0019E473 File Offset: 0x0019C673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDiscardItemResponse);
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x0019E481 File Offset: 0x0019C681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDiscardItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x0019E4B0 File Offset: 0x0019C6B0
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

		// Token: 0x0600AC58 RID: 44120 RVA: 0x0019E4F5 File Offset: 0x0019C6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x0019E502 File Offset: 0x0019C702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x0019E50B File Offset: 0x0019C70B
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

		// Token: 0x0600AC5B RID: 44123 RVA: 0x0019E540 File Offset: 0x0019C740
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

		// Token: 0x0600AC5C RID: 44124 RVA: 0x0019E57E File Offset: 0x0019C77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDiscardItemResponse other)
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

		// Token: 0x0600AC5D RID: 44125 RVA: 0x0019E5AF File Offset: 0x0019C7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x0019E5B8 File Offset: 0x0019C7B8
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

		// Token: 0x04004E10 RID: 19984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E11 RID: 19985
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004E12 RID: 19986
		private ErrorCode errorCode_;
	}
}
