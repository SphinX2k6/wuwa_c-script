using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE8 RID: 4072
	[NetMessage(EMessageId.RogueResIllustrationAwardRequest)]
	public sealed class RogueResIllustrationAwardRequest : IMessage<RogueResIllustrationAwardRequest>, IMessage, IEquatable<RogueResIllustrationAwardRequest>, IDeepCloneable<RogueResIllustrationAwardRequest>, IBufferMessage
	{
		// Token: 0x06015C45 RID: 89157 RVA: 0x003292ED File Offset: 0x003274ED
		[NullableContext(1)]
		public static RogueResIllustrationAwardRequest Create()
		{
			return new RogueResIllustrationAwardRequest();
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06015C46 RID: 89158 RVA: 0x003292F4 File Offset: 0x003274F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06015C47 RID: 89159 RVA: 0x003292F7 File Offset: 0x003274F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationAwardRequest.Descriptor;
			}
		}

		// Token: 0x06015C48 RID: 89160 RVA: 0x003292FE File Offset: 0x003274FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest()
		{
		}

		// Token: 0x06015C49 RID: 89161 RVA: 0x00329311 File Offset: 0x00327511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest(RogueResIllustrationAwardRequest other) : this()
		{
			this.configIds_ = other.configIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C4A RID: 89162 RVA: 0x0032933B File Offset: 0x0032753B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardRequest Clone()
		{
			return new RogueResIllustrationAwardRequest(this);
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06015C4B RID: 89163 RVA: 0x00329343 File Offset: 0x00327543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigIds
		{
			get
			{
				return this.configIds_;
			}
		}

		// Token: 0x06015C4C RID: 89164 RVA: 0x0032934B File Offset: 0x0032754B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationAwardRequest);
		}

		// Token: 0x06015C4D RID: 89165 RVA: 0x00329359 File Offset: 0x00327559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationAwardRequest other)
		{
			return other != null && (other == this || (this.configIds_.Equals(other.configIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C4E RID: 89166 RVA: 0x0032938C File Offset: 0x0032758C
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

		// Token: 0x06015C4F RID: 89167 RVA: 0x003293C0 File Offset: 0x003275C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C50 RID: 89168 RVA: 0x003293CD File Offset: 0x003275CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C51 RID: 89169 RVA: 0x003293D6 File Offset: 0x003275D6
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

		// Token: 0x06015C52 RID: 89170 RVA: 0x00329400 File Offset: 0x00327600
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

		// Token: 0x06015C53 RID: 89171 RVA: 0x00329439 File Offset: 0x00327639
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

		// Token: 0x06015C54 RID: 89172 RVA: 0x00329467 File Offset: 0x00327667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C55 RID: 89173 RVA: 0x00329470 File Offset: 0x00327670
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configIds_.AddEntriesFrom(ref input, RogueResIllustrationAwardRequest._repeated_configIds_codec);
				}
			}
		}

		// Token: 0x040082A1 RID: 33441
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082A2 RID: 33442
		public const int ConfigIdsFieldNumber = 11;

		// Token: 0x040082A3 RID: 33443
		private static readonly FieldCodec<int> _repeated_configIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040082A4 RID: 33444
		private readonly RepeatedField<int> configIds_ = new RepeatedField<int>();
	}
}
