using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001460 RID: 5216
	[NetMessage(EMessageId.TrackMoonTargetRewardRequest)]
	public sealed class TrackMoonTargetRewardRequest : IMessage<TrackMoonTargetRewardRequest>, IMessage, IEquatable<TrackMoonTargetRewardRequest>, IDeepCloneable<TrackMoonTargetRewardRequest>, IBufferMessage
	{
		// Token: 0x0601BB18 RID: 113432 RVA: 0x004057B0 File Offset: 0x004039B0
		[NullableContext(1)]
		public static TrackMoonTargetRewardRequest Create()
		{
			return new TrackMoonTargetRewardRequest();
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x0601BB19 RID: 113433 RVA: 0x004057B7 File Offset: 0x004039B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x0601BB1A RID: 113434 RVA: 0x004057BA File Offset: 0x004039BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601BB1B RID: 113435 RVA: 0x004057C1 File Offset: 0x004039C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest()
		{
		}

		// Token: 0x0601BB1C RID: 113436 RVA: 0x004057C9 File Offset: 0x004039C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest(TrackMoonTargetRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB1D RID: 113437 RVA: 0x004057EE File Offset: 0x004039EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardRequest Clone()
		{
			return new TrackMoonTargetRewardRequest(this);
		}

		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x0601BB1E RID: 113438 RVA: 0x004057F6 File Offset: 0x004039F6
		// (set) Token: 0x0601BB1F RID: 113439 RVA: 0x004057FE File Offset: 0x004039FE
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

		// Token: 0x0601BB20 RID: 113440 RVA: 0x00405807 File Offset: 0x00403A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetRewardRequest);
		}

		// Token: 0x0601BB21 RID: 113441 RVA: 0x00405815 File Offset: 0x00403A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB22 RID: 113442 RVA: 0x00405844 File Offset: 0x00403A44
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

		// Token: 0x0601BB23 RID: 113443 RVA: 0x00405883 File Offset: 0x00403A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB24 RID: 113444 RVA: 0x00405890 File Offset: 0x00403A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x00405899 File Offset: 0x00403A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB26 RID: 113446 RVA: 0x004058CC File Offset: 0x00403ACC
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

		// Token: 0x0601BB27 RID: 113447 RVA: 0x0040590A File Offset: 0x00403B0A
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

		// Token: 0x0601BB28 RID: 113448 RVA: 0x0040593B File Offset: 0x00403B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB29 RID: 113449 RVA: 0x00405944 File Offset: 0x00403B44
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A0C5 RID: 41157
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0C6 RID: 41158
		public const int IdFieldNumber = 4;

		// Token: 0x0400A0C7 RID: 41159
		private int id_;
	}
}
