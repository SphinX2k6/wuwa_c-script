using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000034 RID: 52
	[NetMessage(EMessageId.AbyssPluginItemRemoveNotify)]
	public sealed class AbyssPluginItemRemoveNotify : IMessage<AbyssPluginItemRemoveNotify>, IMessage, IEquatable<AbyssPluginItemRemoveNotify>, IDeepCloneable<AbyssPluginItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x000338F1 File Offset: 0x00031AF1
		[NullableContext(1)]
		public static AbyssPluginItemRemoveNotify Create()
		{
			return new AbyssPluginItemRemoveNotify();
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000338F8 File Offset: 0x00031AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000338FB File Offset: 0x00031AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00033902 File Offset: 0x00031B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify()
		{
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00033915 File Offset: 0x00031B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify(AbyssPluginItemRemoveNotify other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0003393F File Offset: 0x00031B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify Clone()
		{
			return new AbyssPluginItemRemoveNotify(this);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00033947 File Offset: 0x00031B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0003394F File Offset: 0x00031B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemRemoveNotify);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0003395D File Offset: 0x00031B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemRemoveNotify other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00033990 File Offset: 0x00031B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000339C4 File Offset: 0x00031BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000339D1 File Offset: 0x00031BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000339DA File Offset: 0x00031BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00033A04 File Offset: 0x00031C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00033A3D File Offset: 0x00031C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00033A6B File Offset: 0x00031C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00033A74 File Offset: 0x00031C74
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.incrIds_.AddEntriesFrom(ref input, AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x04002032 RID: 8242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002033 RID: 8243
		public const int IncrIdsFieldNumber = 6;

		// Token: 0x04002034 RID: 8244
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04002035 RID: 8245
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
