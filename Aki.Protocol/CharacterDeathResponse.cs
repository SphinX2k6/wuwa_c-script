using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000274 RID: 628
	[NetMessage(EMessageId.CharacterDeathResponse)]
	public sealed class CharacterDeathResponse : IMessage<CharacterDeathResponse>, IMessage, IEquatable<CharacterDeathResponse>, IDeepCloneable<CharacterDeathResponse>, IBufferMessage
	{
		// Token: 0x06004211 RID: 16913 RVA: 0x000A21E4 File Offset: 0x000A03E4
		[NullableContext(1)]
		public static CharacterDeathResponse Create()
		{
			return new CharacterDeathResponse();
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x000A21EB File Offset: 0x000A03EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x000A21EE File Offset: 0x000A03EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathResponse.Descriptor;
			}
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000A21F5 File Offset: 0x000A03F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse()
		{
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x000A21FD File Offset: 0x000A03FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse(CharacterDeathResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x000A2216 File Offset: 0x000A0416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse Clone()
		{
			return new CharacterDeathResponse(this);
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x000A221E File Offset: 0x000A041E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathResponse);
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000A222C File Offset: 0x000A042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x000A224C File Offset: 0x000A044C
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

		// Token: 0x0600421A RID: 16922 RVA: 0x000A2272 File Offset: 0x000A0472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000A227F File Offset: 0x000A047F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000A2288 File Offset: 0x000A0488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x000A22A0 File Offset: 0x000A04A0
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

		// Token: 0x0600421E RID: 16926 RVA: 0x000A22C6 File Offset: 0x000A04C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterDeathResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x000A22E3 File Offset: 0x000A04E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000A22EC File Offset: 0x000A04EC
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

		// Token: 0x04002DE7 RID: 11751
		private UnknownFieldSet _unknownFields;
	}
}
