using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001298 RID: 4760
	[NetMessage(EMessageId.SneakGameStateNotify)]
	public sealed class SneakGameStateNotify : IMessage<SneakGameStateNotify>, IMessage, IEquatable<SneakGameStateNotify>, IDeepCloneable<SneakGameStateNotify>, IBufferMessage
	{
		// Token: 0x0601967B RID: 104059 RVA: 0x003B4729 File Offset: 0x003B2929
		[NullableContext(1)]
		public static SneakGameStateNotify Create()
		{
			return new SneakGameStateNotify();
		}

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x0601967C RID: 104060 RVA: 0x003B4730 File Offset: 0x003B2930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055EF RID: 21999
		// (get) Token: 0x0601967D RID: 104061 RVA: 0x003B4733 File Offset: 0x003B2933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakGameStateNotify.Descriptor;
			}
		}

		// Token: 0x0601967E RID: 104062 RVA: 0x003B473A File Offset: 0x003B293A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify()
		{
		}

		// Token: 0x0601967F RID: 104063 RVA: 0x003B4750 File Offset: 0x003B2950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify(SneakGameStateNotify other) : this()
		{
			this.sneakId_ = other.sneakId_;
			this.state_ = other.state_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019680 RID: 104064 RVA: 0x003B479D File Offset: 0x003B299D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify Clone()
		{
			return new SneakGameStateNotify(this);
		}

		// Token: 0x170055F0 RID: 22000
		// (get) Token: 0x06019681 RID: 104065 RVA: 0x003B47A5 File Offset: 0x003B29A5
		// (set) Token: 0x06019682 RID: 104066 RVA: 0x003B47AD File Offset: 0x003B29AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SneakId
		{
			get
			{
				return this.sneakId_;
			}
			set
			{
				this.sneakId_ = value;
			}
		}

		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x06019683 RID: 104067 RVA: 0x003B47B6 File Offset: 0x003B29B6
		// (set) Token: 0x06019684 RID: 104068 RVA: 0x003B47BE File Offset: 0x003B29BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x06019685 RID: 104069 RVA: 0x003B47C7 File Offset: 0x003B29C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06019686 RID: 104070 RVA: 0x003B47CF File Offset: 0x003B29CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakGameStateNotify);
		}

		// Token: 0x06019687 RID: 104071 RVA: 0x003B47E0 File Offset: 0x003B29E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakGameStateNotify other)
		{
			return other != null && (other == this || (this.SneakId == other.SneakId && this.State == other.State && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019688 RID: 104072 RVA: 0x003B4840 File Offset: 0x003B2A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SneakId != 0)
			{
				num ^= this.SneakId.GetHashCode();
			}
			if (this.State != SneakState.Open)
			{
				num ^= this.State.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019689 RID: 104073 RVA: 0x003B48AC File Offset: 0x003B2AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601968A RID: 104074 RVA: 0x003B48B9 File Offset: 0x003B2AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601968B RID: 104075 RVA: 0x003B48C4 File Offset: 0x003B2AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SneakId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SneakId);
			}
			this.entityIds_.WriteTo(ref output, SneakGameStateNotify._repeated_entityIds_codec);
			if (this.State != SneakState.Open)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601968C RID: 104076 RVA: 0x003B4930 File Offset: 0x003B2B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SneakId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SneakId);
			}
			if (this.State != SneakState.Open)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			num += this.entityIds_.CalculateSize(SneakGameStateNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601968D RID: 104077 RVA: 0x003B499C File Offset: 0x003B2B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakGameStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SneakId != 0)
			{
				this.SneakId = other.SneakId;
			}
			if (other.State != SneakState.Open)
			{
				this.State = other.State;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601968E RID: 104078 RVA: 0x003B49FD File Offset: 0x003B2BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601968F RID: 104079 RVA: 0x003B4A08 File Offset: 0x003B2C08
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.SneakId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_45;
					}
					if (num == 104U)
					{
						this.State = (SneakState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.entityIds_.AddEntriesFrom(ref input, SneakGameStateNotify._repeated_entityIds_codec);
			}
		}

		// Token: 0x04009633 RID: 38451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009634 RID: 38452
		public const int SneakIdFieldNumber = 1;

		// Token: 0x04009635 RID: 38453
		private int sneakId_;

		// Token: 0x04009636 RID: 38454
		public const int StateFieldNumber = 13;

		// Token: 0x04009637 RID: 38455
		private SneakState state_;

		// Token: 0x04009638 RID: 38456
		public const int EntityIdsFieldNumber = 9;

		// Token: 0x04009639 RID: 38457
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(74U);

		// Token: 0x0400963A RID: 38458
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
