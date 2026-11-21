using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000090 RID: 144
	public sealed class ActivityRecommendOnePb : IMessage<ActivityRecommendOnePb>, IMessage, IEquatable<ActivityRecommendOnePb>, IDeepCloneable<ActivityRecommendOnePb>, IBufferMessage
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x0004C708 File Offset: 0x0004A908
		[NullableContext(1)]
		public static ActivityRecommendOnePb Create()
		{
			return new ActivityRecommendOnePb();
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0004C70F File Offset: 0x0004A90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityRecommendOnePb> Parser
		{
			get
			{
				return ActivityRecommendOnePb._parser;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0004C716 File Offset: 0x0004A916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0004C719 File Offset: 0x0004A919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRecommendOnePb.Descriptor;
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0004C720 File Offset: 0x0004A920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb()
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0004C728 File Offset: 0x0004A928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb(ActivityRecommendOnePb other) : this()
		{
			this.activityId_ = other.activityId_;
			this.beginShowTime_ = other.beginShowTime_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0004C765 File Offset: 0x0004A965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRecommendOnePb Clone()
		{
			return new ActivityRecommendOnePb(this);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0004C76D File Offset: 0x0004A96D
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0004C775 File Offset: 0x0004A975
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0004C77E File Offset: 0x0004A97E
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0004C786 File Offset: 0x0004A986
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0004C78F File Offset: 0x0004A98F
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0004C797 File Offset: 0x0004A997
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

		// Token: 0x06001B3E RID: 6974 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRecommendOnePb);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRecommendOnePb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.BeginShowTime == other.BeginShowTime && this.BeginOpenTime == other.BeginOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0004C80C File Offset: 0x0004AA0C
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

		// Token: 0x06001B41 RID: 6977 RVA: 0x0004C87D File Offset: 0x0004AA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0004C88A File Offset: 0x0004AA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0004C894 File Offset: 0x0004AA94
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

		// Token: 0x06001B44 RID: 6980 RVA: 0x0004C908 File Offset: 0x0004AB08
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

		// Token: 0x06001B45 RID: 6981 RVA: 0x0004C978 File Offset: 0x0004AB78
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

		// Token: 0x06001B46 RID: 6982 RVA: 0x0004C9DC File Offset: 0x0004ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0004C9E8 File Offset: 0x0004ABE8
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

		// Token: 0x040022D5 RID: 8917
		private static readonly MessageParser<ActivityRecommendOnePb> _parser = new MessageParser<ActivityRecommendOnePb>(() => new ActivityRecommendOnePb());

		// Token: 0x040022D6 RID: 8918
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D7 RID: 8919
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040022D8 RID: 8920
		private int activityId_;

		// Token: 0x040022D9 RID: 8921
		public const int BeginShowTimeFieldNumber = 2;

		// Token: 0x040022DA RID: 8922
		private long beginShowTime_;

		// Token: 0x040022DB RID: 8923
		public const int BeginOpenTimeFieldNumber = 3;

		// Token: 0x040022DC RID: 8924
		private long beginOpenTime_;
	}
}
