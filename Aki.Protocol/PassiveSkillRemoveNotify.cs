using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD3 RID: 3027
	[NetMessage(EMessageId.PassiveSkillRemoveNotify)]
	public sealed class PassiveSkillRemoveNotify : IMessage<PassiveSkillRemoveNotify>, IMessage, IEquatable<PassiveSkillRemoveNotify>, IDeepCloneable<PassiveSkillRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601064B RID: 67147 RVA: 0x00263E5D File Offset: 0x0026205D
		[NullableContext(1)]
		public static PassiveSkillRemoveNotify Create()
		{
			return new PassiveSkillRemoveNotify();
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0601064C RID: 67148 RVA: 0x00263E64 File Offset: 0x00262064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0601064D RID: 67149 RVA: 0x00263E67 File Offset: 0x00262067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601064E RID: 67150 RVA: 0x00263E6E File Offset: 0x0026206E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify()
		{
		}

		// Token: 0x0601064F RID: 67151 RVA: 0x00263E81 File Offset: 0x00262081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify(PassiveSkillRemoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skillIdList_ = other.skillIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010650 RID: 67152 RVA: 0x00263EB7 File Offset: 0x002620B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveNotify Clone()
		{
			return new PassiveSkillRemoveNotify(this);
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x06010651 RID: 67153 RVA: 0x00263EBF File Offset: 0x002620BF
		// (set) Token: 0x06010652 RID: 67154 RVA: 0x00263EC7 File Offset: 0x002620C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x06010653 RID: 67155 RVA: 0x00263ED0 File Offset: 0x002620D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> SkillIdList
		{
			get
			{
				return this.skillIdList_;
			}
		}

		// Token: 0x06010654 RID: 67156 RVA: 0x00263ED8 File Offset: 0x002620D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveNotify);
		}

		// Token: 0x06010655 RID: 67157 RVA: 0x00263EE8 File Offset: 0x002620E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.skillIdList_.Equals(other.skillIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010656 RID: 67158 RVA: 0x00263F38 File Offset: 0x00262138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.skillIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010657 RID: 67159 RVA: 0x00263F85 File Offset: 0x00262185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010658 RID: 67160 RVA: 0x00263F92 File Offset: 0x00262192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010659 RID: 67161 RVA: 0x00263F9C File Offset: 0x0026219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillIdList_.WriteTo(ref output, PassiveSkillRemoveNotify._repeated_skillIdList_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601065A RID: 67162 RVA: 0x00263FEC File Offset: 0x002621EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.skillIdList_.CalculateSize(PassiveSkillRemoveNotify._repeated_skillIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601065B RID: 67163 RVA: 0x00264040 File Offset: 0x00262240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.skillIdList_.Add(other.skillIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601065C RID: 67164 RVA: 0x0026408D File Offset: 0x0026228D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601065D RID: 67165 RVA: 0x00264098 File Offset: 0x00262298
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
				if (num != 24U && num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.skillIdList_.AddEntriesFrom(ref input, PassiveSkillRemoveNotify._repeated_skillIdList_codec);
				}
			}
		}

		// Token: 0x04006805 RID: 26629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006806 RID: 26630
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04006807 RID: 26631
		private long entityId_;

		// Token: 0x04006808 RID: 26632
		public const int SkillIdListFieldNumber = 3;

		// Token: 0x04006809 RID: 26633
		private static readonly FieldCodec<long> _repeated_skillIdList_codec = FieldCodec.ForInt64(26U);

		// Token: 0x0400680A RID: 26634
		private readonly RepeatedField<long> skillIdList_ = new RepeatedField<long>();
	}
}
