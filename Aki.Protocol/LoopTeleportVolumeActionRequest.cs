using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000959 RID: 2393
	[NetMessage(EMessageId.LoopTeleportVolumeActionRequest)]
	public sealed class LoopTeleportVolumeActionRequest : IMessage<LoopTeleportVolumeActionRequest>, IMessage, IEquatable<LoopTeleportVolumeActionRequest>, IDeepCloneable<LoopTeleportVolumeActionRequest>, IBufferMessage
	{
		// Token: 0x0600D2E9 RID: 53993 RVA: 0x001F1605 File Offset: 0x001EF805
		[NullableContext(1)]
		public static LoopTeleportVolumeActionRequest Create()
		{
			return new LoopTeleportVolumeActionRequest();
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x001F160C File Offset: 0x001EF80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0600D2EB RID: 53995 RVA: 0x001F160F File Offset: 0x001EF80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoopTeleportVolumeActionRequest.Descriptor;
			}
		}

		// Token: 0x0600D2EC RID: 53996 RVA: 0x001F1616 File Offset: 0x001EF816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest()
		{
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x001F161E File Offset: 0x001EF81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest(LoopTeleportVolumeActionRequest other) : this()
		{
			this.volumeId_ = other.volumeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x001F1643 File Offset: 0x001EF843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionRequest Clone()
		{
			return new LoopTeleportVolumeActionRequest(this);
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600D2EF RID: 53999 RVA: 0x001F164B File Offset: 0x001EF84B
		// (set) Token: 0x0600D2F0 RID: 54000 RVA: 0x001F1653 File Offset: 0x001EF853
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

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x001F165C File Offset: 0x001EF85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoopTeleportVolumeActionRequest);
		}

		// Token: 0x0600D2F2 RID: 54002 RVA: 0x001F166A File Offset: 0x001EF86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoopTeleportVolumeActionRequest other)
		{
			return other != null && (other == this || (this.VolumeId == other.VolumeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x001F1698 File Offset: 0x001EF898
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

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x001F16D7 File Offset: 0x001EF8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x001F16E4 File Offset: 0x001EF8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x001F16ED File Offset: 0x001EF8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VolumeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.VolumeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x001F1720 File Offset: 0x001EF920
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

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x001F175E File Offset: 0x001EF95E
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

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x001F178F File Offset: 0x001EF98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2FA RID: 54010 RVA: 0x001F1798 File Offset: 0x001EF998
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VolumeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058B6 RID: 22710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058B7 RID: 22711
		public const int VolumeIdFieldNumber = 15;

		// Token: 0x040058B8 RID: 22712
		private int volumeId_;
	}
}
