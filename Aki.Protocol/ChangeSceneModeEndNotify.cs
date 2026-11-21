using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025F RID: 607
	[NetMessage(EMessageId.ChangeSceneModeEndNotify)]
	public sealed class ChangeSceneModeEndNotify : IMessage<ChangeSceneModeEndNotify>, IMessage, IEquatable<ChangeSceneModeEndNotify>, IDeepCloneable<ChangeSceneModeEndNotify>, IBufferMessage
	{
		// Token: 0x0600408A RID: 16522 RVA: 0x0009ECCD File Offset: 0x0009CECD
		[NullableContext(1)]
		public static ChangeSceneModeEndNotify Create()
		{
			return new ChangeSceneModeEndNotify();
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x0009ECD4 File Offset: 0x0009CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x0009ECD7 File Offset: 0x0009CED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneModeEndNotify.Descriptor;
			}
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0009ECDE File Offset: 0x0009CEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify()
		{
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0009ECE6 File Offset: 0x0009CEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify(ChangeSceneModeEndNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0009ECFF File Offset: 0x0009CEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify Clone()
		{
			return new ChangeSceneModeEndNotify(this);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0009ED07 File Offset: 0x0009CF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneModeEndNotify);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0009ED15 File Offset: 0x0009CF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneModeEndNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0009ED34 File Offset: 0x0009CF34
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

		// Token: 0x06004093 RID: 16531 RVA: 0x0009ED5A File Offset: 0x0009CF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0009ED67 File Offset: 0x0009CF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0009ED70 File Offset: 0x0009CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0009ED88 File Offset: 0x0009CF88
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

		// Token: 0x06004097 RID: 16535 RVA: 0x0009EDAE File Offset: 0x0009CFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSceneModeEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0009EDCB File Offset: 0x0009CFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0009EDD4 File Offset: 0x0009CFD4
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

		// Token: 0x04002DC0 RID: 11712
		private UnknownFieldSet _unknownFields;
	}
}
