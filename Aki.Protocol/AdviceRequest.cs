using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CD RID: 205
	[NetMessage(EMessageId.AdviceRequest)]
	public sealed class AdviceRequest : IMessage<AdviceRequest>, IMessage, IEquatable<AdviceRequest>, IDeepCloneable<AdviceRequest>, IBufferMessage
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x00056331 File Offset: 0x00054531
		[NullableContext(1)]
		public static AdviceRequest Create()
		{
			return new AdviceRequest();
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00056338 File Offset: 0x00054538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0005633B File Offset: 0x0005453B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceRequest.Descriptor;
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00056342 File Offset: 0x00054542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest()
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0005634A File Offset: 0x0005454A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest(AdviceRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00056363 File Offset: 0x00054563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceRequest Clone()
		{
			return new AdviceRequest(this);
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0005636B File Offset: 0x0005456B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceRequest);
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00056379 File Offset: 0x00054579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00056398 File Offset: 0x00054598
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

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000563BE File Offset: 0x000545BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000563CB File Offset: 0x000545CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000563D4 File Offset: 0x000545D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000563EC File Offset: 0x000545EC
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

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00056412 File Offset: 0x00054612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0005642F File Offset: 0x0005462F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00056438 File Offset: 0x00054638
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

		// Token: 0x040023CF RID: 9167
		private UnknownFieldSet _unknownFields;
	}
}
