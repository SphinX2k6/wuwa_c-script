using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B4 RID: 5812
	[NetMessage(EMessageId.AiInformationNotify)]
	public sealed class AiInformationNotify : IMessage<AiInformationNotify>, IMessage, IEquatable<AiInformationNotify>, IDeepCloneable<AiInformationNotify>, IBufferMessage
	{
		// Token: 0x0601D1E5 RID: 119269 RVA: 0x00442953 File Offset: 0x00440B53
		[NullableContext(1)]
		public static AiInformationNotify Create()
		{
			return new AiInformationNotify();
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x0601D1E6 RID: 119270 RVA: 0x0044295A File Offset: 0x00440B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x0601D1E7 RID: 119271 RVA: 0x0044295D File Offset: 0x00440B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationNotify.Descriptor;
			}
		}

		// Token: 0x0601D1E8 RID: 119272 RVA: 0x00442964 File Offset: 0x00440B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify()
		{
		}

		// Token: 0x0601D1E9 RID: 119273 RVA: 0x00442977 File Offset: 0x00440B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify(AiInformationNotify other) : this()
		{
			this.aiBlackboardCd_ = other.aiBlackboardCd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1EA RID: 119274 RVA: 0x004429A1 File Offset: 0x00440BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify Clone()
		{
			return new AiInformationNotify(this);
		}

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x0601D1EB RID: 119275 RVA: 0x004429A9 File Offset: 0x00440BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCd
		{
			get
			{
				return this.aiBlackboardCd_;
			}
		}

		// Token: 0x0601D1EC RID: 119276 RVA: 0x004429B1 File Offset: 0x00440BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationNotify);
		}

		// Token: 0x0601D1ED RID: 119277 RVA: 0x004429BF File Offset: 0x00440BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationNotify other)
		{
			return other != null && (other == this || (this.aiBlackboardCd_.Equals(other.aiBlackboardCd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x004429F4 File Offset: 0x00440BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D1EF RID: 119279 RVA: 0x00442A28 File Offset: 0x00440C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1F0 RID: 119280 RVA: 0x00442A35 File Offset: 0x00440C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1F1 RID: 119281 RVA: 0x00442A3E File Offset: 0x00440C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCd_.WriteTo(ref output, AiInformationNotify._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1F2 RID: 119282 RVA: 0x00442A68 File Offset: 0x00440C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCd_.CalculateSize(AiInformationNotify._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D1F3 RID: 119283 RVA: 0x00442AA1 File Offset: 0x00440CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCd_.Add(other.aiBlackboardCd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D1F4 RID: 119284 RVA: 0x00442ACF File Offset: 0x00440CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1F5 RID: 119285 RVA: 0x00442AD8 File Offset: 0x00440CD8
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
					this.aiBlackboardCd_.AddEntriesFrom(ref input, AiInformationNotify._repeated_aiBlackboardCd_codec);
				}
			}
		}

		// Token: 0x0400C459 RID: 50265
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C45A RID: 50266
		public const int AiBlackboardCdFieldNumber = 10;

		// Token: 0x0400C45B RID: 50267
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCd_codec = FieldCodec.ForMessage<Int2Long>(82U, Int2Long.Parser);

		// Token: 0x0400C45C RID: 50268
		private readonly RepeatedField<Int2Long> aiBlackboardCd_ = new RepeatedField<Int2Long>();
	}
}
