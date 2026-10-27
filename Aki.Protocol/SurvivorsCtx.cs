using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C4 RID: 4804
	public sealed class SurvivorsCtx : IMessage<SurvivorsCtx>, IMessage, IEquatable<SurvivorsCtx>, IDeepCloneable<SurvivorsCtx>, IBufferMessage
	{
		// Token: 0x060198F9 RID: 104697 RVA: 0x003B7099 File Offset: 0x003B5299
		[NullableContext(1)]
		public static SurvivorsCtx Create()
		{
			return new SurvivorsCtx();
		}

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x060198FA RID: 104698 RVA: 0x003B70A0 File Offset: 0x003B52A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x060198FB RID: 104699 RVA: 0x003B70A3 File Offset: 0x003B52A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsCtx.Descriptor;
			}
		}

		// Token: 0x060198FC RID: 104700 RVA: 0x003B70AA File Offset: 0x003B52AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx()
		{
		}

		// Token: 0x060198FD RID: 104701 RVA: 0x003B70B4 File Offset: 0x003B52B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx(SurvivorsCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.levelId_ = other.levelId_;
			this.infiniteMode_ = other.infiniteMode_;
			this.weaponId_ = other.weaponId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198FE RID: 104702 RVA: 0x003B7114 File Offset: 0x003B5314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx Clone()
		{
			return new SurvivorsCtx(this);
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x060198FF RID: 104703 RVA: 0x003B711C File Offset: 0x003B531C
		// (set) Token: 0x06019900 RID: 104704 RVA: 0x003B7124 File Offset: 0x003B5324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x06019901 RID: 104705 RVA: 0x003B712D File Offset: 0x003B532D
		// (set) Token: 0x06019902 RID: 104706 RVA: 0x003B7135 File Offset: 0x003B5335
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

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x06019903 RID: 104707 RVA: 0x003B713E File Offset: 0x003B533E
		// (set) Token: 0x06019904 RID: 104708 RVA: 0x003B7146 File Offset: 0x003B5346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InfiniteMode
		{
			get
			{
				return this.infiniteMode_;
			}
			set
			{
				this.infiniteMode_ = value;
			}
		}

		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x06019905 RID: 104709 RVA: 0x003B714F File Offset: 0x003B534F
		// (set) Token: 0x06019906 RID: 104710 RVA: 0x003B7157 File Offset: 0x003B5357
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

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x06019907 RID: 104711 RVA: 0x003B7160 File Offset: 0x003B5360
		// (set) Token: 0x06019908 RID: 104712 RVA: 0x003B7168 File Offset: 0x003B5368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x003B7171 File Offset: 0x003B5371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsCtx);
		}

		// Token: 0x0601990A RID: 104714 RVA: 0x003B7180 File Offset: 0x003B5380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.WeaponId == other.WeaponId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601990B RID: 104715 RVA: 0x003B71FC File Offset: 0x003B53FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.InfiniteMode)
			{
				num ^= this.InfiniteMode.GetHashCode();
			}
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601990C RID: 104716 RVA: 0x003B729F File Offset: 0x003B549F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601990D RID: 104717 RVA: 0x003B72AC File Offset: 0x003B54AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601990E RID: 104718 RVA: 0x003B72B8 File Offset: 0x003B54B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Continue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.InfiniteMode);
			}
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WeaponId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601990F RID: 104719 RVA: 0x003B7364 File Offset: 0x003B5564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Continue)
			{
				num += 2;
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				num += 2;
			}
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019910 RID: 104720 RVA: 0x003B73EC File Offset: 0x003B55EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.InfiniteMode)
			{
				this.InfiniteMode = other.InfiniteMode;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019911 RID: 104721 RVA: 0x003B7478 File Offset: 0x003B5678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019912 RID: 104722 RVA: 0x003B7484 File Offset: 0x003B5684
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
						this.Continue = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.InfiniteMode = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.WeaponId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040095F1 RID: 38385
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095F2 RID: 38386
		public const int ContinueFieldNumber = 1;

		// Token: 0x040095F3 RID: 38387
		private bool continue_;

		// Token: 0x040095F4 RID: 38388
		public const int LevelIdFieldNumber = 2;

		// Token: 0x040095F5 RID: 38389
		private int levelId_;

		// Token: 0x040095F6 RID: 38390
		public const int InfiniteModeFieldNumber = 3;

		// Token: 0x040095F7 RID: 38391
		private bool infiniteMode_;

		// Token: 0x040095F8 RID: 38392
		public const int WeaponIdFieldNumber = 4;

		// Token: 0x040095F9 RID: 38393
		private int weaponId_;

		// Token: 0x040095FA RID: 38394
		public const int RoleIdFieldNumber = 5;

		// Token: 0x040095FB RID: 38395
		private int roleId_;
	}
}
