using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001379 RID: 4985
	[NetMessage(EMessageId.SynthesisInfoRequest)]
	public sealed class SynthesisInfoRequest : IMessage<SynthesisInfoRequest>, IMessage, IEquatable<SynthesisInfoRequest>, IDeepCloneable<SynthesisInfoRequest>, IBufferMessage
	{
		// Token: 0x0601A8B2 RID: 108722 RVA: 0x003DDFBC File Offset: 0x003DC1BC
		[NullableContext(1)]
		public static SynthesisInfoRequest Create()
		{
			return new SynthesisInfoRequest();
		}

		// Token: 0x170059DB RID: 23003
		// (get) Token: 0x0601A8B3 RID: 108723 RVA: 0x003DDFC3 File Offset: 0x003DC1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x0601A8B4 RID: 108724 RVA: 0x003DDFC6 File Offset: 0x003DC1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601A8B5 RID: 108725 RVA: 0x003DDFCD File Offset: 0x003DC1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest()
		{
		}

		// Token: 0x0601A8B6 RID: 108726 RVA: 0x003DDFD5 File Offset: 0x003DC1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest(SynthesisInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8B7 RID: 108727 RVA: 0x003DDFEE File Offset: 0x003DC1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoRequest Clone()
		{
			return new SynthesisInfoRequest(this);
		}

		// Token: 0x0601A8B8 RID: 108728 RVA: 0x003DDFF6 File Offset: 0x003DC1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoRequest);
		}

		// Token: 0x0601A8B9 RID: 108729 RVA: 0x003DE004 File Offset: 0x003DC204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A8BA RID: 108730 RVA: 0x003DE024 File Offset: 0x003DC224
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

		// Token: 0x0601A8BB RID: 108731 RVA: 0x003DE04A File Offset: 0x003DC24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x003DE057 File Offset: 0x003DC257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8BD RID: 108733 RVA: 0x003DE060 File Offset: 0x003DC260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8BE RID: 108734 RVA: 0x003DE078 File Offset: 0x003DC278
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

		// Token: 0x0601A8BF RID: 108735 RVA: 0x003DE09E File Offset: 0x003DC29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8C0 RID: 108736 RVA: 0x003DE0BB File Offset: 0x003DC2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8C1 RID: 108737 RVA: 0x003DE0C4 File Offset: 0x003DC2C4
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

		// Token: 0x04009B94 RID: 39828
		private UnknownFieldSet _unknownFields;
	}
}
