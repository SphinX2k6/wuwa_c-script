using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8F RID: 2703
	[NetMessage(EMessageId.MotorSliderResponse)]
	public sealed class MotorSliderResponse : IMessage<MotorSliderResponse>, IMessage, IEquatable<MotorSliderResponse>, IDeepCloneable<MotorSliderResponse>, IBufferMessage
	{
		// Token: 0x0600EBB7 RID: 60343 RVA: 0x002270AF File Offset: 0x002252AF
		[NullableContext(1)]
		public static MotorSliderResponse Create()
		{
			return new MotorSliderResponse();
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600EBB8 RID: 60344 RVA: 0x002270B6 File Offset: 0x002252B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600EBB9 RID: 60345 RVA: 0x002270B9 File Offset: 0x002252B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderResponse.Descriptor;
			}
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x002270C0 File Offset: 0x002252C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse()
		{
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x002270C8 File Offset: 0x002252C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse(MotorSliderResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBBC RID: 60348 RVA: 0x002270ED File Offset: 0x002252ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderResponse Clone()
		{
			return new MotorSliderResponse(this);
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600EBBD RID: 60349 RVA: 0x002270F5 File Offset: 0x002252F5
		// (set) Token: 0x0600EBBE RID: 60350 RVA: 0x002270FD File Offset: 0x002252FD
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

		// Token: 0x0600EBBF RID: 60351 RVA: 0x00227106 File Offset: 0x00225306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderResponse);
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x00227114 File Offset: 0x00225314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x00227144 File Offset: 0x00225344
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

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x00227189 File Offset: 0x00225389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x00227196 File Offset: 0x00225396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x0022719F File Offset: 0x0022539F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x002271D4 File Offset: 0x002253D4
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

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x00227212 File Offset: 0x00225412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSliderResponse other)
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

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x00227243 File Offset: 0x00225443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x0022724C File Offset: 0x0022544C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006005 RID: 24581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006006 RID: 24582
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006007 RID: 24583
		private ErrorCode errorCode_;
	}
}
