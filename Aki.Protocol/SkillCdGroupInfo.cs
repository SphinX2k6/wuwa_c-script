using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001235 RID: 4661
	public sealed class SkillCdGroupInfo : IMessage<SkillCdGroupInfo>, IMessage, IEquatable<SkillCdGroupInfo>, IDeepCloneable<SkillCdGroupInfo>, IBufferMessage
	{
		// Token: 0x06018D6D RID: 101741 RVA: 0x0039D4C1 File Offset: 0x0039B6C1
		[NullableContext(1)]
		public static SkillCdGroupInfo Create()
		{
			return new SkillCdGroupInfo();
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x06018D6E RID: 101742 RVA: 0x0039D4C8 File Offset: 0x0039B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillCdGroupInfo> Parser
		{
			get
			{
				return SkillCdGroupInfo._parser;
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x06018D6F RID: 101743 RVA: 0x0039D4CF File Offset: 0x0039B6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x06018D70 RID: 101744 RVA: 0x0039D4D2 File Offset: 0x0039B6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillCdGroupInfo.Descriptor;
			}
		}

		// Token: 0x06018D71 RID: 101745 RVA: 0x0039D4D9 File Offset: 0x0039B6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo()
		{
		}

		// Token: 0x06018D72 RID: 101746 RVA: 0x0039D4E4 File Offset: 0x0039B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo(SkillCdGroupInfo other) : this()
		{
			this.shareGroupId_ = other.shareGroupId_;
			this.skillCdInfo_ = ((other.skillCdInfo_ != null) ? other.skillCdInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D73 RID: 101747 RVA: 0x0039D530 File Offset: 0x0039B730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo Clone()
		{
			return new SkillCdGroupInfo(this);
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x06018D74 RID: 101748 RVA: 0x0039D538 File Offset: 0x0039B738
		// (set) Token: 0x06018D75 RID: 101749 RVA: 0x0039D540 File Offset: 0x0039B740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShareGroupId
		{
			get
			{
				return this.shareGroupId_;
			}
			set
			{
				this.shareGroupId_ = value;
			}
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x06018D76 RID: 101750 RVA: 0x0039D549 File Offset: 0x0039B749
		// (set) Token: 0x06018D77 RID: 101751 RVA: 0x0039D551 File Offset: 0x0039B751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo SkillCdInfo
		{
			get
			{
				return this.skillCdInfo_;
			}
			set
			{
				this.skillCdInfo_ = value;
			}
		}

		// Token: 0x06018D78 RID: 101752 RVA: 0x0039D55A File Offset: 0x0039B75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillCdGroupInfo);
		}

		// Token: 0x06018D79 RID: 101753 RVA: 0x0039D568 File Offset: 0x0039B768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillCdGroupInfo other)
		{
			return other != null && (other == this || (this.ShareGroupId == other.ShareGroupId && object.Equals(this.SkillCdInfo, other.SkillCdInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D7A RID: 101754 RVA: 0x0039D5B8 File Offset: 0x0039B7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShareGroupId != 0)
			{
				num ^= this.ShareGroupId.GetHashCode();
			}
			if (this.skillCdInfo_ != null)
			{
				num ^= this.SkillCdInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D7B RID: 101755 RVA: 0x0039D60D File Offset: 0x0039B80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D7C RID: 101756 RVA: 0x0039D61A File Offset: 0x0039B81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D7D RID: 101757 RVA: 0x0039D624 File Offset: 0x0039B824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShareGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShareGroupId);
			}
			if (this.skillCdInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SkillCdInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D7E RID: 101758 RVA: 0x0039D67C File Offset: 0x0039B87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShareGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShareGroupId);
			}
			if (this.skillCdInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillCdInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D7F RID: 101759 RVA: 0x0039D6D4 File Offset: 0x0039B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillCdGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShareGroupId != 0)
			{
				this.ShareGroupId = other.ShareGroupId;
			}
			if (other.skillCdInfo_ != null)
			{
				if (this.skillCdInfo_ == null)
				{
					this.SkillCdInfo = new SkillCdInfo();
				}
				this.SkillCdInfo.MergeFrom(other.SkillCdInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D80 RID: 101760 RVA: 0x0039D73C File Offset: 0x0039B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D81 RID: 101761 RVA: 0x0039D748 File Offset: 0x0039B948
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.skillCdInfo_ == null)
						{
							this.SkillCdInfo = new SkillCdInfo();
						}
						input.ReadMessage(this.SkillCdInfo);
					}
				}
				else
				{
					this.ShareGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009286 RID: 37510
		private static readonly MessageParser<SkillCdGroupInfo> _parser = new MessageParser<SkillCdGroupInfo>(() => new SkillCdGroupInfo());

		// Token: 0x04009287 RID: 37511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009288 RID: 37512
		public const int ShareGroupIdFieldNumber = 1;

		// Token: 0x04009289 RID: 37513
		private int shareGroupId_;

		// Token: 0x0400928A RID: 37514
		public const int SkillCdInfoFieldNumber = 2;

		// Token: 0x0400928B RID: 37515
		private SkillCdInfo skillCdInfo_;
	}
}
