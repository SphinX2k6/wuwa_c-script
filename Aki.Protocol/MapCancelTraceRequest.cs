using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000973 RID: 2419
	[NetMessage(EMessageId.MapCancelTraceRequest)]
	public sealed class MapCancelTraceRequest : IMessage<MapCancelTraceRequest>, IMessage, IEquatable<MapCancelTraceRequest>, IDeepCloneable<MapCancelTraceRequest>, IBufferMessage
	{
		// Token: 0x0600D51A RID: 54554 RVA: 0x001F5E91 File Offset: 0x001F4091
		[NullableContext(1)]
		public static MapCancelTraceRequest Create()
		{
			return new MapCancelTraceRequest();
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600D51B RID: 54555 RVA: 0x001F5E98 File Offset: 0x001F4098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600D51C RID: 54556 RVA: 0x001F5E9B File Offset: 0x001F409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapCancelTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x001F5EA2 File Offset: 0x001F40A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest()
		{
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x001F5EAA File Offset: 0x001F40AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest(MapCancelTraceRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x001F5ECF File Offset: 0x001F40CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCancelTraceRequest Clone()
		{
			return new MapCancelTraceRequest(this);
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600D520 RID: 54560 RVA: 0x001F5ED7 File Offset: 0x001F40D7
		// (set) Token: 0x0600D521 RID: 54561 RVA: 0x001F5EDF File Offset: 0x001F40DF
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

		// Token: 0x0600D522 RID: 54562 RVA: 0x001F5EE8 File Offset: 0x001F40E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapCancelTraceRequest);
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x001F5EF6 File Offset: 0x001F40F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapCancelTraceRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x001F5F24 File Offset: 0x001F4124
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

		// Token: 0x0600D525 RID: 54565 RVA: 0x001F5F63 File Offset: 0x001F4163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x001F5F70 File Offset: 0x001F4170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x001F5F79 File Offset: 0x001F4179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x001F5FAC File Offset: 0x001F41AC
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

		// Token: 0x0600D529 RID: 54569 RVA: 0x001F5FEA File Offset: 0x001F41EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapCancelTraceRequest other)
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

		// Token: 0x0600D52A RID: 54570 RVA: 0x001F601B File Offset: 0x001F421B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x001F6024 File Offset: 0x001F4224
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005996 RID: 22934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005997 RID: 22935
		public const int MarkIdFieldNumber = 2;

		// Token: 0x04005998 RID: 22936
		private int markId_;
	}
}
