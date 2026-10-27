using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B5 RID: 2485
	[NetMessage(EMessageId.MatchChangeRoleRequest)]
	public sealed class MatchChangeRoleRequest : IMessage<MatchChangeRoleRequest>, IMessage, IEquatable<MatchChangeRoleRequest>, IDeepCloneable<MatchChangeRoleRequest>, IBufferMessage
	{
		// Token: 0x0600DA11 RID: 55825 RVA: 0x002004D8 File Offset: 0x001FE6D8
		[NullableContext(1)]
		public static MatchChangeRoleRequest Create()
		{
			return new MatchChangeRoleRequest();
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x002004DF File Offset: 0x001FE6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x002004E2 File Offset: 0x001FE6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600DA14 RID: 55828 RVA: 0x002004E9 File Offset: 0x001FE6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleRequest()
		{
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x00200514 File Offset: 0x001FE714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleRequest(MatchChangeRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_.Clone();
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this.towerDefencePhantomId_ = other.towerDefencePhantomId_.Clone();
			this.roleContext_ = ((other.roleContext_ != null) ? other.roleContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x00200587 File Offset: 0x001FE787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleRequest Clone()
		{
			return new MatchChangeRoleRequest(this);
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600DA17 RID: 55831 RVA: 0x0020058F File Offset: 0x001FE78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600DA18 RID: 55832 RVA: 0x00200597 File Offset: 0x001FE797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600DA19 RID: 55833 RVA: 0x0020059F File Offset: 0x001FE79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x002005A7 File Offset: 0x001FE7A7
		// (set) Token: 0x0600DA1B RID: 55835 RVA: 0x002005AF File Offset: 0x001FE7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleContext RoleContext
		{
			get
			{
				return this.roleContext_;
			}
			set
			{
				this.roleContext_ = value;
			}
		}

		// Token: 0x0600DA1C RID: 55836 RVA: 0x002005B8 File Offset: 0x001FE7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleRequest);
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x002005C8 File Offset: 0x001FE7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleRequest other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && this.skillBranchId_.Equals(other.skillBranchId_) && this.towerDefencePhantomId_.Equals(other.towerDefencePhantomId_) && object.Equals(this.RoleContext, other.RoleContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA1E RID: 55838 RVA: 0x00200648 File Offset: 0x001FE848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleId_.GetHashCode();
			num ^= this.skillBranchId_.GetHashCode();
			num ^= this.towerDefencePhantomId_.GetHashCode();
			if (this.roleContext_ != null)
			{
				num ^= this.RoleContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA1F RID: 55839 RVA: 0x002006AE File Offset: 0x001FE8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA20 RID: 55840 RVA: 0x002006BB File Offset: 0x001FE8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA21 RID: 55841 RVA: 0x002006C4 File Offset: 0x001FE8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleContext_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RoleContext);
			}
			this.towerDefencePhantomId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_towerDefencePhantomId_codec);
			this.roleId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_roleId_codec);
			this.skillBranchId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA22 RID: 55842 RVA: 0x00200734 File Offset: 0x001FE934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleId_.CalculateSize(MatchChangeRoleRequest._repeated_roleId_codec);
			num += this.skillBranchId_.CalculateSize(MatchChangeRoleRequest._repeated_skillBranchId_codec);
			num += this.towerDefencePhantomId_.CalculateSize(MatchChangeRoleRequest._repeated_towerDefencePhantomId_codec);
			if (this.roleContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x002007AC File Offset: 0x001FE9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleId_.Add(other.roleId_);
			this.skillBranchId_.Add(other.skillBranchId_);
			this.towerDefencePhantomId_.Add(other.towerDefencePhantomId_);
			if (other.roleContext_ != null)
			{
				if (this.roleContext_ == null)
				{
					this.RoleContext = new MatchChangeRoleContext();
				}
				this.RoleContext.MergeFrom(other.RoleContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x00200833 File Offset: 0x001FEA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x0020083C File Offset: 0x001FEA3C
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
				if (num <= 42U)
				{
					if (num == 26U)
					{
						if (this.roleContext_ == null)
						{
							this.RoleContext = new MatchChangeRoleContext();
						}
						input.ReadMessage(this.RoleContext);
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.towerDefencePhantomId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_towerDefencePhantomId_codec);
						continue;
					}
				}
				else if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.roleId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_roleId_codec);
						continue;
					}
				}
				else if (num == 56U || num == 58U)
				{
					this.skillBranchId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_skillBranchId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A9A RID: 23194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A9B RID: 23195
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04005A9C RID: 23196
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005A9D RID: 23197
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();

		// Token: 0x04005A9E RID: 23198
		public const int SkillBranchIdFieldNumber = 7;

		// Token: 0x04005A9F RID: 23199
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005AA0 RID: 23200
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();

		// Token: 0x04005AA1 RID: 23201
		public const int TowerDefencePhantomIdFieldNumber = 5;

		// Token: 0x04005AA2 RID: 23202
		private static readonly FieldCodec<int> _repeated_towerDefencePhantomId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005AA3 RID: 23203
		private readonly RepeatedField<int> towerDefencePhantomId_ = new RepeatedField<int>();

		// Token: 0x04005AA4 RID: 23204
		public const int RoleContextFieldNumber = 3;

		// Token: 0x04005AA5 RID: 23205
		private MatchChangeRoleContext roleContext_;
	}
}
