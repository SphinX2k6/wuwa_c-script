using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6C RID: 3692
	public sealed class RacingBetsOrganEffect : IMessage<RacingBetsOrganEffect>, IMessage, IEquatable<RacingBetsOrganEffect>, IDeepCloneable<RacingBetsOrganEffect>, IBufferMessage
	{
		// Token: 0x06013D61 RID: 81249 RVA: 0x002E3A6B File Offset: 0x002E1C6B
		[NullableContext(1)]
		public static RacingBetsOrganEffect Create()
		{
			return new RacingBetsOrganEffect();
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x06013D62 RID: 81250 RVA: 0x002E3A72 File Offset: 0x002E1C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x06013D63 RID: 81251 RVA: 0x002E3A75 File Offset: 0x002E1C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsOrganEffect.Descriptor;
			}
		}

		// Token: 0x06013D64 RID: 81252 RVA: 0x002E3A7C File Offset: 0x002E1C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect()
		{
		}

		// Token: 0x06013D65 RID: 81253 RVA: 0x002E3A84 File Offset: 0x002E1C84
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

		// Token: 0x06013D66 RID: 81254 RVA: 0x002E3AD8 File Offset: 0x002E1CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganEffect Clone()
		{
			return new RacingBetsOrganEffect(this);
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x06013D67 RID: 81255 RVA: 0x002E3AE0 File Offset: 0x002E1CE0
		// (set) Token: 0x06013D68 RID: 81256 RVA: 0x002E3AE8 File Offset: 0x002E1CE8
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

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x06013D69 RID: 81257 RVA: 0x002E3AF1 File Offset: 0x002E1CF1
		// (set) Token: 0x06013D6A RID: 81258 RVA: 0x002E3AF9 File Offset: 0x002E1CF9
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

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x06013D6B RID: 81259 RVA: 0x002E3B02 File Offset: 0x002E1D02
		// (set) Token: 0x06013D6C RID: 81260 RVA: 0x002E3B0A File Offset: 0x002E1D0A
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

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x06013D6D RID: 81261 RVA: 0x002E3B13 File Offset: 0x002E1D13
		// (set) Token: 0x06013D6E RID: 81262 RVA: 0x002E3B1B File Offset: 0x002E1D1B
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

		// Token: 0x06013D6F RID: 81263 RVA: 0x002E3B24 File Offset: 0x002E1D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsOrganEffect);
		}

		// Token: 0x06013D70 RID: 81264 RVA: 0x002E3B34 File Offset: 0x002E1D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsOrganEffect other)
		{
			return other != null && (other == this || (this.OrganId == other.OrganId && this.SkillId == other.SkillId && this.DangoId == other.DangoId && this.OrganPoint == other.OrganPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D71 RID: 81265 RVA: 0x002E3BA0 File Offset: 0x002E1DA0
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

		// Token: 0x06013D72 RID: 81266 RVA: 0x002E3C2A File Offset: 0x002E1E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D73 RID: 81267 RVA: 0x002E3C37 File Offset: 0x002E1E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D74 RID: 81268 RVA: 0x002E3C40 File Offset: 0x002E1E40
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

		// Token: 0x06013D75 RID: 81269 RVA: 0x002E3CD0 File Offset: 0x002E1ED0
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

		// Token: 0x06013D76 RID: 81270 RVA: 0x002E3D58 File Offset: 0x002E1F58
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

		// Token: 0x06013D77 RID: 81271 RVA: 0x002E3DD0 File Offset: 0x002E1FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D78 RID: 81272 RVA: 0x002E3DDC File Offset: 0x002E1FDC
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

		// Token: 0x0400795F RID: 31071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007960 RID: 31072
		public const int OrganIdFieldNumber = 1;

		// Token: 0x04007961 RID: 31073
		private int organId_;

		// Token: 0x04007962 RID: 31074
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04007963 RID: 31075
		private int skillId_;

		// Token: 0x04007964 RID: 31076
		public const int DangoIdFieldNumber = 3;

		// Token: 0x04007965 RID: 31077
		private int dangoId_;

		// Token: 0x04007966 RID: 31078
		public const int OrganPointFieldNumber = 4;

		// Token: 0x04007967 RID: 31079
		private int organPoint_;
	}
}
