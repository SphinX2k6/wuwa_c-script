using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F83 RID: 3971
	public sealed class RogueBossInstData : IMessage<RogueBossInstData>, IMessage, IEquatable<RogueBossInstData>, IDeepCloneable<RogueBossInstData>, IBufferMessage
	{
		// Token: 0x0601539C RID: 86940 RVA: 0x00313AD5 File Offset: 0x00311CD5
		[NullableContext(1)]
		public static RogueBossInstData Create()
		{
			return new RogueBossInstData();
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x0601539D RID: 86941 RVA: 0x00313ADC File Offset: 0x00311CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBossInstData> Parser
		{
			get
			{
				return RogueBossInstData._parser;
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0601539E RID: 86942 RVA: 0x00313AE3 File Offset: 0x00311CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0601539F RID: 86943 RVA: 0x00313AE6 File Offset: 0x00311CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBossInstData.Descriptor;
			}
		}

		// Token: 0x060153A0 RID: 86944 RVA: 0x00313AED File Offset: 0x00311CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData()
		{
		}

		// Token: 0x060153A1 RID: 86945 RVA: 0x00313AF8 File Offset: 0x00311CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData(RogueBossInstData other) : this()
		{
			this.instId_ = other.instId_;
			this.isUnlock_ = other.isUnlock_;
			this.isFinish_ = other.isFinish_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060153A2 RID: 86946 RVA: 0x00313B4C File Offset: 0x00311D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossInstData Clone()
		{
			return new RogueBossInstData(this);
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x060153A3 RID: 86947 RVA: 0x00313B54 File Offset: 0x00311D54
		// (set) Token: 0x060153A4 RID: 86948 RVA: 0x00313B5C File Offset: 0x00311D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x060153A5 RID: 86949 RVA: 0x00313B65 File Offset: 0x00311D65
		// (set) Token: 0x060153A6 RID: 86950 RVA: 0x00313B6D File Offset: 0x00311D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x060153A7 RID: 86951 RVA: 0x00313B76 File Offset: 0x00311D76
		// (set) Token: 0x060153A8 RID: 86952 RVA: 0x00313B7E File Offset: 0x00311D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x060153A9 RID: 86953 RVA: 0x00313B87 File Offset: 0x00311D87
		// (set) Token: 0x060153AA RID: 86954 RVA: 0x00313B8F File Offset: 0x00311D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x060153AB RID: 86955 RVA: 0x00313B98 File Offset: 0x00311D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBossInstData);
		}

		// Token: 0x060153AC RID: 86956 RVA: 0x00313BA8 File Offset: 0x00311DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBossInstData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsUnlock == other.IsUnlock && this.IsFinish == other.IsFinish && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153AD RID: 86957 RVA: 0x00313C14 File Offset: 0x00311E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060153AE RID: 86958 RVA: 0x00313C9E File Offset: 0x00311E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153AF RID: 86959 RVA: 0x00313CAB File Offset: 0x00311EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153B0 RID: 86960 RVA: 0x00313CB4 File Offset: 0x00311EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060153B1 RID: 86961 RVA: 0x00313D44 File Offset: 0x00311F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060153B2 RID: 86962 RVA: 0x00313DB4 File Offset: 0x00311FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBossInstData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060153B3 RID: 86963 RVA: 0x00313E2C File Offset: 0x0031202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060153B4 RID: 86964 RVA: 0x00313E38 File Offset: 0x00312038
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F94 RID: 32660
		private static readonly MessageParser<RogueBossInstData> _parser = new MessageParser<RogueBossInstData>(() => new RogueBossInstData());

		// Token: 0x04007F95 RID: 32661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F96 RID: 32662
		public const int InstIdFieldNumber = 1;

		// Token: 0x04007F97 RID: 32663
		private int instId_;

		// Token: 0x04007F98 RID: 32664
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04007F99 RID: 32665
		private bool isUnlock_;

		// Token: 0x04007F9A RID: 32666
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04007F9B RID: 32667
		private bool isFinish_;

		// Token: 0x04007F9C RID: 32668
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x04007F9D RID: 32669
		private long unlockTime_;
	}
}
