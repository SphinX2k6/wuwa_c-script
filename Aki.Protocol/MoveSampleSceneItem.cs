using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC0 RID: 2752
	public sealed class MoveSampleSceneItem : IMessage<MoveSampleSceneItem>, IMessage, IEquatable<MoveSampleSceneItem>, IDeepCloneable<MoveSampleSceneItem>, IBufferMessage
	{
		// Token: 0x0600EF91 RID: 61329 RVA: 0x0022FDE6 File Offset: 0x0022DFE6
		[NullableContext(1)]
		public static MoveSampleSceneItem Create()
		{
			return new MoveSampleSceneItem();
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x0022FDED File Offset: 0x0022DFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoveSampleSceneItem> Parser
		{
			get
			{
				return MoveSampleSceneItem._parser;
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600EF93 RID: 61331 RVA: 0x0022FDF4 File Offset: 0x0022DFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600EF94 RID: 61332 RVA: 0x0022FDF7 File Offset: 0x0022DFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSampleSceneItem.Descriptor;
			}
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x0022FDFE File Offset: 0x0022DFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSampleSceneItem()
		{
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x0022FE08 File Offset: 0x0022E008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSampleSceneItem(MoveSampleSceneItem other) : this()
		{
			this.linearVelocity_ = ((other.linearVelocity_ != null) ? other.linearVelocity_.Clone() : null);
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.timeStamp_ = other.timeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x0022FE8C File Offset: 0x0022E08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSampleSceneItem Clone()
		{
			return new MoveSampleSceneItem(this);
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600EF98 RID: 61336 RVA: 0x0022FE94 File Offset: 0x0022E094
		// (set) Token: 0x0600EF99 RID: 61337 RVA: 0x0022FE9C File Offset: 0x0022E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector LinearVelocity
		{
			get
			{
				return this.linearVelocity_;
			}
			set
			{
				this.linearVelocity_ = value;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x0022FEA5 File Offset: 0x0022E0A5
		// (set) Token: 0x0600EF9B RID: 61339 RVA: 0x0022FEAD File Offset: 0x0022E0AD
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

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x0022FEB6 File Offset: 0x0022E0B6
		// (set) Token: 0x0600EF9D RID: 61341 RVA: 0x0022FEBE File Offset: 0x0022E0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600EF9E RID: 61342 RVA: 0x0022FEC7 File Offset: 0x0022E0C7
		// (set) Token: 0x0600EF9F RID: 61343 RVA: 0x0022FECF File Offset: 0x0022E0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x0022FED8 File Offset: 0x0022E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSampleSceneItem);
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x0022FEE8 File Offset: 0x0022E0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSampleSceneItem other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFA2 RID: 61346 RVA: 0x0022FF6C File Offset: 0x0022E16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.linearVelocity_ != null)
			{
				num ^= this.LinearVelocity.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EFA3 RID: 61347 RVA: 0x0022FFF4 File Offset: 0x0022E1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x00230001 File Offset: 0x0022E201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x0023000C File Offset: 0x0022E20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.linearVelocity_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LinearVelocity);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TimeStamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x002300A4 File Offset: 0x0022E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.linearVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LinearVelocity);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00230124 File Offset: 0x0022E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSampleSceneItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.linearVelocity_ != null)
			{
				if (this.linearVelocity_ == null)
				{
					this.LinearVelocity = new Vector();
				}
				this.LinearVelocity.MergeFrom(other.LinearVelocity);
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x002301E9 File Offset: 0x0022E3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x002301F4 File Offset: 0x0022E3F4
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.linearVelocity_ == null)
						{
							this.LinearVelocity = new Vector();
						}
						input.ReadMessage(this.LinearVelocity);
						continue;
					}
					if (num == 18U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 37U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040060E4 RID: 24804
		private static readonly MessageParser<MoveSampleSceneItem> _parser = new MessageParser<MoveSampleSceneItem>(() => new MoveSampleSceneItem());

		// Token: 0x040060E5 RID: 24805
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060E6 RID: 24806
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x040060E7 RID: 24807
		private Vector linearVelocity_;

		// Token: 0x040060E8 RID: 24808
		public const int LocationFieldNumber = 2;

		// Token: 0x040060E9 RID: 24809
		private Vector location_;

		// Token: 0x040060EA RID: 24810
		public const int RotationFieldNumber = 3;

		// Token: 0x040060EB RID: 24811
		private Rotator rotation_;

		// Token: 0x040060EC RID: 24812
		public const int TimeStampFieldNumber = 4;

		// Token: 0x040060ED RID: 24813
		private float timeStamp_;
	}
}
