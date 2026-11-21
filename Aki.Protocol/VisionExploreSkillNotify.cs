using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001554 RID: 5460
	[NetMessage(EMessageId.VisionExploreSkillNotify)]
	public sealed class VisionExploreSkillNotify : IMessage<VisionExploreSkillNotify>, IMessage, IEquatable<VisionExploreSkillNotify>, IDeepCloneable<VisionExploreSkillNotify>, IBufferMessage
	{
		// Token: 0x0601CEBE RID: 118462 RVA: 0x00430C15 File Offset: 0x0042EE15
		[NullableContext(1)]
		public static VisionExploreSkillNotify Create()
		{
			return new VisionExploreSkillNotify();
		}

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x0601CEBF RID: 118463 RVA: 0x00430C1C File Offset: 0x0042EE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x0601CEC0 RID: 118464 RVA: 0x00430C1F File Offset: 0x0042EE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillNotify.Descriptor;
			}
		}

		// Token: 0x0601CEC1 RID: 118465 RVA: 0x00430C26 File Offset: 0x0042EE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify()
		{
		}

		// Token: 0x0601CEC2 RID: 118466 RVA: 0x00430C2E File Offset: 0x0042EE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify(VisionExploreSkillNotify other) : this()
		{
			this.exploreSkill_ = other.exploreSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEC3 RID: 118467 RVA: 0x00430C53 File Offset: 0x0042EE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify Clone()
		{
			return new VisionExploreSkillNotify(this);
		}

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x0601CEC4 RID: 118468 RVA: 0x00430C5B File Offset: 0x0042EE5B
		// (set) Token: 0x0601CEC5 RID: 118469 RVA: 0x00430C63 File Offset: 0x0042EE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreSkill
		{
			get
			{
				return this.exploreSkill_;
			}
			set
			{
				this.exploreSkill_ = value;
			}
		}

		// Token: 0x0601CEC6 RID: 118470 RVA: 0x00430C6C File Offset: 0x0042EE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillNotify);
		}

		// Token: 0x0601CEC7 RID: 118471 RVA: 0x00430C7A File Offset: 0x0042EE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillNotify other)
		{
			return other != null && (other == this || (this.ExploreSkill == other.ExploreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEC8 RID: 118472 RVA: 0x00430CA8 File Offset: 0x0042EEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExploreSkill != 0)
			{
				num ^= this.ExploreSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEC9 RID: 118473 RVA: 0x00430CE7 File Offset: 0x0042EEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CECA RID: 118474 RVA: 0x00430CF4 File Offset: 0x0042EEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CECB RID: 118475 RVA: 0x00430CFD File Offset: 0x0042EEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExploreSkill != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CECC RID: 118476 RVA: 0x00430D30 File Offset: 0x0042EF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExploreSkill != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CECD RID: 118477 RVA: 0x00430D6E File Offset: 0x0042EF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionExploreSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExploreSkill != 0)
			{
				this.ExploreSkill = other.ExploreSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CECE RID: 118478 RVA: 0x00430D9F File Offset: 0x0042EF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CECF RID: 118479 RVA: 0x00430DA8 File Offset: 0x0042EFA8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExploreSkill = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A64C RID: 42572
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A64D RID: 42573
		public const int ExploreSkillFieldNumber = 14;

		// Token: 0x0400A64E RID: 42574
		private int exploreSkill_;
	}
}
