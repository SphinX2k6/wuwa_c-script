using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157B RID: 5499
	public sealed class WeekCardInfo : IMessage<WeekCardInfo>, IMessage, IEquatable<WeekCardInfo>, IDeepCloneable<WeekCardInfo>, IBufferMessage
	{
		// Token: 0x0601D1D6 RID: 119254 RVA: 0x00437471 File Offset: 0x00435671
		[NullableContext(1)]
		public static WeekCardInfo Create()
		{
			return new WeekCardInfo();
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x0601D1D7 RID: 119255 RVA: 0x00437478 File Offset: 0x00435678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeekCardInfo> Parser
		{
			get
			{
				return WeekCardInfo._parser;
			}
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x0601D1D8 RID: 119256 RVA: 0x0043747F File Offset: 0x0043567F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006282 RID: 25218
		// (get) Token: 0x0601D1D9 RID: 119257 RVA: 0x00437482 File Offset: 0x00435682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfo.Descriptor;
			}
		}

		// Token: 0x0601D1DA RID: 119258 RVA: 0x00437489 File Offset: 0x00435689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo()
		{
		}

		// Token: 0x0601D1DB RID: 119259 RVA: 0x0043749C File Offset: 0x0043569C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo(WeekCardInfo other) : this()
		{
			this.weekCardId_ = other.weekCardId_;
			this.days_ = other.days_;
			this.buyTimeStamp_ = other.buyTimeStamp_;
			this.endTimeStamp_ = other.endTimeStamp_;
			this.weekCardContentInfos_ = other.weekCardContentInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1DC RID: 119260 RVA: 0x00437501 File Offset: 0x00435701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo Clone()
		{
			return new WeekCardInfo(this);
		}

		// Token: 0x17006283 RID: 25219
		// (get) Token: 0x0601D1DD RID: 119261 RVA: 0x00437509 File Offset: 0x00435709
		// (set) Token: 0x0601D1DE RID: 119262 RVA: 0x00437511 File Offset: 0x00435711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardId
		{
			get
			{
				return this.weekCardId_;
			}
			set
			{
				this.weekCardId_ = value;
			}
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x0601D1DF RID: 119263 RVA: 0x0043751A File Offset: 0x0043571A
		// (set) Token: 0x0601D1E0 RID: 119264 RVA: 0x00437522 File Offset: 0x00435722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Days
		{
			get
			{
				return this.days_;
			}
			set
			{
				this.days_ = value;
			}
		}

		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x0601D1E1 RID: 119265 RVA: 0x0043752B File Offset: 0x0043572B
		// (set) Token: 0x0601D1E2 RID: 119266 RVA: 0x00437533 File Offset: 0x00435733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuyTimeStamp
		{
			get
			{
				return this.buyTimeStamp_;
			}
			set
			{
				this.buyTimeStamp_ = value;
			}
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x0601D1E3 RID: 119267 RVA: 0x0043753C File Offset: 0x0043573C
		// (set) Token: 0x0601D1E4 RID: 119268 RVA: 0x00437544 File Offset: 0x00435744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTimeStamp
		{
			get
			{
				return this.endTimeStamp_;
			}
			set
			{
				this.endTimeStamp_ = value;
			}
		}

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x0601D1E5 RID: 119269 RVA: 0x0043754D File Offset: 0x0043574D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardContentInfo> WeekCardContentInfos
		{
			get
			{
				return this.weekCardContentInfos_;
			}
		}

		// Token: 0x0601D1E6 RID: 119270 RVA: 0x00437555 File Offset: 0x00435755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfo);
		}

		// Token: 0x0601D1E7 RID: 119271 RVA: 0x00437564 File Offset: 0x00435764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfo other)
		{
			return other != null && (other == this || (this.WeekCardId == other.WeekCardId && this.Days == other.Days && this.BuyTimeStamp == other.BuyTimeStamp && this.EndTimeStamp == other.EndTimeStamp && this.weekCardContentInfos_.Equals(other.weekCardContentInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1E8 RID: 119272 RVA: 0x004375E4 File Offset: 0x004357E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardId != 0)
			{
				num ^= this.WeekCardId.GetHashCode();
			}
			if (this.Days != 0)
			{
				num ^= this.Days.GetHashCode();
			}
			if (this.BuyTimeStamp != 0L)
			{
				num ^= this.BuyTimeStamp.GetHashCode();
			}
			if (this.EndTimeStamp != 0L)
			{
				num ^= this.EndTimeStamp.GetHashCode();
			}
			num ^= this.weekCardContentInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D1E9 RID: 119273 RVA: 0x0043767C File Offset: 0x0043587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1EA RID: 119274 RVA: 0x00437689 File Offset: 0x00435889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1EB RID: 119275 RVA: 0x00437694 File Offset: 0x00435894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeekCardId);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Days);
			}
			if (this.BuyTimeStamp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BuyTimeStamp);
			}
			if (this.EndTimeStamp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EndTimeStamp);
			}
			this.weekCardContentInfos_.WriteTo(ref output, WeekCardInfo._repeated_weekCardContentInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1EC RID: 119276 RVA: 0x00437738 File Offset: 0x00435938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardId);
			}
			if (this.Days != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Days);
			}
			if (this.BuyTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuyTimeStamp);
			}
			if (this.EndTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTimeStamp);
			}
			num += this.weekCardContentInfos_.CalculateSize(WeekCardInfo._repeated_weekCardContentInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D1ED RID: 119277 RVA: 0x004377D4 File Offset: 0x004359D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardId != 0)
			{
				this.WeekCardId = other.WeekCardId;
			}
			if (other.Days != 0)
			{
				this.Days = other.Days;
			}
			if (other.BuyTimeStamp != 0L)
			{
				this.BuyTimeStamp = other.BuyTimeStamp;
			}
			if (other.EndTimeStamp != 0L)
			{
				this.EndTimeStamp = other.EndTimeStamp;
			}
			this.weekCardContentInfos_.Add(other.weekCardContentInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x0043785D File Offset: 0x00435A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1EF RID: 119279 RVA: 0x00437868 File Offset: 0x00435A68
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.WeekCardId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Days = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BuyTimeStamp = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.EndTimeStamp = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.weekCardContentInfos_.AddEntriesFrom(ref input, WeekCardInfo._repeated_weekCardContentInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A728 RID: 42792
		private static readonly MessageParser<WeekCardInfo> _parser = new MessageParser<WeekCardInfo>(() => new WeekCardInfo());

		// Token: 0x0400A729 RID: 42793
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A72A RID: 42794
		public const int WeekCardIdFieldNumber = 1;

		// Token: 0x0400A72B RID: 42795
		private int weekCardId_;

		// Token: 0x0400A72C RID: 42796
		public const int DaysFieldNumber = 2;

		// Token: 0x0400A72D RID: 42797
		private int days_;

		// Token: 0x0400A72E RID: 42798
		public const int BuyTimeStampFieldNumber = 3;

		// Token: 0x0400A72F RID: 42799
		private long buyTimeStamp_;

		// Token: 0x0400A730 RID: 42800
		public const int EndTimeStampFieldNumber = 4;

		// Token: 0x0400A731 RID: 42801
		private long endTimeStamp_;

		// Token: 0x0400A732 RID: 42802
		public const int WeekCardContentInfosFieldNumber = 5;

		// Token: 0x0400A733 RID: 42803
		private static readonly FieldCodec<WeekCardContentInfo> _repeated_weekCardContentInfos_codec = FieldCodec.ForMessage<WeekCardContentInfo>(42U, WeekCardContentInfo.Parser);

		// Token: 0x0400A734 RID: 42804
		private readonly RepeatedField<WeekCardContentInfo> weekCardContentInfos_ = new RepeatedField<WeekCardContentInfo>();
	}
}
