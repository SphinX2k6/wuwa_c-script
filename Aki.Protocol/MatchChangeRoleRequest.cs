using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A4 RID: 2468
	[NetMessage(EMessageId.MatchChangeRoleRequest)]
	public sealed class MatchChangeRoleRequest : IMessage<MatchChangeRoleRequest>, IMessage, IEquatable<MatchChangeRoleRequest>, IDeepCloneable<MatchChangeRoleRequest>, IBufferMessage
	{
		// Token: 0x0600D8F7 RID: 55543 RVA: 0x001FE2E4 File Offset: 0x001FC4E4
		[NullableContext(1)]
		public static MatchChangeRoleRequest Create()
		{
			return new MatchChangeRoleRequest();
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x001FE2EB File Offset: 0x001FC4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0600D8F9 RID: 55545 RVA: 0x001FE2EE File Offset: 0x001FC4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600D8FA RID: 55546 RVA: 0x001FE2F5 File Offset: 0x001FC4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleRequest()
		{
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x001FE320 File Offset: 0x001FC520
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

		// Token: 0x0600D8FC RID: 55548 RVA: 0x001FE393 File Offset: 0x001FC593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleRequest Clone()
		{
			return new MatchChangeRoleRequest(this);
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0600D8FD RID: 55549 RVA: 0x001FE39B File Offset: 0x001FC59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x001FE3A3 File Offset: 0x001FC5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0600D8FF RID: 55551 RVA: 0x001FE3AB File Offset: 0x001FC5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0600D900 RID: 55552 RVA: 0x001FE3B3 File Offset: 0x001FC5B3
		// (set) Token: 0x0600D901 RID: 55553 RVA: 0x001FE3BB File Offset: 0x001FC5BB
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

		// Token: 0x0600D902 RID: 55554 RVA: 0x001FE3C4 File Offset: 0x001FC5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleRequest);
		}

		// Token: 0x0600D903 RID: 55555 RVA: 0x001FE3D4 File Offset: 0x001FC5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleRequest other)
		{
			return other != null && (other == this || (this.roleId_.Equals(other.roleId_) && this.skillBranchId_.Equals(other.skillBranchId_) && this.towerDefencePhantomId_.Equals(other.towerDefencePhantomId_) && object.Equals(this.RoleContext, other.RoleContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D904 RID: 55556 RVA: 0x001FE454 File Offset: 0x001FC654
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

		// Token: 0x0600D905 RID: 55557 RVA: 0x001FE4BA File Offset: 0x001FC6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D906 RID: 55558 RVA: 0x001FE4C7 File Offset: 0x001FC6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x001FE4D0 File Offset: 0x001FC6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_roleId_codec);
			this.towerDefencePhantomId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_towerDefencePhantomId_codec);
			this.skillBranchId_.WriteTo(ref output, MatchChangeRoleRequest._repeated_skillBranchId_codec);
			if (this.roleContext_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RoleContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x001FE540 File Offset: 0x001FC740
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

		// Token: 0x0600D909 RID: 55561 RVA: 0x001FE5B8 File Offset: 0x001FC7B8
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

		// Token: 0x0600D90A RID: 55562 RVA: 0x001FE63F File Offset: 0x001FC83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x001FE648 File Offset: 0x001FC848
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
				if (num > 80U)
				{
					if (num <= 88U)
					{
						if (num == 82U)
						{
							goto IL_64;
						}
						if (num != 88U)
						{
							goto IL_3D;
						}
					}
					else if (num != 90U)
					{
						if (num != 114U)
						{
							goto IL_3D;
						}
						if (this.roleContext_ == null)
						{
							this.RoleContext = new MatchChangeRoleContext();
						}
						input.ReadMessage(this.RoleContext);
						continue;
					}
					this.skillBranchId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_skillBranchId_codec);
					continue;
				}
				if (num == 40U || num == 42U)
				{
					this.roleId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_roleId_codec);
					continue;
				}
				if (num == 80U)
				{
					goto IL_64;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_64:
				this.towerDefencePhantomId_.AddEntriesFrom(ref input, MatchChangeRoleRequest._repeated_towerDefencePhantomId_codec);
			}
		}

		// Token: 0x04005AA3 RID: 23203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AA4 RID: 23204
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04005AA5 RID: 23205
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005AA6 RID: 23206
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();

		// Token: 0x04005AA7 RID: 23207
		public const int SkillBranchIdFieldNumber = 11;

		// Token: 0x04005AA8 RID: 23208
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005AA9 RID: 23209
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();

		// Token: 0x04005AAA RID: 23210
		public const int TowerDefencePhantomIdFieldNumber = 10;

		// Token: 0x04005AAB RID: 23211
		private static readonly FieldCodec<int> _repeated_towerDefencePhantomId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005AAC RID: 23212
		private readonly RepeatedField<int> towerDefencePhantomId_ = new RepeatedField<int>();

		// Token: 0x04005AAD RID: 23213
		public const int RoleContextFieldNumber = 14;

		// Token: 0x04005AAE RID: 23214
		private MatchChangeRoleContext roleContext_;
	}
}
