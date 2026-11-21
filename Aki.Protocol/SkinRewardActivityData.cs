using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127F RID: 4735
	public sealed class SkinRewardActivityData : IMessage<SkinRewardActivityData>, IMessage, IEquatable<SkinRewardActivityData>, IDeepCloneable<SkinRewardActivityData>, IBufferMessage
	{
		// Token: 0x0601947B RID: 103547 RVA: 0x003B015F File Offset: 0x003AE35F
		[NullableContext(1)]
		public static SkinRewardActivityData Create()
		{
			return new SkinRewardActivityData();
		}

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x0601947C RID: 103548 RVA: 0x003B0166 File Offset: 0x003AE366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x0601947D RID: 103549 RVA: 0x003B0169 File Offset: 0x003AE369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardActivityData.Descriptor;
			}
		}

		// Token: 0x0601947E RID: 103550 RVA: 0x003B0170 File Offset: 0x003AE370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData()
		{
		}

		// Token: 0x0601947F RID: 103551 RVA: 0x003B0183 File Offset: 0x003AE383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData(SkinRewardActivityData other) : this()
		{
			this.rewardInfos_ = other.rewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019480 RID: 103552 RVA: 0x003B01AD File Offset: 0x003AE3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData Clone()
		{
			return new SkinRewardActivityData(this);
		}

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x06019481 RID: 103553 RVA: 0x003B01B5 File Offset: 0x003AE3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkinRewardActivityRewardInfo> RewardInfos
		{
			get
			{
				return this.rewardInfos_;
			}
		}

		// Token: 0x06019482 RID: 103554 RVA: 0x003B01BD File Offset: 0x003AE3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardActivityData);
		}

		// Token: 0x06019483 RID: 103555 RVA: 0x003B01CB File Offset: 0x003AE3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardActivityData other)
		{
			return other != null && (other == this || (this.rewardInfos_.Equals(other.rewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019484 RID: 103556 RVA: 0x003B0200 File Offset: 0x003AE400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019485 RID: 103557 RVA: 0x003B0234 File Offset: 0x003AE434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019486 RID: 103558 RVA: 0x003B0241 File Offset: 0x003AE441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019487 RID: 103559 RVA: 0x003B024A File Offset: 0x003AE44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardInfos_.WriteTo(ref output, SkinRewardActivityData._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019488 RID: 103560 RVA: 0x003B0274 File Offset: 0x003AE474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardInfos_.CalculateSize(SkinRewardActivityData._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019489 RID: 103561 RVA: 0x003B02AD File Offset: 0x003AE4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardInfos_.Add(other.rewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601948A RID: 103562 RVA: 0x003B02DB File Offset: 0x003AE4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601948B RID: 103563 RVA: 0x003B02E4 File Offset: 0x003AE4E4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardInfos_.AddEntriesFrom(ref input, SkinRewardActivityData._repeated_rewardInfos_codec);
				}
			}
		}

		// Token: 0x0400959E RID: 38302
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400959F RID: 38303
		public const int RewardInfosFieldNumber = 1;

		// Token: 0x040095A0 RID: 38304
		private static readonly FieldCodec<SkinRewardActivityRewardInfo> _repeated_rewardInfos_codec = FieldCodec.ForMessage<SkinRewardActivityRewardInfo>(10U, SkinRewardActivityRewardInfo.Parser);

		// Token: 0x040095A1 RID: 38305
		private readonly RepeatedField<SkinRewardActivityRewardInfo> rewardInfos_ = new RepeatedField<SkinRewardActivityRewardInfo>();
	}
}
