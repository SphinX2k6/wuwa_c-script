using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000033 RID: 51
	[NetMessage(EMessageId.AbyssPluginItemInfoUpdateNotify)]
	public sealed class AbyssPluginItemInfoUpdateNotify : IMessage<AbyssPluginItemInfoUpdateNotify>, IMessage, IEquatable<AbyssPluginItemInfoUpdateNotify>, IDeepCloneable<AbyssPluginItemInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x0003315C File Offset: 0x0003135C
		[NullableContext(1)]
		public static AbyssPluginItemInfoUpdateNotify Create()
		{
			return new AbyssPluginItemInfoUpdateNotify();
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00033163 File Offset: 0x00031363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00033166 File Offset: 0x00031366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0003316D File Offset: 0x0003136D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify()
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00033180 File Offset: 0x00031380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify(AbyssPluginItemInfoUpdateNotify other) : this()
		{
			this.pluginItems_ = other.pluginItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000331AA File Offset: 0x000313AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify Clone()
		{
			return new AbyssPluginItemInfoUpdateNotify(this);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000331B2 File Offset: 0x000313B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPluginItemInfo> PluginItems
		{
			get
			{
				return this.pluginItems_;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000331BA File Offset: 0x000313BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemInfoUpdateNotify);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000331C8 File Offset: 0x000313C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.pluginItems_.Equals(other.pluginItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000331FC File Offset: 0x000313FC
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

		// Token: 0x0600129F RID: 4767 RVA: 0x00033230 File Offset: 0x00031430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0003323D File Offset: 0x0003143D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00033246 File Offset: 0x00031446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pluginItems_.WriteTo(ref output, AbyssPluginItemInfoUpdateNotify._repeated_pluginItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00033270 File Offset: 0x00031470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pluginItems_.CalculateSize(AbyssPluginItemInfoUpdateNotify._repeated_pluginItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000332A9 File Offset: 0x000314A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pluginItems_.Add(other.pluginItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000332D7 File Offset: 0x000314D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000332E0 File Offset: 0x000314E0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItems_.AddEntriesFrom(ref input, AbyssPluginItemInfoUpdateNotify._repeated_pluginItems_codec);
				}
			}
		}

		// Token: 0x04001FD8 RID: 8152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FD9 RID: 8153
		public const int PluginItemsFieldNumber = 9;

		// Token: 0x04001FDA RID: 8154
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(74U, AbyssPluginItemInfo.Parser);

		// Token: 0x04001FDB RID: 8155
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();
	}
}
