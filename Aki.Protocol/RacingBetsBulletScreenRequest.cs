using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4A RID: 3658
	[NetMessage(EMessageId.RacingBetsBulletScreenRequest)]
	public sealed class RacingBetsBulletScreenRequest : IMessage<RacingBetsBulletScreenRequest>, IMessage, IEquatable<RacingBetsBulletScreenRequest>, IDeepCloneable<RacingBetsBulletScreenRequest>, IBufferMessage
	{
		// Token: 0x06013A44 RID: 80452 RVA: 0x002DB188 File Offset: 0x002D9388
		[NullableContext(1)]
		public static RacingBetsBulletScreenRequest Create()
		{
			return new RacingBetsBulletScreenRequest();
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06013A45 RID: 80453 RVA: 0x002DB18F File Offset: 0x002D938F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x06013A46 RID: 80454 RVA: 0x002DB192 File Offset: 0x002D9392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsBulletScreenRequest.Descriptor;
			}
		}

		// Token: 0x06013A47 RID: 80455 RVA: 0x002DB199 File Offset: 0x002D9399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest()
		{
		}

		// Token: 0x06013A48 RID: 80456 RVA: 0x002DB1A4 File Offset: 0x002D93A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest(RacingBetsBulletScreenRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.bulletScreenId_ = other.bulletScreenId_;
			this.actionIndex_ = other.actionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A49 RID: 80457 RVA: 0x002DB1F8 File Offset: 0x002D93F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenRequest Clone()
		{
			return new RacingBetsBulletScreenRequest(this);
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x06013A4A RID: 80458 RVA: 0x002DB200 File Offset: 0x002D9400
		// (set) Token: 0x06013A4B RID: 80459 RVA: 0x002DB208 File Offset: 0x002D9408
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

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x06013A4C RID: 80460 RVA: 0x002DB211 File Offset: 0x002D9411
		// (set) Token: 0x06013A4D RID: 80461 RVA: 0x002DB219 File Offset: 0x002D9419
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

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x06013A4E RID: 80462 RVA: 0x002DB222 File Offset: 0x002D9422
		// (set) Token: 0x06013A4F RID: 80463 RVA: 0x002DB22A File Offset: 0x002D942A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletScreenId
		{
			get
			{
				return this.bulletScreenId_;
			}
			set
			{
				this.bulletScreenId_ = value;
			}
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x06013A50 RID: 80464 RVA: 0x002DB233 File Offset: 0x002D9433
		// (set) Token: 0x06013A51 RID: 80465 RVA: 0x002DB23B File Offset: 0x002D943B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionIndex
		{
			get
			{
				return this.actionIndex_;
			}
			set
			{
				this.actionIndex_ = value;
			}
		}

		// Token: 0x06013A52 RID: 80466 RVA: 0x002DB244 File Offset: 0x002D9444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsBulletScreenRequest);
		}

		// Token: 0x06013A53 RID: 80467 RVA: 0x002DB254 File Offset: 0x002D9454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsBulletScreenRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.BulletScreenId == other.BulletScreenId && this.ActionIndex == other.ActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A54 RID: 80468 RVA: 0x002DB2C0 File Offset: 0x002D94C0
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
			if (this.BulletScreenId != 0)
			{
				num ^= this.BulletScreenId.GetHashCode();
			}
			if (this.ActionIndex != 0)
			{
				num ^= this.ActionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A55 RID: 80469 RVA: 0x002DB34A File Offset: 0x002D954A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A56 RID: 80470 RVA: 0x002DB357 File Offset: 0x002D9557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A57 RID: 80471 RVA: 0x002DB360 File Offset: 0x002D9560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BulletScreenId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BulletScreenId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActionIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A58 RID: 80472 RVA: 0x002DB3F0 File Offset: 0x002D95F0
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
			if (this.BulletScreenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletScreenId);
			}
			if (this.ActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A59 RID: 80473 RVA: 0x002DB478 File Offset: 0x002D9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsBulletScreenRequest other)
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
			if (other.BulletScreenId != 0)
			{
				this.BulletScreenId = other.BulletScreenId;
			}
			if (other.ActionIndex != 0)
			{
				this.ActionIndex = other.ActionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A5A RID: 80474 RVA: 0x002DB4F0 File Offset: 0x002D96F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A5B RID: 80475 RVA: 0x002DB4FC File Offset: 0x002D96FC
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BulletScreenId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ActionIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400783E RID: 30782
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400783F RID: 30783
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04007840 RID: 30784
		private int activityId_;

		// Token: 0x04007841 RID: 30785
		public const int LegMatchIdFieldNumber = 10;

		// Token: 0x04007842 RID: 30786
		private int legMatchId_;

		// Token: 0x04007843 RID: 30787
		public const int BulletScreenIdFieldNumber = 5;

		// Token: 0x04007844 RID: 30788
		private int bulletScreenId_;

		// Token: 0x04007845 RID: 30789
		public const int ActionIndexFieldNumber = 13;

		// Token: 0x04007846 RID: 30790
		private int actionIndex_;
	}
}
