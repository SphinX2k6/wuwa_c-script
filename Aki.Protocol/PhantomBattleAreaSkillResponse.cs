using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2A RID: 3114
	[NetMessage(EMessageId.PhantomBattleAreaSkillResponse)]
	public sealed class PhantomBattleAreaSkillResponse : IMessage<PhantomBattleAreaSkillResponse>, IMessage, IEquatable<PhantomBattleAreaSkillResponse>, IDeepCloneable<PhantomBattleAreaSkillResponse>, IBufferMessage
	{
		// Token: 0x06010E52 RID: 69202 RVA: 0x00279746 File Offset: 0x00277946
		[NullableContext(1)]
		public static PhantomBattleAreaSkillResponse Create()
		{
			return new PhantomBattleAreaSkillResponse();
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x06010E53 RID: 69203 RVA: 0x0027974D File Offset: 0x0027794D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x06010E54 RID: 69204 RVA: 0x00279750 File Offset: 0x00277950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillResponse.Descriptor;
			}
		}

		// Token: 0x06010E55 RID: 69205 RVA: 0x00279757 File Offset: 0x00277957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse()
		{
		}

		// Token: 0x06010E56 RID: 69206 RVA: 0x00279760 File Offset: 0x00277960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse(PhantomBattleAreaSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleSkillTriggerInfos_ = ((other.phantomBattleSkillTriggerInfos_ != null) ? other.phantomBattleSkillTriggerInfos_.Clone() : null);
			this.cd_ = other.cd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E57 RID: 69207 RVA: 0x002797B8 File Offset: 0x002779B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse Clone()
		{
			return new PhantomBattleAreaSkillResponse(this);
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x06010E58 RID: 69208 RVA: 0x002797C0 File Offset: 0x002779C0
		// (set) Token: 0x06010E59 RID: 69209 RVA: 0x002797C8 File Offset: 0x002779C8
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

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x06010E5A RID: 69210 RVA: 0x002797D1 File Offset: 0x002779D1
		// (set) Token: 0x06010E5B RID: 69211 RVA: 0x002797D9 File Offset: 0x002779D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo PhantomBattleSkillTriggerInfos
		{
			get
			{
				return this.phantomBattleSkillTriggerInfos_;
			}
			set
			{
				this.phantomBattleSkillTriggerInfos_ = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x06010E5C RID: 69212 RVA: 0x002797E2 File Offset: 0x002779E2
		// (set) Token: 0x06010E5D RID: 69213 RVA: 0x002797EA File Offset: 0x002779EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cd
		{
			get
			{
				return this.cd_;
			}
			set
			{
				this.cd_ = value;
			}
		}

		// Token: 0x06010E5E RID: 69214 RVA: 0x002797F3 File Offset: 0x002779F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillResponse);
		}

		// Token: 0x06010E5F RID: 69215 RVA: 0x00279804 File Offset: 0x00277A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleSkillTriggerInfos, other.PhantomBattleSkillTriggerInfos) && this.Cd == other.Cd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E60 RID: 69216 RVA: 0x00279864 File Offset: 0x00277A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num ^= this.PhantomBattleSkillTriggerInfos.GetHashCode();
			}
			if (this.Cd != 0)
			{
				num ^= this.Cd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E61 RID: 69217 RVA: 0x002798D8 File Offset: 0x00277AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E62 RID: 69218 RVA: 0x002798E5 File Offset: 0x00277AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E63 RID: 69219 RVA: 0x002798F0 File Offset: 0x00277AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cd != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Cd);
			}
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfos);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E64 RID: 69220 RVA: 0x00279968 File Offset: 0x00277B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfos);
			}
			if (this.Cd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E65 RID: 69221 RVA: 0x002799D8 File Offset: 0x00277BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAreaSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleSkillTriggerInfos_ != null)
			{
				if (this.phantomBattleSkillTriggerInfos_ == null)
				{
					this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfos.MergeFrom(other.PhantomBattleSkillTriggerInfos);
			}
			if (other.Cd != 0)
			{
				this.Cd = other.Cd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E66 RID: 69222 RVA: 0x00279A54 File Offset: 0x00277C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E67 RID: 69223 RVA: 0x00279A60 File Offset: 0x00277C60
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
				if (num != 16U)
				{
					if (num != 58U)
					{
						if (num != 120U)
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
						if (this.phantomBattleSkillTriggerInfos_ == null)
						{
							this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
						}
						input.ReadMessage(this.PhantomBattleSkillTriggerInfos);
					}
				}
				else
				{
					this.Cd = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B3E RID: 27454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B3F RID: 27455
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006B40 RID: 27456
		private ErrorCode errorCode_;

		// Token: 0x04006B41 RID: 27457
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 7;

		// Token: 0x04006B42 RID: 27458
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfos_;

		// Token: 0x04006B43 RID: 27459
		public const int CdFieldNumber = 2;

		// Token: 0x04006B44 RID: 27460
		private int cd_;
	}
}
