using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF0 RID: 4080
	[NetMessage(EMessageId.RogueResInstStartRequest)]
	public sealed class RogueResInstStartRequest : IMessage<RogueResInstStartRequest>, IMessage, IEquatable<RogueResInstStartRequest>, IDeepCloneable<RogueResInstStartRequest>, IBufferMessage
	{
		// Token: 0x06015D00 RID: 89344 RVA: 0x0032B3C7 File Offset: 0x003295C7
		[NullableContext(1)]
		public static RogueResInstStartRequest Create()
		{
			return new RogueResInstStartRequest();
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06015D01 RID: 89345 RVA: 0x0032B3CE File Offset: 0x003295CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x06015D02 RID: 89346 RVA: 0x0032B3D1 File Offset: 0x003295D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstStartRequest.Descriptor;
			}
		}

		// Token: 0x06015D03 RID: 89347 RVA: 0x0032B3D8 File Offset: 0x003295D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest()
		{
		}

		// Token: 0x06015D04 RID: 89348 RVA: 0x0032B3E0 File Offset: 0x003295E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest(RogueResInstStartRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D05 RID: 89349 RVA: 0x0032B405 File Offset: 0x00329605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest Clone()
		{
			return new RogueResInstStartRequest(this);
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x06015D06 RID: 89350 RVA: 0x0032B40D File Offset: 0x0032960D
		// (set) Token: 0x06015D07 RID: 89351 RVA: 0x0032B415 File Offset: 0x00329615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06015D08 RID: 89352 RVA: 0x0032B41E File Offset: 0x0032961E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstStartRequest);
		}

		// Token: 0x06015D09 RID: 89353 RVA: 0x0032B42C File Offset: 0x0032962C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstStartRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D0A RID: 89354 RVA: 0x0032B45C File Offset: 0x0032965C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D0B RID: 89355 RVA: 0x0032B49B File Offset: 0x0032969B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D0C RID: 89356 RVA: 0x0032B4A8 File Offset: 0x003296A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D0D RID: 89357 RVA: 0x0032B4B1 File Offset: 0x003296B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D0E RID: 89358 RVA: 0x0032B4E4 File Offset: 0x003296E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D0F RID: 89359 RVA: 0x0032B522 File Offset: 0x00329722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D10 RID: 89360 RVA: 0x0032B553 File Offset: 0x00329753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D11 RID: 89361 RVA: 0x0032B55C File Offset: 0x0032975C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040082EF RID: 33519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082F0 RID: 33520
		public const int InstIdFieldNumber = 6;

		// Token: 0x040082F1 RID: 33521
		private int instId_;
	}
}
