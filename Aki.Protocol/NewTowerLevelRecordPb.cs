using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B26 RID: 2854
	public sealed class NewTowerLevelRecordPb : IMessage<NewTowerLevelRecordPb>, IMessage, IEquatable<NewTowerLevelRecordPb>, IDeepCloneable<NewTowerLevelRecordPb>, IBufferMessage
	{
		// Token: 0x0600F80F RID: 63503 RVA: 0x002434EF File Offset: 0x002416EF
		[NullableContext(1)]
		public static NewTowerLevelRecordPb Create()
		{
			return new NewTowerLevelRecordPb();
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600F810 RID: 63504 RVA: 0x002434F6 File Offset: 0x002416F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerLevelRecordPb> Parser
		{
			get
			{
				return NewTowerLevelRecordPb._parser;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600F811 RID: 63505 RVA: 0x002434FD File Offset: 0x002416FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600F812 RID: 63506 RVA: 0x00243500 File Offset: 0x00241700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLevelRecordPb.Descriptor;
			}
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x00243507 File Offset: 0x00241707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb()
		{
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x0024351A File Offset: 0x0024171A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb(NewTowerLevelRecordPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.newTowerTeamRecordPbs_ = other.newTowerTeamRecordPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F815 RID: 63509 RVA: 0x00243550 File Offset: 0x00241750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb Clone()
		{
			return new NewTowerLevelRecordPb(this);
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600F816 RID: 63510 RVA: 0x00243558 File Offset: 0x00241758
		// (set) Token: 0x0600F817 RID: 63511 RVA: 0x00243560 File Offset: 0x00241760
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

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600F818 RID: 63512 RVA: 0x00243569 File Offset: 0x00241769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerTeamRecordPb> NewTowerTeamRecordPbs
		{
			get
			{
				return this.newTowerTeamRecordPbs_;
			}
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x00243571 File Offset: 0x00241771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLevelRecordPb);
		}

		// Token: 0x0600F81A RID: 63514 RVA: 0x00243580 File Offset: 0x00241780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLevelRecordPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.newTowerTeamRecordPbs_.Equals(other.newTowerTeamRecordPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x002435D0 File Offset: 0x002417D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.newTowerTeamRecordPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x0024361D File Offset: 0x0024181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x0024362A File Offset: 0x0024182A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x00243634 File Offset: 0x00241834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.newTowerTeamRecordPbs_.WriteTo(ref output, NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F81F RID: 63519 RVA: 0x00243684 File Offset: 0x00241884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.newTowerTeamRecordPbs_.CalculateSize(NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F820 RID: 63520 RVA: 0x002436D8 File Offset: 0x002418D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLevelRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.newTowerTeamRecordPbs_.Add(other.newTowerTeamRecordPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F821 RID: 63521 RVA: 0x00243725 File Offset: 0x00241925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x00243730 File Offset: 0x00241930
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
						this.newTowerTeamRecordPbs_.AddEntriesFrom(ref input, NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040063E5 RID: 25573
		private static readonly MessageParser<NewTowerLevelRecordPb> _parser = new MessageParser<NewTowerLevelRecordPb>(() => new NewTowerLevelRecordPb());

		// Token: 0x040063E6 RID: 25574
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063E7 RID: 25575
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063E8 RID: 25576
		private int levelId_;

		// Token: 0x040063E9 RID: 25577
		public const int NewTowerTeamRecordPbsFieldNumber = 2;

		// Token: 0x040063EA RID: 25578
		private static readonly FieldCodec<NewTowerTeamRecordPb> _repeated_newTowerTeamRecordPbs_codec = FieldCodec.ForMessage<NewTowerTeamRecordPb>(18U, NewTowerTeamRecordPb.Parser);

		// Token: 0x040063EB RID: 25579
		private readonly RepeatedField<NewTowerTeamRecordPb> newTowerTeamRecordPbs_ = new RepeatedField<NewTowerTeamRecordPb>();
	}
}
