using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B5 RID: 4277
	[NetMessage(EMessageId.RoleSkillQuickLevelUpResponse)]
	public sealed class RoleSkillQuickLevelUpResponse : IMessage<RoleSkillQuickLevelUpResponse>, IMessage, IEquatable<RoleSkillQuickLevelUpResponse>, IDeepCloneable<RoleSkillQuickLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06016D58 RID: 93528 RVA: 0x00351318 File Offset: 0x0034F518
		[NullableContext(1)]
		public static RoleSkillQuickLevelUpResponse Create()
		{
			return new RoleSkillQuickLevelUpResponse();
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x06016D59 RID: 93529 RVA: 0x0035131F File Offset: 0x0034F51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x06016D5A RID: 93530 RVA: 0x00351322 File Offset: 0x0034F522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillQuickLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06016D5B RID: 93531 RVA: 0x00351329 File Offset: 0x0034F529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse()
		{
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x00351334 File Offset: 0x0034F534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse(RoleSkillQuickLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D5D RID: 93533 RVA: 0x00351380 File Offset: 0x0034F580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillQuickLevelUpResponse Clone()
		{
			return new RoleSkillQuickLevelUpResponse(this);
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x06016D5E RID: 93534 RVA: 0x00351388 File Offset: 0x0034F588
		// (set) Token: 0x06016D5F RID: 93535 RVA: 0x00351390 File Offset: 0x0034F590
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

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x06016D60 RID: 93536 RVA: 0x00351399 File Offset: 0x0034F599
		// (set) Token: 0x06016D61 RID: 93537 RVA: 0x003513A1 File Offset: 0x0034F5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
			set
			{
				this.roleInfo_ = value;
			}
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x003513AA File Offset: 0x0034F5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillQuickLevelUpResponse);
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x003513B8 File Offset: 0x0034F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillQuickLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D64 RID: 93540 RVA: 0x00351408 File Offset: 0x0034F608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.roleInfo_ != null)
			{
				num ^= this.RoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016D65 RID: 93541 RVA: 0x00351463 File Offset: 0x0034F663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D66 RID: 93542 RVA: 0x00351470 File Offset: 0x0034F670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D67 RID: 93543 RVA: 0x0035147C File Offset: 0x0034F67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.roleInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D68 RID: 93544 RVA: 0x003514D8 File Offset: 0x0034F6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.roleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016D69 RID: 93545 RVA: 0x00351530 File Offset: 0x0034F730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillQuickLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.roleInfo_ != null)
			{
				if (this.roleInfo_ == null)
				{
					this.RoleInfo = new roleInfo();
				}
				this.RoleInfo.MergeFrom(other.RoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D6A RID: 93546 RVA: 0x00351598 File Offset: 0x0034F798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x003515A4 File Offset: 0x0034F7A4
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
				if (num != 112U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.roleInfo_ == null)
						{
							this.RoleInfo = new roleInfo();
						}
						input.ReadMessage(this.RoleInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400883E RID: 34878
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400883F RID: 34879
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008840 RID: 34880
		private ErrorCode errorCode_;

		// Token: 0x04008841 RID: 34881
		public const int RoleInfoFieldNumber = 15;

		// Token: 0x04008842 RID: 34882
		private roleInfo roleInfo_;
	}
}
