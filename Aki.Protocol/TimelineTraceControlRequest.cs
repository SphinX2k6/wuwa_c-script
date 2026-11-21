using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E2 RID: 5090
	[NetMessage(EMessageId.TimelineTraceControlRequest)]
	public sealed class TimelineTraceControlRequest : IMessage<TimelineTraceControlRequest>, IMessage, IEquatable<TimelineTraceControlRequest>, IDeepCloneable<TimelineTraceControlRequest>, IBufferMessage
	{
		// Token: 0x0601B13B RID: 110907 RVA: 0x003F11D0 File Offset: 0x003EF3D0
		[NullableContext(1)]
		public static TimelineTraceControlRequest Create()
		{
			return new TimelineTraceControlRequest();
		}

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x0601B13C RID: 110908 RVA: 0x003F11D7 File Offset: 0x003EF3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x0601B13D RID: 110909 RVA: 0x003F11DA File Offset: 0x003EF3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceControlRequest.Descriptor;
			}
		}

		// Token: 0x0601B13E RID: 110910 RVA: 0x003F11E1 File Offset: 0x003EF3E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest()
		{
		}

		// Token: 0x0601B13F RID: 110911 RVA: 0x003F11E9 File Offset: 0x003EF3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest(TimelineTraceControlRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.forward_ = other.forward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B140 RID: 110912 RVA: 0x003F121A File Offset: 0x003EF41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest Clone()
		{
			return new TimelineTraceControlRequest(this);
		}

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x0601B141 RID: 110913 RVA: 0x003F1222 File Offset: 0x003EF422
		// (set) Token: 0x0601B142 RID: 110914 RVA: 0x003F122A File Offset: 0x003EF42A
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

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x0601B143 RID: 110915 RVA: 0x003F1233 File Offset: 0x003EF433
		// (set) Token: 0x0601B144 RID: 110916 RVA: 0x003F123B File Offset: 0x003EF43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Forward
		{
			get
			{
				return this.forward_;
			}
			set
			{
				this.forward_ = value;
			}
		}

		// Token: 0x0601B145 RID: 110917 RVA: 0x003F1244 File Offset: 0x003EF444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceControlRequest);
		}

		// Token: 0x0601B146 RID: 110918 RVA: 0x003F1252 File Offset: 0x003EF452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceControlRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Forward == other.Forward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B147 RID: 110919 RVA: 0x003F1290 File Offset: 0x003EF490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Forward)
			{
				num ^= this.Forward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B148 RID: 110920 RVA: 0x003F12E8 File Offset: 0x003EF4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B149 RID: 110921 RVA: 0x003F12F5 File Offset: 0x003EF4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B14A RID: 110922 RVA: 0x003F1300 File Offset: 0x003EF500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Forward)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Forward);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B14B RID: 110923 RVA: 0x003F135C File Offset: 0x003EF55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Forward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B14C RID: 110924 RVA: 0x003F13A8 File Offset: 0x003EF5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceControlRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Forward)
			{
				this.Forward = other.Forward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B14D RID: 110925 RVA: 0x003F13F8 File Offset: 0x003EF5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B14E RID: 110926 RVA: 0x003F1404 File Offset: 0x003EF604
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Forward = input.ReadBool();
				}
			}
		}

		// Token: 0x04009E1E RID: 40478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E1F RID: 40479
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04009E20 RID: 40480
		private long entityId_;

		// Token: 0x04009E21 RID: 40481
		public const int ForwardFieldNumber = 7;

		// Token: 0x04009E22 RID: 40482
		private bool forward_;
	}
}
