using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000412 RID: 1042
	[NetMessage(EMessageId.DrownEndTeleportPush)]
	public sealed class DrownEndTeleportPush : IMessage<DrownEndTeleportPush>, IMessage, IEquatable<DrownEndTeleportPush>, IDeepCloneable<DrownEndTeleportPush>, IBufferMessage
	{
		// Token: 0x06006456 RID: 25686 RVA: 0x000F104F File Offset: 0x000EF24F
		[NullableContext(1)]
		public static DrownEndTeleportPush Create()
		{
			return new DrownEndTeleportPush();
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x000F1056 File Offset: 0x000EF256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06006458 RID: 25688 RVA: 0x000F1059 File Offset: 0x000EF259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportPush.Descriptor;
			}
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x000F1060 File Offset: 0x000EF260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush()
		{
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x000F1068 File Offset: 0x000EF268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush(DrownEndTeleportPush other) : this()
		{
			this.teleportPos_ = ((other.teleportPos_ != null) ? other.teleportPos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x000F109D File Offset: 0x000EF29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportPush Clone()
		{
			return new DrownEndTeleportPush(this);
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x0600645C RID: 25692 RVA: 0x000F10A5 File Offset: 0x000EF2A5
		// (set) Token: 0x0600645D RID: 25693 RVA: 0x000F10AD File Offset: 0x000EF2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TeleportPos
		{
			get
			{
				return this.teleportPos_;
			}
			set
			{
				this.teleportPos_ = value;
			}
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x000F10B6 File Offset: 0x000EF2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportPush);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x000F10C4 File Offset: 0x000EF2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportPush other)
		{
			return other != null && (other == this || (object.Equals(this.TeleportPos, other.TeleportPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x000F10F8 File Offset: 0x000EF2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.teleportPos_ != null)
			{
				num ^= this.TeleportPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x000F1134 File Offset: 0x000EF334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x000F1141 File Offset: 0x000EF341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x000F114A File Offset: 0x000EF34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.teleportPos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TeleportPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x000F117C File Offset: 0x000EF37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.teleportPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeleportPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x000F11BC File Offset: 0x000EF3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.teleportPos_ != null)
			{
				if (this.teleportPos_ == null)
				{
					this.TeleportPos = new Vector();
				}
				this.TeleportPos.MergeFrom(other.TeleportPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x000F1210 File Offset: 0x000EF410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x000F121C File Offset: 0x000EF41C
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.teleportPos_ == null)
					{
						this.TeleportPos = new Vector();
					}
					input.ReadMessage(this.TeleportPos);
				}
			}
		}

		// Token: 0x04003863 RID: 14435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003864 RID: 14436
		public const int TeleportPosFieldNumber = 15;

		// Token: 0x04003865 RID: 14437
		private Vector teleportPos_;
	}
}
