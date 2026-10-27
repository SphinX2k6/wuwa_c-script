using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E00 RID: 3584
	[NetMessage(EMessageId.QueryRecallItemBagRequest)]
	public sealed class QueryRecallItemBagRequest : IMessage<QueryRecallItemBagRequest>, IMessage, IEquatable<QueryRecallItemBagRequest>, IDeepCloneable<QueryRecallItemBagRequest>, IBufferMessage
	{
		// Token: 0x06013455 RID: 78933 RVA: 0x002CE376 File Offset: 0x002CC576
		[NullableContext(1)]
		public static QueryRecallItemBagRequest Create()
		{
			return new QueryRecallItemBagRequest();
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x06013456 RID: 78934 RVA: 0x002CE37D File Offset: 0x002CC57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x06013457 RID: 78935 RVA: 0x002CE380 File Offset: 0x002CC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRecallItemBagRequest.Descriptor;
			}
		}

		// Token: 0x06013458 RID: 78936 RVA: 0x002CE387 File Offset: 0x002CC587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest()
		{
		}

		// Token: 0x06013459 RID: 78937 RVA: 0x002CE38F File Offset: 0x002CC58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest(QueryRecallItemBagRequest other) : this()
		{
			this.recallId_ = other.recallId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601345A RID: 78938 RVA: 0x002CE3B4 File Offset: 0x002CC5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryRecallItemBagRequest Clone()
		{
			return new QueryRecallItemBagRequest(this);
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0601345B RID: 78939 RVA: 0x002CE3BC File Offset: 0x002CC5BC
		// (set) Token: 0x0601345C RID: 78940 RVA: 0x002CE3C4 File Offset: 0x002CC5C4
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

		// Token: 0x0601345D RID: 78941 RVA: 0x002CE3CD File Offset: 0x002CC5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRecallItemBagRequest);
		}

		// Token: 0x0601345E RID: 78942 RVA: 0x002CE3DB File Offset: 0x002CC5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryRecallItemBagRequest other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601345F RID: 78943 RVA: 0x002CE40C File Offset: 0x002CC60C
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

		// Token: 0x06013460 RID: 78944 RVA: 0x002CE44B File Offset: 0x002CC64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013461 RID: 78945 RVA: 0x002CE458 File Offset: 0x002CC658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013462 RID: 78946 RVA: 0x002CE461 File Offset: 0x002CC661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013463 RID: 78947 RVA: 0x002CE494 File Offset: 0x002CC694
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

		// Token: 0x06013464 RID: 78948 RVA: 0x002CE4D2 File Offset: 0x002CC6D2
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

		// Token: 0x06013465 RID: 78949 RVA: 0x002CE503 File Offset: 0x002CC703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013466 RID: 78950 RVA: 0x002CE50C File Offset: 0x002CC70C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007682 RID: 30338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007683 RID: 30339
		public const int RecallIdFieldNumber = 10;

		// Token: 0x04007684 RID: 30340
		private int recallId_;
	}
}
