using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001075 RID: 4213
	[NetMessage(EMessageId.RoleFavorListResponse)]
	public sealed class RoleFavorListResponse : IMessage<RoleFavorListResponse>, IMessage, IEquatable<RoleFavorListResponse>, IDeepCloneable<RoleFavorListResponse>, IBufferMessage
	{
		// Token: 0x0601682C RID: 92204 RVA: 0x00345BC6 File Offset: 0x00343DC6
		[NullableContext(1)]
		public static RoleFavorListResponse Create()
		{
			return new RoleFavorListResponse();
		}

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x0601682D RID: 92205 RVA: 0x00345BCD File Offset: 0x00343DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x0601682E RID: 92206 RVA: 0x00345BD0 File Offset: 0x00343DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListResponse.Descriptor;
			}
		}

		// Token: 0x0601682F RID: 92207 RVA: 0x00345BD7 File Offset: 0x00343DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse()
		{
		}

		// Token: 0x06016830 RID: 92208 RVA: 0x00345BEA File Offset: 0x00343DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse(RoleFavorListResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.favorList_ = other.favorList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016831 RID: 92209 RVA: 0x00345C20 File Offset: 0x00343E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse Clone()
		{
			return new RoleFavorListResponse(this);
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x06016832 RID: 92210 RVA: 0x00345C28 File Offset: 0x00343E28
		// (set) Token: 0x06016833 RID: 92211 RVA: 0x00345C30 File Offset: 0x00343E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x06016834 RID: 92212 RVA: 0x00345C39 File Offset: 0x00343E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFavor> FavorList
		{
			get
			{
				return this.favorList_;
			}
		}

		// Token: 0x06016835 RID: 92213 RVA: 0x00345C41 File Offset: 0x00343E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListResponse);
		}

		// Token: 0x06016836 RID: 92214 RVA: 0x00345C50 File Offset: 0x00343E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.favorList_.Equals(other.favorList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016837 RID: 92215 RVA: 0x00345CA0 File Offset: 0x00343EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.favorList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016838 RID: 92216 RVA: 0x00345CF3 File Offset: 0x00343EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016839 RID: 92217 RVA: 0x00345D00 File Offset: 0x00343F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601683A RID: 92218 RVA: 0x00345D0C File Offset: 0x00343F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrCode);
			}
			this.favorList_.WriteTo(ref output, RoleFavorListResponse._repeated_favorList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601683B RID: 92219 RVA: 0x00345D5C File Offset: 0x00343F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.favorList_.CalculateSize(RoleFavorListResponse._repeated_favorList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601683C RID: 92220 RVA: 0x00345DB0 File Offset: 0x00343FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.favorList_.Add(other.favorList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601683D RID: 92221 RVA: 0x00345DFD File Offset: 0x00343FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601683E RID: 92222 RVA: 0x00345E08 File Offset: 0x00344008
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.favorList_.AddEntriesFrom(ref input, RoleFavorListResponse._repeated_favorList_codec);
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400869C RID: 34460
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400869D RID: 34461
		public const int ErrCodeFieldNumber = 3;

		// Token: 0x0400869E RID: 34462
		private ErrorCode errCode_;

		// Token: 0x0400869F RID: 34463
		public const int FavorListFieldNumber = 12;

		// Token: 0x040086A0 RID: 34464
		private static readonly FieldCodec<RoleFavor> _repeated_favorList_codec = FieldCodec.ForMessage<RoleFavor>(98U, RoleFavor.Parser);

		// Token: 0x040086A1 RID: 34465
		private readonly RepeatedField<RoleFavor> favorList_ = new RepeatedField<RoleFavor>();
	}
}
