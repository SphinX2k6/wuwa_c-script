using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A3 RID: 931
	public sealed class DarkTideDropWeaponEntityCtx : IMessage<DarkTideDropWeaponEntityCtx>, IMessage, IEquatable<DarkTideDropWeaponEntityCtx>, IDeepCloneable<DarkTideDropWeaponEntityCtx>, IBufferMessage
	{
		// Token: 0x06005BA7 RID: 23463 RVA: 0x000DEE12 File Offset: 0x000DD012
		[NullableContext(1)]
		public static DarkTideDropWeaponEntityCtx Create()
		{
			return new DarkTideDropWeaponEntityCtx();
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06005BA8 RID: 23464 RVA: 0x000DEE19 File Offset: 0x000DD019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06005BA9 RID: 23465 RVA: 0x000DEE1C File Offset: 0x000DD01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideDropWeaponEntityCtx.Descriptor;
			}
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x000DEE23 File Offset: 0x000DD023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropWeaponEntityCtx()
		{
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x000DEE38 File Offset: 0x000DD038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropWeaponEntityCtx(DarkTideDropWeaponEntityCtx other) : this()
		{
			this.level_ = other.level_;
			this.quality_ = other.quality_;
			this.affix_ = other.affix_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x000DEE85 File Offset: 0x000DD085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropWeaponEntityCtx Clone()
		{
			return new DarkTideDropWeaponEntityCtx(this);
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x000DEE8D File Offset: 0x000DD08D
		// (set) Token: 0x06005BAE RID: 23470 RVA: 0x000DEE95 File Offset: 0x000DD095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x000DEE9E File Offset: 0x000DD09E
		// (set) Token: 0x06005BB0 RID: 23472 RVA: 0x000DEEA6 File Offset: 0x000DD0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quality
		{
			get
			{
				return this.quality_;
			}
			set
			{
				this.quality_ = value;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06005BB1 RID: 23473 RVA: 0x000DEEAF File Offset: 0x000DD0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affix
		{
			get
			{
				return this.affix_;
			}
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x000DEEB7 File Offset: 0x000DD0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideDropWeaponEntityCtx);
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x000DEEC8 File Offset: 0x000DD0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideDropWeaponEntityCtx other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Quality == other.Quality && this.affix_.Equals(other.affix_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x000DEF28 File Offset: 0x000DD128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			num ^= this.affix_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x000DEF8E File Offset: 0x000DD18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x000DEF9B File Offset: 0x000DD19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x000DEFA4 File Offset: 0x000DD1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Quality);
			}
			this.affix_.WriteTo(ref output, DarkTideDropWeaponEntityCtx._repeated_affix_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x000DF010 File Offset: 0x000DD210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Quality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			num += this.affix_.CalculateSize(DarkTideDropWeaponEntityCtx._repeated_affix_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x000DF07C File Offset: 0x000DD27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideDropWeaponEntityCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			this.affix_.Add(other.affix_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x000DF0DD File Offset: 0x000DD2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x000DF0E8 File Offset: 0x000DD2E8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.affix_.AddEntriesFrom(ref input, DarkTideDropWeaponEntityCtx._repeated_affix_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003610 RID: 13840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003611 RID: 13841
		public const int LevelFieldNumber = 1;

		// Token: 0x04003612 RID: 13842
		private int level_;

		// Token: 0x04003613 RID: 13843
		public const int QualityFieldNumber = 2;

		// Token: 0x04003614 RID: 13844
		private int quality_;

		// Token: 0x04003615 RID: 13845
		public const int AffixFieldNumber = 3;

		// Token: 0x04003616 RID: 13846
		private static readonly FieldCodec<int> _repeated_affix_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003617 RID: 13847
		private readonly RepeatedField<int> affix_ = new RepeatedField<int>();
	}
}
