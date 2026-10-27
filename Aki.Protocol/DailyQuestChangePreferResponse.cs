using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000326 RID: 806
	[NetMessage(EMessageId.DailyQuestChangePreferResponse)]
	public sealed class DailyQuestChangePreferResponse : IMessage<DailyQuestChangePreferResponse>, IMessage, IEquatable<DailyQuestChangePreferResponse>, IDeepCloneable<DailyQuestChangePreferResponse>, IBufferMessage
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x000C5200 File Offset: 0x000C3400
		[NullableContext(1)]
		public static DailyQuestChangePreferResponse Create()
		{
			return new DailyQuestChangePreferResponse();
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x000C5207 File Offset: 0x000C3407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x000C520A File Offset: 0x000C340A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestChangePreferResponse.Descriptor;
			}
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x000C5211 File Offset: 0x000C3411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse()
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x000C5219 File Offset: 0x000C3419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse(DailyQuestChangePreferResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x000C523E File Offset: 0x000C343E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse Clone()
		{
			return new DailyQuestChangePreferResponse(this);
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x000C5246 File Offset: 0x000C3446
		// (set) Token: 0x060050FF RID: 20735 RVA: 0x000C524E File Offset: 0x000C344E
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

		// Token: 0x06005100 RID: 20736 RVA: 0x000C5257 File Offset: 0x000C3457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestChangePreferResponse);
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x000C5265 File Offset: 0x000C3465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestChangePreferResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x000C5294 File Offset: 0x000C3494
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

		// Token: 0x06005103 RID: 20739 RVA: 0x000C52D9 File Offset: 0x000C34D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x000C52E6 File Offset: 0x000C34E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x000C52EF File Offset: 0x000C34EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x000C5324 File Offset: 0x000C3524
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

		// Token: 0x06005107 RID: 20743 RVA: 0x000C5362 File Offset: 0x000C3562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestChangePreferResponse other)
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

		// Token: 0x06005108 RID: 20744 RVA: 0x000C5393 File Offset: 0x000C3593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x000C539C File Offset: 0x000C359C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003285 RID: 12933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003286 RID: 12934
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04003287 RID: 12935
		private ErrorCode errorId_;
	}
}
