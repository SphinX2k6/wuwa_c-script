using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000018 RID: 24
	[NetMessage(EMessageId.AbyssChallengeQuitRequest)]
	public sealed class AbyssChallengeQuitRequest : IMessage<AbyssChallengeQuitRequest>, IMessage, IEquatable<AbyssChallengeQuitRequest>, IDeepCloneable<AbyssChallengeQuitRequest>, IBufferMessage
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x0002DA69 File Offset: 0x0002BC69
		[NullableContext(1)]
		public static AbyssChallengeQuitRequest Create()
		{
			return new AbyssChallengeQuitRequest();
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0002DA70 File Offset: 0x0002BC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0002DA73 File Offset: 0x0002BC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0002DA7A File Offset: 0x0002BC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest()
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0002DA82 File Offset: 0x0002BC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest(AbyssChallengeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0002DA9B File Offset: 0x0002BC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest Clone()
		{
			return new AbyssChallengeQuitRequest(this);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0002DAA3 File Offset: 0x0002BCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeQuitRequest);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002DAB1 File Offset: 0x0002BCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0002DAD0 File Offset: 0x0002BCD0
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

		// Token: 0x06001054 RID: 4180 RVA: 0x0002DAF6 File Offset: 0x0002BCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0002DB03 File Offset: 0x0002BD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0002DB24 File Offset: 0x0002BD24
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

		// Token: 0x06001058 RID: 4184 RVA: 0x0002DB4A File Offset: 0x0002BD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002DB67 File Offset: 0x0002BD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002DB70 File Offset: 0x0002BD70
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

		// Token: 0x04001F06 RID: 7942
		private UnknownFieldSet _unknownFields;
	}
}
