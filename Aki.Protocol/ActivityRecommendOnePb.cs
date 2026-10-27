using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008F RID: 143
	public sealed class ActivityRecommendOnePb : IMessage<ActivityRecommendOnePb>, IMessage, IEquatable<ActivityRecommendOnePb>, IDeepCloneable<ActivityRecommendOnePb>, IBufferMessage
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		[NullableContext(1)]
		public static ActivityRecommendOnePb Create()
		{
			return new ActivityRecommendOnePb();
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0004BAFF File Offset: 0x00049CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityRecommendOnePb> Parser
		{
			get
			{
				return ActivityRecommendOnePb._parser;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0004BB06 File Offset: 0x00049D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0004BB09 File Offset: 0x00049D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRecommendOnePb.Descriptor;
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0004BB10 File Offset: 0x00049D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb()
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0004BB18 File Offset: 0x00049D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb(ActivityRecommendOnePb other) : this()
		{
			this.activityId_ = other.activityId_;
			this.beginShowTime_ = other.beginShowTime_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0004BB55 File Offset: 0x00049D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb Clone()
		{
			return new ActivityRecommendOnePb(this);
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0004BB5D File Offset: 0x00049D5D
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0004BB65 File Offset: 0x00049D65
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0004BB6E File Offset: 0x00049D6E
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0004BB76 File Offset: 0x00049D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginShowTime
		{
			get
			{
				return this.beginShowTime_;
			}
			set
			{
				this.beginShowTime_ = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0004BB7F File Offset: 0x00049D7F
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0004BB87 File Offset: 0x00049D87
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

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004BB90 File Offset: 0x00049D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRecommendOnePb);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0004BBA0 File Offset: 0x00049DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRecommendOnePb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BeginShowTime == other.BeginShowTime && this.BeginOpenTime == other.BeginOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0004BBFC File Offset: 0x00049DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BeginShowTime != 0L)
			{
				num ^= this.BeginShowTime.GetHashCode();
			}
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

		// Token: 0x06001AFA RID: 6906 RVA: 0x0004BC6D File Offset: 0x00049E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0004BC7A File Offset: 0x00049E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0004BC84 File Offset: 0x00049E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BeginShowTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginShowTime);
			}
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BeginShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginShowTime);
			}
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

		// Token: 0x06001AFE RID: 6910 RVA: 0x0004BD68 File Offset: 0x00049F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityRecommendOnePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BeginShowTime != 0L)
			{
				this.BeginShowTime = other.BeginShowTime;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0004BDCC File Offset: 0x00049FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0004BDD8 File Offset: 0x00049FD8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
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
						this.BeginShowTime = input.ReadInt64();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002274 RID: 8820
		private static readonly MessageParser<ActivityRecommendOnePb> _parser = new MessageParser<ActivityRecommendOnePb>(() => new ActivityRecommendOnePb());

		// Token: 0x04002275 RID: 8821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002276 RID: 8822
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04002277 RID: 8823
		private int activityId_;

		// Token: 0x04002278 RID: 8824
		public const int BeginShowTimeFieldNumber = 2;

		// Token: 0x04002279 RID: 8825
		private long beginShowTime_;

		// Token: 0x0400227A RID: 8826
		public const int BeginOpenTimeFieldNumber = 3;

		// Token: 0x0400227B RID: 8827
		private long beginOpenTime_;
	}
}
