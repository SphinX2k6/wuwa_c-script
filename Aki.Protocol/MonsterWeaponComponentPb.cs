using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A06 RID: 2566
	public sealed class MonsterWeaponComponentPb : IMessage<MonsterWeaponComponentPb>, IMessage, IEquatable<MonsterWeaponComponentPb>, IDeepCloneable<MonsterWeaponComponentPb>, IBufferMessage
	{
		// Token: 0x0600E08C RID: 57484 RVA: 0x0020E665 File Offset: 0x0020C865
		[NullableContext(1)]
		public static MonsterWeaponComponentPb Create()
		{
			return new MonsterWeaponComponentPb();
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600E08D RID: 57485 RVA: 0x0020E66C File Offset: 0x0020C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600E08E RID: 57486 RVA: 0x0020E66F File Offset: 0x0020C86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterWeaponComponentPb.Descriptor;
			}
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x0020E676 File Offset: 0x0020C876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb()
		{
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x0020E67E File Offset: 0x0020C87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb(MonsterWeaponComponentPb other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E091 RID: 57489 RVA: 0x0020E6A3 File Offset: 0x0020C8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb Clone()
		{
			return new MonsterWeaponComponentPb(this);
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600E092 RID: 57490 RVA: 0x0020E6AB File Offset: 0x0020C8AB
		// (set) Token: 0x0600E093 RID: 57491 RVA: 0x0020E6B3 File Offset: 0x0020C8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x0020E6BC File Offset: 0x0020C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterWeaponComponentPb);
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x0020E6CA File Offset: 0x0020C8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterWeaponComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E096 RID: 57494 RVA: 0x0020E6F8 File Offset: 0x0020C8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x0020E737 File Offset: 0x0020C937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x0020E744 File Offset: 0x0020C944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E099 RID: 57497 RVA: 0x0020E74D File Offset: 0x0020C94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x0020E780 File Offset: 0x0020C980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E09B RID: 57499 RVA: 0x0020E7BE File Offset: 0x0020C9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterWeaponComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x0020E7EF File Offset: 0x0020C9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x0020E7F8 File Offset: 0x0020C9F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C6A RID: 23658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C6B RID: 23659
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04005C6C RID: 23660
		private int weaponId_;
	}
}
