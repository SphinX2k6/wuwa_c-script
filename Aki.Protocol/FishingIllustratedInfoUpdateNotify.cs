using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054C RID: 1356
	[NetMessage(EMessageId.FishingIllustratedInfoUpdateNotify)]
	public sealed class FishingIllustratedInfoUpdateNotify : IMessage<FishingIllustratedInfoUpdateNotify>, IMessage, IEquatable<FishingIllustratedInfoUpdateNotify>, IDeepCloneable<FishingIllustratedInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007EF8 RID: 32504 RVA: 0x00133596 File Offset: 0x00131796
		[NullableContext(1)]
		public static FishingIllustratedInfoUpdateNotify Create()
		{
			return new FishingIllustratedInfoUpdateNotify();
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x0013359D File Offset: 0x0013179D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06007EFA RID: 32506 RVA: 0x001335A0 File Offset: 0x001317A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x001335A7 File Offset: 0x001317A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify()
		{
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x001335BC File Offset: 0x001317BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify(FishingIllustratedInfoUpdateNotify other) : this()
		{
			this.illustratedInfo_ = ((other.illustratedInfo_ != null) ? other.illustratedInfo_.Clone() : null);
			this.unlockDetections_ = other.unlockDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x0013360D File Offset: 0x0013180D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify Clone()
		{
			return new FishingIllustratedInfoUpdateNotify(this);
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06007EFE RID: 32510 RVA: 0x00133615 File Offset: 0x00131815
		// (set) Token: 0x06007EFF RID: 32511 RVA: 0x0013361D File Offset: 0x0013181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo IllustratedInfo
		{
			get
			{
				return this.illustratedInfo_;
			}
			set
			{
				this.illustratedInfo_ = value;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06007F00 RID: 32512 RVA: 0x00133626 File Offset: 0x00131826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockDetections
		{
			get
			{
				return this.unlockDetections_;
			}
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0013362E File Offset: 0x0013182E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedInfoUpdateNotify);
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x0013363C File Offset: 0x0013183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.IllustratedInfo, other.IllustratedInfo) && this.unlockDetections_.Equals(other.unlockDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x00133690 File Offset: 0x00131890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.illustratedInfo_ != null)
			{
				num ^= this.IllustratedInfo.GetHashCode();
			}
			num ^= this.unlockDetections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x001336DA File Offset: 0x001318DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x001336E7 File Offset: 0x001318E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x001336F0 File Offset: 0x001318F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockDetections_.WriteTo(ref output, FishingIllustratedInfoUpdateNotify._repeated_unlockDetections_codec);
			if (this.illustratedInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.IllustratedInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x00133740 File Offset: 0x00131940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.illustratedInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IllustratedInfo);
			}
			num += this.unlockDetections_.CalculateSize(FishingIllustratedInfoUpdateNotify._repeated_unlockDetections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x00133794 File Offset: 0x00131994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.illustratedInfo_ != null)
			{
				if (this.illustratedInfo_ == null)
				{
					this.IllustratedInfo = new OneFishingIllustratedInfo();
				}
				this.IllustratedInfo.MergeFrom(other.IllustratedInfo);
			}
			this.unlockDetections_.Add(other.unlockDetections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x001337F9 File Offset: 0x001319F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x00133804 File Offset: 0x00131A04
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
				if (num != 32U && num != 34U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.illustratedInfo_ == null)
						{
							this.IllustratedInfo = new OneFishingIllustratedInfo();
						}
						input.ReadMessage(this.IllustratedInfo);
					}
				}
				else
				{
					this.unlockDetections_.AddEntriesFrom(ref input, FishingIllustratedInfoUpdateNotify._repeated_unlockDetections_codec);
				}
			}
		}

		// Token: 0x04004096 RID: 16534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004097 RID: 16535
		public const int IllustratedInfoFieldNumber = 12;

		// Token: 0x04004098 RID: 16536
		private OneFishingIllustratedInfo illustratedInfo_;

		// Token: 0x04004099 RID: 16537
		public const int UnlockDetectionsFieldNumber = 4;

		// Token: 0x0400409A RID: 16538
		private static readonly FieldCodec<int> _repeated_unlockDetections_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400409B RID: 16539
		private readonly RepeatedField<int> unlockDetections_ = new RepeatedField<int>();
	}
}
