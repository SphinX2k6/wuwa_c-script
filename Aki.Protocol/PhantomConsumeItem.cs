using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB9 RID: 3257
	public sealed class PhantomConsumeItem : IMessage<PhantomConsumeItem>, IMessage, IEquatable<PhantomConsumeItem>, IDeepCloneable<PhantomConsumeItem>, IBufferMessage
	{
		// Token: 0x06011A87 RID: 72327 RVA: 0x0029631F File Offset: 0x0029451F
		[NullableContext(1)]
		public static PhantomConsumeItem Create()
		{
			return new PhantomConsumeItem();
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x06011A88 RID: 72328 RVA: 0x00296326 File Offset: 0x00294526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomConsumeItem> Parser
		{
			get
			{
				return PhantomConsumeItem._parser;
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x06011A89 RID: 72329 RVA: 0x0029632D File Offset: 0x0029452D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x06011A8A RID: 72330 RVA: 0x00296330 File Offset: 0x00294530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomConsumeItem.Descriptor;
			}
		}

		// Token: 0x06011A8B RID: 72331 RVA: 0x00296337 File Offset: 0x00294537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem()
		{
		}

		// Token: 0x06011A8C RID: 72332 RVA: 0x0029633F File Offset: 0x0029453F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem(PhantomConsumeItem other) : this()
		{
			this.incId_ = other.incId_;
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A8D RID: 72333 RVA: 0x0029637C File Offset: 0x0029457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem Clone()
		{
			return new PhantomConsumeItem(this);
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x06011A8E RID: 72334 RVA: 0x00296384 File Offset: 0x00294584
		// (set) Token: 0x06011A8F RID: 72335 RVA: 0x0029638C File Offset: 0x0029458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x06011A90 RID: 72336 RVA: 0x00296395 File Offset: 0x00294595
		// (set) Token: 0x06011A91 RID: 72337 RVA: 0x0029639D File Offset: 0x0029459D
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

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x06011A92 RID: 72338 RVA: 0x002963A6 File Offset: 0x002945A6
		// (set) Token: 0x06011A93 RID: 72339 RVA: 0x002963AE File Offset: 0x002945AE
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

		// Token: 0x06011A94 RID: 72340 RVA: 0x002963B7 File Offset: 0x002945B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomConsumeItem);
		}

		// Token: 0x06011A95 RID: 72341 RVA: 0x002963C8 File Offset: 0x002945C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomConsumeItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A96 RID: 72342 RVA: 0x00296424 File Offset: 0x00294624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
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

		// Token: 0x06011A97 RID: 72343 RVA: 0x00296495 File Offset: 0x00294695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A98 RID: 72344 RVA: 0x002964A2 File Offset: 0x002946A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A99 RID: 72345 RVA: 0x002964AC File Offset: 0x002946AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A9A RID: 72346 RVA: 0x00296520 File Offset: 0x00294720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
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

		// Token: 0x06011A9B RID: 72347 RVA: 0x00296590 File Offset: 0x00294790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomConsumeItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
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

		// Token: 0x06011A9C RID: 72348 RVA: 0x002965F4 File Offset: 0x002947F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A9D RID: 72349 RVA: 0x00296600 File Offset: 0x00294800
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
							this.ItemId = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F7F RID: 28543
		private static readonly MessageParser<PhantomConsumeItem> _parser = new MessageParser<PhantomConsumeItem>(() => new PhantomConsumeItem());

		// Token: 0x04006F80 RID: 28544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F81 RID: 28545
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006F82 RID: 28546
		private int incId_;

		// Token: 0x04006F83 RID: 28547
		public const int CountFieldNumber = 2;

		// Token: 0x04006F84 RID: 28548
		private int count_;

		// Token: 0x04006F85 RID: 28549
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006F86 RID: 28550
		private int itemId_;
	}
}
