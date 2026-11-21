using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101F RID: 4127
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerNotify)]
	public sealed class RogueWeeklyBlackFlowerNotify : IMessage<RogueWeeklyBlackFlowerNotify>, IMessage, IEquatable<RogueWeeklyBlackFlowerNotify>, IDeepCloneable<RogueWeeklyBlackFlowerNotify>, IBufferMessage
	{
		// Token: 0x0601615A RID: 90458 RVA: 0x00335F80 File Offset: 0x00334180
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerNotify Create()
		{
			return new RogueWeeklyBlackFlowerNotify();
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0601615B RID: 90459 RVA: 0x00335F87 File Offset: 0x00334187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x0601615C RID: 90460 RVA: 0x00335F8A File Offset: 0x0033418A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerNotify.Descriptor;
			}
		}

		// Token: 0x0601615D RID: 90461 RVA: 0x00335F91 File Offset: 0x00334191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify()
		{
		}

		// Token: 0x0601615E RID: 90462 RVA: 0x00335FA4 File Offset: 0x003341A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify(RogueWeeklyBlackFlowerNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.silentAreaIds_ = other.silentAreaIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601615F RID: 90463 RVA: 0x00335FDA File Offset: 0x003341DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerNotify Clone()
		{
			return new RogueWeeklyBlackFlowerNotify(this);
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06016160 RID: 90464 RVA: 0x00335FE2 File Offset: 0x003341E2
		// (set) Token: 0x06016161 RID: 90465 RVA: 0x00335FEA File Offset: 0x003341EA
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

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x06016162 RID: 90466 RVA: 0x00335FF3 File Offset: 0x003341F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SilentAreaIds
		{
			get
			{
				return this.silentAreaIds_;
			}
		}

		// Token: 0x06016163 RID: 90467 RVA: 0x00335FFB File Offset: 0x003341FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerNotify);
		}

		// Token: 0x06016164 RID: 90468 RVA: 0x0033600C File Offset: 0x0033420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.silentAreaIds_.Equals(other.silentAreaIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016165 RID: 90469 RVA: 0x0033605C File Offset: 0x0033425C
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

		// Token: 0x06016166 RID: 90470 RVA: 0x003360A9 File Offset: 0x003342A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016167 RID: 90471 RVA: 0x003360B6 File Offset: 0x003342B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016168 RID: 90472 RVA: 0x003360C0 File Offset: 0x003342C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.silentAreaIds_.WriteTo(ref output, RogueWeeklyBlackFlowerNotify._repeated_silentAreaIds_codec);
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016169 RID: 90473 RVA: 0x00336110 File Offset: 0x00334310
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

		// Token: 0x0601616A RID: 90474 RVA: 0x00336164 File Offset: 0x00334364
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

		// Token: 0x0601616B RID: 90475 RVA: 0x003361B1 File Offset: 0x003343B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601616C RID: 90476 RVA: 0x003361BC File Offset: 0x003343BC
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
				if (num != 24U && num != 26U)
				{
					if (num != 64U)
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

		// Token: 0x040084B6 RID: 33974
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084B7 RID: 33975
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x040084B8 RID: 33976
		private int entityConfigId_;

		// Token: 0x040084B9 RID: 33977
		public const int SilentAreaIdsFieldNumber = 3;

		// Token: 0x040084BA RID: 33978
		private static readonly FieldCodec<int> _repeated_silentAreaIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040084BB RID: 33979
		private readonly RepeatedField<int> silentAreaIds_ = new RepeatedField<int>();
	}
}
