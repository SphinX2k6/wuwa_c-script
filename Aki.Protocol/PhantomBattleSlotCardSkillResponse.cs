using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBA RID: 3258
	[NetMessage(EMessageId.PhantomBattleSlotCardSkillResponse)]
	public sealed class PhantomBattleSlotCardSkillResponse : IMessage<PhantomBattleSlotCardSkillResponse>, IMessage, IEquatable<PhantomBattleSlotCardSkillResponse>, IDeepCloneable<PhantomBattleSlotCardSkillResponse>, IBufferMessage
	{
		// Token: 0x06011A5B RID: 72283 RVA: 0x00295955 File Offset: 0x00293B55
		[NullableContext(1)]
		public static PhantomBattleSlotCardSkillResponse Create()
		{
			return new PhantomBattleSlotCardSkillResponse();
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x06011A5C RID: 72284 RVA: 0x0029595C File Offset: 0x00293B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x06011A5D RID: 72285 RVA: 0x0029595F File Offset: 0x00293B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x06011A5E RID: 72286 RVA: 0x00295966 File Offset: 0x00293B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillResponse()
		{
		}

		// Token: 0x06011A5F RID: 72287 RVA: 0x00295970 File Offset: 0x00293B70
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

		// Token: 0x06011A60 RID: 72288 RVA: 0x002959E0 File Offset: 0x00293BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillResponse Clone()
		{
			return new PhantomBattleSlotCardSkillResponse(this);
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x06011A61 RID: 72289 RVA: 0x002959E8 File Offset: 0x00293BE8
		// (set) Token: 0x06011A62 RID: 72290 RVA: 0x002959F0 File Offset: 0x00293BF0
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

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x06011A63 RID: 72291 RVA: 0x002959F9 File Offset: 0x00293BF9
		// (set) Token: 0x06011A64 RID: 72292 RVA: 0x00295A01 File Offset: 0x00293C01
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

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x06011A65 RID: 72293 RVA: 0x00295A0A File Offset: 0x00293C0A
		// (set) Token: 0x06011A66 RID: 72294 RVA: 0x00295A12 File Offset: 0x00293C12
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

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x06011A67 RID: 72295 RVA: 0x00295A1B File Offset: 0x00293C1B
		// (set) Token: 0x06011A68 RID: 72296 RVA: 0x00295A23 File Offset: 0x00293C23
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

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x06011A69 RID: 72297 RVA: 0x00295A2C File Offset: 0x00293C2C
		// (set) Token: 0x06011A6A RID: 72298 RVA: 0x00295A34 File Offset: 0x00293C34
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

		// Token: 0x06011A6B RID: 72299 RVA: 0x00295A3D File Offset: 0x00293C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotCardSkillResponse);
		}

		// Token: 0x06011A6C RID: 72300 RVA: 0x00295A4C File Offset: 0x00293C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUId == other.CardUId && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && this.LibraryCount == other.LibraryCount && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A6D RID: 72301 RVA: 0x00295ACC File Offset: 0x00293CCC
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

		// Token: 0x06011A6E RID: 72302 RVA: 0x00295B72 File Offset: 0x00293D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A6F RID: 72303 RVA: 0x00295B7F File Offset: 0x00293D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A70 RID: 72304 RVA: 0x00295B88 File Offset: 0x00293D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LibraryCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LibraryCount);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardUId);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A71 RID: 72305 RVA: 0x00295C34 File Offset: 0x00293E34
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

		// Token: 0x06011A72 RID: 72306 RVA: 0x00295CD4 File Offset: 0x00293ED4
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

		// Token: 0x06011A73 RID: 72307 RVA: 0x00295D78 File Offset: 0x00293F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A74 RID: 72308 RVA: 0x00295D84 File Offset: 0x00293F84
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.LibraryCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.phantomBattleSkillTriggerInfo_ == null)
						{
							this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
						}
						input.ReadMessage(this.PhantomBattleSkillTriggerInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F1E RID: 28446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F1F RID: 28447
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006F20 RID: 28448
		private ErrorCode errorCode_;

		// Token: 0x04006F21 RID: 28449
		public const int CardUIdFieldNumber = 8;

		// Token: 0x04006F22 RID: 28450
		private int cardUId_;

		// Token: 0x04006F23 RID: 28451
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 9;

		// Token: 0x04006F24 RID: 28452
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;

		// Token: 0x04006F25 RID: 28453
		public const int LibraryCountFieldNumber = 1;

		// Token: 0x04006F26 RID: 28454
		private int libraryCount_;

		// Token: 0x04006F27 RID: 28455
		public const int SkillIdFieldNumber = 4;

		// Token: 0x04006F28 RID: 28456
		private int skillId_;
	}
}
