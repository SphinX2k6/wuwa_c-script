using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000054 RID: 84
	[NetMessage(EMessageId.AccessPathConfigResponse)]
	public sealed class AccessPathConfigResponse : IMessage<AccessPathConfigResponse>, IMessage, IEquatable<AccessPathConfigResponse>, IDeepCloneable<AccessPathConfigResponse>, IBufferMessage
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x00038472 File Offset: 0x00036672
		[NullableContext(1)]
		public static AccessPathConfigResponse Create()
		{
			return new AccessPathConfigResponse();
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00038479 File Offset: 0x00036679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x0003847C File Offset: 0x0003667C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfigResponse.Descriptor;
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00038483 File Offset: 0x00036683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse()
		{
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00038496 File Offset: 0x00036696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse(AccessPathConfigResponse other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000384C0 File Offset: 0x000366C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse Clone()
		{
			return new AccessPathConfigResponse(this);
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x000384C8 File Offset: 0x000366C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessPathConfig> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000384D0 File Offset: 0x000366D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfigResponse);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000384DE File Offset: 0x000366DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfigResponse other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00038514 File Offset: 0x00036714
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

		// Token: 0x0600152F RID: 5423 RVA: 0x00038548 File Offset: 0x00036748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00038555 File Offset: 0x00036755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0003855E File Offset: 0x0003675E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configs_.WriteTo(ref output, AccessPathConfigResponse._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00038588 File Offset: 0x00036788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configs_.CalculateSize(AccessPathConfigResponse._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000385C1 File Offset: 0x000367C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPathConfigResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.configs_.Add(other.configs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000385EF File Offset: 0x000367EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000385F8 File Offset: 0x000367F8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, AccessPathConfigResponse._repeated_configs_codec);
				}
			}
		}

		// Token: 0x0400208C RID: 8332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400208D RID: 8333
		public const int ConfigsFieldNumber = 5;

		// Token: 0x0400208E RID: 8334
		private static readonly FieldCodec<AccessPathConfig> _repeated_configs_codec = FieldCodec.ForMessage<AccessPathConfig>(42U, AccessPathConfig.Parser);

		// Token: 0x0400208F RID: 8335
		private readonly RepeatedField<AccessPathConfig> configs_ = new RepeatedField<AccessPathConfig>();
	}
}
