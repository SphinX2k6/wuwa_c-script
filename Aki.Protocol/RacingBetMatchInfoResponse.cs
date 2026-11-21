using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2F RID: 3631
	[NetMessage(EMessageId.RacingBetMatchInfoResponse)]
	public sealed class RacingBetMatchInfoResponse : IMessage<RacingBetMatchInfoResponse>, IMessage, IEquatable<RacingBetMatchInfoResponse>, IDeepCloneable<RacingBetMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06013857 RID: 79959 RVA: 0x002D6CE8 File Offset: 0x002D4EE8
		[NullableContext(1)]
		public static RacingBetMatchInfoResponse Create()
		{
			return new RacingBetMatchInfoResponse();
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06013858 RID: 79960 RVA: 0x002D6CEF File Offset: 0x002D4EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x06013859 RID: 79961 RVA: 0x002D6CF2 File Offset: 0x002D4EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601385A RID: 79962 RVA: 0x002D6CF9 File Offset: 0x002D4EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse()
		{
		}

		// Token: 0x0601385B RID: 79963 RVA: 0x002D6D0C File Offset: 0x002D4F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse(RacingBetMatchInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601385C RID: 79964 RVA: 0x002D6D42 File Offset: 0x002D4F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoResponse Clone()
		{
			return new RacingBetMatchInfoResponse(this);
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0601385D RID: 79965 RVA: 0x002D6D4A File Offset: 0x002D4F4A
		// (set) Token: 0x0601385E RID: 79966 RVA: 0x002D6D52 File Offset: 0x002D4F52
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

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0601385F RID: 79967 RVA: 0x002D6D5B File Offset: 0x002D4F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x06013860 RID: 79968 RVA: 0x002D6D63 File Offset: 0x002D4F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchInfoResponse);
		}

		// Token: 0x06013861 RID: 79969 RVA: 0x002D6D74 File Offset: 0x002D4F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.dangoInfo_.Equals(other.dangoInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013862 RID: 79970 RVA: 0x002D6DC4 File Offset: 0x002D4FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013863 RID: 79971 RVA: 0x002D6E17 File Offset: 0x002D5017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013864 RID: 79972 RVA: 0x002D6E24 File Offset: 0x002D5024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013865 RID: 79973 RVA: 0x002D6E30 File Offset: 0x002D5030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
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

		// Token: 0x06013866 RID: 79974 RVA: 0x002D6E80 File Offset: 0x002D5080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013867 RID: 79975 RVA: 0x002D6ED4 File Offset: 0x002D50D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013868 RID: 79976 RVA: 0x002D6F21 File Offset: 0x002D5121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013869 RID: 79977 RVA: 0x002D6F2C File Offset: 0x002D512C
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
				if (num != 82U)
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
					this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchInfoResponse._repeated_dangoInfo_codec);
				}
			}
		}

		// Token: 0x040077F8 RID: 30712
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077F9 RID: 30713
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040077FA RID: 30714
		private ErrorCode errorCode_;

		// Token: 0x040077FB RID: 30715
		public const int DangoInfoFieldNumber = 10;

		// Token: 0x040077FC RID: 30716
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(82U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077FD RID: 30717
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();
	}
}
