using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEF RID: 4079
	[NetMessage(EMessageId.RogueResInstResultResponse)]
	public sealed class RogueResInstResultResponse : IMessage<RogueResInstResultResponse>, IMessage, IEquatable<RogueResInstResultResponse>, IDeepCloneable<RogueResInstResultResponse>, IBufferMessage
	{
		// Token: 0x06015CEC RID: 89324 RVA: 0x0032B0D2 File Offset: 0x003292D2
		[NullableContext(1)]
		public static RogueResInstResultResponse Create()
		{
			return new RogueResInstResultResponse();
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06015CED RID: 89325 RVA: 0x0032B0D9 File Offset: 0x003292D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06015CEE RID: 89326 RVA: 0x0032B0DC File Offset: 0x003292DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstResultResponse.Descriptor;
			}
		}

		// Token: 0x06015CEF RID: 89327 RVA: 0x0032B0E3 File Offset: 0x003292E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse()
		{
		}

		// Token: 0x06015CF0 RID: 89328 RVA: 0x0032B0EC File Offset: 0x003292EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse(RogueResInstResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instResultView_ = ((other.instResultView_ != null) ? other.instResultView_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CF1 RID: 89329 RVA: 0x0032B138 File Offset: 0x00329338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstResultResponse Clone()
		{
			return new RogueResInstResultResponse(this);
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06015CF2 RID: 89330 RVA: 0x0032B140 File Offset: 0x00329340
		// (set) Token: 0x06015CF3 RID: 89331 RVA: 0x0032B148 File Offset: 0x00329348
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

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06015CF4 RID: 89332 RVA: 0x0032B151 File Offset: 0x00329351
		// (set) Token: 0x06015CF5 RID: 89333 RVA: 0x0032B159 File Offset: 0x00329359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstResultView InstResultView
		{
			get
			{
				return this.instResultView_;
			}
			set
			{
				this.instResultView_ = value;
			}
		}

		// Token: 0x06015CF6 RID: 89334 RVA: 0x0032B162 File Offset: 0x00329362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstResultResponse);
		}

		// Token: 0x06015CF7 RID: 89335 RVA: 0x0032B170 File Offset: 0x00329370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InstResultView, other.InstResultView) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CF8 RID: 89336 RVA: 0x0032B1C0 File Offset: 0x003293C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.instResultView_ != null)
			{
				num ^= this.InstResultView.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CF9 RID: 89337 RVA: 0x0032B21B File Offset: 0x0032941B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CFA RID: 89338 RVA: 0x0032B228 File Offset: 0x00329428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CFB RID: 89339 RVA: 0x0032B234 File Offset: 0x00329434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.instResultView_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.InstResultView);
			}
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

		// Token: 0x06015CFC RID: 89340 RVA: 0x0032B290 File Offset: 0x00329490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.instResultView_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstResultView);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CFD RID: 89341 RVA: 0x0032B2E8 File Offset: 0x003294E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.instResultView_ != null)
			{
				if (this.instResultView_ == null)
				{
					this.InstResultView = new InstResultView();
				}
				this.InstResultView.MergeFrom(other.InstResultView);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CFE RID: 89342 RVA: 0x0032B350 File Offset: 0x00329550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CFF RID: 89343 RVA: 0x0032B35C File Offset: 0x0032955C
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
					if (this.instResultView_ == null)
					{
						this.InstResultView = new InstResultView();
					}
					input.ReadMessage(this.InstResultView);
				}
			}
		}

		// Token: 0x040082EA RID: 33514
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082EB RID: 33515
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040082EC RID: 33516
		private ErrorCode errorCode_;

		// Token: 0x040082ED RID: 33517
		public const int InstResultViewFieldNumber = 10;

		// Token: 0x040082EE RID: 33518
		private InstResultView instResultView_;
	}
}
