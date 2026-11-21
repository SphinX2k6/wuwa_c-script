using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001304 RID: 4868
	[NetMessage(EMessageId.StopMoveSplineRequest)]
	public sealed class StopMoveSplineRequest : IMessage<StopMoveSplineRequest>, IMessage, IEquatable<StopMoveSplineRequest>, IDeepCloneable<StopMoveSplineRequest>, IBufferMessage
	{
		// Token: 0x06019F72 RID: 106354 RVA: 0x003C940F File Offset: 0x003C760F
		[NullableContext(1)]
		public static StopMoveSplineRequest Create()
		{
			return new StopMoveSplineRequest();
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x06019F73 RID: 106355 RVA: 0x003C9416 File Offset: 0x003C7616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x06019F74 RID: 106356 RVA: 0x003C9419 File Offset: 0x003C7619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopMoveSplineRequest.Descriptor;
			}
		}

		// Token: 0x06019F75 RID: 106357 RVA: 0x003C9420 File Offset: 0x003C7620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest()
		{
		}

		// Token: 0x06019F76 RID: 106358 RVA: 0x003C9428 File Offset: 0x003C7628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest(StopMoveSplineRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityId_ = other.splineEntityId_;
			this.isInterrupt_ = other.isInterrupt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F77 RID: 106359 RVA: 0x003C9465 File Offset: 0x003C7665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineRequest Clone()
		{
			return new StopMoveSplineRequest(this);
		}

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x06019F78 RID: 106360 RVA: 0x003C946D File Offset: 0x003C766D
		// (set) Token: 0x06019F79 RID: 106361 RVA: 0x003C9475 File Offset: 0x003C7675
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

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x06019F7A RID: 106362 RVA: 0x003C947E File Offset: 0x003C767E
		// (set) Token: 0x06019F7B RID: 106363 RVA: 0x003C9486 File Offset: 0x003C7686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityId
		{
			get
			{
				return this.splineEntityId_;
			}
			set
			{
				this.splineEntityId_ = value;
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x06019F7C RID: 106364 RVA: 0x003C948F File Offset: 0x003C768F
		// (set) Token: 0x06019F7D RID: 106365 RVA: 0x003C9497 File Offset: 0x003C7697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInterrupt
		{
			get
			{
				return this.isInterrupt_;
			}
			set
			{
				this.isInterrupt_ = value;
			}
		}

		// Token: 0x06019F7E RID: 106366 RVA: 0x003C94A0 File Offset: 0x003C76A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopMoveSplineRequest);
		}

		// Token: 0x06019F7F RID: 106367 RVA: 0x003C94B0 File Offset: 0x003C76B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopMoveSplineRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityId == other.SplineEntityId && this.IsInterrupt == other.IsInterrupt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F80 RID: 106368 RVA: 0x003C950C File Offset: 0x003C770C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineEntityId != 0)
			{
				num ^= this.SplineEntityId.GetHashCode();
			}
			if (this.IsInterrupt)
			{
				num ^= this.IsInterrupt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F81 RID: 106369 RVA: 0x003C957D File Offset: 0x003C777D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F82 RID: 106370 RVA: 0x003C958A File Offset: 0x003C778A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F83 RID: 106371 RVA: 0x003C9594 File Offset: 0x003C7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsInterrupt)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsInterrupt);
			}
			if (this.SplineEntityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SplineEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F84 RID: 106372 RVA: 0x003C960C File Offset: 0x003C780C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityId);
			}
			if (this.IsInterrupt)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F85 RID: 106373 RVA: 0x003C9670 File Offset: 0x003C7870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopMoveSplineRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineEntityId != 0)
			{
				this.SplineEntityId = other.SplineEntityId;
			}
			if (other.IsInterrupt)
			{
				this.IsInterrupt = other.IsInterrupt;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F86 RID: 106374 RVA: 0x003C96D4 File Offset: 0x003C78D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F87 RID: 106375 RVA: 0x003C96E0 File Offset: 0x003C78E0
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SplineEntityId = input.ReadInt32();
						}
					}
					else
					{
						this.IsInterrupt = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009904 RID: 39172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009905 RID: 39173
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04009906 RID: 39174
		private long entityId_;

		// Token: 0x04009907 RID: 39175
		public const int SplineEntityIdFieldNumber = 13;

		// Token: 0x04009908 RID: 39176
		private int splineEntityId_;

		// Token: 0x04009909 RID: 39177
		public const int IsInterruptFieldNumber = 10;

		// Token: 0x0400990A RID: 39178
		private bool isInterrupt_;
	}
}
