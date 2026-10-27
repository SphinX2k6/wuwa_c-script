using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000796 RID: 1942
	[NetMessage(EMessageId.HonamiStoryPollutionUpdateNotify)]
	public sealed class HonamiStoryPollutionUpdateNotify : IMessage<HonamiStoryPollutionUpdateNotify>, IMessage, IEquatable<HonamiStoryPollutionUpdateNotify>, IDeepCloneable<HonamiStoryPollutionUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AF34 RID: 44852 RVA: 0x001A4982 File Offset: 0x001A2B82
		[NullableContext(1)]
		public static HonamiStoryPollutionUpdateNotify Create()
		{
			return new HonamiStoryPollutionUpdateNotify();
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x001A4989 File Offset: 0x001A2B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x001A498C File Offset: 0x001A2B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPollutionUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x001A4993 File Offset: 0x001A2B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify()
		{
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x001A499B File Offset: 0x001A2B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify(HonamiStoryPollutionUpdateNotify other) : this()
		{
			this.pollutionLevel_ = other.pollutionLevel_;
			this.pollutionStartTime_ = other.pollutionStartTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x001A49CC File Offset: 0x001A2BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify Clone()
		{
			return new HonamiStoryPollutionUpdateNotify(this);
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x001A49D4 File Offset: 0x001A2BD4
		// (set) Token: 0x0600AF3B RID: 44859 RVA: 0x001A49DC File Offset: 0x001A2BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PollutionLevel
		{
			get
			{
				return this.pollutionLevel_;
			}
			set
			{
				this.pollutionLevel_ = value;
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x001A49E5 File Offset: 0x001A2BE5
		// (set) Token: 0x0600AF3D RID: 44861 RVA: 0x001A49ED File Offset: 0x001A2BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PollutionStartTime
		{
			get
			{
				return this.pollutionStartTime_;
			}
			set
			{
				this.pollutionStartTime_ = value;
			}
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x001A49F6 File Offset: 0x001A2BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPollutionUpdateNotify);
		}

		// Token: 0x0600AF3F RID: 44863 RVA: 0x001A4A04 File Offset: 0x001A2C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPollutionUpdateNotify other)
		{
			return other != null && (other == this || (this.PollutionLevel == other.PollutionLevel && this.PollutionStartTime == other.PollutionStartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x001A4A44 File Offset: 0x001A2C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PollutionLevel != 0)
			{
				num ^= this.PollutionLevel.GetHashCode();
			}
			if (this.PollutionStartTime != 0L)
			{
				num ^= this.PollutionStartTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x001A4A9C File Offset: 0x001A2C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x001A4AA9 File Offset: 0x001A2CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x001A4AB4 File Offset: 0x001A2CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PollutionStartTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.PollutionStartTime);
			}
			if (this.PollutionLevel != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PollutionLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x001A4B10 File Offset: 0x001A2D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PollutionLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PollutionLevel);
			}
			if (this.PollutionStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PollutionStartTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x001A4B68 File Offset: 0x001A2D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPollutionUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PollutionLevel != 0)
			{
				this.PollutionLevel = other.PollutionLevel;
			}
			if (other.PollutionStartTime != 0L)
			{
				this.PollutionStartTime = other.PollutionStartTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x001A4BB8 File Offset: 0x001A2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF47 RID: 44871 RVA: 0x001A4BC4 File Offset: 0x001A2DC4
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PollutionLevel = input.ReadInt32();
					}
				}
				else
				{
					this.PollutionStartTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004EE8 RID: 20200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EE9 RID: 20201
		public const int PollutionLevelFieldNumber = 12;

		// Token: 0x04004EEA RID: 20202
		private int pollutionLevel_;

		// Token: 0x04004EEB RID: 20203
		public const int PollutionStartTimeFieldNumber = 9;

		// Token: 0x04004EEC RID: 20204
		private long pollutionStartTime_;
	}
}
