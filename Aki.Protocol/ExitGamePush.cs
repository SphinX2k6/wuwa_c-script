using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EB RID: 1259
	[NetMessage(EMessageId.ExitGamePush)]
	public sealed class ExitGamePush : IMessage<ExitGamePush>, IMessage, IEquatable<ExitGamePush>, IDeepCloneable<ExitGamePush>, IBufferMessage
	{
		// Token: 0x06007725 RID: 30501 RVA: 0x00122F61 File Offset: 0x00121161
		[NullableContext(1)]
		public static ExitGamePush Create()
		{
			return new ExitGamePush();
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06007726 RID: 30502 RVA: 0x00122F68 File Offset: 0x00121168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06007727 RID: 30503 RVA: 0x00122F6B File Offset: 0x0012116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitGamePush.Descriptor;
			}
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00122F72 File Offset: 0x00121172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush()
		{
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00122F7A File Offset: 0x0012117A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush(ExitGamePush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00122F93 File Offset: 0x00121193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitGamePush Clone()
		{
			return new ExitGamePush(this);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00122F9B File Offset: 0x0012119B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitGamePush);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00122FA9 File Offset: 0x001211A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitGamePush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00122FC8 File Offset: 0x001211C8
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

		// Token: 0x0600772E RID: 30510 RVA: 0x00122FEE File Offset: 0x001211EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00122FFB File Offset: 0x001211FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00123004 File Offset: 0x00121204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x0012301C File Offset: 0x0012121C
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

		// Token: 0x06007732 RID: 30514 RVA: 0x00123042 File Offset: 0x00121242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitGamePush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x0012305F File Offset: 0x0012125F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00123068 File Offset: 0x00121268
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

		// Token: 0x04003E22 RID: 15906
		private UnknownFieldSet _unknownFields;
	}
}
