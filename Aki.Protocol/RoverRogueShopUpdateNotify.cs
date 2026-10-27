using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001129 RID: 4393
	[NetMessage(EMessageId.RoverRogueShopUpdateNotify)]
	public sealed class RoverRogueShopUpdateNotify : IMessage<RoverRogueShopUpdateNotify>, IMessage, IEquatable<RoverRogueShopUpdateNotify>, IDeepCloneable<RoverRogueShopUpdateNotify>, IBufferMessage
	{
		// Token: 0x060176F9 RID: 95993 RVA: 0x003678F5 File Offset: 0x00365AF5
		[NullableContext(1)]
		public static RoverRogueShopUpdateNotify Create()
		{
			return new RoverRogueShopUpdateNotify();
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x060176FA RID: 95994 RVA: 0x003678FC File Offset: 0x00365AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x060176FB RID: 95995 RVA: 0x003678FF File Offset: 0x00365AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060176FC RID: 95996 RVA: 0x00367906 File Offset: 0x00365B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify()
		{
		}

		// Token: 0x060176FD RID: 95997 RVA: 0x0036790E File Offset: 0x00365B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify(RoverRogueShopUpdateNotify other) : this()
		{
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x00367943 File Offset: 0x00365B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopUpdateNotify Clone()
		{
			return new RoverRogueShopUpdateNotify(this);
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x060176FF RID: 95999 RVA: 0x0036794B File Offset: 0x00365B4B
		// (set) Token: 0x06017700 RID: 96000 RVA: 0x00367953 File Offset: 0x00365B53
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

		// Token: 0x06017701 RID: 96001 RVA: 0x0036795C File Offset: 0x00365B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopUpdateNotify);
		}

		// Token: 0x06017702 RID: 96002 RVA: 0x0036796A File Offset: 0x00365B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017703 RID: 96003 RVA: 0x003679A0 File Offset: 0x00365BA0
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

		// Token: 0x06017704 RID: 96004 RVA: 0x003679DC File Offset: 0x00365BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017705 RID: 96005 RVA: 0x003679E9 File Offset: 0x00365BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017706 RID: 96006 RVA: 0x003679F2 File Offset: 0x00365BF2
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

		// Token: 0x06017707 RID: 96007 RVA: 0x00367A24 File Offset: 0x00365C24
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

		// Token: 0x06017708 RID: 96008 RVA: 0x00367A64 File Offset: 0x00365C64
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

		// Token: 0x06017709 RID: 96009 RVA: 0x00367AB8 File Offset: 0x00365CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601770A RID: 96010 RVA: 0x00367AC4 File Offset: 0x00365CC4
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

		// Token: 0x04008B64 RID: 35684
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B65 RID: 35685
		public const int SnapshotFieldNumber = 1;

		// Token: 0x04008B66 RID: 35686
		private RoverRogueShopSnapshot snapshot_;
	}
}
