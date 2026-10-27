using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000776 RID: 1910
	public sealed class HonamiStoryEquipItemInfo : IMessage<HonamiStoryEquipItemInfo>, IMessage, IEquatable<HonamiStoryEquipItemInfo>, IDeepCloneable<HonamiStoryEquipItemInfo>, IBufferMessage
	{
		// Token: 0x0600AC9B RID: 44187 RVA: 0x0019EDDC File Offset: 0x0019CFDC
		[NullableContext(1)]
		public static HonamiStoryEquipItemInfo Create()
		{
			return new HonamiStoryEquipItemInfo();
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600AC9C RID: 44188 RVA: 0x0019EDE3 File Offset: 0x0019CFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x0019EDE6 File Offset: 0x0019CFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x0019EDED File Offset: 0x0019CFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo()
		{
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x0019EE0C File Offset: 0x0019D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo(HonamiStoryEquipItemInfo other) : this()
		{
			this.mainPropLibraryId_ = other.mainPropLibraryId_;
			this.oriBuffTempId_ = other.oriBuffTempId_.Clone();
			this.childBuffTempId_ = other.childBuffTempId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x0019EE5E File Offset: 0x0019D05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipItemInfo Clone()
		{
			return new HonamiStoryEquipItemInfo(this);
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x0019EE66 File Offset: 0x0019D066
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x0019EE6E File Offset: 0x0019D06E
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

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x0019EE77 File Offset: 0x0019D077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OriBuffTempId
		{
			get
			{
				return this.oriBuffTempId_;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x0019EE7F File Offset: 0x0019D07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChildBuffTempId
		{
			get
			{
				return this.childBuffTempId_;
			}
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x0019EE87 File Offset: 0x0019D087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipItemInfo);
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x0019EE98 File Offset: 0x0019D098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipItemInfo other)
		{
			return other != null && (other == this || (this.MainPropLibraryId == other.MainPropLibraryId && this.oriBuffTempId_.Equals(other.oriBuffTempId_) && this.childBuffTempId_.Equals(other.childBuffTempId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x0019EEFC File Offset: 0x0019D0FC
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

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x0019EF57 File Offset: 0x0019D157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x0019EF64 File Offset: 0x0019D164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x0019EF70 File Offset: 0x0019D170
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

		// Token: 0x0600ACAB RID: 44203 RVA: 0x0019EFD0 File Offset: 0x0019D1D0
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

		// Token: 0x0600ACAC RID: 44204 RVA: 0x0019F034 File Offset: 0x0019D234
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

		// Token: 0x0600ACAD RID: 44205 RVA: 0x0019F092 File Offset: 0x0019D292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x0019F09C File Offset: 0x0019D29C
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

		// Token: 0x04004E22 RID: 20002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E23 RID: 20003
		public const int MainPropLibraryIdFieldNumber = 1;

		// Token: 0x04004E24 RID: 20004
		private int mainPropLibraryId_;

		// Token: 0x04004E25 RID: 20005
		public const int OriBuffTempIdFieldNumber = 2;

		// Token: 0x04004E26 RID: 20006
		private static readonly FieldCodec<int> _repeated_oriBuffTempId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004E27 RID: 20007
		private readonly RepeatedField<int> oriBuffTempId_ = new RepeatedField<int>();

		// Token: 0x04004E28 RID: 20008
		public const int ChildBuffTempIdFieldNumber = 3;

		// Token: 0x04004E29 RID: 20009
		private static readonly FieldCodec<int> _repeated_childBuffTempId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004E2A RID: 20010
		private readonly RepeatedField<int> childBuffTempId_ = new RepeatedField<int>();
	}
}
