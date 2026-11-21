using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3A RID: 3898
	public sealed class RhythmShipLevelPb : IMessage<RhythmShipLevelPb>, IMessage, IEquatable<RhythmShipLevelPb>, IDeepCloneable<RhythmShipLevelPb>, IBufferMessage
	{
		// Token: 0x06014E28 RID: 85544 RVA: 0x00308683 File Offset: 0x00306883
		[NullableContext(1)]
		public static RhythmShipLevelPb Create()
		{
			return new RhythmShipLevelPb();
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x06014E29 RID: 85545 RVA: 0x0030868A File Offset: 0x0030688A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmShipLevelPb> Parser
		{
			get
			{
				return RhythmShipLevelPb._parser;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x06014E2A RID: 85546 RVA: 0x00308691 File Offset: 0x00306891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x06014E2B RID: 85547 RVA: 0x00308694 File Offset: 0x00306894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipLevelPb.Descriptor;
			}
		}

		// Token: 0x06014E2C RID: 85548 RVA: 0x0030869B File Offset: 0x0030689B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb()
		{
		}

		// Token: 0x06014E2D RID: 85549 RVA: 0x003086AE File Offset: 0x003068AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb(RhythmShipLevelPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.rhythmSubLevelPb_ = other.rhythmSubLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E2E RID: 85550 RVA: 0x003086E4 File Offset: 0x003068E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb Clone()
		{
			return new RhythmShipLevelPb(this);
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x06014E2F RID: 85551 RVA: 0x003086EC File Offset: 0x003068EC
		// (set) Token: 0x06014E30 RID: 85552 RVA: 0x003086F4 File Offset: 0x003068F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x06014E31 RID: 85553 RVA: 0x003086FD File Offset: 0x003068FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmSubLevelPb> RhythmSubLevelPb
		{
			get
			{
				return this.rhythmSubLevelPb_;
			}
		}

		// Token: 0x06014E32 RID: 85554 RVA: 0x00308705 File Offset: 0x00306905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipLevelPb);
		}

		// Token: 0x06014E33 RID: 85555 RVA: 0x00308714 File Offset: 0x00306914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.rhythmSubLevelPb_.Equals(other.rhythmSubLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E34 RID: 85556 RVA: 0x00308764 File Offset: 0x00306964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.rhythmSubLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E35 RID: 85557 RVA: 0x003087B1 File Offset: 0x003069B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E36 RID: 85558 RVA: 0x003087BE File Offset: 0x003069BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E37 RID: 85559 RVA: 0x003087C8 File Offset: 0x003069C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.rhythmSubLevelPb_.WriteTo(ref output, RhythmShipLevelPb._repeated_rhythmSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E38 RID: 85560 RVA: 0x00308818 File Offset: 0x00306A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.rhythmSubLevelPb_.CalculateSize(RhythmShipLevelPb._repeated_rhythmSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E39 RID: 85561 RVA: 0x0030886C File Offset: 0x00306A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmShipLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.rhythmSubLevelPb_.Add(other.rhythmSubLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E3A RID: 85562 RVA: 0x003088B9 File Offset: 0x00306AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E3B RID: 85563 RVA: 0x003088C4 File Offset: 0x00306AC4
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rhythmSubLevelPb_.AddEntriesFrom(ref input, RhythmShipLevelPb._repeated_rhythmSubLevelPb_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E6E RID: 32366
		private static readonly MessageParser<RhythmShipLevelPb> _parser = new MessageParser<RhythmShipLevelPb>(() => new RhythmShipLevelPb());

		// Token: 0x04007E6F RID: 32367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E70 RID: 32368
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007E71 RID: 32369
		private int levelId_;

		// Token: 0x04007E72 RID: 32370
		public const int RhythmSubLevelPbFieldNumber = 2;

		// Token: 0x04007E73 RID: 32371
		private static readonly FieldCodec<RhythmSubLevelPb> _repeated_rhythmSubLevelPb_codec = FieldCodec.ForMessage<RhythmSubLevelPb>(18U, Aki.Protocol.RhythmSubLevelPb.Parser);

		// Token: 0x04007E74 RID: 32372
		private readonly RepeatedField<RhythmSubLevelPb> rhythmSubLevelPb_ = new RepeatedField<RhythmSubLevelPb>();
	}
}
