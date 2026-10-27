using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001358 RID: 4952
	public sealed class ThemeCelebration : IMessage<ThemeCelebration>, IMessage, IEquatable<ThemeCelebration>, IDeepCloneable<ThemeCelebration>, IBufferMessage
	{
		// Token: 0x0601A4F5 RID: 107765 RVA: 0x003D2885 File Offset: 0x003D0A85
		[NullableContext(1)]
		public static ThemeCelebration Create()
		{
			return new ThemeCelebration();
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x0601A4F6 RID: 107766 RVA: 0x003D288C File Offset: 0x003D0A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058C8 RID: 22728
		// (get) Token: 0x0601A4F7 RID: 107767 RVA: 0x003D288F File Offset: 0x003D0A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeCelebration.Descriptor;
			}
		}

		// Token: 0x0601A4F8 RID: 107768 RVA: 0x003D2896 File Offset: 0x003D0A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration()
		{
		}

		// Token: 0x0601A4F9 RID: 107769 RVA: 0x003D28C0 File Offset: 0x003D0AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration(ThemeCelebration other) : this()
		{
			this.personalRewardIds_ = other.personalRewardIds_.Clone();
			this.worldRewardIds_ = other.worldRewardIds_.Clone();
			this.subActivityTimes_ = other.subActivityTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4FA RID: 107770 RVA: 0x003D2917 File Offset: 0x003D0B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCelebration Clone()
		{
			return new ThemeCelebration(this);
		}

		// Token: 0x170058C9 RID: 22729
		// (get) Token: 0x0601A4FB RID: 107771 RVA: 0x003D291F File Offset: 0x003D0B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PersonalRewardIds
		{
			get
			{
				return this.personalRewardIds_;
			}
		}

		// Token: 0x170058CA RID: 22730
		// (get) Token: 0x0601A4FC RID: 107772 RVA: 0x003D2927 File Offset: 0x003D0B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WorldRewardIds
		{
			get
			{
				return this.worldRewardIds_;
			}
		}

		// Token: 0x170058CB RID: 22731
		// (get) Token: 0x0601A4FD RID: 107773 RVA: 0x003D292F File Offset: 0x003D0B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SubActivityBeginTime> SubActivityTimes
		{
			get
			{
				return this.subActivityTimes_;
			}
		}

		// Token: 0x0601A4FE RID: 107774 RVA: 0x003D2937 File Offset: 0x003D0B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeCelebration);
		}

		// Token: 0x0601A4FF RID: 107775 RVA: 0x003D2948 File Offset: 0x003D0B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeCelebration other)
		{
			return other != null && (other == this || (this.personalRewardIds_.Equals(other.personalRewardIds_) && this.worldRewardIds_.Equals(other.worldRewardIds_) && this.subActivityTimes_.Equals(other.subActivityTimes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A500 RID: 107776 RVA: 0x003D29B0 File Offset: 0x003D0BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.personalRewardIds_.GetHashCode();
			num ^= this.worldRewardIds_.GetHashCode();
			num ^= this.subActivityTimes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A501 RID: 107777 RVA: 0x003D2A00 File Offset: 0x003D0C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A502 RID: 107778 RVA: 0x003D2A0D File Offset: 0x003D0C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A503 RID: 107779 RVA: 0x003D2A18 File Offset: 0x003D0C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.personalRewardIds_.WriteTo(ref output, ThemeCelebration._repeated_personalRewardIds_codec);
			this.worldRewardIds_.WriteTo(ref output, ThemeCelebration._repeated_worldRewardIds_codec);
			this.subActivityTimes_.WriteTo(ref output, ThemeCelebration._repeated_subActivityTimes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A504 RID: 107780 RVA: 0x003D2A6C File Offset: 0x003D0C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.personalRewardIds_.CalculateSize(ThemeCelebration._repeated_personalRewardIds_codec);
			num += this.worldRewardIds_.CalculateSize(ThemeCelebration._repeated_worldRewardIds_codec);
			num += this.subActivityTimes_.CalculateSize(ThemeCelebration._repeated_subActivityTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A505 RID: 107781 RVA: 0x003D2ACC File Offset: 0x003D0CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeCelebration other)
		{
			if (other == null)
			{
				return;
			}
			this.personalRewardIds_.Add(other.personalRewardIds_);
			this.worldRewardIds_.Add(other.worldRewardIds_);
			this.subActivityTimes_.Add(other.subActivityTimes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A506 RID: 107782 RVA: 0x003D2B27 File Offset: 0x003D0D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A507 RID: 107783 RVA: 0x003D2B30 File Offset: 0x003D0D30
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.personalRewardIds_.AddEntriesFrom(ref input, ThemeCelebration._repeated_personalRewardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U || num == 18U)
					{
						this.worldRewardIds_.AddEntriesFrom(ref input, ThemeCelebration._repeated_worldRewardIds_codec);
						continue;
					}
					if (num == 26U)
					{
						this.subActivityTimes_.AddEntriesFrom(ref input, ThemeCelebration._repeated_subActivityTimes_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400996A RID: 39274
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400996B RID: 39275
		public const int PersonalRewardIdsFieldNumber = 1;

		// Token: 0x0400996C RID: 39276
		private static readonly FieldCodec<int> _repeated_personalRewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400996D RID: 39277
		private readonly RepeatedField<int> personalRewardIds_ = new RepeatedField<int>();

		// Token: 0x0400996E RID: 39278
		public const int WorldRewardIdsFieldNumber = 2;

		// Token: 0x0400996F RID: 39279
		private static readonly FieldCodec<int> _repeated_worldRewardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009970 RID: 39280
		private readonly RepeatedField<int> worldRewardIds_ = new RepeatedField<int>();

		// Token: 0x04009971 RID: 39281
		public const int SubActivityTimesFieldNumber = 3;

		// Token: 0x04009972 RID: 39282
		private static readonly FieldCodec<SubActivityBeginTime> _repeated_subActivityTimes_codec = FieldCodec.ForMessage<SubActivityBeginTime>(26U, SubActivityBeginTime.Parser);

		// Token: 0x04009973 RID: 39283
		private readonly RepeatedField<SubActivityBeginTime> subActivityTimes_ = new RepeatedField<SubActivityBeginTime>();
	}
}
