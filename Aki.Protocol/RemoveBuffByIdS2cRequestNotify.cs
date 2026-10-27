using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF0 RID: 3824
	[NetMessage(EMessageId.RemoveBuffByIdS2cRequestNotify)]
	public sealed class RemoveBuffByIdS2cRequestNotify : IMessage<RemoveBuffByIdS2cRequestNotify>, IMessage, IEquatable<RemoveBuffByIdS2cRequestNotify>, IDeepCloneable<RemoveBuffByIdS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x060147DA RID: 83930 RVA: 0x002FA317 File Offset: 0x002F8517
		[NullableContext(1)]
		public static RemoveBuffByIdS2cRequestNotify Create()
		{
			return new RemoveBuffByIdS2cRequestNotify();
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x060147DB RID: 83931 RVA: 0x002FA31E File Offset: 0x002F851E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x060147DC RID: 83932 RVA: 0x002FA321 File Offset: 0x002F8521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffByIdS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x060147DD RID: 83933 RVA: 0x002FA328 File Offset: 0x002F8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify()
		{
		}

		// Token: 0x060147DE RID: 83934 RVA: 0x002FA330 File Offset: 0x002F8530
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

		// Token: 0x060147DF RID: 83935 RVA: 0x002FA384 File Offset: 0x002F8584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffByIdS2cRequestNotify Clone()
		{
			return new RemoveBuffByIdS2cRequestNotify(this);
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x060147E0 RID: 83936 RVA: 0x002FA38C File Offset: 0x002F858C
		// (set) Token: 0x060147E1 RID: 83937 RVA: 0x002FA394 File Offset: 0x002F8594
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

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x060147E2 RID: 83938 RVA: 0x002FA39D File Offset: 0x002F859D
		// (set) Token: 0x060147E3 RID: 83939 RVA: 0x002FA3A5 File Offset: 0x002F85A5
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

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x060147E4 RID: 83940 RVA: 0x002FA3AE File Offset: 0x002F85AE
		// (set) Token: 0x060147E5 RID: 83941 RVA: 0x002FA3B6 File Offset: 0x002F85B6
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

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x060147E6 RID: 83942 RVA: 0x002FA3BF File Offset: 0x002F85BF
		// (set) Token: 0x060147E7 RID: 83943 RVA: 0x002FA3C7 File Offset: 0x002F85C7
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

		// Token: 0x060147E8 RID: 83944 RVA: 0x002FA3D0 File Offset: 0x002F85D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffByIdS2cRequestNotify);
		}

		// Token: 0x060147E9 RID: 83945 RVA: 0x002FA3E0 File Offset: 0x002F85E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffByIdS2cRequestNotify other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.StackCount == other.StackCount && this.Reason == other.Reason && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147EA RID: 83946 RVA: 0x002FA44C File Offset: 0x002F864C
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

		// Token: 0x060147EB RID: 83947 RVA: 0x002FA4D6 File Offset: 0x002F86D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147EC RID: 83948 RVA: 0x002FA4E3 File Offset: 0x002F86E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147ED RID: 83949 RVA: 0x002FA4EC File Offset: 0x002F86EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BuffId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147EE RID: 83950 RVA: 0x002FA580 File Offset: 0x002F8780
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

		// Token: 0x060147EF RID: 83951 RVA: 0x002FA608 File Offset: 0x002F8808
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

		// Token: 0x060147F0 RID: 83952 RVA: 0x002FA680 File Offset: 0x002F8880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x002FA68C File Offset: 0x002F888C
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.BuffId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C44 RID: 31812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C45 RID: 31813
		public const int BuffIdFieldNumber = 4;

		// Token: 0x04007C46 RID: 31814
		private long buffId_;

		// Token: 0x04007C47 RID: 31815
		public const int StackCountFieldNumber = 13;

		// Token: 0x04007C48 RID: 31816
		private int stackCount_;

		// Token: 0x04007C49 RID: 31817
		public const int ReasonFieldNumber = 10;

		// Token: 0x04007C4A RID: 31818
		private int reason_;

		// Token: 0x04007C4B RID: 31819
		public const int InstigatorIdFieldNumber = 6;

		// Token: 0x04007C4C RID: 31820
		private long instigatorId_;
	}
}
