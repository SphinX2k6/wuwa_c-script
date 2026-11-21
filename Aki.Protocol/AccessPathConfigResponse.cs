using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000055 RID: 85
	[NetMessage(EMessageId.AccessPathConfigResponse)]
	public sealed class AccessPathConfigResponse : IMessage<AccessPathConfigResponse>, IMessage, IEquatable<AccessPathConfigResponse>, IDeepCloneable<AccessPathConfigResponse>, IBufferMessage
	{
		// Token: 0x06001568 RID: 5480 RVA: 0x00038E16 File Offset: 0x00037016
		[NullableContext(1)]
		public static AccessPathConfigResponse Create()
		{
			return new AccessPathConfigResponse();
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00038E1D File Offset: 0x0003701D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00038E20 File Offset: 0x00037020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfigResponse.Descriptor;
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00038E27 File Offset: 0x00037027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse()
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00038E3A File Offset: 0x0003703A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse(AccessPathConfigResponse other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00038E64 File Offset: 0x00037064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfigResponse Clone()
		{
			return new AccessPathConfigResponse(this);
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00038E6C File Offset: 0x0003706C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessPathConfig> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00038E74 File Offset: 0x00037074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfigResponse);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00038E82 File Offset: 0x00037082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfigResponse other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00038EB8 File Offset: 0x000370B8
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

		// Token: 0x06001572 RID: 5490 RVA: 0x00038EEC File Offset: 0x000370EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00038EF9 File Offset: 0x000370F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00038F02 File Offset: 0x00037102
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

		// Token: 0x06001575 RID: 5493 RVA: 0x00038F2C File Offset: 0x0003712C
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

		// Token: 0x06001576 RID: 5494 RVA: 0x00038F65 File Offset: 0x00037165
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

		// Token: 0x06001577 RID: 5495 RVA: 0x00038F93 File Offset: 0x00037193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00038F9C File Offset: 0x0003719C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, AccessPathConfigResponse._repeated_configs_codec);
				}
			}
		}

		// Token: 0x040020EB RID: 8427
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020EC RID: 8428
		public const int ConfigsFieldNumber = 4;

		// Token: 0x040020ED RID: 8429
		private static readonly FieldCodec<AccessPathConfig> _repeated_configs_codec = FieldCodec.ForMessage<AccessPathConfig>(34U, AccessPathConfig.Parser);

		// Token: 0x040020EE RID: 8430
		private readonly RepeatedField<AccessPathConfig> configs_ = new RepeatedField<AccessPathConfig>();
	}
}
