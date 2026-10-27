using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC5 RID: 3013
	public sealed class PartInformation : IMessage<PartInformation>, IMessage, IEquatable<PartInformation>, IDeepCloneable<PartInformation>, IBufferMessage
	{
		// Token: 0x0601052B RID: 66859 RVA: 0x00261911 File Offset: 0x0025FB11
		[NullableContext(1)]
		public static PartInformation Create()
		{
			return new PartInformation();
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0601052C RID: 66860 RVA: 0x00261918 File Offset: 0x0025FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartInformation> Parser
		{
			get
			{
				return PartInformation._parser;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0601052D RID: 66861 RVA: 0x0026191F File Offset: 0x0025FB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0601052E RID: 66862 RVA: 0x00261922 File Offset: 0x0025FB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartInformation.Descriptor;
			}
		}

		// Token: 0x0601052F RID: 66863 RVA: 0x00261929 File Offset: 0x0025FB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation()
		{
		}

		// Token: 0x06010530 RID: 66864 RVA: 0x00261934 File Offset: 0x0025FB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation(PartInformation other) : this()
		{
			this.partId_ = other.partId_;
			this.lifeValue_ = other.lifeValue_;
			this.lifeMax_ = other.lifeMax_;
			this.activated_ = other.activated_;
			this.partTag_ = other.partTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010531 RID: 66865 RVA: 0x00261994 File Offset: 0x0025FB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartInformation Clone()
		{
			return new PartInformation(this);
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x06010532 RID: 66866 RVA: 0x0026199C File Offset: 0x0025FB9C
		// (set) Token: 0x06010533 RID: 66867 RVA: 0x002619A4 File Offset: 0x0025FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x06010534 RID: 66868 RVA: 0x002619AD File Offset: 0x0025FBAD
		// (set) Token: 0x06010535 RID: 66869 RVA: 0x002619B5 File Offset: 0x0025FBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LifeValue
		{
			get
			{
				return this.lifeValue_;
			}
			set
			{
				this.lifeValue_ = value;
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x06010536 RID: 66870 RVA: 0x002619BE File Offset: 0x0025FBBE
		// (set) Token: 0x06010537 RID: 66871 RVA: 0x002619C6 File Offset: 0x0025FBC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LifeMax
		{
			get
			{
				return this.lifeMax_;
			}
			set
			{
				this.lifeMax_ = value;
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x06010538 RID: 66872 RVA: 0x002619CF File Offset: 0x0025FBCF
		// (set) Token: 0x06010539 RID: 66873 RVA: 0x002619D7 File Offset: 0x0025FBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Activated
		{
			get
			{
				return this.activated_;
			}
			set
			{
				this.activated_ = value;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0601053A RID: 66874 RVA: 0x002619E0 File Offset: 0x0025FBE0
		// (set) Token: 0x0601053B RID: 66875 RVA: 0x002619E8 File Offset: 0x0025FBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartTag
		{
			get
			{
				return this.partTag_;
			}
			set
			{
				this.partTag_ = value;
			}
		}

		// Token: 0x0601053C RID: 66876 RVA: 0x002619F1 File Offset: 0x0025FBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartInformation);
		}

		// Token: 0x0601053D RID: 66877 RVA: 0x00261A00 File Offset: 0x0025FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartInformation other)
		{
			return other != null && (other == this || (this.PartId == other.PartId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LifeValue, other.LifeValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LifeMax, other.LifeMax) && this.Activated == other.Activated && this.PartTag == other.PartTag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601053E RID: 66878 RVA: 0x00261A90 File Offset: 0x0025FC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.LifeValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LifeValue);
			}
			if (this.LifeMax != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LifeMax);
			}
			if (this.Activated)
			{
				num ^= this.Activated.GetHashCode();
			}
			if (this.PartTag != 0)
			{
				num ^= this.PartTag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601053F RID: 66879 RVA: 0x00261B41 File Offset: 0x0025FD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010540 RID: 66880 RVA: 0x00261B4E File Offset: 0x0025FD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010541 RID: 66881 RVA: 0x00261B58 File Offset: 0x0025FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartId);
			}
			if (this.LifeValue != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.LifeValue);
			}
			if (this.LifeMax != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.LifeMax);
			}
			if (this.Activated)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Activated);
			}
			if (this.PartTag != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PartTag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010542 RID: 66882 RVA: 0x00261C10 File Offset: 0x0025FE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.LifeValue != 0f)
			{
				num += 5;
			}
			if (this.LifeMax != 0f)
			{
				num += 5;
			}
			if (this.Activated)
			{
				num += 2;
			}
			if (this.PartTag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartTag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010543 RID: 66883 RVA: 0x00261C94 File Offset: 0x0025FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.LifeValue != 0f)
			{
				this.LifeValue = other.LifeValue;
			}
			if (other.LifeMax != 0f)
			{
				this.LifeMax = other.LifeMax;
			}
			if (other.Activated)
			{
				this.Activated = other.Activated;
			}
			if (other.PartTag != 0)
			{
				this.PartTag = other.PartTag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010544 RID: 66884 RVA: 0x00261D2A File Offset: 0x0025FF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010545 RID: 66885 RVA: 0x00261D34 File Offset: 0x0025FF34
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
				if (num <= 21U)
				{
					if (num == 8U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
					if (num == 21U)
					{
						this.LifeValue = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 29U)
					{
						this.LifeMax = input.ReadFloat();
						continue;
					}
					if (num == 32U)
					{
						this.Activated = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PartTag = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040067B5 RID: 26549
		private static readonly MessageParser<PartInformation> _parser = new MessageParser<PartInformation>(() => new PartInformation());

		// Token: 0x040067B6 RID: 26550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067B7 RID: 26551
		public const int PartIdFieldNumber = 1;

		// Token: 0x040067B8 RID: 26552
		private int partId_;

		// Token: 0x040067B9 RID: 26553
		public const int LifeValueFieldNumber = 2;

		// Token: 0x040067BA RID: 26554
		private float lifeValue_;

		// Token: 0x040067BB RID: 26555
		public const int LifeMaxFieldNumber = 3;

		// Token: 0x040067BC RID: 26556
		private float lifeMax_;

		// Token: 0x040067BD RID: 26557
		public const int ActivatedFieldNumber = 4;

		// Token: 0x040067BE RID: 26558
		private bool activated_;

		// Token: 0x040067BF RID: 26559
		public const int PartTagFieldNumber = 5;

		// Token: 0x040067C0 RID: 26560
		private int partTag_;
	}
}
