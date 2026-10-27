using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000561 RID: 1377
	[NetMessage(EMessageId.FishingIllustratedInfoUpdateNotify)]
	public sealed class FishingIllustratedInfoUpdateNotify : IMessage<FishingIllustratedInfoUpdateNotify>, IMessage, IEquatable<FishingIllustratedInfoUpdateNotify>, IDeepCloneable<FishingIllustratedInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008060 RID: 32864 RVA: 0x00136196 File Offset: 0x00134396
		[NullableContext(1)]
		public static FishingIllustratedInfoUpdateNotify Create()
		{
			return new FishingIllustratedInfoUpdateNotify();
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06008061 RID: 32865 RVA: 0x0013619D File Offset: 0x0013439D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x001361A0 File Offset: 0x001343A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x001361A7 File Offset: 0x001343A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify()
		{
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x001361BC File Offset: 0x001343BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify(FishingIllustratedInfoUpdateNotify other) : this()
		{
			this.illustratedInfo_ = ((other.illustratedInfo_ != null) ? other.illustratedInfo_.Clone() : null);
			this.unlockDetections_ = other.unlockDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x0013620D File Offset: 0x0013440D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfoUpdateNotify Clone()
		{
			return new FishingIllustratedInfoUpdateNotify(this);
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x00136215 File Offset: 0x00134415
		// (set) Token: 0x06008067 RID: 32871 RVA: 0x0013621D File Offset: 0x0013441D
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

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06008068 RID: 32872 RVA: 0x00136226 File Offset: 0x00134426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockDetections
		{
			get
			{
				return this.unlockDetections_;
			}
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x0013622E File Offset: 0x0013442E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedInfoUpdateNotify);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0013623C File Offset: 0x0013443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.IllustratedInfo, other.IllustratedInfo) && this.unlockDetections_.Equals(other.unlockDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x00136290 File Offset: 0x00134490
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

		// Token: 0x0600806C RID: 32876 RVA: 0x001362DA File Offset: 0x001344DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x001362E7 File Offset: 0x001344E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x001362F0 File Offset: 0x001344F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.illustratedInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.IllustratedInfo);
			}
			this.unlockDetections_.WriteTo(ref output, FishingIllustratedInfoUpdateNotify._repeated_unlockDetections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x00136340 File Offset: 0x00134540
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

		// Token: 0x06008070 RID: 32880 RVA: 0x00136394 File Offset: 0x00134594
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

		// Token: 0x06008071 RID: 32881 RVA: 0x001363F9 File Offset: 0x001345F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x00136404 File Offset: 0x00134604
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
				if (num != 58U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockDetections_.AddEntriesFrom(ref input, FishingIllustratedInfoUpdateNotify._repeated_unlockDetections_codec);
					}
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
		}

		// Token: 0x040040A0 RID: 16544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040A1 RID: 16545
		public const int IllustratedInfoFieldNumber = 7;

		// Token: 0x040040A2 RID: 16546
		private OneFishingIllustratedInfo illustratedInfo_;

		// Token: 0x040040A3 RID: 16547
		public const int UnlockDetectionsFieldNumber = 12;

		// Token: 0x040040A4 RID: 16548
		private static readonly FieldCodec<int> _repeated_unlockDetections_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040040A5 RID: 16549
		private readonly RepeatedField<int> unlockDetections_ = new RepeatedField<int>();
	}
}
