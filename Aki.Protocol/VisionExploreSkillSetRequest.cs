using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001555 RID: 5461
	[NetMessage(EMessageId.VisionExploreSkillSetRequest)]
	public sealed class VisionExploreSkillSetRequest : IMessage<VisionExploreSkillSetRequest>, IMessage, IEquatable<VisionExploreSkillSetRequest>, IDeepCloneable<VisionExploreSkillSetRequest>, IBufferMessage
	{
		// Token: 0x0601CED0 RID: 118480 RVA: 0x00430DED File Offset: 0x0042EFED
		[NullableContext(1)]
		public static VisionExploreSkillSetRequest Create()
		{
			return new VisionExploreSkillSetRequest();
		}

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x0601CED1 RID: 118481 RVA: 0x00430DF4 File Offset: 0x0042EFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x0601CED2 RID: 118482 RVA: 0x00430DF7 File Offset: 0x0042EFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillSetRequest.Descriptor;
			}
		}

		// Token: 0x0601CED3 RID: 118483 RVA: 0x00430DFE File Offset: 0x0042EFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest()
		{
		}

		// Token: 0x0601CED4 RID: 118484 RVA: 0x00430E06 File Offset: 0x0042F006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest(VisionExploreSkillSetRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.isAutoChange_ = other.isAutoChange_;
			this.rouletteType_ = other.rouletteType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CED5 RID: 118485 RVA: 0x00430E43 File Offset: 0x0042F043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest Clone()
		{
			return new VisionExploreSkillSetRequest(this);
		}

		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x0601CED6 RID: 118486 RVA: 0x00430E4B File Offset: 0x0042F04B
		// (set) Token: 0x0601CED7 RID: 118487 RVA: 0x00430E53 File Offset: 0x0042F053
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

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x0601CED8 RID: 118488 RVA: 0x00430E5C File Offset: 0x0042F05C
		// (set) Token: 0x0601CED9 RID: 118489 RVA: 0x00430E64 File Offset: 0x0042F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAutoChange
		{
			get
			{
				return this.isAutoChange_;
			}
			set
			{
				this.isAutoChange_ = value;
			}
		}

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x0601CEDA RID: 118490 RVA: 0x00430E6D File Offset: 0x0042F06D
		// (set) Token: 0x0601CEDB RID: 118491 RVA: 0x00430E75 File Offset: 0x0042F075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RouletteType RouletteType
		{
			get
			{
				return this.rouletteType_;
			}
			set
			{
				this.rouletteType_ = value;
			}
		}

		// Token: 0x0601CEDC RID: 118492 RVA: 0x00430E7E File Offset: 0x0042F07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillSetRequest);
		}

		// Token: 0x0601CEDD RID: 118493 RVA: 0x00430E8C File Offset: 0x0042F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillSetRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.IsAutoChange == other.IsAutoChange && this.RouletteType == other.RouletteType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEDE RID: 118494 RVA: 0x00430EE8 File Offset: 0x0042F0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.IsAutoChange)
			{
				num ^= this.IsAutoChange.GetHashCode();
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num ^= this.RouletteType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEDF RID: 118495 RVA: 0x00430F5F File Offset: 0x0042F15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEE0 RID: 118496 RVA: 0x00430F6C File Offset: 0x0042F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEE1 RID: 118497 RVA: 0x00430F78 File Offset: 0x0042F178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAutoChange)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsAutoChange);
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RouletteType);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEE2 RID: 118498 RVA: 0x00430FF0 File Offset: 0x0042F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.IsAutoChange)
			{
				num += 2;
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RouletteType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CEE3 RID: 118499 RVA: 0x00431054 File Offset: 0x0042F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionExploreSkillSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.IsAutoChange)
			{
				this.IsAutoChange = other.IsAutoChange;
			}
			if (other.RouletteType != RouletteType.Explore)
			{
				this.RouletteType = other.RouletteType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CEE4 RID: 118500 RVA: 0x004310B8 File Offset: 0x0042F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x004310C4 File Offset: 0x0042F2C4
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
					if (num != 72U)
					{
						if (num != 96U)
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
						this.RouletteType = (RouletteType)input.ReadEnum();
					}
				}
				else
				{
					this.IsAutoChange = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A64F RID: 42575
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A650 RID: 42576
		public const int SkillIdFieldNumber = 12;

		// Token: 0x0400A651 RID: 42577
		private int skillId_;

		// Token: 0x0400A652 RID: 42578
		public const int IsAutoChangeFieldNumber = 4;

		// Token: 0x0400A653 RID: 42579
		private bool isAutoChange_;

		// Token: 0x0400A654 RID: 42580
		public const int RouletteTypeFieldNumber = 9;

		// Token: 0x0400A655 RID: 42581
		private RouletteType rouletteType_;
	}
}
