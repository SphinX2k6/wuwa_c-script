using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8B RID: 3467
	[NetMessage(EMessageId.PlayerMotionResponse)]
	public sealed class PlayerMotionResponse : IMessage<PlayerMotionResponse>, IMessage, IEquatable<PlayerMotionResponse>, IDeepCloneable<PlayerMotionResponse>, IBufferMessage
	{
		// Token: 0x06012B6C RID: 76652 RVA: 0x002BB9A1 File Offset: 0x002B9BA1
		[NullableContext(1)]
		public static PlayerMotionResponse Create()
		{
			return new PlayerMotionResponse();
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x06012B6D RID: 76653 RVA: 0x002BB9A8 File Offset: 0x002B9BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x06012B6E RID: 76654 RVA: 0x002BB9AB File Offset: 0x002B9BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerMotionResponse.Descriptor;
			}
		}

		// Token: 0x06012B6F RID: 76655 RVA: 0x002BB9B2 File Offset: 0x002B9BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse()
		{
		}

		// Token: 0x06012B70 RID: 76656 RVA: 0x002BB9BA File Offset: 0x002B9BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse(PlayerMotionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B71 RID: 76657 RVA: 0x002BB9DF File Offset: 0x002B9BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse Clone()
		{
			return new PlayerMotionResponse(this);
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x06012B72 RID: 76658 RVA: 0x002BB9E7 File Offset: 0x002B9BE7
		// (set) Token: 0x06012B73 RID: 76659 RVA: 0x002BB9EF File Offset: 0x002B9BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06012B74 RID: 76660 RVA: 0x002BB9F8 File Offset: 0x002B9BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerMotionResponse);
		}

		// Token: 0x06012B75 RID: 76661 RVA: 0x002BBA06 File Offset: 0x002B9C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerMotionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x002BBA34 File Offset: 0x002B9C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x002BBA79 File Offset: 0x002B9C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x002BBA86 File Offset: 0x002B9C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x002BBA8F File Offset: 0x002B9C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B7A RID: 76666 RVA: 0x002BBAC4 File Offset: 0x002B9CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B7B RID: 76667 RVA: 0x002BBB02 File Offset: 0x002B9D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerMotionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B7C RID: 76668 RVA: 0x002BBB33 File Offset: 0x002B9D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B7D RID: 76669 RVA: 0x002BBB3C File Offset: 0x002B9D3C
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007475 RID: 29813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007476 RID: 29814
		public const int ErrorIdFieldNumber = 8;

		// Token: 0x04007477 RID: 29815
		private ErrorCode errorId_;
	}
}
