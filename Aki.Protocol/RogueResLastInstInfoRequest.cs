using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF2 RID: 4082
	[NetMessage(EMessageId.RogueResLastInstInfoRequest)]
	public sealed class RogueResLastInstInfoRequest : IMessage<RogueResLastInstInfoRequest>, IMessage, IEquatable<RogueResLastInstInfoRequest>, IDeepCloneable<RogueResLastInstInfoRequest>, IBufferMessage
	{
		// Token: 0x06015D24 RID: 89380 RVA: 0x0032B781 File Offset: 0x00329981
		[NullableContext(1)]
		public static RogueResLastInstInfoRequest Create()
		{
			return new RogueResLastInstInfoRequest();
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06015D25 RID: 89381 RVA: 0x0032B788 File Offset: 0x00329988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06015D26 RID: 89382 RVA: 0x0032B78B File Offset: 0x0032998B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResLastInstInfoRequest.Descriptor;
			}
		}

		// Token: 0x06015D27 RID: 89383 RVA: 0x0032B792 File Offset: 0x00329992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest()
		{
		}

		// Token: 0x06015D28 RID: 89384 RVA: 0x0032B79A File Offset: 0x0032999A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest(RogueResLastInstInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D29 RID: 89385 RVA: 0x0032B7B3 File Offset: 0x003299B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoRequest Clone()
		{
			return new RogueResLastInstInfoRequest(this);
		}

		// Token: 0x06015D2A RID: 89386 RVA: 0x0032B7BB File Offset: 0x003299BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResLastInstInfoRequest);
		}

		// Token: 0x06015D2B RID: 89387 RVA: 0x0032B7C9 File Offset: 0x003299C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResLastInstInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015D2C RID: 89388 RVA: 0x0032B7E8 File Offset: 0x003299E8
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

		// Token: 0x06015D2D RID: 89389 RVA: 0x0032B80E File Offset: 0x00329A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D2E RID: 89390 RVA: 0x0032B81B File Offset: 0x00329A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D2F RID: 89391 RVA: 0x0032B824 File Offset: 0x00329A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D30 RID: 89392 RVA: 0x0032B83C File Offset: 0x00329A3C
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

		// Token: 0x06015D31 RID: 89393 RVA: 0x0032B862 File Offset: 0x00329A62
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

		// Token: 0x06015D32 RID: 89394 RVA: 0x0032B87F File Offset: 0x00329A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D33 RID: 89395 RVA: 0x0032B888 File Offset: 0x00329A88
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

		// Token: 0x040082F5 RID: 33525
		private UnknownFieldSet _unknownFields;
	}
}
