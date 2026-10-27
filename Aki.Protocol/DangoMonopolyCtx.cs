using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000384 RID: 900
	public sealed class DangoMonopolyCtx : IMessage<DangoMonopolyCtx>, IMessage, IEquatable<DangoMonopolyCtx>, IDeepCloneable<DangoMonopolyCtx>, IBufferMessage
	{
		// Token: 0x0600591D RID: 22813 RVA: 0x000D92B1 File Offset: 0x000D74B1
		[NullableContext(1)]
		public static DangoMonopolyCtx Create()
		{
			return new DangoMonopolyCtx();
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x000D92B8 File Offset: 0x000D74B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x0600591F RID: 22815 RVA: 0x000D92BB File Offset: 0x000D74BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyCtx.Descriptor;
			}
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x000D92C2 File Offset: 0x000D74C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx()
		{
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x000D92CA File Offset: 0x000D74CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx(DangoMonopolyCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x000D92EF File Offset: 0x000D74EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx Clone()
		{
			return new DangoMonopolyCtx(this);
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x000D92F7 File Offset: 0x000D74F7
		// (set) Token: 0x06005924 RID: 22820 RVA: 0x000D92FF File Offset: 0x000D74FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x000D9308 File Offset: 0x000D7508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyCtx);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x000D9316 File Offset: 0x000D7516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x000D9344 File Offset: 0x000D7544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x000D9383 File Offset: 0x000D7583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x000D9390 File Offset: 0x000D7590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x000D9399 File Offset: 0x000D7599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x000D93CC File Offset: 0x000D75CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x000D940A File Offset: 0x000D760A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x000D943B File Offset: 0x000D763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x000D9444 File Offset: 0x000D7644
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400354F RID: 13647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003550 RID: 13648
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04003551 RID: 13649
		private int activityId_;
	}
}
