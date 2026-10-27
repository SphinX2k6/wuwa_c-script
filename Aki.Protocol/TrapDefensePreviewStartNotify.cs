using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001436 RID: 5174
	[NetMessage(EMessageId.TrapDefensePreviewStartNotify)]
	public sealed class TrapDefensePreviewStartNotify : IMessage<TrapDefensePreviewStartNotify>, IMessage, IEquatable<TrapDefensePreviewStartNotify>, IDeepCloneable<TrapDefensePreviewStartNotify>, IBufferMessage
	{
		// Token: 0x0601B686 RID: 112262 RVA: 0x003F7E1D File Offset: 0x003F601D
		[NullableContext(1)]
		public static TrapDefensePreviewStartNotify Create()
		{
			return new TrapDefensePreviewStartNotify();
		}

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x0601B687 RID: 112263 RVA: 0x003F7E24 File Offset: 0x003F6024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x0601B688 RID: 112264 RVA: 0x003F7E27 File Offset: 0x003F6027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewStartNotify.Descriptor;
			}
		}

		// Token: 0x0601B689 RID: 112265 RVA: 0x003F7E2E File Offset: 0x003F602E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify()
		{
		}

		// Token: 0x0601B68A RID: 112266 RVA: 0x003F7E44 File Offset: 0x003F6044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify(TrapDefensePreviewStartNotify other) : this()
		{
			this.isShopAppear_ = other.isShopAppear_;
			this.monsterEnhancedTipText_ = other.monsterEnhancedTipText_;
			this.monsterRoutesPreviewInfo_ = other.monsterRoutesPreviewInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B68B RID: 112267 RVA: 0x003F7E91 File Offset: 0x003F6091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify Clone()
		{
			return new TrapDefensePreviewStartNotify(this);
		}

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x0601B68C RID: 112268 RVA: 0x003F7E99 File Offset: 0x003F6099
		// (set) Token: 0x0601B68D RID: 112269 RVA: 0x003F7EA1 File Offset: 0x003F60A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShopAppear
		{
			get
			{
				return this.isShopAppear_;
			}
			set
			{
				this.isShopAppear_ = value;
			}
		}

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x0601B68E RID: 112270 RVA: 0x003F7EAA File Offset: 0x003F60AA
		// (set) Token: 0x0601B68F RID: 112271 RVA: 0x003F7EBB File Offset: 0x003F60BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ ?? TrapDefensePreviewStartNotify.MonsterEnhancedTipTextDefaultValue;
			}
			set
			{
				this.monsterEnhancedTipText_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x0601B690 RID: 112272 RVA: 0x003F7ECE File Offset: 0x003F60CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ != null;
			}
		}

		// Token: 0x0601B691 RID: 112273 RVA: 0x003F7ED9 File Offset: 0x003F60D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMonsterEnhancedTipText()
		{
			this.monsterEnhancedTipText_ = null;
		}

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x0601B692 RID: 112274 RVA: 0x003F7EE2 File Offset: 0x003F60E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, TrapDefenseMonsterPbGroup> MonsterRoutesPreviewInfo
		{
			get
			{
				return this.monsterRoutesPreviewInfo_;
			}
		}

		// Token: 0x0601B693 RID: 112275 RVA: 0x003F7EEA File Offset: 0x003F60EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewStartNotify);
		}

		// Token: 0x0601B694 RID: 112276 RVA: 0x003F7EF8 File Offset: 0x003F60F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewStartNotify other)
		{
			return other != null && (other == this || (this.IsShopAppear == other.IsShopAppear && !(this.MonsterEnhancedTipText != other.MonsterEnhancedTipText) && this.MonsterRoutesPreviewInfo.Equals(other.MonsterRoutesPreviewInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B695 RID: 112277 RVA: 0x003F7F5C File Offset: 0x003F615C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShopAppear)
			{
				num ^= this.IsShopAppear.GetHashCode();
			}
			if (this.HasMonsterEnhancedTipText)
			{
				num ^= this.MonsterEnhancedTipText.GetHashCode();
			}
			num ^= this.MonsterRoutesPreviewInfo.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B696 RID: 112278 RVA: 0x003F7FBF File Offset: 0x003F61BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B697 RID: 112279 RVA: 0x003F7FCC File Offset: 0x003F61CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B698 RID: 112280 RVA: 0x003F7FD8 File Offset: 0x003F61D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsterRoutesPreviewInfo_.WriteTo(ref output, TrapDefensePreviewStartNotify._map_monsterRoutesPreviewInfo_codec);
			if (this.IsShopAppear)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsShopAppear);
			}
			if (this.HasMonsterEnhancedTipText)
			{
				output.WriteRawTag(98);
				output.WriteString(this.MonsterEnhancedTipText);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B699 RID: 112281 RVA: 0x003F8044 File Offset: 0x003F6244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShopAppear)
			{
				num += 2;
			}
			if (this.HasMonsterEnhancedTipText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MonsterEnhancedTipText);
			}
			num += this.monsterRoutesPreviewInfo_.CalculateSize(TrapDefensePreviewStartNotify._map_monsterRoutesPreviewInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B69A RID: 112282 RVA: 0x003F80A4 File Offset: 0x003F62A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShopAppear)
			{
				this.IsShopAppear = other.IsShopAppear;
			}
			if (other.HasMonsterEnhancedTipText)
			{
				this.MonsterEnhancedTipText = other.MonsterEnhancedTipText;
			}
			this.monsterRoutesPreviewInfo_.MergeFrom(other.monsterRoutesPreviewInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B69B RID: 112283 RVA: 0x003F8105 File Offset: 0x003F6305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B69C RID: 112284 RVA: 0x003F8110 File Offset: 0x003F6310
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
				if (num != 10U)
				{
					if (num != 64U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MonsterEnhancedTipText = input.ReadString();
						}
					}
					else
					{
						this.IsShopAppear = input.ReadBool();
					}
				}
				else
				{
					this.monsterRoutesPreviewInfo_.AddEntriesFrom(ref input, TrapDefensePreviewStartNotify._map_monsterRoutesPreviewInfo_codec);
				}
			}
		}

		// Token: 0x04009E2D RID: 40493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E2E RID: 40494
		public const int IsShopAppearFieldNumber = 8;

		// Token: 0x04009E2F RID: 40495
		private bool isShopAppear_;

		// Token: 0x04009E30 RID: 40496
		public const int MonsterEnhancedTipTextFieldNumber = 12;

		// Token: 0x04009E31 RID: 40497
		private static readonly string MonsterEnhancedTipTextDefaultValue = "";

		// Token: 0x04009E32 RID: 40498
		private string monsterEnhancedTipText_;

		// Token: 0x04009E33 RID: 40499
		public const int MonsterRoutesPreviewInfoFieldNumber = 1;

		// Token: 0x04009E34 RID: 40500
		private static readonly MapField<int, TrapDefenseMonsterPbGroup>.Codec _map_monsterRoutesPreviewInfo_codec = new MapField<int, TrapDefenseMonsterPbGroup>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<TrapDefenseMonsterPbGroup>(18U, TrapDefenseMonsterPbGroup.Parser), 10U);

		// Token: 0x04009E35 RID: 40501
		private readonly MapField<int, TrapDefenseMonsterPbGroup> monsterRoutesPreviewInfo_ = new MapField<int, TrapDefenseMonsterPbGroup>();
	}
}
