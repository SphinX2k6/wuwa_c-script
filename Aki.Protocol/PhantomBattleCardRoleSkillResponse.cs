using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5C RID: 3164
	[NetMessage(EMessageId.PhantomBattleCardRoleSkillResponse)]
	public sealed class PhantomBattleCardRoleSkillResponse : IMessage<PhantomBattleCardRoleSkillResponse>, IMessage, IEquatable<PhantomBattleCardRoleSkillResponse>, IDeepCloneable<PhantomBattleCardRoleSkillResponse>, IBufferMessage
	{
		// Token: 0x06011270 RID: 70256 RVA: 0x00282CEC File Offset: 0x00280EEC
		[NullableContext(1)]
		public static PhantomBattleCardRoleSkillResponse Create()
		{
			return new PhantomBattleCardRoleSkillResponse();
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x06011271 RID: 70257 RVA: 0x00282CF3 File Offset: 0x00280EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x06011272 RID: 70258 RVA: 0x00282CF6 File Offset: 0x00280EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleSkillResponse.Descriptor;
			}
		}

		// Token: 0x06011273 RID: 70259 RVA: 0x00282CFD File Offset: 0x00280EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse()
		{
		}

		// Token: 0x06011274 RID: 70260 RVA: 0x00282D08 File Offset: 0x00280F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse(PhantomBattleCardRoleSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleSkillTriggerInfo_ = ((other.phantomBattleSkillTriggerInfo_ != null) ? other.phantomBattleSkillTriggerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011275 RID: 70261 RVA: 0x00282D54 File Offset: 0x00280F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse Clone()
		{
			return new PhantomBattleCardRoleSkillResponse(this);
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x06011276 RID: 70262 RVA: 0x00282D5C File Offset: 0x00280F5C
		// (set) Token: 0x06011277 RID: 70263 RVA: 0x00282D64 File Offset: 0x00280F64
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

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x06011278 RID: 70264 RVA: 0x00282D6D File Offset: 0x00280F6D
		// (set) Token: 0x06011279 RID: 70265 RVA: 0x00282D75 File Offset: 0x00280F75
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

		// Token: 0x0601127A RID: 70266 RVA: 0x00282D7E File Offset: 0x00280F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleSkillResponse);
		}

		// Token: 0x0601127B RID: 70267 RVA: 0x00282D8C File Offset: 0x00280F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601127C RID: 70268 RVA: 0x00282DDC File Offset: 0x00280FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				num ^= this.PhantomBattleSkillTriggerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x00282E37 File Offset: 0x00281037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601127E RID: 70270 RVA: 0x00282E44 File Offset: 0x00281044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601127F RID: 70271 RVA: 0x00282E50 File Offset: 0x00281050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011280 RID: 70272 RVA: 0x00282EAC File Offset: 0x002810AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011281 RID: 70273 RVA: 0x00282F04 File Offset: 0x00281104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRoleSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleSkillTriggerInfo_ != null)
			{
				if (this.phantomBattleSkillTriggerInfo_ == null)
				{
					this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfo.MergeFrom(other.PhantomBattleSkillTriggerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011282 RID: 70274 RVA: 0x00282F6C File Offset: 0x0028116C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011283 RID: 70275 RVA: 0x00282F78 File Offset: 0x00281178
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
				if (num != 42U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.phantomBattleSkillTriggerInfo_ == null)
					{
						this.PhantomBattleSkillTriggerInfo = new PhantomBattleSkillTriggerInfo();
					}
					input.ReadMessage(this.PhantomBattleSkillTriggerInfo);
				}
			}
		}

		// Token: 0x04006C8C RID: 27788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C8D RID: 27789
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006C8E RID: 27790
		private ErrorCode errorCode_;

		// Token: 0x04006C8F RID: 27791
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 5;

		// Token: 0x04006C90 RID: 27792
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;
	}
}
