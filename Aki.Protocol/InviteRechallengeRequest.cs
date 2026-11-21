using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082D RID: 2093
	[NetMessage(EMessageId.InviteRechallengeRequest)]
	public sealed class InviteRechallengeRequest : IMessage<InviteRechallengeRequest>, IMessage, IEquatable<InviteRechallengeRequest>, IDeepCloneable<InviteRechallengeRequest>, IBufferMessage
	{
		// Token: 0x0600BB54 RID: 47956 RVA: 0x001BE5C1 File Offset: 0x001BC7C1
		[NullableContext(1)]
		public static InviteRechallengeRequest Create()
		{
			return new InviteRechallengeRequest();
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x0600BB55 RID: 47957 RVA: 0x001BE5C8 File Offset: 0x001BC7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x001BE5CB File Offset: 0x001BC7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x001BE5D2 File Offset: 0x001BC7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest()
		{
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x001BE5DA File Offset: 0x001BC7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest(InviteRechallengeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x001BE5F3 File Offset: 0x001BC7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeRequest Clone()
		{
			return new InviteRechallengeRequest(this);
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x001BE5FB File Offset: 0x001BC7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeRequest);
		}

		// Token: 0x0600BB5B RID: 47963 RVA: 0x001BE609 File Offset: 0x001BC809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x001BE628 File Offset: 0x001BC828
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

		// Token: 0x0600BB5D RID: 47965 RVA: 0x001BE64E File Offset: 0x001BC84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x001BE65B File Offset: 0x001BC85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x001BE664 File Offset: 0x001BC864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x001BE67C File Offset: 0x001BC87C
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

		// Token: 0x0600BB61 RID: 47969 RVA: 0x001BE6A2 File Offset: 0x001BC8A2
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

		// Token: 0x0600BB62 RID: 47970 RVA: 0x001BE6BF File Offset: 0x001BC8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB63 RID: 47971 RVA: 0x001BE6C8 File Offset: 0x001BC8C8
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

		// Token: 0x04005292 RID: 21138
		private UnknownFieldSet _unknownFields;
	}
}
