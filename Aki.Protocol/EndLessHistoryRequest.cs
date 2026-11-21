using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000428 RID: 1064
	[NetMessage(EMessageId.EndLessHistoryRequest)]
	public sealed class EndLessHistoryRequest : IMessage<EndLessHistoryRequest>, IMessage, IEquatable<EndLessHistoryRequest>, IDeepCloneable<EndLessHistoryRequest>, IBufferMessage
	{
		// Token: 0x0600667F RID: 26239 RVA: 0x000F6B18 File Offset: 0x000F4D18
		[NullableContext(1)]
		public static EndLessHistoryRequest Create()
		{
			return new EndLessHistoryRequest();
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x000F6B1F File Offset: 0x000F4D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x000F6B22 File Offset: 0x000F4D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndLessHistoryRequest.Descriptor;
			}
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x000F6B29 File Offset: 0x000F4D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest()
		{
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x000F6B31 File Offset: 0x000F4D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest(EndLessHistoryRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x000F6B4A File Offset: 0x000F4D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryRequest Clone()
		{
			return new EndLessHistoryRequest(this);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x000F6B52 File Offset: 0x000F4D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndLessHistoryRequest);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x000F6B60 File Offset: 0x000F4D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndLessHistoryRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x000F6B80 File Offset: 0x000F4D80
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

		// Token: 0x06006688 RID: 26248 RVA: 0x000F6BA6 File Offset: 0x000F4DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x000F6BB3 File Offset: 0x000F4DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x000F6BBC File Offset: 0x000F4DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x000F6BD4 File Offset: 0x000F4DD4
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

		// Token: 0x0600668C RID: 26252 RVA: 0x000F6BFA File Offset: 0x000F4DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndLessHistoryRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x000F6C17 File Offset: 0x000F4E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x000F6C20 File Offset: 0x000F4E20
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

		// Token: 0x04003981 RID: 14721
		private UnknownFieldSet _unknownFields;
	}
}
