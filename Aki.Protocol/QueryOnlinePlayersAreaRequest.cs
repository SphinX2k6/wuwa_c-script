using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEE RID: 3566
	[NetMessage(EMessageId.QueryOnlinePlayersAreaRequest)]
	public sealed class QueryOnlinePlayersAreaRequest : IMessage<QueryOnlinePlayersAreaRequest>, IMessage, IEquatable<QueryOnlinePlayersAreaRequest>, IDeepCloneable<QueryOnlinePlayersAreaRequest>, IBufferMessage
	{
		// Token: 0x0601334C RID: 78668 RVA: 0x002CC8C4 File Offset: 0x002CAAC4
		[NullableContext(1)]
		public static QueryOnlinePlayersAreaRequest Create()
		{
			return new QueryOnlinePlayersAreaRequest();
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0601334D RID: 78669 RVA: 0x002CC8CB File Offset: 0x002CAACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0601334E RID: 78670 RVA: 0x002CC8CE File Offset: 0x002CAACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryOnlinePlayersAreaRequest.Descriptor;
			}
		}

		// Token: 0x0601334F RID: 78671 RVA: 0x002CC8D5 File Offset: 0x002CAAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest()
		{
		}

		// Token: 0x06013350 RID: 78672 RVA: 0x002CC8DD File Offset: 0x002CAADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest(QueryOnlinePlayersAreaRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013351 RID: 78673 RVA: 0x002CC8F6 File Offset: 0x002CAAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryOnlinePlayersAreaRequest Clone()
		{
			return new QueryOnlinePlayersAreaRequest(this);
		}

		// Token: 0x06013352 RID: 78674 RVA: 0x002CC8FE File Offset: 0x002CAAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryOnlinePlayersAreaRequest);
		}

		// Token: 0x06013353 RID: 78675 RVA: 0x002CC90C File Offset: 0x002CAB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryOnlinePlayersAreaRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013354 RID: 78676 RVA: 0x002CC92C File Offset: 0x002CAB2C
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

		// Token: 0x06013355 RID: 78677 RVA: 0x002CC952 File Offset: 0x002CAB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013356 RID: 78678 RVA: 0x002CC95F File Offset: 0x002CAB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013357 RID: 78679 RVA: 0x002CC968 File Offset: 0x002CAB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013358 RID: 78680 RVA: 0x002CC980 File Offset: 0x002CAB80
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

		// Token: 0x06013359 RID: 78681 RVA: 0x002CC9A6 File Offset: 0x002CABA6
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

		// Token: 0x0601335A RID: 78682 RVA: 0x002CC9C3 File Offset: 0x002CABC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601335B RID: 78683 RVA: 0x002CC9CC File Offset: 0x002CABCC
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

		// Token: 0x040076A5 RID: 30373
		private UnknownFieldSet _unknownFields;
	}
}
