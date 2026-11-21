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
		// Token: 0x060012C0 RID: 4800 RVA: 0x00033710 File Offset: 0x00031910
		[NullableContext(1)]
		public static AbyssPluginItemInfoUpdateNotify Create()
		{
			return new AbyssPluginItemInfoUpdateNotify();
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00033717 File Offset: 0x00031917
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
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0003371A File Offset: 0x0003191A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00033721 File Offset: 0x00031921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify()
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00033734 File Offset: 0x00031934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify(AbyssPluginItemInfoUpdateNotify other) : this()
		{
			this.pluginItems_ = other.pluginItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0003375E File Offset: 0x0003195E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemInfoUpdateNotify Clone()
		{
			return new AbyssPluginItemInfoUpdateNotify(this);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00033766 File Offset: 0x00031966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssPluginItemInfo> PluginItems
		{
			get
			{
				return this.pluginItems_;
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003376E File Offset: 0x0003196E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemInfoUpdateNotify);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0003377C File Offset: 0x0003197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.pluginItems_.Equals(other.pluginItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000337B0 File Offset: 0x000319B0
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

		// Token: 0x060012CA RID: 4810 RVA: 0x000337E4 File Offset: 0x000319E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000337F1 File Offset: 0x000319F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000337FA File Offset: 0x000319FA
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

		// Token: 0x060012CD RID: 4813 RVA: 0x00033824 File Offset: 0x00031A24
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

		// Token: 0x060012CE RID: 4814 RVA: 0x0003385D File Offset: 0x00031A5D
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

		// Token: 0x060012CF RID: 4815 RVA: 0x0003388B File Offset: 0x00031A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00033894 File Offset: 0x00031A94
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pluginItems_.AddEntriesFrom(ref input, AbyssPluginItemInfoUpdateNotify._repeated_pluginItems_codec);
				}
			}
		}

		// Token: 0x0400202E RID: 8238
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400202F RID: 8239
		public const int PluginItemsFieldNumber = 2;

		// Token: 0x04002030 RID: 8240
		private static readonly FieldCodec<AbyssPluginItemInfo> _repeated_pluginItems_codec = FieldCodec.ForMessage<AbyssPluginItemInfo>(18U, AbyssPluginItemInfo.Parser);

		// Token: 0x04002031 RID: 8241
		private readonly RepeatedField<AbyssPluginItemInfo> pluginItems_ = new RepeatedField<AbyssPluginItemInfo>();
	}
}
