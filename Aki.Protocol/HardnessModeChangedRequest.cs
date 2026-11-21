using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000729 RID: 1833
	[NetMessage(EMessageId.HardnessModeChangedRequest)]
	public sealed class HardnessModeChangedRequest : IMessage<HardnessModeChangedRequest>, IMessage, IEquatable<HardnessModeChangedRequest>, IDeepCloneable<HardnessModeChangedRequest>, IBufferMessage
	{
		// Token: 0x0600A69F RID: 42655 RVA: 0x001919C0 File Offset: 0x0018FBC0
		[NullableContext(1)]
		public static HardnessModeChangedRequest Create()
		{
			return new HardnessModeChangedRequest();
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x001919C7 File Offset: 0x0018FBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x001919CA File Offset: 0x0018FBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedRequest.Descriptor;
			}
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x001919D1 File Offset: 0x0018FBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest()
		{
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x001919D9 File Offset: 0x0018FBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest(HardnessModeChangedRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hardnessModeId_ = other.hardnessModeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x00191A0A File Offset: 0x0018FC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest Clone()
		{
			return new HardnessModeChangedRequest(this);
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600A6A5 RID: 42661 RVA: 0x00191A12 File Offset: 0x0018FC12
		// (set) Token: 0x0600A6A6 RID: 42662 RVA: 0x00191A1A File Offset: 0x0018FC1A
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

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600A6A7 RID: 42663 RVA: 0x00191A23 File Offset: 0x0018FC23
		// (set) Token: 0x0600A6A8 RID: 42664 RVA: 0x00191A2B File Offset: 0x0018FC2B
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

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x00191A34 File Offset: 0x0018FC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedRequest);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x00191A42 File Offset: 0x0018FC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HardnessModeId == other.HardnessModeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x00191A80 File Offset: 0x0018FC80
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

		// Token: 0x0600A6AC RID: 42668 RVA: 0x00191AD8 File Offset: 0x0018FCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x00191AE5 File Offset: 0x0018FCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x00191AF0 File Offset: 0x0018FCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HardnessModeId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x00191B4C File Offset: 0x0018FD4C
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

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x00191BA4 File Offset: 0x0018FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HardnessModeChangedRequest other)
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

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x00191BF4 File Offset: 0x0018FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x00191C00 File Offset: 0x0018FE00
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
				if (num != 32U)
				{
					if (num != 56U)
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

		// Token: 0x04004CAE RID: 19630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CAF RID: 19631
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04004CB0 RID: 19632
		private long entityId_;

		// Token: 0x04004CB1 RID: 19633
		public const int HardnessModeIdFieldNumber = 4;

		// Token: 0x04004CB2 RID: 19634
		private int hardnessModeId_;
	}
}
