using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9C RID: 2972
	[NetMessage(EMessageId.OrderRemoveBuffRequest)]
	public sealed class OrderRemoveBuffRequest : IMessage<OrderRemoveBuffRequest>, IMessage, IEquatable<OrderRemoveBuffRequest>, IDeepCloneable<OrderRemoveBuffRequest>, IBufferMessage
	{
		// Token: 0x06010240 RID: 66112 RVA: 0x0025BCA8 File Offset: 0x00259EA8
		[NullableContext(1)]
		public static OrderRemoveBuffRequest Create()
		{
			return new OrderRemoveBuffRequest();
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x06010241 RID: 66113 RVA: 0x0025BCAF File Offset: 0x00259EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x06010242 RID: 66114 RVA: 0x0025BCB2 File Offset: 0x00259EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderRemoveBuffRequest.Descriptor;
			}
		}

		// Token: 0x06010243 RID: 66115 RVA: 0x0025BCB9 File Offset: 0x00259EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest()
		{
		}

		// Token: 0x06010244 RID: 66116 RVA: 0x0025BCCC File Offset: 0x00259ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest(OrderRemoveBuffRequest other) : this()
		{
			this.id_ = other.id_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010245 RID: 66117 RVA: 0x0025BD20 File Offset: 0x00259F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderRemoveBuffRequest Clone()
		{
			return new OrderRemoveBuffRequest(this);
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x06010246 RID: 66118 RVA: 0x0025BD28 File Offset: 0x00259F28
		// (set) Token: 0x06010247 RID: 66119 RVA: 0x0025BD30 File Offset: 0x00259F30
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

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x06010248 RID: 66120 RVA: 0x0025BD39 File Offset: 0x00259F39
		// (set) Token: 0x06010249 RID: 66121 RVA: 0x0025BD41 File Offset: 0x00259F41
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

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0601024A RID: 66122 RVA: 0x0025BD4A File Offset: 0x00259F4A
		// (set) Token: 0x0601024B RID: 66123 RVA: 0x0025BD52 File Offset: 0x00259F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0601024C RID: 66124 RVA: 0x0025BD65 File Offset: 0x00259F65
		// (set) Token: 0x0601024D RID: 66125 RVA: 0x0025BD6D File Offset: 0x00259F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x0601024E RID: 66126 RVA: 0x0025BD76 File Offset: 0x00259F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderRemoveBuffRequest);
		}

		// Token: 0x0601024F RID: 66127 RVA: 0x0025BD84 File Offset: 0x00259F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderRemoveBuffRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StackCount == other.StackCount && !(this.Reason != other.Reason) && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010250 RID: 66128 RVA: 0x0025BDF4 File Offset: 0x00259FF4
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
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010251 RID: 66129 RVA: 0x0025BE80 File Offset: 0x0025A080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010252 RID: 66130 RVA: 0x0025BE8D File Offset: 0x0025A08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010253 RID: 66131 RVA: 0x0025BE98 File Offset: 0x0025A098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.StackCount);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010254 RID: 66132 RVA: 0x0025BF30 File Offset: 0x0025A130
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
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010255 RID: 66133 RVA: 0x0025BFBC File Offset: 0x0025A1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderRemoveBuffRequest other)
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
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010256 RID: 66134 RVA: 0x0025C039 File Offset: 0x0025A239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010257 RID: 66135 RVA: 0x0025C044 File Offset: 0x0025A244
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
				if (num <= 64U)
				{
					if (num == 50U)
					{
						this.Reason = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006745 RID: 26437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006746 RID: 26438
		public const int IdFieldNumber = 10;

		// Token: 0x04006747 RID: 26439
		private long id_;

		// Token: 0x04006748 RID: 26440
		public const int StackCountFieldNumber = 8;

		// Token: 0x04006749 RID: 26441
		private int stackCount_;

		// Token: 0x0400674A RID: 26442
		public const int ReasonFieldNumber = 6;

		// Token: 0x0400674B RID: 26443
		private string reason_ = "";

		// Token: 0x0400674C RID: 26444
		public const int InstigatorIdFieldNumber = 13;

		// Token: 0x0400674D RID: 26445
		private long instigatorId_;
	}
}
