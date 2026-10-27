using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000742 RID: 1858
	[NetMessage(EMessageId.HarvestActivityLevelNotify)]
	public sealed class HarvestActivityLevelNotify : IMessage<HarvestActivityLevelNotify>, IMessage, IEquatable<HarvestActivityLevelNotify>, IDeepCloneable<HarvestActivityLevelNotify>, IBufferMessage
	{
		// Token: 0x0600A856 RID: 43094 RVA: 0x00195021 File Offset: 0x00193221
		[NullableContext(1)]
		public static HarvestActivityLevelNotify Create()
		{
			return new HarvestActivityLevelNotify();
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x00195028 File Offset: 0x00193228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600A858 RID: 43096 RVA: 0x0019502B File Offset: 0x0019322B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x00195032 File Offset: 0x00193232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify()
		{
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x00195045 File Offset: 0x00193245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify(HarvestActivityLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.harvestLevelRewards_ = other.harvestLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A85B RID: 43099 RVA: 0x0019507B File Offset: 0x0019327B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify Clone()
		{
			return new HarvestActivityLevelNotify(this);
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x00195083 File Offset: 0x00193283
		// (set) Token: 0x0600A85D RID: 43101 RVA: 0x0019508B File Offset: 0x0019328B
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

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x00195094 File Offset: 0x00193294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestLevelReward> HarvestLevelRewards
		{
			get
			{
				return this.harvestLevelRewards_;
			}
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x0019509C File Offset: 0x0019329C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelNotify);
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x001950AC File Offset: 0x001932AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.harvestLevelRewards_.Equals(other.harvestLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x001950FC File Offset: 0x001932FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.harvestLevelRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x00195149 File Offset: 0x00193349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x00195156 File Offset: 0x00193356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x00195160 File Offset: 0x00193360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.harvestLevelRewards_.WriteTo(ref output, HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x001951B0 File Offset: 0x001933B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.harvestLevelRewards_.CalculateSize(HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x00195204 File Offset: 0x00193404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.harvestLevelRewards_.Add(other.harvestLevelRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x00195251 File Offset: 0x00193451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x0019525C File Offset: 0x0019345C
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
					if (num != 104U)
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
					this.harvestLevelRewards_.AddEntriesFrom(ref input, HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
				}
			}
		}

		// Token: 0x04004CCE RID: 19662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CCF RID: 19663
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004CD0 RID: 19664
		private int activityId_;

		// Token: 0x04004CD1 RID: 19665
		public const int HarvestLevelRewardsFieldNumber = 3;

		// Token: 0x04004CD2 RID: 19666
		private static readonly FieldCodec<HarvestLevelReward> _repeated_harvestLevelRewards_codec = FieldCodec.ForMessage<HarvestLevelReward>(26U, HarvestLevelReward.Parser);

		// Token: 0x04004CD3 RID: 19667
		private readonly RepeatedField<HarvestLevelReward> harvestLevelRewards_ = new RepeatedField<HarvestLevelReward>();
	}
}
