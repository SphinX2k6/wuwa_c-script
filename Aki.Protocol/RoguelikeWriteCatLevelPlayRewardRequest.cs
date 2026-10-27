using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCA RID: 4042
	[NetMessage(EMessageId.RoguelikeWriteCatLevelPlayRewardRequest)]
	public sealed class RoguelikeWriteCatLevelPlayRewardRequest : IMessage<RoguelikeWriteCatLevelPlayRewardRequest>, IMessage, IEquatable<RoguelikeWriteCatLevelPlayRewardRequest>, IDeepCloneable<RoguelikeWriteCatLevelPlayRewardRequest>, IBufferMessage
	{
		// Token: 0x060159BA RID: 88506 RVA: 0x00322EC1 File Offset: 0x003210C1
		[NullableContext(1)]
		public static RoguelikeWriteCatLevelPlayRewardRequest Create()
		{
			return new RoguelikeWriteCatLevelPlayRewardRequest();
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x060159BB RID: 88507 RVA: 0x00322EC8 File Offset: 0x003210C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x060159BC RID: 88508 RVA: 0x00322ECB File Offset: 0x003210CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatLevelPlayRewardRequest.Descriptor;
			}
		}

		// Token: 0x060159BD RID: 88509 RVA: 0x00322ED2 File Offset: 0x003210D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest()
		{
		}

		// Token: 0x060159BE RID: 88510 RVA: 0x00322EDA File Offset: 0x003210DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest(RoguelikeWriteCatLevelPlayRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159BF RID: 88511 RVA: 0x00322F0B File Offset: 0x0032110B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardRequest Clone()
		{
			return new RoguelikeWriteCatLevelPlayRewardRequest(this);
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x060159C0 RID: 88512 RVA: 0x00322F13 File Offset: 0x00321113
		// (set) Token: 0x060159C1 RID: 88513 RVA: 0x00322F1B File Offset: 0x0032111B
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

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x060159C2 RID: 88514 RVA: 0x00322F24 File Offset: 0x00321124
		// (set) Token: 0x060159C3 RID: 88515 RVA: 0x00322F2C File Offset: 0x0032112C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060159C4 RID: 88516 RVA: 0x00322F35 File Offset: 0x00321135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatLevelPlayRewardRequest);
		}

		// Token: 0x060159C5 RID: 88517 RVA: 0x00322F43 File Offset: 0x00321143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatLevelPlayRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159C6 RID: 88518 RVA: 0x00322F84 File Offset: 0x00321184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159C7 RID: 88519 RVA: 0x00322FDC File Offset: 0x003211DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159C8 RID: 88520 RVA: 0x00322FE9 File Offset: 0x003211E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159C9 RID: 88521 RVA: 0x00322FF4 File Offset: 0x003211F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159CA RID: 88522 RVA: 0x00323050 File Offset: 0x00321250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159CB RID: 88523 RVA: 0x003230A8 File Offset: 0x003212A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatLevelPlayRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159CC RID: 88524 RVA: 0x003230F8 File Offset: 0x003212F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159CD RID: 88525 RVA: 0x00323104 File Offset: 0x00321304
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
				if (num != 64U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081CA RID: 33226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081CB RID: 33227
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x040081CC RID: 33228
		private int activityId_;

		// Token: 0x040081CD RID: 33229
		public const int IndexFieldNumber = 14;

		// Token: 0x040081CE RID: 33230
		private int index_;
	}
}
