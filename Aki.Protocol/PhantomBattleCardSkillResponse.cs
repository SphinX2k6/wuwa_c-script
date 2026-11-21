using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C53 RID: 3155
	[NetMessage(EMessageId.PhantomBattleCardSkillResponse)]
	public sealed class PhantomBattleCardSkillResponse : IMessage<PhantomBattleCardSkillResponse>, IMessage, IEquatable<PhantomBattleCardSkillResponse>, IDeepCloneable<PhantomBattleCardSkillResponse>, IBufferMessage
	{
		// Token: 0x06011200 RID: 70144 RVA: 0x00282390 File Offset: 0x00280590
		[NullableContext(1)]
		public static PhantomBattleCardSkillResponse Create()
		{
			return new PhantomBattleCardSkillResponse();
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x06011201 RID: 70145 RVA: 0x00282397 File Offset: 0x00280597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x06011202 RID: 70146 RVA: 0x0028239A File Offset: 0x0028059A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x06011203 RID: 70147 RVA: 0x002823A1 File Offset: 0x002805A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillResponse()
		{
		}

		// Token: 0x06011204 RID: 70148 RVA: 0x002823AC File Offset: 0x002805AC
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

		// Token: 0x06011205 RID: 70149 RVA: 0x00282410 File Offset: 0x00280610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillResponse Clone()
		{
			return new PhantomBattleCardSkillResponse(this);
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x06011206 RID: 70150 RVA: 0x00282418 File Offset: 0x00280618
		// (set) Token: 0x06011207 RID: 70151 RVA: 0x00282420 File Offset: 0x00280620
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

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x06011208 RID: 70152 RVA: 0x00282429 File Offset: 0x00280629
		// (set) Token: 0x06011209 RID: 70153 RVA: 0x00282431 File Offset: 0x00280631
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

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0601120A RID: 70154 RVA: 0x0028243A File Offset: 0x0028063A
		// (set) Token: 0x0601120B RID: 70155 RVA: 0x00282442 File Offset: 0x00280642
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

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0601120C RID: 70156 RVA: 0x0028244B File Offset: 0x0028064B
		// (set) Token: 0x0601120D RID: 70157 RVA: 0x00282453 File Offset: 0x00280653
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

		// Token: 0x0601120E RID: 70158 RVA: 0x0028245C File Offset: 0x0028065C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillResponse);
		}

		// Token: 0x0601120F RID: 70159 RVA: 0x0028246C File Offset: 0x0028066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUId == other.CardUId && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && this.LibraryCount == other.LibraryCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011210 RID: 70160 RVA: 0x002824DC File Offset: 0x002806DC
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

		// Token: 0x06011211 RID: 70161 RVA: 0x00282569 File Offset: 0x00280769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011212 RID: 70162 RVA: 0x00282576 File Offset: 0x00280776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011213 RID: 70163 RVA: 0x00282580 File Offset: 0x00280780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LibraryCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LibraryCount);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011214 RID: 70164 RVA: 0x00282610 File Offset: 0x00280810
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

		// Token: 0x06011215 RID: 70165 RVA: 0x00282698 File Offset: 0x00280898
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

		// Token: 0x06011216 RID: 70166 RVA: 0x00282728 File Offset: 0x00280928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011217 RID: 70167 RVA: 0x00282734 File Offset: 0x00280934
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
					if (num == 8U)
					{
						this.CardUId = input.ReadInt32();
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
					if (num == 72U)
					{
						this.LibraryCount = input.ReadInt32();
						continue;
					}
					if (num == 106U)
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

		// Token: 0x04006CCC RID: 27852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CCD RID: 27853
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006CCE RID: 27854
		private ErrorCode errorCode_;

		// Token: 0x04006CCF RID: 27855
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006CD0 RID: 27856
		private int cardUId_;

		// Token: 0x04006CD1 RID: 27857
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 13;

		// Token: 0x04006CD2 RID: 27858
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;

		// Token: 0x04006CD3 RID: 27859
		public const int LibraryCountFieldNumber = 9;

		// Token: 0x04006CD4 RID: 27860
		private int libraryCount_;
	}
}
