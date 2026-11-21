using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001332 RID: 4914
	[NetMessage(EMessageId.SurvivorsComboParamUpdateNotify)]
	public sealed class SurvivorsComboParamUpdateNotify : IMessage<SurvivorsComboParamUpdateNotify>, IMessage, IEquatable<SurvivorsComboParamUpdateNotify>, IDeepCloneable<SurvivorsComboParamUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A31D RID: 107293 RVA: 0x003D15F4 File Offset: 0x003CF7F4
		[NullableContext(1)]
		public static SurvivorsComboParamUpdateNotify Create()
		{
			return new SurvivorsComboParamUpdateNotify();
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x0601A31E RID: 107294 RVA: 0x003D15FB File Offset: 0x003CF7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x0601A31F RID: 107295 RVA: 0x003D15FE File Offset: 0x003CF7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsComboParamUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A320 RID: 107296 RVA: 0x003D1605 File Offset: 0x003CF805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify()
		{
		}

		// Token: 0x0601A321 RID: 107297 RVA: 0x003D1618 File Offset: 0x003CF818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify(SurvivorsComboParamUpdateNotify other) : this()
		{
			this.comboParamInfos_ = other.comboParamInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A322 RID: 107298 RVA: 0x003D1642 File Offset: 0x003CF842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsComboParamUpdateNotify Clone()
		{
			return new SurvivorsComboParamUpdateNotify(this);
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x0601A323 RID: 107299 RVA: 0x003D164A File Offset: 0x003CF84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ComboParamInfo> ComboParamInfos
		{
			get
			{
				return this.comboParamInfos_;
			}
		}

		// Token: 0x0601A324 RID: 107300 RVA: 0x003D1652 File Offset: 0x003CF852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsComboParamUpdateNotify);
		}

		// Token: 0x0601A325 RID: 107301 RVA: 0x003D1660 File Offset: 0x003CF860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsComboParamUpdateNotify other)
		{
			return other != null && (other == this || (this.comboParamInfos_.Equals(other.comboParamInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A326 RID: 107302 RVA: 0x003D1694 File Offset: 0x003CF894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.comboParamInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A327 RID: 107303 RVA: 0x003D16C8 File Offset: 0x003CF8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A328 RID: 107304 RVA: 0x003D16D5 File Offset: 0x003CF8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A329 RID: 107305 RVA: 0x003D16DE File Offset: 0x003CF8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.comboParamInfos_.WriteTo(ref output, SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A32A RID: 107306 RVA: 0x003D1708 File Offset: 0x003CF908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.comboParamInfos_.CalculateSize(SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A32B RID: 107307 RVA: 0x003D1741 File Offset: 0x003CF941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsComboParamUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.comboParamInfos_.Add(other.comboParamInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A32C RID: 107308 RVA: 0x003D176F File Offset: 0x003CF96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A32D RID: 107309 RVA: 0x003D1778 File Offset: 0x003CF978
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
					this.comboParamInfos_.AddEntriesFrom(ref input, SurvivorsComboParamUpdateNotify._repeated_comboParamInfos_codec);
				}
			}
		}

		// Token: 0x04009A17 RID: 39447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A18 RID: 39448
		public const int ComboParamInfosFieldNumber = 2;

		// Token: 0x04009A19 RID: 39449
		private static readonly FieldCodec<ComboParamInfo> _repeated_comboParamInfos_codec = FieldCodec.ForMessage<ComboParamInfo>(18U, ComboParamInfo.Parser);

		// Token: 0x04009A1A RID: 39450
		private readonly RepeatedField<ComboParamInfo> comboParamInfos_ = new RepeatedField<ComboParamInfo>();
	}
}
