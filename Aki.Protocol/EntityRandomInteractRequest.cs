using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049F RID: 1183
	[NetMessage(EMessageId.EntityRandomInteractRequest)]
	public sealed class EntityRandomInteractRequest : IMessage<EntityRandomInteractRequest>, IMessage, IEquatable<EntityRandomInteractRequest>, IDeepCloneable<EntityRandomInteractRequest>, IBufferMessage
	{
		// Token: 0x06007150 RID: 29008 RVA: 0x00116B99 File Offset: 0x00114D99
		[NullableContext(1)]
		public static EntityRandomInteractRequest Create()
		{
			return new EntityRandomInteractRequest();
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x00116BA0 File Offset: 0x00114DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x00116BA3 File Offset: 0x00114DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRandomInteractRequest.Descriptor;
			}
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x00116BAA File Offset: 0x00114DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest()
		{
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00116BB2 File Offset: 0x00114DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest(EntityRandomInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00116BE3 File Offset: 0x00114DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest Clone()
		{
			return new EntityRandomInteractRequest(this);
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x00116BEB File Offset: 0x00114DEB
		// (set) Token: 0x06007157 RID: 29015 RVA: 0x00116BF3 File Offset: 0x00114DF3
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

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06007158 RID: 29016 RVA: 0x00116BFC File Offset: 0x00114DFC
		// (set) Token: 0x06007159 RID: 29017 RVA: 0x00116C04 File Offset: 0x00114E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00116C0D File Offset: 0x00114E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRandomInteractRequest);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x00116C1B File Offset: 0x00114E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRandomInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00116C5C File Offset: 0x00114E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00116CB4 File Offset: 0x00114EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00116CC1 File Offset: 0x00114EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00116CCC File Offset: 0x00114ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00116D28 File Offset: 0x00114F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00116D80 File Offset: 0x00114F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRandomInteractRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00116DD0 File Offset: 0x00114FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x00116DDC File Offset: 0x00114FDC
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
				if (num != 72U)
				{
					if (num != 88U)
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
					this.OptionIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003CEB RID: 15595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CEC RID: 15596
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003CED RID: 15597
		private long entityId_;

		// Token: 0x04003CEE RID: 15598
		public const int OptionIndexFieldNumber = 9;

		// Token: 0x04003CEF RID: 15599
		private int optionIndex_;
	}
}
