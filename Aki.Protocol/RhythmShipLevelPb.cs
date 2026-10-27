using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4A RID: 3914
	public sealed class RhythmShipLevelPb : IMessage<RhythmShipLevelPb>, IMessage, IEquatable<RhythmShipLevelPb>, IDeepCloneable<RhythmShipLevelPb>, IBufferMessage
	{
		// Token: 0x06014F0D RID: 85773 RVA: 0x00309D3F File Offset: 0x00307F3F
		[NullableContext(1)]
		public static RhythmShipLevelPb Create()
		{
			return new RhythmShipLevelPb();
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x06014F0E RID: 85774 RVA: 0x00309D46 File Offset: 0x00307F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmShipLevelPb> Parser
		{
			get
			{
				return RhythmShipLevelPb._parser;
			}
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x06014F0F RID: 85775 RVA: 0x00309D4D File Offset: 0x00307F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x06014F10 RID: 85776 RVA: 0x00309D50 File Offset: 0x00307F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipLevelPb.Descriptor;
			}
		}

		// Token: 0x06014F11 RID: 85777 RVA: 0x00309D57 File Offset: 0x00307F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb()
		{
		}

		// Token: 0x06014F12 RID: 85778 RVA: 0x00309D6A File Offset: 0x00307F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb(RhythmShipLevelPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.rhythmSubLevelPb_ = other.rhythmSubLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F13 RID: 85779 RVA: 0x00309DA0 File Offset: 0x00307FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipLevelPb Clone()
		{
			return new RhythmShipLevelPb(this);
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x06014F14 RID: 85780 RVA: 0x00309DA8 File Offset: 0x00307FA8
		// (set) Token: 0x06014F15 RID: 85781 RVA: 0x00309DB0 File Offset: 0x00307FB0
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

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x06014F16 RID: 85782 RVA: 0x00309DB9 File Offset: 0x00307FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmSubLevelPb> RhythmSubLevelPb
		{
			get
			{
				return this.rhythmSubLevelPb_;
			}
		}

		// Token: 0x06014F17 RID: 85783 RVA: 0x00309DC1 File Offset: 0x00307FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipLevelPb);
		}

		// Token: 0x06014F18 RID: 85784 RVA: 0x00309DD0 File Offset: 0x00307FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.rhythmSubLevelPb_.Equals(other.rhythmSubLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F19 RID: 85785 RVA: 0x00309E20 File Offset: 0x00308020
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

		// Token: 0x06014F1A RID: 85786 RVA: 0x00309E6D File Offset: 0x0030806D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F1B RID: 85787 RVA: 0x00309E7A File Offset: 0x0030807A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F1C RID: 85788 RVA: 0x00309E84 File Offset: 0x00308084
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

		// Token: 0x06014F1D RID: 85789 RVA: 0x00309ED4 File Offset: 0x003080D4
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

		// Token: 0x06014F1E RID: 85790 RVA: 0x00309F28 File Offset: 0x00308128
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

		// Token: 0x06014F1F RID: 85791 RVA: 0x00309F75 File Offset: 0x00308175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F20 RID: 85792 RVA: 0x00309F80 File Offset: 0x00308180
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

		// Token: 0x04007E44 RID: 32324
		private static readonly MessageParser<RhythmShipLevelPb> _parser = new MessageParser<RhythmShipLevelPb>(() => new RhythmShipLevelPb());

		// Token: 0x04007E45 RID: 32325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E46 RID: 32326
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007E47 RID: 32327
		private int levelId_;

		// Token: 0x04007E48 RID: 32328
		public const int RhythmSubLevelPbFieldNumber = 2;

		// Token: 0x04007E49 RID: 32329
		private static readonly FieldCodec<RhythmSubLevelPb> _repeated_rhythmSubLevelPb_codec = FieldCodec.ForMessage<RhythmSubLevelPb>(18U, Aki.Protocol.RhythmSubLevelPb.Parser);

		// Token: 0x04007E4A RID: 32330
		private readonly RepeatedField<RhythmSubLevelPb> rhythmSubLevelPb_ = new RepeatedField<RhythmSubLevelPb>();
	}
}
