using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000037 RID: 55
	[NetMessage(EMessageId.AbyssPluginSynthesisRequest)]
	public sealed class AbyssPluginSynthesisRequest : IMessage<AbyssPluginSynthesisRequest>, IMessage, IEquatable<AbyssPluginSynthesisRequest>, IDeepCloneable<AbyssPluginSynthesisRequest>, IBufferMessage
	{
		// Token: 0x060012DF RID: 4831 RVA: 0x000339A9 File Offset: 0x00031BA9
		[NullableContext(1)]
		public static AbyssPluginSynthesisRequest Create()
		{
			return new AbyssPluginSynthesisRequest();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000339B0 File Offset: 0x00031BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000339B3 File Offset: 0x00031BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginSynthesisRequest.Descriptor;
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000339BA File Offset: 0x00031BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest()
		{
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000339CD File Offset: 0x00031BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest(AbyssPluginSynthesisRequest other) : this()
		{
			this.pluginItemIncrId_ = other.pluginItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000339F7 File Offset: 0x00031BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest Clone()
		{
			return new AbyssPluginSynthesisRequest(this);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000339FF File Offset: 0x00031BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemIncrId
		{
			get
			{
				return this.pluginItemIncrId_;
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00033A07 File Offset: 0x00031C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginSynthesisRequest);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00033A15 File Offset: 0x00031C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginSynthesisRequest other)
		{
			return other != null && (other == this || (this.pluginItemIncrId_.Equals(other.pluginItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00033A48 File Offset: 0x00031C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pluginItemIncrId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00033A7C File Offset: 0x00031C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00033A89 File Offset: 0x00031C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00033A92 File Offset: 0x00031C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pluginItemIncrId_.WriteTo(ref output, AbyssPluginSynthesisRequest._repeated_pluginItemIncrId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00033ABC File Offset: 0x00031CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pluginItemIncrId_.CalculateSize(AbyssPluginSynthesisRequest._repeated_pluginItemIncrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00033AF5 File Offset: 0x00031CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginSynthesisRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.pluginItemIncrId_.Add(other.pluginItemIncrId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00033B23 File Offset: 0x00031D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00033B2C File Offset: 0x00031D2C
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItemIncrId_.AddEntriesFrom(ref input, AbyssPluginSynthesisRequest._repeated_pluginItemIncrId_codec);
				}
			}
		}

		// Token: 0x04001FE9 RID: 8169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FEA RID: 8170
		public const int PluginItemIncrIdFieldNumber = 14;

		// Token: 0x04001FEB RID: 8171
		private static readonly FieldCodec<int> _repeated_pluginItemIncrId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04001FEC RID: 8172
		private readonly RepeatedField<int> pluginItemIncrId_ = new RepeatedField<int>();
	}
}
