using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000844 RID: 2116
	[NetMessage(EMessageId.ItemLockRequest)]
	public sealed class ItemLockRequest : IMessage<ItemLockRequest>, IMessage, IEquatable<ItemLockRequest>, IDeepCloneable<ItemLockRequest>, IBufferMessage
	{
		// Token: 0x0600BD1C RID: 48412 RVA: 0x001C1E58 File Offset: 0x001C0058
		[NullableContext(1)]
		public static ItemLockRequest Create()
		{
			return new ItemLockRequest();
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x001C1E5F File Offset: 0x001C005F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x001C1E62 File Offset: 0x001C0062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemLockRequest.Descriptor;
			}
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x001C1E69 File Offset: 0x001C0069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest()
		{
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x001C1E71 File Offset: 0x001C0071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest(ItemLockRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x001C1EA2 File Offset: 0x001C00A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest Clone()
		{
			return new ItemLockRequest(this);
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600BD22 RID: 48418 RVA: 0x001C1EAA File Offset: 0x001C00AA
		// (set) Token: 0x0600BD23 RID: 48419 RVA: 0x001C1EB2 File Offset: 0x001C00B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Oper
		{
			get
			{
				return this.oper_;
			}
			set
			{
				this.oper_ = value;
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x001C1EBB File Offset: 0x001C00BB
		// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x001C1EC3 File Offset: 0x001C00C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x001C1ECC File Offset: 0x001C00CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemLockRequest);
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x001C1EDA File Offset: 0x001C00DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemLockRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD28 RID: 48424 RVA: 0x001C1F18 File Offset: 0x001C0118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Oper != 0)
			{
				num ^= this.Oper.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x001C1F70 File Offset: 0x001C0170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x001C1F7D File Offset: 0x001C017D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD2B RID: 48427 RVA: 0x001C1F88 File Offset: 0x001C0188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncrId);
			}
			if (this.Oper != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Oper);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x001C1FE4 File Offset: 0x001C01E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Oper);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x001C203C File Offset: 0x001C023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Oper != 0)
			{
				this.Oper = other.Oper;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x001C208C File Offset: 0x001C028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x001C2098 File Offset: 0x001C0298
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
				if (num != 32U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Oper = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005307 RID: 21255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005308 RID: 21256
		public const int OperFieldNumber = 13;

		// Token: 0x04005309 RID: 21257
		private int oper_;

		// Token: 0x0400530A RID: 21258
		public const int IncrIdFieldNumber = 4;

		// Token: 0x0400530B RID: 21259
		private int incrId_;
	}
}
