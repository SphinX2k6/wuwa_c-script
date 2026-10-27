using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC9 RID: 3273
	public sealed class PhantomConsumeItem : IMessage<PhantomConsumeItem>, IMessage, IEquatable<PhantomConsumeItem>, IDeepCloneable<PhantomConsumeItem>, IBufferMessage
	{
		// Token: 0x06011B87 RID: 72583 RVA: 0x0029807F File Offset: 0x0029627F
		[NullableContext(1)]
		public static PhantomConsumeItem Create()
		{
			return new PhantomConsumeItem();
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x06011B88 RID: 72584 RVA: 0x00298086 File Offset: 0x00296286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomConsumeItem> Parser
		{
			get
			{
				return PhantomConsumeItem._parser;
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x06011B89 RID: 72585 RVA: 0x0029808D File Offset: 0x0029628D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x06011B8A RID: 72586 RVA: 0x00298090 File Offset: 0x00296290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomConsumeItem.Descriptor;
			}
		}

		// Token: 0x06011B8B RID: 72587 RVA: 0x00298097 File Offset: 0x00296297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem()
		{
		}

		// Token: 0x06011B8C RID: 72588 RVA: 0x0029809F File Offset: 0x0029629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem(PhantomConsumeItem other) : this()
		{
			this.incId_ = other.incId_;
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B8D RID: 72589 RVA: 0x002980DC File Offset: 0x002962DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomConsumeItem Clone()
		{
			return new PhantomConsumeItem(this);
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x06011B8E RID: 72590 RVA: 0x002980E4 File Offset: 0x002962E4
		// (set) Token: 0x06011B8F RID: 72591 RVA: 0x002980EC File Offset: 0x002962EC
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

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x06011B90 RID: 72592 RVA: 0x002980F5 File Offset: 0x002962F5
		// (set) Token: 0x06011B91 RID: 72593 RVA: 0x002980FD File Offset: 0x002962FD
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

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x06011B92 RID: 72594 RVA: 0x00298106 File Offset: 0x00296306
		// (set) Token: 0x06011B93 RID: 72595 RVA: 0x0029810E File Offset: 0x0029630E
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

		// Token: 0x06011B94 RID: 72596 RVA: 0x00298117 File Offset: 0x00296317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomConsumeItem);
		}

		// Token: 0x06011B95 RID: 72597 RVA: 0x00298128 File Offset: 0x00296328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomConsumeItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B96 RID: 72598 RVA: 0x00298184 File Offset: 0x00296384
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

		// Token: 0x06011B97 RID: 72599 RVA: 0x002981F5 File Offset: 0x002963F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B98 RID: 72600 RVA: 0x00298202 File Offset: 0x00296402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B99 RID: 72601 RVA: 0x0029820C File Offset: 0x0029640C
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

		// Token: 0x06011B9A RID: 72602 RVA: 0x00298280 File Offset: 0x00296480
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

		// Token: 0x06011B9B RID: 72603 RVA: 0x002982F0 File Offset: 0x002964F0
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

		// Token: 0x06011B9C RID: 72604 RVA: 0x00298354 File Offset: 0x00296554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B9D RID: 72605 RVA: 0x00298360 File Offset: 0x00296560
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

		// Token: 0x04006F6B RID: 28523
		private static readonly MessageParser<PhantomConsumeItem> _parser = new MessageParser<PhantomConsumeItem>(() => new PhantomConsumeItem());

		// Token: 0x04006F6C RID: 28524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F6D RID: 28525
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006F6E RID: 28526
		private int incId_;

		// Token: 0x04006F6F RID: 28527
		public const int CountFieldNumber = 2;

		// Token: 0x04006F70 RID: 28528
		private int count_;

		// Token: 0x04006F71 RID: 28529
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006F72 RID: 28530
		private int itemId_;
	}
}
