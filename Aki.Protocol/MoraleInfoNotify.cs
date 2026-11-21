using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A06 RID: 2566
	[NetMessage(EMessageId.MoraleInfoNotify)]
	public sealed class MoraleInfoNotify : IMessage<MoraleInfoNotify>, IMessage, IEquatable<MoraleInfoNotify>, IDeepCloneable<MoraleInfoNotify>, IBufferMessage
	{
		// Token: 0x0600E0CC RID: 57548 RVA: 0x0020F2AB File Offset: 0x0020D4AB
		[NullableContext(1)]
		public static MoraleInfoNotify Create()
		{
			return new MoraleInfoNotify();
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600E0CD RID: 57549 RVA: 0x0020F2B2 File Offset: 0x0020D4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x0020F2B5 File Offset: 0x0020D4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600E0CF RID: 57551 RVA: 0x0020F2BC File Offset: 0x0020D4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify()
		{
		}

		// Token: 0x0600E0D0 RID: 57552 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify(MoraleInfoNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isStart_ = other.isStart_;
			this.moraleConfigId_ = other.moraleConfigId_;
			this.indomitableLevel_ = other.indomitableLevel_;
			this.keepMoraleLevel_ = other.keepMoraleLevel_;
			this.keepMoraleExp_ = other.keepMoraleExp_;
			this.tempMoraleLevel_ = other.tempMoraleLevel_;
			this.tempMoraleExp_ = other.tempMoraleExp_;
			this.expRatio_ = other.expRatio_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x0020F360 File Offset: 0x0020D560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleInfoNotify Clone()
		{
			return new MoraleInfoNotify(this);
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x0020F368 File Offset: 0x0020D568
		// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x0020F370 File Offset: 0x0020D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x0020F379 File Offset: 0x0020D579
		// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x0020F381 File Offset: 0x0020D581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0600E0D6 RID: 57558 RVA: 0x0020F38A File Offset: 0x0020D58A
		// (set) Token: 0x0600E0D7 RID: 57559 RVA: 0x0020F392 File Offset: 0x0020D592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoraleConfigId
		{
			get
			{
				return this.moraleConfigId_;
			}
			set
			{
				this.moraleConfigId_ = value;
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x0020F39B File Offset: 0x0020D59B
		// (set) Token: 0x0600E0D9 RID: 57561 RVA: 0x0020F3A3 File Offset: 0x0020D5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IndomitableLevel
		{
			get
			{
				return this.indomitableLevel_;
			}
			set
			{
				this.indomitableLevel_ = value;
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x0020F3AC File Offset: 0x0020D5AC
		// (set) Token: 0x0600E0DB RID: 57563 RVA: 0x0020F3B4 File Offset: 0x0020D5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepMoraleLevel
		{
			get
			{
				return this.keepMoraleLevel_;
			}
			set
			{
				this.keepMoraleLevel_ = value;
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x0020F3BD File Offset: 0x0020D5BD
		// (set) Token: 0x0600E0DD RID: 57565 RVA: 0x0020F3C5 File Offset: 0x0020D5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepMoraleExp
		{
			get
			{
				return this.keepMoraleExp_;
			}
			set
			{
				this.keepMoraleExp_ = value;
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x0020F3CE File Offset: 0x0020D5CE
		// (set) Token: 0x0600E0DF RID: 57567 RVA: 0x0020F3D6 File Offset: 0x0020D5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempMoraleLevel
		{
			get
			{
				return this.tempMoraleLevel_;
			}
			set
			{
				this.tempMoraleLevel_ = value;
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600E0E0 RID: 57568 RVA: 0x0020F3DF File Offset: 0x0020D5DF
		// (set) Token: 0x0600E0E1 RID: 57569 RVA: 0x0020F3E7 File Offset: 0x0020D5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempMoraleExp
		{
			get
			{
				return this.tempMoraleExp_;
			}
			set
			{
				this.tempMoraleExp_ = value;
			}
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x0020F3F0 File Offset: 0x0020D5F0
		// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x0020F3F8 File Offset: 0x0020D5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExpRatio
		{
			get
			{
				return this.expRatio_;
			}
			set
			{
				this.expRatio_ = value;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x0020F401 File Offset: 0x0020D601
		// (set) Token: 0x0600E0E5 RID: 57573 RVA: 0x0020F409 File Offset: 0x0020D609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x0020F412 File Offset: 0x0020D612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleInfoNotify);
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x0020F420 File Offset: 0x0020D620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleInfoNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsStart == other.IsStart && this.MoraleConfigId == other.MoraleConfigId && this.IndomitableLevel == other.IndomitableLevel && this.KeepMoraleLevel == other.KeepMoraleLevel && this.KeepMoraleExp == other.KeepMoraleExp && this.TempMoraleLevel == other.TempMoraleLevel && this.TempMoraleExp == other.TempMoraleExp && this.ExpRatio == other.ExpRatio && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x0020F4EC File Offset: 0x0020D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this.MoraleConfigId != 0)
			{
				num ^= this.MoraleConfigId.GetHashCode();
			}
			if (this.IndomitableLevel != 0)
			{
				num ^= this.IndomitableLevel.GetHashCode();
			}
			if (this.KeepMoraleLevel != 0)
			{
				num ^= this.KeepMoraleLevel.GetHashCode();
			}
			if (this.KeepMoraleExp != 0)
			{
				num ^= this.KeepMoraleExp.GetHashCode();
			}
			if (this.TempMoraleLevel != 0)
			{
				num ^= this.TempMoraleLevel.GetHashCode();
			}
			if (this.TempMoraleExp != 0)
			{
				num ^= this.TempMoraleExp.GetHashCode();
			}
			if (this.ExpRatio != 0)
			{
				num ^= this.ExpRatio.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x0020F60C File Offset: 0x0020D80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x0020F619 File Offset: 0x0020D819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x0020F624 File Offset: 0x0020D824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Reason);
			}
			if (this.TempMoraleExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TempMoraleExp);
			}
			if (this.IndomitableLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IndomitableLevel);
			}
			if (this.IsStart)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsStart);
			}
			if (this.KeepMoraleLevel != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.KeepMoraleLevel);
			}
			if (this.ExpRatio != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ExpRatio);
			}
			if (this.MoraleConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MoraleConfigId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this.TempMoraleLevel != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TempMoraleLevel);
			}
			if (this.KeepMoraleExp != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.KeepMoraleExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x0020F760 File Offset: 0x0020D960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsStart)
			{
				num += 2;
			}
			if (this.MoraleConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoraleConfigId);
			}
			if (this.IndomitableLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IndomitableLevel);
			}
			if (this.KeepMoraleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepMoraleLevel);
			}
			if (this.KeepMoraleExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepMoraleExp);
			}
			if (this.TempMoraleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempMoraleLevel);
			}
			if (this.TempMoraleExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempMoraleExp);
			}
			if (this.ExpRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpRatio);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x0020F86C File Offset: 0x0020DA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			if (other.MoraleConfigId != 0)
			{
				this.MoraleConfigId = other.MoraleConfigId;
			}
			if (other.IndomitableLevel != 0)
			{
				this.IndomitableLevel = other.IndomitableLevel;
			}
			if (other.KeepMoraleLevel != 0)
			{
				this.KeepMoraleLevel = other.KeepMoraleLevel;
			}
			if (other.KeepMoraleExp != 0)
			{
				this.KeepMoraleExp = other.KeepMoraleExp;
			}
			if (other.TempMoraleLevel != 0)
			{
				this.TempMoraleLevel = other.TempMoraleLevel;
			}
			if (other.TempMoraleExp != 0)
			{
				this.TempMoraleExp = other.TempMoraleExp;
			}
			if (other.ExpRatio != 0)
			{
				this.ExpRatio = other.ExpRatio;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x0020F95C File Offset: 0x0020DB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x0020F968 File Offset: 0x0020DB68
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
				if (num <= 72U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.Reason = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.TempMoraleExp = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.IndomitableLevel = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.IsStart = input.ReadBool();
							continue;
						}
						if (num == 72U)
						{
							this.KeepMoraleLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.ExpRatio = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.MoraleConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.TempMoraleLevel = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.KeepMoraleExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CD2 RID: 23762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CD3 RID: 23763
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04005CD4 RID: 23764
		private int playerId_;

		// Token: 0x04005CD5 RID: 23765
		public const int IsStartFieldNumber = 8;

		// Token: 0x04005CD6 RID: 23766
		private bool isStart_;

		// Token: 0x04005CD7 RID: 23767
		public const int MoraleConfigIdFieldNumber = 12;

		// Token: 0x04005CD8 RID: 23768
		private int moraleConfigId_;

		// Token: 0x04005CD9 RID: 23769
		public const int IndomitableLevelFieldNumber = 6;

		// Token: 0x04005CDA RID: 23770
		private int indomitableLevel_;

		// Token: 0x04005CDB RID: 23771
		public const int KeepMoraleLevelFieldNumber = 9;

		// Token: 0x04005CDC RID: 23772
		private int keepMoraleLevel_;

		// Token: 0x04005CDD RID: 23773
		public const int KeepMoraleExpFieldNumber = 15;

		// Token: 0x04005CDE RID: 23774
		private int keepMoraleExp_;

		// Token: 0x04005CDF RID: 23775
		public const int TempMoraleLevelFieldNumber = 14;

		// Token: 0x04005CE0 RID: 23776
		private int tempMoraleLevel_;

		// Token: 0x04005CE1 RID: 23777
		public const int TempMoraleExpFieldNumber = 3;

		// Token: 0x04005CE2 RID: 23778
		private int tempMoraleExp_;

		// Token: 0x04005CE3 RID: 23779
		public const int ExpRatioFieldNumber = 10;

		// Token: 0x04005CE4 RID: 23780
		private int expRatio_;

		// Token: 0x04005CE5 RID: 23781
		public const int ReasonFieldNumber = 2;

		// Token: 0x04005CE6 RID: 23782
		private int reason_;
	}
}
