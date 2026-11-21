using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAF RID: 2735
	public sealed class MoveSampleSceneItem : IMessage<MoveSampleSceneItem>, IMessage, IEquatable<MoveSampleSceneItem>, IDeepCloneable<MoveSampleSceneItem>, IBufferMessage
	{
		// Token: 0x0600EE77 RID: 61047 RVA: 0x0022DBE2 File Offset: 0x0022BDE2
		[NullableContext(1)]
		public static MoveSampleSceneItem Create()
		{
			return new MoveSampleSceneItem();
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x0022DBE9 File Offset: 0x0022BDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoveSampleSceneItem> Parser
		{
			get
			{
				return MoveSampleSceneItem._parser;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600EE79 RID: 61049 RVA: 0x0022DBF0 File Offset: 0x0022BDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0600EE7A RID: 61050 RVA: 0x0022DBF3 File Offset: 0x0022BDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSampleSceneItem.Descriptor;
			}
		}

		// Token: 0x0600EE7B RID: 61051 RVA: 0x0022DBFA File Offset: 0x0022BDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSampleSceneItem()
		{
		}

		// Token: 0x0600EE7C RID: 61052 RVA: 0x0022DC04 File Offset: 0x0022BE04
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

		// Token: 0x0600EE7D RID: 61053 RVA: 0x0022DC88 File Offset: 0x0022BE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSampleSceneItem Clone()
		{
			return new MoveSampleSceneItem(this);
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600EE7E RID: 61054 RVA: 0x0022DC90 File Offset: 0x0022BE90
		// (set) Token: 0x0600EE7F RID: 61055 RVA: 0x0022DC98 File Offset: 0x0022BE98
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

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600EE80 RID: 61056 RVA: 0x0022DCA1 File Offset: 0x0022BEA1
		// (set) Token: 0x0600EE81 RID: 61057 RVA: 0x0022DCA9 File Offset: 0x0022BEA9
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

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600EE82 RID: 61058 RVA: 0x0022DCB2 File Offset: 0x0022BEB2
		// (set) Token: 0x0600EE83 RID: 61059 RVA: 0x0022DCBA File Offset: 0x0022BEBA
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

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600EE84 RID: 61060 RVA: 0x0022DCC3 File Offset: 0x0022BEC3
		// (set) Token: 0x0600EE85 RID: 61061 RVA: 0x0022DCCB File Offset: 0x0022BECB
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

		// Token: 0x0600EE86 RID: 61062 RVA: 0x0022DCD4 File Offset: 0x0022BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSampleSceneItem);
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x0022DCE4 File Offset: 0x0022BEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSampleSceneItem other)
		{
			return other != null && (other == this || (object.Equals(this.LinearVelocity, other.LinearVelocity) && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x0022DD68 File Offset: 0x0022BF68
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

		// Token: 0x0600EE89 RID: 61065 RVA: 0x0022DDF0 File Offset: 0x0022BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE8A RID: 61066 RVA: 0x0022DDFD File Offset: 0x0022BFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE8B RID: 61067 RVA: 0x0022DE08 File Offset: 0x0022C008
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

		// Token: 0x0600EE8C RID: 61068 RVA: 0x0022DEA0 File Offset: 0x0022C0A0
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

		// Token: 0x0600EE8D RID: 61069 RVA: 0x0022DF20 File Offset: 0x0022C120
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

		// Token: 0x0600EE8E RID: 61070 RVA: 0x0022DFE5 File Offset: 0x0022C1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE8F RID: 61071 RVA: 0x0022DFF0 File Offset: 0x0022C1F0
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

		// Token: 0x040060ED RID: 24813
		private static readonly MessageParser<MoveSampleSceneItem> _parser = new MessageParser<MoveSampleSceneItem>(() => new MoveSampleSceneItem());

		// Token: 0x040060EE RID: 24814
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060EF RID: 24815
		public const int LinearVelocityFieldNumber = 1;

		// Token: 0x040060F0 RID: 24816
		private Vector linearVelocity_;

		// Token: 0x040060F1 RID: 24817
		public const int LocationFieldNumber = 2;

		// Token: 0x040060F2 RID: 24818
		private Vector location_;

		// Token: 0x040060F3 RID: 24819
		public const int RotationFieldNumber = 3;

		// Token: 0x040060F4 RID: 24820
		private Rotator rotation_;

		// Token: 0x040060F5 RID: 24821
		public const int TimeStampFieldNumber = 4;

		// Token: 0x040060F6 RID: 24822
		private float timeStamp_;
	}
}
