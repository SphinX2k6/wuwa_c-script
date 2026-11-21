using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000974 RID: 2420
	[NetMessage(EMessageId.MapCancelTraceResponse)]
	public sealed class MapCancelTraceResponse : IMessage<MapCancelTraceResponse>, IMessage, IEquatable<MapCancelTraceResponse>, IDeepCloneable<MapCancelTraceResponse>, IBufferMessage
	{
		// Token: 0x0600D52C RID: 54572 RVA: 0x001F6069 File Offset: 0x001F4269
		[NullableContext(1)]
		public static MapCancelTraceResponse Create()
		{
			return new MapCancelTraceResponse();
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600D52D RID: 54573 RVA: 0x001F6070 File Offset: 0x001F4270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600D52E RID: 54574 RVA: 0x001F6073 File Offset: 0x001F4273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x001F607A File Offset: 0x001F427A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse()
		{
		}

		// Token: 0x0600D530 RID: 54576 RVA: 0x001F6082 File Offset: 0x001F4282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse(MapCancelTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D531 RID: 54577 RVA: 0x001F60B3 File Offset: 0x001F42B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceResponse Clone()
		{
			return new MapCancelTraceResponse(this);
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x001F60BB File Offset: 0x001F42BB
		// (set) Token: 0x0600D533 RID: 54579 RVA: 0x001F60C3 File Offset: 0x001F42C3
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

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x001F60CC File Offset: 0x001F42CC
		// (set) Token: 0x0600D535 RID: 54581 RVA: 0x001F60D4 File Offset: 0x001F42D4
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

		// Token: 0x0600D536 RID: 54582 RVA: 0x001F60DD File Offset: 0x001F42DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceResponse);
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x001F60EB File Offset: 0x001F42EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D538 RID: 54584 RVA: 0x001F612C File Offset: 0x001F432C
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

		// Token: 0x0600D539 RID: 54585 RVA: 0x001F618A File Offset: 0x001F438A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x001F6197 File Offset: 0x001F4397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x001F61A0 File Offset: 0x001F43A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D53C RID: 54588 RVA: 0x001F61FC File Offset: 0x001F43FC
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

		// Token: 0x0600D53D RID: 54589 RVA: 0x001F6254 File Offset: 0x001F4454
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

		// Token: 0x0600D53E RID: 54590 RVA: 0x001F62A4 File Offset: 0x001F44A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D53F RID: 54591 RVA: 0x001F62B0 File Offset: 0x001F44B0
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
				if (num != 40U)
				{
					if (num != 80U)
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

		// Token: 0x04005999 RID: 22937
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400599A RID: 22938
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400599B RID: 22939
		private ErrorCode errorCode_;

		// Token: 0x0400599C RID: 22940
		public const int MarkIdFieldNumber = 5;

		// Token: 0x0400599D RID: 22941
		private int markId_;
	}
}
