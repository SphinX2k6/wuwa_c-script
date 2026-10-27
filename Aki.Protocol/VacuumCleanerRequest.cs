using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BE RID: 5310
	[NetMessage(EMessageId.VacuumCleanerRequest)]
	public sealed class VacuumCleanerRequest : IMessage<VacuumCleanerRequest>, IMessage, IEquatable<VacuumCleanerRequest>, IDeepCloneable<VacuumCleanerRequest>, IBufferMessage
	{
		// Token: 0x0601C14B RID: 115019 RVA: 0x0040F3DF File Offset: 0x0040D5DF
		[NullableContext(1)]
		public static VacuumCleanerRequest Create()
		{
			return new VacuumCleanerRequest();
		}

		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x0601C14C RID: 115020 RVA: 0x0040F3E6 File Offset: 0x0040D5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x0601C14D RID: 115021 RVA: 0x0040F3E9 File Offset: 0x0040D5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VacuumCleanerRequest.Descriptor;
			}
		}

		// Token: 0x0601C14E RID: 115022 RVA: 0x0040F3F0 File Offset: 0x0040D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerRequest()
		{
		}

		// Token: 0x0601C14F RID: 115023 RVA: 0x0040F404 File Offset: 0x0040D604
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

		// Token: 0x0601C150 RID: 115024 RVA: 0x0040F469 File Offset: 0x0040D669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerRequest Clone()
		{
			return new VacuumCleanerRequest(this);
		}

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0601C151 RID: 115025 RVA: 0x0040F471 File Offset: 0x0040D671
		// (set) Token: 0x0601C152 RID: 115026 RVA: 0x0040F479 File Offset: 0x0040D679
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

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x0601C153 RID: 115027 RVA: 0x0040F482 File Offset: 0x0040D682
		// (set) Token: 0x0601C154 RID: 115028 RVA: 0x0040F48A File Offset: 0x0040D68A
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

		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x0601C155 RID: 115029 RVA: 0x0040F493 File Offset: 0x0040D693
		// (set) Token: 0x0601C156 RID: 115030 RVA: 0x0040F49B File Offset: 0x0040D69B
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

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x0601C157 RID: 115031 RVA: 0x0040F4A4 File Offset: 0x0040D6A4
		// (set) Token: 0x0601C158 RID: 115032 RVA: 0x0040F4AC File Offset: 0x0040D6AC
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

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x0601C159 RID: 115033 RVA: 0x0040F4B5 File Offset: 0x0040D6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIncIds
		{
			get
			{
				return this.entityIncIds_;
			}
		}

		// Token: 0x0601C15A RID: 115034 RVA: 0x0040F4BD File Offset: 0x0040D6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VacuumCleanerRequest);
		}

		// Token: 0x0601C15B RID: 115035 RVA: 0x0040F4CC File Offset: 0x0040D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VacuumCleanerRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.SceneOwnerId == other.SceneOwnerId && this.SkillId == other.SkillId && this.AdsorbEntityIncId == other.AdsorbEntityIncId && this.entityIncIds_.Equals(other.entityIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C15C RID: 115036 RVA: 0x0040F54C File Offset: 0x0040D74C
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

		// Token: 0x0601C15D RID: 115037 RVA: 0x0040F5EA File Offset: 0x0040D7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C15E RID: 115038 RVA: 0x0040F5F7 File Offset: 0x0040D7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C15F RID: 115039 RVA: 0x0040F600 File Offset: 0x0040D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != AdsorbType.SceneAdsorb)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillId);
			}
			if (this.AdsorbEntityIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.AdsorbEntityIncId);
			}
			this.entityIncIds_.WriteTo(ref output, VacuumCleanerRequest._repeated_entityIncIds_codec);
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C160 RID: 115040 RVA: 0x0040F6A4 File Offset: 0x0040D8A4
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

		// Token: 0x0601C161 RID: 115041 RVA: 0x0040F740 File Offset: 0x0040D940
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

		// Token: 0x0601C162 RID: 115042 RVA: 0x0040F7C9 File Offset: 0x0040D9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C163 RID: 115043 RVA: 0x0040F7D4 File Offset: 0x0040D9D4
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
					if (num == 8U)
					{
						this.Type = (AdsorbType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.SkillId = input.ReadInt32();
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
					if (num == 80U || num == 82U)
					{
						this.entityIncIds_.AddEntriesFrom(ref input, VacuumCleanerRequest._repeated_entityIncIds_codec);
						continue;
					}
					if (num == 96U)
					{
						this.SceneOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A13D RID: 41277
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A13E RID: 41278
		public const int TypeFieldNumber = 1;

		// Token: 0x0400A13F RID: 41279
		private AdsorbType type_;

		// Token: 0x0400A140 RID: 41280
		public const int SceneOwnerIdFieldNumber = 12;

		// Token: 0x0400A141 RID: 41281
		private int sceneOwnerId_;

		// Token: 0x0400A142 RID: 41282
		public const int SkillIdFieldNumber = 7;

		// Token: 0x0400A143 RID: 41283
		private int skillId_;

		// Token: 0x0400A144 RID: 41284
		public const int AdsorbEntityIncIdFieldNumber = 9;

		// Token: 0x0400A145 RID: 41285
		private long adsorbEntityIncId_;

		// Token: 0x0400A146 RID: 41286
		public const int EntityIncIdsFieldNumber = 10;

		// Token: 0x0400A147 RID: 41287
		private static readonly FieldCodec<long> _repeated_entityIncIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x0400A148 RID: 41288
		private readonly RepeatedField<long> entityIncIds_ = new RepeatedField<long>();
	}
}
