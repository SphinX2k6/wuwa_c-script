using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034F RID: 847
	public sealed class DangoBrawlFightActionAttrChangeInfo : IMessage<DangoBrawlFightActionAttrChangeInfo>, IMessage, IEquatable<DangoBrawlFightActionAttrChangeInfo>, IDeepCloneable<DangoBrawlFightActionAttrChangeInfo>, IBufferMessage
	{
		// Token: 0x060054DC RID: 21724 RVA: 0x000CEE93 File Offset: 0x000CD093
		[NullableContext(1)]
		public static DangoBrawlFightActionAttrChangeInfo Create()
		{
			return new DangoBrawlFightActionAttrChangeInfo();
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x000CEE9A File Offset: 0x000CD09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x000CEE9D File Offset: 0x000CD09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionAttrChangeInfo.Descriptor;
			}
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo()
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x000CEEB7 File Offset: 0x000CD0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo(DangoBrawlFightActionAttrChangeInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.finalAttrs_ = other.finalAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x000CEEED File Offset: 0x000CD0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo Clone()
		{
			return new DangoBrawlFightActionAttrChangeInfo(this);
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x000CEEF5 File Offset: 0x000CD0F5
		// (set) Token: 0x060054E3 RID: 21731 RVA: 0x000CEEFD File Offset: 0x000CD0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x060054E4 RID: 21732 RVA: 0x000CEF06 File Offset: 0x000CD106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> FinalAttrs
		{
			get
			{
				return this.finalAttrs_;
			}
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x000CEF0E File Offset: 0x000CD10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionAttrChangeInfo);
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x000CEF1C File Offset: 0x000CD11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionAttrChangeInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.FinalAttrs.Equals(other.FinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x000CEF6C File Offset: 0x000CD16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.FinalAttrs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x000CEFB9 File Offset: 0x000CD1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x000CEFC6 File Offset: 0x000CD1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x000CEFD0 File Offset: 0x000CD1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.finalAttrs_.WriteTo(ref output, DangoBrawlFightActionAttrChangeInfo._map_finalAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x000CF020 File Offset: 0x000CD220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.finalAttrs_.CalculateSize(DangoBrawlFightActionAttrChangeInfo._map_finalAttrs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x000CF074 File Offset: 0x000CD274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionAttrChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.finalAttrs_.MergeFrom(other.finalAttrs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x000CF0C1 File Offset: 0x000CD2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x000CF0CC File Offset: 0x000CD2CC
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
						this.finalAttrs_.AddEntriesFrom(ref input, DangoBrawlFightActionAttrChangeInfo._map_finalAttrs_codec);
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400343A RID: 13370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400343B RID: 13371
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x0400343C RID: 13372
		private int targetFighterUId_;

		// Token: 0x0400343D RID: 13373
		public const int FinalAttrsFieldNumber = 2;

		// Token: 0x0400343E RID: 13374
		private static readonly MapField<int, int>.Codec _map_finalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x0400343F RID: 13375
		private readonly MapField<int, int> finalAttrs_ = new MapField<int, int>();
	}
}
