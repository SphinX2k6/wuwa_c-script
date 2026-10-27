using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000430 RID: 1072
	[NetMessage(EMessageId.ElevatorMoveNotify)]
	public sealed class ElevatorMoveNotify : IMessage<ElevatorMoveNotify>, IMessage, IEquatable<ElevatorMoveNotify>, IDeepCloneable<ElevatorMoveNotify>, IBufferMessage
	{
		// Token: 0x060066D5 RID: 26325 RVA: 0x000F7233 File Offset: 0x000F5433
		[NullableContext(1)]
		public static ElevatorMoveNotify Create()
		{
			return new ElevatorMoveNotify();
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x000F723A File Offset: 0x000F543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x000F723D File Offset: 0x000F543D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorMoveNotify.Descriptor;
			}
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x000F7244 File Offset: 0x000F5444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify()
		{
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x000F724C File Offset: 0x000F544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify(ElevatorMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = other.location_;
			this.moveType_ = ((other.moveType_ != null) ? other.moveType_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x000F72A4 File Offset: 0x000F54A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify Clone()
		{
			return new ElevatorMoveNotify(this);
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x000F72AC File Offset: 0x000F54AC
		// (set) Token: 0x060066DC RID: 26332 RVA: 0x000F72B4 File Offset: 0x000F54B4
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x000F72BD File Offset: 0x000F54BD
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x000F72C5 File Offset: 0x000F54C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x000F72CE File Offset: 0x000F54CE
		// (set) Token: 0x060066E0 RID: 26336 RVA: 0x000F72D6 File Offset: 0x000F54D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb MoveType
		{
			get
			{
				return this.moveType_;
			}
			set
			{
				this.moveType_ = value;
			}
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x000F72DF File Offset: 0x000F54DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorMoveNotify);
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x000F72F0 File Offset: 0x000F54F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Location == other.Location && object.Equals(this.MoveType, other.MoveType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x000F7350 File Offset: 0x000F5550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Location != 0)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.moveType_ != null)
			{
				num ^= this.MoveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x000F73BE File Offset: 0x000F55BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x000F73CB File Offset: 0x000F55CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x000F73D4 File Offset: 0x000F55D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Location != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Location);
			}
			if (this.moveType_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MoveType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x000F744C File Offset: 0x000F564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Location != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Location);
			}
			if (this.moveType_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x000F74BC File Offset: 0x000F56BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElevatorMoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Location != 0)
			{
				this.Location = other.Location;
			}
			if (other.moveType_ != null)
			{
				if (this.moveType_ == null)
				{
					this.MoveType = new LiftMoveTypePb();
				}
				this.MoveType.MergeFrom(other.MoveType);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x000F7538 File Offset: 0x000F5738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x000F7544 File Offset: 0x000F5744
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
					if (num != 90U)
					{
						if (num != 104U)
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
						if (this.moveType_ == null)
						{
							this.MoveType = new LiftMoveTypePb();
						}
						input.ReadMessage(this.MoveType);
					}
				}
				else
				{
					this.Location = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400393B RID: 14651
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400393C RID: 14652
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400393D RID: 14653
		private long entityId_;

		// Token: 0x0400393E RID: 14654
		public const int LocationFieldNumber = 6;

		// Token: 0x0400393F RID: 14655
		private int location_;

		// Token: 0x04003940 RID: 14656
		public const int MoveTypeFieldNumber = 11;

		// Token: 0x04003941 RID: 14657
		private LiftMoveTypePb moveType_;
	}
}
