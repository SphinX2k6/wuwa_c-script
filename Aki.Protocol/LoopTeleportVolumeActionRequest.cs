using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000948 RID: 2376
	[NetMessage(EMessageId.LoopTeleportVolumeActionRequest)]
	public sealed class LoopTeleportVolumeActionRequest : IMessage<LoopTeleportVolumeActionRequest>, IMessage, IEquatable<LoopTeleportVolumeActionRequest>, IDeepCloneable<LoopTeleportVolumeActionRequest>, IBufferMessage
	{
		// Token: 0x0600D1CF RID: 53711 RVA: 0x001EF41D File Offset: 0x001ED61D
		[NullableContext(1)]
		public static LoopTeleportVolumeActionRequest Create()
		{
			return new LoopTeleportVolumeActionRequest();
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600D1D0 RID: 53712 RVA: 0x001EF424 File Offset: 0x001ED624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600D1D1 RID: 53713 RVA: 0x001EF427 File Offset: 0x001ED627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoopTeleportVolumeActionRequest.Descriptor;
			}
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x001EF42E File Offset: 0x001ED62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest()
		{
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x001EF436 File Offset: 0x001ED636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest(LoopTeleportVolumeActionRequest other) : this()
		{
			this.volumeId_ = other.volumeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x001EF45B File Offset: 0x001ED65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest Clone()
		{
			return new LoopTeleportVolumeActionRequest(this);
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x001EF463 File Offset: 0x001ED663
		// (set) Token: 0x0600D1D6 RID: 53718 RVA: 0x001EF46B File Offset: 0x001ED66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VolumeId
		{
			get
			{
				return this.volumeId_;
			}
			set
			{
				this.volumeId_ = value;
			}
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x001EF474 File Offset: 0x001ED674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoopTeleportVolumeActionRequest);
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x001EF482 File Offset: 0x001ED682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoopTeleportVolumeActionRequest other)
		{
			return other != null && (other == this || (this.VolumeId == other.VolumeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x001EF4B0 File Offset: 0x001ED6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VolumeId != 0)
			{
				num ^= this.VolumeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x001EF4EF File Offset: 0x001ED6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x001EF4FC File Offset: 0x001ED6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x001EF505 File Offset: 0x001ED705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VolumeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.VolumeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x001EF538 File Offset: 0x001ED738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VolumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VolumeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x001EF576 File Offset: 0x001ED776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoopTeleportVolumeActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VolumeId != 0)
			{
				this.VolumeId = other.VolumeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x001EF5A7 File Offset: 0x001ED7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x001EF5B0 File Offset: 0x001ED7B0
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
					this.VolumeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058BF RID: 22719
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C0 RID: 22720
		public const int VolumeIdFieldNumber = 12;

		// Token: 0x040058C1 RID: 22721
		private int volumeId_;
	}
}
