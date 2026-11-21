using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9B RID: 2971
	[NetMessage(EMessageId.OrderRemoveBuffNotify)]
	public sealed class OrderRemoveBuffNotify : IMessage<OrderRemoveBuffNotify>, IMessage, IEquatable<OrderRemoveBuffNotify>, IDeepCloneable<OrderRemoveBuffNotify>, IBufferMessage
	{
		// Token: 0x0601022C RID: 66092 RVA: 0x0025BA0D File Offset: 0x00259C0D
		[NullableContext(1)]
		public static OrderRemoveBuffNotify Create()
		{
			return new OrderRemoveBuffNotify();
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0601022D RID: 66093 RVA: 0x0025BA14 File Offset: 0x00259C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0601022E RID: 66094 RVA: 0x0025BA17 File Offset: 0x00259C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601022F RID: 66095 RVA: 0x0025BA1E File Offset: 0x00259C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify()
		{
		}

		// Token: 0x06010230 RID: 66096 RVA: 0x0025BA26 File Offset: 0x00259C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify(OrderRemoveBuffNotify other) : this()
		{
			this.id_ = other.id_;
			this.stackCount_ = other.stackCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010231 RID: 66097 RVA: 0x0025BA57 File Offset: 0x00259C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify Clone()
		{
			return new OrderRemoveBuffNotify(this);
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x06010232 RID: 66098 RVA: 0x0025BA5F File Offset: 0x00259C5F
		// (set) Token: 0x06010233 RID: 66099 RVA: 0x0025BA67 File Offset: 0x00259C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x06010234 RID: 66100 RVA: 0x0025BA70 File Offset: 0x00259C70
		// (set) Token: 0x06010235 RID: 66101 RVA: 0x0025BA78 File Offset: 0x00259C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x06010236 RID: 66102 RVA: 0x0025BA81 File Offset: 0x00259C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffNotify);
		}

		// Token: 0x06010237 RID: 66103 RVA: 0x0025BA8F File Offset: 0x00259C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StackCount == other.StackCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010238 RID: 66104 RVA: 0x0025BAD0 File Offset: 0x00259CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010239 RID: 66105 RVA: 0x0025BB28 File Offset: 0x00259D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601023A RID: 66106 RVA: 0x0025BB35 File Offset: 0x00259D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601023B RID: 66107 RVA: 0x0025BB40 File Offset: 0x00259D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601023C RID: 66108 RVA: 0x0025BB9C File Offset: 0x00259D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601023D RID: 66109 RVA: 0x0025BBF4 File Offset: 0x00259DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601023E RID: 66110 RVA: 0x0025BC44 File Offset: 0x00259E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601023F RID: 66111 RVA: 0x0025BC50 File Offset: 0x00259E50
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
				if (num != 16U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StackCount = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006740 RID: 26432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006741 RID: 26433
		public const int IdFieldNumber = 2;

		// Token: 0x04006742 RID: 26434
		private long id_;

		// Token: 0x04006743 RID: 26435
		public const int StackCountFieldNumber = 15;

		// Token: 0x04006744 RID: 26436
		private int stackCount_;
	}
}
