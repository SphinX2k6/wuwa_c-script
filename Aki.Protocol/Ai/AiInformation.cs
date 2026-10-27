using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B3 RID: 5811
	public sealed class AiInformation : IMessage<AiInformation>, IMessage, IEquatable<AiInformation>, IDeepCloneable<AiInformation>, IBufferMessage
	{
		// Token: 0x0601D1D1 RID: 119249 RVA: 0x004425F9 File Offset: 0x004407F9
		[NullableContext(1)]
		public static AiInformation Create()
		{
			return new AiInformation();
		}

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x0601D1D2 RID: 119250 RVA: 0x00442600 File Offset: 0x00440800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x0601D1D3 RID: 119251 RVA: 0x00442603 File Offset: 0x00440803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformation.Descriptor;
			}
		}

		// Token: 0x0601D1D4 RID: 119252 RVA: 0x0044260A File Offset: 0x0044080A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation()
		{
		}

		// Token: 0x0601D1D5 RID: 119253 RVA: 0x00442634 File Offset: 0x00440834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation(AiInformation other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this.hateList_ = other.hateList_.Clone();
			this.aiBlackboardCd_ = other.aiBlackboardCd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1D6 RID: 119254 RVA: 0x0044268B File Offset: 0x0044088B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation Clone()
		{
			return new AiInformation(this);
		}

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x0601D1D7 RID: 119255 RVA: 0x00442693 File Offset: 0x00440893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x0601D1D8 RID: 119256 RVA: 0x0044269B File Offset: 0x0044089B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x0601D1D9 RID: 119257 RVA: 0x004426A3 File Offset: 0x004408A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCd
		{
			get
			{
				return this.aiBlackboardCd_;
			}
		}

		// Token: 0x0601D1DA RID: 119258 RVA: 0x004426AB File Offset: 0x004408AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformation);
		}

		// Token: 0x0601D1DB RID: 119259 RVA: 0x004426BC File Offset: 0x004408BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformation other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && this.hateList_.Equals(other.hateList_) && this.aiBlackboardCd_.Equals(other.aiBlackboardCd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1DC RID: 119260 RVA: 0x00442724 File Offset: 0x00440924
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

		// Token: 0x0601D1DD RID: 119261 RVA: 0x00442774 File Offset: 0x00440974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1DE RID: 119262 RVA: 0x00442781 File Offset: 0x00440981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1DF RID: 119263 RVA: 0x0044278C File Offset: 0x0044098C
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

		// Token: 0x0601D1E0 RID: 119264 RVA: 0x004427E0 File Offset: 0x004409E0
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

		// Token: 0x0601D1E1 RID: 119265 RVA: 0x00442840 File Offset: 0x00440A40
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

		// Token: 0x0601D1E2 RID: 119266 RVA: 0x0044289B File Offset: 0x00440A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1E3 RID: 119267 RVA: 0x004428A4 File Offset: 0x00440AA4
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

		// Token: 0x0400C44F RID: 50255
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C450 RID: 50256
		public const int AiBlackboardsFieldNumber = 1;

		// Token: 0x0400C451 RID: 50257
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(10U, BlackboardParam.Parser);

		// Token: 0x0400C452 RID: 50258
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();

		// Token: 0x0400C453 RID: 50259
		public const int HateListFieldNumber = 2;

		// Token: 0x0400C454 RID: 50260
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(18U, AiHateEntity.Parser);

		// Token: 0x0400C455 RID: 50261
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();

		// Token: 0x0400C456 RID: 50262
		public const int AiBlackboardCdFieldNumber = 3;

		// Token: 0x0400C457 RID: 50263
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCd_codec = FieldCodec.ForMessage<Int2Long>(26U, Int2Long.Parser);

		// Token: 0x0400C458 RID: 50264
		private readonly RepeatedField<Int2Long> aiBlackboardCd_ = new RepeatedField<Int2Long>();
	}
}
