using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D82 RID: 3458
	[NetMessage(EMessageId.PlayerHandFoundationCoreChangeNotify)]
	public sealed class PlayerHandFoundationCoreChangeNotify : IMessage<PlayerHandFoundationCoreChangeNotify>, IMessage, IEquatable<PlayerHandFoundationCoreChangeNotify>, IDeepCloneable<PlayerHandFoundationCoreChangeNotify>, IBufferMessage
	{
		// Token: 0x06012ABC RID: 76476 RVA: 0x002BA372 File Offset: 0x002B8572
		[NullableContext(1)]
		public static PlayerHandFoundationCoreChangeNotify Create()
		{
			return new PlayerHandFoundationCoreChangeNotify();
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x06012ABD RID: 76477 RVA: 0x002BA379 File Offset: 0x002B8579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x06012ABE RID: 76478 RVA: 0x002BA37C File Offset: 0x002B857C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHandFoundationCoreChangeNotify.Descriptor;
			}
		}

		// Token: 0x06012ABF RID: 76479 RVA: 0x002BA383 File Offset: 0x002B8583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify()
		{
		}

		// Token: 0x06012AC0 RID: 76480 RVA: 0x002BA38C File Offset: 0x002B858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify(PlayerHandFoundationCoreChangeNotify other) : this()
		{
			this.fromFoundationEntityId_ = other.fromFoundationEntityId_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AC1 RID: 76481 RVA: 0x002BA3D8 File Offset: 0x002B85D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHandFoundationCoreChangeNotify Clone()
		{
			return new PlayerHandFoundationCoreChangeNotify(this);
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x06012AC2 RID: 76482 RVA: 0x002BA3E0 File Offset: 0x002B85E0
		// (set) Token: 0x06012AC3 RID: 76483 RVA: 0x002BA3E8 File Offset: 0x002B85E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromFoundationEntityId
		{
			get
			{
				return this.fromFoundationEntityId_;
			}
			set
			{
				this.fromFoundationEntityId_ = value;
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x06012AC4 RID: 76484 RVA: 0x002BA3F1 File Offset: 0x002B85F1
		// (set) Token: 0x06012AC5 RID: 76485 RVA: 0x002BA3F9 File Offset: 0x002B85F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06012AC6 RID: 76486 RVA: 0x002BA402 File Offset: 0x002B8602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHandFoundationCoreChangeNotify);
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x002BA410 File Offset: 0x002B8610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHandFoundationCoreChangeNotify other)
		{
			return other != null && (other == this || (this.FromFoundationEntityId == other.FromFoundationEntityId && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x002BA460 File Offset: 0x002B8660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FromFoundationEntityId != 0)
			{
				num ^= this.FromFoundationEntityId.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012AC9 RID: 76489 RVA: 0x002BA4B5 File Offset: 0x002B86B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012ACA RID: 76490 RVA: 0x002BA4C2 File Offset: 0x002B86C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012ACB RID: 76491 RVA: 0x002BA4CC File Offset: 0x002B86CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this.FromFoundationEntityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FromFoundationEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012ACC RID: 76492 RVA: 0x002BA528 File Offset: 0x002B8728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FromFoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromFoundationEntityId);
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012ACD RID: 76493 RVA: 0x002BA580 File Offset: 0x002B8780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHandFoundationCoreChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FromFoundationEntityId != 0)
			{
				this.FromFoundationEntityId = other.FromFoundationEntityId;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012ACE RID: 76494 RVA: 0x002BA5E8 File Offset: 0x002B87E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012ACF RID: 76495 RVA: 0x002BA5F4 File Offset: 0x002B87F4
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
				if (num != 26U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FromFoundationEntityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x04007449 RID: 29769
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400744A RID: 29770
		public const int FromFoundationEntityIdFieldNumber = 13;

		// Token: 0x0400744B RID: 29771
		private int fromFoundationEntityId_;

		// Token: 0x0400744C RID: 29772
		public const int FoundationCoreInfoFieldNumber = 3;

		// Token: 0x0400744D RID: 29773
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
