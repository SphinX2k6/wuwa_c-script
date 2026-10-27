using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F7 RID: 2551
	public sealed class MonsterCreatorProgress : IMessage<MonsterCreatorProgress>, IMessage, IEquatable<MonsterCreatorProgress>, IDeepCloneable<MonsterCreatorProgress>, IBufferMessage
	{
		// Token: 0x0600DF5C RID: 57180 RVA: 0x0020BE9E File Offset: 0x0020A09E
		[NullableContext(1)]
		public static MonsterCreatorProgress Create()
		{
			return new MonsterCreatorProgress();
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600DF5D RID: 57181 RVA: 0x0020BEA5 File Offset: 0x0020A0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600DF5E RID: 57182 RVA: 0x0020BEA8 File Offset: 0x0020A0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCreatorProgress.Descriptor;
			}
		}

		// Token: 0x0600DF5F RID: 57183 RVA: 0x0020BEAF File Offset: 0x0020A0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress()
		{
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x0020BEC2 File Offset: 0x0020A0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress(MonsterCreatorProgress other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.totalNum_ = other.totalNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x0020BEF8 File Offset: 0x0020A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress Clone()
		{
			return new MonsterCreatorProgress(this);
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x0020BF00 File Offset: 0x0020A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterCreatorProgressSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600DF63 RID: 57187 RVA: 0x0020BF08 File Offset: 0x0020A108
		// (set) Token: 0x0600DF64 RID: 57188 RVA: 0x0020BF10 File Offset: 0x0020A110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalNum
		{
			get
			{
				return this.totalNum_;
			}
			set
			{
				this.totalNum_ = value;
			}
		}

		// Token: 0x0600DF65 RID: 57189 RVA: 0x0020BF19 File Offset: 0x0020A119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCreatorProgress);
		}

		// Token: 0x0600DF66 RID: 57190 RVA: 0x0020BF28 File Offset: 0x0020A128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCreatorProgress other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.TotalNum == other.TotalNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF67 RID: 57191 RVA: 0x0020BF78 File Offset: 0x0020A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slots_.GetHashCode();
			if (this.TotalNum != 0)
			{
				num ^= this.TotalNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF68 RID: 57192 RVA: 0x0020BFC5 File Offset: 0x0020A1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF69 RID: 57193 RVA: 0x0020BFD2 File Offset: 0x0020A1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x0020BFDC File Offset: 0x0020A1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slots_.WriteTo(ref output, MonsterCreatorProgress._repeated_slots_codec);
			if (this.TotalNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x0020C02C File Offset: 0x0020A22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slots_.CalculateSize(MonsterCreatorProgress._repeated_slots_codec);
			if (this.TotalNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x0020C080 File Offset: 0x0020A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterCreatorProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.slots_.Add(other.slots_);
			if (other.TotalNum != 0)
			{
				this.TotalNum = other.TotalNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x0020C0CD File Offset: 0x0020A2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x0020C0D8 File Offset: 0x0020A2D8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalNum = input.ReadInt32();
					}
				}
				else
				{
					this.slots_.AddEntriesFrom(ref input, MonsterCreatorProgress._repeated_slots_codec);
				}
			}
		}

		// Token: 0x04005C15 RID: 23573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C16 RID: 23574
		public const int SlotsFieldNumber = 1;

		// Token: 0x04005C17 RID: 23575
		private static readonly FieldCodec<MonsterCreatorProgressSlot> _repeated_slots_codec = FieldCodec.ForMessage<MonsterCreatorProgressSlot>(10U, MonsterCreatorProgressSlot.Parser);

		// Token: 0x04005C18 RID: 23576
		private readonly RepeatedField<MonsterCreatorProgressSlot> slots_ = new RepeatedField<MonsterCreatorProgressSlot>();

		// Token: 0x04005C19 RID: 23577
		public const int TotalNumFieldNumber = 2;

		// Token: 0x04005C1A RID: 23578
		private int totalNum_;
	}
}
