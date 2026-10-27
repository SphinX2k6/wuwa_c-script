using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D9 RID: 4825
	[NetMessage(EMessageId.SurvivorsOpDoneResponse)]
	public sealed class SurvivorsOpDoneResponse : IMessage<SurvivorsOpDoneResponse>, IMessage, IEquatable<SurvivorsOpDoneResponse>, IDeepCloneable<SurvivorsOpDoneResponse>, IBufferMessage
	{
		// Token: 0x06019AB3 RID: 105139 RVA: 0x003BB5E4 File Offset: 0x003B97E4
		[NullableContext(1)]
		public static SurvivorsOpDoneResponse Create()
		{
			return new SurvivorsOpDoneResponse();
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x06019AB4 RID: 105140 RVA: 0x003BB5EB File Offset: 0x003B97EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x06019AB5 RID: 105141 RVA: 0x003BB5EE File Offset: 0x003B97EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDoneResponse.Descriptor;
			}
		}

		// Token: 0x06019AB6 RID: 105142 RVA: 0x003BB5F5 File Offset: 0x003B97F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse()
		{
		}

		// Token: 0x06019AB7 RID: 105143 RVA: 0x003BB5FD File Offset: 0x003B97FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse(SurvivorsOpDoneResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AB8 RID: 105144 RVA: 0x003BB622 File Offset: 0x003B9822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneResponse Clone()
		{
			return new SurvivorsOpDoneResponse(this);
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x06019AB9 RID: 105145 RVA: 0x003BB62A File Offset: 0x003B982A
		// (set) Token: 0x06019ABA RID: 105146 RVA: 0x003BB632 File Offset: 0x003B9832
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

		// Token: 0x06019ABB RID: 105147 RVA: 0x003BB63B File Offset: 0x003B983B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDoneResponse);
		}

		// Token: 0x06019ABC RID: 105148 RVA: 0x003BB649 File Offset: 0x003B9849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDoneResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019ABD RID: 105149 RVA: 0x003BB678 File Offset: 0x003B9878
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

		// Token: 0x06019ABE RID: 105150 RVA: 0x003BB6BD File Offset: 0x003B98BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019ABF RID: 105151 RVA: 0x003BB6CA File Offset: 0x003B98CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AC0 RID: 105152 RVA: 0x003BB6D3 File Offset: 0x003B98D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AC1 RID: 105153 RVA: 0x003BB708 File Offset: 0x003B9908
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

		// Token: 0x06019AC2 RID: 105154 RVA: 0x003BB746 File Offset: 0x003B9946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDoneResponse other)
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

		// Token: 0x06019AC3 RID: 105155 RVA: 0x003BB777 File Offset: 0x003B9977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AC4 RID: 105156 RVA: 0x003BB780 File Offset: 0x003B9980
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400967A RID: 38522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400967B RID: 38523
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x0400967C RID: 38524
		private ErrorCode errCode_;
	}
}
