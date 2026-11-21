using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D5 RID: 4309
	public sealed class RoleTowerPrepareSelection : IMessage<RoleTowerPrepareSelection>, IMessage, IEquatable<RoleTowerPrepareSelection>, IDeepCloneable<RoleTowerPrepareSelection>, IBufferMessage
	{
		// Token: 0x06017090 RID: 94352 RVA: 0x00359E63 File Offset: 0x00358063
		[NullableContext(1)]
		public static RoleTowerPrepareSelection Create()
		{
			return new RoleTowerPrepareSelection();
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x06017091 RID: 94353 RVA: 0x00359E6A File Offset: 0x0035806A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x06017092 RID: 94354 RVA: 0x00359E6D File Offset: 0x0035806D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPrepareSelection.Descriptor;
			}
		}

		// Token: 0x06017093 RID: 94355 RVA: 0x00359E74 File Offset: 0x00358074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareSelection()
		{
		}

		// Token: 0x06017094 RID: 94356 RVA: 0x00359E88 File Offset: 0x00358088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareSelection(RoleTowerPrepareSelection other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.equipTokenId_ = other.equipTokenId_;
			this.branchIndex_ = other.branchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017095 RID: 94357 RVA: 0x00359ED5 File Offset: 0x003580D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareSelection Clone()
		{
			return new RoleTowerPrepareSelection(this);
		}

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06017096 RID: 94358 RVA: 0x00359EDD File Offset: 0x003580DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleBrief> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06017097 RID: 94359 RVA: 0x00359EE5 File Offset: 0x003580E5
		// (set) Token: 0x06017098 RID: 94360 RVA: 0x00359EED File Offset: 0x003580ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquipTokenId
		{
			get
			{
				return this.equipTokenId_;
			}
			set
			{
				this.equipTokenId_ = value;
			}
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06017099 RID: 94361 RVA: 0x00359EF6 File Offset: 0x003580F6
		// (set) Token: 0x0601709A RID: 94362 RVA: 0x00359EFE File Offset: 0x003580FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchIndex
		{
			get
			{
				return this.branchIndex_;
			}
			set
			{
				this.branchIndex_ = value;
			}
		}

		// Token: 0x0601709B RID: 94363 RVA: 0x00359F07 File Offset: 0x00358107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPrepareSelection);
		}

		// Token: 0x0601709C RID: 94364 RVA: 0x00359F18 File Offset: 0x00358118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPrepareSelection other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.EquipTokenId == other.EquipTokenId && this.BranchIndex == other.BranchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601709D RID: 94365 RVA: 0x00359F78 File Offset: 0x00358178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roles_.GetHashCode();
			if (this.EquipTokenId != 0)
			{
				num ^= this.EquipTokenId.GetHashCode();
			}
			if (this.BranchIndex != 0)
			{
				num ^= this.BranchIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x00359FDE File Offset: 0x003581DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x00359FEB File Offset: 0x003581EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170A0 RID: 94368 RVA: 0x00359FF4 File Offset: 0x003581F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, RoleTowerPrepareSelection._repeated_roles_codec);
			if (this.EquipTokenId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EquipTokenId);
			}
			if (this.BranchIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BranchIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x0035A060 File Offset: 0x00358260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roles_.CalculateSize(RoleTowerPrepareSelection._repeated_roles_codec);
			if (this.EquipTokenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipTokenId);
			}
			if (this.BranchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170A2 RID: 94370 RVA: 0x0035A0CC File Offset: 0x003582CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPrepareSelection other)
		{
			if (other == null)
			{
				return;
			}
			this.roles_.Add(other.roles_);
			if (other.EquipTokenId != 0)
			{
				this.EquipTokenId = other.EquipTokenId;
			}
			if (other.BranchIndex != 0)
			{
				this.BranchIndex = other.BranchIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170A3 RID: 94371 RVA: 0x0035A12D File Offset: 0x0035832D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170A4 RID: 94372 RVA: 0x0035A138 File Offset: 0x00358338
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BranchIndex = input.ReadInt32();
						}
					}
					else
					{
						this.EquipTokenId = input.ReadInt32();
					}
				}
				else
				{
					this.roles_.AddEntriesFrom(ref input, RoleTowerPrepareSelection._repeated_roles_codec);
				}
			}
		}

		// Token: 0x040089E8 RID: 35304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089E9 RID: 35305
		public const int RolesFieldNumber = 1;

		// Token: 0x040089EA RID: 35306
		private static readonly FieldCodec<RoleTowerRoleBrief> _repeated_roles_codec = FieldCodec.ForMessage<RoleTowerRoleBrief>(10U, RoleTowerRoleBrief.Parser);

		// Token: 0x040089EB RID: 35307
		private readonly RepeatedField<RoleTowerRoleBrief> roles_ = new RepeatedField<RoleTowerRoleBrief>();

		// Token: 0x040089EC RID: 35308
		public const int EquipTokenIdFieldNumber = 2;

		// Token: 0x040089ED RID: 35309
		private int equipTokenId_;

		// Token: 0x040089EE RID: 35310
		public const int BranchIndexFieldNumber = 3;

		// Token: 0x040089EF RID: 35311
		private int branchIndex_;
	}
}
