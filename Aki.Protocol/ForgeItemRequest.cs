using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000622 RID: 1570
	[NetMessage(EMessageId.ForgeItemRequest)]
	public sealed class ForgeItemRequest : IMessage<ForgeItemRequest>, IMessage, IEquatable<ForgeItemRequest>, IDeepCloneable<ForgeItemRequest>, IBufferMessage
	{
		// Token: 0x060090D2 RID: 37074 RVA: 0x0015E6F9 File Offset: 0x0015C8F9
		[NullableContext(1)]
		public static ForgeItemRequest Create()
		{
			return new ForgeItemRequest();
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x060090D3 RID: 37075 RVA: 0x0015E700 File Offset: 0x0015C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x0015E703 File Offset: 0x0015C903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeItemRequest.Descriptor;
			}
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x0015E70A File Offset: 0x0015C90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemRequest()
		{
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x0015E714 File Offset: 0x0015C914
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

		// Token: 0x060090D7 RID: 37079 RVA: 0x0015E768 File Offset: 0x0015C968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeItemRequest Clone()
		{
			return new ForgeItemRequest(this);
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x0015E770 File Offset: 0x0015C970
		// (set) Token: 0x060090D9 RID: 37081 RVA: 0x0015E778 File Offset: 0x0015C978
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

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x0015E781 File Offset: 0x0015C981
		// (set) Token: 0x060090DB RID: 37083 RVA: 0x0015E789 File Offset: 0x0015C989
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

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060090DC RID: 37084 RVA: 0x0015E792 File Offset: 0x0015C992
		// (set) Token: 0x060090DD RID: 37085 RVA: 0x0015E79A File Offset: 0x0015C99A
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

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060090DE RID: 37086 RVA: 0x0015E7A3 File Offset: 0x0015C9A3
		// (set) Token: 0x060090DF RID: 37087 RVA: 0x0015E7AB File Offset: 0x0015C9AB
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

		// Token: 0x060090E0 RID: 37088 RVA: 0x0015E7B4 File Offset: 0x0015C9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeItemRequest);
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x0015E7C4 File Offset: 0x0015C9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.Count == other.Count && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x0015E830 File Offset: 0x0015CA30
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

		// Token: 0x060090E3 RID: 37091 RVA: 0x0015E8BA File Offset: 0x0015CABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x0015E8C7 File Offset: 0x0015CAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0015E8D0 File Offset: 0x0015CAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x0015E960 File Offset: 0x0015CB60
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

		// Token: 0x060090E7 RID: 37095 RVA: 0x0015E9E8 File Offset: 0x0015CBE8
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

		// Token: 0x060090E8 RID: 37096 RVA: 0x0015EA60 File Offset: 0x0015CC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x0015EA6C File Offset: 0x0015CC6C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004608 RID: 17928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004609 RID: 17929
		public const int IdFieldNumber = 8;

		// Token: 0x0400460A RID: 17930
		private int id_;

		// Token: 0x0400460B RID: 17931
		public const int RoleIdFieldNumber = 6;

		// Token: 0x0400460C RID: 17932
		private int roleId_;

		// Token: 0x0400460D RID: 17933
		public const int CountFieldNumber = 1;

		// Token: 0x0400460E RID: 17934
		private int count_;

		// Token: 0x0400460F RID: 17935
		public const int InteractEntityIdFieldNumber = 3;

		// Token: 0x04004610 RID: 17936
		private long interactEntityId_;
	}
}
