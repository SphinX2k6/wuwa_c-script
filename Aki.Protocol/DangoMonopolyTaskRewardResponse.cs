using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039B RID: 923
	[NetMessage(EMessageId.DangoMonopolyTaskRewardResponse)]
	public sealed class DangoMonopolyTaskRewardResponse : IMessage<DangoMonopolyTaskRewardResponse>, IMessage, IEquatable<DangoMonopolyTaskRewardResponse>, IDeepCloneable<DangoMonopolyTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005B44 RID: 23364 RVA: 0x000DE460 File Offset: 0x000DC660
		[NullableContext(1)]
		public static DangoMonopolyTaskRewardResponse Create()
		{
			return new DangoMonopolyTaskRewardResponse();
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x000DE467 File Offset: 0x000DC667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06005B46 RID: 23366 RVA: 0x000DE46A File Offset: 0x000DC66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x000DE471 File Offset: 0x000DC671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse()
		{
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x000DE479 File Offset: 0x000DC679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse(DangoMonopolyTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x000DE49E File Offset: 0x000DC69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse Clone()
		{
			return new DangoMonopolyTaskRewardResponse(this);
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06005B4A RID: 23370 RVA: 0x000DE4A6 File Offset: 0x000DC6A6
		// (set) Token: 0x06005B4B RID: 23371 RVA: 0x000DE4AE File Offset: 0x000DC6AE
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

		// Token: 0x06005B4C RID: 23372 RVA: 0x000DE4B7 File Offset: 0x000DC6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRewardResponse);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x000DE4C5 File Offset: 0x000DC6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x000DE4F4 File Offset: 0x000DC6F4
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

		// Token: 0x06005B4F RID: 23375 RVA: 0x000DE539 File Offset: 0x000DC739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x000DE546 File Offset: 0x000DC746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x000DE54F File Offset: 0x000DC74F
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

		// Token: 0x06005B52 RID: 23378 RVA: 0x000DE584 File Offset: 0x000DC784
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

		// Token: 0x06005B53 RID: 23379 RVA: 0x000DE5C2 File Offset: 0x000DC7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskRewardResponse other)
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

		// Token: 0x06005B54 RID: 23380 RVA: 0x000DE5F3 File Offset: 0x000DC7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x000DE5FC File Offset: 0x000DC7FC
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

		// Token: 0x0400364A RID: 13898
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400364B RID: 13899
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400364C RID: 13900
		private ErrorCode errorCode_;
	}
}
