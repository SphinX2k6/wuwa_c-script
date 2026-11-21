using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098B RID: 2443
	[NetMessage(EMessageId.MapTraceResponse)]
	public sealed class MapTraceResponse : IMessage<MapTraceResponse>, IMessage, IEquatable<MapTraceResponse>, IDeepCloneable<MapTraceResponse>, IBufferMessage
	{
		// Token: 0x0600D6F8 RID: 55032 RVA: 0x001F9F21 File Offset: 0x001F8121
		[NullableContext(1)]
		public static MapTraceResponse Create()
		{
			return new MapTraceResponse();
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0600D6F9 RID: 55033 RVA: 0x001F9F28 File Offset: 0x001F8128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x001F9F2B File Offset: 0x001F812B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600D6FB RID: 55035 RVA: 0x001F9F32 File Offset: 0x001F8132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse()
		{
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x001F9F3A File Offset: 0x001F813A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse(MapTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x001F9F6B File Offset: 0x001F816B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse Clone()
		{
			return new MapTraceResponse(this);
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x001F9F73 File Offset: 0x001F8173
		// (set) Token: 0x0600D6FF RID: 55039 RVA: 0x001F9F7B File Offset: 0x001F817B
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

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x001F9F84 File Offset: 0x001F8184
		// (set) Token: 0x0600D701 RID: 55041 RVA: 0x001F9F8C File Offset: 0x001F818C
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

		// Token: 0x0600D702 RID: 55042 RVA: 0x001F9F95 File Offset: 0x001F8195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceResponse);
		}

		// Token: 0x0600D703 RID: 55043 RVA: 0x001F9FA3 File Offset: 0x001F81A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D704 RID: 55044 RVA: 0x001F9FE4 File Offset: 0x001F81E4
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

		// Token: 0x0600D705 RID: 55045 RVA: 0x001FA042 File Offset: 0x001F8242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D706 RID: 55046 RVA: 0x001FA04F File Offset: 0x001F824F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D707 RID: 55047 RVA: 0x001FA058 File Offset: 0x001F8258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x001FA0B4 File Offset: 0x001F82B4
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

		// Token: 0x0600D709 RID: 55049 RVA: 0x001FA10C File Offset: 0x001F830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceResponse other)
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

		// Token: 0x0600D70A RID: 55050 RVA: 0x001FA15C File Offset: 0x001F835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D70B RID: 55051 RVA: 0x001FA168 File Offset: 0x001F8368
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
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MarkId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A1C RID: 23068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A1D RID: 23069
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005A1E RID: 23070
		private ErrorCode errorCode_;

		// Token: 0x04005A1F RID: 23071
		public const int MarkIdFieldNumber = 15;

		// Token: 0x04005A20 RID: 23072
		private int markId_;
	}
}
