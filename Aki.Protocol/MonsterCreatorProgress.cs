using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E6 RID: 2534
	public sealed class MonsterCreatorProgress : IMessage<MonsterCreatorProgress>, IMessage, IEquatable<MonsterCreatorProgress>, IDeepCloneable<MonsterCreatorProgress>, IBufferMessage
	{
		// Token: 0x0600DE42 RID: 56898 RVA: 0x00209CB2 File Offset: 0x00207EB2
		[NullableContext(1)]
		public static MonsterCreatorProgress Create()
		{
			return new MonsterCreatorProgress();
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x00209CB9 File Offset: 0x00207EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x00209CBC File Offset: 0x00207EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCreatorProgress.Descriptor;
			}
		}

		// Token: 0x0600DE45 RID: 56901 RVA: 0x00209CC3 File Offset: 0x00207EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress()
		{
		}

		// Token: 0x0600DE46 RID: 56902 RVA: 0x00209CD6 File Offset: 0x00207ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress(MonsterCreatorProgress other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.totalNum_ = other.totalNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x00209D0C File Offset: 0x00207F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress Clone()
		{
			return new MonsterCreatorProgress(this);
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x00209D14 File Offset: 0x00207F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterCreatorProgressSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0600DE49 RID: 56905 RVA: 0x00209D1C File Offset: 0x00207F1C
		// (set) Token: 0x0600DE4A RID: 56906 RVA: 0x00209D24 File Offset: 0x00207F24
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

		// Token: 0x0600DE4B RID: 56907 RVA: 0x00209D2D File Offset: 0x00207F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCreatorProgress);
		}

		// Token: 0x0600DE4C RID: 56908 RVA: 0x00209D3C File Offset: 0x00207F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCreatorProgress other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.TotalNum == other.TotalNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE4D RID: 56909 RVA: 0x00209D8C File Offset: 0x00207F8C
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

		// Token: 0x0600DE4E RID: 56910 RVA: 0x00209DD9 File Offset: 0x00207FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x00209DE6 File Offset: 0x00207FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE50 RID: 56912 RVA: 0x00209DF0 File Offset: 0x00207FF0
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

		// Token: 0x0600DE51 RID: 56913 RVA: 0x00209E40 File Offset: 0x00208040
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

		// Token: 0x0600DE52 RID: 56914 RVA: 0x00209E94 File Offset: 0x00208094
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

		// Token: 0x0600DE53 RID: 56915 RVA: 0x00209EE1 File Offset: 0x002080E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE54 RID: 56916 RVA: 0x00209EEC File Offset: 0x002080EC
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

		// Token: 0x04005C1E RID: 23582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C1F RID: 23583
		public const int SlotsFieldNumber = 1;

		// Token: 0x04005C20 RID: 23584
		private static readonly FieldCodec<MonsterCreatorProgressSlot> _repeated_slots_codec = FieldCodec.ForMessage<MonsterCreatorProgressSlot>(10U, MonsterCreatorProgressSlot.Parser);

		// Token: 0x04005C21 RID: 23585
		private readonly RepeatedField<MonsterCreatorProgressSlot> slots_ = new RepeatedField<MonsterCreatorProgressSlot>();

		// Token: 0x04005C22 RID: 23586
		public const int TotalNumFieldNumber = 2;

		// Token: 0x04005C23 RID: 23587
		private int totalNum_;
	}
}
