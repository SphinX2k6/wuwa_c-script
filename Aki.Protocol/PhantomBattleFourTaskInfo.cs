using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8B RID: 3211
	public sealed class PhantomBattleFourTaskInfo : IMessage<PhantomBattleFourTaskInfo>, IMessage, IEquatable<PhantomBattleFourTaskInfo>, IDeepCloneable<PhantomBattleFourTaskInfo>, IBufferMessage
	{
		// Token: 0x0601167A RID: 71290 RVA: 0x0028CE25 File Offset: 0x0028B025
		[NullableContext(1)]
		public static PhantomBattleFourTaskInfo Create()
		{
			return new PhantomBattleFourTaskInfo();
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0601167B RID: 71291 RVA: 0x0028CE2C File Offset: 0x0028B02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleFourTaskInfo> Parser
		{
			get
			{
				return PhantomBattleFourTaskInfo._parser;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0601167C RID: 71292 RVA: 0x0028CE33 File Offset: 0x0028B033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0601167D RID: 71293 RVA: 0x0028CE36 File Offset: 0x0028B036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourTaskInfo.Descriptor;
			}
		}

		// Token: 0x0601167E RID: 71294 RVA: 0x0028CE3D File Offset: 0x0028B03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo()
		{
		}

		// Token: 0x0601167F RID: 71295 RVA: 0x0028CE48 File Offset: 0x0028B048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo(PhantomBattleFourTaskInfo other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.curProgress_ = other.curProgress_;
			this.targetProgress_ = other.targetProgress_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011680 RID: 71296 RVA: 0x0028CE9C File Offset: 0x0028B09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourTaskInfo Clone()
		{
			return new PhantomBattleFourTaskInfo(this);
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x06011681 RID: 71297 RVA: 0x0028CEA4 File Offset: 0x0028B0A4
		// (set) Token: 0x06011682 RID: 71298 RVA: 0x0028CEAC File Offset: 0x0028B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x06011683 RID: 71299 RVA: 0x0028CEB5 File Offset: 0x0028B0B5
		// (set) Token: 0x06011684 RID: 71300 RVA: 0x0028CEBD File Offset: 0x0028B0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurProgress
		{
			get
			{
				return this.curProgress_;
			}
			set
			{
				this.curProgress_ = value;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x06011685 RID: 71301 RVA: 0x0028CEC6 File Offset: 0x0028B0C6
		// (set) Token: 0x06011686 RID: 71302 RVA: 0x0028CECE File Offset: 0x0028B0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetProgress
		{
			get
			{
				return this.targetProgress_;
			}
			set
			{
				this.targetProgress_ = value;
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x06011687 RID: 71303 RVA: 0x0028CED7 File Offset: 0x0028B0D7
		// (set) Token: 0x06011688 RID: 71304 RVA: 0x0028CEDF File Offset: 0x0028B0DF
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

		// Token: 0x06011689 RID: 71305 RVA: 0x0028CEE8 File Offset: 0x0028B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourTaskInfo);
		}

		// Token: 0x0601168A RID: 71306 RVA: 0x0028CEF8 File Offset: 0x0028B0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourTaskInfo other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.CurProgress == other.CurProgress && this.TargetProgress == other.TargetProgress && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601168B RID: 71307 RVA: 0x0028CF64 File Offset: 0x0028B164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.CurProgress != 0)
			{
				num ^= this.CurProgress.GetHashCode();
			}
			if (this.TargetProgress != 0)
			{
				num ^= this.TargetProgress.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601168C RID: 71308 RVA: 0x0028CFEE File Offset: 0x0028B1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601168D RID: 71309 RVA: 0x0028CFFB File Offset: 0x0028B1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601168E RID: 71310 RVA: 0x0028D004 File Offset: 0x0028B204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.CurProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurProgress);
			}
			if (this.TargetProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetProgress);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601168F RID: 71311 RVA: 0x0028D094 File Offset: 0x0028B294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.CurProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurProgress);
			}
			if (this.TargetProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetProgress);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011690 RID: 71312 RVA: 0x0028D110 File Offset: 0x0028B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFourTaskInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.CurProgress != 0)
			{
				this.CurProgress = other.CurProgress;
			}
			if (other.TargetProgress != 0)
			{
				this.TargetProgress = other.TargetProgress;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011691 RID: 71313 RVA: 0x0028D188 File Offset: 0x0028B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011692 RID: 71314 RVA: 0x0028D194 File Offset: 0x0028B394
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
						this.ConditionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurProgress = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetProgress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DE5 RID: 28133
		private static readonly MessageParser<PhantomBattleFourTaskInfo> _parser = new MessageParser<PhantomBattleFourTaskInfo>(() => new PhantomBattleFourTaskInfo());

		// Token: 0x04006DE6 RID: 28134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DE7 RID: 28135
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04006DE8 RID: 28136
		private int conditionId_;

		// Token: 0x04006DE9 RID: 28137
		public const int CurProgressFieldNumber = 2;

		// Token: 0x04006DEA RID: 28138
		private int curProgress_;

		// Token: 0x04006DEB RID: 28139
		public const int TargetProgressFieldNumber = 3;

		// Token: 0x04006DEC RID: 28140
		private int targetProgress_;

		// Token: 0x04006DED RID: 28141
		public const int IsFinishFieldNumber = 4;

		// Token: 0x04006DEE RID: 28142
		private bool isFinish_;
	}
}
