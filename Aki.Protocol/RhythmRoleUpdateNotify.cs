using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F35 RID: 3893
	[NetMessage(EMessageId.RhythmRoleUpdateNotify)]
	public sealed class RhythmRoleUpdateNotify : IMessage<RhythmRoleUpdateNotify>, IMessage, IEquatable<RhythmRoleUpdateNotify>, IDeepCloneable<RhythmRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014DBE RID: 85438 RVA: 0x00307629 File Offset: 0x00305829
		[NullableContext(1)]
		public static RhythmRoleUpdateNotify Create()
		{
			return new RhythmRoleUpdateNotify();
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x06014DBF RID: 85439 RVA: 0x00307630 File Offset: 0x00305830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x06014DC0 RID: 85440 RVA: 0x00307633 File Offset: 0x00305833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014DC1 RID: 85441 RVA: 0x0030763A File Offset: 0x0030583A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify()
		{
		}

		// Token: 0x06014DC2 RID: 85442 RVA: 0x0030764D File Offset: 0x0030584D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify(RhythmRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DC3 RID: 85443 RVA: 0x00307683 File Offset: 0x00305883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify Clone()
		{
			return new RhythmRoleUpdateNotify(this);
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x06014DC4 RID: 85444 RVA: 0x0030768B File Offset: 0x0030588B
		// (set) Token: 0x06014DC5 RID: 85445 RVA: 0x00307693 File Offset: 0x00305893
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

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x06014DC6 RID: 85446 RVA: 0x0030769C File Offset: 0x0030589C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x06014DC7 RID: 85447 RVA: 0x003076A4 File Offset: 0x003058A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRoleUpdateNotify);
		}

		// Token: 0x06014DC8 RID: 85448 RVA: 0x003076B4 File Offset: 0x003058B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DC9 RID: 85449 RVA: 0x00307704 File Offset: 0x00305904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.unlockedRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DCA RID: 85450 RVA: 0x00307751 File Offset: 0x00305951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DCB RID: 85451 RVA: 0x0030775E File Offset: 0x0030595E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DCC RID: 85452 RVA: 0x00307768 File Offset: 0x00305968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.unlockedRole_.WriteTo(ref output, RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DCD RID: 85453 RVA: 0x003077B8 File Offset: 0x003059B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.unlockedRole_.CalculateSize(RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DCE RID: 85454 RVA: 0x0030780C File Offset: 0x00305A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.unlockedRole_.Add(other.unlockedRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DCF RID: 85455 RVA: 0x00307859 File Offset: 0x00305A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DD0 RID: 85456 RVA: 0x00307864 File Offset: 0x00305A64
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
				if (num != 16U)
				{
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockedRole_.AddEntriesFrom(ref input, RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E4E RID: 32334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E4F RID: 32335
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04007E50 RID: 32336
		private int activityId_;

		// Token: 0x04007E51 RID: 32337
		public const int UnlockedRoleFieldNumber = 4;

		// Token: 0x04007E52 RID: 32338
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E53 RID: 32339
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
