using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000971 RID: 2417
	[NetMessage(EMessageId.MainPhantomRecommendResponse)]
	public sealed class MainPhantomRecommendResponse : IMessage<MainPhantomRecommendResponse>, IMessage, IEquatable<MainPhantomRecommendResponse>, IDeepCloneable<MainPhantomRecommendResponse>, IBufferMessage
	{
		// Token: 0x0600D4F4 RID: 54516 RVA: 0x001F5A05 File Offset: 0x001F3C05
		[NullableContext(1)]
		public static MainPhantomRecommendResponse Create()
		{
			return new MainPhantomRecommendResponse();
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600D4F5 RID: 54517 RVA: 0x001F5A0C File Offset: 0x001F3C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x001F5A0F File Offset: 0x001F3C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x001F5A16 File Offset: 0x001F3C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse()
		{
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x001F5A29 File Offset: 0x001F3C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse(MainPhantomRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.mainPhantomRecommendInfos_ = other.mainPhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x001F5A5F File Offset: 0x001F3C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendResponse Clone()
		{
			return new MainPhantomRecommendResponse(this);
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x001F5A67 File Offset: 0x001F3C67
		// (set) Token: 0x0600D4FB RID: 54523 RVA: 0x001F5A6F File Offset: 0x001F3C6F
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

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600D4FC RID: 54524 RVA: 0x001F5A78 File Offset: 0x001F3C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainPhantomRecommendInfo> MainPhantomRecommendInfos
		{
			get
			{
				return this.mainPhantomRecommendInfos_;
			}
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x001F5A80 File Offset: 0x001F3C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendResponse);
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x001F5A90 File Offset: 0x001F3C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.mainPhantomRecommendInfos_.Equals(other.mainPhantomRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x001F5AE0 File Offset: 0x001F3CE0
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

		// Token: 0x0600D500 RID: 54528 RVA: 0x001F5B33 File Offset: 0x001F3D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x001F5B40 File Offset: 0x001F3D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x001F5B4C File Offset: 0x001F3D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.mainPhantomRecommendInfos_.WriteTo(ref output, MainPhantomRecommendResponse._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D503 RID: 54531 RVA: 0x001F5B9C File Offset: 0x001F3D9C
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

		// Token: 0x0600D504 RID: 54532 RVA: 0x001F5BF0 File Offset: 0x001F3DF0
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

		// Token: 0x0600D505 RID: 54533 RVA: 0x001F5C3D File Offset: 0x001F3E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D506 RID: 54534 RVA: 0x001F5C48 File Offset: 0x001F3E48
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
				if (num != 80U)
				{
					if (num != 98U)
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

		// Token: 0x0400598D RID: 22925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400598E RID: 22926
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400598F RID: 22927
		private ErrorCode errorCode_;

		// Token: 0x04005990 RID: 22928
		public const int MainPhantomRecommendInfosFieldNumber = 12;

		// Token: 0x04005991 RID: 22929
		private static readonly FieldCodec<MainPhantomRecommendInfo> _repeated_mainPhantomRecommendInfos_codec = FieldCodec.ForMessage<MainPhantomRecommendInfo>(98U, MainPhantomRecommendInfo.Parser);

		// Token: 0x04005992 RID: 22930
		private readonly RepeatedField<MainPhantomRecommendInfo> mainPhantomRecommendInfos_ = new RepeatedField<MainPhantomRecommendInfo>();
	}
}
