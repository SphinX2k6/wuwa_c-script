using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D6 RID: 4566
	[NetMessage(EMessageId.SetInitTagResponse)]
	public sealed class SetInitTagResponse : IMessage<SetInitTagResponse>, IMessage, IEquatable<SetInitTagResponse>, IDeepCloneable<SetInitTagResponse>, IBufferMessage
	{
		// Token: 0x06018592 RID: 99730 RVA: 0x0038AB85 File Offset: 0x00388D85
		[NullableContext(1)]
		public static SetInitTagResponse Create()
		{
			return new SetInitTagResponse();
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x06018593 RID: 99731 RVA: 0x0038AB8C File Offset: 0x00388D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x06018594 RID: 99732 RVA: 0x0038AB8F File Offset: 0x00388D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetInitTagResponse.Descriptor;
			}
		}

		// Token: 0x06018595 RID: 99733 RVA: 0x0038AB96 File Offset: 0x00388D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse()
		{
		}

		// Token: 0x06018596 RID: 99734 RVA: 0x0038AB9E File Offset: 0x00388D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse(SetInitTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018597 RID: 99735 RVA: 0x0038ABC3 File Offset: 0x00388DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetInitTagResponse Clone()
		{
			return new SetInitTagResponse(this);
		}

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06018598 RID: 99736 RVA: 0x0038ABCB File Offset: 0x00388DCB
		// (set) Token: 0x06018599 RID: 99737 RVA: 0x0038ABD3 File Offset: 0x00388DD3
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

		// Token: 0x0601859A RID: 99738 RVA: 0x0038ABDC File Offset: 0x00388DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetInitTagResponse);
		}

		// Token: 0x0601859B RID: 99739 RVA: 0x0038ABEA File Offset: 0x00388DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetInitTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601859C RID: 99740 RVA: 0x0038AC18 File Offset: 0x00388E18
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

		// Token: 0x0601859D RID: 99741 RVA: 0x0038AC5D File Offset: 0x00388E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601859E RID: 99742 RVA: 0x0038AC6A File Offset: 0x00388E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601859F RID: 99743 RVA: 0x0038AC73 File Offset: 0x00388E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185A0 RID: 99744 RVA: 0x0038ACA8 File Offset: 0x00388EA8
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

		// Token: 0x060185A1 RID: 99745 RVA: 0x0038ACE6 File Offset: 0x00388EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetInitTagResponse other)
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

		// Token: 0x060185A2 RID: 99746 RVA: 0x0038AD17 File Offset: 0x00388F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185A3 RID: 99747 RVA: 0x0038AD20 File Offset: 0x00388F20
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009018 RID: 36888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009019 RID: 36889
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400901A RID: 36890
		private ErrorCode errorCode_;
	}
}
