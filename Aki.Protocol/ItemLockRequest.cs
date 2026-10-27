using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000856 RID: 2134
	[NetMessage(EMessageId.ItemLockRequest)]
	public sealed class ItemLockRequest : IMessage<ItemLockRequest>, IMessage, IEquatable<ItemLockRequest>, IDeepCloneable<ItemLockRequest>, IBufferMessage
	{
		// Token: 0x0600BE4A RID: 48714 RVA: 0x001C4324 File Offset: 0x001C2524
		[NullableContext(1)]
		public static ItemLockRequest Create()
		{
			return new ItemLockRequest();
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0600BE4B RID: 48715 RVA: 0x001C432B File Offset: 0x001C252B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x001C432E File Offset: 0x001C252E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemLockRequest.Descriptor;
			}
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x001C4335 File Offset: 0x001C2535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest()
		{
		}

		// Token: 0x0600BE4E RID: 48718 RVA: 0x001C433D File Offset: 0x001C253D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest(ItemLockRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x001C436E File Offset: 0x001C256E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockRequest Clone()
		{
			return new ItemLockRequest(this);
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x0600BE50 RID: 48720 RVA: 0x001C4376 File Offset: 0x001C2576
		// (set) Token: 0x0600BE51 RID: 48721 RVA: 0x001C437E File Offset: 0x001C257E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Oper
		{
			get
			{
				return this.oper_;
			}
			set
			{
				this.oper_ = value;
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600BE52 RID: 48722 RVA: 0x001C4387 File Offset: 0x001C2587
		// (set) Token: 0x0600BE53 RID: 48723 RVA: 0x001C438F File Offset: 0x001C258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x001C4398 File Offset: 0x001C2598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemLockRequest);
		}

		// Token: 0x0600BE55 RID: 48725 RVA: 0x001C43A6 File Offset: 0x001C25A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemLockRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x001C43E4 File Offset: 0x001C25E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Oper != 0)
			{
				num ^= this.Oper.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x001C443C File Offset: 0x001C263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE58 RID: 48728 RVA: 0x001C4449 File Offset: 0x001C2649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x001C4454 File Offset: 0x001C2654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Oper != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Oper);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x001C44B0 File Offset: 0x001C26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Oper);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x001C4508 File Offset: 0x001C2708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Oper != 0)
			{
				this.Oper = other.Oper;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE5C RID: 48732 RVA: 0x001C4558 File Offset: 0x001C2758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x001C4564 File Offset: 0x001C2764
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
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.Oper = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005304 RID: 21252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005305 RID: 21253
		public const int OperFieldNumber = 11;

		// Token: 0x04005306 RID: 21254
		private int oper_;

		// Token: 0x04005307 RID: 21255
		public const int IncrIdFieldNumber = 15;

		// Token: 0x04005308 RID: 21256
		private int incrId_;
	}
}
