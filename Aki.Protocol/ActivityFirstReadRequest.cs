using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000085 RID: 133
	[NetMessage(EMessageId.ActivityFirstReadRequest)]
	public sealed class ActivityFirstReadRequest : IMessage<ActivityFirstReadRequest>, IMessage, IEquatable<ActivityFirstReadRequest>, IDeepCloneable<ActivityFirstReadRequest>, IBufferMessage
	{
		// Token: 0x06001A21 RID: 6689 RVA: 0x0004A135 File Offset: 0x00048335
		[NullableContext(1)]
		public static ActivityFirstReadRequest Create()
		{
			return new ActivityFirstReadRequest();
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0004A13C File Offset: 0x0004833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0004A13F File Offset: 0x0004833F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityFirstReadRequest.Descriptor;
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0004A146 File Offset: 0x00048346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest()
		{
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0004A14E File Offset: 0x0004834E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest(ActivityFirstReadRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0004A173 File Offset: 0x00048373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadRequest Clone()
		{
			return new ActivityFirstReadRequest(this);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0004A17B File Offset: 0x0004837B
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0004A183 File Offset: 0x00048383
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

		// Token: 0x06001A29 RID: 6697 RVA: 0x0004A18C File Offset: 0x0004838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityFirstReadRequest);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0004A19A File Offset: 0x0004839A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityFirstReadRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0004A1C8 File Offset: 0x000483C8
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

		// Token: 0x06001A2C RID: 6700 RVA: 0x0004A207 File Offset: 0x00048407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004A214 File Offset: 0x00048414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0004A21D File Offset: 0x0004841D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0004A250 File Offset: 0x00048450
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

		// Token: 0x06001A30 RID: 6704 RVA: 0x0004A28E File Offset: 0x0004848E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityFirstReadRequest other)
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

		// Token: 0x06001A31 RID: 6705 RVA: 0x0004A2BF File Offset: 0x000484BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0004A2C8 File Offset: 0x000484C8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400223D RID: 8765
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400223E RID: 8766
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x0400223F RID: 8767
		private int activityId_;
	}
}
