using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD8 RID: 4056
	[NetMessage(EMessageId.RogueResIllustrationAwardRequest)]
	public sealed class RogueResIllustrationAwardRequest : IMessage<RogueResIllustrationAwardRequest>, IMessage, IEquatable<RogueResIllustrationAwardRequest>, IDeepCloneable<RogueResIllustrationAwardRequest>, IBufferMessage
	{
		// Token: 0x06015B60 RID: 88928 RVA: 0x00327C35 File Offset: 0x00325E35
		[NullableContext(1)]
		public static RogueResIllustrationAwardRequest Create()
		{
			return new RogueResIllustrationAwardRequest();
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06015B61 RID: 88929 RVA: 0x00327C3C File Offset: 0x00325E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06015B62 RID: 88930 RVA: 0x00327C3F File Offset: 0x00325E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationAwardRequest.Descriptor;
			}
		}

		// Token: 0x06015B63 RID: 88931 RVA: 0x00327C46 File Offset: 0x00325E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest()
		{
		}

		// Token: 0x06015B64 RID: 88932 RVA: 0x00327C59 File Offset: 0x00325E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest(RogueResIllustrationAwardRequest other) : this()
		{
			this.configIds_ = other.configIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B65 RID: 88933 RVA: 0x00327C83 File Offset: 0x00325E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest Clone()
		{
			return new RogueResIllustrationAwardRequest(this);
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06015B66 RID: 88934 RVA: 0x00327C8B File Offset: 0x00325E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigIds
		{
			get
			{
				return this.configIds_;
			}
		}

		// Token: 0x06015B67 RID: 88935 RVA: 0x00327C93 File Offset: 0x00325E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationAwardRequest);
		}

		// Token: 0x06015B68 RID: 88936 RVA: 0x00327CA1 File Offset: 0x00325EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationAwardRequest other)
		{
			return other != null && (other == this || (this.configIds_.Equals(other.configIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B69 RID: 88937 RVA: 0x00327CD4 File Offset: 0x00325ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B6A RID: 88938 RVA: 0x00327D08 File Offset: 0x00325F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B6B RID: 88939 RVA: 0x00327D15 File Offset: 0x00325F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B6C RID: 88940 RVA: 0x00327D1E File Offset: 0x00325F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configIds_.WriteTo(ref output, RogueResIllustrationAwardRequest._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B6D RID: 88941 RVA: 0x00327D48 File Offset: 0x00325F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configIds_.CalculateSize(RogueResIllustrationAwardRequest._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B6E RID: 88942 RVA: 0x00327D81 File Offset: 0x00325F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResIllustrationAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.configIds_.Add(other.configIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B6F RID: 88943 RVA: 0x00327DAF File Offset: 0x00325FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B70 RID: 88944 RVA: 0x00327DB8 File Offset: 0x00325FB8
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configIds_.AddEntriesFrom(ref input, RogueResIllustrationAwardRequest._repeated_configIds_codec);
				}
			}
		}

		// Token: 0x040082CB RID: 33483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082CC RID: 33484
		public const int ConfigIdsFieldNumber = 3;

		// Token: 0x040082CD RID: 33485
		private static readonly FieldCodec<int> _repeated_configIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040082CE RID: 33486
		private readonly RepeatedField<int> configIds_ = new RepeatedField<int>();
	}
}
