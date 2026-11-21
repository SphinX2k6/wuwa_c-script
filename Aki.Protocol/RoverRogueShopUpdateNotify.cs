using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001163 RID: 4451
	[NetMessage(EMessageId.RoverRogueShopUpdateNotify)]
	public sealed class RoverRogueShopUpdateNotify : IMessage<RoverRogueShopUpdateNotify>, IMessage, IEquatable<RoverRogueShopUpdateNotify>, IDeepCloneable<RoverRogueShopUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017C9A RID: 97434 RVA: 0x00376C41 File Offset: 0x00374E41
		[NullableContext(1)]
		public static RoverRogueShopUpdateNotify Create()
		{
			return new RoverRogueShopUpdateNotify();
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06017C9B RID: 97435 RVA: 0x00376C48 File Offset: 0x00374E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06017C9C RID: 97436 RVA: 0x00376C4B File Offset: 0x00374E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017C9D RID: 97437 RVA: 0x00376C52 File Offset: 0x00374E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify()
		{
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x00376C5A File Offset: 0x00374E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify(RoverRogueShopUpdateNotify other) : this()
		{
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C9F RID: 97439 RVA: 0x00376C8F File Offset: 0x00374E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify Clone()
		{
			return new RoverRogueShopUpdateNotify(this);
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06017CA0 RID: 97440 RVA: 0x00376C97 File Offset: 0x00374E97
		// (set) Token: 0x06017CA1 RID: 97441 RVA: 0x00376C9F File Offset: 0x00374E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06017CA2 RID: 97442 RVA: 0x00376CA8 File Offset: 0x00374EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopUpdateNotify);
		}

		// Token: 0x06017CA3 RID: 97443 RVA: 0x00376CB6 File Offset: 0x00374EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CA4 RID: 97444 RVA: 0x00376CEC File Offset: 0x00374EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.snapshot_ != null)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017CA5 RID: 97445 RVA: 0x00376D28 File Offset: 0x00374F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CA6 RID: 97446 RVA: 0x00376D35 File Offset: 0x00374F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CA7 RID: 97447 RVA: 0x00376D3E File Offset: 0x00374F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.snapshot_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CA8 RID: 97448 RVA: 0x00376D70 File Offset: 0x00374F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.snapshot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017CA9 RID: 97449 RVA: 0x00376DB0 File Offset: 0x00374FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.snapshot_ != null)
			{
				if (this.snapshot_ == null)
				{
					this.Snapshot = new RoverRogueShopSnapshot();
				}
				this.Snapshot.MergeFrom(other.Snapshot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017CAA RID: 97450 RVA: 0x00376E04 File Offset: 0x00375004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CAB RID: 97451 RVA: 0x00376E10 File Offset: 0x00375010
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.snapshot_ == null)
					{
						this.Snapshot = new RoverRogueShopSnapshot();
					}
					input.ReadMessage(this.Snapshot);
				}
			}
		}

		// Token: 0x04008DF7 RID: 36343
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DF8 RID: 36344
		public const int SnapshotFieldNumber = 1;

		// Token: 0x04008DF9 RID: 36345
		private RoverRogueShopSnapshot snapshot_;
	}
}
