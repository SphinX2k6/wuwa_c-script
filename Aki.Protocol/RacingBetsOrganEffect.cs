using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5C RID: 3676
	public sealed class RacingBetsOrganEffect : IMessage<RacingBetsOrganEffect>, IMessage, IEquatable<RacingBetsOrganEffect>, IDeepCloneable<RacingBetsOrganEffect>, IBufferMessage
	{
		// Token: 0x06013C7C RID: 81020 RVA: 0x002E23AB File Offset: 0x002E05AB
		[NullableContext(1)]
		public static RacingBetsOrganEffect Create()
		{
			return new RacingBetsOrganEffect();
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x06013C7D RID: 81021 RVA: 0x002E23B2 File Offset: 0x002E05B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x06013C7E RID: 81022 RVA: 0x002E23B5 File Offset: 0x002E05B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsOrganEffect.Descriptor;
			}
		}

		// Token: 0x06013C7F RID: 81023 RVA: 0x002E23BC File Offset: 0x002E05BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect()
		{
		}

		// Token: 0x06013C80 RID: 81024 RVA: 0x002E23C4 File Offset: 0x002E05C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect(RacingBetsOrganEffect other) : this()
		{
			this.organId_ = other.organId_;
			this.skillId_ = other.skillId_;
			this.dangoId_ = other.dangoId_;
			this.organPoint_ = other.organPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C81 RID: 81025 RVA: 0x002E2418 File Offset: 0x002E0618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect Clone()
		{
			return new RacingBetsOrganEffect(this);
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x06013C82 RID: 81026 RVA: 0x002E2420 File Offset: 0x002E0620
		// (set) Token: 0x06013C83 RID: 81027 RVA: 0x002E2428 File Offset: 0x002E0628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrganId
		{
			get
			{
				return this.organId_;
			}
			set
			{
				this.organId_ = value;
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x06013C84 RID: 81028 RVA: 0x002E2431 File Offset: 0x002E0631
		// (set) Token: 0x06013C85 RID: 81029 RVA: 0x002E2439 File Offset: 0x002E0639
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

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x06013C86 RID: 81030 RVA: 0x002E2442 File Offset: 0x002E0642
		// (set) Token: 0x06013C87 RID: 81031 RVA: 0x002E244A File Offset: 0x002E064A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x06013C88 RID: 81032 RVA: 0x002E2453 File Offset: 0x002E0653
		// (set) Token: 0x06013C89 RID: 81033 RVA: 0x002E245B File Offset: 0x002E065B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrganPoint
		{
			get
			{
				return this.organPoint_;
			}
			set
			{
				this.organPoint_ = value;
			}
		}

		// Token: 0x06013C8A RID: 81034 RVA: 0x002E2464 File Offset: 0x002E0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsOrganEffect);
		}

		// Token: 0x06013C8B RID: 81035 RVA: 0x002E2474 File Offset: 0x002E0674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsOrganEffect other)
		{
			return other != null && (other == this || (this.OrganId == other.OrganId && this.SkillId == other.SkillId && this.DangoId == other.DangoId && this.OrganPoint == other.OrganPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C8C RID: 81036 RVA: 0x002E24E0 File Offset: 0x002E06E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OrganId != 0)
			{
				num ^= this.OrganId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.OrganPoint != 0)
			{
				num ^= this.OrganPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C8D RID: 81037 RVA: 0x002E256A File Offset: 0x002E076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C8E RID: 81038 RVA: 0x002E2577 File Offset: 0x002E0777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C8F RID: 81039 RVA: 0x002E2580 File Offset: 0x002E0780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OrganId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OrganId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this.DangoId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DangoId);
			}
			if (this.OrganPoint != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OrganPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C90 RID: 81040 RVA: 0x002E2610 File Offset: 0x002E0810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OrganId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OrganId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.OrganPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OrganPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C91 RID: 81041 RVA: 0x002E2698 File Offset: 0x002E0898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsOrganEffect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OrganId != 0)
			{
				this.OrganId = other.OrganId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.OrganPoint != 0)
			{
				this.OrganPoint = other.OrganPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C92 RID: 81042 RVA: 0x002E2710 File Offset: 0x002E0910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C93 RID: 81043 RVA: 0x002E271C File Offset: 0x002E091C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.OrganId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.OrganPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007989 RID: 31113
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400798A RID: 31114
		public const int OrganIdFieldNumber = 1;

		// Token: 0x0400798B RID: 31115
		private int organId_;

		// Token: 0x0400798C RID: 31116
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400798D RID: 31117
		private int skillId_;

		// Token: 0x0400798E RID: 31118
		public const int DangoIdFieldNumber = 3;

		// Token: 0x0400798F RID: 31119
		private int dangoId_;

		// Token: 0x04007990 RID: 31120
		public const int OrganPointFieldNumber = 4;

		// Token: 0x04007991 RID: 31121
		private int organPoint_;
	}
}
