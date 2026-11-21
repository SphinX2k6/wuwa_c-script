using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001170 RID: 4464
	[NetMessage(EMessageId.RTimeStopAnimResponse)]
	public sealed class RTimeStopAnimResponse : IMessage<RTimeStopAnimResponse>, IMessage, IEquatable<RTimeStopAnimResponse>, IDeepCloneable<RTimeStopAnimResponse>, IBufferMessage
	{
		// Token: 0x06017D9F RID: 97695 RVA: 0x00378F4C File Offset: 0x0037714C
		[NullableContext(1)]
		public static RTimeStopAnimResponse Create()
		{
			return new RTimeStopAnimResponse();
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x06017DA0 RID: 97696 RVA: 0x00378F53 File Offset: 0x00377153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x06017DA1 RID: 97697 RVA: 0x00378F56 File Offset: 0x00377156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimResponse.Descriptor;
			}
		}

		// Token: 0x06017DA2 RID: 97698 RVA: 0x00378F5D File Offset: 0x0037715D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse()
		{
		}

		// Token: 0x06017DA3 RID: 97699 RVA: 0x00378F65 File Offset: 0x00377165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse(RTimeStopAnimResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DA4 RID: 97700 RVA: 0x00378F8A File Offset: 0x0037718A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimResponse Clone()
		{
			return new RTimeStopAnimResponse(this);
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x06017DA5 RID: 97701 RVA: 0x00378F92 File Offset: 0x00377192
		// (set) Token: 0x06017DA6 RID: 97702 RVA: 0x00378F9A File Offset: 0x0037719A
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

		// Token: 0x06017DA7 RID: 97703 RVA: 0x00378FA3 File Offset: 0x003771A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimResponse);
		}

		// Token: 0x06017DA8 RID: 97704 RVA: 0x00378FB1 File Offset: 0x003771B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DA9 RID: 97705 RVA: 0x00378FE0 File Offset: 0x003771E0
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

		// Token: 0x06017DAA RID: 97706 RVA: 0x00379025 File Offset: 0x00377225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DAB RID: 97707 RVA: 0x00379032 File Offset: 0x00377232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DAC RID: 97708 RVA: 0x0037903B File Offset: 0x0037723B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DAD RID: 97709 RVA: 0x00379070 File Offset: 0x00377270
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

		// Token: 0x06017DAE RID: 97710 RVA: 0x003790AE File Offset: 0x003772AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopAnimResponse other)
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

		// Token: 0x06017DAF RID: 97711 RVA: 0x003790DF File Offset: 0x003772DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DB0 RID: 97712 RVA: 0x003790E8 File Offset: 0x003772E8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E41 RID: 36417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E42 RID: 36418
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008E43 RID: 36419
		private ErrorCode errorCode_;
	}
}
