using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001111 RID: 4369
	[NetMessage(EMessageId.RoverRogueLootInfoRequest)]
	public sealed class RoverRogueLootInfoRequest : IMessage<RoverRogueLootInfoRequest>, IMessage, IEquatable<RoverRogueLootInfoRequest>, IDeepCloneable<RoverRogueLootInfoRequest>, IBufferMessage
	{
		// Token: 0x060174DA RID: 95450 RVA: 0x003623CA File Offset: 0x003605CA
		[NullableContext(1)]
		public static RoverRogueLootInfoRequest Create()
		{
			return new RoverRogueLootInfoRequest();
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x060174DB RID: 95451 RVA: 0x003623D1 File Offset: 0x003605D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x060174DC RID: 95452 RVA: 0x003623D4 File Offset: 0x003605D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfoRequest.Descriptor;
			}
		}

		// Token: 0x060174DD RID: 95453 RVA: 0x003623DB File Offset: 0x003605DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest()
		{
		}

		// Token: 0x060174DE RID: 95454 RVA: 0x003623E3 File Offset: 0x003605E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest(RoverRogueLootInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174DF RID: 95455 RVA: 0x00362408 File Offset: 0x00360608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoRequest Clone()
		{
			return new RoverRogueLootInfoRequest(this);
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x060174E0 RID: 95456 RVA: 0x00362410 File Offset: 0x00360610
		// (set) Token: 0x060174E1 RID: 95457 RVA: 0x00362418 File Offset: 0x00360618
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

		// Token: 0x060174E2 RID: 95458 RVA: 0x00362421 File Offset: 0x00360621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfoRequest);
		}

		// Token: 0x060174E3 RID: 95459 RVA: 0x0036242F File Offset: 0x0036062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174E4 RID: 95460 RVA: 0x00362460 File Offset: 0x00360660
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

		// Token: 0x060174E5 RID: 95461 RVA: 0x0036249F File Offset: 0x0036069F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174E6 RID: 95462 RVA: 0x003624AC File Offset: 0x003606AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174E7 RID: 95463 RVA: 0x003624B5 File Offset: 0x003606B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174E8 RID: 95464 RVA: 0x003624E8 File Offset: 0x003606E8
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

		// Token: 0x060174E9 RID: 95465 RVA: 0x00362526 File Offset: 0x00360726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfoRequest other)
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

		// Token: 0x060174EA RID: 95466 RVA: 0x00362557 File Offset: 0x00360757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174EB RID: 95467 RVA: 0x00362560 File Offset: 0x00360760
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A9E RID: 35486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A9F RID: 35487
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04008AA0 RID: 35488
		private int activityId_;
	}
}
