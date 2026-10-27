using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078F RID: 1935
	[NetMessage(EMessageId.HonamiStoryMascotRewardRequest)]
	public sealed class HonamiStoryMascotRewardRequest : IMessage<HonamiStoryMascotRewardRequest>, IMessage, IEquatable<HonamiStoryMascotRewardRequest>, IDeepCloneable<HonamiStoryMascotRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AEB5 RID: 44725 RVA: 0x001A3AD1 File Offset: 0x001A1CD1
		[NullableContext(1)]
		public static HonamiStoryMascotRewardRequest Create()
		{
			return new HonamiStoryMascotRewardRequest();
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x001A3AD8 File Offset: 0x001A1CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x001A3ADB File Offset: 0x001A1CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x001A3AE2 File Offset: 0x001A1CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest()
		{
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x001A3AEA File Offset: 0x001A1CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest(HonamiStoryMascotRewardRequest other) : this()
		{
			this.honamiStoryMascotId_ = other.honamiStoryMascotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x001A3B0F File Offset: 0x001A1D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest Clone()
		{
			return new HonamiStoryMascotRewardRequest(this);
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x001A3B17 File Offset: 0x001A1D17
		// (set) Token: 0x0600AEBC RID: 44732 RVA: 0x001A3B1F File Offset: 0x001A1D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryMascotId
		{
			get
			{
				return this.honamiStoryMascotId_;
			}
			set
			{
				this.honamiStoryMascotId_ = value;
			}
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x001A3B28 File Offset: 0x001A1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotRewardRequest);
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x001A3B36 File Offset: 0x001A1D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotRewardRequest other)
		{
			return other != null && (other == this || (this.HonamiStoryMascotId == other.HonamiStoryMascotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x001A3B64 File Offset: 0x001A1D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryMascotId != 0)
			{
				num ^= this.HonamiStoryMascotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x001A3BA3 File Offset: 0x001A1DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x001A3BB0 File Offset: 0x001A1DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x001A3BB9 File Offset: 0x001A1DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryMascotId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HonamiStoryMascotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x001A3BEC File Offset: 0x001A1DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryMascotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryMascotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x001A3C2A File Offset: 0x001A1E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryMascotId != 0)
			{
				this.HonamiStoryMascotId = other.HonamiStoryMascotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x001A3C5B File Offset: 0x001A1E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x001A3C64 File Offset: 0x001A1E64
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HonamiStoryMascotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004ECF RID: 20175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED0 RID: 20176
		public const int HonamiStoryMascotIdFieldNumber = 13;

		// Token: 0x04004ED1 RID: 20177
		private int honamiStoryMascotId_;
	}
}
