using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000408 RID: 1032
	[NetMessage(EMessageId.DropCatchInfoResponse)]
	public sealed class DropCatchInfoResponse : IMessage<DropCatchInfoResponse>, IMessage, IEquatable<DropCatchInfoResponse>, IDeepCloneable<DropCatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06006389 RID: 25481 RVA: 0x000EF54E File Offset: 0x000ED74E
		[NullableContext(1)]
		public static DropCatchInfoResponse Create()
		{
			return new DropCatchInfoResponse();
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x0600638A RID: 25482 RVA: 0x000EF555 File Offset: 0x000ED755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x000EF558 File Offset: 0x000ED758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x000EF55F File Offset: 0x000ED75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse()
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x000EF572 File Offset: 0x000ED772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse(DropCatchInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x000EF5A8 File Offset: 0x000ED7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchInfoResponse Clone()
		{
			return new DropCatchInfoResponse(this);
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x000EF5B0 File Offset: 0x000ED7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06006390 RID: 25488 RVA: 0x000EF5B8 File Offset: 0x000ED7B8
		// (set) Token: 0x06006391 RID: 25489 RVA: 0x000EF5C0 File Offset: 0x000ED7C0
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

		// Token: 0x06006392 RID: 25490 RVA: 0x000EF5C9 File Offset: 0x000ED7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchInfoResponse);
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x000EF5D8 File Offset: 0x000ED7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x000EF628 File Offset: 0x000ED828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
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

		// Token: 0x06006395 RID: 25493 RVA: 0x000EF67B File Offset: 0x000ED87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x000EF688 File Offset: 0x000ED888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x000EF694 File Offset: 0x000ED894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, DropCatchInfoResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x000EF6E4 File Offset: 0x000ED8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(DropCatchInfoResponse._repeated_infos_codec);
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

		// Token: 0x06006399 RID: 25497 RVA: 0x000EF738 File Offset: 0x000ED938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x000EF785 File Offset: 0x000ED985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x000EF790 File Offset: 0x000ED990
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
				if (num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, DropCatchInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04003828 RID: 14376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003829 RID: 14377
		public const int InfosFieldNumber = 3;

		// Token: 0x0400382A RID: 14378
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_infos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(26U, DropCatchLevelInfo.Parser);

		// Token: 0x0400382B RID: 14379
		private readonly RepeatedField<DropCatchLevelInfo> infos_ = new RepeatedField<DropCatchLevelInfo>();

		// Token: 0x0400382C RID: 14380
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400382D RID: 14381
		private ErrorCode errorCode_;
	}
}
