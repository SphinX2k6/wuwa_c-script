using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001427 RID: 5159
	[NetMessage(EMessageId.TowerDefenceSelfPassResponse)]
	public sealed class TowerDefenceSelfPassResponse : IMessage<TowerDefenceSelfPassResponse>, IMessage, IEquatable<TowerDefenceSelfPassResponse>, IDeepCloneable<TowerDefenceSelfPassResponse>, IBufferMessage
	{
		// Token: 0x0601B6B5 RID: 112309 RVA: 0x003FC9BD File Offset: 0x003FABBD
		[NullableContext(1)]
		public static TowerDefenceSelfPassResponse Create()
		{
			return new TowerDefenceSelfPassResponse();
		}

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x0601B6B6 RID: 112310 RVA: 0x003FC9C4 File Offset: 0x003FABC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x0601B6B7 RID: 112311 RVA: 0x003FC9C7 File Offset: 0x003FABC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x0601B6B8 RID: 112312 RVA: 0x003FC9CE File Offset: 0x003FABCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse()
		{
		}

		// Token: 0x0601B6B9 RID: 112313 RVA: 0x003FC9E1 File Offset: 0x003FABE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse(TowerDefenceSelfPassResponse other) : this()
		{
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6BA RID: 112314 RVA: 0x003FCA0B File Offset: 0x003FAC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse Clone()
		{
			return new TowerDefenceSelfPassResponse(this);
		}

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x0601B6BB RID: 112315 RVA: 0x003FCA13 File Offset: 0x003FAC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x0601B6BC RID: 112316 RVA: 0x003FCA1B File Offset: 0x003FAC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceSelfPassResponse);
		}

		// Token: 0x0601B6BD RID: 112317 RVA: 0x003FCA29 File Offset: 0x003FAC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceSelfPassResponse other)
		{
			return other != null && (other == this || (this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6BE RID: 112318 RVA: 0x003FCA5C File Offset: 0x003FAC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selfPassData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B6BF RID: 112319 RVA: 0x003FCA90 File Offset: 0x003FAC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6C0 RID: 112320 RVA: 0x003FCA9D File Offset: 0x003FAC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6C1 RID: 112321 RVA: 0x003FCAA6 File Offset: 0x003FACA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selfPassData_.WriteTo(ref output, TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6C2 RID: 112322 RVA: 0x003FCAD0 File Offset: 0x003FACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selfPassData_.CalculateSize(TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6C3 RID: 112323 RVA: 0x003FCB09 File Offset: 0x003FAD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceSelfPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.selfPassData_.Add(other.selfPassData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6C4 RID: 112324 RVA: 0x003FCB37 File Offset: 0x003FAD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6C5 RID: 112325 RVA: 0x003FCB40 File Offset: 0x003FAD40
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.selfPassData_.AddEntriesFrom(ref input, TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
				}
			}
		}

		// Token: 0x04009FA5 RID: 40869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FA6 RID: 40870
		public const int SelfPassDataFieldNumber = 15;

		// Token: 0x04009FA7 RID: 40871
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(122U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009FA8 RID: 40872
		private readonly RepeatedField<OneTowerDefencePassInfo> selfPassData_ = new RepeatedField<OneTowerDefencePassInfo>();
	}
}
