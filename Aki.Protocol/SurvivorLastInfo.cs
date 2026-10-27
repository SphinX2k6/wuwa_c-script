using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BE RID: 4798
	public sealed class SurvivorLastInfo : IMessage<SurvivorLastInfo>, IMessage, IEquatable<SurvivorLastInfo>, IDeepCloneable<SurvivorLastInfo>, IBufferMessage
	{
		// Token: 0x06019876 RID: 104566 RVA: 0x003B5B4D File Offset: 0x003B3D4D
		[NullableContext(1)]
		public static SurvivorLastInfo Create()
		{
			return new SurvivorLastInfo();
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x06019877 RID: 104567 RVA: 0x003B5B54 File Offset: 0x003B3D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x06019878 RID: 104568 RVA: 0x003B5B57 File Offset: 0x003B3D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorLastInfo.Descriptor;
			}
		}

		// Token: 0x06019879 RID: 104569 RVA: 0x003B5B5E File Offset: 0x003B3D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo()
		{
		}

		// Token: 0x0601987A RID: 104570 RVA: 0x003B5B68 File Offset: 0x003B3D68
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

		// Token: 0x0601987B RID: 104571 RVA: 0x003B5BC8 File Offset: 0x003B3DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorLastInfo Clone()
		{
			return new SurvivorLastInfo(this);
		}

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x0601987C RID: 104572 RVA: 0x003B5BD0 File Offset: 0x003B3DD0
		// (set) Token: 0x0601987D RID: 104573 RVA: 0x003B5BD8 File Offset: 0x003B3DD8
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

		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x0601987E RID: 104574 RVA: 0x003B5BE1 File Offset: 0x003B3DE1
		// (set) Token: 0x0601987F RID: 104575 RVA: 0x003B5BE9 File Offset: 0x003B3DE9
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

		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x06019880 RID: 104576 RVA: 0x003B5BF2 File Offset: 0x003B3DF2
		// (set) Token: 0x06019881 RID: 104577 RVA: 0x003B5BFA File Offset: 0x003B3DFA
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

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x06019882 RID: 104578 RVA: 0x003B5C03 File Offset: 0x003B3E03
		// (set) Token: 0x06019883 RID: 104579 RVA: 0x003B5C0B File Offset: 0x003B3E0B
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

		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x06019884 RID: 104580 RVA: 0x003B5C14 File Offset: 0x003B3E14
		// (set) Token: 0x06019885 RID: 104581 RVA: 0x003B5C1C File Offset: 0x003B3E1C
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

		// Token: 0x06019886 RID: 104582 RVA: 0x003B5C25 File Offset: 0x003B3E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorLastInfo);
		}

		// Token: 0x06019887 RID: 104583 RVA: 0x003B5C34 File Offset: 0x003B3E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorLastInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.InfiniteMode == other.InfiniteMode && this.RoleId == other.RoleId && this.WaveId == other.WaveId && this.MaxWaveId == other.MaxWaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019888 RID: 104584 RVA: 0x003B5CB0 File Offset: 0x003B3EB0
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

		// Token: 0x06019889 RID: 104585 RVA: 0x003B5D53 File Offset: 0x003B3F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601988A RID: 104586 RVA: 0x003B5D60 File Offset: 0x003B3F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601988B RID: 104587 RVA: 0x003B5D6C File Offset: 0x003B3F6C
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

		// Token: 0x0601988C RID: 104588 RVA: 0x003B5E18 File Offset: 0x003B4018
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

		// Token: 0x0601988D RID: 104589 RVA: 0x003B5EAC File Offset: 0x003B40AC
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

		// Token: 0x0601988E RID: 104590 RVA: 0x003B5F38 File Offset: 0x003B4138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601988F RID: 104591 RVA: 0x003B5F44 File Offset: 0x003B4144
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

		// Token: 0x040095BC RID: 38332
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095BD RID: 38333
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040095BE RID: 38334
		private int levelId_;

		// Token: 0x040095BF RID: 38335
		public const int InfiniteModeFieldNumber = 2;

		// Token: 0x040095C0 RID: 38336
		private bool infiniteMode_;

		// Token: 0x040095C1 RID: 38337
		public const int RoleIdFieldNumber = 3;

		// Token: 0x040095C2 RID: 38338
		private int roleId_;

		// Token: 0x040095C3 RID: 38339
		public const int WaveIdFieldNumber = 4;

		// Token: 0x040095C4 RID: 38340
		private int waveId_;

		// Token: 0x040095C5 RID: 38341
		public const int MaxWaveIdFieldNumber = 5;

		// Token: 0x040095C6 RID: 38342
		private int maxWaveId_;
	}
}
