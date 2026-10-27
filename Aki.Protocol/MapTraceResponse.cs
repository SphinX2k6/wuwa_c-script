using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099C RID: 2460
	[NetMessage(EMessageId.MapTraceResponse)]
	public sealed class MapTraceResponse : IMessage<MapTraceResponse>, IMessage, IEquatable<MapTraceResponse>, IDeepCloneable<MapTraceResponse>, IBufferMessage
	{
		// Token: 0x0600D812 RID: 55314 RVA: 0x001FC111 File Offset: 0x001FA311
		[NullableContext(1)]
		public static MapTraceResponse Create()
		{
			return new MapTraceResponse();
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0600D813 RID: 55315 RVA: 0x001FC118 File Offset: 0x001FA318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0600D814 RID: 55316 RVA: 0x001FC11B File Offset: 0x001FA31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600D815 RID: 55317 RVA: 0x001FC122 File Offset: 0x001FA322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse()
		{
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x001FC12A File Offset: 0x001FA32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse(MapTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x001FC15B File Offset: 0x001FA35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceResponse Clone()
		{
			return new MapTraceResponse(this);
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600D818 RID: 55320 RVA: 0x001FC163 File Offset: 0x001FA363
		// (set) Token: 0x0600D819 RID: 55321 RVA: 0x001FC16B File Offset: 0x001FA36B
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

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600D81A RID: 55322 RVA: 0x001FC174 File Offset: 0x001FA374
		// (set) Token: 0x0600D81B RID: 55323 RVA: 0x001FC17C File Offset: 0x001FA37C
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

		// Token: 0x0600D81C RID: 55324 RVA: 0x001FC185 File Offset: 0x001FA385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceResponse);
		}

		// Token: 0x0600D81D RID: 55325 RVA: 0x001FC193 File Offset: 0x001FA393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x001FC1D4 File Offset: 0x001FA3D4
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

		// Token: 0x0600D81F RID: 55327 RVA: 0x001FC232 File Offset: 0x001FA432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x001FC23F File Offset: 0x001FA43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x001FC248 File Offset: 0x001FA448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x001FC2A4 File Offset: 0x001FA4A4
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

		// Token: 0x0600D823 RID: 55331 RVA: 0x001FC2FC File Offset: 0x001FA4FC
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

		// Token: 0x0600D824 RID: 55332 RVA: 0x001FC34C File Offset: 0x001FA54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x001FC358 File Offset: 0x001FA558
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
					if (num != 112U)
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

		// Token: 0x04005A13 RID: 23059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A14 RID: 23060
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005A15 RID: 23061
		private ErrorCode errorCode_;

		// Token: 0x04005A16 RID: 23062
		public const int MarkIdFieldNumber = 14;

		// Token: 0x04005A17 RID: 23063
		private int markId_;
	}
}
