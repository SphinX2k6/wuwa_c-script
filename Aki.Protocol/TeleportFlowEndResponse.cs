using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AF RID: 5039
	[NetMessage(EMessageId.TeleportFlowEndResponse)]
	public sealed class TeleportFlowEndResponse : IMessage<TeleportFlowEndResponse>, IMessage, IEquatable<TeleportFlowEndResponse>, IDeepCloneable<TeleportFlowEndResponse>, IBufferMessage
	{
		// Token: 0x0601AD08 RID: 109832 RVA: 0x003E774D File Offset: 0x003E594D
		[NullableContext(1)]
		public static TeleportFlowEndResponse Create()
		{
			return new TeleportFlowEndResponse();
		}

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x0601AD09 RID: 109833 RVA: 0x003E7754 File Offset: 0x003E5954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x0601AD0A RID: 109834 RVA: 0x003E7757 File Offset: 0x003E5957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowEndResponse.Descriptor;
			}
		}

		// Token: 0x0601AD0B RID: 109835 RVA: 0x003E775E File Offset: 0x003E595E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse()
		{
		}

		// Token: 0x0601AD0C RID: 109836 RVA: 0x003E7766 File Offset: 0x003E5966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse(TeleportFlowEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD0D RID: 109837 RVA: 0x003E778B File Offset: 0x003E598B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse Clone()
		{
			return new TeleportFlowEndResponse(this);
		}

		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0601AD0E RID: 109838 RVA: 0x003E7793 File Offset: 0x003E5993
		// (set) Token: 0x0601AD0F RID: 109839 RVA: 0x003E779B File Offset: 0x003E599B
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

		// Token: 0x0601AD10 RID: 109840 RVA: 0x003E77A4 File Offset: 0x003E59A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowEndResponse);
		}

		// Token: 0x0601AD11 RID: 109841 RVA: 0x003E77B2 File Offset: 0x003E59B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD12 RID: 109842 RVA: 0x003E77E0 File Offset: 0x003E59E0
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

		// Token: 0x0601AD13 RID: 109843 RVA: 0x003E7825 File Offset: 0x003E5A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD14 RID: 109844 RVA: 0x003E7832 File Offset: 0x003E5A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD15 RID: 109845 RVA: 0x003E783B File Offset: 0x003E5A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD16 RID: 109846 RVA: 0x003E7870 File Offset: 0x003E5A70
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

		// Token: 0x0601AD17 RID: 109847 RVA: 0x003E78AE File Offset: 0x003E5AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowEndResponse other)
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

		// Token: 0x0601AD18 RID: 109848 RVA: 0x003E78DF File Offset: 0x003E5ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD19 RID: 109849 RVA: 0x003E78E8 File Offset: 0x003E5AE8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009CD9 RID: 40153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CDA RID: 40154
		public const int CodeFieldNumber = 8;

		// Token: 0x04009CDB RID: 40155
		private ErrorCode code_;
	}
}
