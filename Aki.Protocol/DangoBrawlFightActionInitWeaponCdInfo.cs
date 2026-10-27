using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000350 RID: 848
	public sealed class DangoBrawlFightActionInitWeaponCdInfo : IMessage<DangoBrawlFightActionInitWeaponCdInfo>, IMessage, IEquatable<DangoBrawlFightActionInitWeaponCdInfo>, IDeepCloneable<DangoBrawlFightActionInitWeaponCdInfo>, IBufferMessage
	{
		// Token: 0x060054D9 RID: 21721 RVA: 0x000CF6CD File Offset: 0x000CD8CD
		[NullableContext(1)]
		public static DangoBrawlFightActionInitWeaponCdInfo Create()
		{
			return new DangoBrawlFightActionInitWeaponCdInfo();
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x000CF6D4 File Offset: 0x000CD8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x000CF6D7 File Offset: 0x000CD8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionInitWeaponCdInfo.Descriptor;
			}
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x000CF6DE File Offset: 0x000CD8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo()
		{
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x000CF6F1 File Offset: 0x000CD8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo(DangoBrawlFightActionInitWeaponCdInfo other) : this()
		{
			this.weaponNextReadyMs_ = other.weaponNextReadyMs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x000CF71B File Offset: 0x000CD91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionInitWeaponCdInfo Clone()
		{
			return new DangoBrawlFightActionInitWeaponCdInfo(this);
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x000CF723 File Offset: 0x000CD923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> WeaponNextReadyMs
		{
			get
			{
				return this.weaponNextReadyMs_;
			}
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x000CF72B File Offset: 0x000CD92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionInitWeaponCdInfo);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x000CF739 File Offset: 0x000CD939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionInitWeaponCdInfo other)
		{
			return other != null && (other == this || (this.WeaponNextReadyMs.Equals(other.WeaponNextReadyMs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x000CF76C File Offset: 0x000CD96C
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

		// Token: 0x060054E3 RID: 21731 RVA: 0x000CF7A0 File Offset: 0x000CD9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x000CF7AD File Offset: 0x000CD9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x000CF7B6 File Offset: 0x000CD9B6
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

		// Token: 0x060054E6 RID: 21734 RVA: 0x000CF7E0 File Offset: 0x000CD9E0
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

		// Token: 0x060054E7 RID: 21735 RVA: 0x000CF819 File Offset: 0x000CDA19
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

		// Token: 0x060054E8 RID: 21736 RVA: 0x000CF847 File Offset: 0x000CDA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x000CF850 File Offset: 0x000CDA50
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

		// Token: 0x040033F4 RID: 13300
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F5 RID: 13301
		public const int WeaponNextReadyMsFieldNumber = 1;

		// Token: 0x040033F6 RID: 13302
		private static readonly MapField<int, int>.Codec _map_weaponNextReadyMs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x040033F7 RID: 13303
		private readonly MapField<int, int> weaponNextReadyMs_ = new MapField<int, int>();
	}
}
