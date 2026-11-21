using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C2 RID: 1730
	[NetMessage(EMessageId.GiantActivityNodeActiveNotify)]
	public sealed class GiantActivityNodeActiveNotify : IMessage<GiantActivityNodeActiveNotify>, IMessage, IEquatable<GiantActivityNodeActiveNotify>, IDeepCloneable<GiantActivityNodeActiveNotify>, IBufferMessage
	{
		// Token: 0x06009E7B RID: 40571 RVA: 0x0018081F File Offset: 0x0017EA1F
		[NullableContext(1)]
		public static GiantActivityNodeActiveNotify Create()
		{
			return new GiantActivityNodeActiveNotify();
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x00180826 File Offset: 0x0017EA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06009E7D RID: 40573 RVA: 0x00180829 File Offset: 0x0017EA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantActivityNodeActiveNotify.Descriptor;
			}
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x00180830 File Offset: 0x0017EA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify()
		{
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x00180843 File Offset: 0x0017EA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify(GiantActivityNodeActiveNotify other) : this()
		{
			this.activeIds_ = other.activeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x0018086D File Offset: 0x0017EA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityNodeActiveNotify Clone()
		{
			return new GiantActivityNodeActiveNotify(this);
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x00180875 File Offset: 0x0017EA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveIds
		{
			get
			{
				return this.activeIds_;
			}
		}

		// Token: 0x06009E82 RID: 40578 RVA: 0x0018087D File Offset: 0x0017EA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantActivityNodeActiveNotify);
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x0018088B File Offset: 0x0017EA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantActivityNodeActiveNotify other)
		{
			return other != null && (other == this || (this.activeIds_.Equals(other.activeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x001808C0 File Offset: 0x0017EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x001808F4 File Offset: 0x0017EAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x00180901 File Offset: 0x0017EB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x0018090A File Offset: 0x0017EB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeIds_.WriteTo(ref output, GiantActivityNodeActiveNotify._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x00180934 File Offset: 0x0017EB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeIds_.CalculateSize(GiantActivityNodeActiveNotify._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x0018096D File Offset: 0x0017EB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantActivityNodeActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activeIds_.Add(other.activeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x0018099B File Offset: 0x0017EB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x001809A4 File Offset: 0x0017EBA4
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activeIds_.AddEntriesFrom(ref input, GiantActivityNodeActiveNotify._repeated_activeIds_codec);
				}
			}
		}

		// Token: 0x04004A7B RID: 19067
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A7C RID: 19068
		public const int ActiveIdsFieldNumber = 7;

		// Token: 0x04004A7D RID: 19069
		private static readonly FieldCodec<int> _repeated_activeIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004A7E RID: 19070
		private readonly RepeatedField<int> activeIds_ = new RepeatedField<int>();
	}
}
