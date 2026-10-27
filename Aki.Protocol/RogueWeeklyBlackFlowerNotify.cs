using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102F RID: 4143
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerNotify)]
	public sealed class RogueWeeklyBlackFlowerNotify : IMessage<RogueWeeklyBlackFlowerNotify>, IMessage, IEquatable<RogueWeeklyBlackFlowerNotify>, IDeepCloneable<RogueWeeklyBlackFlowerNotify>, IBufferMessage
	{
		// Token: 0x0601623F RID: 90687 RVA: 0x00337640 File Offset: 0x00335840
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerNotify Create()
		{
			return new RogueWeeklyBlackFlowerNotify();
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x06016240 RID: 90688 RVA: 0x00337647 File Offset: 0x00335847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x06016241 RID: 90689 RVA: 0x0033764A File Offset: 0x0033584A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerNotify.Descriptor;
			}
		}

		// Token: 0x06016242 RID: 90690 RVA: 0x00337651 File Offset: 0x00335851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify()
		{
		}

		// Token: 0x06016243 RID: 90691 RVA: 0x00337664 File Offset: 0x00335864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify(RogueWeeklyBlackFlowerNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.silentAreaIds_ = other.silentAreaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016244 RID: 90692 RVA: 0x0033769A File Offset: 0x0033589A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify Clone()
		{
			return new RogueWeeklyBlackFlowerNotify(this);
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x06016245 RID: 90693 RVA: 0x003376A2 File Offset: 0x003358A2
		// (set) Token: 0x06016246 RID: 90694 RVA: 0x003376AA File Offset: 0x003358AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x06016247 RID: 90695 RVA: 0x003376B3 File Offset: 0x003358B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SilentAreaIds
		{
			get
			{
				return this.silentAreaIds_;
			}
		}

		// Token: 0x06016248 RID: 90696 RVA: 0x003376BB File Offset: 0x003358BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerNotify);
		}

		// Token: 0x06016249 RID: 90697 RVA: 0x003376CC File Offset: 0x003358CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.silentAreaIds_.Equals(other.silentAreaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601624A RID: 90698 RVA: 0x0033771C File Offset: 0x0033591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			num ^= this.silentAreaIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601624B RID: 90699 RVA: 0x00337769 File Offset: 0x00335969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601624C RID: 90700 RVA: 0x00337776 File Offset: 0x00335976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601624D RID: 90701 RVA: 0x00337780 File Offset: 0x00335980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.silentAreaIds_.WriteTo(ref output, RogueWeeklyBlackFlowerNotify._repeated_silentAreaIds_codec);
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601624E RID: 90702 RVA: 0x003377D0 File Offset: 0x003359D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			num += this.silentAreaIds_.CalculateSize(RogueWeeklyBlackFlowerNotify._repeated_silentAreaIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601624F RID: 90703 RVA: 0x00337824 File Offset: 0x00335A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBlackFlowerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this.silentAreaIds_.Add(other.silentAreaIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016250 RID: 90704 RVA: 0x00337871 File Offset: 0x00335A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016251 RID: 90705 RVA: 0x0033787C File Offset: 0x00335A7C
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
				if (num != 16U && num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.silentAreaIds_.AddEntriesFrom(ref input, RogueWeeklyBlackFlowerNotify._repeated_silentAreaIds_codec);
				}
			}
		}

		// Token: 0x0400848C RID: 33932
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400848D RID: 33933
		public const int EntityConfigIdFieldNumber = 13;

		// Token: 0x0400848E RID: 33934
		private int entityConfigId_;

		// Token: 0x0400848F RID: 33935
		public const int SilentAreaIdsFieldNumber = 2;

		// Token: 0x04008490 RID: 33936
		private static readonly FieldCodec<int> _repeated_silentAreaIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008491 RID: 33937
		private readonly RepeatedField<int> silentAreaIds_ = new RepeatedField<int>();
	}
}
