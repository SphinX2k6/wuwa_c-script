using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073C RID: 1852
	[NetMessage(EMessageId.HardnessModeChangedNotify)]
	public sealed class HardnessModeChangedNotify : IMessage<HardnessModeChangedNotify>, IMessage, IEquatable<HardnessModeChangedNotify>, IDeepCloneable<HardnessModeChangedNotify>, IBufferMessage
	{
		// Token: 0x0600A7E1 RID: 42977 RVA: 0x00194153 File Offset: 0x00192353
		[NullableContext(1)]
		public static HardnessModeChangedNotify Create()
		{
			return new HardnessModeChangedNotify();
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x0019415A File Offset: 0x0019235A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x0019415D File Offset: 0x0019235D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedNotify.Descriptor;
			}
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x00194164 File Offset: 0x00192364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify()
		{
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x0019416C File Offset: 0x0019236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify(HardnessModeChangedNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hardnessModeId_ = other.hardnessModeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x0019419D File Offset: 0x0019239D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedNotify Clone()
		{
			return new HardnessModeChangedNotify(this);
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x001941A5 File Offset: 0x001923A5
		// (set) Token: 0x0600A7E8 RID: 42984 RVA: 0x001941AD File Offset: 0x001923AD
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

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x001941B6 File Offset: 0x001923B6
		// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x001941BE File Offset: 0x001923BE
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

		// Token: 0x0600A7EB RID: 42987 RVA: 0x001941C7 File Offset: 0x001923C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedNotify);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x001941D5 File Offset: 0x001923D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HardnessModeId == other.HardnessModeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x00194214 File Offset: 0x00192414
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

		// Token: 0x0600A7EE RID: 42990 RVA: 0x0019426C File Offset: 0x0019246C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x00194279 File Offset: 0x00192479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x00194284 File Offset: 0x00192484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HardnessModeId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x001942E0 File Offset: 0x001924E0
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

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x00194338 File Offset: 0x00192538
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

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x00194388 File Offset: 0x00192588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x00194394 File Offset: 0x00192594
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
					if (num != 96U)
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
					this.HardnessModeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CB0 RID: 19632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CB1 RID: 19633
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04004CB2 RID: 19634
		private long entityId_;

		// Token: 0x04004CB3 RID: 19635
		public const int HardnessModeIdFieldNumber = 11;

		// Token: 0x04004CB4 RID: 19636
		private int hardnessModeId_;
	}
}
