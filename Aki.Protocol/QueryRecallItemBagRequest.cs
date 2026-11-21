using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF0 RID: 3568
	[NetMessage(EMessageId.QueryRecallItemBagRequest)]
	public sealed class QueryRecallItemBagRequest : IMessage<QueryRecallItemBagRequest>, IMessage, IEquatable<QueryRecallItemBagRequest>, IDeepCloneable<QueryRecallItemBagRequest>, IBufferMessage
	{
		// Token: 0x06013370 RID: 78704 RVA: 0x002CCCBA File Offset: 0x002CAEBA
		[NullableContext(1)]
		public static QueryRecallItemBagRequest Create()
		{
			return new QueryRecallItemBagRequest();
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x06013371 RID: 78705 RVA: 0x002CCCC1 File Offset: 0x002CAEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x06013372 RID: 78706 RVA: 0x002CCCC4 File Offset: 0x002CAEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRecallItemBagRequest.Descriptor;
			}
		}

		// Token: 0x06013373 RID: 78707 RVA: 0x002CCCCB File Offset: 0x002CAECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest()
		{
		}

		// Token: 0x06013374 RID: 78708 RVA: 0x002CCCD3 File Offset: 0x002CAED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest(QueryRecallItemBagRequest other) : this()
		{
			this.recallId_ = other.recallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013375 RID: 78709 RVA: 0x002CCCF8 File Offset: 0x002CAEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest Clone()
		{
			return new QueryRecallItemBagRequest(this);
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x06013376 RID: 78710 RVA: 0x002CCD00 File Offset: 0x002CAF00
		// (set) Token: 0x06013377 RID: 78711 RVA: 0x002CCD08 File Offset: 0x002CAF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x06013378 RID: 78712 RVA: 0x002CCD11 File Offset: 0x002CAF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRecallItemBagRequest);
		}

		// Token: 0x06013379 RID: 78713 RVA: 0x002CCD1F File Offset: 0x002CAF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryRecallItemBagRequest other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601337A RID: 78714 RVA: 0x002CCD50 File Offset: 0x002CAF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601337B RID: 78715 RVA: 0x002CCD8F File Offset: 0x002CAF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601337C RID: 78716 RVA: 0x002CCD9C File Offset: 0x002CAF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601337D RID: 78717 RVA: 0x002CCDA5 File Offset: 0x002CAFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601337E RID: 78718 RVA: 0x002CCDD8 File Offset: 0x002CAFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601337F RID: 78719 RVA: 0x002CCE16 File Offset: 0x002CB016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryRecallItemBagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013380 RID: 78720 RVA: 0x002CCE47 File Offset: 0x002CB047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013381 RID: 78721 RVA: 0x002CCE50 File Offset: 0x002CB050
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076AC RID: 30380
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076AD RID: 30381
		public const int RecallIdFieldNumber = 9;

		// Token: 0x040076AE RID: 30382
		private int recallId_;
	}
}
