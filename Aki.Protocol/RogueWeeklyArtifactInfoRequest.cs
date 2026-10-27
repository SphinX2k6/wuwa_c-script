using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102A RID: 4138
	[NetMessage(EMessageId.RogueWeeklyArtifactInfoRequest)]
	public sealed class RogueWeeklyArtifactInfoRequest : IMessage<RogueWeeklyArtifactInfoRequest>, IMessage, IEquatable<RogueWeeklyArtifactInfoRequest>, IDeepCloneable<RogueWeeklyArtifactInfoRequest>, IBufferMessage
	{
		// Token: 0x060161DB RID: 90587 RVA: 0x003369B9 File Offset: 0x00334BB9
		[NullableContext(1)]
		public static RogueWeeklyArtifactInfoRequest Create()
		{
			return new RogueWeeklyArtifactInfoRequest();
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x060161DC RID: 90588 RVA: 0x003369C0 File Offset: 0x00334BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x060161DD RID: 90589 RVA: 0x003369C3 File Offset: 0x00334BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactInfoRequest.Descriptor;
			}
		}

		// Token: 0x060161DE RID: 90590 RVA: 0x003369CA File Offset: 0x00334BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest()
		{
		}

		// Token: 0x060161DF RID: 90591 RVA: 0x003369D2 File Offset: 0x00334BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest(RogueWeeklyArtifactInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161E0 RID: 90592 RVA: 0x003369EB File Offset: 0x00334BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoRequest Clone()
		{
			return new RogueWeeklyArtifactInfoRequest(this);
		}

		// Token: 0x060161E1 RID: 90593 RVA: 0x003369F3 File Offset: 0x00334BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactInfoRequest);
		}

		// Token: 0x060161E2 RID: 90594 RVA: 0x00336A01 File Offset: 0x00334C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060161E3 RID: 90595 RVA: 0x00336A20 File Offset: 0x00334C20
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

		// Token: 0x060161E4 RID: 90596 RVA: 0x00336A46 File Offset: 0x00334C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161E5 RID: 90597 RVA: 0x00336A53 File Offset: 0x00334C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161E6 RID: 90598 RVA: 0x00336A5C File Offset: 0x00334C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161E7 RID: 90599 RVA: 0x00336A74 File Offset: 0x00334C74
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

		// Token: 0x060161E8 RID: 90600 RVA: 0x00336A9A File Offset: 0x00334C9A
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

		// Token: 0x060161E9 RID: 90601 RVA: 0x00336AB7 File Offset: 0x00334CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161EA RID: 90602 RVA: 0x00336AC0 File Offset: 0x00334CC0
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

		// Token: 0x04008473 RID: 33907
		private UnknownFieldSet _unknownFields;
	}
}
