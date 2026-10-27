using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000841 RID: 2113
	[NetMessage(EMessageId.InviteRechallengeRequest)]
	public sealed class InviteRechallengeRequest : IMessage<InviteRechallengeRequest>, IMessage, IEquatable<InviteRechallengeRequest>, IDeepCloneable<InviteRechallengeRequest>, IBufferMessage
	{
		// Token: 0x0600BCAA RID: 48298 RVA: 0x001C0FF9 File Offset: 0x001BF1F9
		[NullableContext(1)]
		public static InviteRechallengeRequest Create()
		{
			return new InviteRechallengeRequest();
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x001C1000 File Offset: 0x001BF200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600BCAC RID: 48300 RVA: 0x001C1003 File Offset: 0x001BF203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x001C100A File Offset: 0x001BF20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest()
		{
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x001C1012 File Offset: 0x001BF212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest(InviteRechallengeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x001C102B File Offset: 0x001BF22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest Clone()
		{
			return new InviteRechallengeRequest(this);
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x001C1033 File Offset: 0x001BF233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeRequest);
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x001C1041 File Offset: 0x001BF241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x001C1060 File Offset: 0x001BF260
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

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x001C1086 File Offset: 0x001BF286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x001C1093 File Offset: 0x001BF293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x001C109C File Offset: 0x001BF29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x001C10B4 File Offset: 0x001BF2B4
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

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x001C10DA File Offset: 0x001BF2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InviteRechallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x001C10F7 File Offset: 0x001BF2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x001C1100 File Offset: 0x001BF300
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

		// Token: 0x04005299 RID: 21145
		private UnknownFieldSet _unknownFields;
	}
}
