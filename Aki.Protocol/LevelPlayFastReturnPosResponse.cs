using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F9 RID: 2297
	[NetMessage(EMessageId.LevelPlayFastReturnPosResponse)]
	public sealed class LevelPlayFastReturnPosResponse : IMessage<LevelPlayFastReturnPosResponse>, IMessage, IEquatable<LevelPlayFastReturnPosResponse>, IDeepCloneable<LevelPlayFastReturnPosResponse>, IBufferMessage
	{
		// Token: 0x0600CAFE RID: 51966 RVA: 0x001DF471 File Offset: 0x001DD671
		[NullableContext(1)]
		public static LevelPlayFastReturnPosResponse Create()
		{
			return new LevelPlayFastReturnPosResponse();
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x001DF478 File Offset: 0x001DD678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600CB00 RID: 51968 RVA: 0x001DF47B File Offset: 0x001DD67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFastReturnPosResponse.Descriptor;
			}
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x001DF482 File Offset: 0x001DD682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse()
		{
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x001DF48A File Offset: 0x001DD68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse(LevelPlayFastReturnPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x001DF4AF File Offset: 0x001DD6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse Clone()
		{
			return new LevelPlayFastReturnPosResponse(this);
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600CB04 RID: 51972 RVA: 0x001DF4B7 File Offset: 0x001DD6B7
		// (set) Token: 0x0600CB05 RID: 51973 RVA: 0x001DF4BF File Offset: 0x001DD6BF
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

		// Token: 0x0600CB06 RID: 51974 RVA: 0x001DF4C8 File Offset: 0x001DD6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFastReturnPosResponse);
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x001DF4D6 File Offset: 0x001DD6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFastReturnPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB08 RID: 51976 RVA: 0x001DF504 File Offset: 0x001DD704
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

		// Token: 0x0600CB09 RID: 51977 RVA: 0x001DF549 File Offset: 0x001DD749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB0A RID: 51978 RVA: 0x001DF556 File Offset: 0x001DD756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB0B RID: 51979 RVA: 0x001DF55F File Offset: 0x001DD75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x001DF594 File Offset: 0x001DD794
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

		// Token: 0x0600CB0D RID: 51981 RVA: 0x001DF5D2 File Offset: 0x001DD7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFastReturnPosResponse other)
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

		// Token: 0x0600CB0E RID: 51982 RVA: 0x001DF603 File Offset: 0x001DD803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x001DF60C File Offset: 0x001DD80C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400564B RID: 22091
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400564C RID: 22092
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400564D RID: 22093
		private ErrorCode errorCode_;
	}
}
