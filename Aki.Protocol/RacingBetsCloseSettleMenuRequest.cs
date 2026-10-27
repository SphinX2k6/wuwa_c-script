using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4D RID: 3661
	[NetMessage(EMessageId.RacingBetsCloseSettleMenuRequest)]
	public sealed class RacingBetsCloseSettleMenuRequest : IMessage<RacingBetsCloseSettleMenuRequest>, IMessage, IEquatable<RacingBetsCloseSettleMenuRequest>, IDeepCloneable<RacingBetsCloseSettleMenuRequest>, IBufferMessage
	{
		// Token: 0x06013A84 RID: 80516 RVA: 0x002DBA17 File Offset: 0x002D9C17
		[NullableContext(1)]
		public static RacingBetsCloseSettleMenuRequest Create()
		{
			return new RacingBetsCloseSettleMenuRequest();
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x06013A85 RID: 80517 RVA: 0x002DBA1E File Offset: 0x002D9C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x06013A86 RID: 80518 RVA: 0x002DBA21 File Offset: 0x002D9C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsCloseSettleMenuRequest.Descriptor;
			}
		}

		// Token: 0x06013A87 RID: 80519 RVA: 0x002DBA28 File Offset: 0x002D9C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest()
		{
		}

		// Token: 0x06013A88 RID: 80520 RVA: 0x002DBA30 File Offset: 0x002D9C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest(RacingBetsCloseSettleMenuRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A89 RID: 80521 RVA: 0x002DBA61 File Offset: 0x002D9C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuRequest Clone()
		{
			return new RacingBetsCloseSettleMenuRequest(this);
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x06013A8A RID: 80522 RVA: 0x002DBA69 File Offset: 0x002D9C69
		// (set) Token: 0x06013A8B RID: 80523 RVA: 0x002DBA71 File Offset: 0x002D9C71
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

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x06013A8C RID: 80524 RVA: 0x002DBA7A File Offset: 0x002D9C7A
		// (set) Token: 0x06013A8D RID: 80525 RVA: 0x002DBA82 File Offset: 0x002D9C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x06013A8E RID: 80526 RVA: 0x002DBA8B File Offset: 0x002D9C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsCloseSettleMenuRequest);
		}

		// Token: 0x06013A8F RID: 80527 RVA: 0x002DBA99 File Offset: 0x002D9C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsCloseSettleMenuRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A90 RID: 80528 RVA: 0x002DBAD8 File Offset: 0x002D9CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A91 RID: 80529 RVA: 0x002DBB30 File Offset: 0x002D9D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A92 RID: 80530 RVA: 0x002DBB3D File Offset: 0x002D9D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A93 RID: 80531 RVA: 0x002DBB48 File Offset: 0x002D9D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A94 RID: 80532 RVA: 0x002DBBA4 File Offset: 0x002D9DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A95 RID: 80533 RVA: 0x002DBBFC File Offset: 0x002D9DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsCloseSettleMenuRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A96 RID: 80534 RVA: 0x002DBC4C File Offset: 0x002D9E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A97 RID: 80535 RVA: 0x002DBC58 File Offset: 0x002D9E58
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LegMatchId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007850 RID: 30800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007851 RID: 30801
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04007852 RID: 30802
		private int activityId_;

		// Token: 0x04007853 RID: 30803
		public const int LegMatchIdFieldNumber = 12;

		// Token: 0x04007854 RID: 30804
		private int legMatchId_;
	}
}
