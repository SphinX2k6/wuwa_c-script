using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079D RID: 1949
	[NetMessage(EMessageId.HonamiStorySafeLeaveNotify)]
	public sealed class HonamiStorySafeLeaveNotify : IMessage<HonamiStorySafeLeaveNotify>, IMessage, IEquatable<HonamiStorySafeLeaveNotify>, IDeepCloneable<HonamiStorySafeLeaveNotify>, IBufferMessage
	{
		// Token: 0x0600AFBF RID: 44991 RVA: 0x001A5B34 File Offset: 0x001A3D34
		[NullableContext(1)]
		public static HonamiStorySafeLeaveNotify Create()
		{
			return new HonamiStorySafeLeaveNotify();
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x001A5B3B File Offset: 0x001A3D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x001A5B3E File Offset: 0x001A3D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySafeLeaveNotify.Descriptor;
			}
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x001A5B45 File Offset: 0x001A3D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify()
		{
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x001A5B4D File Offset: 0x001A3D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify(HonamiStorySafeLeaveNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.canSafeLeave_ = other.canSafeLeave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x001A5B7E File Offset: 0x001A3D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySafeLeaveNotify Clone()
		{
			return new HonamiStorySafeLeaveNotify(this);
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x0600AFC5 RID: 44997 RVA: 0x001A5B86 File Offset: 0x001A3D86
		// (set) Token: 0x0600AFC6 RID: 44998 RVA: 0x001A5B8E File Offset: 0x001A3D8E
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

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0600AFC7 RID: 44999 RVA: 0x001A5B97 File Offset: 0x001A3D97
		// (set) Token: 0x0600AFC8 RID: 45000 RVA: 0x001A5B9F File Offset: 0x001A3D9F
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

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x001A5BA8 File Offset: 0x001A3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySafeLeaveNotify);
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x001A5BB6 File Offset: 0x001A3DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySafeLeaveNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.CanSafeLeave == other.CanSafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x001A5BF4 File Offset: 0x001A3DF4
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

		// Token: 0x0600AFCC RID: 45004 RVA: 0x001A5C4C File Offset: 0x001A3E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x001A5C59 File Offset: 0x001A3E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x001A5C64 File Offset: 0x001A3E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.CanSafeLeave)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.CanSafeLeave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x001A5CC0 File Offset: 0x001A3EC0
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

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x001A5D0C File Offset: 0x001A3F0C
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

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x001A5D5C File Offset: 0x001A3F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x001A5D68 File Offset: 0x001A3F68
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CanSafeLeave = input.ReadBool();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F0E RID: 20238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F0F RID: 20239
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04004F10 RID: 20240
		private int activityId_;

		// Token: 0x04004F11 RID: 20241
		public const int CanSafeLeaveFieldNumber = 9;

		// Token: 0x04004F12 RID: 20242
		private bool canSafeLeave_;
	}
}
