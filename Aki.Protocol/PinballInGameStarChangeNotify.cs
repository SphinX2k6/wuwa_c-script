using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3B RID: 3387
	[NetMessage(EMessageId.PinballInGameStarChangeNotify)]
	public sealed class PinballInGameStarChangeNotify : IMessage<PinballInGameStarChangeNotify>, IMessage, IEquatable<PinballInGameStarChangeNotify>, IDeepCloneable<PinballInGameStarChangeNotify>, IBufferMessage
	{
		// Token: 0x060124B9 RID: 74937 RVA: 0x002ABDA9 File Offset: 0x002A9FA9
		[NullableContext(1)]
		public static PinballInGameStarChangeNotify Create()
		{
			return new PinballInGameStarChangeNotify();
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x060124BA RID: 74938 RVA: 0x002ABDB0 File Offset: 0x002A9FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x060124BB RID: 74939 RVA: 0x002ABDB3 File Offset: 0x002A9FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameStarChangeNotify.Descriptor;
			}
		}

		// Token: 0x060124BC RID: 74940 RVA: 0x002ABDBA File Offset: 0x002A9FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify()
		{
		}

		// Token: 0x060124BD RID: 74941 RVA: 0x002ABDCD File Offset: 0x002A9FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify(PinballInGameStarChangeNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.starInfo_ = other.starInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060124BE RID: 74942 RVA: 0x002ABE03 File Offset: 0x002AA003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameStarChangeNotify Clone()
		{
			return new PinballInGameStarChangeNotify(this);
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x060124BF RID: 74943 RVA: 0x002ABE0B File Offset: 0x002AA00B
		// (set) Token: 0x060124C0 RID: 74944 RVA: 0x002ABE13 File Offset: 0x002AA013
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

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x060124C1 RID: 74945 RVA: 0x002ABE1C File Offset: 0x002AA01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x060124C2 RID: 74946 RVA: 0x002ABE24 File Offset: 0x002AA024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameStarChangeNotify);
		}

		// Token: 0x060124C3 RID: 74947 RVA: 0x002ABE34 File Offset: 0x002AA034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameStarChangeNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.starInfo_.Equals(other.starInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060124C4 RID: 74948 RVA: 0x002ABE84 File Offset: 0x002AA084
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

		// Token: 0x060124C5 RID: 74949 RVA: 0x002ABED1 File Offset: 0x002AA0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060124C6 RID: 74950 RVA: 0x002ABEDE File Offset: 0x002AA0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060124C7 RID: 74951 RVA: 0x002ABEE8 File Offset: 0x002AA0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			this.starInfo_.WriteTo(ref output, PinballInGameStarChangeNotify._repeated_starInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060124C8 RID: 74952 RVA: 0x002ABF38 File Offset: 0x002AA138
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

		// Token: 0x060124C9 RID: 74953 RVA: 0x002ABF8C File Offset: 0x002AA18C
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

		// Token: 0x060124CA RID: 74954 RVA: 0x002ABFD9 File Offset: 0x002AA1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060124CB RID: 74955 RVA: 0x002ABFE4 File Offset: 0x002AA1E4
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
				if (num != 16U)
				{
					if (num != 24U && num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.starInfo_.AddEntriesFrom(ref input, PinballInGameStarChangeNotify._repeated_starInfo_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400726D RID: 29293
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400726E RID: 29294
		public const int LevelIdFieldNumber = 2;

		// Token: 0x0400726F RID: 29295
		private int levelId_;

		// Token: 0x04007270 RID: 29296
		public const int StarInfoFieldNumber = 3;

		// Token: 0x04007271 RID: 29297
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007272 RID: 29298
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();
	}
}
