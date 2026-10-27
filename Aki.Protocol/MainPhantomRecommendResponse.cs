using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000982 RID: 2434
	[NetMessage(EMessageId.MainPhantomRecommendResponse)]
	public sealed class MainPhantomRecommendResponse : IMessage<MainPhantomRecommendResponse>, IMessage, IEquatable<MainPhantomRecommendResponse>, IDeepCloneable<MainPhantomRecommendResponse>, IBufferMessage
	{
		// Token: 0x0600D60E RID: 54798 RVA: 0x001F7BED File Offset: 0x001F5DED
		[NullableContext(1)]
		public static MainPhantomRecommendResponse Create()
		{
			return new MainPhantomRecommendResponse();
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600D60F RID: 54799 RVA: 0x001F7BF4 File Offset: 0x001F5DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0600D610 RID: 54800 RVA: 0x001F7BF7 File Offset: 0x001F5DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x001F7BFE File Offset: 0x001F5DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse()
		{
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x001F7C11 File Offset: 0x001F5E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse(MainPhantomRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.mainPhantomRecommendInfos_ = other.mainPhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x001F7C47 File Offset: 0x001F5E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse Clone()
		{
			return new MainPhantomRecommendResponse(this);
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x001F7C4F File Offset: 0x001F5E4F
		// (set) Token: 0x0600D615 RID: 54805 RVA: 0x001F7C57 File Offset: 0x001F5E57
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

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600D616 RID: 54806 RVA: 0x001F7C60 File Offset: 0x001F5E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainPhantomRecommendInfo> MainPhantomRecommendInfos
		{
			get
			{
				return this.mainPhantomRecommendInfos_;
			}
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x001F7C68 File Offset: 0x001F5E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendResponse);
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x001F7C78 File Offset: 0x001F5E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.mainPhantomRecommendInfos_.Equals(other.mainPhantomRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x001F7CC8 File Offset: 0x001F5EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.mainPhantomRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x001F7D1B File Offset: 0x001F5F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x001F7D28 File Offset: 0x001F5F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x001F7D34 File Offset: 0x001F5F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.mainPhantomRecommendInfos_.WriteTo(ref output, MainPhantomRecommendResponse._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x001F7D84 File Offset: 0x001F5F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.mainPhantomRecommendInfos_.CalculateSize(MainPhantomRecommendResponse._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x001F7DD8 File Offset: 0x001F5FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MainPhantomRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.mainPhantomRecommendInfos_.Add(other.mainPhantomRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x001F7E25 File Offset: 0x001F6025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x001F7E30 File Offset: 0x001F6030
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
				if (num != 40U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.mainPhantomRecommendInfos_.AddEntriesFrom(ref input, MainPhantomRecommendResponse._repeated_mainPhantomRecommendInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005984 RID: 22916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005985 RID: 22917
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005986 RID: 22918
		private ErrorCode errorCode_;

		// Token: 0x04005987 RID: 22919
		public const int MainPhantomRecommendInfosFieldNumber = 13;

		// Token: 0x04005988 RID: 22920
		private static readonly FieldCodec<MainPhantomRecommendInfo> _repeated_mainPhantomRecommendInfos_codec = FieldCodec.ForMessage<MainPhantomRecommendInfo>(106U, MainPhantomRecommendInfo.Parser);

		// Token: 0x04005989 RID: 22921
		private readonly RepeatedField<MainPhantomRecommendInfo> mainPhantomRecommendInfos_ = new RepeatedField<MainPhantomRecommendInfo>();
	}
}
