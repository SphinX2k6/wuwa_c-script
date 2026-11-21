using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B02 RID: 2818
	[NetMessage(EMessageId.NewbieMainTaskUpdateNotify)]
	public sealed class NewbieMainTaskUpdateNotify : IMessage<NewbieMainTaskUpdateNotify>, IMessage, IEquatable<NewbieMainTaskUpdateNotify>, IDeepCloneable<NewbieMainTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F51C RID: 62748 RVA: 0x0023C6C5 File Offset: 0x0023A8C5
		[NullableContext(1)]
		public static NewbieMainTaskUpdateNotify Create()
		{
			return new NewbieMainTaskUpdateNotify();
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600F51D RID: 62749 RVA: 0x0023C6CC File Offset: 0x0023A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600F51E RID: 62750 RVA: 0x0023C6CF File Offset: 0x0023A8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F51F RID: 62751 RVA: 0x0023C6D6 File Offset: 0x0023A8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify()
		{
		}

		// Token: 0x0600F520 RID: 62752 RVA: 0x0023C6EC File Offset: 0x0023A8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify(NewbieMainTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.newbieMainTabs_ = other.newbieMainTabs_.Clone();
			this.progressScore_ = other.progressScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F521 RID: 62753 RVA: 0x0023C739 File Offset: 0x0023A939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify Clone()
		{
			return new NewbieMainTaskUpdateNotify(this);
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600F522 RID: 62754 RVA: 0x0023C741 File Offset: 0x0023A941
		// (set) Token: 0x0600F523 RID: 62755 RVA: 0x0023C749 File Offset: 0x0023A949
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

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600F524 RID: 62756 RVA: 0x0023C752 File Offset: 0x0023A952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieMainTabPb> NewbieMainTabs
		{
			get
			{
				return this.newbieMainTabs_;
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600F525 RID: 62757 RVA: 0x0023C75A File Offset: 0x0023A95A
		// (set) Token: 0x0600F526 RID: 62758 RVA: 0x0023C762 File Offset: 0x0023A962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ProgressScore
		{
			get
			{
				return this.progressScore_;
			}
			set
			{
				this.progressScore_ = value;
			}
		}

		// Token: 0x0600F527 RID: 62759 RVA: 0x0023C76B File Offset: 0x0023A96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainTaskUpdateNotify);
		}

		// Token: 0x0600F528 RID: 62760 RVA: 0x0023C77C File Offset: 0x0023A97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.newbieMainTabs_.Equals(other.newbieMainTabs_) && this.ProgressScore == other.ProgressScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F529 RID: 62761 RVA: 0x0023C7DC File Offset: 0x0023A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.newbieMainTabs_.GetHashCode();
			if (this.ProgressScore != 0)
			{
				num ^= this.ProgressScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F52A RID: 62762 RVA: 0x0023C842 File Offset: 0x0023AA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F52B RID: 62763 RVA: 0x0023C84F File Offset: 0x0023AA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F52C RID: 62764 RVA: 0x0023C858 File Offset: 0x0023AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ProgressScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ProgressScore);
			}
			this.newbieMainTabs_.WriteTo(ref output, NewbieMainTaskUpdateNotify._repeated_newbieMainTabs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F52D RID: 62765 RVA: 0x0023C8C4 File Offset: 0x0023AAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.newbieMainTabs_.CalculateSize(NewbieMainTaskUpdateNotify._repeated_newbieMainTabs_codec);
			if (this.ProgressScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F52E RID: 62766 RVA: 0x0023C930 File Offset: 0x0023AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieMainTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.newbieMainTabs_.Add(other.newbieMainTabs_);
			if (other.ProgressScore != 0)
			{
				this.ProgressScore = other.ProgressScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F52F RID: 62767 RVA: 0x0023C991 File Offset: 0x0023AB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F530 RID: 62768 RVA: 0x0023C99C File Offset: 0x0023AB9C
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
					if (num != 64U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.newbieMainTabs_.AddEntriesFrom(ref input, NewbieMainTaskUpdateNotify._repeated_newbieMainTabs_codec);
						}
					}
					else
					{
						this.ProgressScore = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062F1 RID: 25329
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062F2 RID: 25330
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x040062F3 RID: 25331
		private int activityId_;

		// Token: 0x040062F4 RID: 25332
		public const int NewbieMainTabsFieldNumber = 15;

		// Token: 0x040062F5 RID: 25333
		private static readonly FieldCodec<NewbieMainTabPb> _repeated_newbieMainTabs_codec = FieldCodec.ForMessage<NewbieMainTabPb>(122U, NewbieMainTabPb.Parser);

		// Token: 0x040062F6 RID: 25334
		private readonly RepeatedField<NewbieMainTabPb> newbieMainTabs_ = new RepeatedField<NewbieMainTabPb>();

		// Token: 0x040062F7 RID: 25335
		public const int ProgressScoreFieldNumber = 8;

		// Token: 0x040062F8 RID: 25336
		private int progressScore_;
	}
}
