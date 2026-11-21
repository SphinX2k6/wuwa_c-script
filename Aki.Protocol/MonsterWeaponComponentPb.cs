using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F5 RID: 2549
	public sealed class MonsterWeaponComponentPb : IMessage<MonsterWeaponComponentPb>, IMessage, IEquatable<MonsterWeaponComponentPb>, IDeepCloneable<MonsterWeaponComponentPb>, IBufferMessage
	{
		// Token: 0x0600DF72 RID: 57202 RVA: 0x0020C479 File Offset: 0x0020A679
		[NullableContext(1)]
		public static MonsterWeaponComponentPb Create()
		{
			return new MonsterWeaponComponentPb();
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600DF73 RID: 57203 RVA: 0x0020C480 File Offset: 0x0020A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600DF74 RID: 57204 RVA: 0x0020C483 File Offset: 0x0020A683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterWeaponComponentPb.Descriptor;
			}
		}

		// Token: 0x0600DF75 RID: 57205 RVA: 0x0020C48A File Offset: 0x0020A68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb()
		{
		}

		// Token: 0x0600DF76 RID: 57206 RVA: 0x0020C492 File Offset: 0x0020A692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb(MonsterWeaponComponentPb other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x0020C4B7 File Offset: 0x0020A6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb Clone()
		{
			return new MonsterWeaponComponentPb(this);
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x0020C4BF File Offset: 0x0020A6BF
		// (set) Token: 0x0600DF79 RID: 57209 RVA: 0x0020C4C7 File Offset: 0x0020A6C7
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

		// Token: 0x0600DF7A RID: 57210 RVA: 0x0020C4D0 File Offset: 0x0020A6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterWeaponComponentPb);
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x0020C4DE File Offset: 0x0020A6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterWeaponComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x0020C50C File Offset: 0x0020A70C
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

		// Token: 0x0600DF7D RID: 57213 RVA: 0x0020C54B File Offset: 0x0020A74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF7E RID: 57214 RVA: 0x0020C558 File Offset: 0x0020A758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF7F RID: 57215 RVA: 0x0020C561 File Offset: 0x0020A761
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

		// Token: 0x0600DF80 RID: 57216 RVA: 0x0020C594 File Offset: 0x0020A794
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

		// Token: 0x0600DF81 RID: 57217 RVA: 0x0020C5D2 File Offset: 0x0020A7D2
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

		// Token: 0x0600DF82 RID: 57218 RVA: 0x0020C603 File Offset: 0x0020A803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x0020C60C File Offset: 0x0020A80C
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

		// Token: 0x04005C73 RID: 23667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C74 RID: 23668
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04005C75 RID: 23669
		private int weaponId_;
	}
}
