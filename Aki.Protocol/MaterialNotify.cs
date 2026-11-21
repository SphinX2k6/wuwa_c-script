using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B9 RID: 2489
	[NetMessage(EMessageId.MaterialNotify)]
	public sealed class MaterialNotify : IMessage<MaterialNotify>, IMessage, IEquatable<MaterialNotify>, IDeepCloneable<MaterialNotify>, IBufferMessage
	{
		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00202782 File Offset: 0x00200982
		[NullableContext(1)]
		public static MaterialNotify Create()
		{
			return new MaterialNotify();
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x00202789 File Offset: 0x00200989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x0020278C File Offset: 0x0020098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialNotify.Descriptor;
			}
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x00202793 File Offset: 0x00200993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify()
		{
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x0020279C File Offset: 0x0020099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify(MaterialNotify other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x002027F8 File Offset: 0x002009F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify Clone()
		{
			return new MaterialNotify(this);
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0600DAC9 RID: 56009 RVA: 0x00202800 File Offset: 0x00200A00
		// (set) Token: 0x0600DACA RID: 56010 RVA: 0x00202808 File Offset: 0x00200A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo MaterialInfo
		{
			get
			{
				return this.materialInfo_;
			}
			set
			{
				this.materialInfo_ = value;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0600DACB RID: 56011 RVA: 0x00202811 File Offset: 0x00200A11
		// (set) Token: 0x0600DACC RID: 56012 RVA: 0x00202819 File Offset: 0x00200A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x0600DACD RID: 56013 RVA: 0x00202822 File Offset: 0x00200A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialNotify);
		}

		// Token: 0x0600DACE RID: 56014 RVA: 0x00202830 File Offset: 0x00200A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x00202884 File Offset: 0x00200A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.materialInfo_ != null)
			{
				num ^= this.MaterialInfo.GetHashCode();
			}
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAD0 RID: 56016 RVA: 0x002028D6 File Offset: 0x00200AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x002028E3 File Offset: 0x00200AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x002028EC File Offset: 0x00200AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAD3 RID: 56019 RVA: 0x00202948 File Offset: 0x00200B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.materialInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialInfo);
			}
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x002029A0 File Offset: 0x00200BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.materialInfo_ != null)
			{
				if (this.materialInfo_ == null)
				{
					this.MaterialInfo = new MaterialInfo();
				}
				this.MaterialInfo.MergeFrom(other.MaterialInfo);
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DAD5 RID: 56021 RVA: 0x00202A20 File Offset: 0x00200C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x00202A2C File Offset: 0x00200C2C
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
				if (num != 18U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					if (this.materialInfo_ == null)
					{
						this.MaterialInfo = new MaterialInfo();
					}
					input.ReadMessage(this.MaterialInfo);
				}
			}
		}

		// Token: 0x04005B3A RID: 23354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B3B RID: 23355
		public const int MaterialInfoFieldNumber = 2;

		// Token: 0x04005B3C RID: 23356
		private MaterialInfo materialInfo_;

		// Token: 0x04005B3D RID: 23357
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x04005B3E RID: 23358
		private CombatCommon combatCommon_;
	}
}
