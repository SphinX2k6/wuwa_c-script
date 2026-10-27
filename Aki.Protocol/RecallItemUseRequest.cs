using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB0 RID: 3760
	[NetMessage(EMessageId.RecallItemUseRequest)]
	public sealed class RecallItemUseRequest : IMessage<RecallItemUseRequest>, IMessage, IEquatable<RecallItemUseRequest>, IDeepCloneable<RecallItemUseRequest>, IBufferMessage
	{
		// Token: 0x060142D7 RID: 82647 RVA: 0x002EF9A5 File Offset: 0x002EDBA5
		[NullableContext(1)]
		public static RecallItemUseRequest Create()
		{
			return new RecallItemUseRequest();
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x060142D8 RID: 82648 RVA: 0x002EF9AC File Offset: 0x002EDBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x060142D9 RID: 82649 RVA: 0x002EF9AF File Offset: 0x002EDBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemUseRequest.Descriptor;
			}
		}

		// Token: 0x060142DA RID: 82650 RVA: 0x002EF9B6 File Offset: 0x002EDBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest()
		{
		}

		// Token: 0x060142DB RID: 82651 RVA: 0x002EF9BE File Offset: 0x002EDBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest(RecallItemUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142DC RID: 82652 RVA: 0x002EF9EF File Offset: 0x002EDBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseRequest Clone()
		{
			return new RecallItemUseRequest(this);
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x060142DD RID: 82653 RVA: 0x002EF9F7 File Offset: 0x002EDBF7
		// (set) Token: 0x060142DE RID: 82654 RVA: 0x002EF9FF File Offset: 0x002EDBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x060142DF RID: 82655 RVA: 0x002EFA08 File Offset: 0x002EDC08
		// (set) Token: 0x060142E0 RID: 82656 RVA: 0x002EFA10 File Offset: 0x002EDC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060142E1 RID: 82657 RVA: 0x002EFA19 File Offset: 0x002EDC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemUseRequest);
		}

		// Token: 0x060142E2 RID: 82658 RVA: 0x002EFA27 File Offset: 0x002EDC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142E3 RID: 82659 RVA: 0x002EFA68 File Offset: 0x002EDC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142E4 RID: 82660 RVA: 0x002EFAC0 File Offset: 0x002EDCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142E5 RID: 82661 RVA: 0x002EFACD File Offset: 0x002EDCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142E6 RID: 82662 RVA: 0x002EFAD8 File Offset: 0x002EDCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142E7 RID: 82663 RVA: 0x002EFB34 File Offset: 0x002EDD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142E8 RID: 82664 RVA: 0x002EFB8C File Offset: 0x002EDD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemUseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142E9 RID: 82665 RVA: 0x002EFBDC File Offset: 0x002EDDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142EA RID: 82666 RVA: 0x002EFBE8 File Offset: 0x002EDDE8
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AE2 RID: 31458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AE3 RID: 31459
		public const int CountFieldNumber = 10;

		// Token: 0x04007AE4 RID: 31460
		private int count_;

		// Token: 0x04007AE5 RID: 31461
		public const int ItemIdFieldNumber = 9;

		// Token: 0x04007AE6 RID: 31462
		private int itemId_;
	}
}
