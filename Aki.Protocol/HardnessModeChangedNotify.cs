using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000728 RID: 1832
	[NetMessage(EMessageId.HardnessModeChangedNotify)]
	public sealed class HardnessModeChangedNotify : IMessage<HardnessModeChangedNotify>, IMessage, IEquatable<HardnessModeChangedNotify>, IDeepCloneable<HardnessModeChangedNotify>, IBufferMessage
	{
		// Token: 0x0600A68B RID: 42635 RVA: 0x00191727 File Offset: 0x0018F927
		[NullableContext(1)]
		public static HardnessModeChangedNotify Create()
		{
			return new HardnessModeChangedNotify();
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x0019172E File Offset: 0x0018F92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x00191731 File Offset: 0x0018F931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedNotify.Descriptor;
			}
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x00191738 File Offset: 0x0018F938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify()
		{
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x00191740 File Offset: 0x0018F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify(HardnessModeChangedNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hardnessModeId_ = other.hardnessModeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x00191771 File Offset: 0x0018F971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify Clone()
		{
			return new HardnessModeChangedNotify(this);
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x00191779 File Offset: 0x0018F979
		// (set) Token: 0x0600A692 RID: 42642 RVA: 0x00191781 File Offset: 0x0018F981
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

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x0019178A File Offset: 0x0018F98A
		// (set) Token: 0x0600A694 RID: 42644 RVA: 0x00191792 File Offset: 0x0018F992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HardnessModeId
		{
			get
			{
				return this.hardnessModeId_;
			}
			set
			{
				this.hardnessModeId_ = value;
			}
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x0019179B File Offset: 0x0018F99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedNotify);
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x001917A9 File Offset: 0x0018F9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HardnessModeId == other.HardnessModeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x001917E8 File Offset: 0x0018F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HardnessModeId != 0)
			{
				num ^= this.HardnessModeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x00191840 File Offset: 0x0018FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x0019184D File Offset: 0x0018FA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A69A RID: 42650 RVA: 0x00191858 File Offset: 0x0018FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HardnessModeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x001918B4 File Offset: 0x0018FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HardnessModeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HardnessModeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A69C RID: 42652 RVA: 0x0019190C File Offset: 0x0018FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HardnessModeChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HardnessModeId != 0)
			{
				this.HardnessModeId = other.HardnessModeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A69D RID: 42653 RVA: 0x0019195C File Offset: 0x0018FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x00191968 File Offset: 0x0018FB68
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HardnessModeId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004CA9 RID: 19625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CAA RID: 19626
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04004CAB RID: 19627
		private long entityId_;

		// Token: 0x04004CAC RID: 19628
		public const int HardnessModeIdFieldNumber = 4;

		// Token: 0x04004CAD RID: 19629
		private int hardnessModeId_;
	}
}
