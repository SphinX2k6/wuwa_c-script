using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B21 RID: 2849
	public sealed class NewTowerCycleStartParam : IMessage<NewTowerCycleStartParam>, IMessage, IEquatable<NewTowerCycleStartParam>, IDeepCloneable<NewTowerCycleStartParam>, IBufferMessage
	{
		// Token: 0x0600F7B0 RID: 63408 RVA: 0x002428B7 File Offset: 0x00240AB7
		[NullableContext(1)]
		public static NewTowerCycleStartParam Create()
		{
			return new NewTowerCycleStartParam();
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600F7B1 RID: 63409 RVA: 0x002428BE File Offset: 0x00240ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x002428C1 File Offset: 0x00240AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartParam.Descriptor;
			}
		}

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x002428C8 File Offset: 0x00240AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam()
		{
		}

		// Token: 0x0600F7B4 RID: 63412 RVA: 0x002428E8 File Offset: 0x00240AE8
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

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x00242946 File Offset: 0x00240B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam Clone()
		{
			return new NewTowerCycleStartParam(this);
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600F7B6 RID: 63414 RVA: 0x0024294E File Offset: 0x00240B4E
		// (set) Token: 0x0600F7B7 RID: 63415 RVA: 0x00242956 File Offset: 0x00240B56
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

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x0024295F File Offset: 0x00240B5F
		// (set) Token: 0x0600F7B9 RID: 63417 RVA: 0x00242967 File Offset: 0x00240B67
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

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600F7BA RID: 63418 RVA: 0x00242970 File Offset: 0x00240B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600F7BB RID: 63419 RVA: 0x00242978 File Offset: 0x00240B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSaveInfo> RoleSaveInfos
		{
			get
			{
				return this.roleSaveInfos_;
			}
		}

		// Token: 0x0600F7BC RID: 63420 RVA: 0x00242980 File Offset: 0x00240B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartParam);
		}

		// Token: 0x0600F7BD RID: 63421 RVA: 0x00242990 File Offset: 0x00240B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartParam other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Index == other.Index && this.buffIds_.Equals(other.buffIds_) && this.roleSaveInfos_.Equals(other.roleSaveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x00242A04 File Offset: 0x00240C04
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

		// Token: 0x0600F7BF RID: 63423 RVA: 0x00242A78 File Offset: 0x00240C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x00242A85 File Offset: 0x00240C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x00242A90 File Offset: 0x00240C90
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

		// Token: 0x0600F7C2 RID: 63426 RVA: 0x00242B0C File Offset: 0x00240D0C
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

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x00242B88 File Offset: 0x00240D88
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

		// Token: 0x0600F7C4 RID: 63428 RVA: 0x00242BFA File Offset: 0x00240DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x00242C04 File Offset: 0x00240E04
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

		// Token: 0x040063CE RID: 25550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063CF RID: 25551
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063D0 RID: 25552
		private int levelId_;

		// Token: 0x040063D1 RID: 25553
		public const int IndexFieldNumber = 2;

		// Token: 0x040063D2 RID: 25554
		private int index_;

		// Token: 0x040063D3 RID: 25555
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x040063D4 RID: 25556
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040063D5 RID: 25557
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x040063D6 RID: 25558
		public const int RoleSaveInfosFieldNumber = 4;

		// Token: 0x040063D7 RID: 25559
		private static readonly FieldCodec<RoleSaveInfo> _repeated_roleSaveInfos_codec = FieldCodec.ForMessage<RoleSaveInfo>(34U, RoleSaveInfo.Parser);

		// Token: 0x040063D8 RID: 25560
		private readonly RepeatedField<RoleSaveInfo> roleSaveInfos_ = new RepeatedField<RoleSaveInfo>();
	}
}
