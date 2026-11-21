using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000639 RID: 1593
	[NetMessage(EMessageId.FriendApplyHandleRequest)]
	public sealed class FriendApplyHandleRequest : IMessage<FriendApplyHandleRequest>, IMessage, IEquatable<FriendApplyHandleRequest>, IDeepCloneable<FriendApplyHandleRequest>, IBufferMessage
	{
		// Token: 0x06009308 RID: 37640 RVA: 0x00163F1D File Offset: 0x0016211D
		[NullableContext(1)]
		public static FriendApplyHandleRequest Create()
		{
			return new FriendApplyHandleRequest();
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06009309 RID: 37641 RVA: 0x00163F24 File Offset: 0x00162124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x0600930A RID: 37642 RVA: 0x00163F27 File Offset: 0x00162127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyHandleRequest.Descriptor;
			}
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00163F2E File Offset: 0x0016212E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest()
		{
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00163F41 File Offset: 0x00162141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest(FriendApplyHandleRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.operator_ = other.operator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x00163F77 File Offset: 0x00162177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyHandleRequest Clone()
		{
			return new FriendApplyHandleRequest(this);
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x00163F7F File Offset: 0x0016217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x00163F87 File Offset: 0x00162187
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x00163F8F File Offset: 0x0016218F
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

		// Token: 0x06009311 RID: 37649 RVA: 0x00163F98 File Offset: 0x00162198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyHandleRequest);
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x00163FA8 File Offset: 0x001621A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyHandleRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.Operator == other.Operator && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x00163FF8 File Offset: 0x001621F8
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

		// Token: 0x06009314 RID: 37652 RVA: 0x0016404B File Offset: 0x0016224B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009315 RID: 37653 RVA: 0x00164058 File Offset: 0x00162258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x00164064 File Offset: 0x00162264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, FriendApplyHandleRequest._repeated_ids_codec);
			if (this.Operator != FriendApplyOperator.Approve)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Operator);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x001640B4 File Offset: 0x001622B4
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

		// Token: 0x06009318 RID: 37656 RVA: 0x00164108 File Offset: 0x00162308
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

		// Token: 0x06009319 RID: 37657 RVA: 0x00164155 File Offset: 0x00162355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00164160 File Offset: 0x00162360
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
				if (num != 56U && num != 58U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Operator = (FriendApplyOperator)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, FriendApplyHandleRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400471B RID: 18203
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400471C RID: 18204
		public const int IdsFieldNumber = 7;

		// Token: 0x0400471D RID: 18205
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400471E RID: 18206
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x0400471F RID: 18207
		public const int OperatorFieldNumber = 13;

		// Token: 0x04004720 RID: 18208
		private FriendApplyOperator operator_;
	}
}
