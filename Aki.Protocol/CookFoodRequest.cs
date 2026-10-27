using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F2 RID: 754
	[NetMessage(EMessageId.CookFoodRequest)]
	public sealed class CookFoodRequest : IMessage<CookFoodRequest>, IMessage, IEquatable<CookFoodRequest>, IDeepCloneable<CookFoodRequest>, IBufferMessage
	{
		// Token: 0x06004C71 RID: 19569 RVA: 0x000B9EE0 File Offset: 0x000B80E0
		[NullableContext(1)]
		public static CookFoodRequest Create()
		{
			return new CookFoodRequest();
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x000B9EE7 File Offset: 0x000B80E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x000B9EEA File Offset: 0x000B80EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFoodRequest.Descriptor;
			}
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x000B9EF1 File Offset: 0x000B80F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodRequest()
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x000B9EFC File Offset: 0x000B80FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodRequest(CookFoodRequest other) : this()
		{
			this.id_ = other.id_;
			this.roleId_ = other.roleId_;
			this.cookCount_ = other.cookCount_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x000B9F50 File Offset: 0x000B8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodRequest Clone()
		{
			return new CookFoodRequest(this);
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x000B9F58 File Offset: 0x000B8158
		// (set) Token: 0x06004C78 RID: 19576 RVA: 0x000B9F60 File Offset: 0x000B8160
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

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x000B9F69 File Offset: 0x000B8169
		// (set) Token: 0x06004C7A RID: 19578 RVA: 0x000B9F71 File Offset: 0x000B8171
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

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x000B9F7A File Offset: 0x000B817A
		// (set) Token: 0x06004C7C RID: 19580 RVA: 0x000B9F82 File Offset: 0x000B8182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookCount
		{
			get
			{
				return this.cookCount_;
			}
			set
			{
				this.cookCount_ = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x000B9F8B File Offset: 0x000B818B
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x000B9F93 File Offset: 0x000B8193
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

		// Token: 0x06004C7F RID: 19583 RVA: 0x000B9F9C File Offset: 0x000B819C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFoodRequest);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x000B9FAC File Offset: 0x000B81AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFoodRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.CookCount == other.CookCount && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x000BA018 File Offset: 0x000B8218
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
			if (this.CookCount != 0)
			{
				num ^= this.CookCount.GetHashCode();
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

		// Token: 0x06004C82 RID: 19586 RVA: 0x000BA0A2 File Offset: 0x000B82A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x000BA0AF File Offset: 0x000B82AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x000BA0B8 File Offset: 0x000B82B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.CookCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CookCount);
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

		// Token: 0x06004C85 RID: 19589 RVA: 0x000BA148 File Offset: 0x000B8348
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
			if (this.CookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookCount);
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

		// Token: 0x06004C86 RID: 19590 RVA: 0x000BA1D0 File Offset: 0x000B83D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookFoodRequest other)
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
			if (other.CookCount != 0)
			{
				this.CookCount = other.CookCount;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x000BA248 File Offset: 0x000B8448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x000BA254 File Offset: 0x000B8454
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.CookCount = input.ReadInt32();
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

		// Token: 0x040030F9 RID: 12537
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030FA RID: 12538
		public const int IdFieldNumber = 1;

		// Token: 0x040030FB RID: 12539
		private int id_;

		// Token: 0x040030FC RID: 12540
		public const int RoleIdFieldNumber = 2;

		// Token: 0x040030FD RID: 12541
		private int roleId_;

		// Token: 0x040030FE RID: 12542
		public const int CookCountFieldNumber = 13;

		// Token: 0x040030FF RID: 12543
		private int cookCount_;

		// Token: 0x04003100 RID: 12544
		public const int InteractEntityIdFieldNumber = 15;

		// Token: 0x04003101 RID: 12545
		private long interactEntityId_;
	}
}
