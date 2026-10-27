using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001446 RID: 5190
	public sealed class TrapDefenseShopBdGroupPbInfo : IMessage<TrapDefenseShopBdGroupPbInfo>, IMessage, IEquatable<TrapDefenseShopBdGroupPbInfo>, IDeepCloneable<TrapDefenseShopBdGroupPbInfo>, IBufferMessage
	{
		// Token: 0x0601B7CC RID: 112588 RVA: 0x003FAB91 File Offset: 0x003F8D91
		[NullableContext(1)]
		public static TrapDefenseShopBdGroupPbInfo Create()
		{
			return new TrapDefenseShopBdGroupPbInfo();
		}

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x0601B7CD RID: 112589 RVA: 0x003FAB98 File Offset: 0x003F8D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x0601B7CE RID: 112590 RVA: 0x003FAB9B File Offset: 0x003F8D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopBdGroupPbInfo.Descriptor;
			}
		}

		// Token: 0x0601B7CF RID: 112591 RVA: 0x003FABA2 File Offset: 0x003F8DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo()
		{
		}

		// Token: 0x0601B7D0 RID: 112592 RVA: 0x003FABAA File Offset: 0x003F8DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo(TrapDefenseShopBdGroupPbInfo other) : this()
		{
			this.bdGrougConfigId_ = other.bdGrougConfigId_;
			this.isSold_ = other.isSold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7D1 RID: 112593 RVA: 0x003FABDB File Offset: 0x003F8DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo Clone()
		{
			return new TrapDefenseShopBdGroupPbInfo(this);
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0601B7D2 RID: 112594 RVA: 0x003FABE3 File Offset: 0x003F8DE3
		// (set) Token: 0x0601B7D3 RID: 112595 RVA: 0x003FABEB File Offset: 0x003F8DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BdGrougConfigId
		{
			get
			{
				return this.bdGrougConfigId_;
			}
			set
			{
				this.bdGrougConfigId_ = value;
			}
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0601B7D4 RID: 112596 RVA: 0x003FABF4 File Offset: 0x003F8DF4
		// (set) Token: 0x0601B7D5 RID: 112597 RVA: 0x003FABFC File Offset: 0x003F8DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSold
		{
			get
			{
				return this.isSold_;
			}
			set
			{
				this.isSold_ = value;
			}
		}

		// Token: 0x0601B7D6 RID: 112598 RVA: 0x003FAC05 File Offset: 0x003F8E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopBdGroupPbInfo);
		}

		// Token: 0x0601B7D7 RID: 112599 RVA: 0x003FAC13 File Offset: 0x003F8E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopBdGroupPbInfo other)
		{
			return other != null && (other == this || (this.BdGrougConfigId == other.BdGrougConfigId && this.IsSold == other.IsSold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7D8 RID: 112600 RVA: 0x003FAC54 File Offset: 0x003F8E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BdGrougConfigId != 0)
			{
				num ^= this.BdGrougConfigId.GetHashCode();
			}
			if (this.IsSold)
			{
				num ^= this.IsSold.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7D9 RID: 112601 RVA: 0x003FACAC File Offset: 0x003F8EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7DA RID: 112602 RVA: 0x003FACB9 File Offset: 0x003F8EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7DB RID: 112603 RVA: 0x003FACC4 File Offset: 0x003F8EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BdGrougConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BdGrougConfigId);
			}
			if (this.IsSold)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSold);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7DC RID: 112604 RVA: 0x003FAD1C File Offset: 0x003F8F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BdGrougConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BdGrougConfigId);
			}
			if (this.IsSold)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7DD RID: 112605 RVA: 0x003FAD68 File Offset: 0x003F8F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseShopBdGroupPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BdGrougConfigId != 0)
			{
				this.BdGrougConfigId = other.BdGrougConfigId;
			}
			if (other.IsSold)
			{
				this.IsSold = other.IsSold;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7DE RID: 112606 RVA: 0x003FADB8 File Offset: 0x003F8FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7DF RID: 112607 RVA: 0x003FADC4 File Offset: 0x003F8FC4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsSold = input.ReadBool();
					}
				}
				else
				{
					this.BdGrougConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E90 RID: 40592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E91 RID: 40593
		public const int BdGrougConfigIdFieldNumber = 1;

		// Token: 0x04009E92 RID: 40594
		private int bdGrougConfigId_;

		// Token: 0x04009E93 RID: 40595
		public const int IsSoldFieldNumber = 2;

		// Token: 0x04009E94 RID: 40596
		private bool isSold_;
	}
}
