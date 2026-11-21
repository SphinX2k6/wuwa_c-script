using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CB RID: 4299
	public sealed class RoleTowerInstParam : IMessage<RoleTowerInstParam>, IMessage, IEquatable<RoleTowerInstParam>, IDeepCloneable<RoleTowerInstParam>, IBufferMessage
	{
		// Token: 0x06016FAA RID: 94122 RVA: 0x00357825 File Offset: 0x00355A25
		[NullableContext(1)]
		public static RoleTowerInstParam Create()
		{
			return new RoleTowerInstParam();
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x06016FAB RID: 94123 RVA: 0x0035782C File Offset: 0x00355A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x06016FAC RID: 94124 RVA: 0x0035782F File Offset: 0x00355A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerInstParam.Descriptor;
			}
		}

		// Token: 0x06016FAD RID: 94125 RVA: 0x00357836 File Offset: 0x00355A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerInstParam()
		{
		}

		// Token: 0x06016FAE RID: 94126 RVA: 0x0035784C File Offset: 0x00355A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerInstParam(RoleTowerInstParam other) : this()
		{
			this.levelId_ = other.levelId_;
			this.isContinue_ = other.isContinue_;
			this.tokenId_ = other.tokenId_;
			this.branchId_ = other.branchId_;
			this.roleSkillBranchIds_ = other.roleSkillBranchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FAF RID: 94127 RVA: 0x003578B1 File Offset: 0x00355AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerInstParam Clone()
		{
			return new RoleTowerInstParam(this);
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x06016FB0 RID: 94128 RVA: 0x003578B9 File Offset: 0x00355AB9
		// (set) Token: 0x06016FB1 RID: 94129 RVA: 0x003578C1 File Offset: 0x00355AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06016FB2 RID: 94130 RVA: 0x003578CA File Offset: 0x00355ACA
		// (set) Token: 0x06016FB3 RID: 94131 RVA: 0x003578D2 File Offset: 0x00355AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsContinue
		{
			get
			{
				return this.isContinue_;
			}
			set
			{
				this.isContinue_ = value;
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06016FB4 RID: 94132 RVA: 0x003578DB File Offset: 0x00355ADB
		// (set) Token: 0x06016FB5 RID: 94133 RVA: 0x003578E3 File Offset: 0x00355AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenId
		{
			get
			{
				return this.tokenId_;
			}
			set
			{
				this.tokenId_ = value;
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x06016FB6 RID: 94134 RVA: 0x003578EC File Offset: 0x00355AEC
		// (set) Token: 0x06016FB7 RID: 94135 RVA: 0x003578F4 File Offset: 0x00355AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchId
		{
			get
			{
				return this.branchId_;
			}
			set
			{
				this.branchId_ = value;
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x06016FB8 RID: 94136 RVA: 0x003578FD File Offset: 0x00355AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleSkillBranchIds
		{
			get
			{
				return this.roleSkillBranchIds_;
			}
		}

		// Token: 0x06016FB9 RID: 94137 RVA: 0x00357905 File Offset: 0x00355B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerInstParam);
		}

		// Token: 0x06016FBA RID: 94138 RVA: 0x00357914 File Offset: 0x00355B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerInstParam other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.IsContinue == other.IsContinue && this.TokenId == other.TokenId && this.BranchId == other.BranchId && this.RoleSkillBranchIds.Equals(other.RoleSkillBranchIds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FBB RID: 94139 RVA: 0x00357994 File Offset: 0x00355B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.IsContinue)
			{
				num ^= this.IsContinue.GetHashCode();
			}
			if (this.TokenId != 0)
			{
				num ^= this.TokenId.GetHashCode();
			}
			if (this.BranchId != 0)
			{
				num ^= this.BranchId.GetHashCode();
			}
			num ^= this.RoleSkillBranchIds.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FBC RID: 94140 RVA: 0x00357A2C File Offset: 0x00355C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FBD RID: 94141 RVA: 0x00357A39 File Offset: 0x00355C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FBE RID: 94142 RVA: 0x00357A44 File Offset: 0x00355C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.IsContinue)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsContinue);
			}
			if (this.TokenId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TokenId);
			}
			if (this.BranchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BranchId);
			}
			this.roleSkillBranchIds_.WriteTo(ref output, RoleTowerInstParam._map_roleSkillBranchIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FBF RID: 94143 RVA: 0x00357AE8 File Offset: 0x00355CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.IsContinue)
			{
				num += 2;
			}
			if (this.TokenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenId);
			}
			if (this.BranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchId);
			}
			num += this.roleSkillBranchIds_.CalculateSize(RoleTowerInstParam._map_roleSkillBranchIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FC0 RID: 94144 RVA: 0x00357B78 File Offset: 0x00355D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerInstParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.IsContinue)
			{
				this.IsContinue = other.IsContinue;
			}
			if (other.TokenId != 0)
			{
				this.TokenId = other.TokenId;
			}
			if (other.BranchId != 0)
			{
				this.BranchId = other.BranchId;
			}
			this.roleSkillBranchIds_.MergeFrom(other.roleSkillBranchIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FC1 RID: 94145 RVA: 0x00357C01 File Offset: 0x00355E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FC2 RID: 94146 RVA: 0x00357C0C File Offset: 0x00355E0C
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
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsContinue = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TokenId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BranchId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.roleSkillBranchIds_.AddEntriesFrom(ref input, RoleTowerInstParam._map_roleSkillBranchIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008987 RID: 35207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008988 RID: 35208
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04008989 RID: 35209
		private int levelId_;

		// Token: 0x0400898A RID: 35210
		public const int IsContinueFieldNumber = 2;

		// Token: 0x0400898B RID: 35211
		private bool isContinue_;

		// Token: 0x0400898C RID: 35212
		public const int TokenIdFieldNumber = 3;

		// Token: 0x0400898D RID: 35213
		private int tokenId_;

		// Token: 0x0400898E RID: 35214
		public const int BranchIdFieldNumber = 4;

		// Token: 0x0400898F RID: 35215
		private int branchId_;

		// Token: 0x04008990 RID: 35216
		public const int RoleSkillBranchIdsFieldNumber = 5;

		// Token: 0x04008991 RID: 35217
		private static readonly MapField<int, int>.Codec _map_roleSkillBranchIds_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04008992 RID: 35218
		private readonly MapField<int, int> roleSkillBranchIds_ = new MapField<int, int>();
	}
}
