using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000923 RID: 2339
	[NetMessage(EMessageId.LivenessTakeResponse)]
	public sealed class LivenessTakeResponse : IMessage<LivenessTakeResponse>, IMessage, IEquatable<LivenessTakeResponse>, IDeepCloneable<LivenessTakeResponse>, IBufferMessage
	{
		// Token: 0x0600CE8E RID: 52878 RVA: 0x001E6F45 File Offset: 0x001E5145
		[NullableContext(1)]
		public static LivenessTakeResponse Create()
		{
			return new LivenessTakeResponse();
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600CE8F RID: 52879 RVA: 0x001E6F4C File Offset: 0x001E514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600CE90 RID: 52880 RVA: 0x001E6F4F File Offset: 0x001E514F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTakeResponse.Descriptor;
			}
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x001E6F56 File Offset: 0x001E5156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse()
		{
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x001E6F69 File Offset: 0x001E5169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse(LivenessTakeResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x001E6F9F File Offset: 0x001E519F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse Clone()
		{
			return new LivenessTakeResponse(this);
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0600CE94 RID: 52884 RVA: 0x001E6FA7 File Offset: 0x001E51A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0600CE95 RID: 52885 RVA: 0x001E6FAF File Offset: 0x001E51AF
		// (set) Token: 0x0600CE96 RID: 52886 RVA: 0x001E6FB7 File Offset: 0x001E51B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x001E6FC0 File Offset: 0x001E51C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTakeResponse);
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x001E6FD0 File Offset: 0x001E51D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTakeResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x001E7020 File Offset: 0x001E5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x001E7073 File Offset: 0x001E5273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x001E7080 File Offset: 0x001E5280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x001E708C File Offset: 0x001E528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, LivenessTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE9D RID: 52893 RVA: 0x001E70DC File Offset: 0x001E52DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LivenessTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x001E7130 File Offset: 0x001E5330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x001E717D File Offset: 0x001E537D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x001E7188 File Offset: 0x001E5388
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
				if (num != 24U && num != 26U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, LivenessTakeResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400579A RID: 22426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400579B RID: 22427
		public const int IdsFieldNumber = 3;

		// Token: 0x0400579C RID: 22428
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400579D RID: 22429
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x0400579E RID: 22430
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400579F RID: 22431
		private ErrorCode errorCode_;
	}
}
