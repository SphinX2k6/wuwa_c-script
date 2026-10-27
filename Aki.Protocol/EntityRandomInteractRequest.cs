using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B6 RID: 1206
	[NetMessage(EMessageId.EntityRandomInteractRequest)]
	public sealed class EntityRandomInteractRequest : IMessage<EntityRandomInteractRequest>, IMessage, IEquatable<EntityRandomInteractRequest>, IDeepCloneable<EntityRandomInteractRequest>, IBufferMessage
	{
		// Token: 0x060072E0 RID: 29408 RVA: 0x00119CBD File Offset: 0x00117EBD
		[NullableContext(1)]
		public static EntityRandomInteractRequest Create()
		{
			return new EntityRandomInteractRequest();
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x060072E1 RID: 29409 RVA: 0x00119CC4 File Offset: 0x00117EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x00119CC7 File Offset: 0x00117EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRandomInteractRequest.Descriptor;
			}
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00119CCE File Offset: 0x00117ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest()
		{
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00119CD6 File Offset: 0x00117ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest(EntityRandomInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00119D07 File Offset: 0x00117F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRandomInteractRequest Clone()
		{
			return new EntityRandomInteractRequest(this);
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x060072E6 RID: 29414 RVA: 0x00119D0F File Offset: 0x00117F0F
		// (set) Token: 0x060072E7 RID: 29415 RVA: 0x00119D17 File Offset: 0x00117F17
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

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x00119D20 File Offset: 0x00117F20
		// (set) Token: 0x060072E9 RID: 29417 RVA: 0x00119D28 File Offset: 0x00117F28
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

		// Token: 0x060072EA RID: 29418 RVA: 0x00119D31 File Offset: 0x00117F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRandomInteractRequest);
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00119D3F File Offset: 0x00117F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRandomInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00119D80 File Offset: 0x00117F80
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

		// Token: 0x060072ED RID: 29421 RVA: 0x00119DD8 File Offset: 0x00117FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00119DE5 File Offset: 0x00117FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x00119DF0 File Offset: 0x00117FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00119E48 File Offset: 0x00118048
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

		// Token: 0x060072F1 RID: 29425 RVA: 0x00119EA0 File Offset: 0x001180A0
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

		// Token: 0x060072F2 RID: 29426 RVA: 0x00119EF0 File Offset: 0x001180F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00119EFC File Offset: 0x001180FC
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

		// Token: 0x04003CFF RID: 15615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D00 RID: 15616
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003D01 RID: 15617
		private long entityId_;

		// Token: 0x04003D02 RID: 15618
		public const int OptionIndexFieldNumber = 1;

		// Token: 0x04003D03 RID: 15619
		private int optionIndex_;
	}
}
