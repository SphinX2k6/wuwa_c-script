using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000413 RID: 1043
	[NetMessage(EMessageId.EdgeRunnerTaskRewardResponse)]
	public sealed class EdgeRunnerTaskRewardResponse : IMessage<EdgeRunnerTaskRewardResponse>, IMessage, IEquatable<EdgeRunnerTaskRewardResponse>, IDeepCloneable<EdgeRunnerTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060064CB RID: 25803 RVA: 0x000F310C File Offset: 0x000F130C
		[NullableContext(1)]
		public static EdgeRunnerTaskRewardResponse Create()
		{
			return new EdgeRunnerTaskRewardResponse();
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x000F3113 File Offset: 0x000F1313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x000F3116 File Offset: 0x000F1316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x000F311D File Offset: 0x000F131D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse()
		{
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x000F3125 File Offset: 0x000F1325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse(EdgeRunnerTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x000F314A File Offset: 0x000F134A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardResponse Clone()
		{
			return new EdgeRunnerTaskRewardResponse(this);
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x000F3152 File Offset: 0x000F1352
		// (set) Token: 0x060064D2 RID: 25810 RVA: 0x000F315A File Offset: 0x000F135A
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

		// Token: 0x060064D3 RID: 25811 RVA: 0x000F3163 File Offset: 0x000F1363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerTaskRewardResponse);
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x000F3171 File Offset: 0x000F1371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x000F31A0 File Offset: 0x000F13A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x000F31E5 File Offset: 0x000F13E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x000F31F2 File Offset: 0x000F13F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x000F31FB File Offset: 0x000F13FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x000F3230 File Offset: 0x000F1430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x000F326E File Offset: 0x000F146E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x000F329F File Offset: 0x000F149F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x000F32A8 File Offset: 0x000F14A8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400390C RID: 14604
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400390D RID: 14605
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x0400390E RID: 14606
		private ErrorCode errCode_;
	}
}
