using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E4 RID: 5092
	[NetMessage(EMessageId.TimelineTraceExitRequest)]
	public sealed class TimelineTraceExitRequest : IMessage<TimelineTraceExitRequest>, IMessage, IEquatable<TimelineTraceExitRequest>, IDeepCloneable<TimelineTraceExitRequest>, IBufferMessage
	{
		// Token: 0x0601B163 RID: 110947 RVA: 0x003F16F8 File Offset: 0x003EF8F8
		[NullableContext(1)]
		public static TimelineTraceExitRequest Create()
		{
			return new TimelineTraceExitRequest();
		}

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x0601B164 RID: 110948 RVA: 0x003F16FF File Offset: 0x003EF8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BBA RID: 23482
		// (get) Token: 0x0601B165 RID: 110949 RVA: 0x003F1702 File Offset: 0x003EF902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceExitRequest.Descriptor;
			}
		}

		// Token: 0x0601B166 RID: 110950 RVA: 0x003F1709 File Offset: 0x003EF909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest()
		{
		}

		// Token: 0x0601B167 RID: 110951 RVA: 0x003F1711 File Offset: 0x003EF911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest(TimelineTraceExitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B168 RID: 110952 RVA: 0x003F1736 File Offset: 0x003EF936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest Clone()
		{
			return new TimelineTraceExitRequest(this);
		}

		// Token: 0x17005BBB RID: 23483
		// (get) Token: 0x0601B169 RID: 110953 RVA: 0x003F173E File Offset: 0x003EF93E
		// (set) Token: 0x0601B16A RID: 110954 RVA: 0x003F1746 File Offset: 0x003EF946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0601B16B RID: 110955 RVA: 0x003F174F File Offset: 0x003EF94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceExitRequest);
		}

		// Token: 0x0601B16C RID: 110956 RVA: 0x003F175D File Offset: 0x003EF95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceExitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B16D RID: 110957 RVA: 0x003F178C File Offset: 0x003EF98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B16E RID: 110958 RVA: 0x003F17CB File Offset: 0x003EF9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x003F17D8 File Offset: 0x003EF9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B170 RID: 110960 RVA: 0x003F17E1 File Offset: 0x003EF9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B171 RID: 110961 RVA: 0x003F1814 File Offset: 0x003EFA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B172 RID: 110962 RVA: 0x003F1852 File Offset: 0x003EFA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceExitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B173 RID: 110963 RVA: 0x003F1883 File Offset: 0x003EFA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B174 RID: 110964 RVA: 0x003F188C File Offset: 0x003EFA8C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009E28 RID: 40488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E29 RID: 40489
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04009E2A RID: 40490
		private long entityId_;
	}
}
