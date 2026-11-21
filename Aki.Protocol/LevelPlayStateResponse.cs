using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FD RID: 2301
	[NetMessage(EMessageId.LevelPlayStateResponse)]
	public sealed class LevelPlayStateResponse : IMessage<LevelPlayStateResponse>, IMessage, IEquatable<LevelPlayStateResponse>, IDeepCloneable<LevelPlayStateResponse>, IBufferMessage
	{
		// Token: 0x0600CB8C RID: 52108 RVA: 0x001E0818 File Offset: 0x001DEA18
		[NullableContext(1)]
		public static LevelPlayStateResponse Create()
		{
			return new LevelPlayStateResponse();
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x001E081F File Offset: 0x001DEA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x001E0822 File Offset: 0x001DEA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateResponse.Descriptor;
			}
		}

		// Token: 0x0600CB8F RID: 52111 RVA: 0x001E0829 File Offset: 0x001DEA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse()
		{
		}

		// Token: 0x0600CB90 RID: 52112 RVA: 0x001E083C File Offset: 0x001DEA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse(LevelPlayStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelPlayStateDict_ = other.levelPlayStateDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB91 RID: 52113 RVA: 0x001E0872 File Offset: 0x001DEA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateResponse Clone()
		{
			return new LevelPlayStateResponse(this);
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600CB92 RID: 52114 RVA: 0x001E087A File Offset: 0x001DEA7A
		// (set) Token: 0x0600CB93 RID: 52115 RVA: 0x001E0882 File Offset: 0x001DEA82
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

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x001E088B File Offset: 0x001DEA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayStateMsg> LevelPlayStateDict
		{
			get
			{
				return this.levelPlayStateDict_;
			}
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x001E0893 File Offset: 0x001DEA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateResponse);
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x001E08A4 File Offset: 0x001DEAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelPlayStateDict.Equals(other.LevelPlayStateDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x001E08F4 File Offset: 0x001DEAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.LevelPlayStateDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x001E0947 File Offset: 0x001DEB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x001E0954 File Offset: 0x001DEB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x001E0960 File Offset: 0x001DEB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayStateDict_.WriteTo(ref output, LevelPlayStateResponse._map_levelPlayStateDict_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x001E09B0 File Offset: 0x001DEBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.levelPlayStateDict_.CalculateSize(LevelPlayStateResponse._map_levelPlayStateDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x001E0A04 File Offset: 0x001DEC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.levelPlayStateDict_.MergeFrom(other.levelPlayStateDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x001E0A51 File Offset: 0x001DEC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x001E0A5C File Offset: 0x001DEC5C
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
					if (num != 88U)
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
					this.levelPlayStateDict_.AddEntriesFrom(ref input, LevelPlayStateResponse._map_levelPlayStateDict_codec);
				}
			}
		}

		// Token: 0x040056C7 RID: 22215
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C8 RID: 22216
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040056C9 RID: 22217
		private ErrorCode errorCode_;

		// Token: 0x040056CA RID: 22218
		public const int LevelPlayStateDictFieldNumber = 5;

		// Token: 0x040056CB RID: 22219
		private static readonly MapField<int, LevelPlayStateMsg>.Codec _map_levelPlayStateDict_codec = new MapField<int, LevelPlayStateMsg>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayStateMsg>(18U, LevelPlayStateMsg.Parser), 42U);

		// Token: 0x040056CC RID: 22220
		private readonly MapField<int, LevelPlayStateMsg> levelPlayStateDict_ = new MapField<int, LevelPlayStateMsg>();
	}
}
