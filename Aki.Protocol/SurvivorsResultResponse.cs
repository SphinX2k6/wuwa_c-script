using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DE RID: 4830
	[NetMessage(EMessageId.SurvivorsResultResponse)]
	public sealed class SurvivorsResultResponse : IMessage<SurvivorsResultResponse>, IMessage, IEquatable<SurvivorsResultResponse>, IDeepCloneable<SurvivorsResultResponse>, IBufferMessage
	{
		// Token: 0x06019B17 RID: 105239 RVA: 0x003BC2EA File Offset: 0x003BA4EA
		[NullableContext(1)]
		public static SurvivorsResultResponse Create()
		{
			return new SurvivorsResultResponse();
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x06019B18 RID: 105240 RVA: 0x003BC2F1 File Offset: 0x003BA4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x06019B19 RID: 105241 RVA: 0x003BC2F4 File Offset: 0x003BA4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsResultResponse.Descriptor;
			}
		}

		// Token: 0x06019B1A RID: 105242 RVA: 0x003BC2FB File Offset: 0x003BA4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse()
		{
		}

		// Token: 0x06019B1B RID: 105243 RVA: 0x003BC304 File Offset: 0x003BA504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse(SurvivorsResultResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.resultView_ = ((other.resultView_ != null) ? other.resultView_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B1C RID: 105244 RVA: 0x003BC350 File Offset: 0x003BA550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse Clone()
		{
			return new SurvivorsResultResponse(this);
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x06019B1D RID: 105245 RVA: 0x003BC358 File Offset: 0x003BA558
		// (set) Token: 0x06019B1E RID: 105246 RVA: 0x003BC360 File Offset: 0x003BA560
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

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x06019B1F RID: 105247 RVA: 0x003BC369 File Offset: 0x003BA569
		// (set) Token: 0x06019B20 RID: 105248 RVA: 0x003BC371 File Offset: 0x003BA571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResultView ResultView
		{
			get
			{
				return this.resultView_;
			}
			set
			{
				this.resultView_ = value;
			}
		}

		// Token: 0x06019B21 RID: 105249 RVA: 0x003BC37A File Offset: 0x003BA57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsResultResponse);
		}

		// Token: 0x06019B22 RID: 105250 RVA: 0x003BC388 File Offset: 0x003BA588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsResultResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.ResultView, other.ResultView) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B23 RID: 105251 RVA: 0x003BC3D8 File Offset: 0x003BA5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.resultView_ != null)
			{
				num ^= this.ResultView.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B24 RID: 105252 RVA: 0x003BC433 File Offset: 0x003BA633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B25 RID: 105253 RVA: 0x003BC440 File Offset: 0x003BA640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B26 RID: 105254 RVA: 0x003BC44C File Offset: 0x003BA64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultView_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ResultView);
			}
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

		// Token: 0x06019B27 RID: 105255 RVA: 0x003BC4A8 File Offset: 0x003BA6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.resultView_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultView);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B28 RID: 105256 RVA: 0x003BC500 File Offset: 0x003BA700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.resultView_ != null)
			{
				if (this.resultView_ == null)
				{
					this.ResultView = new ResultView();
				}
				this.ResultView.MergeFrom(other.ResultView);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B29 RID: 105257 RVA: 0x003BC568 File Offset: 0x003BA768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B2A RID: 105258 RVA: 0x003BC574 File Offset: 0x003BA774
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
					if (this.resultView_ == null)
					{
						this.ResultView = new ResultView();
					}
					input.ReadMessage(this.ResultView);
				}
			}
		}

		// Token: 0x04009694 RID: 38548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009695 RID: 38549
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04009696 RID: 38550
		private ErrorCode errCode_;

		// Token: 0x04009697 RID: 38551
		public const int ResultViewFieldNumber = 10;

		// Token: 0x04009698 RID: 38552
		private ResultView resultView_;
	}
}
