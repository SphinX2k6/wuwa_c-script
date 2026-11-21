using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000419 RID: 1049
	[NetMessage(EMessageId.ElevatorMoveNotify)]
	public sealed class ElevatorMoveNotify : IMessage<ElevatorMoveNotify>, IMessage, IEquatable<ElevatorMoveNotify>, IDeepCloneable<ElevatorMoveNotify>, IBufferMessage
	{
		// Token: 0x06006545 RID: 25925 RVA: 0x000F40BF File Offset: 0x000F22BF
		[NullableContext(1)]
		public static ElevatorMoveNotify Create()
		{
			return new ElevatorMoveNotify();
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x000F40C6 File Offset: 0x000F22C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x000F40C9 File Offset: 0x000F22C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorMoveNotify.Descriptor;
			}
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x000F40D0 File Offset: 0x000F22D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify()
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x000F40D8 File Offset: 0x000F22D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify(ElevatorMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = other.location_;
			this.moveType_ = ((other.moveType_ != null) ? other.moveType_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x000F4130 File Offset: 0x000F2330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorMoveNotify Clone()
		{
			return new ElevatorMoveNotify(this);
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x000F4138 File Offset: 0x000F2338
		// (set) Token: 0x0600654C RID: 25932 RVA: 0x000F4140 File Offset: 0x000F2340
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x000F4149 File Offset: 0x000F2349
		// (set) Token: 0x0600654E RID: 25934 RVA: 0x000F4151 File Offset: 0x000F2351
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

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x000F415A File Offset: 0x000F235A
		// (set) Token: 0x06006550 RID: 25936 RVA: 0x000F4162 File Offset: 0x000F2362
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

		// Token: 0x06006551 RID: 25937 RVA: 0x000F416B File Offset: 0x000F236B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorMoveNotify);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x000F417C File Offset: 0x000F237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Location == other.Location && object.Equals(this.MoveType, other.MoveType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x000F41DC File Offset: 0x000F23DC
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

		// Token: 0x06006554 RID: 25940 RVA: 0x000F424A File Offset: 0x000F244A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x000F4257 File Offset: 0x000F2457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x000F4260 File Offset: 0x000F2460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Location != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Location);
			}
			if (this.moveType_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MoveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x000F42D4 File Offset: 0x000F24D4
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

		// Token: 0x06006558 RID: 25944 RVA: 0x000F4344 File Offset: 0x000F2544
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

		// Token: 0x06006559 RID: 25945 RVA: 0x000F43C0 File Offset: 0x000F25C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x000F43CC File Offset: 0x000F25CC
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
				if (num != 8U)
				{
					if (num != 32U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003928 RID: 14632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003929 RID: 14633
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400392A RID: 14634
		private long entityId_;

		// Token: 0x0400392B RID: 14635
		public const int LocationFieldNumber = 4;

		// Token: 0x0400392C RID: 14636
		private int location_;

		// Token: 0x0400392D RID: 14637
		public const int MoveTypeFieldNumber = 15;

		// Token: 0x0400392E RID: 14638
		private LiftMoveTypePb moveType_;
	}
}
