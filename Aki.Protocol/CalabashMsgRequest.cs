using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000223 RID: 547
	[NetMessage(EMessageId.CalabashMsgRequest)]
	public sealed class CalabashMsgRequest : IMessage<CalabashMsgRequest>, IMessage, IEquatable<CalabashMsgRequest>, IDeepCloneable<CalabashMsgRequest>, IBufferMessage
	{
		// Token: 0x06003BAF RID: 15279 RVA: 0x00094842 File Offset: 0x00092A42
		[NullableContext(1)]
		public static CalabashMsgRequest Create()
		{
			return new CalabashMsgRequest();
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00094849 File Offset: 0x00092A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x0009484C File Offset: 0x00092A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsgRequest.Descriptor;
			}
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00094853 File Offset: 0x00092A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest()
		{
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x0009485B File Offset: 0x00092A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest(CalabashMsgRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x00094874 File Offset: 0x00092A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsgRequest Clone()
		{
			return new CalabashMsgRequest(this);
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0009487C File Offset: 0x00092A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsgRequest);
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x0009488A File Offset: 0x00092A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsgRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000948A8 File Offset: 0x00092AA8
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

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000948CE File Offset: 0x00092ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000948DB File Offset: 0x00092ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000948E4 File Offset: 0x00092AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000948FC File Offset: 0x00092AFC
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

		// Token: 0x06003BBC RID: 15292 RVA: 0x00094922 File Offset: 0x00092B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashMsgRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x0009493F File Offset: 0x00092B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00094948 File Offset: 0x00092B48
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

		// Token: 0x04002C3D RID: 11325
		private UnknownFieldSet _unknownFields;
	}
}
