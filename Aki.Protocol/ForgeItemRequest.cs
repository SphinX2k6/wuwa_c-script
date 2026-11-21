using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060E RID: 1550
	[NetMessage(EMessageId.ForgeItemRequest)]
	public sealed class ForgeItemRequest : IMessage<ForgeItemRequest>, IMessage, IEquatable<ForgeItemRequest>, IDeepCloneable<ForgeItemRequest>, IBufferMessage
	{
		// Token: 0x06008F7C RID: 36732 RVA: 0x0015BCC5 File Offset: 0x00159EC5
		[NullableContext(1)]
		public static ForgeItemRequest Create()
		{
			return new ForgeItemRequest();
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x0015BCCC File Offset: 0x00159ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06008F7E RID: 36734 RVA: 0x0015BCCF File Offset: 0x00159ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemRequest.Descriptor;
			}
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x0015BCD6 File Offset: 0x00159ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemRequest()
		{
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x0015BCE0 File Offset: 0x00159EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemRequest(ForgeItemRequest other) : this()
		{
			this.id_ = other.id_;
			this.roleId_ = other.roleId_;
			this.count_ = other.count_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x0015BD34 File Offset: 0x00159F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemRequest Clone()
		{
			return new ForgeItemRequest(this);
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06008F82 RID: 36738 RVA: 0x0015BD3C File Offset: 0x00159F3C
		// (set) Token: 0x06008F83 RID: 36739 RVA: 0x0015BD44 File Offset: 0x00159F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06008F84 RID: 36740 RVA: 0x0015BD4D File Offset: 0x00159F4D
		// (set) Token: 0x06008F85 RID: 36741 RVA: 0x0015BD55 File Offset: 0x00159F55
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

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06008F86 RID: 36742 RVA: 0x0015BD5E File Offset: 0x00159F5E
		// (set) Token: 0x06008F87 RID: 36743 RVA: 0x0015BD66 File Offset: 0x00159F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06008F88 RID: 36744 RVA: 0x0015BD6F File Offset: 0x00159F6F
		// (set) Token: 0x06008F89 RID: 36745 RVA: 0x0015BD77 File Offset: 0x00159F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0015BD80 File Offset: 0x00159F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemRequest);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0015BD90 File Offset: 0x00159F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.Count == other.Count && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0015BDFC File Offset: 0x00159FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0015BE86 File Offset: 0x0015A086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x0015BE93 File Offset: 0x0015A093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0015BE9C File Offset: 0x0015A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Count);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x0015BF30 File Offset: 0x0015A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x0015BFB8 File Offset: 0x0015A1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x0015C030 File Offset: 0x0015A230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x0015C03C File Offset: 0x0015A23C
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
				if (num <= 104U)
				{
					if (num == 96U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004601 RID: 17921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004602 RID: 17922
		public const int IdFieldNumber = 14;

		// Token: 0x04004603 RID: 17923
		private int id_;

		// Token: 0x04004604 RID: 17924
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04004605 RID: 17925
		private int roleId_;

		// Token: 0x04004606 RID: 17926
		public const int CountFieldNumber = 13;

		// Token: 0x04004607 RID: 17927
		private int count_;

		// Token: 0x04004608 RID: 17928
		public const int InteractEntityIdFieldNumber = 15;

		// Token: 0x04004609 RID: 17929
		private long interactEntityId_;
	}
}
