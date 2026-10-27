using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000347 RID: 839
	public sealed class DangoBrawlFightActionAttrChangeInfo : IMessage<DangoBrawlFightActionAttrChangeInfo>, IMessage, IEquatable<DangoBrawlFightActionAttrChangeInfo>, IDeepCloneable<DangoBrawlFightActionAttrChangeInfo>, IBufferMessage
	{
		// Token: 0x060053EF RID: 21487 RVA: 0x000CC807 File Offset: 0x000CAA07
		[NullableContext(1)]
		public static DangoBrawlFightActionAttrChangeInfo Create()
		{
			return new DangoBrawlFightActionAttrChangeInfo();
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x000CC80E File Offset: 0x000CAA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060053F1 RID: 21489 RVA: 0x000CC811 File Offset: 0x000CAA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionAttrChangeInfo.Descriptor;
			}
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x000CC818 File Offset: 0x000CAA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo()
		{
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x000CC82B File Offset: 0x000CAA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo(DangoBrawlFightActionAttrChangeInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.finalAttrs_ = other.finalAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x000CC861 File Offset: 0x000CAA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionAttrChangeInfo Clone()
		{
			return new DangoBrawlFightActionAttrChangeInfo(this);
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060053F5 RID: 21493 RVA: 0x000CC869 File Offset: 0x000CAA69
		// (set) Token: 0x060053F6 RID: 21494 RVA: 0x000CC871 File Offset: 0x000CAA71
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

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060053F7 RID: 21495 RVA: 0x000CC87A File Offset: 0x000CAA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> FinalAttrs
		{
			get
			{
				return this.finalAttrs_;
			}
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x000CC882 File Offset: 0x000CAA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionAttrChangeInfo);
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x000CC890 File Offset: 0x000CAA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionAttrChangeInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.FinalAttrs.Equals(other.FinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x000CC8E0 File Offset: 0x000CAAE0
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

		// Token: 0x060053FB RID: 21499 RVA: 0x000CC92D File Offset: 0x000CAB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x000CC93A File Offset: 0x000CAB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x000CC944 File Offset: 0x000CAB44
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

		// Token: 0x060053FE RID: 21502 RVA: 0x000CC994 File Offset: 0x000CAB94
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

		// Token: 0x060053FF RID: 21503 RVA: 0x000CC9E8 File Offset: 0x000CABE8
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

		// Token: 0x06005400 RID: 21504 RVA: 0x000CCA35 File Offset: 0x000CAC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x000CCA40 File Offset: 0x000CAC40
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

		// Token: 0x0400339E RID: 13214
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400339F RID: 13215
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040033A0 RID: 13216
		private int targetFighterUId_;

		// Token: 0x040033A1 RID: 13217
		public const int FinalAttrsFieldNumber = 2;

		// Token: 0x040033A2 RID: 13218
		private static readonly MapField<int, int>.Codec _map_finalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040033A3 RID: 13219
		private readonly MapField<int, int> finalAttrs_ = new MapField<int, int>();
	}
}
