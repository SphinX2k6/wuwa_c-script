using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172F RID: 5935
	public sealed class AiInformation : IMessage<AiInformation>, IMessage, IEquatable<AiInformation>, IDeepCloneable<AiInformation>, IBufferMessage
	{
		// Token: 0x0601DCA0 RID: 122016 RVA: 0x0045E339 File Offset: 0x0045C539
		[NullableContext(1)]
		public static AiInformation Create()
		{
			return new AiInformation();
		}

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x0601DCA1 RID: 122017 RVA: 0x0045E340 File Offset: 0x0045C540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x0601DCA2 RID: 122018 RVA: 0x0045E343 File Offset: 0x0045C543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformation.Descriptor;
			}
		}

		// Token: 0x0601DCA3 RID: 122019 RVA: 0x0045E34A File Offset: 0x0045C54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation()
		{
		}

		// Token: 0x0601DCA4 RID: 122020 RVA: 0x0045E374 File Offset: 0x0045C574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation(AiInformation other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this.hateList_ = other.hateList_.Clone();
			this.aiBlackboardCd_ = other.aiBlackboardCd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DCA5 RID: 122021 RVA: 0x0045E3CB File Offset: 0x0045C5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation Clone()
		{
			return new AiInformation(this);
		}

		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x0601DCA6 RID: 122022 RVA: 0x0045E3D3 File Offset: 0x0045C5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x0601DCA7 RID: 122023 RVA: 0x0045E3DB File Offset: 0x0045C5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x0601DCA8 RID: 122024 RVA: 0x0045E3E3 File Offset: 0x0045C5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCd
		{
			get
			{
				return this.aiBlackboardCd_;
			}
		}

		// Token: 0x0601DCA9 RID: 122025 RVA: 0x0045E3EB File Offset: 0x0045C5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformation);
		}

		// Token: 0x0601DCAA RID: 122026 RVA: 0x0045E3FC File Offset: 0x0045C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformation other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && this.hateList_.Equals(other.hateList_) && this.aiBlackboardCd_.Equals(other.aiBlackboardCd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DCAB RID: 122027 RVA: 0x0045E464 File Offset: 0x0045C664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboards_.GetHashCode();
			num ^= this.hateList_.GetHashCode();
			num ^= this.aiBlackboardCd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DCAC RID: 122028 RVA: 0x0045E4B4 File Offset: 0x0045C6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DCAD RID: 122029 RVA: 0x0045E4C1 File Offset: 0x0045C6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DCAE RID: 122030 RVA: 0x0045E4CC File Offset: 0x0045C6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboards_.WriteTo(ref output, AiInformation._repeated_aiBlackboards_codec);
			this.hateList_.WriteTo(ref output, AiInformation._repeated_hateList_codec);
			this.aiBlackboardCd_.WriteTo(ref output, AiInformation._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DCAF RID: 122031 RVA: 0x0045E520 File Offset: 0x0045C720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboards_.CalculateSize(AiInformation._repeated_aiBlackboards_codec);
			num += this.hateList_.CalculateSize(AiInformation._repeated_hateList_codec);
			num += this.aiBlackboardCd_.CalculateSize(AiInformation._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DCB0 RID: 122032 RVA: 0x0045E580 File Offset: 0x0045C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformation other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboards_.Add(other.aiBlackboards_);
			this.hateList_.Add(other.hateList_);
			this.aiBlackboardCd_.Add(other.aiBlackboardCd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DCB1 RID: 122033 RVA: 0x0045E5DB File Offset: 0x0045C7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DCB2 RID: 122034 RVA: 0x0045E5E4 File Offset: 0x0045C7E4
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.aiBlackboardCd_.AddEntriesFrom(ref input, AiInformation._repeated_aiBlackboardCd_codec);
						}
					}
					else
					{
						this.hateList_.AddEntriesFrom(ref input, AiInformation._repeated_hateList_codec);
					}
				}
				else
				{
					this.aiBlackboards_.AddEntriesFrom(ref input, AiInformation._repeated_aiBlackboards_codec);
				}
			}
		}

		// Token: 0x0400C97E RID: 51582
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C97F RID: 51583
		public const int AiBlackboardsFieldNumber = 1;

		// Token: 0x0400C980 RID: 51584
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(10U, BlackboardParam.Parser);

		// Token: 0x0400C981 RID: 51585
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();

		// Token: 0x0400C982 RID: 51586
		public const int HateListFieldNumber = 2;

		// Token: 0x0400C983 RID: 51587
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(18U, AiHateEntity.Parser);

		// Token: 0x0400C984 RID: 51588
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();

		// Token: 0x0400C985 RID: 51589
		public const int AiBlackboardCdFieldNumber = 3;

		// Token: 0x0400C986 RID: 51590
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCd_codec = FieldCodec.ForMessage<Int2Long>(26U, Int2Long.Parser);

		// Token: 0x0400C987 RID: 51591
		private readonly RepeatedField<Int2Long> aiBlackboardCd_ = new RepeatedField<Int2Long>();
	}
}
