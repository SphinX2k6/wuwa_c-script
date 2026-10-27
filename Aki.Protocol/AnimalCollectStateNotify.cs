using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E1 RID: 225
	[NetMessage(EMessageId.AnimalCollectStateNotify)]
	public sealed class AnimalCollectStateNotify : IMessage<AnimalCollectStateNotify>, IMessage, IEquatable<AnimalCollectStateNotify>, IDeepCloneable<AnimalCollectStateNotify>, IBufferMessage
	{
		// Token: 0x0600214E RID: 8526 RVA: 0x00059414 File Offset: 0x00057614
		[NullableContext(1)]
		public static AnimalCollectStateNotify Create()
		{
			return new AnimalCollectStateNotify();
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0005941B File Offset: 0x0005761B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0005941E File Offset: 0x0005761E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalCollectStateNotify.Descriptor;
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00059425 File Offset: 0x00057625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify()
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0005942D File Offset: 0x0005762D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify(AnimalCollectStateNotify other) : this()
		{
			this.stateType_ = other.stateType_;
			this.entityId_ = other.entityId_;
			this.partId_ = other.partId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0005946A File Offset: 0x0005766A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify Clone()
		{
			return new AnimalCollectStateNotify(this);
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00059472 File Offset: 0x00057672
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x0005947A File Offset: 0x0005767A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateType StateType
		{
			get
			{
				return this.stateType_;
			}
			set
			{
				this.stateType_ = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00059483 File Offset: 0x00057683
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x0005948B File Offset: 0x0005768B
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x00059494 File Offset: 0x00057694
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x0005949C File Offset: 0x0005769C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000594A5 File Offset: 0x000576A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalCollectStateNotify);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000594B4 File Offset: 0x000576B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalCollectStateNotify other)
		{
			return other != null && (other == this || (this.StateType == other.StateType && this.EntityId == other.EntityId && this.PartId == other.PartId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00059510 File Offset: 0x00057710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StateType != AnimalCollectStateType.SlotCollected)
			{
				num ^= this.StateType.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00059587 File Offset: 0x00057787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00059594 File Offset: 0x00057794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x000595A0 File Offset: 0x000577A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PartId);
			}
			if (this.StateType != AnimalCollectStateType.SlotCollected)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.StateType);
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

		// Token: 0x06002160 RID: 8544 RVA: 0x00059618 File Offset: 0x00057818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StateType != AnimalCollectStateType.SlotCollected)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StateType);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00059688 File Offset: 0x00057888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalCollectStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StateType != AnimalCollectStateType.SlotCollected)
			{
				this.StateType = other.StateType;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000596EC File Offset: 0x000578EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x000596F8 File Offset: 0x000578F8
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
					if (num != 32U)
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
						this.StateType = (AnimalCollectStateType)input.ReadEnum();
					}
				}
				else
				{
					this.PartId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002434 RID: 9268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002435 RID: 9269
		public const int StateTypeFieldNumber = 4;

		// Token: 0x04002436 RID: 9270
		private AnimalCollectStateType stateType_;

		// Token: 0x04002437 RID: 9271
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04002438 RID: 9272
		private long entityId_;

		// Token: 0x04002439 RID: 9273
		public const int PartIdFieldNumber = 2;

		// Token: 0x0400243A RID: 9274
		private int partId_;
	}
}
