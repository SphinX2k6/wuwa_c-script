using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAB RID: 2987
	[NetMessage(EMessageId.OrderRemoveBuffNotify)]
	public sealed class OrderRemoveBuffNotify : IMessage<OrderRemoveBuffNotify>, IMessage, IEquatable<OrderRemoveBuffNotify>, IDeepCloneable<OrderRemoveBuffNotify>, IBufferMessage
	{
		// Token: 0x06010330 RID: 66352 RVA: 0x0025D8C5 File Offset: 0x0025BAC5
		[NullableContext(1)]
		public static OrderRemoveBuffNotify Create()
		{
			return new OrderRemoveBuffNotify();
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x06010331 RID: 66353 RVA: 0x0025D8CC File Offset: 0x0025BACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x06010332 RID: 66354 RVA: 0x0025D8CF File Offset: 0x0025BACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffNotify.Descriptor;
			}
		}

		// Token: 0x06010333 RID: 66355 RVA: 0x0025D8D6 File Offset: 0x0025BAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify()
		{
		}

		// Token: 0x06010334 RID: 66356 RVA: 0x0025D8DE File Offset: 0x0025BADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify(OrderRemoveBuffNotify other) : this()
		{
			this.id_ = other.id_;
			this.stackCount_ = other.stackCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010335 RID: 66357 RVA: 0x0025D90F File Offset: 0x0025BB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffNotify Clone()
		{
			return new OrderRemoveBuffNotify(this);
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x06010336 RID: 66358 RVA: 0x0025D917 File Offset: 0x0025BB17
		// (set) Token: 0x06010337 RID: 66359 RVA: 0x0025D91F File Offset: 0x0025BB1F
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

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x06010338 RID: 66360 RVA: 0x0025D928 File Offset: 0x0025BB28
		// (set) Token: 0x06010339 RID: 66361 RVA: 0x0025D930 File Offset: 0x0025BB30
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

		// Token: 0x0601033A RID: 66362 RVA: 0x0025D939 File Offset: 0x0025BB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffNotify);
		}

		// Token: 0x0601033B RID: 66363 RVA: 0x0025D947 File Offset: 0x0025BB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StackCount == other.StackCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601033C RID: 66364 RVA: 0x0025D988 File Offset: 0x0025BB88
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

		// Token: 0x0601033D RID: 66365 RVA: 0x0025D9E0 File Offset: 0x0025BBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601033E RID: 66366 RVA: 0x0025D9ED File Offset: 0x0025BBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601033F RID: 66367 RVA: 0x0025D9F8 File Offset: 0x0025BBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StackCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.StackCount);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010340 RID: 66368 RVA: 0x0025DA54 File Offset: 0x0025BC54
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

		// Token: 0x06010341 RID: 66369 RVA: 0x0025DAAC File Offset: 0x0025BCAC
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

		// Token: 0x06010342 RID: 66370 RVA: 0x0025DAFC File Offset: 0x0025BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010343 RID: 66371 RVA: 0x0025DB08 File Offset: 0x0025BD08
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.StackCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006730 RID: 26416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006731 RID: 26417
		public const int IdFieldNumber = 12;

		// Token: 0x04006732 RID: 26418
		private long id_;

		// Token: 0x04006733 RID: 26419
		public const int StackCountFieldNumber = 5;

		// Token: 0x04006734 RID: 26420
		private int stackCount_;
	}
}
