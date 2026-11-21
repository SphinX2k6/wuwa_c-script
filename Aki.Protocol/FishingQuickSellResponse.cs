using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000560 RID: 1376
	[NetMessage(EMessageId.FishingQuickSellResponse)]
	public sealed class FishingQuickSellResponse : IMessage<FishingQuickSellResponse>, IMessage, IEquatable<FishingQuickSellResponse>, IDeepCloneable<FishingQuickSellResponse>, IBufferMessage
	{
		// Token: 0x06008090 RID: 32912 RVA: 0x001370CE File Offset: 0x001352CE
		[NullableContext(1)]
		public static FishingQuickSellResponse Create()
		{
			return new FishingQuickSellResponse();
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x001370D5 File Offset: 0x001352D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x001370D8 File Offset: 0x001352D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellResponse.Descriptor;
			}
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x001370DF File Offset: 0x001352DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse()
		{
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x001370E7 File Offset: 0x001352E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse(FishingQuickSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x0013710C File Offset: 0x0013530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellResponse Clone()
		{
			return new FishingQuickSellResponse(this);
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06008096 RID: 32918 RVA: 0x00137114 File Offset: 0x00135314
		// (set) Token: 0x06008097 RID: 32919 RVA: 0x0013711C File Offset: 0x0013531C
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

		// Token: 0x06008098 RID: 32920 RVA: 0x00137125 File Offset: 0x00135325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellResponse);
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x00137133 File Offset: 0x00135333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x00137164 File Offset: 0x00135364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600809B RID: 32923 RVA: 0x001371A9 File Offset: 0x001353A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x001371B6 File Offset: 0x001353B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x001371BF File Offset: 0x001353BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x001371F4 File Offset: 0x001353F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600809F RID: 32927 RVA: 0x00137232 File Offset: 0x00135432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00137263 File Offset: 0x00135463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0013726C File Offset: 0x0013546C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400411B RID: 16667
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400411C RID: 16668
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400411D RID: 16669
		private ErrorCode errorCode_;
	}
}
