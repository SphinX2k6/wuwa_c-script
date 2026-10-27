using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FF RID: 2559
	public sealed class MonsterGachaDataPb : IMessage<MonsterGachaDataPb>, IMessage, IEquatable<MonsterGachaDataPb>, IDeepCloneable<MonsterGachaDataPb>, IBufferMessage
	{
		// Token: 0x0600DFF8 RID: 57336 RVA: 0x0020D2C8 File Offset: 0x0020B4C8
		[NullableContext(1)]
		public static MonsterGachaDataPb Create()
		{
			return new MonsterGachaDataPb();
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600DFF9 RID: 57337 RVA: 0x0020D2CF File Offset: 0x0020B4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x0020D2D2 File Offset: 0x0020B4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterGachaDataPb.Descriptor;
			}
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x0020D2D9 File Offset: 0x0020B4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb()
		{
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x0020D2EC File Offset: 0x0020B4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb(MonsterGachaDataPb other) : this()
		{
			this.monsterCrystalInfoList_ = other.monsterCrystalInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFFD RID: 57341 RVA: 0x0020D316 File Offset: 0x0020B516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb Clone()
		{
			return new MonsterGachaDataPb(this);
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x0020D31E File Offset: 0x0020B51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CrystalMonsterInfoPb> MonsterCrystalInfoList
		{
			get
			{
				return this.monsterCrystalInfoList_;
			}
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x0020D326 File Offset: 0x0020B526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterGachaDataPb);
		}

		// Token: 0x0600E000 RID: 57344 RVA: 0x0020D334 File Offset: 0x0020B534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterGachaDataPb other)
		{
			return other != null && (other == this || (this.monsterCrystalInfoList_.Equals(other.monsterCrystalInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x0020D368 File Offset: 0x0020B568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monsterCrystalInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E002 RID: 57346 RVA: 0x0020D39C File Offset: 0x0020B59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E003 RID: 57347 RVA: 0x0020D3A9 File Offset: 0x0020B5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E004 RID: 57348 RVA: 0x0020D3B2 File Offset: 0x0020B5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsterCrystalInfoList_.WriteTo(ref output, MonsterGachaDataPb._repeated_monsterCrystalInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x0020D3DC File Offset: 0x0020B5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsterCrystalInfoList_.CalculateSize(MonsterGachaDataPb._repeated_monsterCrystalInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x0020D415 File Offset: 0x0020B615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterGachaDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.monsterCrystalInfoList_.Add(other.monsterCrystalInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x0020D443 File Offset: 0x0020B643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x0020D44C File Offset: 0x0020B64C
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
					this.monsterCrystalInfoList_.AddEntriesFrom(ref input, MonsterGachaDataPb._repeated_monsterCrystalInfoList_codec);
				}
			}
		}

		// Token: 0x04005C3F RID: 23615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C40 RID: 23616
		public const int MonsterCrystalInfoListFieldNumber = 1;

		// Token: 0x04005C41 RID: 23617
		private static readonly FieldCodec<CrystalMonsterInfoPb> _repeated_monsterCrystalInfoList_codec = FieldCodec.ForMessage<CrystalMonsterInfoPb>(10U, CrystalMonsterInfoPb.Parser);

		// Token: 0x04005C42 RID: 23618
		private readonly RepeatedField<CrystalMonsterInfoPb> monsterCrystalInfoList_ = new RepeatedField<CrystalMonsterInfoPb>();
	}
}
