using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028B RID: 651
	[NetMessage(EMessageId.CheckUseSoundBoxSkillRequest)]
	public sealed class CheckUseSoundBoxSkillRequest : IMessage<CheckUseSoundBoxSkillRequest>, IMessage, IEquatable<CheckUseSoundBoxSkillRequest>, IDeepCloneable<CheckUseSoundBoxSkillRequest>, IBufferMessage
	{
		// Token: 0x06004435 RID: 17461 RVA: 0x000A75D8 File Offset: 0x000A57D8
		[NullableContext(1)]
		public static CheckUseSoundBoxSkillRequest Create()
		{
			return new CheckUseSoundBoxSkillRequest();
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x000A75DF File Offset: 0x000A57DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x000A75E2 File Offset: 0x000A57E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckUseSoundBoxSkillRequest.Descriptor;
			}
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x000A75E9 File Offset: 0x000A57E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest()
		{
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x000A75F1 File Offset: 0x000A57F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest(CheckUseSoundBoxSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000A760A File Offset: 0x000A580A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillRequest Clone()
		{
			return new CheckUseSoundBoxSkillRequest(this);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x000A7612 File Offset: 0x000A5812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckUseSoundBoxSkillRequest);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x000A7620 File Offset: 0x000A5820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckUseSoundBoxSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x000A7640 File Offset: 0x000A5840
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

		// Token: 0x0600443E RID: 17470 RVA: 0x000A7666 File Offset: 0x000A5866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000A7673 File Offset: 0x000A5873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x000A767C File Offset: 0x000A587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x000A7694 File Offset: 0x000A5894
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

		// Token: 0x06004442 RID: 17474 RVA: 0x000A76BA File Offset: 0x000A58BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckUseSoundBoxSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x000A76D7 File Offset: 0x000A58D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x000A76E0 File Offset: 0x000A58E0
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

		// Token: 0x04002EDF RID: 11999
		private UnknownFieldSet _unknownFields;
	}
}
