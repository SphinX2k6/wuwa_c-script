using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121F RID: 4639
	[NetMessage(EMessageId.SimpleCombatEndNotify)]
	public sealed class SimpleCombatEndNotify : IMessage<SimpleCombatEndNotify>, IMessage, IEquatable<SimpleCombatEndNotify>, IDeepCloneable<SimpleCombatEndNotify>, IBufferMessage
	{
		// Token: 0x06018B81 RID: 101249 RVA: 0x003982CC File Offset: 0x003964CC
		[NullableContext(1)]
		public static SimpleCombatEndNotify Create()
		{
			return new SimpleCombatEndNotify();
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x06018B82 RID: 101250 RVA: 0x003982D3 File Offset: 0x003964D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x06018B83 RID: 101251 RVA: 0x003982D6 File Offset: 0x003964D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEndNotify.Descriptor;
			}
		}

		// Token: 0x06018B84 RID: 101252 RVA: 0x003982DD File Offset: 0x003964DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify()
		{
		}

		// Token: 0x06018B85 RID: 101253 RVA: 0x003982E5 File Offset: 0x003964E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify(SimpleCombatEndNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B86 RID: 101254 RVA: 0x003982FE File Offset: 0x003964FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEndNotify Clone()
		{
			return new SimpleCombatEndNotify(this);
		}

		// Token: 0x06018B87 RID: 101255 RVA: 0x00398306 File Offset: 0x00396506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEndNotify);
		}

		// Token: 0x06018B88 RID: 101256 RVA: 0x00398314 File Offset: 0x00396514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEndNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06018B89 RID: 101257 RVA: 0x00398334 File Offset: 0x00396534
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

		// Token: 0x06018B8A RID: 101258 RVA: 0x0039835A File Offset: 0x0039655A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B8B RID: 101259 RVA: 0x00398367 File Offset: 0x00396567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B8C RID: 101260 RVA: 0x00398370 File Offset: 0x00396570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B8D RID: 101261 RVA: 0x00398388 File Offset: 0x00396588
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

		// Token: 0x06018B8E RID: 101262 RVA: 0x003983AE File Offset: 0x003965AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B8F RID: 101263 RVA: 0x003983CB File Offset: 0x003965CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B90 RID: 101264 RVA: 0x003983D4 File Offset: 0x003965D4
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

		// Token: 0x040091ED RID: 37357
		private UnknownFieldSet _unknownFields;
	}
}
