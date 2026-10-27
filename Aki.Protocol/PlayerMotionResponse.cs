using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9B RID: 3483
	[NetMessage(EMessageId.PlayerMotionResponse)]
	public sealed class PlayerMotionResponse : IMessage<PlayerMotionResponse>, IMessage, IEquatable<PlayerMotionResponse>, IDeepCloneable<PlayerMotionResponse>, IBufferMessage
	{
		// Token: 0x06012C68 RID: 76904 RVA: 0x002BD5C5 File Offset: 0x002BB7C5
		[NullableContext(1)]
		public static PlayerMotionResponse Create()
		{
			return new PlayerMotionResponse();
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x06012C69 RID: 76905 RVA: 0x002BD5CC File Offset: 0x002BB7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x06012C6A RID: 76906 RVA: 0x002BD5CF File Offset: 0x002BB7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerMotionResponse.Descriptor;
			}
		}

		// Token: 0x06012C6B RID: 76907 RVA: 0x002BD5D6 File Offset: 0x002BB7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse()
		{
		}

		// Token: 0x06012C6C RID: 76908 RVA: 0x002BD5DE File Offset: 0x002BB7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse(PlayerMotionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C6D RID: 76909 RVA: 0x002BD603 File Offset: 0x002BB803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerMotionResponse Clone()
		{
			return new PlayerMotionResponse(this);
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x06012C6E RID: 76910 RVA: 0x002BD60B File Offset: 0x002BB80B
		// (set) Token: 0x06012C6F RID: 76911 RVA: 0x002BD613 File Offset: 0x002BB813
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

		// Token: 0x06012C70 RID: 76912 RVA: 0x002BD61C File Offset: 0x002BB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerMotionResponse);
		}

		// Token: 0x06012C71 RID: 76913 RVA: 0x002BD62A File Offset: 0x002BB82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerMotionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C72 RID: 76914 RVA: 0x002BD658 File Offset: 0x002BB858
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

		// Token: 0x06012C73 RID: 76915 RVA: 0x002BD69D File Offset: 0x002BB89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C74 RID: 76916 RVA: 0x002BD6AA File Offset: 0x002BB8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C75 RID: 76917 RVA: 0x002BD6B3 File Offset: 0x002BB8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x002BD6E8 File Offset: 0x002BB8E8
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

		// Token: 0x06012C77 RID: 76919 RVA: 0x002BD726 File Offset: 0x002BB926
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

		// Token: 0x06012C78 RID: 76920 RVA: 0x002BD757 File Offset: 0x002BB957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x002BD760 File Offset: 0x002BB960
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400745D RID: 29789
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400745E RID: 29790
		public const int ErrorIdFieldNumber = 2;

		// Token: 0x0400745F RID: 29791
		private ErrorCode errorId_;
	}
}
