using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013ED RID: 5101
	[NetMessage(EMessageId.TrackMoonTargetRewardRequest)]
	public sealed class TrackMoonTargetRewardRequest : IMessage<TrackMoonTargetRewardRequest>, IMessage, IEquatable<TrackMoonTargetRewardRequest>, IDeepCloneable<TrackMoonTargetRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B08D RID: 110733 RVA: 0x003EA4DC File Offset: 0x003E86DC
		[NullableContext(1)]
		public static TrackMoonTargetRewardRequest Create()
		{
			return new TrackMoonTargetRewardRequest();
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x0601B08E RID: 110734 RVA: 0x003EA4E3 File Offset: 0x003E86E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x0601B08F RID: 110735 RVA: 0x003EA4E6 File Offset: 0x003E86E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B090 RID: 110736 RVA: 0x003EA4ED File Offset: 0x003E86ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest()
		{
		}

		// Token: 0x0601B091 RID: 110737 RVA: 0x003EA4F5 File Offset: 0x003E86F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest(TrackMoonTargetRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B092 RID: 110738 RVA: 0x003EA51A File Offset: 0x003E871A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest Clone()
		{
			return new TrackMoonTargetRewardRequest(this);
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x0601B093 RID: 110739 RVA: 0x003EA522 File Offset: 0x003E8722
		// (set) Token: 0x0601B094 RID: 110740 RVA: 0x003EA52A File Offset: 0x003E872A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601B095 RID: 110741 RVA: 0x003EA533 File Offset: 0x003E8733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetRewardRequest);
		}

		// Token: 0x0601B096 RID: 110742 RVA: 0x003EA541 File Offset: 0x003E8741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B097 RID: 110743 RVA: 0x003EA570 File Offset: 0x003E8770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B098 RID: 110744 RVA: 0x003EA5AF File Offset: 0x003E87AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B099 RID: 110745 RVA: 0x003EA5BC File Offset: 0x003E87BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B09A RID: 110746 RVA: 0x003EA5C5 File Offset: 0x003E87C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B09B RID: 110747 RVA: 0x003EA5F8 File Offset: 0x003E87F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B09C RID: 110748 RVA: 0x003EA636 File Offset: 0x003E8836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTargetRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B09D RID: 110749 RVA: 0x003EA667 File Offset: 0x003E8867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B09E RID: 110750 RVA: 0x003EA670 File Offset: 0x003E8870
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C7E RID: 40062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C7F RID: 40063
		public const int IdFieldNumber = 3;

		// Token: 0x04009C80 RID: 40064
		private int id_;
	}
}
