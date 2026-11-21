using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035B RID: 859
	public sealed class DangoBrawlFightActionReflectDamageInfo : IMessage<DangoBrawlFightActionReflectDamageInfo>, IMessage, IEquatable<DangoBrawlFightActionReflectDamageInfo>, IDeepCloneable<DangoBrawlFightActionReflectDamageInfo>, IBufferMessage
	{
		// Token: 0x06005602 RID: 22018 RVA: 0x000D252B File Offset: 0x000D072B
		[NullableContext(1)]
		public static DangoBrawlFightActionReflectDamageInfo Create()
		{
			return new DangoBrawlFightActionReflectDamageInfo();
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x000D2532 File Offset: 0x000D0732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x000D2535 File Offset: 0x000D0735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionReflectDamageInfo.Descriptor;
			}
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x000D253C File Offset: 0x000D073C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo()
		{
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x000D254F File Offset: 0x000D074F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo(DangoBrawlFightActionReflectDamageInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damages_ = other.damages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x000D2585 File Offset: 0x000D0785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo Clone()
		{
			return new DangoBrawlFightActionReflectDamageInfo(this);
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x000D258D File Offset: 0x000D078D
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x000D2595 File Offset: 0x000D0795
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

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x000D259E File Offset: 0x000D079E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Damages
		{
			get
			{
				return this.damages_;
			}
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x000D25A6 File Offset: 0x000D07A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionReflectDamageInfo);
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x000D25B4 File Offset: 0x000D07B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionReflectDamageInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.damages_.Equals(other.damages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x000D2604 File Offset: 0x000D0804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.damages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x000D2651 File Offset: 0x000D0851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x000D265E File Offset: 0x000D085E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x000D2668 File Offset: 0x000D0868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.damages_.WriteTo(ref output, DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x000D26B8 File Offset: 0x000D08B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.damages_.CalculateSize(DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x000D270C File Offset: 0x000D090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionReflectDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.damages_.Add(other.damages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x000D2759 File Offset: 0x000D0959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x000D2764 File Offset: 0x000D0964
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
						this.damages_.AddEntriesFrom(ref input, DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040034A2 RID: 13474
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034A3 RID: 13475
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040034A4 RID: 13476
		private int targetFighterUId_;

		// Token: 0x040034A5 RID: 13477
		public const int DamagesFieldNumber = 2;

		// Token: 0x040034A6 RID: 13478
		private static readonly FieldCodec<int> _repeated_damages_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040034A7 RID: 13479
		private readonly RepeatedField<int> damages_ = new RepeatedField<int>();
	}
}
