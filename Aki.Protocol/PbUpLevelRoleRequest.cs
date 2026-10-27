using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C12 RID: 3090
	[NetMessage(EMessageId.PbUpLevelRoleRequest)]
	public sealed class PbUpLevelRoleRequest : IMessage<PbUpLevelRoleRequest>, IMessage, IEquatable<PbUpLevelRoleRequest>, IDeepCloneable<PbUpLevelRoleRequest>, IBufferMessage
	{
		// Token: 0x06010C60 RID: 68704 RVA: 0x00274D87 File Offset: 0x00272F87
		[NullableContext(1)]
		public static PbUpLevelRoleRequest Create()
		{
			return new PbUpLevelRoleRequest();
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x06010C61 RID: 68705 RVA: 0x00274D8E File Offset: 0x00272F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x06010C62 RID: 68706 RVA: 0x00274D91 File Offset: 0x00272F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelRoleRequest.Descriptor;
			}
		}

		// Token: 0x06010C63 RID: 68707 RVA: 0x00274D98 File Offset: 0x00272F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest()
		{
		}

		// Token: 0x06010C64 RID: 68708 RVA: 0x00274DAB File Offset: 0x00272FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest(PbUpLevelRoleRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C65 RID: 68709 RVA: 0x00274DE1 File Offset: 0x00272FE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleRequest Clone()
		{
			return new PbUpLevelRoleRequest(this);
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x06010C66 RID: 68710 RVA: 0x00274DE9 File Offset: 0x00272FE9
		// (set) Token: 0x06010C67 RID: 68711 RVA: 0x00274DF1 File Offset: 0x00272FF1
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

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x06010C68 RID: 68712 RVA: 0x00274DFA File Offset: 0x00272FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06010C69 RID: 68713 RVA: 0x00274E02 File Offset: 0x00273002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelRoleRequest);
		}

		// Token: 0x06010C6A RID: 68714 RVA: 0x00274E10 File Offset: 0x00273010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelRoleRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C6B RID: 68715 RVA: 0x00274E60 File Offset: 0x00273060
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

		// Token: 0x06010C6C RID: 68716 RVA: 0x00274EAD File Offset: 0x002730AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C6D RID: 68717 RVA: 0x00274EBA File Offset: 0x002730BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C6E RID: 68718 RVA: 0x00274EC4 File Offset: 0x002730C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			this.itemList_.WriteTo(ref output, PbUpLevelRoleRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C6F RID: 68719 RVA: 0x00274F14 File Offset: 0x00273114
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

		// Token: 0x06010C70 RID: 68720 RVA: 0x00274F68 File Offset: 0x00273168
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

		// Token: 0x06010C71 RID: 68721 RVA: 0x00274FB5 File Offset: 0x002731B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C72 RID: 68722 RVA: 0x00274FC0 File Offset: 0x002731C0
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
				if (num != 48U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemList_.AddEntriesFrom(ref input, PbUpLevelRoleRequest._repeated_itemList_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A89 RID: 27273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A8A RID: 27274
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04006A8B RID: 27275
		private int roleId_;

		// Token: 0x04006A8C RID: 27276
		public const int ItemListFieldNumber = 9;

		// Token: 0x04006A8D RID: 27277
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(74U, ArrayIntInt.Parser);

		// Token: 0x04006A8E RID: 27278
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
