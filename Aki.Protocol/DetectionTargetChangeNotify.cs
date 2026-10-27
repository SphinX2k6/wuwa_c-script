using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D1 RID: 977
	[NetMessage(EMessageId.DetectionTargetChangeNotify)]
	public sealed class DetectionTargetChangeNotify : IMessage<DetectionTargetChangeNotify>, IMessage, IEquatable<DetectionTargetChangeNotify>, IDeepCloneable<DetectionTargetChangeNotify>, IBufferMessage
	{
		// Token: 0x06005F46 RID: 24390 RVA: 0x000E69CC File Offset: 0x000E4BCC
		[NullableContext(1)]
		public static DetectionTargetChangeNotify Create()
		{
			return new DetectionTargetChangeNotify();
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x000E69D3 File Offset: 0x000E4BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x000E69D6 File Offset: 0x000E4BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTargetChangeNotify.Descriptor;
			}
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x000E69DD File Offset: 0x000E4BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify()
		{
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x000E69E5 File Offset: 0x000E4BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify(DetectionTargetChangeNotify other) : this()
		{
			this.mapId_ = other.mapId_;
			this.entityId_ = other.entityId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x000E6A22 File Offset: 0x000E4C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetChangeNotify Clone()
		{
			return new DetectionTargetChangeNotify(this);
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x000E6A2A File Offset: 0x000E4C2A
		// (set) Token: 0x06005F4D RID: 24397 RVA: 0x000E6A32 File Offset: 0x000E4C32
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

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x000E6A3B File Offset: 0x000E4C3B
		// (set) Token: 0x06005F4F RID: 24399 RVA: 0x000E6A43 File Offset: 0x000E4C43
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

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06005F50 RID: 24400 RVA: 0x000E6A4C File Offset: 0x000E4C4C
		// (set) Token: 0x06005F51 RID: 24401 RVA: 0x000E6A54 File Offset: 0x000E4C54
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

		// Token: 0x06005F52 RID: 24402 RVA: 0x000E6A5D File Offset: 0x000E4C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTargetChangeNotify);
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x000E6A6C File Offset: 0x000E4C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTargetChangeNotify other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.EntityId == other.EntityId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x000E6AC8 File Offset: 0x000E4CC8
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

		// Token: 0x06005F55 RID: 24405 RVA: 0x000E6B3F File Offset: 0x000E4D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x000E6B4C File Offset: 0x000E4D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x000E6B58 File Offset: 0x000E4D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityId);
			}
			if (this.Reason != DetectionTargetChangeReason.Kill)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x000E6BCC File Offset: 0x000E4DCC
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

		// Token: 0x06005F59 RID: 24409 RVA: 0x000E6C3C File Offset: 0x000E4E3C
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

		// Token: 0x06005F5A RID: 24410 RVA: 0x000E6CA0 File Offset: 0x000E4EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x000E6CAC File Offset: 0x000E4EAC
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
					if (num != 32U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400370B RID: 14091
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400370C RID: 14092
		public const int MapIdFieldNumber = 11;

		// Token: 0x0400370D RID: 14093
		private int mapId_;

		// Token: 0x0400370E RID: 14094
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400370F RID: 14095
		private int entityId_;

		// Token: 0x04003710 RID: 14096
		public const int ReasonFieldNumber = 4;

		// Token: 0x04003711 RID: 14097
		private DetectionTargetChangeReason reason_;
	}
}
