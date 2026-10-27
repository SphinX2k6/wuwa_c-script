using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001115 RID: 4373
	[NetMessage(EMessageId.RoverRogueQuitRequest)]
	public sealed class RoverRogueQuitRequest : IMessage<RoverRogueQuitRequest>, IMessage, IEquatable<RoverRogueQuitRequest>, IDeepCloneable<RoverRogueQuitRequest>, IBufferMessage
	{
		// Token: 0x0601752C RID: 95532 RVA: 0x00362E53 File Offset: 0x00361053
		[NullableContext(1)]
		public static RoverRogueQuitRequest Create()
		{
			return new RoverRogueQuitRequest();
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x0601752D RID: 95533 RVA: 0x00362E5A File Offset: 0x0036105A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x0601752E RID: 95534 RVA: 0x00362E5D File Offset: 0x0036105D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601752F RID: 95535 RVA: 0x00362E64 File Offset: 0x00361064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest()
		{
		}

		// Token: 0x06017530 RID: 95536 RVA: 0x00362E6C File Offset: 0x0036106C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest(RoverRogueQuitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017531 RID: 95537 RVA: 0x00362E91 File Offset: 0x00361091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest Clone()
		{
			return new RoverRogueQuitRequest(this);
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x06017532 RID: 95538 RVA: 0x00362E99 File Offset: 0x00361099
		// (set) Token: 0x06017533 RID: 95539 RVA: 0x00362EA1 File Offset: 0x003610A1
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

		// Token: 0x06017534 RID: 95540 RVA: 0x00362EAA File Offset: 0x003610AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueQuitRequest);
		}

		// Token: 0x06017535 RID: 95541 RVA: 0x00362EB8 File Offset: 0x003610B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueQuitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017536 RID: 95542 RVA: 0x00362EE8 File Offset: 0x003610E8
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

		// Token: 0x06017537 RID: 95543 RVA: 0x00362F27 File Offset: 0x00361127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017538 RID: 95544 RVA: 0x00362F34 File Offset: 0x00361134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017539 RID: 95545 RVA: 0x00362F3D File Offset: 0x0036113D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601753A RID: 95546 RVA: 0x00362F70 File Offset: 0x00361170
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

		// Token: 0x0601753B RID: 95547 RVA: 0x00362FAE File Offset: 0x003611AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueQuitRequest other)
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

		// Token: 0x0601753C RID: 95548 RVA: 0x00362FDF File Offset: 0x003611DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601753D RID: 95549 RVA: 0x00362FE8 File Offset: 0x003611E8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008AB4 RID: 35508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AB5 RID: 35509
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04008AB6 RID: 35510
		private int activityId_;
	}
}
