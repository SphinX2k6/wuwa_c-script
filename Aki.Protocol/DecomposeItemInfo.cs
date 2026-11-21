using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A5 RID: 933
	public sealed class DecomposeItemInfo : IMessage<DecomposeItemInfo>, IMessage, IEquatable<DecomposeItemInfo>, IDeepCloneable<DecomposeItemInfo>, IBufferMessage
	{
		// Token: 0x06005C0F RID: 23567 RVA: 0x000DFFC9 File Offset: 0x000DE1C9
		[NullableContext(1)]
		public static DecomposeItemInfo Create()
		{
			return new DecomposeItemInfo();
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x000DFFD0 File Offset: 0x000DE1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DecomposeItemInfo> Parser
		{
			get
			{
				return DecomposeItemInfo._parser;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06005C11 RID: 23569 RVA: 0x000DFFD7 File Offset: 0x000DE1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x000DFFDA File Offset: 0x000DE1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecomposeItemInfo.Descriptor;
			}
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x000DFFE1 File Offset: 0x000DE1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo()
		{
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x000DFFE9 File Offset: 0x000DE1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo(DecomposeItemInfo other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x000E0026 File Offset: 0x000DE226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecomposeItemInfo Clone()
		{
			return new DecomposeItemInfo(this);
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x000E002E File Offset: 0x000DE22E
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x000E0036 File Offset: 0x000DE236
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

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x000E003F File Offset: 0x000DE23F
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x000E0047 File Offset: 0x000DE247
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

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x000E0050 File Offset: 0x000DE250
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x000E0058 File Offset: 0x000DE258
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

		// Token: 0x06005C1C RID: 23580 RVA: 0x000E0061 File Offset: 0x000DE261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecomposeItemInfo);
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x000E0070 File Offset: 0x000DE270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecomposeItemInfo other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x000E00CC File Offset: 0x000DE2CC
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

		// Token: 0x06005C1F RID: 23583 RVA: 0x000E013D File Offset: 0x000DE33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x000E014A File Offset: 0x000DE34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x000E0154 File Offset: 0x000DE354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x000E01CC File Offset: 0x000DE3CC
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

		// Token: 0x06005C23 RID: 23587 RVA: 0x000E023C File Offset: 0x000DE43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecomposeItemInfo other)
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
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x000E02A0 File Offset: 0x000DE4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x000E02AC File Offset: 0x000DE4AC
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 32U)
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
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003685 RID: 13957
		private static readonly MessageParser<DecomposeItemInfo> _parser = new MessageParser<DecomposeItemInfo>(() => new DecomposeItemInfo());

		// Token: 0x04003686 RID: 13958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003687 RID: 13959
		public const int CountFieldNumber = 2;

		// Token: 0x04003688 RID: 13960
		private int count_;

		// Token: 0x04003689 RID: 13961
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400368A RID: 13962
		private int itemId_;

		// Token: 0x0400368B RID: 13963
		public const int IncrIdFieldNumber = 4;

		// Token: 0x0400368C RID: 13964
		private int incrId_;
	}
}
