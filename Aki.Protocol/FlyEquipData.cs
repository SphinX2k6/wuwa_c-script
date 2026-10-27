using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060B RID: 1547
	public sealed class FlyEquipData : IMessage<FlyEquipData>, IMessage, IEquatable<FlyEquipData>, IDeepCloneable<FlyEquipData>, IBufferMessage
	{
		// Token: 0x06008F05 RID: 36613 RVA: 0x0015AA45 File Offset: 0x00158C45
		[NullableContext(1)]
		public static FlyEquipData Create()
		{
			return new FlyEquipData();
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06008F06 RID: 36614 RVA: 0x0015AA4C File Offset: 0x00158C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlyEquipData> Parser
		{
			get
			{
				return FlyEquipData._parser;
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x0015AA53 File Offset: 0x00158C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06008F08 RID: 36616 RVA: 0x0015AA56 File Offset: 0x00158C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlyEquipData.Descriptor;
			}
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x0015AA5D File Offset: 0x00158C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData()
		{
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x0015AA70 File Offset: 0x00158C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData(FlyEquipData other) : this()
		{
			this.skinId_ = other.skinId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x0015AAA6 File Offset: 0x00158CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipData Clone()
		{
			return new FlyEquipData(this);
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0015AAAE File Offset: 0x00158CAE
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x0015AAB6 File Offset: 0x00158CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x0015AABF File Offset: 0x00158CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0015AAC7 File Offset: 0x00158CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlyEquipData);
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0015AAD8 File Offset: 0x00158CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlyEquipData other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x0015AB28 File Offset: 0x00158D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x0015AB75 File Offset: 0x00158D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0015AB82 File Offset: 0x00158D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0015AB8C File Offset: 0x00158D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			this.roleIds_.WriteTo(ref output, FlyEquipData._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0015ABDC File Offset: 0x00158DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			num += this.roleIds_.CalculateSize(FlyEquipData._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0015AC30 File Offset: 0x00158E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlyEquipData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0015AC7D File Offset: 0x00158E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0015AC88 File Offset: 0x00158E88
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIds_.AddEntriesFrom(ref input, FlyEquipData._repeated_roleIds_codec);
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004589 RID: 17801
		private static readonly MessageParser<FlyEquipData> _parser = new MessageParser<FlyEquipData>(() => new FlyEquipData());

		// Token: 0x0400458A RID: 17802
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400458B RID: 17803
		public const int SkinIdFieldNumber = 1;

		// Token: 0x0400458C RID: 17804
		private int skinId_;

		// Token: 0x0400458D RID: 17805
		public const int RoleIdsFieldNumber = 2;

		// Token: 0x0400458E RID: 17806
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400458F RID: 17807
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
