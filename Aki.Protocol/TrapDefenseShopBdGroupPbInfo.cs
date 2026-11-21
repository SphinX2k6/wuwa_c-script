using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B9 RID: 5305
	public sealed class TrapDefenseShopBdGroupPbInfo : IMessage<TrapDefenseShopBdGroupPbInfo>, IMessage, IEquatable<TrapDefenseShopBdGroupPbInfo>, IDeepCloneable<TrapDefenseShopBdGroupPbInfo>, IBufferMessage
	{
		// Token: 0x0601C257 RID: 115287 RVA: 0x00415E65 File Offset: 0x00414065
		[NullableContext(1)]
		public static TrapDefenseShopBdGroupPbInfo Create()
		{
			return new TrapDefenseShopBdGroupPbInfo();
		}

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x0601C258 RID: 115288 RVA: 0x00415E6C File Offset: 0x0041406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x0601C259 RID: 115289 RVA: 0x00415E6F File Offset: 0x0041406F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopBdGroupPbInfo.Descriptor;
			}
		}

		// Token: 0x0601C25A RID: 115290 RVA: 0x00415E76 File Offset: 0x00414076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo()
		{
		}

		// Token: 0x0601C25B RID: 115291 RVA: 0x00415E7E File Offset: 0x0041407E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo(TrapDefenseShopBdGroupPbInfo other) : this()
		{
			this.bdGrougConfigId_ = other.bdGrougConfigId_;
			this.isSold_ = other.isSold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C25C RID: 115292 RVA: 0x00415EAF File Offset: 0x004140AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo Clone()
		{
			return new TrapDefenseShopBdGroupPbInfo(this);
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x0601C25D RID: 115293 RVA: 0x00415EB7 File Offset: 0x004140B7
		// (set) Token: 0x0601C25E RID: 115294 RVA: 0x00415EBF File Offset: 0x004140BF
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

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x0601C25F RID: 115295 RVA: 0x00415EC8 File Offset: 0x004140C8
		// (set) Token: 0x0601C260 RID: 115296 RVA: 0x00415ED0 File Offset: 0x004140D0
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

		// Token: 0x0601C261 RID: 115297 RVA: 0x00415ED9 File Offset: 0x004140D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopBdGroupPbInfo);
		}

		// Token: 0x0601C262 RID: 115298 RVA: 0x00415EE7 File Offset: 0x004140E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopBdGroupPbInfo other)
		{
			return other != null && (other == this || (this.BdGrougConfigId == other.BdGrougConfigId && this.IsSold == other.IsSold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C263 RID: 115299 RVA: 0x00415F28 File Offset: 0x00414128
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

		// Token: 0x0601C264 RID: 115300 RVA: 0x00415F80 File Offset: 0x00414180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C265 RID: 115301 RVA: 0x00415F8D File Offset: 0x0041418D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C266 RID: 115302 RVA: 0x00415F98 File Offset: 0x00414198
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

		// Token: 0x0601C267 RID: 115303 RVA: 0x00415FF0 File Offset: 0x004141F0
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

		// Token: 0x0601C268 RID: 115304 RVA: 0x0041603C File Offset: 0x0041423C
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

		// Token: 0x0601C269 RID: 115305 RVA: 0x0041608C File Offset: 0x0041428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C26A RID: 115306 RVA: 0x00416098 File Offset: 0x00414298
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

		// Token: 0x0400A2D7 RID: 41687
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2D8 RID: 41688
		public const int BdGrougConfigIdFieldNumber = 1;

		// Token: 0x0400A2D9 RID: 41689
		private int bdGrougConfigId_;

		// Token: 0x0400A2DA RID: 41690
		public const int IsSoldFieldNumber = 2;

		// Token: 0x0400A2DB RID: 41691
		private bool isSold_;
	}
}
