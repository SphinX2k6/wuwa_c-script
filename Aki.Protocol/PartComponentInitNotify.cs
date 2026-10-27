using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC1 RID: 3009
	[NetMessage(EMessageId.PartComponentInitNotify)]
	public sealed class PartComponentInitNotify : IMessage<PartComponentInitNotify>, IMessage, IEquatable<PartComponentInitNotify>, IDeepCloneable<PartComponentInitNotify>, IBufferMessage
	{
		// Token: 0x060104E1 RID: 66785 RVA: 0x00261019 File Offset: 0x0025F219
		[NullableContext(1)]
		public static PartComponentInitNotify Create()
		{
			return new PartComponentInitNotify();
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x060104E2 RID: 66786 RVA: 0x00261020 File Offset: 0x0025F220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x060104E3 RID: 66787 RVA: 0x00261023 File Offset: 0x0025F223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitNotify.Descriptor;
			}
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x0026102A File Offset: 0x0025F22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify()
		{
		}

		// Token: 0x060104E5 RID: 66789 RVA: 0x00261034 File Offset: 0x0025F234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify(PartComponentInitNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partComponent_ = ((other.partComponent_ != null) ? other.partComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104E6 RID: 66790 RVA: 0x00261080 File Offset: 0x0025F280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify Clone()
		{
			return new PartComponentInitNotify(this);
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x060104E7 RID: 66791 RVA: 0x00261088 File Offset: 0x0025F288
		// (set) Token: 0x060104E8 RID: 66792 RVA: 0x00261090 File Offset: 0x0025F290
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x060104E9 RID: 66793 RVA: 0x00261099 File Offset: 0x0025F299
		// (set) Token: 0x060104EA RID: 66794 RVA: 0x002610A1 File Offset: 0x0025F2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb PartComponent
		{
			get
			{
				return this.partComponent_;
			}
			set
			{
				this.partComponent_ = value;
			}
		}

		// Token: 0x060104EB RID: 66795 RVA: 0x002610AA File Offset: 0x0025F2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitNotify);
		}

		// Token: 0x060104EC RID: 66796 RVA: 0x002610B8 File Offset: 0x0025F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104ED RID: 66797 RVA: 0x00261108 File Offset: 0x0025F308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.partComponent_ != null)
			{
				num ^= this.PartComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060104EE RID: 66798 RVA: 0x0026115D File Offset: 0x0025F35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104EF RID: 66799 RVA: 0x0026116A File Offset: 0x0025F36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104F0 RID: 66800 RVA: 0x00261174 File Offset: 0x0025F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.partComponent_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PartComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104F1 RID: 66801 RVA: 0x002611D0 File Offset: 0x0025F3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.partComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060104F2 RID: 66802 RVA: 0x00261228 File Offset: 0x0025F428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartComponentInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.partComponent_ != null)
			{
				if (this.partComponent_ == null)
				{
					this.PartComponent = new PartComponentPb();
				}
				this.PartComponent.MergeFrom(other.PartComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060104F3 RID: 66803 RVA: 0x00261290 File Offset: 0x0025F490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104F4 RID: 66804 RVA: 0x0026129C File Offset: 0x0025F49C
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.partComponent_ == null)
						{
							this.PartComponent = new PartComponentPb();
						}
						input.ReadMessage(this.PartComponent);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067A6 RID: 26534
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067A7 RID: 26535
		public const int EntityIdFieldNumber = 9;

		// Token: 0x040067A8 RID: 26536
		private long entityId_;

		// Token: 0x040067A9 RID: 26537
		public const int PartComponentFieldNumber = 13;

		// Token: 0x040067AA RID: 26538
		private PartComponentPb partComponent_;
	}
}
