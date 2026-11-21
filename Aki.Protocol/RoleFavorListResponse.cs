using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001065 RID: 4197
	[NetMessage(EMessageId.RoleFavorListResponse)]
	public sealed class RoleFavorListResponse : IMessage<RoleFavorListResponse>, IMessage, IEquatable<RoleFavorListResponse>, IDeepCloneable<RoleFavorListResponse>, IBufferMessage
	{
		// Token: 0x06016747 RID: 91975 RVA: 0x003444F2 File Offset: 0x003426F2
		[NullableContext(1)]
		public static RoleFavorListResponse Create()
		{
			return new RoleFavorListResponse();
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x06016748 RID: 91976 RVA: 0x003444F9 File Offset: 0x003426F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x06016749 RID: 91977 RVA: 0x003444FC File Offset: 0x003426FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorListResponse.Descriptor;
			}
		}

		// Token: 0x0601674A RID: 91978 RVA: 0x00344503 File Offset: 0x00342703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse()
		{
		}

		// Token: 0x0601674B RID: 91979 RVA: 0x00344516 File Offset: 0x00342716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse(RoleFavorListResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.favorList_ = other.favorList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601674C RID: 91980 RVA: 0x0034454C File Offset: 0x0034274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorListResponse Clone()
		{
			return new RoleFavorListResponse(this);
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x0601674D RID: 91981 RVA: 0x00344554 File Offset: 0x00342754
		// (set) Token: 0x0601674E RID: 91982 RVA: 0x0034455C File Offset: 0x0034275C
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

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x0601674F RID: 91983 RVA: 0x00344565 File Offset: 0x00342765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFavor> FavorList
		{
			get
			{
				return this.favorList_;
			}
		}

		// Token: 0x06016750 RID: 91984 RVA: 0x0034456D File Offset: 0x0034276D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorListResponse);
		}

		// Token: 0x06016751 RID: 91985 RVA: 0x0034457C File Offset: 0x0034277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorListResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.favorList_.Equals(other.favorList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016752 RID: 91986 RVA: 0x003445CC File Offset: 0x003427CC
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

		// Token: 0x06016753 RID: 91987 RVA: 0x0034461F File Offset: 0x0034281F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016754 RID: 91988 RVA: 0x0034462C File Offset: 0x0034282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016755 RID: 91989 RVA: 0x00344638 File Offset: 0x00342838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.favorList_.WriteTo(ref output, RoleFavorListResponse._repeated_favorList_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016756 RID: 91990 RVA: 0x00344688 File Offset: 0x00342888
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

		// Token: 0x06016757 RID: 91991 RVA: 0x003446DC File Offset: 0x003428DC
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

		// Token: 0x06016758 RID: 91992 RVA: 0x00344729 File Offset: 0x00342929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016759 RID: 91993 RVA: 0x00344734 File Offset: 0x00342934
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.favorList_.AddEntriesFrom(ref input, RoleFavorListResponse._repeated_favorList_codec);
				}
			}
		}

		// Token: 0x040086C6 RID: 34502
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086C7 RID: 34503
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x040086C8 RID: 34504
		private ErrorCode errCode_;

		// Token: 0x040086C9 RID: 34505
		public const int FavorListFieldNumber = 2;

		// Token: 0x040086CA RID: 34506
		private static readonly FieldCodec<RoleFavor> _repeated_favorList_codec = FieldCodec.ForMessage<RoleFavor>(18U, RoleFavor.Parser);

		// Token: 0x040086CB RID: 34507
		private readonly RepeatedField<RoleFavor> favorList_ = new RepeatedField<RoleFavor>();
	}
}
