using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000705 RID: 1797
	[NetMessage(EMessageId.GolemCrackUpdateResponse)]
	public sealed class GolemCrackUpdateResponse : IMessage<GolemCrackUpdateResponse>, IMessage, IEquatable<GolemCrackUpdateResponse>, IDeepCloneable<GolemCrackUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600A38C RID: 41868 RVA: 0x0018B0C7 File Offset: 0x001892C7
		[NullableContext(1)]
		public static GolemCrackUpdateResponse Create()
		{
			return new GolemCrackUpdateResponse();
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600A38D RID: 41869 RVA: 0x0018B0CE File Offset: 0x001892CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x0018B0D1 File Offset: 0x001892D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x0018B0D8 File Offset: 0x001892D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse()
		{
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x0018B0E0 File Offset: 0x001892E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse(GolemCrackUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x0018B105 File Offset: 0x00189305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateResponse Clone()
		{
			return new GolemCrackUpdateResponse(this);
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x0018B10D File Offset: 0x0018930D
		// (set) Token: 0x0600A393 RID: 41875 RVA: 0x0018B115 File Offset: 0x00189315
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

		// Token: 0x0600A394 RID: 41876 RVA: 0x0018B11E File Offset: 0x0018931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackUpdateResponse);
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x0018B12C File Offset: 0x0018932C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x0018B15C File Offset: 0x0018935C
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

		// Token: 0x0600A397 RID: 41879 RVA: 0x0018B1A1 File Offset: 0x001893A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x0018B1AE File Offset: 0x001893AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x0018B1B7 File Offset: 0x001893B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x0018B1EC File Offset: 0x001893EC
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

		// Token: 0x0600A39B RID: 41883 RVA: 0x0018B22A File Offset: 0x0018942A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackUpdateResponse other)
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

		// Token: 0x0600A39C RID: 41884 RVA: 0x0018B25B File Offset: 0x0018945B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x0018B264 File Offset: 0x00189464
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004B90 RID: 19344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B91 RID: 19345
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04004B92 RID: 19346
		private ErrorCode errCode_;
	}
}
