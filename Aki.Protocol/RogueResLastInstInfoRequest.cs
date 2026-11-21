using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE2 RID: 4066
	[NetMessage(EMessageId.RogueResLastInstInfoRequest)]
	public sealed class RogueResLastInstInfoRequest : IMessage<RogueResLastInstInfoRequest>, IMessage, IEquatable<RogueResLastInstInfoRequest>, IDeepCloneable<RogueResLastInstInfoRequest>, IBufferMessage
	{
		// Token: 0x06015C3F RID: 89151 RVA: 0x0032A0BD File Offset: 0x003282BD
		[NullableContext(1)]
		public static RogueResLastInstInfoRequest Create()
		{
			return new RogueResLastInstInfoRequest();
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x06015C40 RID: 89152 RVA: 0x0032A0C4 File Offset: 0x003282C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x06015C41 RID: 89153 RVA: 0x0032A0C7 File Offset: 0x003282C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResLastInstInfoRequest.Descriptor;
			}
		}

		// Token: 0x06015C42 RID: 89154 RVA: 0x0032A0CE File Offset: 0x003282CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest()
		{
		}

		// Token: 0x06015C43 RID: 89155 RVA: 0x0032A0D6 File Offset: 0x003282D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest(RogueResLastInstInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C44 RID: 89156 RVA: 0x0032A0EF File Offset: 0x003282EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest Clone()
		{
			return new RogueResLastInstInfoRequest(this);
		}

		// Token: 0x06015C45 RID: 89157 RVA: 0x0032A0F7 File Offset: 0x003282F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResLastInstInfoRequest);
		}

		// Token: 0x06015C46 RID: 89158 RVA: 0x0032A105 File Offset: 0x00328305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResLastInstInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015C47 RID: 89159 RVA: 0x0032A124 File Offset: 0x00328324
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

		// Token: 0x06015C48 RID: 89160 RVA: 0x0032A14A File Offset: 0x0032834A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C49 RID: 89161 RVA: 0x0032A157 File Offset: 0x00328357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C4A RID: 89162 RVA: 0x0032A160 File Offset: 0x00328360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C4B RID: 89163 RVA: 0x0032A178 File Offset: 0x00328378
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

		// Token: 0x06015C4C RID: 89164 RVA: 0x0032A19E File Offset: 0x0032839E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResLastInstInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C4D RID: 89165 RVA: 0x0032A1BB File Offset: 0x003283BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C4E RID: 89166 RVA: 0x0032A1C4 File Offset: 0x003283C4
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

		// Token: 0x0400831F RID: 33567
		private UnknownFieldSet _unknownFields;
	}
}
