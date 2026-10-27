using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFE RID: 3582
	[NetMessage(EMessageId.QueryOnlinePlayersAreaRequest)]
	public sealed class QueryOnlinePlayersAreaRequest : IMessage<QueryOnlinePlayersAreaRequest>, IMessage, IEquatable<QueryOnlinePlayersAreaRequest>, IDeepCloneable<QueryOnlinePlayersAreaRequest>, IBufferMessage
	{
		// Token: 0x06013431 RID: 78897 RVA: 0x002CDF80 File Offset: 0x002CC180
		[NullableContext(1)]
		public static QueryOnlinePlayersAreaRequest Create()
		{
			return new QueryOnlinePlayersAreaRequest();
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x06013432 RID: 78898 RVA: 0x002CDF87 File Offset: 0x002CC187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x06013433 RID: 78899 RVA: 0x002CDF8A File Offset: 0x002CC18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryOnlinePlayersAreaRequest.Descriptor;
			}
		}

		// Token: 0x06013434 RID: 78900 RVA: 0x002CDF91 File Offset: 0x002CC191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest()
		{
		}

		// Token: 0x06013435 RID: 78901 RVA: 0x002CDF99 File Offset: 0x002CC199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest(QueryOnlinePlayersAreaRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013436 RID: 78902 RVA: 0x002CDFB2 File Offset: 0x002CC1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest Clone()
		{
			return new QueryOnlinePlayersAreaRequest(this);
		}

		// Token: 0x06013437 RID: 78903 RVA: 0x002CDFBA File Offset: 0x002CC1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryOnlinePlayersAreaRequest);
		}

		// Token: 0x06013438 RID: 78904 RVA: 0x002CDFC8 File Offset: 0x002CC1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryOnlinePlayersAreaRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013439 RID: 78905 RVA: 0x002CDFE8 File Offset: 0x002CC1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601343A RID: 78906 RVA: 0x002CE00E File Offset: 0x002CC20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601343B RID: 78907 RVA: 0x002CE01B File Offset: 0x002CC21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601343C RID: 78908 RVA: 0x002CE024 File Offset: 0x002CC224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601343D RID: 78909 RVA: 0x002CE03C File Offset: 0x002CC23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601343E RID: 78910 RVA: 0x002CE062 File Offset: 0x002CC262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryOnlinePlayersAreaRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601343F RID: 78911 RVA: 0x002CE07F File Offset: 0x002CC27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013440 RID: 78912 RVA: 0x002CE088 File Offset: 0x002CC288
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400767B RID: 30331
		private UnknownFieldSet _unknownFields;
	}
}
