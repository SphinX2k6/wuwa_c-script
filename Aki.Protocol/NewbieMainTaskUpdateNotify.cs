using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B13 RID: 2835
	[NetMessage(EMessageId.NewbieMainTaskUpdateNotify)]
	public sealed class NewbieMainTaskUpdateNotify : IMessage<NewbieMainTaskUpdateNotify>, IMessage, IEquatable<NewbieMainTaskUpdateNotify>, IDeepCloneable<NewbieMainTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F636 RID: 63030 RVA: 0x0023E8D1 File Offset: 0x0023CAD1
		[NullableContext(1)]
		public static NewbieMainTaskUpdateNotify Create()
		{
			return new NewbieMainTaskUpdateNotify();
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600F637 RID: 63031 RVA: 0x0023E8D8 File Offset: 0x0023CAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600F638 RID: 63032 RVA: 0x0023E8DB File Offset: 0x0023CADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F639 RID: 63033 RVA: 0x0023E8E2 File Offset: 0x0023CAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify()
		{
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x0023E8F8 File Offset: 0x0023CAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify(NewbieMainTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.newbieMainTabs_ = other.newbieMainTabs_.Clone();
			this.progressScore_ = other.progressScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x0023E945 File Offset: 0x0023CB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTaskUpdateNotify Clone()
		{
			return new NewbieMainTaskUpdateNotify(this);
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600F63C RID: 63036 RVA: 0x0023E94D File Offset: 0x0023CB4D
		// (set) Token: 0x0600F63D RID: 63037 RVA: 0x0023E955 File Offset: 0x0023CB55
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

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600F63E RID: 63038 RVA: 0x0023E95E File Offset: 0x0023CB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieMainTabPb> NewbieMainTabs
		{
			get
			{
				return this.newbieMainTabs_;
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600F63F RID: 63039 RVA: 0x0023E966 File Offset: 0x0023CB66
		// (set) Token: 0x0600F640 RID: 63040 RVA: 0x0023E96E File Offset: 0x0023CB6E
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

		// Token: 0x0600F641 RID: 63041 RVA: 0x0023E977 File Offset: 0x0023CB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainTaskUpdateNotify);
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x0023E988 File Offset: 0x0023CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.newbieMainTabs_.Equals(other.newbieMainTabs_) && this.ProgressScore == other.ProgressScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F643 RID: 63043 RVA: 0x0023E9E8 File Offset: 0x0023CBE8
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

		// Token: 0x0600F644 RID: 63044 RVA: 0x0023EA4E File Offset: 0x0023CC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x0023EA5B File Offset: 0x0023CC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F646 RID: 63046 RVA: 0x0023EA64 File Offset: 0x0023CC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ProgressScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ProgressScore);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.newbieMainTabs_.WriteTo(ref output, NewbieMainTaskUpdateNotify._repeated_newbieMainTabs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x0023EAD0 File Offset: 0x0023CCD0
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

		// Token: 0x0600F648 RID: 63048 RVA: 0x0023EB3C File Offset: 0x0023CD3C
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

		// Token: 0x0600F649 RID: 63049 RVA: 0x0023EB9D File Offset: 0x0023CD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F64A RID: 63050 RVA: 0x0023EBA8 File Offset: 0x0023CDA8
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
				if (num != 32U)
				{
					if (num != 64U)
					{
						if (num != 106U)
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
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ProgressScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062E8 RID: 25320
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062E9 RID: 25321
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x040062EA RID: 25322
		private int activityId_;

		// Token: 0x040062EB RID: 25323
		public const int NewbieMainTabsFieldNumber = 13;

		// Token: 0x040062EC RID: 25324
		private static readonly FieldCodec<NewbieMainTabPb> _repeated_newbieMainTabs_codec = FieldCodec.ForMessage<NewbieMainTabPb>(106U, NewbieMainTabPb.Parser);

		// Token: 0x040062ED RID: 25325
		private readonly RepeatedField<NewbieMainTabPb> newbieMainTabs_ = new RepeatedField<NewbieMainTabPb>();

		// Token: 0x040062EE RID: 25326
		public const int ProgressScoreFieldNumber = 4;

		// Token: 0x040062EF RID: 25327
		private int progressScore_;
	}
}
