using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112A RID: 4394
	[NetMessage(EMessageId.RoverRogueSubLevelNotify)]
	public sealed class RoverRogueSubLevelNotify : IMessage<RoverRogueSubLevelNotify>, IMessage, IEquatable<RoverRogueSubLevelNotify>, IDeepCloneable<RoverRogueSubLevelNotify>, IBufferMessage
	{
		// Token: 0x0601770B RID: 96011 RVA: 0x00367B1C File Offset: 0x00365D1C
		[NullableContext(1)]
		public static RoverRogueSubLevelNotify Create()
		{
			return new RoverRogueSubLevelNotify();
		}

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x0601770C RID: 96012 RVA: 0x00367B23 File Offset: 0x00365D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x0601770D RID: 96013 RVA: 0x00367B26 File Offset: 0x00365D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x0601770E RID: 96014 RVA: 0x00367B2D File Offset: 0x00365D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSubLevelNotify()
		{
		}

		// Token: 0x0601770F RID: 96015 RVA: 0x00367B4C File Offset: 0x00365D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSubLevelNotify(RoverRogueSubLevelNotify other) : this()
		{
			this.loadSubLevels_ = other.loadSubLevels_.Clone();
			this.unLoadSubLevels_ = other.unLoadSubLevels_.Clone();
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x00367BCE File Offset: 0x00365DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSubLevelNotify Clone()
		{
			return new RoverRogueSubLevelNotify(this);
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x06017711 RID: 96017 RVA: 0x00367BD6 File Offset: 0x00365DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x06017712 RID: 96018 RVA: 0x00367BDE File Offset: 0x00365DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x06017713 RID: 96019 RVA: 0x00367BE6 File Offset: 0x00365DE6
		// (set) Token: 0x06017714 RID: 96020 RVA: 0x00367BEE File Offset: 0x00365DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x06017715 RID: 96021 RVA: 0x00367BF7 File Offset: 0x00365DF7
		// (set) Token: 0x06017716 RID: 96022 RVA: 0x00367BFF File Offset: 0x00365DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x06017717 RID: 96023 RVA: 0x00367C08 File Offset: 0x00365E08
		// (set) Token: 0x06017718 RID: 96024 RVA: 0x00367C10 File Offset: 0x00365E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x06017719 RID: 96025 RVA: 0x00367C19 File Offset: 0x00365E19
		// (set) Token: 0x0601771A RID: 96026 RVA: 0x00367C21 File Offset: 0x00365E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float A
		{
			get
			{
				return this.a_;
			}
			set
			{
				this.a_ = value;
			}
		}

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x0601771B RID: 96027 RVA: 0x00367C2A File Offset: 0x00365E2A
		// (set) Token: 0x0601771C RID: 96028 RVA: 0x00367C32 File Offset: 0x00365E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x00367C3B File Offset: 0x00365E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueSubLevelNotify);
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x00367C4C File Offset: 0x00365E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueSubLevelNotify other)
		{
			return other != null && (other == this || (this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x00367D18 File Offset: 0x00365F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.loadSubLevels_.GetHashCode();
			num ^= this.unLoadSubLevels_.GetHashCode();
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.Z != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			if (this.A != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.A);
			}
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x00367DF3 File Offset: 0x00365FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00367E00 File Offset: 0x00366000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x00367E0C File Offset: 0x0036600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loadSubLevels_.WriteTo(ref output, RoverRogueSubLevelNotify._repeated_loadSubLevels_codec);
			if (this.A != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.A);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Z);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Layer);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.Y);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.X);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RoverRogueSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017723 RID: 96035 RVA: 0x00367EF0 File Offset: 0x003660F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.loadSubLevels_.CalculateSize(RoverRogueSubLevelNotify._repeated_loadSubLevels_codec);
			num += this.unLoadSubLevels_.CalculateSize(RoverRogueSubLevelNotify._repeated_unLoadSubLevels_codec);
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.Z != 0f)
			{
				num += 5;
			}
			if (this.A != 0f)
			{
				num += 5;
			}
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x00367F98 File Offset: 0x00366198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueSubLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.loadSubLevels_.Add(other.loadSubLevels_);
			this.unLoadSubLevels_.Add(other.unLoadSubLevels_);
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.Z != 0f)
			{
				this.Z = other.Z;
			}
			if (other.A != 0f)
			{
				this.A = other.A;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017725 RID: 96037 RVA: 0x0036805A File Offset: 0x0036625A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x00368064 File Offset: 0x00366264
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
				if (num <= 37U)
				{
					if (num == 18U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RoverRogueSubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
					if (num == 29U)
					{
						this.A = input.ReadFloat();
						continue;
					}
					if (num == 37U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
				}
				else if (num <= 69U)
				{
					if (num == 40U)
					{
						this.Layer = input.ReadInt32();
						continue;
					}
					if (num == 69U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 101U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 106U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RoverRogueSubLevelNotify._repeated_unLoadSubLevels_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B67 RID: 35687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B68 RID: 35688
		public const int LoadSubLevelsFieldNumber = 2;

		// Token: 0x04008B69 RID: 35689
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(18U);

		// Token: 0x04008B6A RID: 35690
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008B6B RID: 35691
		public const int UnLoadSubLevelsFieldNumber = 13;

		// Token: 0x04008B6C RID: 35692
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(106U);

		// Token: 0x04008B6D RID: 35693
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008B6E RID: 35694
		public const int XFieldNumber = 12;

		// Token: 0x04008B6F RID: 35695
		private float x_;

		// Token: 0x04008B70 RID: 35696
		public const int YFieldNumber = 8;

		// Token: 0x04008B71 RID: 35697
		private float y_;

		// Token: 0x04008B72 RID: 35698
		public const int ZFieldNumber = 4;

		// Token: 0x04008B73 RID: 35699
		private float z_;

		// Token: 0x04008B74 RID: 35700
		public const int AFieldNumber = 3;

		// Token: 0x04008B75 RID: 35701
		private float a_;

		// Token: 0x04008B76 RID: 35702
		public const int LayerFieldNumber = 5;

		// Token: 0x04008B77 RID: 35703
		private int layer_;
	}
}
