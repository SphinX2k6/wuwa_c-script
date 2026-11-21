using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038A RID: 906
	[NetMessage(EMessageId.DangoMonopolyBoardRewardRequest)]
	public sealed class DangoMonopolyBoardRewardRequest : IMessage<DangoMonopolyBoardRewardRequest>, IMessage, IEquatable<DangoMonopolyBoardRewardRequest>, IDeepCloneable<DangoMonopolyBoardRewardRequest>, IBufferMessage
	{
		// Token: 0x060059E4 RID: 23012 RVA: 0x000DB4AE File Offset: 0x000D96AE
		[NullableContext(1)]
		public static DangoMonopolyBoardRewardRequest Create()
		{
			return new DangoMonopolyBoardRewardRequest();
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060059E5 RID: 23013 RVA: 0x000DB4B5 File Offset: 0x000D96B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060059E6 RID: 23014 RVA: 0x000DB4B8 File Offset: 0x000D96B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRewardRequest.Descriptor;
			}
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x000DB4BF File Offset: 0x000D96BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest()
		{
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x000DB4D2 File Offset: 0x000D96D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest(DangoMonopolyBoardRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.boardIds_ = other.boardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x000DB508 File Offset: 0x000D9708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardRequest Clone()
		{
			return new DangoMonopolyBoardRewardRequest(this);
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060059EA RID: 23018 RVA: 0x000DB510 File Offset: 0x000D9710
		// (set) Token: 0x060059EB RID: 23019 RVA: 0x000DB518 File Offset: 0x000D9718
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x000DB521 File Offset: 0x000D9721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BoardIds
		{
			get
			{
				return this.boardIds_;
			}
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x000DB529 File Offset: 0x000D9729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRewardRequest);
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x000DB538 File Offset: 0x000D9738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.boardIds_.Equals(other.boardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x000DB588 File Offset: 0x000D9788
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

		// Token: 0x060059F0 RID: 23024 RVA: 0x000DB5D5 File Offset: 0x000D97D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x000DB5E2 File Offset: 0x000D97E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x000DB5EC File Offset: 0x000D97EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.boardIds_.WriteTo(ref output, DangoMonopolyBoardRewardRequest._repeated_boardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x000DB63C File Offset: 0x000D983C
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

		// Token: 0x060059F4 RID: 23028 RVA: 0x000DB690 File Offset: 0x000D9890
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

		// Token: 0x060059F5 RID: 23029 RVA: 0x000DB6DD File Offset: 0x000D98DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x000DB6E8 File Offset: 0x000D98E8
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
				if (num != 40U && num != 42U)
				{
					if (num != 56U)
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

		// Token: 0x040035E2 RID: 13794
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E3 RID: 13795
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040035E4 RID: 13796
		private int activityId_;

		// Token: 0x040035E5 RID: 13797
		public const int BoardIdsFieldNumber = 5;

		// Token: 0x040035E6 RID: 13798
		private static readonly FieldCodec<int> _repeated_boardIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040035E7 RID: 13799
		private readonly RepeatedField<int> boardIds_ = new RepeatedField<int>();
	}
}
