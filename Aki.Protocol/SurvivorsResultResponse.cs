using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134D RID: 4941
	[NetMessage(EMessageId.SurvivorsResultResponse)]
	public sealed class SurvivorsResultResponse : IMessage<SurvivorsResultResponse>, IMessage, IEquatable<SurvivorsResultResponse>, IDeepCloneable<SurvivorsResultResponse>, IBufferMessage
	{
		// Token: 0x0601A54D RID: 107853 RVA: 0x003D6A1A File Offset: 0x003D4C1A
		[NullableContext(1)]
		public static SurvivorsResultResponse Create()
		{
			return new SurvivorsResultResponse();
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x0601A54E RID: 107854 RVA: 0x003D6A21 File Offset: 0x003D4C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x0601A54F RID: 107855 RVA: 0x003D6A24 File Offset: 0x003D4C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsResultResponse.Descriptor;
			}
		}

		// Token: 0x0601A550 RID: 107856 RVA: 0x003D6A2B File Offset: 0x003D4C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse()
		{
		}

		// Token: 0x0601A551 RID: 107857 RVA: 0x003D6A34 File Offset: 0x003D4C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse(SurvivorsResultResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.resultView_ = ((other.resultView_ != null) ? other.resultView_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A552 RID: 107858 RVA: 0x003D6A80 File Offset: 0x003D4C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsResultResponse Clone()
		{
			return new SurvivorsResultResponse(this);
		}

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x0601A553 RID: 107859 RVA: 0x003D6A88 File Offset: 0x003D4C88
		// (set) Token: 0x0601A554 RID: 107860 RVA: 0x003D6A90 File Offset: 0x003D4C90
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

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x0601A555 RID: 107861 RVA: 0x003D6A99 File Offset: 0x003D4C99
		// (set) Token: 0x0601A556 RID: 107862 RVA: 0x003D6AA1 File Offset: 0x003D4CA1
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

		// Token: 0x0601A557 RID: 107863 RVA: 0x003D6AAA File Offset: 0x003D4CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsResultResponse);
		}

		// Token: 0x0601A558 RID: 107864 RVA: 0x003D6AB8 File Offset: 0x003D4CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsResultResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.ResultView, other.ResultView) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A559 RID: 107865 RVA: 0x003D6B08 File Offset: 0x003D4D08
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

		// Token: 0x0601A55A RID: 107866 RVA: 0x003D6B63 File Offset: 0x003D4D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A55B RID: 107867 RVA: 0x003D6B70 File Offset: 0x003D4D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A55C RID: 107868 RVA: 0x003D6B7C File Offset: 0x003D4D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.resultView_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ResultView);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A55D RID: 107869 RVA: 0x003D6BD8 File Offset: 0x003D4DD8
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

		// Token: 0x0601A55E RID: 107870 RVA: 0x003D6C30 File Offset: 0x003D4E30
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

		// Token: 0x0601A55F RID: 107871 RVA: 0x003D6C98 File Offset: 0x003D4E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A560 RID: 107872 RVA: 0x003D6CA4 File Offset: 0x003D4EA4
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009ABE RID: 39614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ABF RID: 39615
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04009AC0 RID: 39616
		private ErrorCode errCode_;

		// Token: 0x04009AC1 RID: 39617
		public const int ResultViewFieldNumber = 11;

		// Token: 0x04009AC2 RID: 39618
		private ResultView resultView_;
	}
}
