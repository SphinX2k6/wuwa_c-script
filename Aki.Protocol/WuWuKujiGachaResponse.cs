using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159A RID: 5530
	[NetMessage(EMessageId.WuWuKujiGachaResponse)]
	public sealed class WuWuKujiGachaResponse : IMessage<WuWuKujiGachaResponse>, IMessage, IEquatable<WuWuKujiGachaResponse>, IDeepCloneable<WuWuKujiGachaResponse>, IBufferMessage
	{
		// Token: 0x0601D46A RID: 119914 RVA: 0x0043D29D File Offset: 0x0043B49D
		[NullableContext(1)]
		public static WuWuKujiGachaResponse Create()
		{
			return new WuWuKujiGachaResponse();
		}

		// Token: 0x17006311 RID: 25361
		// (get) Token: 0x0601D46B RID: 119915 RVA: 0x0043D2A4 File Offset: 0x0043B4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006312 RID: 25362
		// (get) Token: 0x0601D46C RID: 119916 RVA: 0x0043D2A7 File Offset: 0x0043B4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiGachaResponse.Descriptor;
			}
		}

		// Token: 0x0601D46D RID: 119917 RVA: 0x0043D2AE File Offset: 0x0043B4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse()
		{
		}

		// Token: 0x0601D46E RID: 119918 RVA: 0x0043D2C4 File Offset: 0x0043B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse(WuWuKujiGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.trickType_ = other.trickType_;
			this.awards_ = other.awards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D46F RID: 119919 RVA: 0x0043D311 File Offset: 0x0043B511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse Clone()
		{
			return new WuWuKujiGachaResponse(this);
		}

		// Token: 0x17006313 RID: 25363
		// (get) Token: 0x0601D470 RID: 119920 RVA: 0x0043D319 File Offset: 0x0043B519
		// (set) Token: 0x0601D471 RID: 119921 RVA: 0x0043D321 File Offset: 0x0043B521
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

		// Token: 0x17006314 RID: 25364
		// (get) Token: 0x0601D472 RID: 119922 RVA: 0x0043D32A File Offset: 0x0043B52A
		// (set) Token: 0x0601D473 RID: 119923 RVA: 0x0043D332 File Offset: 0x0043B532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrickType
		{
			get
			{
				return this.trickType_;
			}
			set
			{
				this.trickType_ = value;
			}
		}

		// Token: 0x17006315 RID: 25365
		// (get) Token: 0x0601D474 RID: 119924 RVA: 0x0043D33B File Offset: 0x0043B53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleGachaAwardPb> Awards
		{
			get
			{
				return this.awards_;
			}
		}

		// Token: 0x0601D475 RID: 119925 RVA: 0x0043D343 File Offset: 0x0043B543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiGachaResponse);
		}

		// Token: 0x0601D476 RID: 119926 RVA: 0x0043D354 File Offset: 0x0043B554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TrickType == other.TrickType && this.awards_.Equals(other.awards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D477 RID: 119927 RVA: 0x0043D3B4 File Offset: 0x0043B5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TrickType != 0)
			{
				num ^= this.TrickType.GetHashCode();
			}
			num ^= this.awards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D478 RID: 119928 RVA: 0x0043D420 File Offset: 0x0043B620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x0043D42D File Offset: 0x0043B62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x0043D438 File Offset: 0x0043B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrickType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TrickType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.awards_.WriteTo(ref output, WuWuKujiGachaResponse._repeated_awards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x0043D4A4 File Offset: 0x0043B6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TrickType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrickType);
			}
			num += this.awards_.CalculateSize(WuWuKujiGachaResponse._repeated_awards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D47C RID: 119932 RVA: 0x0043D510 File Offset: 0x0043B710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuKujiGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TrickType != 0)
			{
				this.TrickType = other.TrickType;
			}
			this.awards_.Add(other.awards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D47D RID: 119933 RVA: 0x0043D571 File Offset: 0x0043B771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D47E RID: 119934 RVA: 0x0043D57C File Offset: 0x0043B77C
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
					if (num != 56U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.awards_.AddEntriesFrom(ref input, WuWuKujiGachaResponse._repeated_awards_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TrickType = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A7F0 RID: 42992
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7F1 RID: 42993
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400A7F2 RID: 42994
		private ErrorCode errorCode_;

		// Token: 0x0400A7F3 RID: 42995
		public const int TrickTypeFieldNumber = 3;

		// Token: 0x0400A7F4 RID: 42996
		private int trickType_;

		// Token: 0x0400A7F5 RID: 42997
		public const int AwardsFieldNumber = 13;

		// Token: 0x0400A7F6 RID: 42998
		private static readonly FieldCodec<SingleGachaAwardPb> _repeated_awards_codec = FieldCodec.ForMessage<SingleGachaAwardPb>(106U, SingleGachaAwardPb.Parser);

		// Token: 0x0400A7F7 RID: 42999
		private readonly RepeatedField<SingleGachaAwardPb> awards_ = new RepeatedField<SingleGachaAwardPb>();
	}
}
