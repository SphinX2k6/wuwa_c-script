using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000382 RID: 898
	[NetMessage(EMessageId.DangoMonopolyBoardRewardRequest)]
	public sealed class DangoMonopolyBoardRewardRequest : IMessage<DangoMonopolyBoardRewardRequest>, IMessage, IEquatable<DangoMonopolyBoardRewardRequest>, IDeepCloneable<DangoMonopolyBoardRewardRequest>, IBufferMessage
	{
		// Token: 0x060058F7 RID: 22775 RVA: 0x000D8E26 File Offset: 0x000D7026
		[NullableContext(1)]
		public static DangoMonopolyBoardRewardRequest Create()
		{
			return new DangoMonopolyBoardRewardRequest();
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x000D8E2D File Offset: 0x000D702D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x000D8E30 File Offset: 0x000D7030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRewardRequest.Descriptor;
			}
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x000D8E37 File Offset: 0x000D7037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest()
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x000D8E4A File Offset: 0x000D704A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest(DangoMonopolyBoardRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.boardIds_ = other.boardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x000D8E80 File Offset: 0x000D7080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest Clone()
		{
			return new DangoMonopolyBoardRewardRequest(this);
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x000D8E88 File Offset: 0x000D7088
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x000D8E90 File Offset: 0x000D7090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x000D8E99 File Offset: 0x000D7099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BoardIds
		{
			get
			{
				return this.boardIds_;
			}
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x000D8EA1 File Offset: 0x000D70A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRewardRequest);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x000D8EB0 File Offset: 0x000D70B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.boardIds_.Equals(other.boardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x000D8F00 File Offset: 0x000D7100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.boardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x000D8F4D File Offset: 0x000D714D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x000D8F5A File Offset: 0x000D715A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x000D8F64 File Offset: 0x000D7164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.boardIds_.WriteTo(ref output, DangoMonopolyBoardRewardRequest._repeated_boardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.boardIds_.CalculateSize(DangoMonopolyBoardRewardRequest._repeated_boardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x000D9008 File Offset: 0x000D7208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyBoardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.boardIds_.Add(other.boardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x000D9055 File Offset: 0x000D7255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x000D9060 File Offset: 0x000D7260
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
				if (num != 80U && num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.boardIds_.AddEntriesFrom(ref input, DangoMonopolyBoardRewardRequest._repeated_boardIds_codec);
				}
			}
		}

		// Token: 0x04003546 RID: 13638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003547 RID: 13639
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04003548 RID: 13640
		private int activityId_;

		// Token: 0x04003549 RID: 13641
		public const int BoardIdsFieldNumber = 10;

		// Token: 0x0400354A RID: 13642
		private static readonly FieldCodec<int> _repeated_boardIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400354B RID: 13643
		private readonly RepeatedField<int> boardIds_ = new RepeatedField<int>();
	}
}
