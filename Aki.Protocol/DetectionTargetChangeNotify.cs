using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BA RID: 954
	[NetMessage(EMessageId.DetectionTargetChangeNotify)]
	public sealed class DetectionTargetChangeNotify : IMessage<DetectionTargetChangeNotify>, IMessage, IEquatable<DetectionTargetChangeNotify>, IDeepCloneable<DetectionTargetChangeNotify>, IBufferMessage
	{
		// Token: 0x06005DB6 RID: 23990 RVA: 0x000E3848 File Offset: 0x000E1A48
		[NullableContext(1)]
		public static DetectionTargetChangeNotify Create()
		{
			return new DetectionTargetChangeNotify();
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06005DB7 RID: 23991 RVA: 0x000E384F File Offset: 0x000E1A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06005DB8 RID: 23992 RVA: 0x000E3852 File Offset: 0x000E1A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTargetChangeNotify.Descriptor;
			}
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x000E3859 File Offset: 0x000E1A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify()
		{
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x000E3861 File Offset: 0x000E1A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify(DetectionTargetChangeNotify other) : this()
		{
			this.mapId_ = other.mapId_;
			this.entityId_ = other.entityId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x000E389E File Offset: 0x000E1A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify Clone()
		{
			return new DetectionTargetChangeNotify(this);
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x000E38A6 File Offset: 0x000E1AA6
		// (set) Token: 0x06005DBD RID: 23997 RVA: 0x000E38AE File Offset: 0x000E1AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x000E38B7 File Offset: 0x000E1AB7
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x000E38BF File Offset: 0x000E1ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x000E38C8 File Offset: 0x000E1AC8
		// (set) Token: 0x06005DC1 RID: 24001 RVA: 0x000E38D0 File Offset: 0x000E1AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeReason Reason
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

		// Token: 0x06005DC2 RID: 24002 RVA: 0x000E38D9 File Offset: 0x000E1AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTargetChangeNotify);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x000E38E8 File Offset: 0x000E1AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTargetChangeNotify other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.EntityId == other.EntityId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x000E3944 File Offset: 0x000E1B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Reason != DetectionTargetChangeReason.Kill)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x000E39BB File Offset: 0x000E1BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x000E39C8 File Offset: 0x000E1BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x000E39D4 File Offset: 0x000E1BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != DetectionTargetChangeReason.Kill)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Reason);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MapId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x000E3A4C File Offset: 0x000E1C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.Reason != DetectionTargetChangeReason.Kill)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x000E3ABC File Offset: 0x000E1CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionTargetChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Reason != DetectionTargetChangeReason.Kill)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x000E3B20 File Offset: 0x000E1D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x000E3B2C File Offset: 0x000E1D2C
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt32();
						}
					}
					else
					{
						this.MapId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (DetectionTargetChangeReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x040036F8 RID: 14072
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F9 RID: 14073
		public const int MapIdFieldNumber = 10;

		// Token: 0x040036FA RID: 14074
		private int mapId_;

		// Token: 0x040036FB RID: 14075
		public const int EntityIdFieldNumber = 11;

		// Token: 0x040036FC RID: 14076
		private int entityId_;

		// Token: 0x040036FD RID: 14077
		public const int ReasonFieldNumber = 8;

		// Token: 0x040036FE RID: 14078
		private DetectionTargetChangeReason reason_;
	}
}
