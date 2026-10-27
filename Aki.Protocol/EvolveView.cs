using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DF RID: 1247
	public sealed class EvolveView : IMessage<EvolveView>, IMessage, IEquatable<EvolveView>, IDeepCloneable<EvolveView>, IBufferMessage
	{
		// Token: 0x06007640 RID: 30272 RVA: 0x001213CC File Offset: 0x0011F5CC
		[NullableContext(1)]
		public static EvolveView Create()
		{
			return new EvolveView();
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06007641 RID: 30273 RVA: 0x001213D3 File Offset: 0x0011F5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x001213D6 File Offset: 0x0011F5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveView.Descriptor;
			}
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x001213DD File Offset: 0x0011F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView()
		{
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x001213F0 File Offset: 0x0011F5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView(EvolveView other) : this()
		{
			this.survivorsGainDatas_ = other.survivorsGainDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x0012141A File Offset: 0x0011F61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView Clone()
		{
			return new EvolveView(this);
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007646 RID: 30278 RVA: 0x00121422 File Offset: 0x0011F622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x0012142A File Offset: 0x0011F62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveView);
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00121438 File Offset: 0x0011F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveView other)
		{
			return other != null && (other == this || (this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x0012146C File Offset: 0x0011F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.survivorsGainDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x001214A0 File Offset: 0x0011F6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x001214AD File Offset: 0x0011F6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x001214B6 File Offset: 0x0011F6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.survivorsGainDatas_.WriteTo(ref output, EvolveView._repeated_survivorsGainDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x001214E0 File Offset: 0x0011F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.survivorsGainDatas_.CalculateSize(EvolveView._repeated_survivorsGainDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00121519 File Offset: 0x0011F719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveView other)
		{
			if (other == null)
			{
				return;
			}
			this.survivorsGainDatas_.Add(other.survivorsGainDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00121547 File Offset: 0x0011F747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00121550 File Offset: 0x0011F750
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.survivorsGainDatas_.AddEntriesFrom(ref input, EvolveView._repeated_survivorsGainDatas_codec);
				}
			}
		}

		// Token: 0x04003DEB RID: 15851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DEC RID: 15852
		public const int SurvivorsGainDatasFieldNumber = 1;

		// Token: 0x04003DED RID: 15853
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(10U, SurvivorsGainData.Parser);

		// Token: 0x04003DEE RID: 15854
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();
	}
}
