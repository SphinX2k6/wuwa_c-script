using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000522 RID: 1314
	[NetMessage(EMessageId.FarmGoldLevelPlayRepeatedRequest)]
	public sealed class FarmGoldLevelPlayRepeatedRequest : IMessage<FarmGoldLevelPlayRepeatedRequest>, IMessage, IEquatable<FarmGoldLevelPlayRepeatedRequest>, IDeepCloneable<FarmGoldLevelPlayRepeatedRequest>, IBufferMessage
	{
		// Token: 0x06007B5A RID: 31578 RVA: 0x0012B4FC File Offset: 0x001296FC
		[NullableContext(1)]
		public static FarmGoldLevelPlayRepeatedRequest Create()
		{
			return new FarmGoldLevelPlayRepeatedRequest();
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x0012B503 File Offset: 0x00129703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x0012B506 File Offset: 0x00129706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRepeatedRequest.Descriptor;
			}
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0012B50D File Offset: 0x0012970D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest()
		{
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x0012B520 File Offset: 0x00129720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest(FarmGoldLevelPlayRepeatedRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instIdList_ = other.instIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0012B556 File Offset: 0x00129756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest Clone()
		{
			return new FarmGoldLevelPlayRepeatedRequest(this);
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06007B60 RID: 31584 RVA: 0x0012B55E File Offset: 0x0012975E
		// (set) Token: 0x06007B61 RID: 31585 RVA: 0x0012B566 File Offset: 0x00129766
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

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06007B62 RID: 31586 RVA: 0x0012B56F File Offset: 0x0012976F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstIdList
		{
			get
			{
				return this.instIdList_;
			}
		}

		// Token: 0x06007B63 RID: 31587 RVA: 0x0012B577 File Offset: 0x00129777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRepeatedRequest);
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x0012B588 File Offset: 0x00129788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRepeatedRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.instIdList_.Equals(other.instIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0012B5D8 File Offset: 0x001297D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.instIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x0012B625 File Offset: 0x00129825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x0012B632 File Offset: 0x00129832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x0012B63C File Offset: 0x0012983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.instIdList_.WriteTo(ref output, FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x0012B68C File Offset: 0x0012988C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.instIdList_.CalculateSize(FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x0012B6E0 File Offset: 0x001298E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRepeatedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.instIdList_.Add(other.instIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x0012B72D File Offset: 0x0012992D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x0012B738 File Offset: 0x00129938
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
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.instIdList_.AddEntriesFrom(ref input, FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F2A RID: 16170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F2B RID: 16171
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04003F2C RID: 16172
		private int activityId_;

		// Token: 0x04003F2D RID: 16173
		public const int InstIdListFieldNumber = 8;

		// Token: 0x04003F2E RID: 16174
		private static readonly FieldCodec<int> _repeated_instIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04003F2F RID: 16175
		private readonly RepeatedField<int> instIdList_ = new RepeatedField<int>();
	}
}
