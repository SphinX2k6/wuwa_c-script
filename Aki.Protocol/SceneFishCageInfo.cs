using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114E RID: 4430
	public sealed class SceneFishCageInfo : IMessage<SceneFishCageInfo>, IMessage, IEquatable<SceneFishCageInfo>, IDeepCloneable<SceneFishCageInfo>, IBufferMessage
	{
		// Token: 0x060179DE RID: 96734 RVA: 0x0036DB89 File Offset: 0x0036BD89
		[NullableContext(1)]
		public static SceneFishCageInfo Create()
		{
			return new SceneFishCageInfo();
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x060179DF RID: 96735 RVA: 0x0036DB90 File Offset: 0x0036BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneFishCageInfo> Parser
		{
			get
			{
				return SceneFishCageInfo._parser;
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x060179E0 RID: 96736 RVA: 0x0036DB97 File Offset: 0x0036BD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x060179E1 RID: 96737 RVA: 0x0036DB9A File Offset: 0x0036BD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishCageInfo.Descriptor;
			}
		}

		// Token: 0x060179E2 RID: 96738 RVA: 0x0036DBA1 File Offset: 0x0036BDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo()
		{
		}

		// Token: 0x060179E3 RID: 96739 RVA: 0x0036DBB4 File Offset: 0x0036BDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo(SceneFishCageInfo other) : this()
		{
			this.cages_ = other.cages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179E4 RID: 96740 RVA: 0x0036DBDE File Offset: 0x0036BDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishCageInfo Clone()
		{
			return new SceneFishCageInfo(this);
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x060179E5 RID: 96741 RVA: 0x0036DBE6 File Offset: 0x0036BDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishCage> Cages
		{
			get
			{
				return this.cages_;
			}
		}

		// Token: 0x060179E6 RID: 96742 RVA: 0x0036DBEE File Offset: 0x0036BDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishCageInfo);
		}

		// Token: 0x060179E7 RID: 96743 RVA: 0x0036DBFC File Offset: 0x0036BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishCageInfo other)
		{
			return other != null && (other == this || (this.cages_.Equals(other.cages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179E8 RID: 96744 RVA: 0x0036DC30 File Offset: 0x0036BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179E9 RID: 96745 RVA: 0x0036DC64 File Offset: 0x0036BE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179EA RID: 96746 RVA: 0x0036DC71 File Offset: 0x0036BE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179EB RID: 96747 RVA: 0x0036DC7A File Offset: 0x0036BE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cages_.WriteTo(ref output, SceneFishCageInfo._repeated_cages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179EC RID: 96748 RVA: 0x0036DCA4 File Offset: 0x0036BEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cages_.CalculateSize(SceneFishCageInfo._repeated_cages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179ED RID: 96749 RVA: 0x0036DCDD File Offset: 0x0036BEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneFishCageInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.cages_.Add(other.cages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179EE RID: 96750 RVA: 0x0036DD0B File Offset: 0x0036BF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179EF RID: 96751 RVA: 0x0036DD14 File Offset: 0x0036BF14
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
					this.cages_.AddEntriesFrom(ref input, SceneFishCageInfo._repeated_cages_codec);
				}
			}
		}

		// Token: 0x04008C33 RID: 35891
		private static readonly MessageParser<SceneFishCageInfo> _parser = new MessageParser<SceneFishCageInfo>(() => new SceneFishCageInfo());

		// Token: 0x04008C34 RID: 35892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C35 RID: 35893
		public const int CagesFieldNumber = 1;

		// Token: 0x04008C36 RID: 35894
		private static readonly FieldCodec<OneFishCage> _repeated_cages_codec = FieldCodec.ForMessage<OneFishCage>(10U, OneFishCage.Parser);

		// Token: 0x04008C37 RID: 35895
		private readonly RepeatedField<OneFishCage> cages_ = new RepeatedField<OneFishCage>();
	}
}
