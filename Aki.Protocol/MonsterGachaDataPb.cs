using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EE RID: 2542
	public sealed class MonsterGachaDataPb : IMessage<MonsterGachaDataPb>, IMessage, IEquatable<MonsterGachaDataPb>, IDeepCloneable<MonsterGachaDataPb>, IBufferMessage
	{
		// Token: 0x0600DEDE RID: 57054 RVA: 0x0020B0DC File Offset: 0x002092DC
		[NullableContext(1)]
		public static MonsterGachaDataPb Create()
		{
			return new MonsterGachaDataPb();
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600DEDF RID: 57055 RVA: 0x0020B0E3 File Offset: 0x002092E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0600DEE0 RID: 57056 RVA: 0x0020B0E6 File Offset: 0x002092E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterGachaDataPb.Descriptor;
			}
		}

		// Token: 0x0600DEE1 RID: 57057 RVA: 0x0020B0ED File Offset: 0x002092ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb()
		{
		}

		// Token: 0x0600DEE2 RID: 57058 RVA: 0x0020B100 File Offset: 0x00209300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb(MonsterGachaDataPb other) : this()
		{
			this.monsterCrystalInfoList_ = other.monsterCrystalInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEE3 RID: 57059 RVA: 0x0020B12A File Offset: 0x0020932A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb Clone()
		{
			return new MonsterGachaDataPb(this);
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0600DEE4 RID: 57060 RVA: 0x0020B132 File Offset: 0x00209332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CrystalMonsterInfoPb> MonsterCrystalInfoList
		{
			get
			{
				return this.monsterCrystalInfoList_;
			}
		}

		// Token: 0x0600DEE5 RID: 57061 RVA: 0x0020B13A File Offset: 0x0020933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterGachaDataPb);
		}

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x0020B148 File Offset: 0x00209348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterGachaDataPb other)
		{
			return other != null && (other == this || (this.monsterCrystalInfoList_.Equals(other.monsterCrystalInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x0020B17C File Offset: 0x0020937C
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

		// Token: 0x0600DEE8 RID: 57064 RVA: 0x0020B1B0 File Offset: 0x002093B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEE9 RID: 57065 RVA: 0x0020B1BD File Offset: 0x002093BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEEA RID: 57066 RVA: 0x0020B1C6 File Offset: 0x002093C6
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

		// Token: 0x0600DEEB RID: 57067 RVA: 0x0020B1F0 File Offset: 0x002093F0
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

		// Token: 0x0600DEEC RID: 57068 RVA: 0x0020B229 File Offset: 0x00209429
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

		// Token: 0x0600DEED RID: 57069 RVA: 0x0020B257 File Offset: 0x00209457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x0020B260 File Offset: 0x00209460
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

		// Token: 0x04005C48 RID: 23624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C49 RID: 23625
		public const int MonsterCrystalInfoListFieldNumber = 1;

		// Token: 0x04005C4A RID: 23626
		private static readonly FieldCodec<CrystalMonsterInfoPb> _repeated_monsterCrystalInfoList_codec = FieldCodec.ForMessage<CrystalMonsterInfoPb>(10U, CrystalMonsterInfoPb.Parser);

		// Token: 0x04005C4B RID: 23627
		private readonly RepeatedField<CrystalMonsterInfoPb> monsterCrystalInfoList_ = new RepeatedField<CrystalMonsterInfoPb>();
	}
}
