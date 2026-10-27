using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BA RID: 954
	public sealed class DecalInfo : IMessage<DecalInfo>, IMessage, IEquatable<DecalInfo>, IDeepCloneable<DecalInfo>, IBufferMessage
	{
		// Token: 0x06005D73 RID: 23923 RVA: 0x000E2AF5 File Offset: 0x000E0CF5
		[NullableContext(1)]
		public static DecalInfo Create()
		{
			return new DecalInfo();
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x000E2AFC File Offset: 0x000E0CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DecalInfo> Parser
		{
			get
			{
				return DecalInfo._parser;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x000E2B03 File Offset: 0x000E0D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x000E2B06 File Offset: 0x000E0D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalInfo.Descriptor;
			}
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x000E2B0D File Offset: 0x000E0D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalInfo()
		{
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x000E2B18 File Offset: 0x000E0D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalInfo(DecalInfo other) : this()
		{
			this.decalId_ = other.decalId_;
			this.sceneId_ = other.sceneId_;
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.effectId_ = other.effectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x000E2B98 File Offset: 0x000E0D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalInfo Clone()
		{
			return new DecalInfo(this);
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x000E2BA0 File Offset: 0x000E0DA0
		// (set) Token: 0x06005D7B RID: 23931 RVA: 0x000E2BA8 File Offset: 0x000E0DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DecalId
		{
			get
			{
				return this.decalId_;
			}
			set
			{
				this.decalId_ = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06005D7C RID: 23932 RVA: 0x000E2BB1 File Offset: 0x000E0DB1
		// (set) Token: 0x06005D7D RID: 23933 RVA: 0x000E2BB9 File Offset: 0x000E0DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06005D7E RID: 23934 RVA: 0x000E2BC2 File Offset: 0x000E0DC2
		// (set) Token: 0x06005D7F RID: 23935 RVA: 0x000E2BCA File Offset: 0x000E0DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x000E2BD3 File Offset: 0x000E0DD3
		// (set) Token: 0x06005D81 RID: 23937 RVA: 0x000E2BDB File Offset: 0x000E0DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rotation
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

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06005D82 RID: 23938 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
		// (set) Token: 0x06005D83 RID: 23939 RVA: 0x000E2BEC File Offset: 0x000E0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x000E2BF5 File Offset: 0x000E0DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalInfo);
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x000E2C04 File Offset: 0x000E0E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalInfo other)
		{
			return other != null && (other == this || (this.DecalId == other.DecalId && this.SceneId == other.SceneId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x000E2C88 File Offset: 0x000E0E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DecalId != 0L)
			{
				num ^= this.DecalId.GetHashCode();
			}
			if (this.SceneId != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.position_ != null)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x000E2D25 File Offset: 0x000E0F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x000E2D32 File Offset: 0x000E0F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x000E2D3C File Offset: 0x000E0F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DecalId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.DecalId);
			}
			if (this.SceneId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SceneId);
			}
			if (this.position_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Position);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rotation);
			}
			if (this.EffectId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x000E2DE8 File Offset: 0x000E0FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DecalId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DecalId);
			}
			if (this.SceneId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneId);
			}
			if (this.position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Position);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x000E2E88 File Offset: 0x000E1088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecalInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DecalId != 0L)
			{
				this.DecalId = other.DecalId;
			}
			if (other.SceneId != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.position_ != null)
			{
				if (this.position_ == null)
				{
					this.Position = new Vector();
				}
				this.Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Vector();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x000E2F44 File Offset: 0x000E1144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x000E2F50 File Offset: 0x000E1150
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
						this.DecalId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.SceneId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.position_ == null)
						{
							this.Position = new Vector();
						}
						input.ReadMessage(this.Position);
						continue;
					}
					if (num == 34U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 40U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400368A RID: 13962
		private static readonly MessageParser<DecalInfo> _parser = new MessageParser<DecalInfo>(() => new DecalInfo());

		// Token: 0x0400368B RID: 13963
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400368C RID: 13964
		public const int DecalIdFieldNumber = 1;

		// Token: 0x0400368D RID: 13965
		private long decalId_;

		// Token: 0x0400368E RID: 13966
		public const int SceneIdFieldNumber = 2;

		// Token: 0x0400368F RID: 13967
		private int sceneId_;

		// Token: 0x04003690 RID: 13968
		public const int PositionFieldNumber = 3;

		// Token: 0x04003691 RID: 13969
		private Vector position_;

		// Token: 0x04003692 RID: 13970
		public const int RotationFieldNumber = 4;

		// Token: 0x04003693 RID: 13971
		private Vector rotation_;

		// Token: 0x04003694 RID: 13972
		public const int EffectIdFieldNumber = 5;

		// Token: 0x04003695 RID: 13973
		private int effectId_;
	}
}
