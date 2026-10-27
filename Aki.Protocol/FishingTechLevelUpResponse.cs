using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058E RID: 1422
	[NetMessage(EMessageId.FishingTechLevelUpResponse)]
	public sealed class FishingTechLevelUpResponse : IMessage<FishingTechLevelUpResponse>, IMessage, IEquatable<FishingTechLevelUpResponse>, IDeepCloneable<FishingTechLevelUpResponse>, IBufferMessage
	{
		// Token: 0x060083D4 RID: 33748 RVA: 0x0013D5AD File Offset: 0x0013B7AD
		[NullableContext(1)]
		public static FishingTechLevelUpResponse Create()
		{
			return new FishingTechLevelUpResponse();
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060083D5 RID: 33749 RVA: 0x0013D5B4 File Offset: 0x0013B7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060083D6 RID: 33750 RVA: 0x0013D5B7 File Offset: 0x0013B7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x0013D5BE File Offset: 0x0013B7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse()
		{
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0013D5C8 File Offset: 0x0013B7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse(FishingTechLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishingTech_ = ((other.fishingTech_ != null) ? other.fishingTech_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0013D614 File Offset: 0x0013B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpResponse Clone()
		{
			return new FishingTechLevelUpResponse(this);
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060083DA RID: 33754 RVA: 0x0013D61C File Offset: 0x0013B81C
		// (set) Token: 0x060083DB RID: 33755 RVA: 0x0013D624 File Offset: 0x0013B824
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060083DC RID: 33756 RVA: 0x0013D62D File Offset: 0x0013B82D
		// (set) Token: 0x060083DD RID: 33757 RVA: 0x0013D635 File Offset: 0x0013B835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechInfo FishingTech
		{
			get
			{
				return this.fishingTech_;
			}
			set
			{
				this.fishingTech_ = value;
			}
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0013D63E File Offset: 0x0013B83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechLevelUpResponse);
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x0013D64C File Offset: 0x0013B84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishingTech, other.FishingTech) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x0013D69C File Offset: 0x0013B89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fishingTech_ != null)
			{
				num ^= this.FishingTech.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0013D6F7 File Offset: 0x0013B8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x0013D704 File Offset: 0x0013B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x0013D710 File Offset: 0x0013B910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishingTech_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FishingTech);
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

		// Token: 0x060083E4 RID: 33764 RVA: 0x0013D76C File Offset: 0x0013B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fishingTech_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishingTech);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x0013D7C4 File Offset: 0x0013B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTechLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fishingTech_ != null)
			{
				if (this.fishingTech_ == null)
				{
					this.FishingTech = new FishingTechInfo();
				}
				this.FishingTech.MergeFrom(other.FishingTech);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x0013D82C File Offset: 0x0013BA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x0013D838 File Offset: 0x0013BA38
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
					if (this.fishingTech_ == null)
					{
						this.FishingTech = new FishingTechInfo();
					}
					input.ReadMessage(this.FishingTech);
				}
			}
		}

		// Token: 0x0400418E RID: 16782
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400418F RID: 16783
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004190 RID: 16784
		private ErrorCode errorCode_;

		// Token: 0x04004191 RID: 16785
		public const int FishingTechFieldNumber = 10;

		// Token: 0x04004192 RID: 16786
		private FishingTechInfo fishingTech_;
	}
}
