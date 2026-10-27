using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080B RID: 2059
	[NetMessage(EMessageId.InfrV2TreeFinishCondUpdateNotify)]
	public sealed class InfrV2TreeFinishCondUpdateNotify : IMessage<InfrV2TreeFinishCondUpdateNotify>, IMessage, IEquatable<InfrV2TreeFinishCondUpdateNotify>, IDeepCloneable<InfrV2TreeFinishCondUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B834 RID: 47156 RVA: 0x001B6DB9 File Offset: 0x001B4FB9
		[NullableContext(1)]
		public static InfrV2TreeFinishCondUpdateNotify Create()
		{
			return new InfrV2TreeFinishCondUpdateNotify();
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x0600B835 RID: 47157 RVA: 0x001B6DC0 File Offset: 0x001B4FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x001B6DC3 File Offset: 0x001B4FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeFinishCondUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x001B6DCA File Offset: 0x001B4FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify()
		{
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x001B6DDD File Offset: 0x001B4FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify(InfrV2TreeFinishCondUpdateNotify other) : this()
		{
			this.cond_ = other.cond_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x001B6E07 File Offset: 0x001B5007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify Clone()
		{
			return new InfrV2TreeFinishCondUpdateNotify(this);
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600B83A RID: 47162 RVA: 0x001B6E0F File Offset: 0x001B500F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Cond
		{
			get
			{
				return this.cond_;
			}
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x001B6E17 File Offset: 0x001B5017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeFinishCondUpdateNotify);
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x001B6E25 File Offset: 0x001B5025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeFinishCondUpdateNotify other)
		{
			return other != null && (other == this || (this.cond_.Equals(other.cond_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x001B6E58 File Offset: 0x001B5058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cond_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x001B6E8C File Offset: 0x001B508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x001B6E99 File Offset: 0x001B5099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x001B6EA2 File Offset: 0x001B50A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cond_.WriteTo(ref output, InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x001B6ECC File Offset: 0x001B50CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cond_.CalculateSize(InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x001B6F05 File Offset: 0x001B5105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeFinishCondUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.cond_.Add(other.cond_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B843 RID: 47171 RVA: 0x001B6F33 File Offset: 0x001B5133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x001B6F3C File Offset: 0x001B513C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cond_.AddEntriesFrom(ref input, InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
				}
			}
		}

		// Token: 0x0400512E RID: 20782
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400512F RID: 20783
		public const int CondFieldNumber = 10;

		// Token: 0x04005130 RID: 20784
		private static readonly FieldCodec<int> _repeated_cond_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005131 RID: 20785
		private readonly RepeatedField<int> cond_ = new RepeatedField<int>();
	}
}
