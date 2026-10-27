using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C13 RID: 3091
	[NetMessage(EMessageId.PbUpLevelRoleResponse)]
	public sealed class PbUpLevelRoleResponse : IMessage<PbUpLevelRoleResponse>, IMessage, IEquatable<PbUpLevelRoleResponse>, IDeepCloneable<PbUpLevelRoleResponse>, IBufferMessage
	{
		// Token: 0x06010C74 RID: 68724 RVA: 0x00275030 File Offset: 0x00273230
		[NullableContext(1)]
		public static PbUpLevelRoleResponse Create()
		{
			return new PbUpLevelRoleResponse();
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x06010C75 RID: 68725 RVA: 0x00275037 File Offset: 0x00273237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x06010C76 RID: 68726 RVA: 0x0027503A File Offset: 0x0027323A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelRoleResponse.Descriptor;
			}
		}

		// Token: 0x06010C77 RID: 68727 RVA: 0x00275041 File Offset: 0x00273241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse()
		{
		}

		// Token: 0x06010C78 RID: 68728 RVA: 0x00275054 File Offset: 0x00273254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse(PbUpLevelRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C79 RID: 68729 RVA: 0x002750B9 File Offset: 0x002732B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse Clone()
		{
			return new PbUpLevelRoleResponse(this);
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x06010C7A RID: 68730 RVA: 0x002750C1 File Offset: 0x002732C1
		// (set) Token: 0x06010C7B RID: 68731 RVA: 0x002750C9 File Offset: 0x002732C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x06010C7C RID: 68732 RVA: 0x002750D2 File Offset: 0x002732D2
		// (set) Token: 0x06010C7D RID: 68733 RVA: 0x002750DA File Offset: 0x002732DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x06010C7E RID: 68734 RVA: 0x002750E3 File Offset: 0x002732E3
		// (set) Token: 0x06010C7F RID: 68735 RVA: 0x002750EB File Offset: 0x002732EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x06010C80 RID: 68736 RVA: 0x002750F4 File Offset: 0x002732F4
		// (set) Token: 0x06010C81 RID: 68737 RVA: 0x002750FC File Offset: 0x002732FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x06010C82 RID: 68738 RVA: 0x00275105 File Offset: 0x00273305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06010C83 RID: 68739 RVA: 0x0027510D File Offset: 0x0027330D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelRoleResponse);
		}

		// Token: 0x06010C84 RID: 68740 RVA: 0x0027511C File Offset: 0x0027331C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.Exp == other.Exp && this.Level == other.Level && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C85 RID: 68741 RVA: 0x0027519C File Offset: 0x0027339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C86 RID: 68742 RVA: 0x0027523A File Offset: 0x0027343A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C87 RID: 68743 RVA: 0x00275247 File Offset: 0x00273447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C88 RID: 68744 RVA: 0x00275250 File Offset: 0x00273450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PbUpLevelRoleResponse._map_itemMap_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C89 RID: 68745 RVA: 0x002752F4 File Offset: 0x002734F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.itemMap_.CalculateSize(PbUpLevelRoleResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C8A RID: 68746 RVA: 0x00275390 File Offset: 0x00273590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbUpLevelRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C8B RID: 68747 RVA: 0x00275419 File Offset: 0x00273619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C8C RID: 68748 RVA: 0x00275424 File Offset: 0x00273624
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.itemMap_.AddEntriesFrom(ref input, PbUpLevelRoleResponse._map_itemMap_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006A8F RID: 27279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A90 RID: 27280
		public const int CodeFieldNumber = 7;

		// Token: 0x04006A91 RID: 27281
		private ErrorCode code_;

		// Token: 0x04006A92 RID: 27282
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04006A93 RID: 27283
		private int roleId_;

		// Token: 0x04006A94 RID: 27284
		public const int ExpFieldNumber = 15;

		// Token: 0x04006A95 RID: 27285
		private int exp_;

		// Token: 0x04006A96 RID: 27286
		public const int LevelFieldNumber = 14;

		// Token: 0x04006A97 RID: 27287
		private int level_;

		// Token: 0x04006A98 RID: 27288
		public const int ItemMapFieldNumber = 1;

		// Token: 0x04006A99 RID: 27289
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04006A9A RID: 27290
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
