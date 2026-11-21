using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129D RID: 4765
	[NetMessage(EMessageId.SneakTimeResponse)]
	public sealed class SneakTimeResponse : IMessage<SneakTimeResponse>, IMessage, IEquatable<SneakTimeResponse>, IDeepCloneable<SneakTimeResponse>, IBufferMessage
	{
		// Token: 0x060196E7 RID: 104167 RVA: 0x003B56F8 File Offset: 0x003B38F8
		[NullableContext(1)]
		public static SneakTimeResponse Create()
		{
			return new SneakTimeResponse();
		}

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x060196E8 RID: 104168 RVA: 0x003B56FF File Offset: 0x003B38FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x060196E9 RID: 104169 RVA: 0x003B5702 File Offset: 0x003B3902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakTimeResponse.Descriptor;
			}
		}

		// Token: 0x060196EA RID: 104170 RVA: 0x003B5709 File Offset: 0x003B3909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse()
		{
		}

		// Token: 0x060196EB RID: 104171 RVA: 0x003B5711 File Offset: 0x003B3911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse(SneakTimeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196EC RID: 104172 RVA: 0x003B5736 File Offset: 0x003B3936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse Clone()
		{
			return new SneakTimeResponse(this);
		}

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x060196ED RID: 104173 RVA: 0x003B573E File Offset: 0x003B393E
		// (set) Token: 0x060196EE RID: 104174 RVA: 0x003B5746 File Offset: 0x003B3946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060196EF RID: 104175 RVA: 0x003B574F File Offset: 0x003B394F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakTimeResponse);
		}

		// Token: 0x060196F0 RID: 104176 RVA: 0x003B575D File Offset: 0x003B395D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakTimeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196F1 RID: 104177 RVA: 0x003B578C File Offset: 0x003B398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060196F2 RID: 104178 RVA: 0x003B57D1 File Offset: 0x003B39D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196F3 RID: 104179 RVA: 0x003B57DE File Offset: 0x003B39DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196F4 RID: 104180 RVA: 0x003B57E7 File Offset: 0x003B39E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196F5 RID: 104181 RVA: 0x003B581C File Offset: 0x003B3A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060196F6 RID: 104182 RVA: 0x003B585A File Offset: 0x003B3A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakTimeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060196F7 RID: 104183 RVA: 0x003B588B File Offset: 0x003B3A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196F8 RID: 104184 RVA: 0x003B5894 File Offset: 0x003B3A94
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009655 RID: 38485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009656 RID: 38486
		public const int ErrorIdFieldNumber = 11;

		// Token: 0x04009657 RID: 38487
		private ErrorCode errorId_;
	}
}
