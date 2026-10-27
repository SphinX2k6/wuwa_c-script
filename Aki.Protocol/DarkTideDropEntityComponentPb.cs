using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A1 RID: 929
	public sealed class DarkTideDropEntityComponentPb : IMessage<DarkTideDropEntityComponentPb>, IMessage, IEquatable<DarkTideDropEntityComponentPb>, IDeepCloneable<DarkTideDropEntityComponentPb>, IBufferMessage
	{
		// Token: 0x06005B7F RID: 23423 RVA: 0x000DE879 File Offset: 0x000DCA79
		[NullableContext(1)]
		public static DarkTideDropEntityComponentPb Create()
		{
			return new DarkTideDropEntityComponentPb();
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x000DE880 File Offset: 0x000DCA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x000DE883 File Offset: 0x000DCA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideDropEntityComponentPb.Descriptor;
			}
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x000DE88A File Offset: 0x000DCA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropEntityComponentPb()
		{
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x000DE894 File Offset: 0x000DCA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropEntityComponentPb(DarkTideDropEntityComponentPb other) : this()
		{
			this.configId_ = other.configId_;
			DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase darkTideDropEntityContextCase = other.DarkTideDropEntityContextCase;
			if (darkTideDropEntityContextCase != DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
			{
				if (darkTideDropEntityContextCase == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
				{
					this.Item = other.Item.Clone();
				}
			}
			else
			{
				this.Weapon = other.Weapon.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x000DE8FA File Offset: 0x000DCAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropEntityComponentPb Clone()
		{
			return new DarkTideDropEntityComponentPb(this);
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06005B85 RID: 23429 RVA: 0x000DE902 File Offset: 0x000DCB02
		// (set) Token: 0x06005B86 RID: 23430 RVA: 0x000DE90A File Offset: 0x000DCB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06005B87 RID: 23431 RVA: 0x000DE913 File Offset: 0x000DCB13
		// (set) Token: 0x06005B88 RID: 23432 RVA: 0x000DE92B File Offset: 0x000DCB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropWeaponEntityCtx Weapon
		{
			get
			{
				if (this.darkTideDropEntityContextCase_ != DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
				{
					return null;
				}
				return (DarkTideDropWeaponEntityCtx)this.darkTideDropEntityContext_;
			}
			set
			{
				this.darkTideDropEntityContext_ = value;
				this.darkTideDropEntityContextCase_ = ((value == null) ? DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.None : DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon);
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06005B89 RID: 23433 RVA: 0x000DE941 File Offset: 0x000DCB41
		// (set) Token: 0x06005B8A RID: 23434 RVA: 0x000DE95A File Offset: 0x000DCB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropItemEntityCtx Item
		{
			get
			{
				if (this.darkTideDropEntityContextCase_ != DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
				{
					return null;
				}
				return (DarkTideDropItemEntityCtx)this.darkTideDropEntityContext_;
			}
			set
			{
				this.darkTideDropEntityContext_ = value;
				this.darkTideDropEntityContextCase_ = ((value == null) ? DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.None : DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item);
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06005B8B RID: 23435 RVA: 0x000DE971 File Offset: 0x000DCB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase DarkTideDropEntityContextCase
		{
			get
			{
				return this.darkTideDropEntityContextCase_;
			}
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x000DE979 File Offset: 0x000DCB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDarkTideDropEntityContext()
		{
			this.darkTideDropEntityContextCase_ = DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.None;
			this.darkTideDropEntityContext_ = null;
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x000DE989 File Offset: 0x000DCB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideDropEntityComponentPb);
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x000DE998 File Offset: 0x000DCB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideDropEntityComponentPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.Weapon, other.Weapon) && object.Equals(this.Item, other.Item) && this.DarkTideDropEntityContextCase == other.DarkTideDropEntityContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x000DEA0C File Offset: 0x000DCC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
			{
				num ^= this.Weapon.GetHashCode();
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
			{
				num ^= this.Item.GetHashCode();
			}
			num ^= (int)this.darkTideDropEntityContextCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x000DEA83 File Offset: 0x000DCC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x000DEA90 File Offset: 0x000DCC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x000DEA9C File Offset: 0x000DCC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Weapon);
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Item);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x000DEB14 File Offset: 0x000DCD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Weapon);
			}
			if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x000DEB88 File Offset: 0x000DCD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideDropEntityComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase darkTideDropEntityContextCase = other.DarkTideDropEntityContextCase;
			if (darkTideDropEntityContextCase != DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
			{
				if (darkTideDropEntityContextCase == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
				{
					if (this.Item == null)
					{
						this.Item = new DarkTideDropItemEntityCtx();
					}
					this.Item.MergeFrom(other.Item);
				}
			}
			else
			{
				if (this.Weapon == null)
				{
					this.Weapon = new DarkTideDropWeaponEntityCtx();
				}
				this.Weapon.MergeFrom(other.Weapon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x000DEC20 File Offset: 0x000DCE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x000DEC2C File Offset: 0x000DCE2C
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
					if (num != 66U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							DarkTideDropItemEntityCtx darkTideDropItemEntityCtx = new DarkTideDropItemEntityCtx();
							if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Item)
							{
								darkTideDropItemEntityCtx.MergeFrom(this.Item);
							}
							input.ReadMessage(darkTideDropItemEntityCtx);
							this.Item = darkTideDropItemEntityCtx;
						}
					}
					else
					{
						DarkTideDropWeaponEntityCtx darkTideDropWeaponEntityCtx = new DarkTideDropWeaponEntityCtx();
						if (this.darkTideDropEntityContextCase_ == DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase.Weapon)
						{
							darkTideDropWeaponEntityCtx.MergeFrom(this.Weapon);
						}
						input.ReadMessage(darkTideDropWeaponEntityCtx);
						this.Weapon = darkTideDropWeaponEntityCtx;
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003608 RID: 13832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003609 RID: 13833
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400360A RID: 13834
		private int configId_;

		// Token: 0x0400360B RID: 13835
		public const int WeaponFieldNumber = 8;

		// Token: 0x0400360C RID: 13836
		public const int ItemFieldNumber = 9;

		// Token: 0x0400360D RID: 13837
		private object darkTideDropEntityContext_;

		// Token: 0x0400360E RID: 13838
		private DarkTideDropEntityComponentPb.DarkTideDropEntityContextOneofCase darkTideDropEntityContextCase_;

		// Token: 0x0200174D RID: 5965
		public enum DarkTideDropEntityContextOneofCase
		{
			// Token: 0x0400C5C9 RID: 50633
			None,
			// Token: 0x0400C5CA RID: 50634
			Weapon = 8,
			// Token: 0x0400C5CB RID: 50635
			Item
		}
	}
}
