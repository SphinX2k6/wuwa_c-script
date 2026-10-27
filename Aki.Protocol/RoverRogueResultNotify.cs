using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111C RID: 4380
	[NetMessage(EMessageId.RoverRogueResultNotify)]
	public sealed class RoverRogueResultNotify : IMessage<RoverRogueResultNotify>, IMessage, IEquatable<RoverRogueResultNotify>, IDeepCloneable<RoverRogueResultNotify>, IBufferMessage
	{
		// Token: 0x060175DC RID: 95708 RVA: 0x00364E9F File Offset: 0x0036309F
		[NullableContext(1)]
		public static RoverRogueResultNotify Create()
		{
			return new RoverRogueResultNotify();
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x060175DD RID: 95709 RVA: 0x00364EA6 File Offset: 0x003630A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x060175DE RID: 95710 RVA: 0x00364EA9 File Offset: 0x003630A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultNotify.Descriptor;
			}
		}

		// Token: 0x060175DF RID: 95711 RVA: 0x00364EB0 File Offset: 0x003630B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify()
		{
		}

		// Token: 0x060175E0 RID: 95712 RVA: 0x00364EB8 File Offset: 0x003630B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify(RoverRogueResultNotify other) : this()
		{
			this.resultInfo_ = ((other.resultInfo_ != null) ? other.resultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060175E1 RID: 95713 RVA: 0x00364EED File Offset: 0x003630ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultNotify Clone()
		{
			return new RoverRogueResultNotify(this);
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x060175E2 RID: 95714 RVA: 0x00364EF5 File Offset: 0x003630F5
		// (set) Token: 0x060175E3 RID: 95715 RVA: 0x00364EFD File Offset: 0x003630FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultInfo ResultInfo
		{
			get
			{
				return this.resultInfo_;
			}
			set
			{
				this.resultInfo_ = value;
			}
		}

		// Token: 0x060175E4 RID: 95716 RVA: 0x00364F06 File Offset: 0x00363106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultNotify);
		}

		// Token: 0x060175E5 RID: 95717 RVA: 0x00364F14 File Offset: 0x00363114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ResultInfo, other.ResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175E6 RID: 95718 RVA: 0x00364F48 File Offset: 0x00363148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.resultInfo_ != null)
			{
				num ^= this.ResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060175E7 RID: 95719 RVA: 0x00364F84 File Offset: 0x00363184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175E8 RID: 95720 RVA: 0x00364F91 File Offset: 0x00363191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175E9 RID: 95721 RVA: 0x00364F9A File Offset: 0x0036319A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.resultInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175EA RID: 95722 RVA: 0x00364FCC File Offset: 0x003631CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.resultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060175EB RID: 95723 RVA: 0x0036500C File Offset: 0x0036320C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.resultInfo_ != null)
			{
				if (this.resultInfo_ == null)
				{
					this.ResultInfo = new RoverRogueResultInfo();
				}
				this.ResultInfo.MergeFrom(other.ResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060175EC RID: 95724 RVA: 0x00365060 File Offset: 0x00363260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175ED RID: 95725 RVA: 0x0036506C File Offset: 0x0036326C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.resultInfo_ == null)
					{
						this.ResultInfo = new RoverRogueResultInfo();
					}
					input.ReadMessage(this.ResultInfo);
				}
			}
		}

		// Token: 0x04008B08 RID: 35592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B09 RID: 35593
		public const int ResultInfoFieldNumber = 3;

		// Token: 0x04008B0A RID: 35594
		private RoverRogueResultInfo resultInfo_;
	}
}
