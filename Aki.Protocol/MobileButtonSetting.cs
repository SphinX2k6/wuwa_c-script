using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D1 RID: 2513
	public sealed class MobileButtonSetting : IMessage<MobileButtonSetting>, IMessage, IEquatable<MobileButtonSetting>, IDeepCloneable<MobileButtonSetting>, IBufferMessage
	{
		// Token: 0x0600DC93 RID: 56467 RVA: 0x00206149 File Offset: 0x00204349
		[NullableContext(1)]
		public static MobileButtonSetting Create()
		{
			return new MobileButtonSetting();
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600DC94 RID: 56468 RVA: 0x00206150 File Offset: 0x00204350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MobileButtonSetting> Parser
		{
			get
			{
				return MobileButtonSetting._parser;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x00206157 File Offset: 0x00204357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x0020615A File Offset: 0x0020435A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSetting.Descriptor;
			}
		}

		// Token: 0x0600DC97 RID: 56471 RVA: 0x00206161 File Offset: 0x00204361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSetting()
		{
		}

		// Token: 0x0600DC98 RID: 56472 RVA: 0x0020616C File Offset: 0x0020436C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSetting(MobileButtonSetting other) : this()
		{
			this.id_ = other.id_;
			this.size_ = other.size_;
			this.transparency_ = other.transparency_;
			this.screenX_ = other.screenX_;
			this.screenY_ = other.screenY_;
			this.buttonLevel_ = other.buttonLevel_;
			this.panelLevel_ = other.panelLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC99 RID: 56473 RVA: 0x002061E4 File Offset: 0x002043E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSetting Clone()
		{
			return new MobileButtonSetting(this);
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x002061EC File Offset: 0x002043EC
		// (set) Token: 0x0600DC9B RID: 56475 RVA: 0x002061F4 File Offset: 0x002043F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0600DC9C RID: 56476 RVA: 0x002061FD File Offset: 0x002043FD
		// (set) Token: 0x0600DC9D RID: 56477 RVA: 0x00206205 File Offset: 0x00204405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x0020620E File Offset: 0x0020440E
		// (set) Token: 0x0600DC9F RID: 56479 RVA: 0x00206216 File Offset: 0x00204416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Transparency
		{
			get
			{
				return this.transparency_;
			}
			set
			{
				this.transparency_ = value;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0600DCA0 RID: 56480 RVA: 0x0020621F File Offset: 0x0020441F
		// (set) Token: 0x0600DCA1 RID: 56481 RVA: 0x00206227 File Offset: 0x00204427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ScreenX
		{
			get
			{
				return this.screenX_;
			}
			set
			{
				this.screenX_ = value;
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x00206230 File Offset: 0x00204430
		// (set) Token: 0x0600DCA3 RID: 56483 RVA: 0x00206238 File Offset: 0x00204438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ScreenY
		{
			get
			{
				return this.screenY_;
			}
			set
			{
				this.screenY_ = value;
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x00206241 File Offset: 0x00204441
		// (set) Token: 0x0600DCA5 RID: 56485 RVA: 0x00206249 File Offset: 0x00204449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ButtonLevel
		{
			get
			{
				return this.buttonLevel_;
			}
			set
			{
				this.buttonLevel_ = value;
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0600DCA6 RID: 56486 RVA: 0x00206252 File Offset: 0x00204452
		// (set) Token: 0x0600DCA7 RID: 56487 RVA: 0x0020625A File Offset: 0x0020445A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PanelLevel
		{
			get
			{
				return this.panelLevel_;
			}
			set
			{
				this.panelLevel_ = value;
			}
		}

		// Token: 0x0600DCA8 RID: 56488 RVA: 0x00206263 File Offset: 0x00204463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSetting);
		}

		// Token: 0x0600DCA9 RID: 56489 RVA: 0x00206274 File Offset: 0x00204474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSetting other)
		{
			return other != null && (other == this || (this.Id == other.Id && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Size, other.Size) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Transparency, other.Transparency) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScreenX, other.ScreenX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScreenY, other.ScreenY) && this.ButtonLevel == other.ButtonLevel && this.PanelLevel == other.PanelLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCAA RID: 56490 RVA: 0x00206338 File Offset: 0x00204538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Size != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Size);
			}
			if (this.Transparency != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Transparency);
			}
			if (this.ScreenX != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScreenX);
			}
			if (this.ScreenY != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScreenY);
			}
			if (this.ButtonLevel != 0)
			{
				num ^= this.ButtonLevel.GetHashCode();
			}
			if (this.PanelLevel != 0)
			{
				num ^= this.PanelLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCAB RID: 56491 RVA: 0x00206429 File Offset: 0x00204629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCAC RID: 56492 RVA: 0x00206436 File Offset: 0x00204636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCAD RID: 56493 RVA: 0x00206440 File Offset: 0x00204640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Size != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Size);
			}
			if (this.Transparency != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Transparency);
			}
			if (this.ScreenX != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.ScreenX);
			}
			if (this.ScreenY != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.ScreenY);
			}
			if (this.ButtonLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ButtonLevel);
			}
			if (this.PanelLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PanelLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCAE RID: 56494 RVA: 0x00206538 File Offset: 0x00204738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Size != 0f)
			{
				num += 5;
			}
			if (this.Transparency != 0f)
			{
				num += 5;
			}
			if (this.ScreenX != 0f)
			{
				num += 5;
			}
			if (this.ScreenY != 0f)
			{
				num += 5;
			}
			if (this.ButtonLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ButtonLevel);
			}
			if (this.PanelLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PanelLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCAF RID: 56495 RVA: 0x002065EC File Offset: 0x002047EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MobileButtonSetting other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Size != 0f)
			{
				this.Size = other.Size;
			}
			if (other.Transparency != 0f)
			{
				this.Transparency = other.Transparency;
			}
			if (other.ScreenX != 0f)
			{
				this.ScreenX = other.ScreenX;
			}
			if (other.ScreenY != 0f)
			{
				this.ScreenY = other.ScreenY;
			}
			if (other.ButtonLevel != 0)
			{
				this.ButtonLevel = other.ButtonLevel;
			}
			if (other.PanelLevel != 0)
			{
				this.PanelLevel = other.PanelLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x002066B4 File Offset: 0x002048B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCB1 RID: 56497 RVA: 0x002066C0 File Offset: 0x002048C0
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
				if (num <= 29U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 21U)
					{
						this.Size = input.ReadFloat();
						continue;
					}
					if (num == 29U)
					{
						this.Transparency = input.ReadFloat();
						continue;
					}
				}
				else if (num <= 45U)
				{
					if (num == 37U)
					{
						this.ScreenX = input.ReadFloat();
						continue;
					}
					if (num == 45U)
					{
						this.ScreenY = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ButtonLevel = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PanelLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BA7 RID: 23463
		private static readonly MessageParser<MobileButtonSetting> _parser = new MessageParser<MobileButtonSetting>(() => new MobileButtonSetting());

		// Token: 0x04005BA8 RID: 23464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BA9 RID: 23465
		public const int IdFieldNumber = 1;

		// Token: 0x04005BAA RID: 23466
		private int id_;

		// Token: 0x04005BAB RID: 23467
		public const int SizeFieldNumber = 2;

		// Token: 0x04005BAC RID: 23468
		private float size_;

		// Token: 0x04005BAD RID: 23469
		public const int TransparencyFieldNumber = 3;

		// Token: 0x04005BAE RID: 23470
		private float transparency_;

		// Token: 0x04005BAF RID: 23471
		public const int ScreenXFieldNumber = 4;

		// Token: 0x04005BB0 RID: 23472
		private float screenX_;

		// Token: 0x04005BB1 RID: 23473
		public const int ScreenYFieldNumber = 5;

		// Token: 0x04005BB2 RID: 23474
		private float screenY_;

		// Token: 0x04005BB3 RID: 23475
		public const int ButtonLevelFieldNumber = 6;

		// Token: 0x04005BB4 RID: 23476
		private int buttonLevel_;

		// Token: 0x04005BB5 RID: 23477
		public const int PanelLevelFieldNumber = 7;

		// Token: 0x04005BB6 RID: 23478
		private int panelLevel_;
	}
}
