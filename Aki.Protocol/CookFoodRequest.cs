using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F9 RID: 761
	[NetMessage(EMessageId.CookFoodRequest)]
	public sealed class CookFoodRequest : IMessage<CookFoodRequest>, IMessage, IEquatable<CookFoodRequest>, IDeepCloneable<CookFoodRequest>, IBufferMessage
	{
		// Token: 0x06004D4A RID: 19786 RVA: 0x000BC2C8 File Offset: 0x000BA4C8
		[NullableContext(1)]
		public static CookFoodRequest Create()
		{
			return new CookFoodRequest();
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x000BC2CF File Offset: 0x000BA4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x000BC2D2 File Offset: 0x000BA4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookFoodRequest.Descriptor;
			}
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x000BC2D9 File Offset: 0x000BA4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodRequest()
		{
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x000BC2E4 File Offset: 0x000BA4E4
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

		// Token: 0x06004D4F RID: 19791 RVA: 0x000BC338 File Offset: 0x000BA538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookFoodRequest Clone()
		{
			return new CookFoodRequest(this);
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x000BC340 File Offset: 0x000BA540
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x000BC348 File Offset: 0x000BA548
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

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x000BC351 File Offset: 0x000BA551
		// (set) Token: 0x06004D53 RID: 19795 RVA: 0x000BC359 File Offset: 0x000BA559
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

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06004D54 RID: 19796 RVA: 0x000BC362 File Offset: 0x000BA562
		// (set) Token: 0x06004D55 RID: 19797 RVA: 0x000BC36A File Offset: 0x000BA56A
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

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x000BC373 File Offset: 0x000BA573
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x000BC37B File Offset: 0x000BA57B
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

		// Token: 0x06004D58 RID: 19800 RVA: 0x000BC384 File Offset: 0x000BA584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookFoodRequest);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x000BC394 File Offset: 0x000BA594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookFoodRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.CookCount == other.CookCount && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x000BC400 File Offset: 0x000BA600
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

		// Token: 0x06004D5B RID: 19803 RVA: 0x000BC48A File Offset: 0x000BA68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x000BC497 File Offset: 0x000BA697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x000BC4A0 File Offset: 0x000BA6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.CookCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CookCount);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
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

		// Token: 0x06004D5E RID: 19806 RVA: 0x000BC534 File Offset: 0x000BA734
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

		// Token: 0x06004D5F RID: 19807 RVA: 0x000BC5BC File Offset: 0x000BA7BC
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

		// Token: 0x06004D60 RID: 19808 RVA: 0x000BC634 File Offset: 0x000BA834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x000BC640 File Offset: 0x000BA840
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
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.CookCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003190 RID: 12688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003191 RID: 12689
		public const int IdFieldNumber = 13;

		// Token: 0x04003192 RID: 12690
		private int id_;

		// Token: 0x04003193 RID: 12691
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04003194 RID: 12692
		private int roleId_;

		// Token: 0x04003195 RID: 12693
		public const int CookCountFieldNumber = 10;

		// Token: 0x04003196 RID: 12694
		private int cookCount_;

		// Token: 0x04003197 RID: 12695
		public const int InteractEntityIdFieldNumber = 3;

		// Token: 0x04003198 RID: 12696
		private long interactEntityId_;
	}
}
