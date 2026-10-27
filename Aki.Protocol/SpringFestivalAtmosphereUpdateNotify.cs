using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001276 RID: 4726
	[NetMessage(EMessageId.SpringFestivalAtmosphereUpdateNotify)]
	public sealed class SpringFestivalAtmosphereUpdateNotify : IMessage<SpringFestivalAtmosphereUpdateNotify>, IMessage, IEquatable<SpringFestivalAtmosphereUpdateNotify>, IDeepCloneable<SpringFestivalAtmosphereUpdateNotify>, IBufferMessage
	{
		// Token: 0x060192D2 RID: 103122 RVA: 0x003A9D1C File Offset: 0x003A7F1C
		[NullableContext(1)]
		public static SpringFestivalAtmosphereUpdateNotify Create()
		{
			return new SpringFestivalAtmosphereUpdateNotify();
		}

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x060192D3 RID: 103123 RVA: 0x003A9D23 File Offset: 0x003A7F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x060192D4 RID: 103124 RVA: 0x003A9D26 File Offset: 0x003A7F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060192D5 RID: 103125 RVA: 0x003A9D2D File Offset: 0x003A7F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify()
		{
		}

		// Token: 0x060192D6 RID: 103126 RVA: 0x003A9D35 File Offset: 0x003A7F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify(SpringFestivalAtmosphereUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.atmosphere_ = other.atmosphere_;
			this.atmosphereLevel_ = other.atmosphereLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192D7 RID: 103127 RVA: 0x003A9D72 File Offset: 0x003A7F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify Clone()
		{
			return new SpringFestivalAtmosphereUpdateNotify(this);
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x060192D8 RID: 103128 RVA: 0x003A9D7A File Offset: 0x003A7F7A
		// (set) Token: 0x060192D9 RID: 103129 RVA: 0x003A9D82 File Offset: 0x003A7F82
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

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x060192DA RID: 103130 RVA: 0x003A9D8B File Offset: 0x003A7F8B
		// (set) Token: 0x060192DB RID: 103131 RVA: 0x003A9D93 File Offset: 0x003A7F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Atmosphere
		{
			get
			{
				return this.atmosphere_;
			}
			set
			{
				this.atmosphere_ = value;
			}
		}

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x060192DC RID: 103132 RVA: 0x003A9D9C File Offset: 0x003A7F9C
		// (set) Token: 0x060192DD RID: 103133 RVA: 0x003A9DA4 File Offset: 0x003A7FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AtmosphereLevel
		{
			get
			{
				return this.atmosphereLevel_;
			}
			set
			{
				this.atmosphereLevel_ = value;
			}
		}

		// Token: 0x060192DE RID: 103134 RVA: 0x003A9DAD File Offset: 0x003A7FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereUpdateNotify);
		}

		// Token: 0x060192DF RID: 103135 RVA: 0x003A9DBC File Offset: 0x003A7FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Atmosphere == other.Atmosphere && this.AtmosphereLevel == other.AtmosphereLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192E0 RID: 103136 RVA: 0x003A9E18 File Offset: 0x003A8018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			if (this.AtmosphereLevel != 0)
			{
				num ^= this.AtmosphereLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192E1 RID: 103137 RVA: 0x003A9E89 File Offset: 0x003A8089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192E2 RID: 103138 RVA: 0x003A9E96 File Offset: 0x003A8096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192E3 RID: 103139 RVA: 0x003A9EA0 File Offset: 0x003A80A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AtmosphereLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AtmosphereLevel);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Atmosphere);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192E4 RID: 103140 RVA: 0x003A9F18 File Offset: 0x003A8118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			if (this.AtmosphereLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtmosphereLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192E5 RID: 103141 RVA: 0x003A9F88 File Offset: 0x003A8188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAtmosphereUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			if (other.AtmosphereLevel != 0)
			{
				this.AtmosphereLevel = other.AtmosphereLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192E6 RID: 103142 RVA: 0x003A9FEC File Offset: 0x003A81EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192E7 RID: 103143 RVA: 0x003A9FF8 File Offset: 0x003A81F8
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
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Atmosphere = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.AtmosphereLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400943F RID: 37951
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009440 RID: 37952
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04009441 RID: 37953
		private int activityId_;

		// Token: 0x04009442 RID: 37954
		public const int AtmosphereFieldNumber = 5;

		// Token: 0x04009443 RID: 37955
		private int atmosphere_;

		// Token: 0x04009444 RID: 37956
		public const int AtmosphereLevelFieldNumber = 2;

		// Token: 0x04009445 RID: 37957
		private int atmosphereLevel_;
	}
}
