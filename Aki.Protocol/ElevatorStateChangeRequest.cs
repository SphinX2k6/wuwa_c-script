using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000431 RID: 1073
	[NetMessage(EMessageId.ElevatorStateChangeRequest)]
	public sealed class ElevatorStateChangeRequest : IMessage<ElevatorStateChangeRequest>, IMessage, IEquatable<ElevatorStateChangeRequest>, IDeepCloneable<ElevatorStateChangeRequest>, IBufferMessage
	{
		// Token: 0x060066EB RID: 26347 RVA: 0x000F75C2 File Offset: 0x000F57C2
		[NullableContext(1)]
		public static ElevatorStateChangeRequest Create()
		{
			return new ElevatorStateChangeRequest();
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x000F75C9 File Offset: 0x000F57C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060066ED RID: 26349 RVA: 0x000F75CC File Offset: 0x000F57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorStateChangeRequest.Descriptor;
			}
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x000F75D3 File Offset: 0x000F57D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest()
		{
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x000F75DB File Offset: 0x000F57DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest(ElevatorStateChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.state_ = other.state_;
			this.tagState_ = other.tagState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x000F7618 File Offset: 0x000F5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeRequest Clone()
		{
			return new ElevatorStateChangeRequest(this);
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060066F1 RID: 26353 RVA: 0x000F7620 File Offset: 0x000F5820
		// (set) Token: 0x060066F2 RID: 26354 RVA: 0x000F7628 File Offset: 0x000F5828
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060066F3 RID: 26355 RVA: 0x000F7631 File Offset: 0x000F5831
		// (set) Token: 0x060066F4 RID: 26356 RVA: 0x000F7639 File Offset: 0x000F5839
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060066F5 RID: 26357 RVA: 0x000F7642 File Offset: 0x000F5842
		// (set) Token: 0x060066F6 RID: 26358 RVA: 0x000F764A File Offset: 0x000F584A
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

		// Token: 0x060066F7 RID: 26359 RVA: 0x000F7653 File Offset: 0x000F5853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorStateChangeRequest);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x000F7664 File Offset: 0x000F5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorStateChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.State == other.State && this.TagState == other.TagState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x000F76C0 File Offset: 0x000F58C0
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

		// Token: 0x060066FA RID: 26362 RVA: 0x000F7737 File Offset: 0x000F5937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x000F7744 File Offset: 0x000F5944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x000F7750 File Offset: 0x000F5950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagState != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TagState);
			}
			if (this.State != ElevatorState.End)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.State);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x000F77C8 File Offset: 0x000F59C8
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

		// Token: 0x060066FE RID: 26366 RVA: 0x000F7838 File Offset: 0x000F5A38
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

		// Token: 0x060066FF RID: 26367 RVA: 0x000F789C File Offset: 0x000F5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x000F78A8 File Offset: 0x000F5AA8
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.TagState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003942 RID: 14658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003943 RID: 14659
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003944 RID: 14660
		private long entityId_;

		// Token: 0x04003945 RID: 14661
		public const int StateFieldNumber = 12;

		// Token: 0x04003946 RID: 14662
		private ElevatorState state_;

		// Token: 0x04003947 RID: 14663
		public const int TagStateFieldNumber = 6;

		// Token: 0x04003948 RID: 14664
		private int tagState_;
	}
}
