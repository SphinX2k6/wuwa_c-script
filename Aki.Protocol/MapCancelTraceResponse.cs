using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000985 RID: 2437
	[NetMessage(EMessageId.MapCancelTraceResponse)]
	public sealed class MapCancelTraceResponse : IMessage<MapCancelTraceResponse>, IMessage, IEquatable<MapCancelTraceResponse>, IDeepCloneable<MapCancelTraceResponse>, IBufferMessage
	{
		// Token: 0x0600D646 RID: 54854 RVA: 0x001F8251 File Offset: 0x001F6451
		[NullableContext(1)]
		public static MapCancelTraceResponse Create()
		{
			return new MapCancelTraceResponse();
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0600D647 RID: 54855 RVA: 0x001F8258 File Offset: 0x001F6458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0600D648 RID: 54856 RVA: 0x001F825B File Offset: 0x001F645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600D649 RID: 54857 RVA: 0x001F8262 File Offset: 0x001F6462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse()
		{
		}

		// Token: 0x0600D64A RID: 54858 RVA: 0x001F826A File Offset: 0x001F646A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse(MapCancelTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x001F829B File Offset: 0x001F649B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse Clone()
		{
			return new MapCancelTraceResponse(this);
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0600D64C RID: 54860 RVA: 0x001F82A3 File Offset: 0x001F64A3
		// (set) Token: 0x0600D64D RID: 54861 RVA: 0x001F82AB File Offset: 0x001F64AB
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

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0600D64E RID: 54862 RVA: 0x001F82B4 File Offset: 0x001F64B4
		// (set) Token: 0x0600D64F RID: 54863 RVA: 0x001F82BC File Offset: 0x001F64BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0600D650 RID: 54864 RVA: 0x001F82C5 File Offset: 0x001F64C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceResponse);
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x001F82D3 File Offset: 0x001F64D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x001F8314 File Offset: 0x001F6514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x001F8372 File Offset: 0x001F6572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x001F837F File Offset: 0x001F657F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x001F8388 File Offset: 0x001F6588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MarkId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x001F83E4 File Offset: 0x001F65E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D657 RID: 54871 RVA: 0x001F843C File Offset: 0x001F663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCancelTraceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D658 RID: 54872 RVA: 0x001F848C File Offset: 0x001F668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D659 RID: 54873 RVA: 0x001F8498 File Offset: 0x001F6698
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005990 RID: 22928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005991 RID: 22929
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005992 RID: 22930
		private ErrorCode errorCode_;

		// Token: 0x04005993 RID: 22931
		public const int MarkIdFieldNumber = 6;

		// Token: 0x04005994 RID: 22932
		private int markId_;
	}
}
