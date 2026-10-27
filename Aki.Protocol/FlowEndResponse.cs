using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F9 RID: 1529
	[NetMessage(EMessageId.FlowEndResponse)]
	public sealed class FlowEndResponse : IMessage<FlowEndResponse>, IMessage, IEquatable<FlowEndResponse>, IDeepCloneable<FlowEndResponse>, IBufferMessage
	{
		// Token: 0x06008D88 RID: 36232 RVA: 0x0015745F File Offset: 0x0015565F
		[NullableContext(1)]
		public static FlowEndResponse Create()
		{
			return new FlowEndResponse();
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06008D89 RID: 36233 RVA: 0x00157466 File Offset: 0x00155666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x00157469 File Offset: 0x00155669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowEndResponse.Descriptor;
			}
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x00157470 File Offset: 0x00155670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse()
		{
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x00157478 File Offset: 0x00155678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse(FlowEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x0015749D File Offset: 0x0015569D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowEndResponse Clone()
		{
			return new FlowEndResponse(this);
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06008D8E RID: 36238 RVA: 0x001574A5 File Offset: 0x001556A5
		// (set) Token: 0x06008D8F RID: 36239 RVA: 0x001574AD File Offset: 0x001556AD
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

		// Token: 0x06008D90 RID: 36240 RVA: 0x001574B6 File Offset: 0x001556B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowEndResponse);
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x001574C4 File Offset: 0x001556C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x001574F4 File Offset: 0x001556F4
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

		// Token: 0x06008D93 RID: 36243 RVA: 0x00157539 File Offset: 0x00155739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00157546 File Offset: 0x00155746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x0015754F File Offset: 0x0015574F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x00157584 File Offset: 0x00155784
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

		// Token: 0x06008D97 RID: 36247 RVA: 0x001575C2 File Offset: 0x001557C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowEndResponse other)
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

		// Token: 0x06008D98 RID: 36248 RVA: 0x001575F3 File Offset: 0x001557F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x001575FC File Offset: 0x001557FC
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004517 RID: 17687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004518 RID: 17688
		public const int CodeFieldNumber = 3;

		// Token: 0x04004519 RID: 17689
		private ErrorCode code_;
	}
}
