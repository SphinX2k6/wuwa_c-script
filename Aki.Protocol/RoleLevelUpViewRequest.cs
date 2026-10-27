using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001089 RID: 4233
	[NetMessage(EMessageId.RoleLevelUpViewRequest)]
	public sealed class RoleLevelUpViewRequest : IMessage<RoleLevelUpViewRequest>, IMessage, IEquatable<RoleLevelUpViewRequest>, IDeepCloneable<RoleLevelUpViewRequest>, IBufferMessage
	{
		// Token: 0x060169D2 RID: 92626 RVA: 0x00349814 File Offset: 0x00347A14
		[NullableContext(1)]
		public static RoleLevelUpViewRequest Create()
		{
			return new RoleLevelUpViewRequest();
		}

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x060169D3 RID: 92627 RVA: 0x0034981B File Offset: 0x00347A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x060169D4 RID: 92628 RVA: 0x0034981E File Offset: 0x00347A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLevelUpViewRequest.Descriptor;
			}
		}

		// Token: 0x060169D5 RID: 92629 RVA: 0x00349825 File Offset: 0x00347A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest()
		{
		}

		// Token: 0x060169D6 RID: 92630 RVA: 0x00349838 File Offset: 0x00347A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest(RoleLevelUpViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.maxItemId_ = other.maxItemId_;
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169D7 RID: 92631 RVA: 0x00349885 File Offset: 0x00347A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLevelUpViewRequest Clone()
		{
			return new RoleLevelUpViewRequest(this);
		}

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x060169D8 RID: 92632 RVA: 0x0034988D File Offset: 0x00347A8D
		// (set) Token: 0x060169D9 RID: 92633 RVA: 0x00349895 File Offset: 0x00347A95
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

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x060169DA RID: 92634 RVA: 0x0034989E File Offset: 0x00347A9E
		// (set) Token: 0x060169DB RID: 92635 RVA: 0x003498A6 File Offset: 0x00347AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxItemId
		{
			get
			{
				return this.maxItemId_;
			}
			set
			{
				this.maxItemId_ = value;
			}
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x060169DC RID: 92636 RVA: 0x003498AF File Offset: 0x00347AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x060169DD RID: 92637 RVA: 0x003498B7 File Offset: 0x00347AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLevelUpViewRequest);
		}

		// Token: 0x060169DE RID: 92638 RVA: 0x003498C8 File Offset: 0x00347AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLevelUpViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.MaxItemId == other.MaxItemId && this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169DF RID: 92639 RVA: 0x00349928 File Offset: 0x00347B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.MaxItemId != 0)
			{
				num ^= this.MaxItemId.GetHashCode();
			}
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060169E0 RID: 92640 RVA: 0x0034998E File Offset: 0x00347B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169E1 RID: 92641 RVA: 0x0034999B File Offset: 0x00347B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169E2 RID: 92642 RVA: 0x003499A4 File Offset: 0x00347BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.itemList_.WriteTo(ref output, RoleLevelUpViewRequest._repeated_itemList_codec);
			if (this.MaxItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MaxItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169E3 RID: 92643 RVA: 0x00349A10 File Offset: 0x00347C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.MaxItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxItemId);
			}
			num += this.itemList_.CalculateSize(RoleLevelUpViewRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060169E4 RID: 92644 RVA: 0x00349A7C File Offset: 0x00347C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleLevelUpViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.MaxItemId != 0)
			{
				this.MaxItemId = other.MaxItemId;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060169E5 RID: 92645 RVA: 0x00349ADD File Offset: 0x00347CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169E6 RID: 92646 RVA: 0x00349AE8 File Offset: 0x00347CE8
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MaxItemId = input.ReadInt32();
						}
					}
					else
					{
						this.itemList_.AddEntriesFrom(ref input, RoleLevelUpViewRequest._repeated_itemList_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008726 RID: 34598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008727 RID: 34599
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008728 RID: 34600
		private int roleId_;

		// Token: 0x04008729 RID: 34601
		public const int MaxItemIdFieldNumber = 7;

		// Token: 0x0400872A RID: 34602
		private int maxItemId_;

		// Token: 0x0400872B RID: 34603
		public const int ItemListFieldNumber = 2;

		// Token: 0x0400872C RID: 34604
		private static readonly FieldCodec<ArrayIntInt> _repeated_itemList_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x0400872D RID: 34605
		private readonly RepeatedField<ArrayIntInt> itemList_ = new RepeatedField<ArrayIntInt>();
	}
}
