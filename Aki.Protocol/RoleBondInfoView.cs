using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001057 RID: 4183
	public sealed class RoleBondInfoView : IMessage<RoleBondInfoView>, IMessage, IEquatable<RoleBondInfoView>, IDeepCloneable<RoleBondInfoView>, IBufferMessage
	{
		// Token: 0x0601659A RID: 91546 RVA: 0x0033F5E8 File Offset: 0x0033D7E8
		[NullableContext(1)]
		public static RoleBondInfoView Create()
		{
			return new RoleBondInfoView();
		}

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x0601659B RID: 91547 RVA: 0x0033F5EF File Offset: 0x0033D7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x0601659C RID: 91548 RVA: 0x0033F5F2 File Offset: 0x0033D7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBondInfoView.Descriptor;
			}
		}

		// Token: 0x0601659D RID: 91549 RVA: 0x0033F5F9 File Offset: 0x0033D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView()
		{
		}

		// Token: 0x0601659E RID: 91550 RVA: 0x0033F60C File Offset: 0x0033D80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView(RoleBondInfoView other) : this()
		{
			this.parentId_ = other.parentId_;
			this.oldStar_ = other.oldStar_;
			this.newStar_ = other.newStar_;
			this.oldRoleBondInfos_ = other.oldRoleBondInfos_.Clone();
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601659F RID: 91551 RVA: 0x0033F671 File Offset: 0x0033D871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView Clone()
		{
			return new RoleBondInfoView(this);
		}

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x060165A0 RID: 91552 RVA: 0x0033F679 File Offset: 0x0033D879
		// (set) Token: 0x060165A1 RID: 91553 RVA: 0x0033F681 File Offset: 0x0033D881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ParentId
		{
			get
			{
				return this.parentId_;
			}
			set
			{
				this.parentId_ = value;
			}
		}

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x060165A2 RID: 91554 RVA: 0x0033F68A File Offset: 0x0033D88A
		// (set) Token: 0x060165A3 RID: 91555 RVA: 0x0033F692 File Offset: 0x0033D892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OldStar
		{
			get
			{
				return this.oldStar_;
			}
			set
			{
				this.oldStar_ = value;
			}
		}

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x060165A4 RID: 91556 RVA: 0x0033F69B File Offset: 0x0033D89B
		// (set) Token: 0x060165A5 RID: 91557 RVA: 0x0033F6A3 File Offset: 0x0033D8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewStar
		{
			get
			{
				return this.newStar_;
			}
			set
			{
				this.newStar_ = value;
			}
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x060165A6 RID: 91558 RVA: 0x0033F6AC File Offset: 0x0033D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> OldRoleBondInfos
		{
			get
			{
				return this.oldRoleBondInfos_;
			}
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x060165A7 RID: 91559 RVA: 0x0033F6B4 File Offset: 0x0033D8B4
		// (set) Token: 0x060165A8 RID: 91560 RVA: 0x0033F6BC File Offset: 0x0033D8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIdOrTrialRoleId
		{
			get
			{
				return this.roleIdOrTrialRoleId_;
			}
			set
			{
				this.roleIdOrTrialRoleId_ = value;
			}
		}

		// Token: 0x060165A9 RID: 91561 RVA: 0x0033F6C5 File Offset: 0x0033D8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBondInfoView);
		}

		// Token: 0x060165AA RID: 91562 RVA: 0x0033F6D4 File Offset: 0x0033D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBondInfoView other)
		{
			return other != null && (other == this || (this.ParentId == other.ParentId && this.OldStar == other.OldStar && this.NewStar == other.NewStar && this.oldRoleBondInfos_.Equals(other.oldRoleBondInfos_) && this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165AB RID: 91563 RVA: 0x0033F754 File Offset: 0x0033D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ParentId != 0)
			{
				num ^= this.ParentId.GetHashCode();
			}
			if (this.OldStar != 0)
			{
				num ^= this.OldStar.GetHashCode();
			}
			if (this.NewStar != 0)
			{
				num ^= this.NewStar.GetHashCode();
			}
			num ^= this.oldRoleBondInfos_.GetHashCode();
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165AC RID: 91564 RVA: 0x0033F7EC File Offset: 0x0033D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165AD RID: 91565 RVA: 0x0033F7F9 File Offset: 0x0033D9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165AE RID: 91566 RVA: 0x0033F804 File Offset: 0x0033DA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ParentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ParentId);
			}
			if (this.OldStar != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OldStar);
			}
			if (this.NewStar != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NewStar);
			}
			this.oldRoleBondInfos_.WriteTo(ref output, RoleBondInfoView._repeated_oldRoleBondInfos_codec);
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165AF RID: 91567 RVA: 0x0033F8A8 File Offset: 0x0033DAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ParentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ParentId);
			}
			if (this.OldStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OldStar);
			}
			if (this.NewStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewStar);
			}
			num += this.oldRoleBondInfos_.CalculateSize(RoleBondInfoView._repeated_oldRoleBondInfos_codec);
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165B0 RID: 91568 RVA: 0x0033F944 File Offset: 0x0033DB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBondInfoView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ParentId != 0)
			{
				this.ParentId = other.ParentId;
			}
			if (other.OldStar != 0)
			{
				this.OldStar = other.OldStar;
			}
			if (other.NewStar != 0)
			{
				this.NewStar = other.NewStar;
			}
			this.oldRoleBondInfos_.Add(other.oldRoleBondInfos_);
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165B1 RID: 91569 RVA: 0x0033F9CD File Offset: 0x0033DBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165B2 RID: 91570 RVA: 0x0033F9D8 File Offset: 0x0033DBD8
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
						this.ParentId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OldStar = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.NewStar = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.oldRoleBondInfos_.AddEntriesFrom(ref input, RoleBondInfoView._repeated_oldRoleBondInfos_codec);
						continue;
					}
					if (num == 40U)
					{
						this.RoleIdOrTrialRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085AA RID: 34218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085AB RID: 34219
		public const int ParentIdFieldNumber = 1;

		// Token: 0x040085AC RID: 34220
		private int parentId_;

		// Token: 0x040085AD RID: 34221
		public const int OldStarFieldNumber = 2;

		// Token: 0x040085AE RID: 34222
		private int oldStar_;

		// Token: 0x040085AF RID: 34223
		public const int NewStarFieldNumber = 3;

		// Token: 0x040085B0 RID: 34224
		private int newStar_;

		// Token: 0x040085B1 RID: 34225
		public const int OldRoleBondInfosFieldNumber = 4;

		// Token: 0x040085B2 RID: 34226
		private static readonly FieldCodec<RoleBondInfo> _repeated_oldRoleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(34U, RoleBondInfo.Parser);

		// Token: 0x040085B3 RID: 34227
		private readonly RepeatedField<RoleBondInfo> oldRoleBondInfos_ = new RepeatedField<RoleBondInfo>();

		// Token: 0x040085B4 RID: 34228
		public const int RoleIdOrTrialRoleIdFieldNumber = 5;

		// Token: 0x040085B5 RID: 34229
		private int roleIdOrTrialRoleId_;
	}
}
