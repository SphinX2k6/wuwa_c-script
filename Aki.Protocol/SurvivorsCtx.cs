using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001333 RID: 4915
	public sealed class SurvivorsCtx : IMessage<SurvivorsCtx>, IMessage, IEquatable<SurvivorsCtx>, IDeepCloneable<SurvivorsCtx>, IBufferMessage
	{
		// Token: 0x0601A32F RID: 107311 RVA: 0x003D17D5 File Offset: 0x003CF9D5
		[NullableContext(1)]
		public static SurvivorsCtx Create()
		{
			return new SurvivorsCtx();
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x0601A330 RID: 107312 RVA: 0x003D17DC File Offset: 0x003CF9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x0601A331 RID: 107313 RVA: 0x003D17DF File Offset: 0x003CF9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsCtx.Descriptor;
			}
		}

		// Token: 0x0601A332 RID: 107314 RVA: 0x003D17E6 File Offset: 0x003CF9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx()
		{
		}

		// Token: 0x0601A333 RID: 107315 RVA: 0x003D17F0 File Offset: 0x003CF9F0
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

		// Token: 0x0601A334 RID: 107316 RVA: 0x003D1850 File Offset: 0x003CFA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsCtx Clone()
		{
			return new SurvivorsCtx(this);
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x0601A335 RID: 107317 RVA: 0x003D1858 File Offset: 0x003CFA58
		// (set) Token: 0x0601A336 RID: 107318 RVA: 0x003D1860 File Offset: 0x003CFA60
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

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x0601A337 RID: 107319 RVA: 0x003D1869 File Offset: 0x003CFA69
		// (set) Token: 0x0601A338 RID: 107320 RVA: 0x003D1871 File Offset: 0x003CFA71
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

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x0601A339 RID: 107321 RVA: 0x003D187A File Offset: 0x003CFA7A
		// (set) Token: 0x0601A33A RID: 107322 RVA: 0x003D1882 File Offset: 0x003CFA82
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

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x0601A33B RID: 107323 RVA: 0x003D188B File Offset: 0x003CFA8B
		// (set) Token: 0x0601A33C RID: 107324 RVA: 0x003D1893 File Offset: 0x003CFA93
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

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x0601A33D RID: 107325 RVA: 0x003D189C File Offset: 0x003CFA9C
		// (set) Token: 0x0601A33E RID: 107326 RVA: 0x003D18A4 File Offset: 0x003CFAA4
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

		// Token: 0x0601A33F RID: 107327 RVA: 0x003D18AD File Offset: 0x003CFAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsCtx);
		}

		// Token: 0x0601A340 RID: 107328 RVA: 0x003D18BC File Offset: 0x003CFABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.WeaponId == other.WeaponId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A341 RID: 107329 RVA: 0x003D1938 File Offset: 0x003CFB38
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

		// Token: 0x0601A342 RID: 107330 RVA: 0x003D19DB File Offset: 0x003CFBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A343 RID: 107331 RVA: 0x003D19E8 File Offset: 0x003CFBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A344 RID: 107332 RVA: 0x003D19F4 File Offset: 0x003CFBF4
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

		// Token: 0x0601A345 RID: 107333 RVA: 0x003D1AA0 File Offset: 0x003CFCA0
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

		// Token: 0x0601A346 RID: 107334 RVA: 0x003D1B28 File Offset: 0x003CFD28
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

		// Token: 0x0601A347 RID: 107335 RVA: 0x003D1BB4 File Offset: 0x003CFDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A348 RID: 107336 RVA: 0x003D1BC0 File Offset: 0x003CFDC0
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

		// Token: 0x04009A1B RID: 39451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A1C RID: 39452
		public const int ContinueFieldNumber = 1;

		// Token: 0x04009A1D RID: 39453
		private bool continue_;

		// Token: 0x04009A1E RID: 39454
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04009A1F RID: 39455
		private int levelId_;

		// Token: 0x04009A20 RID: 39456
		public const int InfiniteModeFieldNumber = 3;

		// Token: 0x04009A21 RID: 39457
		private bool infiniteMode_;

		// Token: 0x04009A22 RID: 39458
		public const int WeaponIdFieldNumber = 4;

		// Token: 0x04009A23 RID: 39459
		private int weaponId_;

		// Token: 0x04009A24 RID: 39460
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04009A25 RID: 39461
		private int roleId_;
	}
}
