using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1A RID: 3098
	[NetMessage(EMessageId.PhantomBattleAreaSkillResponse)]
	public sealed class PhantomBattleAreaSkillResponse : IMessage<PhantomBattleAreaSkillResponse>, IMessage, IEquatable<PhantomBattleAreaSkillResponse>, IDeepCloneable<PhantomBattleAreaSkillResponse>, IBufferMessage
	{
		// Token: 0x06010D52 RID: 68946 RVA: 0x002779E2 File Offset: 0x00275BE2
		[NullableContext(1)]
		public static PhantomBattleAreaSkillResponse Create()
		{
			return new PhantomBattleAreaSkillResponse();
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x06010D53 RID: 68947 RVA: 0x002779E9 File Offset: 0x00275BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x06010D54 RID: 68948 RVA: 0x002779EC File Offset: 0x00275BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillResponse.Descriptor;
			}
		}

		// Token: 0x06010D55 RID: 68949 RVA: 0x002779F3 File Offset: 0x00275BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse()
		{
		}

		// Token: 0x06010D56 RID: 68950 RVA: 0x002779FC File Offset: 0x00275BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse(PhantomBattleAreaSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleSkillTriggerInfos_ = ((other.phantomBattleSkillTriggerInfos_ != null) ? other.phantomBattleSkillTriggerInfos_.Clone() : null);
			this.cd_ = other.cd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D57 RID: 68951 RVA: 0x00277A54 File Offset: 0x00275C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillResponse Clone()
		{
			return new PhantomBattleAreaSkillResponse(this);
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x06010D58 RID: 68952 RVA: 0x00277A5C File Offset: 0x00275C5C
		// (set) Token: 0x06010D59 RID: 68953 RVA: 0x00277A64 File Offset: 0x00275C64
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

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x06010D5A RID: 68954 RVA: 0x00277A6D File Offset: 0x00275C6D
		// (set) Token: 0x06010D5B RID: 68955 RVA: 0x00277A75 File Offset: 0x00275C75
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

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x06010D5C RID: 68956 RVA: 0x00277A7E File Offset: 0x00275C7E
		// (set) Token: 0x06010D5D RID: 68957 RVA: 0x00277A86 File Offset: 0x00275C86
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

		// Token: 0x06010D5E RID: 68958 RVA: 0x00277A8F File Offset: 0x00275C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillResponse);
		}

		// Token: 0x06010D5F RID: 68959 RVA: 0x00277AA0 File Offset: 0x00275CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleSkillTriggerInfos, other.PhantomBattleSkillTriggerInfos) && this.Cd == other.Cd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D60 RID: 68960 RVA: 0x00277B00 File Offset: 0x00275D00
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

		// Token: 0x06010D61 RID: 68961 RVA: 0x00277B74 File Offset: 0x00275D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D62 RID: 68962 RVA: 0x00277B81 File Offset: 0x00275D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D63 RID: 68963 RVA: 0x00277B8C File Offset: 0x00275D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfos);
			}
			if (this.Cd != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Cd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D64 RID: 68964 RVA: 0x00277C04 File Offset: 0x00275E04
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

		// Token: 0x06010D65 RID: 68965 RVA: 0x00277C74 File Offset: 0x00275E74
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

		// Token: 0x06010D66 RID: 68966 RVA: 0x00277CF0 File Offset: 0x00275EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D67 RID: 68967 RVA: 0x00277CFC File Offset: 0x00275EFC
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
				if (num != 24U)
				{
					if (num != 98U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Cd = input.ReadInt32();
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006B52 RID: 27474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B53 RID: 27475
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006B54 RID: 27476
		private ErrorCode errorCode_;

		// Token: 0x04006B55 RID: 27477
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 12;

		// Token: 0x04006B56 RID: 27478
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfos_;

		// Token: 0x04006B57 RID: 27479
		public const int CdFieldNumber = 14;

		// Token: 0x04006B58 RID: 27480
		private int cd_;
	}
}
