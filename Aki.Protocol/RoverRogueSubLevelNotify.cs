using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001164 RID: 4452
	[NetMessage(EMessageId.RoverRogueSubLevelNotify)]
	public sealed class RoverRogueSubLevelNotify : IMessage<RoverRogueSubLevelNotify>, IMessage, IEquatable<RoverRogueSubLevelNotify>, IDeepCloneable<RoverRogueSubLevelNotify>, IBufferMessage
	{
		// Token: 0x06017CAC RID: 97452 RVA: 0x00376E68 File Offset: 0x00375068
		[NullableContext(1)]
		public static RoverRogueSubLevelNotify Create()
		{
			return new RoverRogueSubLevelNotify();
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06017CAD RID: 97453 RVA: 0x00376E6F File Offset: 0x0037506F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x06017CAE RID: 97454 RVA: 0x00376E72 File Offset: 0x00375072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x06017CAF RID: 97455 RVA: 0x00376E79 File Offset: 0x00375079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSubLevelNotify()
		{
		}

		// Token: 0x06017CB0 RID: 97456 RVA: 0x00376E98 File Offset: 0x00375098
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

		// Token: 0x06017CB1 RID: 97457 RVA: 0x00376F1A File Offset: 0x0037511A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSubLevelNotify Clone()
		{
			return new RoverRogueSubLevelNotify(this);
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x06017CB2 RID: 97458 RVA: 0x00376F22 File Offset: 0x00375122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> LoadSubLevels
		{
			get
			{
				return this.loadSubLevels_;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x06017CB3 RID: 97459 RVA: 0x00376F2A File Offset: 0x0037512A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> UnLoadSubLevels
		{
			get
			{
				return this.unLoadSubLevels_;
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x06017CB4 RID: 97460 RVA: 0x00376F32 File Offset: 0x00375132
		// (set) Token: 0x06017CB5 RID: 97461 RVA: 0x00376F3A File Offset: 0x0037513A
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

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x06017CB6 RID: 97462 RVA: 0x00376F43 File Offset: 0x00375143
		// (set) Token: 0x06017CB7 RID: 97463 RVA: 0x00376F4B File Offset: 0x0037514B
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

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x06017CB8 RID: 97464 RVA: 0x00376F54 File Offset: 0x00375154
		// (set) Token: 0x06017CB9 RID: 97465 RVA: 0x00376F5C File Offset: 0x0037515C
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

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x06017CBA RID: 97466 RVA: 0x00376F65 File Offset: 0x00375165
		// (set) Token: 0x06017CBB RID: 97467 RVA: 0x00376F6D File Offset: 0x0037516D
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

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x06017CBC RID: 97468 RVA: 0x00376F76 File Offset: 0x00375176
		// (set) Token: 0x06017CBD RID: 97469 RVA: 0x00376F7E File Offset: 0x0037517E
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

		// Token: 0x06017CBE RID: 97470 RVA: 0x00376F87 File Offset: 0x00375187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueSubLevelNotify);
		}

		// Token: 0x06017CBF RID: 97471 RVA: 0x00376F98 File Offset: 0x00375198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueSubLevelNotify other)
		{
			return other != null && (other == this || (this.loadSubLevels_.Equals(other.loadSubLevels_) && this.unLoadSubLevels_.Equals(other.unLoadSubLevels_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CC0 RID: 97472 RVA: 0x00377064 File Offset: 0x00375264
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

		// Token: 0x06017CC1 RID: 97473 RVA: 0x0037713F File Offset: 0x0037533F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CC2 RID: 97474 RVA: 0x0037714C File Offset: 0x0037534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CC3 RID: 97475 RVA: 0x00377158 File Offset: 0x00375358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Y);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Layer);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.A);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Z);
			}
			this.unLoadSubLevels_.WriteTo(ref output, RoverRogueSubLevelNotify._repeated_unLoadSubLevels_codec);
			this.loadSubLevels_.WriteTo(ref output, RoverRogueSubLevelNotify._repeated_loadSubLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CC4 RID: 97476 RVA: 0x0037723C File Offset: 0x0037543C
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

		// Token: 0x06017CC5 RID: 97477 RVA: 0x003772E4 File Offset: 0x003754E4
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

		// Token: 0x06017CC6 RID: 97478 RVA: 0x003773A6 File Offset: 0x003755A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CC7 RID: 97479 RVA: 0x003773B0 File Offset: 0x003755B0
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
				if (num <= 32U)
				{
					if (num == 13U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
					if (num == 32U)
					{
						this.Layer = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 61U)
				{
					if (num == 45U)
					{
						this.A = input.ReadFloat();
						continue;
					}
					if (num == 61U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.unLoadSubLevels_.AddEntriesFrom(ref input, RoverRogueSubLevelNotify._repeated_unLoadSubLevels_codec);
						continue;
					}
					if (num == 114U)
					{
						this.loadSubLevels_.AddEntriesFrom(ref input, RoverRogueSubLevelNotify._repeated_loadSubLevels_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008DFA RID: 36346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DFB RID: 36347
		public const int LoadSubLevelsFieldNumber = 14;

		// Token: 0x04008DFC RID: 36348
		private static readonly FieldCodec<string> _repeated_loadSubLevels_codec = FieldCodec.ForString(114U);

		// Token: 0x04008DFD RID: 36349
		private readonly RepeatedField<string> loadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008DFE RID: 36350
		public const int UnLoadSubLevelsFieldNumber = 11;

		// Token: 0x04008DFF RID: 36351
		private static readonly FieldCodec<string> _repeated_unLoadSubLevels_codec = FieldCodec.ForString(90U);

		// Token: 0x04008E00 RID: 36352
		private readonly RepeatedField<string> unLoadSubLevels_ = new RepeatedField<string>();

		// Token: 0x04008E01 RID: 36353
		public const int XFieldNumber = 1;

		// Token: 0x04008E02 RID: 36354
		private float x_;

		// Token: 0x04008E03 RID: 36355
		public const int YFieldNumber = 3;

		// Token: 0x04008E04 RID: 36356
		private float y_;

		// Token: 0x04008E05 RID: 36357
		public const int ZFieldNumber = 7;

		// Token: 0x04008E06 RID: 36358
		private float z_;

		// Token: 0x04008E07 RID: 36359
		public const int AFieldNumber = 5;

		// Token: 0x04008E08 RID: 36360
		private float a_;

		// Token: 0x04008E09 RID: 36361
		public const int LayerFieldNumber = 4;

		// Token: 0x04008E0A RID: 36362
		private int layer_;
	}
}
