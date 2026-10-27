using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125B RID: 4699
	[NetMessage(EMessageId.SneakGameStateNotify)]
	public sealed class SneakGameStateNotify : IMessage<SneakGameStateNotify>, IMessage, IEquatable<SneakGameStateNotify>, IDeepCloneable<SneakGameStateNotify>, IBufferMessage
	{
		// Token: 0x06019091 RID: 102545 RVA: 0x003A47D9 File Offset: 0x003A29D9
		[NullableContext(1)]
		public static SneakGameStateNotify Create()
		{
			return new SneakGameStateNotify();
		}

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x06019092 RID: 102546 RVA: 0x003A47E0 File Offset: 0x003A29E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x06019093 RID: 102547 RVA: 0x003A47E3 File Offset: 0x003A29E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakGameStateNotify.Descriptor;
			}
		}

		// Token: 0x06019094 RID: 102548 RVA: 0x003A47EA File Offset: 0x003A29EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify()
		{
		}

		// Token: 0x06019095 RID: 102549 RVA: 0x003A4800 File Offset: 0x003A2A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify(SneakGameStateNotify other) : this()
		{
			this.sneakId_ = other.sneakId_;
			this.state_ = other.state_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019096 RID: 102550 RVA: 0x003A484D File Offset: 0x003A2A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakGameStateNotify Clone()
		{
			return new SneakGameStateNotify(this);
		}

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x06019097 RID: 102551 RVA: 0x003A4855 File Offset: 0x003A2A55
		// (set) Token: 0x06019098 RID: 102552 RVA: 0x003A485D File Offset: 0x003A2A5D
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

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x06019099 RID: 102553 RVA: 0x003A4866 File Offset: 0x003A2A66
		// (set) Token: 0x0601909A RID: 102554 RVA: 0x003A486E File Offset: 0x003A2A6E
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

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x0601909B RID: 102555 RVA: 0x003A4877 File Offset: 0x003A2A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601909C RID: 102556 RVA: 0x003A487F File Offset: 0x003A2A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakGameStateNotify);
		}

		// Token: 0x0601909D RID: 102557 RVA: 0x003A4890 File Offset: 0x003A2A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakGameStateNotify other)
		{
			return other != null && (other == this || (this.SneakId == other.SneakId && this.State == other.State && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601909E RID: 102558 RVA: 0x003A48F0 File Offset: 0x003A2AF0
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

		// Token: 0x0601909F RID: 102559 RVA: 0x003A495C File Offset: 0x003A2B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190A0 RID: 102560 RVA: 0x003A4969 File Offset: 0x003A2B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190A1 RID: 102561 RVA: 0x003A4974 File Offset: 0x003A2B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, SneakGameStateNotify._repeated_entityIds_codec);
			if (this.State != SneakState.Open)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.State);
			}
			if (this.SneakId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SneakId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190A2 RID: 102562 RVA: 0x003A49E0 File Offset: 0x003A2BE0
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

		// Token: 0x060190A3 RID: 102563 RVA: 0x003A4A4C File Offset: 0x003A2C4C
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

		// Token: 0x060190A4 RID: 102564 RVA: 0x003A4AAD File Offset: 0x003A2CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190A5 RID: 102565 RVA: 0x003A4AB8 File Offset: 0x003A2CB8
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.entityIds_.AddEntriesFrom(ref input, SneakGameStateNotify._repeated_entityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.State = (SneakState)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.SneakId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009381 RID: 37761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009382 RID: 37762
		public const int SneakIdFieldNumber = 13;

		// Token: 0x04009383 RID: 37763
		private int sneakId_;

		// Token: 0x04009384 RID: 37764
		public const int StateFieldNumber = 9;

		// Token: 0x04009385 RID: 37765
		private SneakState state_;

		// Token: 0x04009386 RID: 37766
		public const int EntityIdsFieldNumber = 3;

		// Token: 0x04009387 RID: 37767
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x04009388 RID: 37768
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
