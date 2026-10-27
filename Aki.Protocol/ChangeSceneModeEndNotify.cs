using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025A RID: 602
	[NetMessage(EMessageId.ChangeSceneModeEndNotify)]
	public sealed class ChangeSceneModeEndNotify : IMessage<ChangeSceneModeEndNotify>, IMessage, IEquatable<ChangeSceneModeEndNotify>, IDeepCloneable<ChangeSceneModeEndNotify>, IBufferMessage
	{
		// Token: 0x06003FE3 RID: 16355 RVA: 0x0009D000 File Offset: 0x0009B200
		[NullableContext(1)]
		public static ChangeSceneModeEndNotify Create()
		{
			return new ChangeSceneModeEndNotify();
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x0009D007 File Offset: 0x0009B207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x0009D00A File Offset: 0x0009B20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneModeEndNotify.Descriptor;
			}
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x0009D011 File Offset: 0x0009B211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify()
		{
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x0009D019 File Offset: 0x0009B219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify(ChangeSceneModeEndNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0009D032 File Offset: 0x0009B232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeEndNotify Clone()
		{
			return new ChangeSceneModeEndNotify(this);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0009D03A File Offset: 0x0009B23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneModeEndNotify);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0009D048 File Offset: 0x0009B248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneModeEndNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0009D068 File Offset: 0x0009B268
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

		// Token: 0x06003FEC RID: 16364 RVA: 0x0009D08E File Offset: 0x0009B28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x0009D09B File Offset: 0x0009B29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x0009D0A4 File Offset: 0x0009B2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x0009D0BC File Offset: 0x0009B2BC
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

		// Token: 0x06003FF0 RID: 16368 RVA: 0x0009D0E2 File Offset: 0x0009B2E2
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

		// Token: 0x06003FF1 RID: 16369 RVA: 0x0009D0FF File Offset: 0x0009B2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0009D108 File Offset: 0x0009B308
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

		// Token: 0x04002D3C RID: 11580
		private UnknownFieldSet _unknownFields;
	}
}
