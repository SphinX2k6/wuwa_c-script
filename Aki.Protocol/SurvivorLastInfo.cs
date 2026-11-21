using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132D RID: 4909
	public sealed class SurvivorLastInfo : IMessage<SurvivorLastInfo>, IMessage, IEquatable<SurvivorLastInfo>, IDeepCloneable<SurvivorLastInfo>, IBufferMessage
	{
		// Token: 0x0601A2AC RID: 107180 RVA: 0x003D0289 File Offset: 0x003CE489
		[NullableContext(1)]
		public static SurvivorLastInfo Create()
		{
			return new SurvivorLastInfo();
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x0601A2AD RID: 107181 RVA: 0x003D0290 File Offset: 0x003CE490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x0601A2AE RID: 107182 RVA: 0x003D0293 File Offset: 0x003CE493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorLastInfo.Descriptor;
			}
		}

		// Token: 0x0601A2AF RID: 107183 RVA: 0x003D029A File Offset: 0x003CE49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo()
		{
		}

		// Token: 0x0601A2B0 RID: 107184 RVA: 0x003D02A4 File Offset: 0x003CE4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo(SurvivorLastInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.infiniteMode_ = other.infiniteMode_;
			this.roleId_ = other.roleId_;
			this.waveId_ = other.waveId_;
			this.maxWaveId_ = other.maxWaveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2B1 RID: 107185 RVA: 0x003D0304 File Offset: 0x003CE504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo Clone()
		{
			return new SurvivorLastInfo(this);
		}

		// Token: 0x17005899 RID: 22681
		// (get) Token: 0x0601A2B2 RID: 107186 RVA: 0x003D030C File Offset: 0x003CE50C
		// (set) Token: 0x0601A2B3 RID: 107187 RVA: 0x003D0314 File Offset: 0x003CE514
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

		// Token: 0x1700589A RID: 22682
		// (get) Token: 0x0601A2B4 RID: 107188 RVA: 0x003D031D File Offset: 0x003CE51D
		// (set) Token: 0x0601A2B5 RID: 107189 RVA: 0x003D0325 File Offset: 0x003CE525
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

		// Token: 0x1700589B RID: 22683
		// (get) Token: 0x0601A2B6 RID: 107190 RVA: 0x003D032E File Offset: 0x003CE52E
		// (set) Token: 0x0601A2B7 RID: 107191 RVA: 0x003D0336 File Offset: 0x003CE536
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

		// Token: 0x1700589C RID: 22684
		// (get) Token: 0x0601A2B8 RID: 107192 RVA: 0x003D033F File Offset: 0x003CE53F
		// (set) Token: 0x0601A2B9 RID: 107193 RVA: 0x003D0347 File Offset: 0x003CE547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x1700589D RID: 22685
		// (get) Token: 0x0601A2BA RID: 107194 RVA: 0x003D0350 File Offset: 0x003CE550
		// (set) Token: 0x0601A2BB RID: 107195 RVA: 0x003D0358 File Offset: 0x003CE558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxWaveId
		{
			get
			{
				return this.maxWaveId_;
			}
			set
			{
				this.maxWaveId_ = value;
			}
		}

		// Token: 0x0601A2BC RID: 107196 RVA: 0x003D0361 File Offset: 0x003CE561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorLastInfo);
		}

		// Token: 0x0601A2BD RID: 107197 RVA: 0x003D0370 File Offset: 0x003CE570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorLastInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.RoleId == other.RoleId && this.WaveId == other.WaveId && this.MaxWaveId == other.MaxWaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2BE RID: 107198 RVA: 0x003D03EC File Offset: 0x003CE5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.InfiniteMode)
			{
				num ^= this.InfiniteMode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this.MaxWaveId != 0)
			{
				num ^= this.MaxWaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2BF RID: 107199 RVA: 0x003D048F File Offset: 0x003CE68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2C0 RID: 107200 RVA: 0x003D049C File Offset: 0x003CE69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2C1 RID: 107201 RVA: 0x003D04A8 File Offset: 0x003CE6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.InfiniteMode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WaveId);
			}
			if (this.MaxWaveId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxWaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2C2 RID: 107202 RVA: 0x003D0554 File Offset: 0x003CE754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.InfiniteMode)
			{
				num += 2;
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this.MaxWaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxWaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x003D05E8 File Offset: 0x003CE7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorLastInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.InfiniteMode)
			{
				this.InfiniteMode = other.InfiniteMode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			if (other.MaxWaveId != 0)
			{
				this.MaxWaveId = other.MaxWaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2C4 RID: 107204 RVA: 0x003D0674 File Offset: 0x003CE874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x003D0680 File Offset: 0x003CE880
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
						this.InfiniteMode = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.WaveId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.MaxWaveId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099E6 RID: 39398
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099E7 RID: 39399
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040099E8 RID: 39400
		private int levelId_;

		// Token: 0x040099E9 RID: 39401
		public const int InfiniteModeFieldNumber = 2;

		// Token: 0x040099EA RID: 39402
		private bool infiniteMode_;

		// Token: 0x040099EB RID: 39403
		public const int RoleIdFieldNumber = 3;

		// Token: 0x040099EC RID: 39404
		private int roleId_;

		// Token: 0x040099ED RID: 39405
		public const int WaveIdFieldNumber = 4;

		// Token: 0x040099EE RID: 39406
		private int waveId_;

		// Token: 0x040099EF RID: 39407
		public const int MaxWaveIdFieldNumber = 5;

		// Token: 0x040099F0 RID: 39408
		private int maxWaveId_;
	}
}
