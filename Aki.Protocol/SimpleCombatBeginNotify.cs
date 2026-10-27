using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121D RID: 4637
	[NetMessage(EMessageId.SimpleCombatBeginNotify)]
	public sealed class SimpleCombatBeginNotify : IMessage<SimpleCombatBeginNotify>, IMessage, IEquatable<SimpleCombatBeginNotify>, IDeepCloneable<SimpleCombatBeginNotify>, IBufferMessage
	{
		// Token: 0x06018B53 RID: 101203 RVA: 0x00397B3B File Offset: 0x00395D3B
		[NullableContext(1)]
		public static SimpleCombatBeginNotify Create()
		{
			return new SimpleCombatBeginNotify();
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x06018B54 RID: 101204 RVA: 0x00397B42 File Offset: 0x00395D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x06018B55 RID: 101205 RVA: 0x00397B45 File Offset: 0x00395D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatBeginNotify.Descriptor;
			}
		}

		// Token: 0x06018B56 RID: 101206 RVA: 0x00397B4C File Offset: 0x00395D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify()
		{
		}

		// Token: 0x06018B57 RID: 101207 RVA: 0x00397B54 File Offset: 0x00395D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify(SimpleCombatBeginNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B58 RID: 101208 RVA: 0x00397B6D File Offset: 0x00395D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatBeginNotify Clone()
		{
			return new SimpleCombatBeginNotify(this);
		}

		// Token: 0x06018B59 RID: 101209 RVA: 0x00397B75 File Offset: 0x00395D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatBeginNotify);
		}

		// Token: 0x06018B5A RID: 101210 RVA: 0x00397B83 File Offset: 0x00395D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatBeginNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018B5B RID: 101211 RVA: 0x00397BA4 File Offset: 0x00395DA4
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

		// Token: 0x06018B5C RID: 101212 RVA: 0x00397BCA File Offset: 0x00395DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B5D RID: 101213 RVA: 0x00397BD7 File Offset: 0x00395DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B5E RID: 101214 RVA: 0x00397BE0 File Offset: 0x00395DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B5F RID: 101215 RVA: 0x00397BF8 File Offset: 0x00395DF8
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

		// Token: 0x06018B60 RID: 101216 RVA: 0x00397C1E File Offset: 0x00395E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatBeginNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B61 RID: 101217 RVA: 0x00397C3B File Offset: 0x00395E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B62 RID: 101218 RVA: 0x00397C44 File Offset: 0x00395E44
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

		// Token: 0x040091D9 RID: 37337
		private UnknownFieldSet _unknownFields;
	}
}
