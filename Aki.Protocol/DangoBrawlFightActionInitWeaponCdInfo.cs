using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000358 RID: 856
	public sealed class DangoBrawlFightActionInitWeaponCdInfo : IMessage<DangoBrawlFightActionInitWeaponCdInfo>, IMessage, IEquatable<DangoBrawlFightActionInitWeaponCdInfo>, IDeepCloneable<DangoBrawlFightActionInitWeaponCdInfo>, IBufferMessage
	{
		// Token: 0x060055C6 RID: 21958 RVA: 0x000D1D59 File Offset: 0x000CFF59
		[NullableContext(1)]
		public static DangoBrawlFightActionInitWeaponCdInfo Create()
		{
			return new DangoBrawlFightActionInitWeaponCdInfo();
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060055C7 RID: 21959 RVA: 0x000D1D60 File Offset: 0x000CFF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x000D1D63 File Offset: 0x000CFF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionInitWeaponCdInfo.Descriptor;
			}
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x000D1D6A File Offset: 0x000CFF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo()
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x000D1D7D File Offset: 0x000CFF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo(DangoBrawlFightActionInitWeaponCdInfo other) : this()
		{
			this.weaponNextReadyMs_ = other.weaponNextReadyMs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x000D1DA7 File Offset: 0x000CFFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo Clone()
		{
			return new DangoBrawlFightActionInitWeaponCdInfo(this);
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x000D1DAF File Offset: 0x000CFFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> WeaponNextReadyMs
		{
			get
			{
				return this.weaponNextReadyMs_;
			}
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x000D1DB7 File Offset: 0x000CFFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionInitWeaponCdInfo);
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x000D1DC5 File Offset: 0x000CFFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionInitWeaponCdInfo other)
		{
			return other != null && (other == this || (this.WeaponNextReadyMs.Equals(other.WeaponNextReadyMs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x000D1DF8 File Offset: 0x000CFFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.WeaponNextReadyMs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x000D1E2C File Offset: 0x000D002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x000D1E39 File Offset: 0x000D0039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x000D1E42 File Offset: 0x000D0042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponNextReadyMs_.WriteTo(ref output, DangoBrawlFightActionInitWeaponCdInfo._map_weaponNextReadyMs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x000D1E6C File Offset: 0x000D006C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponNextReadyMs_.CalculateSize(DangoBrawlFightActionInitWeaponCdInfo._map_weaponNextReadyMs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x000D1EA5 File Offset: 0x000D00A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionInitWeaponCdInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponNextReadyMs_.MergeFrom(other.weaponNextReadyMs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x000D1ED3 File Offset: 0x000D00D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x000D1EDC File Offset: 0x000D00DC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponNextReadyMs_.AddEntriesFrom(ref input, DangoBrawlFightActionInitWeaponCdInfo._map_weaponNextReadyMs_codec);
				}
			}
		}

		// Token: 0x04003490 RID: 13456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003491 RID: 13457
		public const int WeaponNextReadyMsFieldNumber = 1;

		// Token: 0x04003492 RID: 13458
		private static readonly MapField<int, int>.Codec _map_weaponNextReadyMs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04003493 RID: 13459
		private readonly MapField<int, int> weaponNextReadyMs_ = new MapField<int, int>();
	}
}
