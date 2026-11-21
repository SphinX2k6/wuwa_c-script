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
		// Token: 0x06001076 RID: 4214 RVA: 0x0002E01D File Offset: 0x0002C21D
		[NullableContext(1)]
		public static AbyssChallengeQuitRequest Create()
		{
			return new AbyssChallengeQuitRequest();
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0002E024 File Offset: 0x0002C224
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
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0002E027 File Offset: 0x0002C227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002E02E File Offset: 0x0002C22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest()
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002E036 File Offset: 0x0002C236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest(AbyssChallengeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002E04F File Offset: 0x0002C24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeQuitRequest Clone()
		{
			return new AbyssChallengeQuitRequest(this);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002E057 File Offset: 0x0002C257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeQuitRequest);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002E065 File Offset: 0x0002C265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002E084 File Offset: 0x0002C284
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

		// Token: 0x0600107F RID: 4223 RVA: 0x0002E0AA File Offset: 0x0002C2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002E0B7 File Offset: 0x0002C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002E0C0 File Offset: 0x0002C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
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

		// Token: 0x06001083 RID: 4227 RVA: 0x0002E0FE File Offset: 0x0002C2FE
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

		// Token: 0x06001084 RID: 4228 RVA: 0x0002E11B File Offset: 0x0002C31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002E124 File Offset: 0x0002C324
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

		// Token: 0x04001F5C RID: 8028
		private UnknownFieldSet _unknownFields;
	}
}
