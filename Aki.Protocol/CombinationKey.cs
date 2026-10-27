using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B2 RID: 690
	public sealed class CombinationKey : IMessage<CombinationKey>, IMessage, IEquatable<CombinationKey>, IDeepCloneable<CombinationKey>, IBufferMessage
	{
		// Token: 0x06004769 RID: 18281 RVA: 0x000AF793 File Offset: 0x000AD993
		[NullableContext(1)]
		public static CombinationKey Create()
		{
			return new CombinationKey();
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x000AF79A File Offset: 0x000AD99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationKey> Parser
		{
			get
			{
				return CombinationKey._parser;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x000AF7A1 File Offset: 0x000AD9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationKey.Descriptor;
			}
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x000AF7AB File Offset: 0x000AD9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey()
		{
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x000AF7BE File Offset: 0x000AD9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey(CombinationKey other) : this()
		{
			this.keyNameList_ = other.keyNameList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x000AF7E8 File Offset: 0x000AD9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey Clone()
		{
			return new CombinationKey(this);
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x000AF7F0 File Offset: 0x000AD9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> KeyNameList
		{
			get
			{
				return this.keyNameList_;
			}
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x000AF7F8 File Offset: 0x000AD9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationKey);
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x000AF806 File Offset: 0x000ADA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationKey other)
		{
			return other != null && (other == this || (this.keyNameList_.Equals(other.keyNameList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x000AF83C File Offset: 0x000ADA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.keyNameList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x000AF870 File Offset: 0x000ADA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x000AF87D File Offset: 0x000ADA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x000AF886 File Offset: 0x000ADA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.keyNameList_.WriteTo(ref output, CombinationKey._repeated_keyNameList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x000AF8B0 File Offset: 0x000ADAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.keyNameList_.CalculateSize(CombinationKey._repeated_keyNameList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x000AF8E9 File Offset: 0x000ADAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombinationKey other)
		{
			if (other == null)
			{
				return;
			}
			this.keyNameList_.Add(other.keyNameList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x000AF917 File Offset: 0x000ADB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x000AF920 File Offset: 0x000ADB20
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.keyNameList_.AddEntriesFrom(ref input, CombinationKey._repeated_keyNameList_codec);
				}
			}
		}

		// Token: 0x04002FA1 RID: 12193
		private static readonly MessageParser<CombinationKey> _parser = new MessageParser<CombinationKey>(() => new CombinationKey());

		// Token: 0x04002FA2 RID: 12194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA3 RID: 12195
		public const int KeyNameListFieldNumber = 1;

		// Token: 0x04002FA4 RID: 12196
		private static readonly FieldCodec<string> _repeated_keyNameList_codec = FieldCodec.ForString(10U);

		// Token: 0x04002FA5 RID: 12197
		private readonly RepeatedField<string> keyNameList_ = new RepeatedField<string>();
	}
}
