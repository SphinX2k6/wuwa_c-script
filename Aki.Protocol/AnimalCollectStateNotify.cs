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
		// Token: 0x06002185 RID: 8581 RVA: 0x00059EE8 File Offset: 0x000580E8
		[NullableContext(1)]
		public static AnimalCollectStateNotify Create()
		{
			return new AnimalCollectStateNotify();
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x00059EEF File Offset: 0x000580EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00059EF2 File Offset: 0x000580F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalCollectStateNotify.Descriptor;
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00059EF9 File Offset: 0x000580F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify()
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00059F01 File Offset: 0x00058101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify(AnimalCollectStateNotify other) : this()
		{
			this.stateType_ = other.stateType_;
			this.entityId_ = other.entityId_;
			this.partId_ = other.partId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00059F3E File Offset: 0x0005813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectStateNotify Clone()
		{
			return new AnimalCollectStateNotify(this);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00059F46 File Offset: 0x00058146
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00059F4E File Offset: 0x0005814E
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x00059F57 File Offset: 0x00058157
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x00059F5F File Offset: 0x0005815F
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x00059F68 File Offset: 0x00058168
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00059F70 File Offset: 0x00058170
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

		// Token: 0x06002191 RID: 8593 RVA: 0x00059F79 File Offset: 0x00058179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalCollectStateNotify);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00059F88 File Offset: 0x00058188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalCollectStateNotify other)
		{
			return other != null && (other == this || (this.StateType == other.StateType && this.EntityId == other.EntityId && this.PartId == other.PartId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00059FE4 File Offset: 0x000581E4
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

		// Token: 0x06002194 RID: 8596 RVA: 0x0005A05B File Offset: 0x0005825B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x0005A068 File Offset: 0x00058268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0005A074 File Offset: 0x00058274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PartId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.StateType != AnimalCollectStateType.SlotCollected)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.StateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0005A0EC File Offset: 0x000582EC
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

		// Token: 0x06002198 RID: 8600 RVA: 0x0005A15C File Offset: 0x0005835C
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

		// Token: 0x06002199 RID: 8601 RVA: 0x0005A1C0 File Offset: 0x000583C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0005A1CC File Offset: 0x000583CC
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
							this.StateType = (AnimalCollectStateType)input.ReadEnum();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.PartId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002493 RID: 9363
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002494 RID: 9364
		public const int StateTypeFieldNumber = 14;

		// Token: 0x04002495 RID: 9365
		private AnimalCollectStateType stateType_;

		// Token: 0x04002496 RID: 9366
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04002497 RID: 9367
		private long entityId_;

		// Token: 0x04002498 RID: 9368
		public const int PartIdFieldNumber = 6;

		// Token: 0x04002499 RID: 9369
		private int partId_;
	}
}
