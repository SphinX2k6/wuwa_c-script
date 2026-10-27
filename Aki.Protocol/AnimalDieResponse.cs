using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E6 RID: 230
	[NetMessage(EMessageId.AnimalDieResponse)]
	public sealed class AnimalDieResponse : IMessage<AnimalDieResponse>, IMessage, IEquatable<AnimalDieResponse>, IDeepCloneable<AnimalDieResponse>, IBufferMessage
	{
		// Token: 0x060021B0 RID: 8624 RVA: 0x0005A0A7 File Offset: 0x000582A7
		[NullableContext(1)]
		public static AnimalDieResponse Create()
		{
			return new AnimalDieResponse();
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0005A0AE File Offset: 0x000582AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x0005A0B1 File Offset: 0x000582B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieResponse.Descriptor;
			}
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0005A0B8 File Offset: 0x000582B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse()
		{
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0005A0C0 File Offset: 0x000582C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse(AnimalDieResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0005A0E5 File Offset: 0x000582E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieResponse Clone()
		{
			return new AnimalDieResponse(this);
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0005A0ED File Offset: 0x000582ED
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0005A0F5 File Offset: 0x000582F5
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

		// Token: 0x060021B8 RID: 8632 RVA: 0x0005A0FE File Offset: 0x000582FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieResponse);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0005A10C File Offset: 0x0005830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0005A13C File Offset: 0x0005833C
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

		// Token: 0x060021BB RID: 8635 RVA: 0x0005A181 File Offset: 0x00058381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0005A18E File Offset: 0x0005838E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0005A197 File Offset: 0x00058397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0005A1CC File Offset: 0x000583CC
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

		// Token: 0x060021BF RID: 8639 RVA: 0x0005A20A File Offset: 0x0005840A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieResponse other)
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

		// Token: 0x060021C0 RID: 8640 RVA: 0x0005A23B File Offset: 0x0005843B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0005A244 File Offset: 0x00058444
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400244B RID: 9291
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400244C RID: 9292
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400244D RID: 9293
		private ErrorCode errorCode_;
	}
}
