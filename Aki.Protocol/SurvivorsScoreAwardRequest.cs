using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E4 RID: 4836
	[NetMessage(EMessageId.SurvivorsScoreAwardRequest)]
	public sealed class SurvivorsScoreAwardRequest : IMessage<SurvivorsScoreAwardRequest>, IMessage, IEquatable<SurvivorsScoreAwardRequest>, IDeepCloneable<SurvivorsScoreAwardRequest>, IBufferMessage
	{
		// Token: 0x06019B88 RID: 105352 RVA: 0x003BD116 File Offset: 0x003BB316
		[NullableContext(1)]
		public static SurvivorsScoreAwardRequest Create()
		{
			return new SurvivorsScoreAwardRequest();
		}

		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x06019B89 RID: 105353 RVA: 0x003BD11D File Offset: 0x003BB31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x06019B8A RID: 105354 RVA: 0x003BD120 File Offset: 0x003BB320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsScoreAwardRequest.Descriptor;
			}
		}

		// Token: 0x06019B8B RID: 105355 RVA: 0x003BD127 File Offset: 0x003BB327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest()
		{
		}

		// Token: 0x06019B8C RID: 105356 RVA: 0x003BD13A File Offset: 0x003BB33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest(SurvivorsScoreAwardRequest other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B8D RID: 105357 RVA: 0x003BD164 File Offset: 0x003BB364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsScoreAwardRequest Clone()
		{
			return new SurvivorsScoreAwardRequest(this);
		}

		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x06019B8E RID: 105358 RVA: 0x003BD16C File Offset: 0x003BB36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x06019B8F RID: 105359 RVA: 0x003BD174 File Offset: 0x003BB374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsScoreAwardRequest);
		}

		// Token: 0x06019B90 RID: 105360 RVA: 0x003BD182 File Offset: 0x003BB382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsScoreAwardRequest other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B91 RID: 105361 RVA: 0x003BD1B8 File Offset: 0x003BB3B8
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

		// Token: 0x06019B92 RID: 105362 RVA: 0x003BD1EC File Offset: 0x003BB3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B93 RID: 105363 RVA: 0x003BD1F9 File Offset: 0x003BB3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B94 RID: 105364 RVA: 0x003BD202 File Offset: 0x003BB402
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

		// Token: 0x06019B95 RID: 105365 RVA: 0x003BD22C File Offset: 0x003BB42C
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

		// Token: 0x06019B96 RID: 105366 RVA: 0x003BD265 File Offset: 0x003BB465
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

		// Token: 0x06019B97 RID: 105367 RVA: 0x003BD293 File Offset: 0x003BB493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B98 RID: 105368 RVA: 0x003BD29C File Offset: 0x003BB49C
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, SurvivorsScoreAwardRequest._repeated_configs_codec);
				}
			}
		}

		// Token: 0x040096AE RID: 38574
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096AF RID: 38575
		public const int ConfigsFieldNumber = 4;

		// Token: 0x040096B0 RID: 38576
		private static readonly FieldCodec<int> _repeated_configs_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040096B1 RID: 38577
		private readonly RepeatedField<int> configs_ = new RepeatedField<int>();
	}
}
