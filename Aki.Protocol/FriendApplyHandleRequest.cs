using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064D RID: 1613
	[NetMessage(EMessageId.FriendApplyHandleRequest)]
	public sealed class FriendApplyHandleRequest : IMessage<FriendApplyHandleRequest>, IMessage, IEquatable<FriendApplyHandleRequest>, IDeepCloneable<FriendApplyHandleRequest>, IBufferMessage
	{
		// Token: 0x0600945E RID: 37982 RVA: 0x0016694D File Offset: 0x00164B4D
		[NullableContext(1)]
		public static FriendApplyHandleRequest Create()
		{
			return new FriendApplyHandleRequest();
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x00166954 File Offset: 0x00164B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06009460 RID: 37984 RVA: 0x00166957 File Offset: 0x00164B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyHandleRequest.Descriptor;
			}
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x0016695E File Offset: 0x00164B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest()
		{
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00166971 File Offset: 0x00164B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest(FriendApplyHandleRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.operator_ = other.operator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x001669A7 File Offset: 0x00164BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest Clone()
		{
			return new FriendApplyHandleRequest(this);
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06009464 RID: 37988 RVA: 0x001669AF File Offset: 0x00164BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06009465 RID: 37989 RVA: 0x001669B7 File Offset: 0x00164BB7
		// (set) Token: 0x06009466 RID: 37990 RVA: 0x001669BF File Offset: 0x00164BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyOperator Operator
		{
			get
			{
				return this.operator_;
			}
			set
			{
				this.operator_ = value;
			}
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x001669C8 File Offset: 0x00164BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyHandleRequest);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x001669D8 File Offset: 0x00164BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyHandleRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.Operator == other.Operator && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x00166A28 File Offset: 0x00164C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.Operator != FriendApplyOperator.Approve)
			{
				num ^= this.Operator.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x00166A7B File Offset: 0x00164C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x00166A88 File Offset: 0x00164C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x00166A94 File Offset: 0x00164C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operator != FriendApplyOperator.Approve)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Operator);
			}
			this.ids_.WriteTo(ref output, FriendApplyHandleRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x00166AE4 File Offset: 0x00164CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(FriendApplyHandleRequest._repeated_ids_codec);
			if (this.Operator != FriendApplyOperator.Approve)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Operator);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00166B38 File Offset: 0x00164D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyHandleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.Operator != FriendApplyOperator.Approve)
			{
				this.Operator = other.Operator;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x00166B85 File Offset: 0x00164D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x00166B90 File Offset: 0x00164D90
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
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, FriendApplyHandleRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.Operator = (FriendApplyOperator)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004722 RID: 18210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004723 RID: 18211
		public const int IdsFieldNumber = 13;

		// Token: 0x04004724 RID: 18212
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04004725 RID: 18213
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04004726 RID: 18214
		public const int OperatorFieldNumber = 3;

		// Token: 0x04004727 RID: 18215
		private FriendApplyOperator operator_;
	}
}
