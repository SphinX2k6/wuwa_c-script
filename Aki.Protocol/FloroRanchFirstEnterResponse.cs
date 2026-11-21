using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059E RID: 1438
	[NetMessage(EMessageId.FloroRanchFirstEnterResponse)]
	public sealed class FloroRanchFirstEnterResponse : IMessage<FloroRanchFirstEnterResponse>, IMessage, IEquatable<FloroRanchFirstEnterResponse>, IDeepCloneable<FloroRanchFirstEnterResponse>, IBufferMessage
	{
		// Token: 0x06008564 RID: 34148 RVA: 0x00141308 File Offset: 0x0013F508
		[NullableContext(1)]
		public static FloroRanchFirstEnterResponse Create()
		{
			return new FloroRanchFirstEnterResponse();
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x0014130F File Offset: 0x0013F50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06008566 RID: 34150 RVA: 0x00141312 File Offset: 0x0013F512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchFirstEnterResponse.Descriptor;
			}
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00141319 File Offset: 0x0013F519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse()
		{
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00141321 File Offset: 0x0013F521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse(FloroRanchFirstEnterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00141346 File Offset: 0x0013F546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse Clone()
		{
			return new FloroRanchFirstEnterResponse(this);
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x0600856A RID: 34154 RVA: 0x0014134E File Offset: 0x0013F54E
		// (set) Token: 0x0600856B RID: 34155 RVA: 0x00141356 File Offset: 0x0013F556
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

		// Token: 0x0600856C RID: 34156 RVA: 0x0014135F File Offset: 0x0013F55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchFirstEnterResponse);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x0014136D File Offset: 0x0013F56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchFirstEnterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x0014139C File Offset: 0x0013F59C
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

		// Token: 0x0600856F RID: 34159 RVA: 0x001413E1 File Offset: 0x0013F5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x001413EE File Offset: 0x0013F5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x001413F7 File Offset: 0x0013F5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06008572 RID: 34162 RVA: 0x0014142C File Offset: 0x0013F62C
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

		// Token: 0x06008573 RID: 34163 RVA: 0x0014146A File Offset: 0x0013F66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchFirstEnterResponse other)
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

		// Token: 0x06008574 RID: 34164 RVA: 0x0014149B File Offset: 0x0013F69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008575 RID: 34165 RVA: 0x001414A4 File Offset: 0x0013F6A4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004262 RID: 16994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004263 RID: 16995
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004264 RID: 16996
		private ErrorCode errorCode_;
	}
}
