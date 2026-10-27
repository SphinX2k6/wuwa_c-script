using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000399 RID: 921
	public sealed class DarkTideBagItemPb : IMessage<DarkTideBagItemPb>, IMessage, IEquatable<DarkTideBagItemPb>, IDeepCloneable<DarkTideBagItemPb>, IBufferMessage
	{
		// Token: 0x06005AD5 RID: 23253 RVA: 0x000DCFEF File Offset: 0x000DB1EF
		[NullableContext(1)]
		public static DarkTideBagItemPb Create()
		{
			return new DarkTideBagItemPb();
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x000DCFF6 File Offset: 0x000DB1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DarkTideBagItemPb> Parser
		{
			get
			{
				return DarkTideBagItemPb._parser;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x000DCFFD File Offset: 0x000DB1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x000DD000 File Offset: 0x000DB200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagItemPb.Descriptor;
			}
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x000DD007 File Offset: 0x000DB207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemPb()
		{
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x000DD010 File Offset: 0x000DB210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemPb(DarkTideBagItemPb other) : this()
		{
			this.configId_ = other.configId_;
			DarkTideBagItemPb.DarkTideItemEntityContextOneofCase darkTideItemEntityContextCase = other.DarkTideItemEntityContextCase;
			if (darkTideItemEntityContextCase != DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
			{
				if (darkTideItemEntityContextCase == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
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

		// Token: 0x06005ADB RID: 23259 RVA: 0x000DD076 File Offset: 0x000DB276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemPb Clone()
		{
			return new DarkTideBagItemPb(this);
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x000DD07E File Offset: 0x000DB27E
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x000DD086 File Offset: 0x000DB286
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

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x000DD08F File Offset: 0x000DB28F
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x000DD0A7 File Offset: 0x000DB2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagWeaponCtx Weapon
		{
			get
			{
				if (this.darkTideItemEntityContextCase_ != DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
				{
					return null;
				}
				return (DarkTideBagWeaponCtx)this.darkTideItemEntityContext_;
			}
			set
			{
				this.darkTideItemEntityContext_ = value;
				this.darkTideItemEntityContextCase_ = ((value == null) ? DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.None : DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon);
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x000DD0BD File Offset: 0x000DB2BD
		// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x000DD0D6 File Offset: 0x000DB2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemCtx Item
		{
			get
			{
				if (this.darkTideItemEntityContextCase_ != DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
				{
					return null;
				}
				return (DarkTideBagItemCtx)this.darkTideItemEntityContext_;
			}
			set
			{
				this.darkTideItemEntityContext_ = value;
				this.darkTideItemEntityContextCase_ = ((value == null) ? DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.None : DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item);
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x000DD0ED File Offset: 0x000DB2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagItemPb.DarkTideItemEntityContextOneofCase DarkTideItemEntityContextCase
		{
			get
			{
				return this.darkTideItemEntityContextCase_;
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x000DD0F5 File Offset: 0x000DB2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDarkTideItemEntityContext()
		{
			this.darkTideItemEntityContextCase_ = DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.None;
			this.darkTideItemEntityContext_ = null;
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000DD105 File Offset: 0x000DB305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagItemPb);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x000DD114 File Offset: 0x000DB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagItemPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.Weapon, other.Weapon) && object.Equals(this.Item, other.Item) && this.DarkTideItemEntityContextCase == other.DarkTideItemEntityContextCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x000DD188 File Offset: 0x000DB388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
			{
				num ^= this.Weapon.GetHashCode();
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
			{
				num ^= this.Item.GetHashCode();
			}
			num ^= (int)this.darkTideItemEntityContextCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x000DD1FF File Offset: 0x000DB3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x000DD20C File Offset: 0x000DB40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x000DD218 File Offset: 0x000DB418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Weapon);
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Item);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x000DD290 File Offset: 0x000DB490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Weapon);
			}
			if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x000DD304 File Offset: 0x000DB504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			DarkTideBagItemPb.DarkTideItemEntityContextOneofCase darkTideItemEntityContextCase = other.DarkTideItemEntityContextCase;
			if (darkTideItemEntityContextCase != DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
			{
				if (darkTideItemEntityContextCase == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
				{
					if (this.Item == null)
					{
						this.Item = new DarkTideBagItemCtx();
					}
					this.Item.MergeFrom(other.Item);
				}
			}
			else
			{
				if (this.Weapon == null)
				{
					this.Weapon = new DarkTideBagWeaponCtx();
				}
				this.Weapon.MergeFrom(other.Weapon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x000DD39C File Offset: 0x000DB59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x000DD3A8 File Offset: 0x000DB5A8
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
							DarkTideBagItemCtx darkTideBagItemCtx = new DarkTideBagItemCtx();
							if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Item)
							{
								darkTideBagItemCtx.MergeFrom(this.Item);
							}
							input.ReadMessage(darkTideBagItemCtx);
							this.Item = darkTideBagItemCtx;
						}
					}
					else
					{
						DarkTideBagWeaponCtx darkTideBagWeaponCtx = new DarkTideBagWeaponCtx();
						if (this.darkTideItemEntityContextCase_ == DarkTideBagItemPb.DarkTideItemEntityContextOneofCase.Weapon)
						{
							darkTideBagWeaponCtx.MergeFrom(this.Weapon);
						}
						input.ReadMessage(darkTideBagWeaponCtx);
						this.Weapon = darkTideBagWeaponCtx;
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035D7 RID: 13783
		private static readonly MessageParser<DarkTideBagItemPb> _parser = new MessageParser<DarkTideBagItemPb>(() => new DarkTideBagItemPb());

		// Token: 0x040035D8 RID: 13784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D9 RID: 13785
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040035DA RID: 13786
		private int configId_;

		// Token: 0x040035DB RID: 13787
		public const int WeaponFieldNumber = 8;

		// Token: 0x040035DC RID: 13788
		public const int ItemFieldNumber = 9;

		// Token: 0x040035DD RID: 13789
		private object darkTideItemEntityContext_;

		// Token: 0x040035DE RID: 13790
		private DarkTideBagItemPb.DarkTideItemEntityContextOneofCase darkTideItemEntityContextCase_;

		// Token: 0x0200174B RID: 5963
		public enum DarkTideItemEntityContextOneofCase
		{
			// Token: 0x0400C5C4 RID: 50628
			None,
			// Token: 0x0400C5C5 RID: 50629
			Weapon = 8,
			// Token: 0x0400C5C6 RID: 50630
			Item
		}
	}
}
