using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9F RID: 3999
	[NetMessage(EMessageId.RoguelikeGotoNextRoomResponse)]
	public sealed class RoguelikeGotoNextRoomResponse : IMessage<RoguelikeGotoNextRoomResponse>, IMessage, IEquatable<RoguelikeGotoNextRoomResponse>, IDeepCloneable<RoguelikeGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x06015627 RID: 87591 RVA: 0x0031A676 File Offset: 0x00318876
		[NullableContext(1)]
		public static RoguelikeGotoNextRoomResponse Create()
		{
			return new RoguelikeGotoNextRoomResponse();
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x06015628 RID: 87592 RVA: 0x0031A67D File Offset: 0x0031887D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x06015629 RID: 87593 RVA: 0x0031A680 File Offset: 0x00318880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x0601562A RID: 87594 RVA: 0x0031A687 File Offset: 0x00318887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse()
		{
		}

		// Token: 0x0601562B RID: 87595 RVA: 0x0031A68F File Offset: 0x0031888F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse(RoguelikeGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601562C RID: 87596 RVA: 0x0031A6B4 File Offset: 0x003188B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse Clone()
		{
			return new RoguelikeGotoNextRoomResponse(this);
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x0601562D RID: 87597 RVA: 0x0031A6BC File Offset: 0x003188BC
		// (set) Token: 0x0601562E RID: 87598 RVA: 0x0031A6C4 File Offset: 0x003188C4
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

		// Token: 0x0601562F RID: 87599 RVA: 0x0031A6CD File Offset: 0x003188CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGotoNextRoomResponse);
		}

		// Token: 0x06015630 RID: 87600 RVA: 0x0031A6DB File Offset: 0x003188DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015631 RID: 87601 RVA: 0x0031A70C File Offset: 0x0031890C
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

		// Token: 0x06015632 RID: 87602 RVA: 0x0031A751 File Offset: 0x00318951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015633 RID: 87603 RVA: 0x0031A75E File Offset: 0x0031895E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015634 RID: 87604 RVA: 0x0031A767 File Offset: 0x00318967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015635 RID: 87605 RVA: 0x0031A79C File Offset: 0x0031899C
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

		// Token: 0x06015636 RID: 87606 RVA: 0x0031A7DA File Offset: 0x003189DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGotoNextRoomResponse other)
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

		// Token: 0x06015637 RID: 87607 RVA: 0x0031A80B File Offset: 0x00318A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015638 RID: 87608 RVA: 0x0031A814 File Offset: 0x00318A14
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040080A1 RID: 32929
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080A2 RID: 32930
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040080A3 RID: 32931
		private ErrorCode errorCode_;
	}
}
