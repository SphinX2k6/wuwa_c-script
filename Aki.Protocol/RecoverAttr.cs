using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED5 RID: 3797
	public sealed class RecoverAttr : IMessage<RecoverAttr>, IMessage, IEquatable<RecoverAttr>, IDeepCloneable<RecoverAttr>, IBufferMessage
	{
		// Token: 0x060145A3 RID: 83363 RVA: 0x002F50CB File Offset: 0x002F32CB
		[NullableContext(1)]
		public static RecoverAttr Create()
		{
			return new RecoverAttr();
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x060145A4 RID: 83364 RVA: 0x002F50D2 File Offset: 0x002F32D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecoverAttr> Parser
		{
			get
			{
				return RecoverAttr._parser;
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x060145A5 RID: 83365 RVA: 0x002F50D9 File Offset: 0x002F32D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x060145A6 RID: 83366 RVA: 0x002F50DC File Offset: 0x002F32DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverAttr.Descriptor;
			}
		}

		// Token: 0x060145A7 RID: 83367 RVA: 0x002F50E3 File Offset: 0x002F32E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr()
		{
		}

		// Token: 0x060145A8 RID: 83368 RVA: 0x002F50EC File Offset: 0x002F32EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr(RecoverAttr other) : this()
		{
			this.attrId_ = other.attrId_;
			this.ratio_ = other.ratio_;
			this.maxValue_ = other.maxValue_;
			this.currentValue_ = other.currentValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x002F5140 File Offset: 0x002F3340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr Clone()
		{
			return new RecoverAttr(this);
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x060145AA RID: 83370 RVA: 0x002F5148 File Offset: 0x002F3348
		// (set) Token: 0x060145AB RID: 83371 RVA: 0x002F5150 File Offset: 0x002F3350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttrId
		{
			get
			{
				return this.attrId_;
			}
			set
			{
				this.attrId_ = value;
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x060145AC RID: 83372 RVA: 0x002F5159 File Offset: 0x002F3359
		// (set) Token: 0x060145AD RID: 83373 RVA: 0x002F5161 File Offset: 0x002F3361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ratio
		{
			get
			{
				return this.ratio_;
			}
			set
			{
				this.ratio_ = value;
			}
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x060145AE RID: 83374 RVA: 0x002F516A File Offset: 0x002F336A
		// (set) Token: 0x060145AF RID: 83375 RVA: 0x002F5172 File Offset: 0x002F3372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxValue
		{
			get
			{
				return this.maxValue_;
			}
			set
			{
				this.maxValue_ = value;
			}
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x060145B0 RID: 83376 RVA: 0x002F517B File Offset: 0x002F337B
		// (set) Token: 0x060145B1 RID: 83377 RVA: 0x002F5183 File Offset: 0x002F3383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentValue
		{
			get
			{
				return this.currentValue_;
			}
			set
			{
				this.currentValue_ = value;
			}
		}

		// Token: 0x060145B2 RID: 83378 RVA: 0x002F518C File Offset: 0x002F338C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverAttr);
		}

		// Token: 0x060145B3 RID: 83379 RVA: 0x002F519C File Offset: 0x002F339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Ratio == other.Ratio && this.MaxValue == other.MaxValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145B4 RID: 83380 RVA: 0x002F5208 File Offset: 0x002F3408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrId != 0)
			{
				num ^= this.AttrId.GetHashCode();
			}
			if (this.Ratio != 0)
			{
				num ^= this.Ratio.GetHashCode();
			}
			if (this.MaxValue != 0)
			{
				num ^= this.MaxValue.GetHashCode();
			}
			if (this.CurrentValue != 0)
			{
				num ^= this.CurrentValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060145B5 RID: 83381 RVA: 0x002F5292 File Offset: 0x002F3492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145B6 RID: 83382 RVA: 0x002F529F File Offset: 0x002F349F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145B7 RID: 83383 RVA: 0x002F52A8 File Offset: 0x002F34A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttrId);
			}
			if (this.Ratio != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Ratio);
			}
			if (this.MaxValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxValue);
			}
			if (this.CurrentValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145B8 RID: 83384 RVA: 0x002F5338 File Offset: 0x002F3538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrId);
			}
			if (this.Ratio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ratio);
			}
			if (this.MaxValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxValue);
			}
			if (this.CurrentValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060145B9 RID: 83385 RVA: 0x002F53C0 File Offset: 0x002F35C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecoverAttr other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrId != 0)
			{
				this.AttrId = other.AttrId;
			}
			if (other.Ratio != 0)
			{
				this.Ratio = other.Ratio;
			}
			if (other.MaxValue != 0)
			{
				this.MaxValue = other.MaxValue;
			}
			if (other.CurrentValue != 0)
			{
				this.CurrentValue = other.CurrentValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145BA RID: 83386 RVA: 0x002F5438 File Offset: 0x002F3638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145BB RID: 83387 RVA: 0x002F5444 File Offset: 0x002F3644
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.AttrId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Ratio = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.MaxValue = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.CurrentValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B8C RID: 31628
		private static readonly MessageParser<RecoverAttr> _parser = new MessageParser<RecoverAttr>(() => new RecoverAttr());

		// Token: 0x04007B8D RID: 31629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B8E RID: 31630
		public const int AttrIdFieldNumber = 1;

		// Token: 0x04007B8F RID: 31631
		private int attrId_;

		// Token: 0x04007B90 RID: 31632
		public const int RatioFieldNumber = 2;

		// Token: 0x04007B91 RID: 31633
		private int ratio_;

		// Token: 0x04007B92 RID: 31634
		public const int MaxValueFieldNumber = 4;

		// Token: 0x04007B93 RID: 31635
		private int maxValue_;

		// Token: 0x04007B94 RID: 31636
		public const int CurrentValueFieldNumber = 5;

		// Token: 0x04007B95 RID: 31637
		private int currentValue_;
	}
}
