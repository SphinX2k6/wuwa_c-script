using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041A RID: 1050
	[NetMessage(EMessageId.ElevatorStateChangeRequest)]
	public sealed class ElevatorStateChangeRequest : IMessage<ElevatorStateChangeRequest>, IMessage, IEquatable<ElevatorStateChangeRequest>, IDeepCloneable<ElevatorStateChangeRequest>, IBufferMessage
	{
		// Token: 0x0600655B RID: 25947 RVA: 0x000F4449 File Offset: 0x000F2649
		[NullableContext(1)]
		public static ElevatorStateChangeRequest Create()
		{
			return new ElevatorStateChangeRequest();
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x000F4450 File Offset: 0x000F2650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x000F4453 File Offset: 0x000F2653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorStateChangeRequest.Descriptor;
			}
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x000F445A File Offset: 0x000F265A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest()
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x000F4462 File Offset: 0x000F2662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest(ElevatorStateChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.state_ = other.state_;
			this.tagState_ = other.tagState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x000F449F File Offset: 0x000F269F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest Clone()
		{
			return new ElevatorStateChangeRequest(this);
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x000F44A7 File Offset: 0x000F26A7
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x000F44AF File Offset: 0x000F26AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x000F44B8 File Offset: 0x000F26B8
		// (set) Token: 0x06006564 RID: 25956 RVA: 0x000F44C0 File Offset: 0x000F26C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x000F44C9 File Offset: 0x000F26C9
		// (set) Token: 0x06006566 RID: 25958 RVA: 0x000F44D1 File Offset: 0x000F26D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagState
		{
			get
			{
				return this.tagState_;
			}
			set
			{
				this.tagState_ = value;
			}
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x000F44DA File Offset: 0x000F26DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorStateChangeRequest);
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x000F44E8 File Offset: 0x000F26E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorStateChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.State == other.State && this.TagState == other.TagState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x000F4544 File Offset: 0x000F2744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.State != ElevatorState.End)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.TagState != 0)
			{
				num ^= this.TagState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x000F45BB File Offset: 0x000F27BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x000F45C8 File Offset: 0x000F27C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x000F45D4 File Offset: 0x000F27D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != ElevatorState.End)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.State);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.TagState != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TagState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x000F464C File Offset: 0x000F284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.State != ElevatorState.End)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.TagState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x000F46BC File Offset: 0x000F28BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElevatorStateChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.State != ElevatorState.End)
			{
				this.State = other.State;
			}
			if (other.TagState != 0)
			{
				this.TagState = other.TagState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x000F4720 File Offset: 0x000F2920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x000F472C File Offset: 0x000F292C
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
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TagState = input.ReadInt32();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.State = (ElevatorState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400392F RID: 14639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003930 RID: 14640
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003931 RID: 14641
		private long entityId_;

		// Token: 0x04003932 RID: 14642
		public const int StateFieldNumber = 4;

		// Token: 0x04003933 RID: 14643
		private ElevatorState state_;

		// Token: 0x04003934 RID: 14644
		public const int TagStateFieldNumber = 11;

		// Token: 0x04003935 RID: 14645
		private int tagState_;
	}
}
