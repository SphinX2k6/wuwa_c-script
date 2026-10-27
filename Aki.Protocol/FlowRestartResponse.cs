using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000601 RID: 1537
	[NetMessage(EMessageId.FlowRestartResponse)]
	public sealed class FlowRestartResponse : IMessage<FlowRestartResponse>, IMessage, IEquatable<FlowRestartResponse>, IDeepCloneable<FlowRestartResponse>, IBufferMessage
	{
		// Token: 0x06008E27 RID: 36391 RVA: 0x001587F1 File Offset: 0x001569F1
		[NullableContext(1)]
		public static FlowRestartResponse Create()
		{
			return new FlowRestartResponse();
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x001587F8 File Offset: 0x001569F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06008E29 RID: 36393 RVA: 0x001587FB File Offset: 0x001569FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowRestartResponse.Descriptor;
			}
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x00158802 File Offset: 0x00156A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse()
		{
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x0015880A File Offset: 0x00156A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse(FlowRestartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E2C RID: 36396 RVA: 0x0015882F File Offset: 0x00156A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartResponse Clone()
		{
			return new FlowRestartResponse(this);
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x00158837 File Offset: 0x00156A37
		// (set) Token: 0x06008E2E RID: 36398 RVA: 0x0015883F File Offset: 0x00156A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x00158848 File Offset: 0x00156A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowRestartResponse);
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x00158856 File Offset: 0x00156A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowRestartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x00158884 File Offset: 0x00156A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x001588C9 File Offset: 0x00156AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x001588D6 File Offset: 0x00156AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x001588DF File Offset: 0x00156ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x00158914 File Offset: 0x00156B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x00158952 File Offset: 0x00156B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowRestartResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x00158983 File Offset: 0x00156B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x0015898C File Offset: 0x00156B8C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400453F RID: 17727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004540 RID: 17728
		public const int CodeFieldNumber = 14;

		// Token: 0x04004541 RID: 17729
		private ErrorCode code_;
	}
}
