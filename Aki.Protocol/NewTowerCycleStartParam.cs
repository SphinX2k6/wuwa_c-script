using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B32 RID: 2866
	public sealed class NewTowerCycleStartParam : IMessage<NewTowerCycleStartParam>, IMessage, IEquatable<NewTowerCycleStartParam>, IDeepCloneable<NewTowerCycleStartParam>, IBufferMessage
	{
		// Token: 0x0600F8CA RID: 63690 RVA: 0x00244AD3 File Offset: 0x00242CD3
		[NullableContext(1)]
		public static NewTowerCycleStartParam Create()
		{
			return new NewTowerCycleStartParam();
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600F8CB RID: 63691 RVA: 0x00244ADA File Offset: 0x00242CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600F8CC RID: 63692 RVA: 0x00244ADD File Offset: 0x00242CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartParam.Descriptor;
			}
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00244AE4 File Offset: 0x00242CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam()
		{
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00244B04 File Offset: 0x00242D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam(NewTowerCycleStartParam other) : this()
		{
			this.levelId_ = other.levelId_;
			this.index_ = other.index_;
			this.buffIds_ = other.buffIds_.Clone();
			this.roleSaveInfos_ = other.roleSaveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00244B62 File Offset: 0x00242D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam Clone()
		{
			return new NewTowerCycleStartParam(this);
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x00244B6A File Offset: 0x00242D6A
		// (set) Token: 0x0600F8D1 RID: 63697 RVA: 0x00244B72 File Offset: 0x00242D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600F8D2 RID: 63698 RVA: 0x00244B7B File Offset: 0x00242D7B
		// (set) Token: 0x0600F8D3 RID: 63699 RVA: 0x00244B83 File Offset: 0x00242D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600F8D4 RID: 63700 RVA: 0x00244B8C File Offset: 0x00242D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600F8D5 RID: 63701 RVA: 0x00244B94 File Offset: 0x00242D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSaveInfo> RoleSaveInfos
		{
			get
			{
				return this.roleSaveInfos_;
			}
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00244B9C File Offset: 0x00242D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartParam);
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x00244BAC File Offset: 0x00242DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartParam other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Index == other.Index && this.buffIds_.Equals(other.buffIds_) && this.roleSaveInfos_.Equals(other.roleSaveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00244C20 File Offset: 0x00242E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			num ^= this.roleSaveInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x00244C94 File Offset: 0x00242E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x00244CA1 File Offset: 0x00242EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x00244CAC File Offset: 0x00242EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			this.buffIds_.WriteTo(ref output, NewTowerCycleStartParam._repeated_buffIds_codec);
			this.roleSaveInfos_.WriteTo(ref output, NewTowerCycleStartParam._repeated_roleSaveInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x00244D28 File Offset: 0x00242F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.buffIds_.CalculateSize(NewTowerCycleStartParam._repeated_buffIds_codec);
			num += this.roleSaveInfos_.CalculateSize(NewTowerCycleStartParam._repeated_roleSaveInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x00244DA4 File Offset: 0x00242FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerCycleStartParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.buffIds_.Add(other.buffIds_);
			this.roleSaveInfos_.Add(other.roleSaveInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x00244E16 File Offset: 0x00243016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x00244E20 File Offset: 0x00243020
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
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.buffIds_.AddEntriesFrom(ref input, NewTowerCycleStartParam._repeated_buffIds_codec);
						continue;
					}
					if (num == 34U)
					{
						this.roleSaveInfos_.AddEntriesFrom(ref input, NewTowerCycleStartParam._repeated_roleSaveInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040063C5 RID: 25541
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063C6 RID: 25542
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063C7 RID: 25543
		private int levelId_;

		// Token: 0x040063C8 RID: 25544
		public const int IndexFieldNumber = 2;

		// Token: 0x040063C9 RID: 25545
		private int index_;

		// Token: 0x040063CA RID: 25546
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x040063CB RID: 25547
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040063CC RID: 25548
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x040063CD RID: 25549
		public const int RoleSaveInfosFieldNumber = 4;

		// Token: 0x040063CE RID: 25550
		private static readonly FieldCodec<RoleSaveInfo> _repeated_roleSaveInfos_codec = FieldCodec.ForMessage<RoleSaveInfo>(34U, RoleSaveInfo.Parser);

		// Token: 0x040063CF RID: 25551
		private readonly RepeatedField<RoleSaveInfo> roleSaveInfos_ = new RepeatedField<RoleSaveInfo>();
	}
}
