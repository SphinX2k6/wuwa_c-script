using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A9 RID: 5289
	[NetMessage(EMessageId.TrapDefensePreviewStartNotify)]
	public sealed class TrapDefensePreviewStartNotify : IMessage<TrapDefensePreviewStartNotify>, IMessage, IEquatable<TrapDefensePreviewStartNotify>, IDeepCloneable<TrapDefensePreviewStartNotify>, IBufferMessage
	{
		// Token: 0x0601C111 RID: 114961 RVA: 0x004130F1 File Offset: 0x004112F1
		[NullableContext(1)]
		public static TrapDefensePreviewStartNotify Create()
		{
			return new TrapDefensePreviewStartNotify();
		}

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x0601C112 RID: 114962 RVA: 0x004130F8 File Offset: 0x004112F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x0601C113 RID: 114963 RVA: 0x004130FB File Offset: 0x004112FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewStartNotify.Descriptor;
			}
		}

		// Token: 0x0601C114 RID: 114964 RVA: 0x00413102 File Offset: 0x00411302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify()
		{
		}

		// Token: 0x0601C115 RID: 114965 RVA: 0x00413118 File Offset: 0x00411318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify(TrapDefensePreviewStartNotify other) : this()
		{
			this.isShopAppear_ = other.isShopAppear_;
			this.monsterEnhancedTipText_ = other.monsterEnhancedTipText_;
			this.monsterRoutesPreviewInfo_ = other.monsterRoutesPreviewInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C116 RID: 114966 RVA: 0x00413165 File Offset: 0x00411365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStartNotify Clone()
		{
			return new TrapDefensePreviewStartNotify(this);
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x0601C117 RID: 114967 RVA: 0x0041316D File Offset: 0x0041136D
		// (set) Token: 0x0601C118 RID: 114968 RVA: 0x00413175 File Offset: 0x00411375
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

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x0601C119 RID: 114969 RVA: 0x0041317E File Offset: 0x0041137E
		// (set) Token: 0x0601C11A RID: 114970 RVA: 0x0041318F File Offset: 0x0041138F
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

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x0601C11B RID: 114971 RVA: 0x004131A2 File Offset: 0x004113A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMonsterEnhancedTipText
		{
			get
			{
				return this.monsterEnhancedTipText_ != null;
			}
		}

		// Token: 0x0601C11C RID: 114972 RVA: 0x004131AD File Offset: 0x004113AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMonsterEnhancedTipText()
		{
			this.monsterEnhancedTipText_ = null;
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x0601C11D RID: 114973 RVA: 0x004131B6 File Offset: 0x004113B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, TrapDefenseMonsterPbGroup> MonsterRoutesPreviewInfo
		{
			get
			{
				return this.monsterRoutesPreviewInfo_;
			}
		}

		// Token: 0x0601C11E RID: 114974 RVA: 0x004131BE File Offset: 0x004113BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewStartNotify);
		}

		// Token: 0x0601C11F RID: 114975 RVA: 0x004131CC File Offset: 0x004113CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewStartNotify other)
		{
			return other != null && (other == this || (this.IsShopAppear == other.IsShopAppear && !(this.MonsterEnhancedTipText != other.MonsterEnhancedTipText) && this.MonsterRoutesPreviewInfo.Equals(other.MonsterRoutesPreviewInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C120 RID: 114976 RVA: 0x00413230 File Offset: 0x00411430
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

		// Token: 0x0601C121 RID: 114977 RVA: 0x00413293 File Offset: 0x00411493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x004132A0 File Offset: 0x004114A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C123 RID: 114979 RVA: 0x004132AC File Offset: 0x004114AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasMonsterEnhancedTipText)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MonsterEnhancedTipText);
			}
			this.monsterRoutesPreviewInfo_.WriteTo(ref output, TrapDefensePreviewStartNotify._map_monsterRoutesPreviewInfo_codec);
			if (this.IsShopAppear)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsShopAppear);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x00413318 File Offset: 0x00411518
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

		// Token: 0x0601C125 RID: 114981 RVA: 0x00413378 File Offset: 0x00411578
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

		// Token: 0x0601C126 RID: 114982 RVA: 0x004133D9 File Offset: 0x004115D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C127 RID: 114983 RVA: 0x004133E4 File Offset: 0x004115E4
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
					if (num != 58U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.MonsterEnhancedTipText = input.ReadString();
				}
			}
		}

		// Token: 0x0400A274 RID: 41588
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A275 RID: 41589
		public const int IsShopAppearFieldNumber = 10;

		// Token: 0x0400A276 RID: 41590
		private bool isShopAppear_;

		// Token: 0x0400A277 RID: 41591
		public const int MonsterEnhancedTipTextFieldNumber = 1;

		// Token: 0x0400A278 RID: 41592
		private static readonly string MonsterEnhancedTipTextDefaultValue = "";

		// Token: 0x0400A279 RID: 41593
		private string monsterEnhancedTipText_;

		// Token: 0x0400A27A RID: 41594
		public const int MonsterRoutesPreviewInfoFieldNumber = 7;

		// Token: 0x0400A27B RID: 41595
		private static readonly MapField<int, TrapDefenseMonsterPbGroup>.Codec _map_monsterRoutesPreviewInfo_codec = new MapField<int, TrapDefenseMonsterPbGroup>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<TrapDefenseMonsterPbGroup>(18U, TrapDefenseMonsterPbGroup.Parser), 58U);

		// Token: 0x0400A27C RID: 41596
		private readonly MapField<int, TrapDefenseMonsterPbGroup> monsterRoutesPreviewInfo_ = new MapField<int, TrapDefenseMonsterPbGroup>();
	}
}
