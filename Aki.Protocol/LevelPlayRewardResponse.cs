using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F7 RID: 2295
	[NetMessage(EMessageId.LevelPlayRewardResponse)]
	public sealed class LevelPlayRewardResponse : IMessage<LevelPlayRewardResponse>, IMessage, IEquatable<LevelPlayRewardResponse>, IDeepCloneable<LevelPlayRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CB08 RID: 51976 RVA: 0x001DF50C File Offset: 0x001DD70C
		[NullableContext(1)]
		public static LevelPlayRewardResponse Create()
		{
			return new LevelPlayRewardResponse();
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x001DF513 File Offset: 0x001DD713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x001DF516 File Offset: 0x001DD716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CB0B RID: 51979 RVA: 0x001DF51D File Offset: 0x001DD71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse()
		{
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x001DF525 File Offset: 0x001DD725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse(LevelPlayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x001DF54A File Offset: 0x001DD74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse Clone()
		{
			return new LevelPlayRewardResponse(this);
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600CB0E RID: 51982 RVA: 0x001DF552 File Offset: 0x001DD752
		// (set) Token: 0x0600CB0F RID: 51983 RVA: 0x001DF55A File Offset: 0x001DD75A
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

		// Token: 0x0600CB10 RID: 51984 RVA: 0x001DF563 File Offset: 0x001DD763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardResponse);
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x001DF571 File Offset: 0x001DD771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x001DF5A0 File Offset: 0x001DD7A0
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

		// Token: 0x0600CB13 RID: 51987 RVA: 0x001DF5E5 File Offset: 0x001DD7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x001DF5F2 File Offset: 0x001DD7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x001DF5FB File Offset: 0x001DD7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x001DF630 File Offset: 0x001DD830
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

		// Token: 0x0600CB17 RID: 51991 RVA: 0x001DF66E File Offset: 0x001DD86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardResponse other)
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

		// Token: 0x0600CB18 RID: 51992 RVA: 0x001DF69F File Offset: 0x001DD89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x001DF6A8 File Offset: 0x001DD8A8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400569C RID: 22172
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400569D RID: 22173
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400569E RID: 22174
		private ErrorCode errorCode_;
	}
}
