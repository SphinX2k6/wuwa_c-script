using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C63 RID: 3171
	[NetMessage(EMessageId.PhantomBattleCardSkillResponse)]
	public sealed class PhantomBattleCardSkillResponse : IMessage<PhantomBattleCardSkillResponse>, IMessage, IEquatable<PhantomBattleCardSkillResponse>, IDeepCloneable<PhantomBattleCardSkillResponse>, IBufferMessage
	{
		// Token: 0x06011300 RID: 70400 RVA: 0x002840FC File Offset: 0x002822FC
		[NullableContext(1)]
		public static PhantomBattleCardSkillResponse Create()
		{
			return new PhantomBattleCardSkillResponse();
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x06011301 RID: 70401 RVA: 0x00284103 File Offset: 0x00282303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x06011302 RID: 70402 RVA: 0x00284106 File Offset: 0x00282306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x06011303 RID: 70403 RVA: 0x0028410D File Offset: 0x0028230D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillResponse()
		{
		}

		// Token: 0x06011304 RID: 70404 RVA: 0x00284118 File Offset: 0x00282318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillResponse(PhantomBattleCardSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUId_ = other.cardUId_;
			this.phantomBattleSkillTriggerInfo_ = ((other.phantomBattleSkillTriggerInfo_ != null) ? other.phantomBattleSkillTriggerInfo_.Clone() : null);
			this.libraryCount_ = other.libraryCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011305 RID: 70405 RVA: 0x0028417C File Offset: 0x0028237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillResponse Clone()
		{
			return new PhantomBattleCardSkillResponse(this);
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x06011306 RID: 70406 RVA: 0x00284184 File Offset: 0x00282384
		// (set) Token: 0x06011307 RID: 70407 RVA: 0x0028418C File Offset: 0x0028238C
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

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x06011308 RID: 70408 RVA: 0x00284195 File Offset: 0x00282395
		// (set) Token: 0x06011309 RID: 70409 RVA: 0x0028419D File Offset: 0x0028239D
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

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0601130A RID: 70410 RVA: 0x002841A6 File Offset: 0x002823A6
		// (set) Token: 0x0601130B RID: 70411 RVA: 0x002841AE File Offset: 0x002823AE
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0601130C RID: 70412 RVA: 0x002841B7 File Offset: 0x002823B7
		// (set) Token: 0x0601130D RID: 70413 RVA: 0x002841BF File Offset: 0x002823BF
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

		// Token: 0x0601130E RID: 70414 RVA: 0x002841C8 File Offset: 0x002823C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillResponse);
		}

		// Token: 0x0601130F RID: 70415 RVA: 0x002841D8 File Offset: 0x002823D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUId == other.CardUId && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && this.LibraryCount == other.LibraryCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011310 RID: 70416 RVA: 0x00284248 File Offset: 0x00282448
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011311 RID: 70417 RVA: 0x002842D5 File Offset: 0x002824D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011312 RID: 70418 RVA: 0x002842E2 File Offset: 0x002824E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011313 RID: 70419 RVA: 0x002842EC File Offset: 0x002824EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LibraryCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LibraryCount);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardUId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011314 RID: 70420 RVA: 0x00284380 File Offset: 0x00282580
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011315 RID: 70421 RVA: 0x00284408 File Offset: 0x00282608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSkillResponse other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011316 RID: 70422 RVA: 0x00284498 File Offset: 0x00282698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011317 RID: 70423 RVA: 0x002844A4 File Offset: 0x002826A4
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
				if (num <= 42U)
				{
					if (num == 32U)
					{
						this.LibraryCount = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.phantomBattleSkillTriggerInfo_ == null)
						{
							this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
						}
						input.ReadMessage(this.PhantomBattleSkillTriggerInfo);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CB8 RID: 27832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CB9 RID: 27833
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006CBA RID: 27834
		private ErrorCode errorCode_;

		// Token: 0x04006CBB RID: 27835
		public const int CardUIdFieldNumber = 8;

		// Token: 0x04006CBC RID: 27836
		private int cardUId_;

		// Token: 0x04006CBD RID: 27837
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 5;

		// Token: 0x04006CBE RID: 27838
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;

		// Token: 0x04006CBF RID: 27839
		public const int LibraryCountFieldNumber = 4;

		// Token: 0x04006CC0 RID: 27840
		private int libraryCount_;
	}
}
