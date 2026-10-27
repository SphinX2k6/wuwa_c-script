using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A6 RID: 5286
	[NetMessage(EMessageId.UpdateSceneDateRequest)]
	public sealed class UpdateSceneDateRequest : IMessage<UpdateSceneDateRequest>, IMessage, IEquatable<UpdateSceneDateRequest>, IDeepCloneable<UpdateSceneDateRequest>, IBufferMessage
	{
		// Token: 0x0601BF49 RID: 114505 RVA: 0x0040A577 File Offset: 0x00408777
		[NullableContext(1)]
		public static UpdateSceneDateRequest Create()
		{
			return new UpdateSceneDateRequest();
		}

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0601BF4A RID: 114506 RVA: 0x0040A57E File Offset: 0x0040877E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0601BF4B RID: 114507 RVA: 0x0040A581 File Offset: 0x00408781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneDateRequest.Descriptor;
			}
		}

		// Token: 0x0601BF4C RID: 114508 RVA: 0x0040A588 File Offset: 0x00408788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest()
		{
		}

		// Token: 0x0601BF4D RID: 114509 RVA: 0x0040A590 File Offset: 0x00408790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest(UpdateSceneDateRequest other) : this()
		{
			this.addDays_ = other.addDays_;
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF4E RID: 114510 RVA: 0x0040A5E4 File Offset: 0x004087E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest Clone()
		{
			return new UpdateSceneDateRequest(this);
		}

		// Token: 0x17005E36 RID: 24118
		// (get) Token: 0x0601BF4F RID: 114511 RVA: 0x0040A5EC File Offset: 0x004087EC
		// (set) Token: 0x0601BF50 RID: 114512 RVA: 0x0040A5F4 File Offset: 0x004087F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AddDays
		{
			get
			{
				return this.addDays_;
			}
			set
			{
				this.addDays_ = value;
			}
		}

		// Token: 0x17005E37 RID: 24119
		// (get) Token: 0x0601BF51 RID: 114513 RVA: 0x0040A5FD File Offset: 0x004087FD
		// (set) Token: 0x0601BF52 RID: 114514 RVA: 0x0040A605 File Offset: 0x00408805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Hour
		{
			get
			{
				return this.hour_;
			}
			set
			{
				this.hour_ = value;
			}
		}

		// Token: 0x17005E38 RID: 24120
		// (get) Token: 0x0601BF53 RID: 114515 RVA: 0x0040A60E File Offset: 0x0040880E
		// (set) Token: 0x0601BF54 RID: 114516 RVA: 0x0040A616 File Offset: 0x00408816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Minute
		{
			get
			{
				return this.minute_;
			}
			set
			{
				this.minute_ = value;
			}
		}

		// Token: 0x17005E39 RID: 24121
		// (get) Token: 0x0601BF55 RID: 114517 RVA: 0x0040A61F File Offset: 0x0040881F
		// (set) Token: 0x0601BF56 RID: 114518 RVA: 0x0040A627 File Offset: 0x00408827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601BF57 RID: 114519 RVA: 0x0040A630 File Offset: 0x00408830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneDateRequest);
		}

		// Token: 0x0601BF58 RID: 114520 RVA: 0x0040A640 File Offset: 0x00408840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneDateRequest other)
		{
			return other != null && (other == this || (this.AddDays == other.AddDays && this.Hour == other.Hour && this.Minute == other.Minute && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF59 RID: 114521 RVA: 0x0040A6AC File Offset: 0x004088AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AddDays != 0U)
			{
				num ^= this.AddDays.GetHashCode();
			}
			if (this.Hour != 0)
			{
				num ^= this.Hour.GetHashCode();
			}
			if (this.Minute != 0)
			{
				num ^= this.Minute.GetHashCode();
			}
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF5A RID: 114522 RVA: 0x0040A73C File Offset: 0x0040893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF5B RID: 114523 RVA: 0x0040A749 File Offset: 0x00408949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF5C RID: 114524 RVA: 0x0040A754 File Offset: 0x00408954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			if (this.AddDays != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AddDays);
			}
			if (this.Minute != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Minute);
			}
			if (this.Hour != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Hour);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF5D RID: 114525 RVA: 0x0040A7E8 File Offset: 0x004089E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AddDays != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AddDays);
			}
			if (this.Hour != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hour);
			}
			if (this.Minute != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Minute);
			}
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF5E RID: 114526 RVA: 0x0040A870 File Offset: 0x00408A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneDateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AddDays != 0U)
			{
				this.AddDays = other.AddDays;
			}
			if (other.Hour != 0)
			{
				this.Hour = other.Hour;
			}
			if (other.Minute != 0)
			{
				this.Minute = other.Minute;
			}
			if (other.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF5F RID: 114527 RVA: 0x0040A8E8 File Offset: 0x00408AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF60 RID: 114528 RVA: 0x0040A8F4 File Offset: 0x00408AF4
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.Reason = (SceneDateUpdateReason)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.AddDays = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Minute = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Hour = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A098 RID: 41112
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A099 RID: 41113
		public const int AddDaysFieldNumber = 5;

		// Token: 0x0400A09A RID: 41114
		private uint addDays_;

		// Token: 0x0400A09B RID: 41115
		public const int HourFieldNumber = 10;

		// Token: 0x0400A09C RID: 41116
		private int hour_;

		// Token: 0x0400A09D RID: 41117
		public const int MinuteFieldNumber = 8;

		// Token: 0x0400A09E RID: 41118
		private int minute_;

		// Token: 0x0400A09F RID: 41119
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400A0A0 RID: 41120
		private SceneDateUpdateReason reason_;
	}
}
