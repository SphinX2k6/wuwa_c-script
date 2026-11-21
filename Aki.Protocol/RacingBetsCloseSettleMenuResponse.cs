using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3E RID: 3646
	[NetMessage(EMessageId.RacingBetsCloseSettleMenuResponse)]
	public sealed class RacingBetsCloseSettleMenuResponse : IMessage<RacingBetsCloseSettleMenuResponse>, IMessage, IEquatable<RacingBetsCloseSettleMenuResponse>, IDeepCloneable<RacingBetsCloseSettleMenuResponse>, IBufferMessage
	{
		// Token: 0x060139B3 RID: 80307 RVA: 0x002DA5F4 File Offset: 0x002D87F4
		[NullableContext(1)]
		public static RacingBetsCloseSettleMenuResponse Create()
		{
			return new RacingBetsCloseSettleMenuResponse();
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x060139B4 RID: 80308 RVA: 0x002DA5FB File Offset: 0x002D87FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x060139B5 RID: 80309 RVA: 0x002DA5FE File Offset: 0x002D87FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsCloseSettleMenuResponse.Descriptor;
			}
		}

		// Token: 0x060139B6 RID: 80310 RVA: 0x002DA605 File Offset: 0x002D8805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse()
		{
		}

		// Token: 0x060139B7 RID: 80311 RVA: 0x002DA60D File Offset: 0x002D880D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse(RacingBetsCloseSettleMenuResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139B8 RID: 80312 RVA: 0x002DA632 File Offset: 0x002D8832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse Clone()
		{
			return new RacingBetsCloseSettleMenuResponse(this);
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x060139B9 RID: 80313 RVA: 0x002DA63A File Offset: 0x002D883A
		// (set) Token: 0x060139BA RID: 80314 RVA: 0x002DA642 File Offset: 0x002D8842
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

		// Token: 0x060139BB RID: 80315 RVA: 0x002DA64B File Offset: 0x002D884B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsCloseSettleMenuResponse);
		}

		// Token: 0x060139BC RID: 80316 RVA: 0x002DA659 File Offset: 0x002D8859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsCloseSettleMenuResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139BD RID: 80317 RVA: 0x002DA688 File Offset: 0x002D8888
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

		// Token: 0x060139BE RID: 80318 RVA: 0x002DA6CD File Offset: 0x002D88CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139BF RID: 80319 RVA: 0x002DA6DA File Offset: 0x002D88DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139C0 RID: 80320 RVA: 0x002DA6E3 File Offset: 0x002D88E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139C1 RID: 80321 RVA: 0x002DA718 File Offset: 0x002D8918
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

		// Token: 0x060139C2 RID: 80322 RVA: 0x002DA756 File Offset: 0x002D8956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsCloseSettleMenuResponse other)
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

		// Token: 0x060139C3 RID: 80323 RVA: 0x002DA787 File Offset: 0x002D8987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139C4 RID: 80324 RVA: 0x002DA790 File Offset: 0x002D8990
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400787F RID: 30847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007880 RID: 30848
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007881 RID: 30849
		private ErrorCode errorCode_;
	}
}
