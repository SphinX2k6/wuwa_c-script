using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E0 RID: 5344
	[NetMessage(EMessageId.VisionExploreSkillSetResponse)]
	public sealed class VisionExploreSkillSetResponse : IMessage<VisionExploreSkillSetResponse>, IMessage, IEquatable<VisionExploreSkillSetResponse>, IDeepCloneable<VisionExploreSkillSetResponse>, IBufferMessage
	{
		// Token: 0x0601C41F RID: 115743 RVA: 0x00415673 File Offset: 0x00413873
		[NullableContext(1)]
		public static VisionExploreSkillSetResponse Create()
		{
			return new VisionExploreSkillSetResponse();
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x0601C420 RID: 115744 RVA: 0x0041567A File Offset: 0x0041387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x0601C421 RID: 115745 RVA: 0x0041567D File Offset: 0x0041387D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillSetResponse.Descriptor;
			}
		}

		// Token: 0x0601C422 RID: 115746 RVA: 0x00415684 File Offset: 0x00413884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse()
		{
		}

		// Token: 0x0601C423 RID: 115747 RVA: 0x0041568C File Offset: 0x0041388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse(VisionExploreSkillSetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C424 RID: 115748 RVA: 0x004156BD File Offset: 0x004138BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetResponse Clone()
		{
			return new VisionExploreSkillSetResponse(this);
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x0601C425 RID: 115749 RVA: 0x004156C5 File Offset: 0x004138C5
		// (set) Token: 0x0601C426 RID: 115750 RVA: 0x004156CD File Offset: 0x004138CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x0601C427 RID: 115751 RVA: 0x004156D6 File Offset: 0x004138D6
		// (set) Token: 0x0601C428 RID: 115752 RVA: 0x004156DE File Offset: 0x004138DE
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

		// Token: 0x0601C429 RID: 115753 RVA: 0x004156E7 File Offset: 0x004138E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillSetResponse);
		}

		// Token: 0x0601C42A RID: 115754 RVA: 0x004156F5 File Offset: 0x004138F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillSetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C42B RID: 115755 RVA: 0x00415734 File Offset: 0x00413934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
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

		// Token: 0x0601C42C RID: 115756 RVA: 0x00415792 File Offset: 0x00413992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C42D RID: 115757 RVA: 0x0041579F File Offset: 0x0041399F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x004157A8 File Offset: 0x004139A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C42F RID: 115759 RVA: 0x00415804 File Offset: 0x00413A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
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

		// Token: 0x0601C430 RID: 115760 RVA: 0x0041585C File Offset: 0x00413A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionExploreSkillSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C431 RID: 115761 RVA: 0x004158AC File Offset: 0x00413AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C432 RID: 115762 RVA: 0x004158B8 File Offset: 0x00413AB8
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1FD RID: 41469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1FE RID: 41470
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400A1FF RID: 41471
		private ErrorCode errCode_;

		// Token: 0x0400A200 RID: 41472
		public const int SkillIdFieldNumber = 6;

		// Token: 0x0400A201 RID: 41473
		private int skillId_;
	}
}
