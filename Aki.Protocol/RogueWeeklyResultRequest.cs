using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001044 RID: 4164
	[NetMessage(EMessageId.RogueWeeklyResultRequest)]
	public sealed class RogueWeeklyResultRequest : IMessage<RogueWeeklyResultRequest>, IMessage, IEquatable<RogueWeeklyResultRequest>, IDeepCloneable<RogueWeeklyResultRequest>, IBufferMessage
	{
		// Token: 0x06016403 RID: 91139 RVA: 0x0033B7E3 File Offset: 0x003399E3
		[NullableContext(1)]
		public static RogueWeeklyResultRequest Create()
		{
			return new RogueWeeklyResultRequest();
		}

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x06016404 RID: 91140 RVA: 0x0033B7EA File Offset: 0x003399EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x06016405 RID: 91141 RVA: 0x0033B7ED File Offset: 0x003399ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultRequest.Descriptor;
			}
		}

		// Token: 0x06016406 RID: 91142 RVA: 0x0033B7F4 File Offset: 0x003399F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest()
		{
		}

		// Token: 0x06016407 RID: 91143 RVA: 0x0033B7FC File Offset: 0x003399FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest(RogueWeeklyResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016408 RID: 91144 RVA: 0x0033B815 File Offset: 0x00339A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest Clone()
		{
			return new RogueWeeklyResultRequest(this);
		}

		// Token: 0x06016409 RID: 91145 RVA: 0x0033B81D File Offset: 0x00339A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultRequest);
		}

		// Token: 0x0601640A RID: 91146 RVA: 0x0033B82B File Offset: 0x00339A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601640B RID: 91147 RVA: 0x0033B84C File Offset: 0x00339A4C
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

		// Token: 0x0601640C RID: 91148 RVA: 0x0033B872 File Offset: 0x00339A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601640D RID: 91149 RVA: 0x0033B87F File Offset: 0x00339A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601640E RID: 91150 RVA: 0x0033B888 File Offset: 0x00339A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601640F RID: 91151 RVA: 0x0033B8A0 File Offset: 0x00339AA0
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

		// Token: 0x06016410 RID: 91152 RVA: 0x0033B8C6 File Offset: 0x00339AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016411 RID: 91153 RVA: 0x0033B8E3 File Offset: 0x00339AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016412 RID: 91154 RVA: 0x0033B8EC File Offset: 0x00339AEC
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

		// Token: 0x0400851B RID: 34075
		private UnknownFieldSet _unknownFields;
	}
}
