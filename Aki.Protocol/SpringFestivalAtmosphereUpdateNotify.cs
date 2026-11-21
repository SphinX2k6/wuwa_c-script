using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E5 RID: 4837
	[NetMessage(EMessageId.SpringFestivalAtmosphereUpdateNotify)]
	public sealed class SpringFestivalAtmosphereUpdateNotify : IMessage<SpringFestivalAtmosphereUpdateNotify>, IMessage, IEquatable<SpringFestivalAtmosphereUpdateNotify>, IDeepCloneable<SpringFestivalAtmosphereUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019D08 RID: 105736 RVA: 0x003C4471 File Offset: 0x003C2671
		[NullableContext(1)]
		public static SpringFestivalAtmosphereUpdateNotify Create()
		{
			return new SpringFestivalAtmosphereUpdateNotify();
		}

		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x06019D09 RID: 105737 RVA: 0x003C4478 File Offset: 0x003C2678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x06019D0A RID: 105738 RVA: 0x003C447B File Offset: 0x003C267B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAtmosphereUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019D0B RID: 105739 RVA: 0x003C4482 File Offset: 0x003C2682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify()
		{
		}

		// Token: 0x06019D0C RID: 105740 RVA: 0x003C448A File Offset: 0x003C268A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify(SpringFestivalAtmosphereUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.atmosphere_ = other.atmosphere_;
			this.atmosphereLevel_ = other.atmosphereLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D0D RID: 105741 RVA: 0x003C44C7 File Offset: 0x003C26C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAtmosphereUpdateNotify Clone()
		{
			return new SpringFestivalAtmosphereUpdateNotify(this);
		}

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x06019D0E RID: 105742 RVA: 0x003C44CF File Offset: 0x003C26CF
		// (set) Token: 0x06019D0F RID: 105743 RVA: 0x003C44D7 File Offset: 0x003C26D7
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

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x06019D10 RID: 105744 RVA: 0x003C44E0 File Offset: 0x003C26E0
		// (set) Token: 0x06019D11 RID: 105745 RVA: 0x003C44E8 File Offset: 0x003C26E8
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

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x06019D12 RID: 105746 RVA: 0x003C44F1 File Offset: 0x003C26F1
		// (set) Token: 0x06019D13 RID: 105747 RVA: 0x003C44F9 File Offset: 0x003C26F9
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

		// Token: 0x06019D14 RID: 105748 RVA: 0x003C4502 File Offset: 0x003C2702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAtmosphereUpdateNotify);
		}

		// Token: 0x06019D15 RID: 105749 RVA: 0x003C4510 File Offset: 0x003C2710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAtmosphereUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Atmosphere == other.Atmosphere && this.AtmosphereLevel == other.AtmosphereLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D16 RID: 105750 RVA: 0x003C456C File Offset: 0x003C276C
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

		// Token: 0x06019D17 RID: 105751 RVA: 0x003C45DD File Offset: 0x003C27DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D18 RID: 105752 RVA: 0x003C45EA File Offset: 0x003C27EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D19 RID: 105753 RVA: 0x003C45F4 File Offset: 0x003C27F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AtmosphereLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AtmosphereLevel);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Atmosphere);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D1A RID: 105754 RVA: 0x003C466C File Offset: 0x003C286C
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

		// Token: 0x06019D1B RID: 105755 RVA: 0x003C46DC File Offset: 0x003C28DC
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

		// Token: 0x06019D1C RID: 105756 RVA: 0x003C4740 File Offset: 0x003C2940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D1D RID: 105757 RVA: 0x003C474C File Offset: 0x003C294C
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 88U)
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

		// Token: 0x04009869 RID: 39017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400986A RID: 39018
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400986B RID: 39019
		private int activityId_;

		// Token: 0x0400986C RID: 39020
		public const int AtmosphereFieldNumber = 11;

		// Token: 0x0400986D RID: 39021
		private int atmosphere_;

		// Token: 0x0400986E RID: 39022
		public const int AtmosphereLevelFieldNumber = 6;

		// Token: 0x0400986F RID: 39023
		private int atmosphereLevel_;
	}
}
