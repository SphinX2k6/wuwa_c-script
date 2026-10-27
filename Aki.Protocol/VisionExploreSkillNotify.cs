using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DE RID: 5342
	[NetMessage(EMessageId.VisionExploreSkillNotify)]
	public sealed class VisionExploreSkillNotify : IMessage<VisionExploreSkillNotify>, IMessage, IEquatable<VisionExploreSkillNotify>, IDeepCloneable<VisionExploreSkillNotify>, IBufferMessage
	{
		// Token: 0x0601C3F7 RID: 115703 RVA: 0x00415159 File Offset: 0x00413359
		[NullableContext(1)]
		public static VisionExploreSkillNotify Create()
		{
			return new VisionExploreSkillNotify();
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x0601C3F8 RID: 115704 RVA: 0x00415160 File Offset: 0x00413360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x0601C3F9 RID: 115705 RVA: 0x00415163 File Offset: 0x00413363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillNotify.Descriptor;
			}
		}

		// Token: 0x0601C3FA RID: 115706 RVA: 0x0041516A File Offset: 0x0041336A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify()
		{
		}

		// Token: 0x0601C3FB RID: 115707 RVA: 0x00415172 File Offset: 0x00413372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify(VisionExploreSkillNotify other) : this()
		{
			this.exploreSkill_ = other.exploreSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3FC RID: 115708 RVA: 0x00415197 File Offset: 0x00413397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillNotify Clone()
		{
			return new VisionExploreSkillNotify(this);
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x0601C3FD RID: 115709 RVA: 0x0041519F File Offset: 0x0041339F
		// (set) Token: 0x0601C3FE RID: 115710 RVA: 0x004151A7 File Offset: 0x004133A7
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

		// Token: 0x0601C3FF RID: 115711 RVA: 0x004151B0 File Offset: 0x004133B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillNotify);
		}

		// Token: 0x0601C400 RID: 115712 RVA: 0x004151BE File Offset: 0x004133BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillNotify other)
		{
			return other != null && (other == this || (this.ExploreSkill == other.ExploreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C401 RID: 115713 RVA: 0x004151EC File Offset: 0x004133EC
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

		// Token: 0x0601C402 RID: 115714 RVA: 0x0041522B File Offset: 0x0041342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C403 RID: 115715 RVA: 0x00415238 File Offset: 0x00413438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C404 RID: 115716 RVA: 0x00415241 File Offset: 0x00413441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExploreSkill != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ExploreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C405 RID: 115717 RVA: 0x00415274 File Offset: 0x00413474
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

		// Token: 0x0601C406 RID: 115718 RVA: 0x004152B2 File Offset: 0x004134B2
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

		// Token: 0x0601C407 RID: 115719 RVA: 0x004152E3 File Offset: 0x004134E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C408 RID: 115720 RVA: 0x004152EC File Offset: 0x004134EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExploreSkill = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1F3 RID: 41459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1F4 RID: 41460
		public const int ExploreSkillFieldNumber = 3;

		// Token: 0x0400A1F5 RID: 41461
		private int exploreSkill_;
	}
}
