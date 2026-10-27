using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039D RID: 925
	public sealed class DarkTideBagWeaponCtx : IMessage<DarkTideBagWeaponCtx>, IMessage, IEquatable<DarkTideBagWeaponCtx>, IDeepCloneable<DarkTideBagWeaponCtx>, IBufferMessage
	{
		// Token: 0x06005B29 RID: 23337 RVA: 0x000DDB81 File Offset: 0x000DBD81
		[NullableContext(1)]
		public static DarkTideBagWeaponCtx Create()
		{
			return new DarkTideBagWeaponCtx();
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x000DDB88 File Offset: 0x000DBD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06005B2B RID: 23339 RVA: 0x000DDB8B File Offset: 0x000DBD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagWeaponCtx.Descriptor;
			}
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x000DDB92 File Offset: 0x000DBD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagWeaponCtx()
		{
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x000DDBA8 File Offset: 0x000DBDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagWeaponCtx(DarkTideBagWeaponCtx other) : this()
		{
			this.incrId_ = other.incrId_;
			this.slotId_ = other.slotId_;
			this.level_ = other.level_;
			this.quality_ = other.quality_;
			this.affix_ = other.affix_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x000DDC0D File Offset: 0x000DBE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagWeaponCtx Clone()
		{
			return new DarkTideBagWeaponCtx(this);
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06005B2F RID: 23343 RVA: 0x000DDC15 File Offset: 0x000DBE15
		// (set) Token: 0x06005B30 RID: 23344 RVA: 0x000DDC1D File Offset: 0x000DBE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x000DDC26 File Offset: 0x000DBE26
		// (set) Token: 0x06005B32 RID: 23346 RVA: 0x000DDC2E File Offset: 0x000DBE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x000DDC37 File Offset: 0x000DBE37
		// (set) Token: 0x06005B34 RID: 23348 RVA: 0x000DDC3F File Offset: 0x000DBE3F
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

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06005B35 RID: 23349 RVA: 0x000DDC48 File Offset: 0x000DBE48
		// (set) Token: 0x06005B36 RID: 23350 RVA: 0x000DDC50 File Offset: 0x000DBE50
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

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x000DDC59 File Offset: 0x000DBE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Affix
		{
			get
			{
				return this.affix_;
			}
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x000DDC61 File Offset: 0x000DBE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagWeaponCtx);
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x000DDC70 File Offset: 0x000DBE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagWeaponCtx other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.SlotId == other.SlotId && this.Level == other.Level && this.Quality == other.Quality && this.affix_.Equals(other.affix_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x000DDCF0 File Offset: 0x000DBEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
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

		// Token: 0x06005B3B RID: 23355 RVA: 0x000DDD88 File Offset: 0x000DBF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x000DDD95 File Offset: 0x000DBF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x000DDDA0 File Offset: 0x000DBFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncrId);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Quality);
			}
			this.affix_.WriteTo(ref output, DarkTideBagWeaponCtx._repeated_affix_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x000DDE44 File Offset: 0x000DC044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Quality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			num += this.affix_.CalculateSize(DarkTideBagWeaponCtx._repeated_affix_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x000DDEE0 File Offset: 0x000DC0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagWeaponCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
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

		// Token: 0x06005B40 RID: 23360 RVA: 0x000DDF69 File Offset: 0x000DC169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x000DDF74 File Offset: 0x000DC174
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SlotId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.affix_.AddEntriesFrom(ref input, DarkTideBagWeaponCtx._repeated_affix_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035ED RID: 13805
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035EE RID: 13806
		public const int IncrIdFieldNumber = 1;

		// Token: 0x040035EF RID: 13807
		private int incrId_;

		// Token: 0x040035F0 RID: 13808
		public const int SlotIdFieldNumber = 2;

		// Token: 0x040035F1 RID: 13809
		private int slotId_;

		// Token: 0x040035F2 RID: 13810
		public const int LevelFieldNumber = 3;

		// Token: 0x040035F3 RID: 13811
		private int level_;

		// Token: 0x040035F4 RID: 13812
		public const int QualityFieldNumber = 4;

		// Token: 0x040035F5 RID: 13813
		private int quality_;

		// Token: 0x040035F6 RID: 13814
		public const int AffixFieldNumber = 5;

		// Token: 0x040035F7 RID: 13815
		private static readonly FieldCodec<int> _repeated_affix_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040035F8 RID: 13816
		private readonly RepeatedField<int> affix_ = new RepeatedField<int>();
	}
}
