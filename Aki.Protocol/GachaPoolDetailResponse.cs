using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000683 RID: 1667
	[NetMessage(EMessageId.GachaPoolDetailResponse)]
	public sealed class GachaPoolDetailResponse : IMessage<GachaPoolDetailResponse>, IMessage, IEquatable<GachaPoolDetailResponse>, IDeepCloneable<GachaPoolDetailResponse>, IBufferMessage
	{
		// Token: 0x0600991F RID: 39199 RVA: 0x00171EB9 File Offset: 0x001700B9
		[NullableContext(1)]
		public static GachaPoolDetailResponse Create()
		{
			return new GachaPoolDetailResponse();
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x00171EC0 File Offset: 0x001700C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x00171EC3 File Offset: 0x001700C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetailResponse.Descriptor;
			}
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x00171ECA File Offset: 0x001700CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse()
		{
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x00171ED4 File Offset: 0x001700D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse(GachaPoolDetailResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.detail_ = ((other.detail_ != null) ? other.detail_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00171F20 File Offset: 0x00170120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailResponse Clone()
		{
			return new GachaPoolDetailResponse(this);
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06009925 RID: 39205 RVA: 0x00171F28 File Offset: 0x00170128
		// (set) Token: 0x06009926 RID: 39206 RVA: 0x00171F30 File Offset: 0x00170130
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00171F39 File Offset: 0x00170139
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x00171F41 File Offset: 0x00170141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail Detail
		{
			get
			{
				return this.detail_;
			}
			set
			{
				this.detail_ = value;
			}
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00171F4A File Offset: 0x0017014A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetailResponse);
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00171F58 File Offset: 0x00170158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Detail, other.Detail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00171FA8 File Offset: 0x001701A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.detail_ != null)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00172003 File Offset: 0x00170203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x00172010 File Offset: 0x00170210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x0017201C File Offset: 0x0017021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.detail_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Detail);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00172078 File Offset: 0x00170278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.detail_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Detail);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x001720D0 File Offset: 0x001702D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDetailResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.detail_ != null)
			{
				if (this.detail_ == null)
				{
					this.Detail = new GachaPoolDetail();
				}
				this.Detail.MergeFrom(other.Detail);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x00172138 File Offset: 0x00170338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x00172144 File Offset: 0x00170344
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
				if (num != 24U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.detail_ == null)
						{
							this.Detail = new GachaPoolDetail();
						}
						input.ReadMessage(this.Detail);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004906 RID: 18694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004907 RID: 18695
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004908 RID: 18696
		private ErrorCode errorCode_;

		// Token: 0x04004909 RID: 18697
		public const int DetailFieldNumber = 10;

		// Token: 0x0400490A RID: 18698
		private GachaPoolDetail detail_;
	}
}
