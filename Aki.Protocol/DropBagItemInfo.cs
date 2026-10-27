using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000405 RID: 1029
	public sealed class DropBagItemInfo : IMessage<DropBagItemInfo>, IMessage, IEquatable<DropBagItemInfo>, IDeepCloneable<DropBagItemInfo>, IBufferMessage
	{
		// Token: 0x0600634F RID: 25423 RVA: 0x000EEECC File Offset: 0x000ED0CC
		[NullableContext(1)]
		public static DropBagItemInfo Create()
		{
			return new DropBagItemInfo();
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x000EEED3 File Offset: 0x000ED0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropBagItemInfo> Parser
		{
			get
			{
				return DropBagItemInfo._parser;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06006351 RID: 25425 RVA: 0x000EEEDA File Offset: 0x000ED0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x000EEEDD File Offset: 0x000ED0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropBagItemInfo.Descriptor;
			}
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x000EEEE4 File Offset: 0x000ED0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo()
		{
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x000EEEEC File Offset: 0x000ED0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo(DropBagItemInfo other) : this()
		{
			this.showPlanId_ = other.showPlanId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x000EEF29 File Offset: 0x000ED129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo Clone()
		{
			return new DropBagItemInfo(this);
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x000EEF31 File Offset: 0x000ED131
		// (set) Token: 0x06006357 RID: 25431 RVA: 0x000EEF39 File Offset: 0x000ED139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowPlanId
		{
			get
			{
				return this.showPlanId_;
			}
			set
			{
				this.showPlanId_ = value;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x000EEF42 File Offset: 0x000ED142
		// (set) Token: 0x06006359 RID: 25433 RVA: 0x000EEF4A File Offset: 0x000ED14A
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

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x000EEF53 File Offset: 0x000ED153
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x000EEF5B File Offset: 0x000ED15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x000EEF64 File Offset: 0x000ED164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropBagItemInfo);
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x000EEF74 File Offset: 0x000ED174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropBagItemInfo other)
		{
			return other != null && (other == this || (this.ShowPlanId == other.ShowPlanId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x000EEFD0 File Offset: 0x000ED1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowPlanId != 0)
			{
				num ^= this.ShowPlanId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x000EF041 File Offset: 0x000ED241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x000EF04E File Offset: 0x000ED24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x000EF058 File Offset: 0x000ED258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowPlanId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x000EF0CC File Offset: 0x000ED2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowPlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x000EF13C File Offset: 0x000ED33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropBagItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowPlanId != 0)
			{
				this.ShowPlanId = other.ShowPlanId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x000EF1A0 File Offset: 0x000ED3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x000EF1AC File Offset: 0x000ED3AC
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemCount = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.ShowPlanId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400381B RID: 14363
		private static readonly MessageParser<DropBagItemInfo> _parser = new MessageParser<DropBagItemInfo>(() => new DropBagItemInfo());

		// Token: 0x0400381C RID: 14364
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400381D RID: 14365
		public const int ShowPlanIdFieldNumber = 1;

		// Token: 0x0400381E RID: 14366
		private int showPlanId_;

		// Token: 0x0400381F RID: 14367
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04003820 RID: 14368
		private int itemId_;

		// Token: 0x04003821 RID: 14369
		public const int ItemCountFieldNumber = 3;

		// Token: 0x04003822 RID: 14370
		private int itemCount_;
	}
}
