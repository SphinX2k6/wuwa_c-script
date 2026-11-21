using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDE RID: 4062
	[NetMessage(EMessageId.RogueResInstResultRequest)]
	public sealed class RogueResInstResultRequest : IMessage<RogueResInstResultRequest>, IMessage, IEquatable<RogueResInstResultRequest>, IDeepCloneable<RogueResInstResultRequest>, IBufferMessage
	{
		// Token: 0x06015BF7 RID: 89079 RVA: 0x003298D3 File Offset: 0x00327AD3
		[NullableContext(1)]
		public static RogueResInstResultRequest Create()
		{
			return new RogueResInstResultRequest();
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06015BF8 RID: 89080 RVA: 0x003298DA File Offset: 0x00327ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06015BF9 RID: 89081 RVA: 0x003298DD File Offset: 0x00327ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstResultRequest.Descriptor;
			}
		}

		// Token: 0x06015BFA RID: 89082 RVA: 0x003298E4 File Offset: 0x00327AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest()
		{
		}

		// Token: 0x06015BFB RID: 89083 RVA: 0x003298EC File Offset: 0x00327AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest(RogueResInstResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BFC RID: 89084 RVA: 0x00329905 File Offset: 0x00327B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest Clone()
		{
			return new RogueResInstResultRequest(this);
		}

		// Token: 0x06015BFD RID: 89085 RVA: 0x0032990D File Offset: 0x00327B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstResultRequest);
		}

		// Token: 0x06015BFE RID: 89086 RVA: 0x0032991B File Offset: 0x00327B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015BFF RID: 89087 RVA: 0x0032993C File Offset: 0x00327B3C
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

		// Token: 0x06015C00 RID: 89088 RVA: 0x00329962 File Offset: 0x00327B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C01 RID: 89089 RVA: 0x0032996F File Offset: 0x00327B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C02 RID: 89090 RVA: 0x00329978 File Offset: 0x00327B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C03 RID: 89091 RVA: 0x00329990 File Offset: 0x00327B90
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

		// Token: 0x06015C04 RID: 89092 RVA: 0x003299B6 File Offset: 0x00327BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C05 RID: 89093 RVA: 0x003299D3 File Offset: 0x00327BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C06 RID: 89094 RVA: 0x003299DC File Offset: 0x00327BDC
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

		// Token: 0x04008313 RID: 33555
		private UnknownFieldSet _unknownFields;
	}
}
