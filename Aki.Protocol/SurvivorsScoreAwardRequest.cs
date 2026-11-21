using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001353 RID: 4947
	[NetMessage(EMessageId.SurvivorsScoreAwardRequest)]
	public sealed class SurvivorsScoreAwardRequest : IMessage<SurvivorsScoreAwardRequest>, IMessage, IEquatable<SurvivorsScoreAwardRequest>, IDeepCloneable<SurvivorsScoreAwardRequest>, IBufferMessage
	{
		// Token: 0x0601A5BE RID: 107966 RVA: 0x003D7846 File Offset: 0x003D5A46
		[NullableContext(1)]
		public static SurvivorsScoreAwardRequest Create()
		{
			return new SurvivorsScoreAwardRequest();
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x0601A5BF RID: 107967 RVA: 0x003D784D File Offset: 0x003D5A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x0601A5C0 RID: 107968 RVA: 0x003D7850 File Offset: 0x003D5A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsScoreAwardRequest.Descriptor;
			}
		}

		// Token: 0x0601A5C1 RID: 107969 RVA: 0x003D7857 File Offset: 0x003D5A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest()
		{
		}

		// Token: 0x0601A5C2 RID: 107970 RVA: 0x003D786A File Offset: 0x003D5A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest(SurvivorsScoreAwardRequest other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5C3 RID: 107971 RVA: 0x003D7894 File Offset: 0x003D5A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest Clone()
		{
			return new SurvivorsScoreAwardRequest(this);
		}

		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x0601A5C4 RID: 107972 RVA: 0x003D789C File Offset: 0x003D5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x0601A5C5 RID: 107973 RVA: 0x003D78A4 File Offset: 0x003D5AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsScoreAwardRequest);
		}

		// Token: 0x0601A5C6 RID: 107974 RVA: 0x003D78B2 File Offset: 0x003D5AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsScoreAwardRequest other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5C7 RID: 107975 RVA: 0x003D78E8 File Offset: 0x003D5AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A5C8 RID: 107976 RVA: 0x003D791C File Offset: 0x003D5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5C9 RID: 107977 RVA: 0x003D7929 File Offset: 0x003D5B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5CA RID: 107978 RVA: 0x003D7932 File Offset: 0x003D5B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configs_.WriteTo(ref output, SurvivorsScoreAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5CB RID: 107979 RVA: 0x003D795C File Offset: 0x003D5B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configs_.CalculateSize(SurvivorsScoreAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A5CC RID: 107980 RVA: 0x003D7995 File Offset: 0x003D5B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsScoreAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.configs_.Add(other.configs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5CD RID: 107981 RVA: 0x003D79C3 File Offset: 0x003D5BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5CE RID: 107982 RVA: 0x003D79CC File Offset: 0x003D5BCC
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, SurvivorsScoreAwardRequest._repeated_configs_codec);
				}
			}
		}

		// Token: 0x04009AD8 RID: 39640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AD9 RID: 39641
		public const int ConfigsFieldNumber = 14;

		// Token: 0x04009ADA RID: 39642
		private static readonly FieldCodec<int> _repeated_configs_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009ADB RID: 39643
		private readonly RepeatedField<int> configs_ = new RepeatedField<int>();
	}
}
