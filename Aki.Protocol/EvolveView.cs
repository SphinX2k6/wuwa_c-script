using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C8 RID: 1224
	public sealed class EvolveView : IMessage<EvolveView>, IMessage, IEquatable<EvolveView>, IDeepCloneable<EvolveView>, IBufferMessage
	{
		// Token: 0x060074B0 RID: 29872 RVA: 0x0011E2B4 File Offset: 0x0011C4B4
		[NullableContext(1)]
		public static EvolveView Create()
		{
			return new EvolveView();
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x060074B1 RID: 29873 RVA: 0x0011E2BB File Offset: 0x0011C4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x060074B2 RID: 29874 RVA: 0x0011E2BE File Offset: 0x0011C4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveView.Descriptor;
			}
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x0011E2C5 File Offset: 0x0011C4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView()
		{
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x0011E2D8 File Offset: 0x0011C4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView(EvolveView other) : this()
		{
			this.survivorsGainDatas_ = other.survivorsGainDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x0011E302 File Offset: 0x0011C502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveView Clone()
		{
			return new EvolveView(this);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x0011E30A File Offset: 0x0011C50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x0011E312 File Offset: 0x0011C512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveView);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x0011E320 File Offset: 0x0011C520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveView other)
		{
			return other != null && (other == this || (this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0011E354 File Offset: 0x0011C554
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

		// Token: 0x060074BA RID: 29882 RVA: 0x0011E388 File Offset: 0x0011C588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0011E395 File Offset: 0x0011C595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0011E39E File Offset: 0x0011C59E
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

		// Token: 0x060074BD RID: 29885 RVA: 0x0011E3C8 File Offset: 0x0011C5C8
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

		// Token: 0x060074BE RID: 29886 RVA: 0x0011E401 File Offset: 0x0011C601
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

		// Token: 0x060074BF RID: 29887 RVA: 0x0011E42F File Offset: 0x0011C62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x0011E438 File Offset: 0x0011C638
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

		// Token: 0x04003DD7 RID: 15831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DD8 RID: 15832
		public const int SurvivorsGainDatasFieldNumber = 1;

		// Token: 0x04003DD9 RID: 15833
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(10U, SurvivorsGainData.Parser);

		// Token: 0x04003DDA RID: 15834
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();
	}
}
