using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098A RID: 2442
	[NetMessage(EMessageId.MapTraceRequest)]
	public sealed class MapTraceRequest : IMessage<MapTraceRequest>, IMessage, IEquatable<MapTraceRequest>, IDeepCloneable<MapTraceRequest>, IBufferMessage
	{
		// Token: 0x0600D6E6 RID: 55014 RVA: 0x001F9D49 File Offset: 0x001F7F49
		[NullableContext(1)]
		public static MapTraceRequest Create()
		{
			return new MapTraceRequest();
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x001F9D50 File Offset: 0x001F7F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x001F9D53 File Offset: 0x001F7F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x001F9D5A File Offset: 0x001F7F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest()
		{
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x001F9D62 File Offset: 0x001F7F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest(MapTraceRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6EB RID: 55019 RVA: 0x001F9D87 File Offset: 0x001F7F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceRequest Clone()
		{
			return new MapTraceRequest(this);
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600D6EC RID: 55020 RVA: 0x001F9D8F File Offset: 0x001F7F8F
		// (set) Token: 0x0600D6ED RID: 55021 RVA: 0x001F9D97 File Offset: 0x001F7F97
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

		// Token: 0x0600D6EE RID: 55022 RVA: 0x001F9DA0 File Offset: 0x001F7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceRequest);
		}

		// Token: 0x0600D6EF RID: 55023 RVA: 0x001F9DAE File Offset: 0x001F7FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6F0 RID: 55024 RVA: 0x001F9DDC File Offset: 0x001F7FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x001F9E1B File Offset: 0x001F801B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6F2 RID: 55026 RVA: 0x001F9E28 File Offset: 0x001F8028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x001F9E31 File Offset: 0x001F8031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6F4 RID: 55028 RVA: 0x001F9E64 File Offset: 0x001F8064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x001F9EA2 File Offset: 0x001F80A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x001F9ED3 File Offset: 0x001F80D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x001F9EDC File Offset: 0x001F80DC
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
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A19 RID: 23065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A1A RID: 23066
		public const int MarkIdFieldNumber = 11;

		// Token: 0x04005A1B RID: 23067
		private int markId_;
	}
}
