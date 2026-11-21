using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000762 RID: 1890
	public sealed class HonamiStoryEquipItemInfo : IMessage<HonamiStoryEquipItemInfo>, IMessage, IEquatable<HonamiStoryEquipItemInfo>, IDeepCloneable<HonamiStoryEquipItemInfo>, IBufferMessage
	{
		// Token: 0x0600AB45 RID: 43845 RVA: 0x0019C3B4 File Offset: 0x0019A5B4
		[NullableContext(1)]
		public static HonamiStoryEquipItemInfo Create()
		{
			return new HonamiStoryEquipItemInfo();
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x0019C3BB File Offset: 0x0019A5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x0019C3BE File Offset: 0x0019A5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x0019C3C5 File Offset: 0x0019A5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo()
		{
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x0019C3E4 File Offset: 0x0019A5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo(HonamiStoryEquipItemInfo other) : this()
		{
			this.mainPropLibraryId_ = other.mainPropLibraryId_;
			this.oriBuffTempId_ = other.oriBuffTempId_.Clone();
			this.childBuffTempId_ = other.childBuffTempId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x0019C436 File Offset: 0x0019A636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo Clone()
		{
			return new HonamiStoryEquipItemInfo(this);
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x0019C43E File Offset: 0x0019A63E
		// (set) Token: 0x0600AB4C RID: 43852 RVA: 0x0019C446 File Offset: 0x0019A646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MainPropLibraryId
		{
			get
			{
				return this.mainPropLibraryId_;
			}
			set
			{
				this.mainPropLibraryId_ = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600AB4D RID: 43853 RVA: 0x0019C44F File Offset: 0x0019A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OriBuffTempId
		{
			get
			{
				return this.oriBuffTempId_;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x0019C457 File Offset: 0x0019A657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChildBuffTempId
		{
			get
			{
				return this.childBuffTempId_;
			}
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x0019C45F File Offset: 0x0019A65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipItemInfo);
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x0019C470 File Offset: 0x0019A670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipItemInfo other)
		{
			return other != null && (other == this || (this.MainPropLibraryId == other.MainPropLibraryId && this.oriBuffTempId_.Equals(other.oriBuffTempId_) && this.childBuffTempId_.Equals(other.childBuffTempId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x0019C4D4 File Offset: 0x0019A6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainPropLibraryId != 0)
			{
				num ^= this.MainPropLibraryId.GetHashCode();
			}
			num ^= this.oriBuffTempId_.GetHashCode();
			num ^= this.childBuffTempId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x0019C52F File Offset: 0x0019A72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x0019C53C File Offset: 0x0019A73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x0019C548 File Offset: 0x0019A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainPropLibraryId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MainPropLibraryId);
			}
			this.oriBuffTempId_.WriteTo(ref output, HonamiStoryEquipItemInfo._repeated_oriBuffTempId_codec);
			this.childBuffTempId_.WriteTo(ref output, HonamiStoryEquipItemInfo._repeated_childBuffTempId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x0019C5A8 File Offset: 0x0019A7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainPropLibraryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MainPropLibraryId);
			}
			num += this.oriBuffTempId_.CalculateSize(HonamiStoryEquipItemInfo._repeated_oriBuffTempId_codec);
			num += this.childBuffTempId_.CalculateSize(HonamiStoryEquipItemInfo._repeated_childBuffTempId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x0019C60C File Offset: 0x0019A80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEquipItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainPropLibraryId != 0)
			{
				this.MainPropLibraryId = other.MainPropLibraryId;
			}
			this.oriBuffTempId_.Add(other.oriBuffTempId_);
			this.childBuffTempId_.Add(other.childBuffTempId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x0019C66A File Offset: 0x0019A86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x0019C674 File Offset: 0x0019A874
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
						this.MainPropLibraryId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.childBuffTempId_.AddEntriesFrom(ref input, HonamiStoryEquipItemInfo._repeated_childBuffTempId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.oriBuffTempId_.AddEntriesFrom(ref input, HonamiStoryEquipItemInfo._repeated_oriBuffTempId_codec);
			}
		}

		// Token: 0x04004E1B RID: 19995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E1C RID: 19996
		public const int MainPropLibraryIdFieldNumber = 1;

		// Token: 0x04004E1D RID: 19997
		private int mainPropLibraryId_;

		// Token: 0x04004E1E RID: 19998
		public const int OriBuffTempIdFieldNumber = 2;

		// Token: 0x04004E1F RID: 19999
		private static readonly FieldCodec<int> _repeated_oriBuffTempId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004E20 RID: 20000
		private readonly RepeatedField<int> oriBuffTempId_ = new RepeatedField<int>();

		// Token: 0x04004E21 RID: 20001
		public const int ChildBuffTempIdFieldNumber = 3;

		// Token: 0x04004E22 RID: 20002
		private static readonly FieldCodec<int> _repeated_childBuffTempId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004E23 RID: 20003
		private readonly RepeatedField<int> childBuffTempId_ = new RepeatedField<int>();
	}
}
