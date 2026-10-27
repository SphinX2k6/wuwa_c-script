using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4B RID: 3403
	[NetMessage(EMessageId.PinballInGameStarChangeNotify)]
	public sealed class PinballInGameStarChangeNotify : IMessage<PinballInGameStarChangeNotify>, IMessage, IEquatable<PinballInGameStarChangeNotify>, IDeepCloneable<PinballInGameStarChangeNotify>, IBufferMessage
	{
		// Token: 0x060125B5 RID: 75189 RVA: 0x002AD9C5 File Offset: 0x002ABBC5
		[NullableContext(1)]
		public static PinballInGameStarChangeNotify Create()
		{
			return new PinballInGameStarChangeNotify();
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x060125B6 RID: 75190 RVA: 0x002AD9CC File Offset: 0x002ABBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x060125B7 RID: 75191 RVA: 0x002AD9CF File Offset: 0x002ABBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameStarChangeNotify.Descriptor;
			}
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x002AD9D6 File Offset: 0x002ABBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify()
		{
		}

		// Token: 0x060125B9 RID: 75193 RVA: 0x002AD9E9 File Offset: 0x002ABBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify(PinballInGameStarChangeNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.starInfo_ = other.starInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125BA RID: 75194 RVA: 0x002ADA1F File Offset: 0x002ABC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify Clone()
		{
			return new PinballInGameStarChangeNotify(this);
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x060125BB RID: 75195 RVA: 0x002ADA27 File Offset: 0x002ABC27
		// (set) Token: 0x060125BC RID: 75196 RVA: 0x002ADA2F File Offset: 0x002ABC2F
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

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x060125BD RID: 75197 RVA: 0x002ADA38 File Offset: 0x002ABC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x060125BE RID: 75198 RVA: 0x002ADA40 File Offset: 0x002ABC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameStarChangeNotify);
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x002ADA50 File Offset: 0x002ABC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameStarChangeNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.starInfo_.Equals(other.starInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125C0 RID: 75200 RVA: 0x002ADAA0 File Offset: 0x002ABCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.starInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060125C1 RID: 75201 RVA: 0x002ADAED File Offset: 0x002ABCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125C2 RID: 75202 RVA: 0x002ADAFA File Offset: 0x002ABCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125C3 RID: 75203 RVA: 0x002ADB04 File Offset: 0x002ABD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.starInfo_.WriteTo(ref output, PinballInGameStarChangeNotify._repeated_starInfo_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125C4 RID: 75204 RVA: 0x002ADB54 File Offset: 0x002ABD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.starInfo_.CalculateSize(PinballInGameStarChangeNotify._repeated_starInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060125C5 RID: 75205 RVA: 0x002ADBA8 File Offset: 0x002ABDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameStarChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.starInfo_.Add(other.starInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125C6 RID: 75206 RVA: 0x002ADBF5 File Offset: 0x002ABDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125C7 RID: 75207 RVA: 0x002ADC00 File Offset: 0x002ABE00
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.starInfo_.AddEntriesFrom(ref input, PinballInGameStarChangeNotify._repeated_starInfo_codec);
				}
			}
		}

		// Token: 0x04007255 RID: 29269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007256 RID: 29270
		public const int LevelIdFieldNumber = 8;

		// Token: 0x04007257 RID: 29271
		private int levelId_;

		// Token: 0x04007258 RID: 29272
		public const int StarInfoFieldNumber = 2;

		// Token: 0x04007259 RID: 29273
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400725A RID: 29274
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();
	}
}
