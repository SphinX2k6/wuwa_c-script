using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D89 RID: 3465
	public sealed class PlayerLocation : IMessage<PlayerLocation>, IMessage, IEquatable<PlayerLocation>, IDeepCloneable<PlayerLocation>, IBufferMessage
	{
		// Token: 0x06012B3E RID: 76606 RVA: 0x002BB288 File Offset: 0x002B9488
		[NullableContext(1)]
		public static PlayerLocation Create()
		{
			return new PlayerLocation();
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x06012B3F RID: 76607 RVA: 0x002BB28F File Offset: 0x002B948F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLocation> Parser
		{
			get
			{
				return PlayerLocation._parser;
			}
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x06012B40 RID: 76608 RVA: 0x002BB296 File Offset: 0x002B9496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x06012B41 RID: 76609 RVA: 0x002BB299 File Offset: 0x002B9499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLocation.Descriptor;
			}
		}

		// Token: 0x06012B42 RID: 76610 RVA: 0x002BB2A0 File Offset: 0x002B94A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLocation()
		{
		}

		// Token: 0x06012B43 RID: 76611 RVA: 0x002BB2A8 File Offset: 0x002B94A8
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

		// Token: 0x06012B44 RID: 76612 RVA: 0x002BB328 File Offset: 0x002B9528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLocation Clone()
		{
			return new PlayerLocation(this);
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x06012B45 RID: 76613 RVA: 0x002BB330 File Offset: 0x002B9530
		// (set) Token: 0x06012B46 RID: 76614 RVA: 0x002BB338 File Offset: 0x002B9538
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

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x06012B47 RID: 76615 RVA: 0x002BB341 File Offset: 0x002B9541
		// (set) Token: 0x06012B48 RID: 76616 RVA: 0x002BB349 File Offset: 0x002B9549
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

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x06012B49 RID: 76617 RVA: 0x002BB352 File Offset: 0x002B9552
		// (set) Token: 0x06012B4A RID: 76618 RVA: 0x002BB35A File Offset: 0x002B955A
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

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x06012B4B RID: 76619 RVA: 0x002BB363 File Offset: 0x002B9563
		// (set) Token: 0x06012B4C RID: 76620 RVA: 0x002BB36B File Offset: 0x002B956B
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

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x06012B4D RID: 76621 RVA: 0x002BB374 File Offset: 0x002B9574
		// (set) Token: 0x06012B4E RID: 76622 RVA: 0x002BB37C File Offset: 0x002B957C
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

		// Token: 0x06012B4F RID: 76623 RVA: 0x002BB385 File Offset: 0x002B9585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLocation);
		}

		// Token: 0x06012B50 RID: 76624 RVA: 0x002BB394 File Offset: 0x002B9594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLocation other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.PlayerId == other.PlayerId && object.Equals(this.Location, other.Location) && object.Equals(this.GravityDirection, other.GravityDirection) && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B51 RID: 76625 RVA: 0x002BB418 File Offset: 0x002B9618
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

		// Token: 0x06012B52 RID: 76626 RVA: 0x002BB4B5 File Offset: 0x002B96B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B53 RID: 76627 RVA: 0x002BB4C2 File Offset: 0x002B96C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B54 RID: 76628 RVA: 0x002BB4CC File Offset: 0x002B96CC
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

		// Token: 0x06012B55 RID: 76629 RVA: 0x002BB578 File Offset: 0x002B9778
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

		// Token: 0x06012B56 RID: 76630 RVA: 0x002BB618 File Offset: 0x002B9818
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

		// Token: 0x06012B57 RID: 76631 RVA: 0x002BB6D4 File Offset: 0x002B98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B58 RID: 76632 RVA: 0x002BB6E0 File Offset: 0x002B98E0
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

		// Token: 0x04007466 RID: 29798
		private static readonly MessageParser<PlayerLocation> _parser = new MessageParser<PlayerLocation>(() => new PlayerLocation());

		// Token: 0x04007467 RID: 29799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007468 RID: 29800
		public const int MapIdFieldNumber = 1;

		// Token: 0x04007469 RID: 29801
		private int mapId_;

		// Token: 0x0400746A RID: 29802
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x0400746B RID: 29803
		private int playerId_;

		// Token: 0x0400746C RID: 29804
		public const int LocationFieldNumber = 3;

		// Token: 0x0400746D RID: 29805
		private Vector location_;

		// Token: 0x0400746E RID: 29806
		public const int GravityDirectionFieldNumber = 4;

		// Token: 0x0400746F RID: 29807
		private Vector gravityDirection_;

		// Token: 0x04007470 RID: 29808
		public const int AreaIdFieldNumber = 5;

		// Token: 0x04007471 RID: 29809
		private int areaId_;
	}
}
