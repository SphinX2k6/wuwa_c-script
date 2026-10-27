using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000201 RID: 513
	public sealed class BuffItem : IMessage<BuffItem>, IMessage, IEquatable<BuffItem>, IDeepCloneable<BuffItem>, IBufferMessage
	{
		// Token: 0x060038C8 RID: 14536 RVA: 0x0008DB7D File Offset: 0x0008BD7D
		[NullableContext(1)]
		public static BuffItem Create()
		{
			return new BuffItem();
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0008DB84 File Offset: 0x0008BD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffItem> Parser
		{
			get
			{
				return BuffItem._parser;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0008DB8B File Offset: 0x0008BD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0008DB8E File Offset: 0x0008BD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItem.Descriptor;
			}
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x0008DB95 File Offset: 0x0008BD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem()
		{
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0008DB9D File Offset: 0x0008BD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem(BuffItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.cdTime_ = other.cdTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0008DBCE File Offset: 0x0008BDCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem Clone()
		{
			return new BuffItem(this);
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x0008DBD6 File Offset: 0x0008BDD6
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x0008DBDE File Offset: 0x0008BDDE
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x0008DBE7 File Offset: 0x0008BDE7
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x0008DBEF File Offset: 0x0008BDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CdTime
		{
			get
			{
				return this.cdTime_;
			}
			set
			{
				this.cdTime_ = value;
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0008DBF8 File Offset: 0x0008BDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItem);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0008DC06 File Offset: 0x0008BE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.CdTime == other.CdTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0008DC44 File Offset: 0x0008BE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.CdTime != 0L)
			{
				num ^= this.CdTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0008DC9C File Offset: 0x0008BE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0008DCA9 File Offset: 0x0008BEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0008DCB4 File Offset: 0x0008BEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.CdTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CdTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0008DD0C File Offset: 0x0008BF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.CdTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CdTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0008DD64 File Offset: 0x0008BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.CdTime != 0L)
			{
				this.CdTime = other.CdTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0008DDB4 File Offset: 0x0008BFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0008DDC0 File Offset: 0x0008BFC0
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CdTime = input.ReadInt64();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002B4A RID: 11082
		private static readonly MessageParser<BuffItem> _parser = new MessageParser<BuffItem>(() => new BuffItem());

		// Token: 0x04002B4B RID: 11083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B4C RID: 11084
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04002B4D RID: 11085
		private int itemId_;

		// Token: 0x04002B4E RID: 11086
		public const int CdTimeFieldNumber = 3;

		// Token: 0x04002B4F RID: 11087
		private long cdTime_;
	}
}
