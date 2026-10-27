using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E2 RID: 2530
	public sealed class MobileButtonSetting : IMessage<MobileButtonSetting>, IMessage, IEquatable<MobileButtonSetting>, IDeepCloneable<MobileButtonSetting>, IBufferMessage
	{
		// Token: 0x0600DDAD RID: 56749 RVA: 0x00208335 File Offset: 0x00206535
		[NullableContext(1)]
		public static MobileButtonSetting Create()
		{
			return new MobileButtonSetting();
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600DDAE RID: 56750 RVA: 0x0020833C File Offset: 0x0020653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MobileButtonSetting> Parser
		{
			get
			{
				return MobileButtonSetting._parser;
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x00208343 File Offset: 0x00206543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x00208346 File Offset: 0x00206546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSetting.Descriptor;
			}
		}

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x0020834D File Offset: 0x0020654D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSetting()
		{
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x00208358 File Offset: 0x00206558
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

		// Token: 0x0600DDB3 RID: 56755 RVA: 0x002083D0 File Offset: 0x002065D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSetting Clone()
		{
			return new MobileButtonSetting(this);
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600DDB4 RID: 56756 RVA: 0x002083D8 File Offset: 0x002065D8
		// (set) Token: 0x0600DDB5 RID: 56757 RVA: 0x002083E0 File Offset: 0x002065E0
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

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0600DDB6 RID: 56758 RVA: 0x002083E9 File Offset: 0x002065E9
		// (set) Token: 0x0600DDB7 RID: 56759 RVA: 0x002083F1 File Offset: 0x002065F1
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

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x002083FA File Offset: 0x002065FA
		// (set) Token: 0x0600DDB9 RID: 56761 RVA: 0x00208402 File Offset: 0x00206602
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

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0600DDBA RID: 56762 RVA: 0x0020840B File Offset: 0x0020660B
		// (set) Token: 0x0600DDBB RID: 56763 RVA: 0x00208413 File Offset: 0x00206613
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

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0600DDBC RID: 56764 RVA: 0x0020841C File Offset: 0x0020661C
		// (set) Token: 0x0600DDBD RID: 56765 RVA: 0x00208424 File Offset: 0x00206624
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

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0600DDBE RID: 56766 RVA: 0x0020842D File Offset: 0x0020662D
		// (set) Token: 0x0600DDBF RID: 56767 RVA: 0x00208435 File Offset: 0x00206635
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

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x0020843E File Offset: 0x0020663E
		// (set) Token: 0x0600DDC1 RID: 56769 RVA: 0x00208446 File Offset: 0x00206646
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

		// Token: 0x0600DDC2 RID: 56770 RVA: 0x0020844F File Offset: 0x0020664F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSetting);
		}

		// Token: 0x0600DDC3 RID: 56771 RVA: 0x00208460 File Offset: 0x00206660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSetting other)
		{
			return other != null && (other == this || (this.Id == other.Id && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Size, other.Size) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Transparency, other.Transparency) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScreenX, other.ScreenX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScreenY, other.ScreenY) && this.ButtonLevel == other.ButtonLevel && this.PanelLevel == other.PanelLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x00208524 File Offset: 0x00206724
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

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x00208615 File Offset: 0x00206815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDC6 RID: 56774 RVA: 0x00208622 File Offset: 0x00206822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x0020862C File Offset: 0x0020682C
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

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x00208724 File Offset: 0x00206924
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

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x002087D8 File Offset: 0x002069D8
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

		// Token: 0x0600DDCA RID: 56778 RVA: 0x002088A0 File Offset: 0x00206AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDCB RID: 56779 RVA: 0x002088AC File Offset: 0x00206AAC
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

		// Token: 0x04005B9E RID: 23454
		private static readonly MessageParser<MobileButtonSetting> _parser = new MessageParser<MobileButtonSetting>(() => new MobileButtonSetting());

		// Token: 0x04005B9F RID: 23455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BA0 RID: 23456
		public const int IdFieldNumber = 1;

		// Token: 0x04005BA1 RID: 23457
		private int id_;

		// Token: 0x04005BA2 RID: 23458
		public const int SizeFieldNumber = 2;

		// Token: 0x04005BA3 RID: 23459
		private float size_;

		// Token: 0x04005BA4 RID: 23460
		public const int TransparencyFieldNumber = 3;

		// Token: 0x04005BA5 RID: 23461
		private float transparency_;

		// Token: 0x04005BA6 RID: 23462
		public const int ScreenXFieldNumber = 4;

		// Token: 0x04005BA7 RID: 23463
		private float screenX_;

		// Token: 0x04005BA8 RID: 23464
		public const int ScreenYFieldNumber = 5;

		// Token: 0x04005BA9 RID: 23465
		private float screenY_;

		// Token: 0x04005BAA RID: 23466
		public const int ButtonLevelFieldNumber = 6;

		// Token: 0x04005BAB RID: 23467
		private int buttonLevel_;

		// Token: 0x04005BAC RID: 23468
		public const int PanelLevelFieldNumber = 7;

		// Token: 0x04005BAD RID: 23469
		private int panelLevel_;
	}
}
