using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000279 RID: 633
	[NetMessage(EMessageId.CharacterDeathResponse)]
	public sealed class CharacterDeathResponse : IMessage<CharacterDeathResponse>, IMessage, IEquatable<CharacterDeathResponse>, IDeepCloneable<CharacterDeathResponse>, IBufferMessage
	{
		// Token: 0x060042B8 RID: 17080 RVA: 0x000A3EB0 File Offset: 0x000A20B0
		[NullableContext(1)]
		public static CharacterDeathResponse Create()
		{
			return new CharacterDeathResponse();
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x000A3EB7 File Offset: 0x000A20B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x000A3EBA File Offset: 0x000A20BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDeathResponse.Descriptor;
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000A3EC1 File Offset: 0x000A20C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse()
		{
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000A3EC9 File Offset: 0x000A20C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse(CharacterDeathResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000A3EE2 File Offset: 0x000A20E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterDeathResponse Clone()
		{
			return new CharacterDeathResponse(this);
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000A3EEA File Offset: 0x000A20EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDeathResponse);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000A3EF8 File Offset: 0x000A20F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterDeathResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000A3F18 File Offset: 0x000A2118
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

		// Token: 0x060042C1 RID: 17089 RVA: 0x000A3F3E File Offset: 0x000A213E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000A3F4B File Offset: 0x000A214B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x000A3F54 File Offset: 0x000A2154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x000A3F6C File Offset: 0x000A216C
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

		// Token: 0x060042C5 RID: 17093 RVA: 0x000A3F92 File Offset: 0x000A2192
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

		// Token: 0x060042C6 RID: 17094 RVA: 0x000A3FAF File Offset: 0x000A21AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000A3FB8 File Offset: 0x000A21B8
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

		// Token: 0x04002E6B RID: 11883
		private UnknownFieldSet _unknownFields;
	}
}
