using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B8 RID: 696
	public sealed class CombinationKey : IMessage<CombinationKey>, IMessage, IEquatable<CombinationKey>, IDeepCloneable<CombinationKey>, IBufferMessage
	{
		// Token: 0x06004830 RID: 18480 RVA: 0x000B1997 File Offset: 0x000AFB97
		[NullableContext(1)]
		public static CombinationKey Create()
		{
			return new CombinationKey();
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x000B199E File Offset: 0x000AFB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationKey> Parser
		{
			get
			{
				return CombinationKey._parser;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x000B19A5 File Offset: 0x000AFBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x000B19A8 File Offset: 0x000AFBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationKey.Descriptor;
			}
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x000B19AF File Offset: 0x000AFBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey()
		{
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x000B19C2 File Offset: 0x000AFBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey(CombinationKey other) : this()
		{
			this.keyNameList_ = other.keyNameList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x000B19EC File Offset: 0x000AFBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationKey Clone()
		{
			return new CombinationKey(this);
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x000B19F4 File Offset: 0x000AFBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> KeyNameList
		{
			get
			{
				return this.keyNameList_;
			}
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x000B19FC File Offset: 0x000AFBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationKey);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x000B1A0A File Offset: 0x000AFC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationKey other)
		{
			return other != null && (other == this || (this.keyNameList_.Equals(other.keyNameList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x000B1A40 File Offset: 0x000AFC40
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

		// Token: 0x0600483B RID: 18491 RVA: 0x000B1A74 File Offset: 0x000AFC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x000B1A81 File Offset: 0x000AFC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x000B1A8A File Offset: 0x000AFC8A
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

		// Token: 0x0600483E RID: 18494 RVA: 0x000B1AB4 File Offset: 0x000AFCB4
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

		// Token: 0x0600483F RID: 18495 RVA: 0x000B1AED File Offset: 0x000AFCED
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

		// Token: 0x06004840 RID: 18496 RVA: 0x000B1B1B File Offset: 0x000AFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x000B1B24 File Offset: 0x000AFD24
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

		// Token: 0x04003034 RID: 12340
		private static readonly MessageParser<CombinationKey> _parser = new MessageParser<CombinationKey>(() => new CombinationKey());

		// Token: 0x04003035 RID: 12341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003036 RID: 12342
		public const int KeyNameListFieldNumber = 1;

		// Token: 0x04003037 RID: 12343
		private static readonly FieldCodec<string> _repeated_keyNameList_codec = FieldCodec.ForString(10U);

		// Token: 0x04003038 RID: 12344
		private readonly RepeatedField<string> keyNameList_ = new RepeatedField<string>();
	}
}
