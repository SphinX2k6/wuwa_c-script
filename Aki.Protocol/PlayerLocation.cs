using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D99 RID: 3481
	public sealed class PlayerLocation : IMessage<PlayerLocation>, IMessage, IEquatable<PlayerLocation>, IDeepCloneable<PlayerLocation>, IBufferMessage
	{
		// Token: 0x06012C3A RID: 76858 RVA: 0x002BCEAC File Offset: 0x002BB0AC
		[NullableContext(1)]
		public static PlayerLocation Create()
		{
			return new PlayerLocation();
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x06012C3B RID: 76859 RVA: 0x002BCEB3 File Offset: 0x002BB0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLocation> Parser
		{
			get
			{
				return PlayerLocation._parser;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x06012C3C RID: 76860 RVA: 0x002BCEBA File Offset: 0x002BB0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x06012C3D RID: 76861 RVA: 0x002BCEBD File Offset: 0x002BB0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLocation.Descriptor;
			}
		}

		// Token: 0x06012C3E RID: 76862 RVA: 0x002BCEC4 File Offset: 0x002BB0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLocation()
		{
		}

		// Token: 0x06012C3F RID: 76863 RVA: 0x002BCECC File Offset: 0x002BB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLocation(PlayerLocation other) : this()
		{
			this.mapId_ = other.mapId_;
			this.playerId_ = other.playerId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C40 RID: 76864 RVA: 0x002BCF4C File Offset: 0x002BB14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLocation Clone()
		{
			return new PlayerLocation(this);
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x06012C41 RID: 76865 RVA: 0x002BCF54 File Offset: 0x002BB154
		// (set) Token: 0x06012C42 RID: 76866 RVA: 0x002BCF5C File Offset: 0x002BB15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x06012C43 RID: 76867 RVA: 0x002BCF65 File Offset: 0x002BB165
		// (set) Token: 0x06012C44 RID: 76868 RVA: 0x002BCF6D File Offset: 0x002BB16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x06012C45 RID: 76869 RVA: 0x002BCF76 File Offset: 0x002BB176
		// (set) Token: 0x06012C46 RID: 76870 RVA: 0x002BCF7E File Offset: 0x002BB17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x06012C47 RID: 76871 RVA: 0x002BCF87 File Offset: 0x002BB187
		// (set) Token: 0x06012C48 RID: 76872 RVA: 0x002BCF8F File Offset: 0x002BB18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06012C49 RID: 76873 RVA: 0x002BCF98 File Offset: 0x002BB198
		// (set) Token: 0x06012C4A RID: 76874 RVA: 0x002BCFA0 File Offset: 0x002BB1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x002BCFA9 File Offset: 0x002BB1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLocation);
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x002BCFB8 File Offset: 0x002BB1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLocation other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.PlayerId == other.PlayerId && object.Equals(this.Location, other.Location) && object.Equals(this.GravityDirection, other.GravityDirection) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x002BD03C File Offset: 0x002BB23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x002BD0D9 File Offset: 0x002BB2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C4F RID: 76879 RVA: 0x002BD0E6 File Offset: 0x002BB2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x002BD0F0 File Offset: 0x002BB2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MapId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Location);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x002BD19C File Offset: 0x002BB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.gravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x002BD23C File Offset: 0x002BB43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLocation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x002BD2F8 File Offset: 0x002BB4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x002BD304 File Offset: 0x002BB504
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
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 34U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
					if (num == 40U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400744E RID: 29774
		private static readonly MessageParser<PlayerLocation> _parser = new MessageParser<PlayerLocation>(() => new PlayerLocation());

		// Token: 0x0400744F RID: 29775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007450 RID: 29776
		public const int MapIdFieldNumber = 1;

		// Token: 0x04007451 RID: 29777
		private int mapId_;

		// Token: 0x04007452 RID: 29778
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04007453 RID: 29779
		private int playerId_;

		// Token: 0x04007454 RID: 29780
		public const int LocationFieldNumber = 3;

		// Token: 0x04007455 RID: 29781
		private Vector location_;

		// Token: 0x04007456 RID: 29782
		public const int GravityDirectionFieldNumber = 4;

		// Token: 0x04007457 RID: 29783
		private Vector gravityDirection_;

		// Token: 0x04007458 RID: 29784
		public const int AreaIdFieldNumber = 5;

		// Token: 0x04007459 RID: 29785
		private int areaId_;
	}
}
