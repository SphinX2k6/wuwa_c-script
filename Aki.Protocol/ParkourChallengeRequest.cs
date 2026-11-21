using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAB RID: 2987
	[NetMessage(EMessageId.ParkourChallengeRequest)]
	public sealed class ParkourChallengeRequest : IMessage<ParkourChallengeRequest>, IMessage, IEquatable<ParkourChallengeRequest>, IDeepCloneable<ParkourChallengeRequest>, IBufferMessage
	{
		// Token: 0x0601036E RID: 66414 RVA: 0x0025E483 File Offset: 0x0025C683
		[NullableContext(1)]
		public static ParkourChallengeRequest Create()
		{
			return new ParkourChallengeRequest();
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0601036F RID: 66415 RVA: 0x0025E48A File Offset: 0x0025C68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x06010370 RID: 66416 RVA: 0x0025E48D File Offset: 0x0025C68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeRequest.Descriptor;
			}
		}

		// Token: 0x06010371 RID: 66417 RVA: 0x0025E494 File Offset: 0x0025C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest()
		{
		}

		// Token: 0x06010372 RID: 66418 RVA: 0x0025E49C File Offset: 0x0025C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest(ParkourChallengeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010373 RID: 66419 RVA: 0x0025E4B5 File Offset: 0x0025C6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest Clone()
		{
			return new ParkourChallengeRequest(this);
		}

		// Token: 0x06010374 RID: 66420 RVA: 0x0025E4BD File Offset: 0x0025C6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeRequest);
		}

		// Token: 0x06010375 RID: 66421 RVA: 0x0025E4CB File Offset: 0x0025C6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010376 RID: 66422 RVA: 0x0025E4EC File Offset: 0x0025C6EC
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

		// Token: 0x06010377 RID: 66423 RVA: 0x0025E512 File Offset: 0x0025C712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010378 RID: 66424 RVA: 0x0025E51F File Offset: 0x0025C71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010379 RID: 66425 RVA: 0x0025E528 File Offset: 0x0025C728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601037A RID: 66426 RVA: 0x0025E540 File Offset: 0x0025C740
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

		// Token: 0x0601037B RID: 66427 RVA: 0x0025E566 File Offset: 0x0025C766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601037C RID: 66428 RVA: 0x0025E583 File Offset: 0x0025C783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601037D RID: 66429 RVA: 0x0025E58C File Offset: 0x0025C78C
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

		// Token: 0x0400679D RID: 26525
		private UnknownFieldSet _unknownFields;
	}
}
