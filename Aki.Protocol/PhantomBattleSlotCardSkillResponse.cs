using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAA RID: 3242
	[NetMessage(EMessageId.PhantomBattleSlotCardSkillResponse)]
	public sealed class PhantomBattleSlotCardSkillResponse : IMessage<PhantomBattleSlotCardSkillResponse>, IMessage, IEquatable<PhantomBattleSlotCardSkillResponse>, IDeepCloneable<PhantomBattleSlotCardSkillResponse>, IBufferMessage
	{
		// Token: 0x0601195B RID: 72027 RVA: 0x00293BF1 File Offset: 0x00291DF1
		[NullableContext(1)]
		public static PhantomBattleSlotCardSkillResponse Create()
		{
			return new PhantomBattleSlotCardSkillResponse();
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0601195C RID: 72028 RVA: 0x00293BF8 File Offset: 0x00291DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0601195D RID: 72029 RVA: 0x00293BFB File Offset: 0x00291DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601195E RID: 72030 RVA: 0x00293C02 File Offset: 0x00291E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillResponse()
		{
		}

		// Token: 0x0601195F RID: 72031 RVA: 0x00293C0C File Offset: 0x00291E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillResponse(PhantomBattleSlotCardSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUId_ = other.cardUId_;
			this.phantomBattleSkillTriggerInfo_ = ((other.phantomBattleSkillTriggerInfo_ != null) ? other.phantomBattleSkillTriggerInfo_.Clone() : null);
			this.libraryCount_ = other.libraryCount_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011960 RID: 72032 RVA: 0x00293C7C File Offset: 0x00291E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillResponse Clone()
		{
			return new PhantomBattleSlotCardSkillResponse(this);
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x06011961 RID: 72033 RVA: 0x00293C84 File Offset: 0x00291E84
		// (set) Token: 0x06011962 RID: 72034 RVA: 0x00293C8C File Offset: 0x00291E8C
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

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x06011963 RID: 72035 RVA: 0x00293C95 File Offset: 0x00291E95
		// (set) Token: 0x06011964 RID: 72036 RVA: 0x00293C9D File Offset: 0x00291E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x06011965 RID: 72037 RVA: 0x00293CA6 File Offset: 0x00291EA6
		// (set) Token: 0x06011966 RID: 72038 RVA: 0x00293CAE File Offset: 0x00291EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo PhantomBattleSkillTriggerInfo
		{
			get
			{
				return this.phantomBattleSkillTriggerInfo_;
			}
			set
			{
				this.phantomBattleSkillTriggerInfo_ = value;
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x06011967 RID: 72039 RVA: 0x00293CB7 File Offset: 0x00291EB7
		// (set) Token: 0x06011968 RID: 72040 RVA: 0x00293CBF File Offset: 0x00291EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LibraryCount
		{
			get
			{
				return this.libraryCount_;
			}
			set
			{
				this.libraryCount_ = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x06011969 RID: 72041 RVA: 0x00293CC8 File Offset: 0x00291EC8
		// (set) Token: 0x0601196A RID: 72042 RVA: 0x00293CD0 File Offset: 0x00291ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601196B RID: 72043 RVA: 0x00293CD9 File Offset: 0x00291ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotCardSkillResponse);
		}

		// Token: 0x0601196C RID: 72044 RVA: 0x00293CE8 File Offset: 0x00291EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUId == other.CardUId && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && this.LibraryCount == other.LibraryCount && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601196D RID: 72045 RVA: 0x00293D68 File Offset: 0x00291F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				num ^= this.PhantomBattleSkillTriggerInfo.GetHashCode();
			}
			if (this.LibraryCount != 0)
			{
				num ^= this.LibraryCount.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601196E RID: 72046 RVA: 0x00293E0E File Offset: 0x0029200E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601196F RID: 72047 RVA: 0x00293E1B File Offset: 0x0029201B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011970 RID: 72048 RVA: 0x00293E24 File Offset: 0x00292024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LibraryCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LibraryCount);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011971 RID: 72049 RVA: 0x00293ED4 File Offset: 0x002920D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.LibraryCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LibraryCount);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011972 RID: 72050 RVA: 0x00293F74 File Offset: 0x00292174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSlotCardSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.phantomBattleSkillTriggerInfo_ != null)
			{
				if (this.phantomBattleSkillTriggerInfo_ == null)
				{
					this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfo.MergeFrom(other.PhantomBattleSkillTriggerInfo);
			}
			if (other.LibraryCount != 0)
			{
				this.LibraryCount = other.LibraryCount;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011973 RID: 72051 RVA: 0x00294018 File Offset: 0x00292218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011974 RID: 72052 RVA: 0x00294024 File Offset: 0x00292224
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.LibraryCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.phantomBattleSkillTriggerInfo_ == null)
						{
							this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
						}
						input.ReadMessage(this.PhantomBattleSkillTriggerInfo);
						continue;
					}
					if (num == 80U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F32 RID: 28466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F33 RID: 28467
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006F34 RID: 28468
		private ErrorCode errorCode_;

		// Token: 0x04006F35 RID: 28469
		public const int CardUIdFieldNumber = 10;

		// Token: 0x04006F36 RID: 28470
		private int cardUId_;

		// Token: 0x04006F37 RID: 28471
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 7;

		// Token: 0x04006F38 RID: 28472
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;

		// Token: 0x04006F39 RID: 28473
		public const int LibraryCountFieldNumber = 6;

		// Token: 0x04006F3A RID: 28474
		private int libraryCount_;

		// Token: 0x04006F3B RID: 28475
		public const int SkillIdFieldNumber = 11;

		// Token: 0x04006F3C RID: 28476
		private int skillId_;
	}
}
