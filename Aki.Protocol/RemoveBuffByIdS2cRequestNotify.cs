using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE0 RID: 3808
	[NetMessage(EMessageId.RemoveBuffByIdS2cRequestNotify)]
	public sealed class RemoveBuffByIdS2cRequestNotify : IMessage<RemoveBuffByIdS2cRequestNotify>, IMessage, IEquatable<RemoveBuffByIdS2cRequestNotify>, IDeepCloneable<RemoveBuffByIdS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x060146F5 RID: 83701 RVA: 0x002F8C60 File Offset: 0x002F6E60
		[NullableContext(1)]
		public static RemoveBuffByIdS2cRequestNotify Create()
		{
			return new RemoveBuffByIdS2cRequestNotify();
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x060146F6 RID: 83702 RVA: 0x002F8C67 File Offset: 0x002F6E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x060146F7 RID: 83703 RVA: 0x002F8C6A File Offset: 0x002F6E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByIdS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x060146F8 RID: 83704 RVA: 0x002F8C71 File Offset: 0x002F6E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify()
		{
		}

		// Token: 0x060146F9 RID: 83705 RVA: 0x002F8C7C File Offset: 0x002F6E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify(RemoveBuffByIdS2cRequestNotify other) : this()
		{
			this.buffId_ = other.buffId_;
			this.stackCount_ = other.stackCount_;
			this.reason_ = other.reason_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146FA RID: 83706 RVA: 0x002F8CD0 File Offset: 0x002F6ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify Clone()
		{
			return new RemoveBuffByIdS2cRequestNotify(this);
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x060146FB RID: 83707 RVA: 0x002F8CD8 File Offset: 0x002F6ED8
		// (set) Token: 0x060146FC RID: 83708 RVA: 0x002F8CE0 File Offset: 0x002F6EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x060146FD RID: 83709 RVA: 0x002F8CE9 File Offset: 0x002F6EE9
		// (set) Token: 0x060146FE RID: 83710 RVA: 0x002F8CF1 File Offset: 0x002F6EF1
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

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x060146FF RID: 83711 RVA: 0x002F8CFA File Offset: 0x002F6EFA
		// (set) Token: 0x06014700 RID: 83712 RVA: 0x002F8D02 File Offset: 0x002F6F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x06014701 RID: 83713 RVA: 0x002F8D0B File Offset: 0x002F6F0B
		// (set) Token: 0x06014702 RID: 83714 RVA: 0x002F8D13 File Offset: 0x002F6F13
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

		// Token: 0x06014703 RID: 83715 RVA: 0x002F8D1C File Offset: 0x002F6F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByIdS2cRequestNotify);
		}

		// Token: 0x06014704 RID: 83716 RVA: 0x002F8D2C File Offset: 0x002F6F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByIdS2cRequestNotify other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014705 RID: 83717 RVA: 0x002F8D98 File Offset: 0x002F6F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.Reason != 0)
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

		// Token: 0x06014706 RID: 83718 RVA: 0x002F8E22 File Offset: 0x002F7022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014707 RID: 83719 RVA: 0x002F8E2F File Offset: 0x002F702F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014708 RID: 83720 RVA: 0x002F8E38 File Offset: 0x002F7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BuffId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014709 RID: 83721 RVA: 0x002F8ECC File Offset: 0x002F70CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
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

		// Token: 0x0601470A RID: 83722 RVA: 0x002F8F54 File Offset: 0x002F7154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffByIdS2cRequestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601470B RID: 83723 RVA: 0x002F8FCC File Offset: 0x002F71CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601470C RID: 83724 RVA: 0x002F8FD8 File Offset: 0x002F71D8
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
					if (num == 32U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.BuffId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C6E RID: 31854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C6F RID: 31855
		public const int BuffIdFieldNumber = 8;

		// Token: 0x04007C70 RID: 31856
		private long buffId_;

		// Token: 0x04007C71 RID: 31857
		public const int StackCountFieldNumber = 14;

		// Token: 0x04007C72 RID: 31858
		private int stackCount_;

		// Token: 0x04007C73 RID: 31859
		public const int ReasonFieldNumber = 13;

		// Token: 0x04007C74 RID: 31860
		private int reason_;

		// Token: 0x04007C75 RID: 31861
		public const int InstigatorIdFieldNumber = 4;

		// Token: 0x04007C76 RID: 31862
		private long instigatorId_;
	}
}
