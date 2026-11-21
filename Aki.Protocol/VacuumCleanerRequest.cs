using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001534 RID: 5428
	[NetMessage(EMessageId.VacuumCleanerRequest)]
	public sealed class VacuumCleanerRequest : IMessage<VacuumCleanerRequest>, IMessage, IEquatable<VacuumCleanerRequest>, IDeepCloneable<VacuumCleanerRequest>, IBufferMessage
	{
		// Token: 0x0601CC12 RID: 117778 RVA: 0x0042AE97 File Offset: 0x00429097
		[NullableContext(1)]
		public static VacuumCleanerRequest Create()
		{
			return new VacuumCleanerRequest();
		}

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x0601CC13 RID: 117779 RVA: 0x0042AE9E File Offset: 0x0042909E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x0601CC14 RID: 117780 RVA: 0x0042AEA1 File Offset: 0x004290A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VacuumCleanerRequest.Descriptor;
			}
		}

		// Token: 0x0601CC15 RID: 117781 RVA: 0x0042AEA8 File Offset: 0x004290A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerRequest()
		{
		}

		// Token: 0x0601CC16 RID: 117782 RVA: 0x0042AEBC File Offset: 0x004290BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerRequest(VacuumCleanerRequest other) : this()
		{
			this.type_ = other.type_;
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this.skillId_ = other.skillId_;
			this.adsorbEntityIncId_ = other.adsorbEntityIncId_;
			this.entityIncIds_ = other.entityIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC17 RID: 117783 RVA: 0x0042AF21 File Offset: 0x00429121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerRequest Clone()
		{
			return new VacuumCleanerRequest(this);
		}

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x0601CC18 RID: 117784 RVA: 0x0042AF29 File Offset: 0x00429129
		// (set) Token: 0x0601CC19 RID: 117785 RVA: 0x0042AF31 File Offset: 0x00429131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdsorbType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x0601CC1A RID: 117786 RVA: 0x0042AF3A File Offset: 0x0042913A
		// (set) Token: 0x0601CC1B RID: 117787 RVA: 0x0042AF42 File Offset: 0x00429142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneOwnerId
		{
			get
			{
				return this.sceneOwnerId_;
			}
			set
			{
				this.sceneOwnerId_ = value;
			}
		}

		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x0601CC1C RID: 117788 RVA: 0x0042AF4B File Offset: 0x0042914B
		// (set) Token: 0x0601CC1D RID: 117789 RVA: 0x0042AF53 File Offset: 0x00429153
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

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0601CC1E RID: 117790 RVA: 0x0042AF5C File Offset: 0x0042915C
		// (set) Token: 0x0601CC1F RID: 117791 RVA: 0x0042AF64 File Offset: 0x00429164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AdsorbEntityIncId
		{
			get
			{
				return this.adsorbEntityIncId_;
			}
			set
			{
				this.adsorbEntityIncId_ = value;
			}
		}

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0601CC20 RID: 117792 RVA: 0x0042AF6D File Offset: 0x0042916D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIncIds
		{
			get
			{
				return this.entityIncIds_;
			}
		}

		// Token: 0x0601CC21 RID: 117793 RVA: 0x0042AF75 File Offset: 0x00429175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VacuumCleanerRequest);
		}

		// Token: 0x0601CC22 RID: 117794 RVA: 0x0042AF84 File Offset: 0x00429184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VacuumCleanerRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.SceneOwnerId == other.SceneOwnerId && this.SkillId == other.SkillId && this.AdsorbEntityIncId == other.AdsorbEntityIncId && this.entityIncIds_.Equals(other.entityIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC23 RID: 117795 RVA: 0x0042B004 File Offset: 0x00429204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != AdsorbType.SceneAdsorb)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.SceneOwnerId != 0)
			{
				num ^= this.SceneOwnerId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.AdsorbEntityIncId != 0L)
			{
				num ^= this.AdsorbEntityIncId.GetHashCode();
			}
			num ^= this.entityIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CC24 RID: 117796 RVA: 0x0042B0A2 File Offset: 0x004292A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC25 RID: 117797 RVA: 0x0042B0AF File Offset: 0x004292AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC26 RID: 117798 RVA: 0x0042B0B8 File Offset: 0x004292B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillId);
			}
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this.AdsorbEntityIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.AdsorbEntityIncId);
			}
			this.entityIncIds_.WriteTo(ref output, VacuumCleanerRequest._repeated_entityIncIds_codec);
			if (this.Type != AdsorbType.SceneAdsorb)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC27 RID: 117799 RVA: 0x0042B15C File Offset: 0x0042935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != AdsorbType.SceneAdsorb)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.SceneOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneOwnerId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.AdsorbEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AdsorbEntityIncId);
			}
			num += this.entityIncIds_.CalculateSize(VacuumCleanerRequest._repeated_entityIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC28 RID: 117800 RVA: 0x0042B1F8 File Offset: 0x004293F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VacuumCleanerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != AdsorbType.SceneAdsorb)
			{
				this.Type = other.Type;
			}
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.AdsorbEntityIncId != 0L)
			{
				this.AdsorbEntityIncId = other.AdsorbEntityIncId;
			}
			this.entityIncIds_.Add(other.entityIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC29 RID: 117801 RVA: 0x0042B281 File Offset: 0x00429481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC2A RID: 117802 RVA: 0x0042B28C File Offset: 0x0042948C
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
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.SceneOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.AdsorbEntityIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.entityIncIds_.AddEntriesFrom(ref input, VacuumCleanerRequest._repeated_entityIncIds_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Type = (AdsorbType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A596 RID: 42390
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A597 RID: 42391
		public const int TypeFieldNumber = 14;

		// Token: 0x0400A598 RID: 42392
		private AdsorbType type_;

		// Token: 0x0400A599 RID: 42393
		public const int SceneOwnerIdFieldNumber = 6;

		// Token: 0x0400A59A RID: 42394
		private int sceneOwnerId_;

		// Token: 0x0400A59B RID: 42395
		public const int SkillIdFieldNumber = 5;

		// Token: 0x0400A59C RID: 42396
		private int skillId_;

		// Token: 0x0400A59D RID: 42397
		public const int AdsorbEntityIncIdFieldNumber = 9;

		// Token: 0x0400A59E RID: 42398
		private long adsorbEntityIncId_;

		// Token: 0x0400A59F RID: 42399
		public const int EntityIncIdsFieldNumber = 13;

		// Token: 0x0400A5A0 RID: 42400
		private static readonly FieldCodec<long> _repeated_entityIncIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x0400A5A1 RID: 42401
		private readonly RepeatedField<long> entityIncIds_ = new RepeatedField<long>();
	}
}
