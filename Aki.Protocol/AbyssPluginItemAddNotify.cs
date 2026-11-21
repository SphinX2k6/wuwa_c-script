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
		// Token: 0x06001294 RID: 4756 RVA: 0x00033112 File Offset: 0x00031312
		[NullableContext(1)]
		public static AbyssPluginItemAddNotify Create()
		{
			return new AbyssPluginItemAddNotify();
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00033119 File Offset: 0x00031319
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
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0003311C File Offset: 0x0003131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemAddNotify.Descriptor;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00033123 File Offset: 0x00031323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify()
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00033136 File Offset: 0x00031336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify(AbyssPluginItemAddNotify other) : this()
		{
			this.pluginItems_ = other.pluginItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00033160 File Offset: 0x00031360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemAddNotify Clone()
		{
			return new AbyssPluginItemAddNotify(this);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00033168 File Offset: 0x00031368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPluginItemInfo> PluginItems
		{
			get
			{
				return this.pluginItems_;
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00033170 File Offset: 0x00031370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemAddNotify);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0003317E File Offset: 0x0003137E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemAddNotify other)
		{
			return other != null && (other == this || (this.pluginItems_.Equals(other.pluginItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000331B4 File Offset: 0x000313B4
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

		// Token: 0x0600129E RID: 4766 RVA: 0x000331E8 File Offset: 0x000313E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000331F5 File Offset: 0x000313F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000331FE File Offset: 0x000313FE
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

		// Token: 0x060012A1 RID: 4769 RVA: 0x00033228 File Offset: 0x00031428
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

		// Token: 0x060012A2 RID: 4770 RVA: 0x00033261 File Offset: 0x00031461
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

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003328F File Offset: 0x0003148F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00033298 File Offset: 0x00031498
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItems_.AddEntriesFrom(ref input, AbyssPluginItemAddNotify._repeated_pluginItems_codec);
				}
			}
		}

		// Token: 0x04002020 RID: 8224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002021 RID: 8225
		public const int PluginItemsFieldNumber = 13;

		// Token: 0x04002022 RID: 8226
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(106U, AbyssPluginItemInfo.Parser);

		// Token: 0x04002023 RID: 8227
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();
	}
}
