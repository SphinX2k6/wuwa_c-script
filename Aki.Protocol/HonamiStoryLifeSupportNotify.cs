using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000784 RID: 1924
	[NetMessage(EMessageId.HonamiStoryLifeSupportNotify)]
	public sealed class HonamiStoryLifeSupportNotify : IMessage<HonamiStoryLifeSupportNotify>, IMessage, IEquatable<HonamiStoryLifeSupportNotify>, IDeepCloneable<HonamiStoryLifeSupportNotify>, IBufferMessage
	{
		// Token: 0x0600ADD7 RID: 44503 RVA: 0x001A1E4F File Offset: 0x001A004F
		[NullableContext(1)]
		public static HonamiStoryLifeSupportNotify Create()
		{
			return new HonamiStoryLifeSupportNotify();
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x001A1E56 File Offset: 0x001A0056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x0600ADD9 RID: 44505 RVA: 0x001A1E59 File Offset: 0x001A0059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportNotify.Descriptor;
			}
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x001A1E60 File Offset: 0x001A0060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify()
		{
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x001A1E68 File Offset: 0x001A0068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify(HonamiStoryLifeSupportNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.lifeSupportLevel_ = other.lifeSupportLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x001A1E99 File Offset: 0x001A0099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportNotify Clone()
		{
			return new HonamiStoryLifeSupportNotify(this);
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x001A1EA1 File Offset: 0x001A00A1
		// (set) Token: 0x0600ADDE RID: 44510 RVA: 0x001A1EA9 File Offset: 0x001A00A9
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

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0600ADDF RID: 44511 RVA: 0x001A1EB2 File Offset: 0x001A00B2
		// (set) Token: 0x0600ADE0 RID: 44512 RVA: 0x001A1EBA File Offset: 0x001A00BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeSupportLevel
		{
			get
			{
				return this.lifeSupportLevel_;
			}
			set
			{
				this.lifeSupportLevel_ = value;
			}
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x001A1EC3 File Offset: 0x001A00C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportNotify);
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x001A1ED1 File Offset: 0x001A00D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LifeSupportLevel == other.LifeSupportLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x001A1F10 File Offset: 0x001A0110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LifeSupportLevel != 0)
			{
				num ^= this.LifeSupportLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x001A1F68 File Offset: 0x001A0168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x001A1F75 File Offset: 0x001A0175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x001A1F80 File Offset: 0x001A0180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeSupportLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LifeSupportLevel);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x001A1FD8 File Offset: 0x001A01D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LifeSupportLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeSupportLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x001A2030 File Offset: 0x001A0230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LifeSupportLevel != 0)
			{
				this.LifeSupportLevel = other.LifeSupportLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x001A2080 File Offset: 0x001A0280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x001A208C File Offset: 0x001A028C
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
				if (num != 8U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LifeSupportLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E94 RID: 20116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E95 RID: 20117
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004E96 RID: 20118
		private int activityId_;

		// Token: 0x04004E97 RID: 20119
		public const int LifeSupportLevelFieldNumber = 1;

		// Token: 0x04004E98 RID: 20120
		private int lifeSupportLevel_;
	}
}
