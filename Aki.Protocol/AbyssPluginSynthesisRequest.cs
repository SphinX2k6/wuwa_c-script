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
		// Token: 0x0600130A RID: 4874 RVA: 0x00033F5D File Offset: 0x0003215D
		[NullableContext(1)]
		public static AbyssPluginSynthesisRequest Create()
		{
			return new AbyssPluginSynthesisRequest();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00033F64 File Offset: 0x00032164
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
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00033F67 File Offset: 0x00032167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginSynthesisRequest.Descriptor;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00033F6E File Offset: 0x0003216E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest()
		{
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00033F81 File Offset: 0x00032181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest(AbyssPluginSynthesisRequest other) : this()
		{
			this.pluginItemIncrId_ = other.pluginItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00033FAB File Offset: 0x000321AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisRequest Clone()
		{
			return new AbyssPluginSynthesisRequest(this);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00033FB3 File Offset: 0x000321B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemIncrId
		{
			get
			{
				return this.pluginItemIncrId_;
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00033FBB File Offset: 0x000321BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginSynthesisRequest);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00033FC9 File Offset: 0x000321C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginSynthesisRequest other)
		{
			return other != null && (other == this || (this.pluginItemIncrId_.Equals(other.pluginItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00033FFC File Offset: 0x000321FC
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

		// Token: 0x06001314 RID: 4884 RVA: 0x00034030 File Offset: 0x00032230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003403D File Offset: 0x0003223D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00034046 File Offset: 0x00032246
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

		// Token: 0x06001317 RID: 4887 RVA: 0x00034070 File Offset: 0x00032270
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

		// Token: 0x06001318 RID: 4888 RVA: 0x000340A9 File Offset: 0x000322A9
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

		// Token: 0x06001319 RID: 4889 RVA: 0x000340D7 File Offset: 0x000322D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000340E0 File Offset: 0x000322E0
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItemIncrId_.AddEntriesFrom(ref input, AbyssPluginSynthesisRequest._repeated_pluginItemIncrId_codec);
				}
			}
		}

		// Token: 0x0400203F RID: 8255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002040 RID: 8256
		public const int PluginItemIncrIdFieldNumber = 9;

		// Token: 0x04002041 RID: 8257
		private static readonly FieldCodec<int> _repeated_pluginItemIncrId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002042 RID: 8258
		private readonly RepeatedField<int> pluginItemIncrId_ = new RepeatedField<int>();
	}
}
