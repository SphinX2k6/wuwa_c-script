using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000637 RID: 1591
	public sealed class FoundationCoreInfo : IMessage<FoundationCoreInfo>, IMessage, IEquatable<FoundationCoreInfo>, IDeepCloneable<FoundationCoreInfo>, IBufferMessage
	{
		// Token: 0x06009299 RID: 37529 RVA: 0x001629B8 File Offset: 0x00160BB8
		[NullableContext(1)]
		public static FoundationCoreInfo Create()
		{
			return new FoundationCoreInfo();
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x001629BF File Offset: 0x00160BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x001629C2 File Offset: 0x00160BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreInfo.Descriptor;
			}
		}

		// Token: 0x0600929C RID: 37532 RVA: 0x001629C9 File Offset: 0x00160BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo()
		{
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x001629E8 File Offset: 0x00160BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo(FoundationCoreInfo other) : this()
		{
			this.sourceEntityId_ = other.sourceEntityId_;
			this.elementalBoxId_ = other.elementalBoxId_;
			this.state_ = other.state_;
			this.elementalType_ = other.elementalType_;
			this.priority_ = other.priority_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x00162A54 File Offset: 0x00160C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo Clone()
		{
			return new FoundationCoreInfo(this);
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x0600929F RID: 37535 RVA: 0x00162A5C File Offset: 0x00160C5C
		// (set) Token: 0x060092A0 RID: 37536 RVA: 0x00162A64 File Offset: 0x00160C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceEntityId
		{
			get
			{
				return this.sourceEntityId_;
			}
			set
			{
				this.sourceEntityId_ = value;
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x00162A6D File Offset: 0x00160C6D
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x00162A75 File Offset: 0x00160C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementalBoxId
		{
			get
			{
				return this.elementalBoxId_;
			}
			set
			{
				this.elementalBoxId_ = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x00162A7E File Offset: 0x00160C7E
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x00162A86 File Offset: 0x00160C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x00162A99 File Offset: 0x00160C99
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x00162AA1 File Offset: 0x00160CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ElementalType
		{
			get
			{
				return this.elementalType_;
			}
			set
			{
				this.elementalType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x00162AB4 File Offset: 0x00160CB4
		// (set) Token: 0x060092A8 RID: 37544 RVA: 0x00162ABC File Offset: 0x00160CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Priority
		{
			get
			{
				return this.priority_;
			}
			set
			{
				this.priority_ = value;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060092A9 RID: 37545 RVA: 0x00162AC5 File Offset: 0x00160CC5
		// (set) Token: 0x060092AA RID: 37546 RVA: 0x00162ACD File Offset: 0x00160CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x060092AB RID: 37547 RVA: 0x00162AD6 File Offset: 0x00160CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreInfo);
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00162AE4 File Offset: 0x00160CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreInfo other)
		{
			return other != null && (other == this || (this.SourceEntityId == other.SourceEntityId && this.ElementalBoxId == other.ElementalBoxId && !(this.State != other.State) && !(this.ElementalType != other.ElementalType) && this.Priority == other.Priority && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00162B78 File Offset: 0x00160D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceEntityId != 0)
			{
				num ^= this.SourceEntityId.GetHashCode();
			}
			if (this.ElementalBoxId != 0)
			{
				num ^= this.ElementalBoxId.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ElementalType.Length != 0)
			{
				num ^= this.ElementalType.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00162C38 File Offset: 0x00160E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x00162C45 File Offset: 0x00160E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x00162C50 File Offset: 0x00160E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceEntityId);
			}
			if (this.ElementalBoxId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ElementalBoxId);
			}
			if (this.State.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.State);
			}
			if (this.ElementalType.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ElementalType);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Priority);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00162D24 File Offset: 0x00160F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceEntityId);
			}
			if (this.ElementalBoxId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementalBoxId);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this.ElementalType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ElementalType);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x00162DE4 File Offset: 0x00160FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceEntityId != 0)
			{
				this.SourceEntityId = other.SourceEntityId;
			}
			if (other.ElementalBoxId != 0)
			{
				this.ElementalBoxId = other.ElementalBoxId;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			if (other.ElementalType.Length != 0)
			{
				this.ElementalType = other.ElementalType;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00162E8E File Offset: 0x0016108E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x00162E98 File Offset: 0x00161098
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.SourceEntityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ElementalBoxId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.State = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.ElementalType = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.Priority = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046A3 RID: 18083
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046A4 RID: 18084
		public const int SourceEntityIdFieldNumber = 1;

		// Token: 0x040046A5 RID: 18085
		private int sourceEntityId_;

		// Token: 0x040046A6 RID: 18086
		public const int ElementalBoxIdFieldNumber = 2;

		// Token: 0x040046A7 RID: 18087
		private int elementalBoxId_;

		// Token: 0x040046A8 RID: 18088
		public const int StateFieldNumber = 3;

		// Token: 0x040046A9 RID: 18089
		private string state_ = "";

		// Token: 0x040046AA RID: 18090
		public const int ElementalTypeFieldNumber = 4;

		// Token: 0x040046AB RID: 18091
		private string elementalType_ = "";

		// Token: 0x040046AC RID: 18092
		public const int PriorityFieldNumber = 5;

		// Token: 0x040046AD RID: 18093
		private int priority_;

		// Token: 0x040046AE RID: 18094
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040046AF RID: 18095
		private int entityId_;
	}
}
