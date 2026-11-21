using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F93 RID: 3987
	[NetMessage(EMessageId.RoguelikeLastInfoRequest)]
	public sealed class RoguelikeLastInfoRequest : IMessage<RoguelikeLastInfoRequest>, IMessage, IEquatable<RoguelikeLastInfoRequest>, IDeepCloneable<RoguelikeLastInfoRequest>, IBufferMessage
	{
		// Token: 0x060155A2 RID: 87458 RVA: 0x0031A1C9 File Offset: 0x003183C9
		[NullableContext(1)]
		public static RoguelikeLastInfoRequest Create()
		{
			return new RoguelikeLastInfoRequest();
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x060155A3 RID: 87459 RVA: 0x0031A1D0 File Offset: 0x003183D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x060155A4 RID: 87460 RVA: 0x0031A1D3 File Offset: 0x003183D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x0031A1DA File Offset: 0x003183DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest()
		{
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x0031A1E2 File Offset: 0x003183E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest(RoguelikeLastInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155A7 RID: 87463 RVA: 0x0031A1FB File Offset: 0x003183FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfoRequest Clone()
		{
			return new RoguelikeLastInfoRequest(this);
		}

		// Token: 0x060155A8 RID: 87464 RVA: 0x0031A203 File Offset: 0x00318403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfoRequest);
		}

		// Token: 0x060155A9 RID: 87465 RVA: 0x0031A211 File Offset: 0x00318411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060155AA RID: 87466 RVA: 0x0031A230 File Offset: 0x00318430
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

		// Token: 0x060155AB RID: 87467 RVA: 0x0031A256 File Offset: 0x00318456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155AC RID: 87468 RVA: 0x0031A263 File Offset: 0x00318463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x0031A26C File Offset: 0x0031846C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155AE RID: 87470 RVA: 0x0031A284 File Offset: 0x00318484
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

		// Token: 0x060155AF RID: 87471 RVA: 0x0031A2AA File Offset: 0x003184AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeLastInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060155B0 RID: 87472 RVA: 0x0031A2C7 File Offset: 0x003184C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155B1 RID: 87473 RVA: 0x0031A2D0 File Offset: 0x003184D0
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

		// Token: 0x040080F8 RID: 33016
		private UnknownFieldSet _unknownFields;
	}
}
