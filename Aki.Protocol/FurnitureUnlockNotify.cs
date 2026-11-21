using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000671 RID: 1649
	[NetMessage(EMessageId.FurnitureUnlockNotify)]
	public sealed class FurnitureUnlockNotify : IMessage<FurnitureUnlockNotify>, IMessage, IEquatable<FurnitureUnlockNotify>, IDeepCloneable<FurnitureUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600977B RID: 38779 RVA: 0x0016D7FB File Offset: 0x0016B9FB
		[NullableContext(1)]
		public static FurnitureUnlockNotify Create()
		{
			return new FurnitureUnlockNotify();
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x0016D802 File Offset: 0x0016BA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x0016D805 File Offset: 0x0016BA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x0016D80C File Offset: 0x0016BA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify()
		{
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x0016D81F File Offset: 0x0016BA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify(FurnitureUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.furnitureIds_ = other.furnitureIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x0016D855 File Offset: 0x0016BA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureUnlockNotify Clone()
		{
			return new FurnitureUnlockNotify(this);
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x0016D85D File Offset: 0x0016BA5D
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x0016D865 File Offset: 0x0016BA65
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

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x0016D86E File Offset: 0x0016BA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FurnitureIds
		{
			get
			{
				return this.furnitureIds_;
			}
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0016D876 File Offset: 0x0016BA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureUnlockNotify);
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0016D884 File Offset: 0x0016BA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.furnitureIds_.Equals(other.furnitureIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0016D8D4 File Offset: 0x0016BAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.furnitureIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0016D921 File Offset: 0x0016BB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x0016D92E File Offset: 0x0016BB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x0016D938 File Offset: 0x0016BB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.furnitureIds_.WriteTo(ref output, FurnitureUnlockNotify._repeated_furnitureIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0016D988 File Offset: 0x0016BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.furnitureIds_.CalculateSize(FurnitureUnlockNotify._repeated_furnitureIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0016D9DC File Offset: 0x0016BBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.furnitureIds_.Add(other.furnitureIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0016DA29 File Offset: 0x0016BC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0016DA34 File Offset: 0x0016BC34
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
				if (num != 96U && num != 98U)
				{
					if (num != 112U)
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
					this.furnitureIds_.AddEntriesFrom(ref input, FurnitureUnlockNotify._repeated_furnitureIds_codec);
				}
			}
		}

		// Token: 0x0400485A RID: 18522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400485B RID: 18523
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400485C RID: 18524
		private int activityId_;

		// Token: 0x0400485D RID: 18525
		public const int FurnitureIdsFieldNumber = 12;

		// Token: 0x0400485E RID: 18526
		private static readonly FieldCodec<int> _repeated_furnitureIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400485F RID: 18527
		private readonly RepeatedField<int> furnitureIds_ = new RepeatedField<int>();
	}
}
