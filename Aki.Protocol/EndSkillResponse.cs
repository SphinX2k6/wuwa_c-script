using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000444 RID: 1092
	[NetMessage(EMessageId.EndSkillResponse)]
	public sealed class EndSkillResponse : IMessage<EndSkillResponse>, IMessage, IEquatable<EndSkillResponse>, IDeepCloneable<EndSkillResponse>, IBufferMessage
	{
		// Token: 0x0600687F RID: 26751 RVA: 0x000FB03A File Offset: 0x000F923A
		[NullableContext(1)]
		public static EndSkillResponse Create()
		{
			return new EndSkillResponse();
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06006880 RID: 26752 RVA: 0x000FB041 File Offset: 0x000F9241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x000FB044 File Offset: 0x000F9244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillResponse.Descriptor;
			}
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x000FB04B File Offset: 0x000F924B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse()
		{
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x000FB054 File Offset: 0x000F9254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse(EndSkillResponse other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x000FB0AC File Offset: 0x000F92AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse Clone()
		{
			return new EndSkillResponse(this);
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06006885 RID: 26757 RVA: 0x000FB0B4 File Offset: 0x000F92B4
		// (set) Token: 0x06006886 RID: 26758 RVA: 0x000FB0BC File Offset: 0x000F92BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x000FB0C5 File Offset: 0x000F92C5
		// (set) Token: 0x06006888 RID: 26760 RVA: 0x000FB0CD File Offset: 0x000F92CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x000FB0D6 File Offset: 0x000F92D6
		// (set) Token: 0x0600688A RID: 26762 RVA: 0x000FB0DE File Offset: 0x000F92DE
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

		// Token: 0x0600688B RID: 26763 RVA: 0x000FB0E7 File Offset: 0x000F92E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillResponse);
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x000FB0F8 File Offset: 0x000F92F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x000FB158 File Offset: 0x000F9358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x000FB1CC File Offset: 0x000F93CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x000FB1D9 File Offset: 0x000F93D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x000FB1E4 File Offset: 0x000F93E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x000FB25C File Offset: 0x000F945C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x000FB2CC File Offset: 0x000F94CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x000FB348 File Offset: 0x000F9548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x000FB354 File Offset: 0x000F9554
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
				if (num != 26U)
				{
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillSingleId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.useSkillInfo_ == null)
					{
						this.UseSkillInfo = new UseSkillInformation();
					}
					input.ReadMessage(this.UseSkillInfo);
				}
			}
		}

		// Token: 0x040039B9 RID: 14777
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039BA RID: 14778
		public const int UseSkillInfoFieldNumber = 3;

		// Token: 0x040039BB RID: 14779
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039BC RID: 14780
		public const int SkillSingleIdFieldNumber = 12;

		// Token: 0x040039BD RID: 14781
		private int skillSingleId_;

		// Token: 0x040039BE RID: 14782
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040039BF RID: 14783
		private ErrorCode errorCode_;
	}
}
