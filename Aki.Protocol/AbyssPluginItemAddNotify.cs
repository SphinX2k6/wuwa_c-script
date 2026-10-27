using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000031 RID: 49
	[NetMessage(EMessageId.AbyssPluginItemAddNotify)]
	public sealed class AbyssPluginItemAddNotify : IMessage<AbyssPluginItemAddNotify>, IMessage, IEquatable<AbyssPluginItemAddNotify>, IDeepCloneable<AbyssPluginItemAddNotify>, IBufferMessage
	{
		// Token: 0x06001269 RID: 4713 RVA: 0x00032B5E File Offset: 0x00030D5E
		[NullableContext(1)]
		public static AbyssPluginItemAddNotify Create()
		{
			return new AbyssPluginItemAddNotify();
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00032B65 File Offset: 0x00030D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00032B68 File Offset: 0x00030D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00032B6F File Offset: 0x00030D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify()
		{
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00032B82 File Offset: 0x00030D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify(AbyssPluginItemAddNotify other) : this()
		{
			this.pluginItems_ = other.pluginItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00032BAC File Offset: 0x00030DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify Clone()
		{
			return new AbyssPluginItemAddNotify(this);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00032BB4 File Offset: 0x00030DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPluginItemInfo> PluginItems
		{
			get
			{
				return this.pluginItems_;
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00032BBC File Offset: 0x00030DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemAddNotify);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00032BCA File Offset: 0x00030DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemAddNotify other)
		{
			return other != null && (other == this || (this.pluginItems_.Equals(other.pluginItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00032C00 File Offset: 0x00030E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pluginItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00032C34 File Offset: 0x00030E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00032C41 File Offset: 0x00030E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00032C4A File Offset: 0x00030E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pluginItems_.WriteTo(ref output, AbyssPluginItemAddNotify._repeated_pluginItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00032C74 File Offset: 0x00030E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pluginItems_.CalculateSize(AbyssPluginItemAddNotify._repeated_pluginItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00032CAD File Offset: 0x00030EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pluginItems_.Add(other.pluginItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00032CDB File Offset: 0x00030EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00032CE4 File Offset: 0x00030EE4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItems_.AddEntriesFrom(ref input, AbyssPluginItemAddNotify._repeated_pluginItems_codec);
				}
			}
		}

		// Token: 0x04001FCA RID: 8138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FCB RID: 8139
		public const int PluginItemsFieldNumber = 10;

		// Token: 0x04001FCC RID: 8140
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(82U, AbyssPluginItemInfo.Parser);

		// Token: 0x04001FCD RID: 8141
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();
	}
}
