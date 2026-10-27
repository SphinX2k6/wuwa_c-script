using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E7 RID: 1767
	[NetMessage(EMessageId.GiantStableValueActivityResponse)]
	public sealed class GiantStableValueActivityResponse : IMessage<GiantStableValueActivityResponse>, IMessage, IEquatable<GiantStableValueActivityResponse>, IDeepCloneable<GiantStableValueActivityResponse>, IBufferMessage
	{
		// Token: 0x0600A130 RID: 41264 RVA: 0x00186249 File Offset: 0x00184449
		[NullableContext(1)]
		public static GiantStableValueActivityResponse Create()
		{
			return new GiantStableValueActivityResponse();
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600A131 RID: 41265 RVA: 0x00186250 File Offset: 0x00184450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x00186253 File Offset: 0x00184453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantStableValueActivityResponse.Descriptor;
			}
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x0018625A File Offset: 0x0018445A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse()
		{
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x0018626D File Offset: 0x0018446D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse(GiantStableValueActivityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gotRewardIds_ = other.gotRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x001862A3 File Offset: 0x001844A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse Clone()
		{
			return new GiantStableValueActivityResponse(this);
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x001862AB File Offset: 0x001844AB
		// (set) Token: 0x0600A137 RID: 41271 RVA: 0x001862B3 File Offset: 0x001844B3
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

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600A138 RID: 41272 RVA: 0x001862BC File Offset: 0x001844BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GotRewardIds
		{
			get
			{
				return this.gotRewardIds_;
			}
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x001862C4 File Offset: 0x001844C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantStableValueActivityResponse);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x001862D4 File Offset: 0x001844D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantStableValueActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gotRewardIds_.Equals(other.gotRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x00186324 File Offset: 0x00184524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.gotRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x00186377 File Offset: 0x00184577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x00186384 File Offset: 0x00184584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x00186390 File Offset: 0x00184590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.gotRewardIds_.WriteTo(ref output, GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x001863E0 File Offset: 0x001845E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.gotRewardIds_.CalculateSize(GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x00186434 File Offset: 0x00184634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantStableValueActivityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.gotRewardIds_.Add(other.gotRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x00186481 File Offset: 0x00184681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x0018648C File Offset: 0x0018468C
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
				if (num != 72U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gotRewardIds_.AddEntriesFrom(ref input, GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004AE6 RID: 19174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE7 RID: 19175
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004AE8 RID: 19176
		private ErrorCode errorCode_;

		// Token: 0x04004AE9 RID: 19177
		public const int GotRewardIdsFieldNumber = 14;

		// Token: 0x04004AEA RID: 19178
		private static readonly FieldCodec<int> _repeated_gotRewardIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04004AEB RID: 19179
		private readonly RepeatedField<int> gotRewardIds_ = new RepeatedField<int>();
	}
}
