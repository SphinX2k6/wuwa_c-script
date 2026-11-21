using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000206 RID: 518
	public sealed class BuffItem : IMessage<BuffItem>, IMessage, IEquatable<BuffItem>, IDeepCloneable<BuffItem>, IBufferMessage
	{
		// Token: 0x0600396D RID: 14701 RVA: 0x0008F78D File Offset: 0x0008D98D
		[NullableContext(1)]
		public static BuffItem Create()
		{
			return new BuffItem();
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x0008F794 File Offset: 0x0008D994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffItem> Parser
		{
			get
			{
				return BuffItem._parser;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x0008F79B File Offset: 0x0008D99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x0008F79E File Offset: 0x0008D99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItem.Descriptor;
			}
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0008F7A5 File Offset: 0x0008D9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem()
		{
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0008F7AD File Offset: 0x0008D9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem(BuffItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.cdTime_ = other.cdTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0008F7DE File Offset: 0x0008D9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItem Clone()
		{
			return new BuffItem(this);
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x0008F7E6 File Offset: 0x0008D9E6
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x0008F7EE File Offset: 0x0008D9EE
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

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x0008F7F7 File Offset: 0x0008D9F7
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x0008F7FF File Offset: 0x0008D9FF
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

		// Token: 0x06003978 RID: 14712 RVA: 0x0008F808 File Offset: 0x0008DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItem);
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0008F816 File Offset: 0x0008DA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.CdTime == other.CdTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0008F854 File Offset: 0x0008DA54
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

		// Token: 0x0600397B RID: 14715 RVA: 0x0008F8AC File Offset: 0x0008DAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0008F8B9 File Offset: 0x0008DAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0008F8C4 File Offset: 0x0008DAC4
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

		// Token: 0x0600397E RID: 14718 RVA: 0x0008F91C File Offset: 0x0008DB1C
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

		// Token: 0x0600397F RID: 14719 RVA: 0x0008F974 File Offset: 0x0008DB74
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

		// Token: 0x06003980 RID: 14720 RVA: 0x0008F9C4 File Offset: 0x0008DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
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

		// Token: 0x04002BCC RID: 11212
		private static readonly MessageParser<BuffItem> _parser = new MessageParser<BuffItem>(() => new BuffItem());

		// Token: 0x04002BCD RID: 11213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BCE RID: 11214
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04002BCF RID: 11215
		private int itemId_;

		// Token: 0x04002BD0 RID: 11216
		public const int CdTimeFieldNumber = 3;

		// Token: 0x04002BD1 RID: 11217
		private long cdTime_;
	}
}
