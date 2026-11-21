using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144E RID: 5198
	[NetMessage(EMessageId.TrackMoonActivityRewardRequest)]
	public sealed class TrackMoonActivityRewardRequest : IMessage<TrackMoonActivityRewardRequest>, IMessage, IEquatable<TrackMoonActivityRewardRequest>, IDeepCloneable<TrackMoonActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B9C2 RID: 113090 RVA: 0x00402EF5 File Offset: 0x004010F5
		[NullableContext(1)]
		public static TrackMoonActivityRewardRequest Create()
		{
			return new TrackMoonActivityRewardRequest();
		}

		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x0601B9C3 RID: 113091 RVA: 0x00402EFC File Offset: 0x004010FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x0601B9C4 RID: 113092 RVA: 0x00402EFF File Offset: 0x004010FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B9C5 RID: 113093 RVA: 0x00402F06 File Offset: 0x00401106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest()
		{
		}

		// Token: 0x0601B9C6 RID: 113094 RVA: 0x00402F0E File Offset: 0x0040110E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest(TrackMoonActivityRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9C7 RID: 113095 RVA: 0x00402F3F File Offset: 0x0040113F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardRequest Clone()
		{
			return new TrackMoonActivityRewardRequest(this);
		}

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x0601B9C8 RID: 113096 RVA: 0x00402F47 File Offset: 0x00401147
		// (set) Token: 0x0601B9C9 RID: 113097 RVA: 0x00402F4F File Offset: 0x0040114F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x0601B9CA RID: 113098 RVA: 0x00402F58 File Offset: 0x00401158
		// (set) Token: 0x0601B9CB RID: 113099 RVA: 0x00402F60 File Offset: 0x00401160
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

		// Token: 0x0601B9CC RID: 113100 RVA: 0x00402F69 File Offset: 0x00401169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonActivityRewardRequest);
		}

		// Token: 0x0601B9CD RID: 113101 RVA: 0x00402F77 File Offset: 0x00401177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonActivityRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9CE RID: 113102 RVA: 0x00402FB8 File Offset: 0x004011B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9CF RID: 113103 RVA: 0x00403010 File Offset: 0x00401210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9D0 RID: 113104 RVA: 0x0040301D File Offset: 0x0040121D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9D1 RID: 113105 RVA: 0x00403028 File Offset: 0x00401228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9D2 RID: 113106 RVA: 0x00403084 File Offset: 0x00401284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9D3 RID: 113107 RVA: 0x004030DC File Offset: 0x004012DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonActivityRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9D4 RID: 113108 RVA: 0x0040312C File Offset: 0x0040132C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9D5 RID: 113109 RVA: 0x00403138 File Offset: 0x00401338
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
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A077 RID: 41079
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A078 RID: 41080
		public const int IdFieldNumber = 10;

		// Token: 0x0400A079 RID: 41081
		private int id_;

		// Token: 0x0400A07A RID: 41082
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400A07B RID: 41083
		private int activityId_;
	}
}
