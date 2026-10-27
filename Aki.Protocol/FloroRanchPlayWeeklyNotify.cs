using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D9 RID: 1497
	[NetMessage(EMessageId.FloroRanchPlayWeeklyNotify)]
	public sealed class FloroRanchPlayWeeklyNotify : IMessage<FloroRanchPlayWeeklyNotify>, IMessage, IEquatable<FloroRanchPlayWeeklyNotify>, IDeepCloneable<FloroRanchPlayWeeklyNotify>, IBufferMessage
	{
		// Token: 0x06008A87 RID: 35463 RVA: 0x0014EF73 File Offset: 0x0014D173
		[NullableContext(1)]
		public static FloroRanchPlayWeeklyNotify Create()
		{
			return new FloroRanchPlayWeeklyNotify();
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06008A88 RID: 35464 RVA: 0x0014EF7A File Offset: 0x0014D17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06008A89 RID: 35465 RVA: 0x0014EF7D File Offset: 0x0014D17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayWeeklyNotify.Descriptor;
			}
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x0014EF84 File Offset: 0x0014D184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify()
		{
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x0014EF8C File Offset: 0x0014D18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify(FloroRanchPlayWeeklyNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x0014EFE4 File Offset: 0x0014D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyNotify Clone()
		{
			return new FloroRanchPlayWeeklyNotify(this);
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x0014EFEC File Offset: 0x0014D1EC
		// (set) Token: 0x06008A8E RID: 35470 RVA: 0x0014EFF4 File Offset: 0x0014D1F4
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

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06008A8F RID: 35471 RVA: 0x0014EFFD File Offset: 0x0014D1FD
		// (set) Token: 0x06008A90 RID: 35472 RVA: 0x0014F005 File Offset: 0x0014D205
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

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06008A91 RID: 35473 RVA: 0x0014F00E File Offset: 0x0014D20E
		// (set) Token: 0x06008A92 RID: 35474 RVA: 0x0014F016 File Offset: 0x0014D216
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

		// Token: 0x06008A93 RID: 35475 RVA: 0x0014F01F File Offset: 0x0014D21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayWeeklyNotify);
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x0014F030 File Offset: 0x0014D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayWeeklyNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0014F090 File Offset: 0x0014D290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06008A96 RID: 35478 RVA: 0x0014F0FE File Offset: 0x0014D2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x0014F10B File Offset: 0x0014D30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x0014F114 File Offset: 0x0014D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0014F18C File Offset: 0x0014D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06008A9A RID: 35482 RVA: 0x0014F1FC File Offset: 0x0014D3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayWeeklyNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06008A9B RID: 35483 RVA: 0x0014F278 File Offset: 0x0014D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x0014F284 File Offset: 0x0014D484
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
				if (num != 50U)
				{
					if (num != 56U)
					{
						if (num != 120U)
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
						this.SubInsId = input.ReadInt32();
					}
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new FloroRanchPlayerInfo();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x0400440A RID: 17418
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400440B RID: 17419
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x0400440C RID: 17420
		private int activityId_;

		// Token: 0x0400440D RID: 17421
		public const int SubInsIdFieldNumber = 7;

		// Token: 0x0400440E RID: 17422
		private int subInsId_;

		// Token: 0x0400440F RID: 17423
		public const int PlayerInfoFieldNumber = 6;

		// Token: 0x04004410 RID: 17424
		private FloroRanchPlayerInfo playerInfo_;
	}
}
