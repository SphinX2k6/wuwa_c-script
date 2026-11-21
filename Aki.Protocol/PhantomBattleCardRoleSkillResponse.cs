using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4C RID: 3148
	[NetMessage(EMessageId.PhantomBattleCardRoleSkillResponse)]
	public sealed class PhantomBattleCardRoleSkillResponse : IMessage<PhantomBattleCardRoleSkillResponse>, IMessage, IEquatable<PhantomBattleCardRoleSkillResponse>, IDeepCloneable<PhantomBattleCardRoleSkillResponse>, IBufferMessage
	{
		// Token: 0x06011170 RID: 70000 RVA: 0x00280F7C File Offset: 0x0027F17C
		[NullableContext(1)]
		public static PhantomBattleCardRoleSkillResponse Create()
		{
			return new PhantomBattleCardRoleSkillResponse();
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x06011171 RID: 70001 RVA: 0x00280F83 File Offset: 0x0027F183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x06011172 RID: 70002 RVA: 0x00280F86 File Offset: 0x0027F186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleSkillResponse.Descriptor;
			}
		}

		// Token: 0x06011173 RID: 70003 RVA: 0x00280F8D File Offset: 0x0027F18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse()
		{
		}

		// Token: 0x06011174 RID: 70004 RVA: 0x00280F98 File Offset: 0x0027F198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse(PhantomBattleCardRoleSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleSkillTriggerInfo_ = ((other.phantomBattleSkillTriggerInfo_ != null) ? other.phantomBattleSkillTriggerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011175 RID: 70005 RVA: 0x00280FE4 File Offset: 0x0027F1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillResponse Clone()
		{
			return new PhantomBattleCardRoleSkillResponse(this);
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x06011176 RID: 70006 RVA: 0x00280FEC File Offset: 0x0027F1EC
		// (set) Token: 0x06011177 RID: 70007 RVA: 0x00280FF4 File Offset: 0x0027F1F4
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

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x06011178 RID: 70008 RVA: 0x00280FFD File Offset: 0x0027F1FD
		// (set) Token: 0x06011179 RID: 70009 RVA: 0x00281005 File Offset: 0x0027F205
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

		// Token: 0x0601117A RID: 70010 RVA: 0x0028100E File Offset: 0x0027F20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleSkillResponse);
		}

		// Token: 0x0601117B RID: 70011 RVA: 0x0028101C File Offset: 0x0027F21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleSkillTriggerInfo, other.PhantomBattleSkillTriggerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601117C RID: 70012 RVA: 0x0028106C File Offset: 0x0027F26C
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

		// Token: 0x0601117D RID: 70013 RVA: 0x002810C7 File Offset: 0x0027F2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601117E RID: 70014 RVA: 0x002810D4 File Offset: 0x0027F2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601117F RID: 70015 RVA: 0x002810E0 File Offset: 0x0027F2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleSkillTriggerInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011180 RID: 70016 RVA: 0x0028113C File Offset: 0x0027F33C
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

		// Token: 0x06011181 RID: 70017 RVA: 0x00281194 File Offset: 0x0027F394
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

		// Token: 0x06011182 RID: 70018 RVA: 0x002811FC File Offset: 0x0027F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011183 RID: 70019 RVA: 0x00281208 File Offset: 0x0027F408
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
				if (num != 82U)
				{
					if (num != 112U)
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

		// Token: 0x04006CA0 RID: 27808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CA1 RID: 27809
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006CA2 RID: 27810
		private ErrorCode errorCode_;

		// Token: 0x04006CA3 RID: 27811
		public const int PhantomBattleSkillTriggerInfoFieldNumber = 10;

		// Token: 0x04006CA4 RID: 27812
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfo_;
	}
}
