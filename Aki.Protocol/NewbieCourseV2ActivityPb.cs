using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFA RID: 2810
	public sealed class NewbieCourseV2ActivityPb : IMessage<NewbieCourseV2ActivityPb>, IMessage, IEquatable<NewbieCourseV2ActivityPb>, IDeepCloneable<NewbieCourseV2ActivityPb>, IBufferMessage
	{
		// Token: 0x0600F47E RID: 62590 RVA: 0x0023B231 File Offset: 0x00239431
		[NullableContext(1)]
		public static NewbieCourseV2ActivityPb Create()
		{
			return new NewbieCourseV2ActivityPb();
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600F47F RID: 62591 RVA: 0x0023B238 File Offset: 0x00239438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600F480 RID: 62592 RVA: 0x0023B23B File Offset: 0x0023943B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2ActivityPb.Descriptor;
			}
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x0023B242 File Offset: 0x00239442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb()
		{
		}

		// Token: 0x0600F482 RID: 62594 RVA: 0x0023B255 File Offset: 0x00239455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb(NewbieCourseV2ActivityPb other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this.beginOpenTime_ = other.beginOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x0023B28B File Offset: 0x0023948B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2ActivityPb Clone()
		{
			return new NewbieCourseV2ActivityPb(this);
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600F484 RID: 62596 RVA: 0x0023B293 File Offset: 0x00239493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600F485 RID: 62597 RVA: 0x0023B29B File Offset: 0x0023949B
		// (set) Token: 0x0600F486 RID: 62598 RVA: 0x0023B2A3 File Offset: 0x002394A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x0600F487 RID: 62599 RVA: 0x0023B2AC File Offset: 0x002394AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2ActivityPb);
		}

		// Token: 0x0600F488 RID: 62600 RVA: 0x0023B2BC File Offset: 0x002394BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2ActivityPb other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && this.BeginOpenTime == other.BeginOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F489 RID: 62601 RVA: 0x0023B30C File Offset: 0x0023950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hadTakeReward_.GetHashCode();
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F48A RID: 62602 RVA: 0x0023B359 File Offset: 0x00239559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F48B RID: 62603 RVA: 0x0023B366 File Offset: 0x00239566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F48C RID: 62604 RVA: 0x0023B370 File Offset: 0x00239570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hadTakeReward_.WriteTo(ref output, NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F48D RID: 62605 RVA: 0x0023B3C0 File Offset: 0x002395C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hadTakeReward_.CalculateSize(NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F48E RID: 62606 RVA: 0x0023B414 File Offset: 0x00239614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2ActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F48F RID: 62607 RVA: 0x0023B461 File Offset: 0x00239661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F490 RID: 62608 RVA: 0x0023B46C File Offset: 0x0023966C
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
				if (num != 8U && num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BeginOpenTime = input.ReadInt64();
					}
				}
				else
				{
					this.hadTakeReward_.AddEntriesFrom(ref input, NewbieCourseV2ActivityPb._repeated_hadTakeReward_codec);
				}
			}
		}

		// Token: 0x040062C3 RID: 25283
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062C4 RID: 25284
		public const int HadTakeRewardFieldNumber = 1;

		// Token: 0x040062C5 RID: 25285
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040062C6 RID: 25286
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();

		// Token: 0x040062C7 RID: 25287
		public const int BeginOpenTimeFieldNumber = 2;

		// Token: 0x040062C8 RID: 25288
		private long beginOpenTime_;
	}
}
