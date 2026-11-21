using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001047 RID: 4167
	public sealed class RoleBondInfoView : IMessage<RoleBondInfoView>, IMessage, IEquatable<RoleBondInfoView>, IDeepCloneable<RoleBondInfoView>, IBufferMessage
	{
		// Token: 0x060164B5 RID: 91317 RVA: 0x0033DF14 File Offset: 0x0033C114
		[NullableContext(1)]
		public static RoleBondInfoView Create()
		{
			return new RoleBondInfoView();
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x060164B6 RID: 91318 RVA: 0x0033DF1B File Offset: 0x0033C11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x060164B7 RID: 91319 RVA: 0x0033DF1E File Offset: 0x0033C11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBondInfoView.Descriptor;
			}
		}

		// Token: 0x060164B8 RID: 91320 RVA: 0x0033DF25 File Offset: 0x0033C125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView()
		{
		}

		// Token: 0x060164B9 RID: 91321 RVA: 0x0033DF38 File Offset: 0x0033C138
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

		// Token: 0x060164BA RID: 91322 RVA: 0x0033DF9D File Offset: 0x0033C19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBondInfoView Clone()
		{
			return new RoleBondInfoView(this);
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x060164BB RID: 91323 RVA: 0x0033DFA5 File Offset: 0x0033C1A5
		// (set) Token: 0x060164BC RID: 91324 RVA: 0x0033DFAD File Offset: 0x0033C1AD
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

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x060164BD RID: 91325 RVA: 0x0033DFB6 File Offset: 0x0033C1B6
		// (set) Token: 0x060164BE RID: 91326 RVA: 0x0033DFBE File Offset: 0x0033C1BE
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

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x060164BF RID: 91327 RVA: 0x0033DFC7 File Offset: 0x0033C1C7
		// (set) Token: 0x060164C0 RID: 91328 RVA: 0x0033DFCF File Offset: 0x0033C1CF
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

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x060164C1 RID: 91329 RVA: 0x0033DFD8 File Offset: 0x0033C1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> OldRoleBondInfos
		{
			get
			{
				return this.oldRoleBondInfos_;
			}
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x060164C2 RID: 91330 RVA: 0x0033DFE0 File Offset: 0x0033C1E0
		// (set) Token: 0x060164C3 RID: 91331 RVA: 0x0033DFE8 File Offset: 0x0033C1E8
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

		// Token: 0x060164C4 RID: 91332 RVA: 0x0033DFF1 File Offset: 0x0033C1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBondInfoView);
		}

		// Token: 0x060164C5 RID: 91333 RVA: 0x0033E000 File Offset: 0x0033C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBondInfoView other)
		{
			return other != null && (other == this || (this.ParentId == other.ParentId && this.OldStar == other.OldStar && this.NewStar == other.NewStar && this.oldRoleBondInfos_.Equals(other.oldRoleBondInfos_) && this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164C6 RID: 91334 RVA: 0x0033E080 File Offset: 0x0033C280
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

		// Token: 0x060164C7 RID: 91335 RVA: 0x0033E118 File Offset: 0x0033C318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164C8 RID: 91336 RVA: 0x0033E125 File Offset: 0x0033C325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164C9 RID: 91337 RVA: 0x0033E130 File Offset: 0x0033C330
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

		// Token: 0x060164CA RID: 91338 RVA: 0x0033E1D4 File Offset: 0x0033C3D4
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

		// Token: 0x060164CB RID: 91339 RVA: 0x0033E270 File Offset: 0x0033C470
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

		// Token: 0x060164CC RID: 91340 RVA: 0x0033E2F9 File Offset: 0x0033C4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164CD RID: 91341 RVA: 0x0033E304 File Offset: 0x0033C504
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

		// Token: 0x040085D4 RID: 34260
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085D5 RID: 34261
		public const int ParentIdFieldNumber = 1;

		// Token: 0x040085D6 RID: 34262
		private int parentId_;

		// Token: 0x040085D7 RID: 34263
		public const int OldStarFieldNumber = 2;

		// Token: 0x040085D8 RID: 34264
		private int oldStar_;

		// Token: 0x040085D9 RID: 34265
		public const int NewStarFieldNumber = 3;

		// Token: 0x040085DA RID: 34266
		private int newStar_;

		// Token: 0x040085DB RID: 34267
		public const int OldRoleBondInfosFieldNumber = 4;

		// Token: 0x040085DC RID: 34268
		private static readonly FieldCodec<RoleBondInfo> _repeated_oldRoleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(34U, RoleBondInfo.Parser);

		// Token: 0x040085DD RID: 34269
		private readonly RepeatedField<RoleBondInfo> oldRoleBondInfos_ = new RepeatedField<RoleBondInfo>();

		// Token: 0x040085DE RID: 34270
		public const int RoleIdOrTrialRoleIdFieldNumber = 5;

		// Token: 0x040085DF RID: 34271
		private int roleIdOrTrialRoleId_;
	}
}
