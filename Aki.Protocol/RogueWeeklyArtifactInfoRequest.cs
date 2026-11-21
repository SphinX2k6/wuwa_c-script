using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101A RID: 4122
	[NetMessage(EMessageId.RogueWeeklyArtifactInfoRequest)]
	public sealed class RogueWeeklyArtifactInfoRequest : IMessage<RogueWeeklyArtifactInfoRequest>, IMessage, IEquatable<RogueWeeklyArtifactInfoRequest>, IDeepCloneable<RogueWeeklyArtifactInfoRequest>, IBufferMessage
	{
		// Token: 0x060160F6 RID: 90358 RVA: 0x003352F9 File Offset: 0x003334F9
		[NullableContext(1)]
		public static RogueWeeklyArtifactInfoRequest Create()
		{
			return new RogueWeeklyArtifactInfoRequest();
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x060160F7 RID: 90359 RVA: 0x00335300 File Offset: 0x00333500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x060160F8 RID: 90360 RVA: 0x00335303 File Offset: 0x00333503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactInfoRequest.Descriptor;
			}
		}

		// Token: 0x060160F9 RID: 90361 RVA: 0x0033530A File Offset: 0x0033350A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest()
		{
		}

		// Token: 0x060160FA RID: 90362 RVA: 0x00335312 File Offset: 0x00333512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest(RogueWeeklyArtifactInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160FB RID: 90363 RVA: 0x0033532B File Offset: 0x0033352B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest Clone()
		{
			return new RogueWeeklyArtifactInfoRequest(this);
		}

		// Token: 0x060160FC RID: 90364 RVA: 0x00335333 File Offset: 0x00333533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactInfoRequest);
		}

		// Token: 0x060160FD RID: 90365 RVA: 0x00335341 File Offset: 0x00333541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060160FE RID: 90366 RVA: 0x00335360 File Offset: 0x00333560
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

		// Token: 0x060160FF RID: 90367 RVA: 0x00335386 File Offset: 0x00333586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016100 RID: 90368 RVA: 0x00335393 File Offset: 0x00333593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016101 RID: 90369 RVA: 0x0033539C File Offset: 0x0033359C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016102 RID: 90370 RVA: 0x003353B4 File Offset: 0x003335B4
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

		// Token: 0x06016103 RID: 90371 RVA: 0x003353DA File Offset: 0x003335DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyArtifactInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016104 RID: 90372 RVA: 0x003353F7 File Offset: 0x003335F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016105 RID: 90373 RVA: 0x00335400 File Offset: 0x00333600
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

		// Token: 0x0400849D RID: 33949
		private UnknownFieldSet _unknownFields;
	}
}
