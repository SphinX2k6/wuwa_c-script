using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8E RID: 3470
	[NetMessage(EMessageId.PlayerNetStatePush)]
	public sealed class PlayerNetStatePush : IMessage<PlayerNetStatePush>, IMessage, IEquatable<PlayerNetStatePush>, IDeepCloneable<PlayerNetStatePush>, IBufferMessage
	{
		// Token: 0x06012BA4 RID: 76708 RVA: 0x002BBFF8 File Offset: 0x002BA1F8
		[NullableContext(1)]
		public static PlayerNetStatePush Create()
		{
			return new PlayerNetStatePush();
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x06012BA5 RID: 76709 RVA: 0x002BBFFF File Offset: 0x002BA1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x06012BA6 RID: 76710 RVA: 0x002BC002 File Offset: 0x002BA202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStatePush.Descriptor;
			}
		}

		// Token: 0x06012BA7 RID: 76711 RVA: 0x002BC009 File Offset: 0x002BA209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush()
		{
		}

		// Token: 0x06012BA8 RID: 76712 RVA: 0x002BC011 File Offset: 0x002BA211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush(PlayerNetStatePush other) : this()
		{
			this.rttMs_ = other.rttMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x002BC036 File Offset: 0x002BA236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush Clone()
		{
			return new PlayerNetStatePush(this);
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x06012BAA RID: 76714 RVA: 0x002BC03E File Offset: 0x002BA23E
		// (set) Token: 0x06012BAB RID: 76715 RVA: 0x002BC046 File Offset: 0x002BA246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RttMs
		{
			get
			{
				return this.rttMs_;
			}
			set
			{
				this.rttMs_ = value;
			}
		}

		// Token: 0x06012BAC RID: 76716 RVA: 0x002BC04F File Offset: 0x002BA24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStatePush);
		}

		// Token: 0x06012BAD RID: 76717 RVA: 0x002BC05D File Offset: 0x002BA25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStatePush other)
		{
			return other != null && (other == this || (this.RttMs == other.RttMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BAE RID: 76718 RVA: 0x002BC08C File Offset: 0x002BA28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RttMs != 0)
			{
				num ^= this.RttMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BAF RID: 76719 RVA: 0x002BC0CB File Offset: 0x002BA2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BB0 RID: 76720 RVA: 0x002BC0D8 File Offset: 0x002BA2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BB1 RID: 76721 RVA: 0x002BC0E1 File Offset: 0x002BA2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RttMs != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RttMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BB2 RID: 76722 RVA: 0x002BC114 File Offset: 0x002BA314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RttMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RttMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BB3 RID: 76723 RVA: 0x002BC152 File Offset: 0x002BA352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RttMs != 0)
			{
				this.RttMs = other.RttMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BB4 RID: 76724 RVA: 0x002BC183 File Offset: 0x002BA383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BB5 RID: 76725 RVA: 0x002BC18C File Offset: 0x002BA38C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RttMs = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007480 RID: 29824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007481 RID: 29825
		public const int RttMsFieldNumber = 15;

		// Token: 0x04007482 RID: 29826
		private int rttMs_;
	}
}
