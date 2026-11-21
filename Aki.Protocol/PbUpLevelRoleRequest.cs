using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C02 RID: 3074
	[NetMessage(EMessageId.PbUpLevelRoleRequest)]
	public sealed class PbUpLevelRoleRequest : IMessage<PbUpLevelRoleRequest>, IMessage, IEquatable<PbUpLevelRoleRequest>, IDeepCloneable<PbUpLevelRoleRequest>, IBufferMessage
	{
		// Token: 0x06010B60 RID: 68448 RVA: 0x0027301B File Offset: 0x0027121B
		[NullableContext(1)]
		public static PbUpLevelRoleRequest Create()
		{
			return new PbUpLevelRoleRequest();
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x06010B61 RID: 68449 RVA: 0x00273022 File Offset: 0x00271222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x06010B62 RID: 68450 RVA: 0x00273025 File Offset: 0x00271225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelRoleRequest.Descriptor;
			}
		}

		// Token: 0x06010B63 RID: 68451 RVA: 0x0027302C File Offset: 0x0027122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest()
		{
		}

		// Token: 0x06010B64 RID: 68452 RVA: 0x0027303F File Offset: 0x0027123F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest(PbUpLevelRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B65 RID: 68453 RVA: 0x00273075 File Offset: 0x00271275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest Clone()
		{
			return new PbUpLevelRoleRequest(this);
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x06010B66 RID: 68454 RVA: 0x0027307D File Offset: 0x0027127D
		// (set) Token: 0x06010B67 RID: 68455 RVA: 0x00273085 File Offset: 0x00271285
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

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x06010B68 RID: 68456 RVA: 0x0027308E File Offset: 0x0027128E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06010B69 RID: 68457 RVA: 0x00273096 File Offset: 0x00271296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelRoleRequest);
		}

		// Token: 0x06010B6A RID: 68458 RVA: 0x002730A4 File Offset: 0x002712A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B6B RID: 68459 RVA: 0x002730F4 File Offset: 0x002712F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B6C RID: 68460 RVA: 0x00273141 File Offset: 0x00271341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B6D RID: 68461 RVA: 0x0027314E File Offset: 0x0027134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B6E RID: 68462 RVA: 0x00273158 File Offset: 0x00271358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, PbUpLevelRoleRequest._repeated_itemList_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B6F RID: 68463 RVA: 0x002731A8 File Offset: 0x002713A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.itemList_.CalculateSize(PbUpLevelRoleRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B70 RID: 68464 RVA: 0x002731FC File Offset: 0x002713FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbUpLevelRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B71 RID: 68465 RVA: 0x00273249 File Offset: 0x00271449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B72 RID: 68466 RVA: 0x00273254 File Offset: 0x00271454
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
				if (num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, PbUpLevelRoleRequest._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x04006A9D RID: 27293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A9E RID: 27294
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04006A9F RID: 27295
		private int roleId_;

		// Token: 0x04006AA0 RID: 27296
		public const int ItemListFieldNumber = 5;

		// Token: 0x04006AA1 RID: 27297
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(42U, ArrayIntInt.Parser);

		// Token: 0x04006AA2 RID: 27298
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
