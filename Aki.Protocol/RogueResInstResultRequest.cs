using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEE RID: 4078
	[NetMessage(EMessageId.RogueResInstResultRequest)]
	public sealed class RogueResInstResultRequest : IMessage<RogueResInstResultRequest>, IMessage, IEquatable<RogueResInstResultRequest>, IDeepCloneable<RogueResInstResultRequest>, IBufferMessage
	{
		// Token: 0x06015CDC RID: 89308 RVA: 0x0032AF97 File Offset: 0x00329197
		[NullableContext(1)]
		public static RogueResInstResultRequest Create()
		{
			return new RogueResInstResultRequest();
		}

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06015CDD RID: 89309 RVA: 0x0032AF9E File Offset: 0x0032919E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06015CDE RID: 89310 RVA: 0x0032AFA1 File Offset: 0x003291A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstResultRequest.Descriptor;
			}
		}

		// Token: 0x06015CDF RID: 89311 RVA: 0x0032AFA8 File Offset: 0x003291A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest()
		{
		}

		// Token: 0x06015CE0 RID: 89312 RVA: 0x0032AFB0 File Offset: 0x003291B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest(RogueResInstResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CE1 RID: 89313 RVA: 0x0032AFC9 File Offset: 0x003291C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultRequest Clone()
		{
			return new RogueResInstResultRequest(this);
		}

		// Token: 0x06015CE2 RID: 89314 RVA: 0x0032AFD1 File Offset: 0x003291D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstResultRequest);
		}

		// Token: 0x06015CE3 RID: 89315 RVA: 0x0032AFDF File Offset: 0x003291DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015CE4 RID: 89316 RVA: 0x0032B000 File Offset: 0x00329200
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

		// Token: 0x06015CE5 RID: 89317 RVA: 0x0032B026 File Offset: 0x00329226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CE6 RID: 89318 RVA: 0x0032B033 File Offset: 0x00329233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CE7 RID: 89319 RVA: 0x0032B03C File Offset: 0x0032923C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CE8 RID: 89320 RVA: 0x0032B054 File Offset: 0x00329254
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

		// Token: 0x06015CE9 RID: 89321 RVA: 0x0032B07A File Offset: 0x0032927A
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

		// Token: 0x06015CEA RID: 89322 RVA: 0x0032B097 File Offset: 0x00329297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CEB RID: 89323 RVA: 0x0032B0A0 File Offset: 0x003292A0
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

		// Token: 0x040082E9 RID: 33513
		private UnknownFieldSet _unknownFields;
	}
}
