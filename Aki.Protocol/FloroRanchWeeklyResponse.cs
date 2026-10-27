using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F1 RID: 1521
	[NetMessage(EMessageId.FloroRanchWeeklyResponse)]
	public sealed class FloroRanchWeeklyResponse : IMessage<FloroRanchWeeklyResponse>, IMessage, IEquatable<FloroRanchWeeklyResponse>, IDeepCloneable<FloroRanchWeeklyResponse>, IBufferMessage
	{
		// Token: 0x06008CD2 RID: 36050 RVA: 0x00155906 File Offset: 0x00153B06
		[NullableContext(1)]
		public static FloroRanchWeeklyResponse Create()
		{
			return new FloroRanchWeeklyResponse();
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x0015590D File Offset: 0x00153B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06008CD4 RID: 36052 RVA: 0x00155910 File Offset: 0x00153B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWeeklyResponse.Descriptor;
			}
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x00155917 File Offset: 0x00153B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse()
		{
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x00155920 File Offset: 0x00153B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse(FloroRanchWeeklyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CD7 RID: 36055 RVA: 0x00155984 File Offset: 0x00153B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWeeklyResponse Clone()
		{
			return new FloroRanchWeeklyResponse(this);
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06008CD8 RID: 36056 RVA: 0x0015598C File Offset: 0x00153B8C
		// (set) Token: 0x06008CD9 RID: 36057 RVA: 0x00155994 File Offset: 0x00153B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x0015599D File Offset: 0x00153B9D
		// (set) Token: 0x06008CDB RID: 36059 RVA: 0x001559A5 File Offset: 0x00153BA5
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

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x001559AE File Offset: 0x00153BAE
		// (set) Token: 0x06008CDD RID: 36061 RVA: 0x001559B6 File Offset: 0x00153BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x001559BF File Offset: 0x00153BBF
		// (set) Token: 0x06008CDF RID: 36063 RVA: 0x001559C7 File Offset: 0x00153BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06008CE0 RID: 36064 RVA: 0x001559D0 File Offset: 0x00153BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWeeklyResponse);
		}

		// Token: 0x06008CE1 RID: 36065 RVA: 0x001559E0 File Offset: 0x00153BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWeeklyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CE2 RID: 36066 RVA: 0x00155A50 File Offset: 0x00153C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CE3 RID: 36067 RVA: 0x00155ADD File Offset: 0x00153CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CE4 RID: 36068 RVA: 0x00155AEA File Offset: 0x00153CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x00155AF4 File Offset: 0x00153CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x00155B88 File Offset: 0x00153D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x00155C10 File Offset: 0x00153E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchWeeklyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new FloroRanchPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00155CA0 File Offset: 0x00153EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x00155CAC File Offset: 0x00153EAC
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
				if (num <= 64U)
				{
					if (num == 42U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new FloroRanchPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044DA RID: 17626
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044DB RID: 17627
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040044DC RID: 17628
		private ErrorCode errorCode_;

		// Token: 0x040044DD RID: 17629
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040044DE RID: 17630
		private int activityId_;

		// Token: 0x040044DF RID: 17631
		public const int SubInsIdFieldNumber = 13;

		// Token: 0x040044E0 RID: 17632
		private int subInsId_;

		// Token: 0x040044E1 RID: 17633
		public const int PlayerInfoFieldNumber = 5;

		// Token: 0x040044E2 RID: 17634
		private FloroRanchPlayerInfo playerInfo_;
	}
}
