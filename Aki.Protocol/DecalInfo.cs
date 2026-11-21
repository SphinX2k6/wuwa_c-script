using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A3 RID: 931
	public sealed class DecalInfo : IMessage<DecalInfo>, IMessage, IEquatable<DecalInfo>, IDeepCloneable<DecalInfo>, IBufferMessage
	{
		// Token: 0x06005BE1 RID: 23521 RVA: 0x000DF8AD File Offset: 0x000DDAAD
		[NullableContext(1)]
		public static DecalInfo Create()
		{
			return new DecalInfo();
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x000DF8B4 File Offset: 0x000DDAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DecalInfo> Parser
		{
			get
			{
				return DecalInfo._parser;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x000DF8BB File Offset: 0x000DDABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x000DF8BE File Offset: 0x000DDABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalInfo.Descriptor;
			}
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x000DF8C5 File Offset: 0x000DDAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalInfo()
		{
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x000DF8D0 File Offset: 0x000DDAD0
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

		// Token: 0x06005BE7 RID: 23527 RVA: 0x000DF950 File Offset: 0x000DDB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalInfo Clone()
		{
			return new DecalInfo(this);
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x000DF958 File Offset: 0x000DDB58
		// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x000DF960 File Offset: 0x000DDB60
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

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x000DF969 File Offset: 0x000DDB69
		// (set) Token: 0x06005BEB RID: 23531 RVA: 0x000DF971 File Offset: 0x000DDB71
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

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x000DF97A File Offset: 0x000DDB7A
		// (set) Token: 0x06005BED RID: 23533 RVA: 0x000DF982 File Offset: 0x000DDB82
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

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06005BEE RID: 23534 RVA: 0x000DF98B File Offset: 0x000DDB8B
		// (set) Token: 0x06005BEF RID: 23535 RVA: 0x000DF993 File Offset: 0x000DDB93
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

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x000DF99C File Offset: 0x000DDB9C
		// (set) Token: 0x06005BF1 RID: 23537 RVA: 0x000DF9A4 File Offset: 0x000DDBA4
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

		// Token: 0x06005BF2 RID: 23538 RVA: 0x000DF9AD File Offset: 0x000DDBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalInfo);
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x000DF9BC File Offset: 0x000DDBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalInfo other)
		{
			return other != null && (other == this || (this.DecalId == other.DecalId && this.SceneId == other.SceneId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x000DFA40 File Offset: 0x000DDC40
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

		// Token: 0x06005BF5 RID: 23541 RVA: 0x000DFADD File Offset: 0x000DDCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x000DFAEA File Offset: 0x000DDCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x000DFAF4 File Offset: 0x000DDCF4
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

		// Token: 0x06005BF8 RID: 23544 RVA: 0x000DFBA0 File Offset: 0x000DDDA0
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

		// Token: 0x06005BF9 RID: 23545 RVA: 0x000DFC40 File Offset: 0x000DDE40
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

		// Token: 0x06005BFA RID: 23546 RVA: 0x000DFCFC File Offset: 0x000DDEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x000DFD08 File Offset: 0x000DDF08
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

		// Token: 0x04003675 RID: 13941
		private static readonly MessageParser<DecalInfo> _parser = new MessageParser<DecalInfo>(() => new DecalInfo());

		// Token: 0x04003676 RID: 13942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003677 RID: 13943
		public const int DecalIdFieldNumber = 1;

		// Token: 0x04003678 RID: 13944
		private long decalId_;

		// Token: 0x04003679 RID: 13945
		public const int SceneIdFieldNumber = 2;

		// Token: 0x0400367A RID: 13946
		private int sceneId_;

		// Token: 0x0400367B RID: 13947
		public const int PositionFieldNumber = 3;

		// Token: 0x0400367C RID: 13948
		private Vector position_;

		// Token: 0x0400367D RID: 13949
		public const int RotationFieldNumber = 4;

		// Token: 0x0400367E RID: 13950
		private Vector rotation_;

		// Token: 0x0400367F RID: 13951
		public const int EffectIdFieldNumber = 5;

		// Token: 0x04003680 RID: 13952
		private int effectId_;
	}
}
