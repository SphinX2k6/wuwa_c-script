using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000789 RID: 1929
	[NetMessage(EMessageId.HonamiStorySafeLeaveNotify)]
	public sealed class HonamiStorySafeLeaveNotify : IMessage<HonamiStorySafeLeaveNotify>, IMessage, IEquatable<HonamiStorySafeLeaveNotify>, IDeepCloneable<HonamiStorySafeLeaveNotify>, IBufferMessage
	{
		// Token: 0x0600AE69 RID: 44649 RVA: 0x001A310C File Offset: 0x001A130C
		[NullableContext(1)]
		public static HonamiStorySafeLeaveNotify Create()
		{
			return new HonamiStorySafeLeaveNotify();
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x0600AE6A RID: 44650 RVA: 0x001A3113 File Offset: 0x001A1313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x001A3116 File Offset: 0x001A1316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySafeLeaveNotify.Descriptor;
			}
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x001A311D File Offset: 0x001A131D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify()
		{
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x001A3125 File Offset: 0x001A1325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify(HonamiStorySafeLeaveNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.canSafeLeave_ = other.canSafeLeave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x001A3156 File Offset: 0x001A1356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify Clone()
		{
			return new HonamiStorySafeLeaveNotify(this);
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x001A315E File Offset: 0x001A135E
		// (set) Token: 0x0600AE70 RID: 44656 RVA: 0x001A3166 File Offset: 0x001A1366
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

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x001A316F File Offset: 0x001A136F
		// (set) Token: 0x0600AE72 RID: 44658 RVA: 0x001A3177 File Offset: 0x001A1377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanSafeLeave
		{
			get
			{
				return this.canSafeLeave_;
			}
			set
			{
				this.canSafeLeave_ = value;
			}
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x001A3180 File Offset: 0x001A1380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySafeLeaveNotify);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x001A318E File Offset: 0x001A138E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySafeLeaveNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.CanSafeLeave == other.CanSafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x001A31CC File Offset: 0x001A13CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.CanSafeLeave)
			{
				num ^= this.CanSafeLeave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x001A3224 File Offset: 0x001A1424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x001A3231 File Offset: 0x001A1431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x001A323C File Offset: 0x001A143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CanSafeLeave)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CanSafeLeave);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x001A3294 File Offset: 0x001A1494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.CanSafeLeave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x001A32E0 File Offset: 0x001A14E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySafeLeaveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.CanSafeLeave)
			{
				this.CanSafeLeave = other.CanSafeLeave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE7B RID: 44667 RVA: 0x001A3330 File Offset: 0x001A1530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x001A333C File Offset: 0x001A153C
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
					if (num != 48U)
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
					this.CanSafeLeave = input.ReadBool();
				}
			}
		}

		// Token: 0x04004F07 RID: 20231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F08 RID: 20232
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004F09 RID: 20233
		private int activityId_;

		// Token: 0x04004F0A RID: 20234
		public const int CanSafeLeaveFieldNumber = 1;

		// Token: 0x04004F0B RID: 20235
		private bool canSafeLeave_;
	}
}
