using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DF RID: 5343
	[NetMessage(EMessageId.VisionExploreSkillSetRequest)]
	public sealed class VisionExploreSkillSetRequest : IMessage<VisionExploreSkillSetRequest>, IMessage, IEquatable<VisionExploreSkillSetRequest>, IDeepCloneable<VisionExploreSkillSetRequest>, IBufferMessage
	{
		// Token: 0x0601C409 RID: 115721 RVA: 0x00415331 File Offset: 0x00413531
		[NullableContext(1)]
		public static VisionExploreSkillSetRequest Create()
		{
			return new VisionExploreSkillSetRequest();
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x0601C40A RID: 115722 RVA: 0x00415338 File Offset: 0x00413538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x0601C40B RID: 115723 RVA: 0x0041533B File Offset: 0x0041353B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionExploreSkillSetRequest.Descriptor;
			}
		}

		// Token: 0x0601C40C RID: 115724 RVA: 0x00415342 File Offset: 0x00413542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest()
		{
		}

		// Token: 0x0601C40D RID: 115725 RVA: 0x0041534A File Offset: 0x0041354A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest(VisionExploreSkillSetRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.isAutoChange_ = other.isAutoChange_;
			this.rouletteType_ = other.rouletteType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C40E RID: 115726 RVA: 0x00415387 File Offset: 0x00413587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionExploreSkillSetRequest Clone()
		{
			return new VisionExploreSkillSetRequest(this);
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x0601C40F RID: 115727 RVA: 0x0041538F File Offset: 0x0041358F
		// (set) Token: 0x0601C410 RID: 115728 RVA: 0x00415397 File Offset: 0x00413597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x0601C411 RID: 115729 RVA: 0x004153A0 File Offset: 0x004135A0
		// (set) Token: 0x0601C412 RID: 115730 RVA: 0x004153A8 File Offset: 0x004135A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAutoChange
		{
			get
			{
				return this.isAutoChange_;
			}
			set
			{
				this.isAutoChange_ = value;
			}
		}

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x0601C413 RID: 115731 RVA: 0x004153B1 File Offset: 0x004135B1
		// (set) Token: 0x0601C414 RID: 115732 RVA: 0x004153B9 File Offset: 0x004135B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RouletteType RouletteType
		{
			get
			{
				return this.rouletteType_;
			}
			set
			{
				this.rouletteType_ = value;
			}
		}

		// Token: 0x0601C415 RID: 115733 RVA: 0x004153C2 File Offset: 0x004135C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionExploreSkillSetRequest);
		}

		// Token: 0x0601C416 RID: 115734 RVA: 0x004153D0 File Offset: 0x004135D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionExploreSkillSetRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.IsAutoChange == other.IsAutoChange && this.RouletteType == other.RouletteType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C417 RID: 115735 RVA: 0x0041542C File Offset: 0x0041362C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.IsAutoChange)
			{
				num ^= this.IsAutoChange.GetHashCode();
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num ^= this.RouletteType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C418 RID: 115736 RVA: 0x004154A3 File Offset: 0x004136A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C419 RID: 115737 RVA: 0x004154B0 File Offset: 0x004136B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C41A RID: 115738 RVA: 0x004154BC File Offset: 0x004136BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this.IsAutoChange)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsAutoChange);
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RouletteType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C41B RID: 115739 RVA: 0x00415534 File Offset: 0x00413734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.IsAutoChange)
			{
				num += 2;
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RouletteType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C41C RID: 115740 RVA: 0x00415598 File Offset: 0x00413798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionExploreSkillSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.IsAutoChange)
			{
				this.IsAutoChange = other.IsAutoChange;
			}
			if (other.RouletteType != RouletteType.Explore)
			{
				this.RouletteType = other.RouletteType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C41D RID: 115741 RVA: 0x004155FC File Offset: 0x004137FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C41E RID: 115742 RVA: 0x00415608 File Offset: 0x00413808
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RouletteType = (RouletteType)input.ReadEnum();
						}
					}
					else
					{
						this.IsAutoChange = input.ReadBool();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1F6 RID: 41462
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1F7 RID: 41463
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400A1F8 RID: 41464
		private int skillId_;

		// Token: 0x0400A1F9 RID: 41465
		public const int IsAutoChangeFieldNumber = 7;

		// Token: 0x0400A1FA RID: 41466
		private bool isAutoChange_;

		// Token: 0x0400A1FB RID: 41467
		public const int RouletteTypeFieldNumber = 9;

		// Token: 0x0400A1FC RID: 41468
		private RouletteType rouletteType_;
	}
}
