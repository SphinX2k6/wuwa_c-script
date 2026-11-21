using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000695 RID: 1685
	[NetMessage(EMessageId.GameplayCueResponse)]
	public sealed class GameplayCueResponse : IMessage<GameplayCueResponse>, IMessage, IEquatable<GameplayCueResponse>, IDeepCloneable<GameplayCueResponse>, IBufferMessage
	{
		// Token: 0x06009B26 RID: 39718 RVA: 0x0017A519 File Offset: 0x00178719
		[NullableContext(1)]
		public static GameplayCueResponse Create()
		{
			return new GameplayCueResponse();
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x0017A520 File Offset: 0x00178720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x0017A523 File Offset: 0x00178723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueResponse.Descriptor;
			}
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0017A52A File Offset: 0x0017872A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse()
		{
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x0017A532 File Offset: 0x00178732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse(GameplayCueResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x0017A557 File Offset: 0x00178757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueResponse Clone()
		{
			return new GameplayCueResponse(this);
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x0017A55F File Offset: 0x0017875F
		// (set) Token: 0x06009B2D RID: 39725 RVA: 0x0017A567 File Offset: 0x00178767
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

		// Token: 0x06009B2E RID: 39726 RVA: 0x0017A570 File Offset: 0x00178770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueResponse);
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x0017A57E File Offset: 0x0017877E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x0017A5AC File Offset: 0x001787AC
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

		// Token: 0x06009B31 RID: 39729 RVA: 0x0017A5F1 File Offset: 0x001787F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x0017A5FE File Offset: 0x001787FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x0017A607 File Offset: 0x00178807
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

		// Token: 0x06009B34 RID: 39732 RVA: 0x0017A63C File Offset: 0x0017883C
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

		// Token: 0x06009B35 RID: 39733 RVA: 0x0017A67A File Offset: 0x0017887A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCueResponse other)
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

		// Token: 0x06009B36 RID: 39734 RVA: 0x0017A6AB File Offset: 0x001788AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x0017A6B4 File Offset: 0x001788B4
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

		// Token: 0x040049BF RID: 18879
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C0 RID: 18880
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040049C1 RID: 18881
		private ErrorCode errorCode_;
	}
}
