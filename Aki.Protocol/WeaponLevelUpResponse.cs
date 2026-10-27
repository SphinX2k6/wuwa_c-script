using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F4 RID: 5364
	[NetMessage(EMessageId.WeaponLevelUpResponse)]
	public sealed class WeaponLevelUpResponse : IMessage<WeaponLevelUpResponse>, IMessage, IEquatable<WeaponLevelUpResponse>, IDeepCloneable<WeaponLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601C5BD RID: 116157 RVA: 0x00418DCB File Offset: 0x00416FCB
		[NullableContext(1)]
		public static WeaponLevelUpResponse Create()
		{
			return new WeaponLevelUpResponse();
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x0601C5BE RID: 116158 RVA: 0x00418DD2 File Offset: 0x00416FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x0601C5BF RID: 116159 RVA: 0x00418DD5 File Offset: 0x00416FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601C5C0 RID: 116160 RVA: 0x00418DDC File Offset: 0x00416FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpResponse()
		{
		}

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x00418DF0 File Offset: 0x00416FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpResponse(WeaponLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.incId_ = other.incId_;
			this.weaponLevel_ = other.weaponLevel_;
			this.weaponExp_ = other.weaponExp_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x00418E55 File Offset: 0x00417055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpResponse Clone()
		{
			return new WeaponLevelUpResponse(this);
		}

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x0601C5C3 RID: 116163 RVA: 0x00418E5D File Offset: 0x0041705D
		// (set) Token: 0x0601C5C4 RID: 116164 RVA: 0x00418E65 File Offset: 0x00417065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x0601C5C5 RID: 116165 RVA: 0x00418E6E File Offset: 0x0041706E
		// (set) Token: 0x0601C5C6 RID: 116166 RVA: 0x00418E76 File Offset: 0x00417076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x0601C5C7 RID: 116167 RVA: 0x00418E7F File Offset: 0x0041707F
		// (set) Token: 0x0601C5C8 RID: 116168 RVA: 0x00418E87 File Offset: 0x00417087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponLevel
		{
			get
			{
				return this.weaponLevel_;
			}
			set
			{
				this.weaponLevel_ = value;
			}
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x0601C5C9 RID: 116169 RVA: 0x00418E90 File Offset: 0x00417090
		// (set) Token: 0x0601C5CA RID: 116170 RVA: 0x00418E98 File Offset: 0x00417098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponExp
		{
			get
			{
				return this.weaponExp_;
			}
			set
			{
				this.weaponExp_ = value;
			}
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x0601C5CB RID: 116171 RVA: 0x00418EA1 File Offset: 0x004170A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601C5CC RID: 116172 RVA: 0x00418EA9 File Offset: 0x004170A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponLevelUpResponse);
		}

		// Token: 0x0601C5CD RID: 116173 RVA: 0x00418EB8 File Offset: 0x004170B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x00418F38 File Offset: 0x00417138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.WeaponLevel != 0)
			{
				num ^= this.WeaponLevel.GetHashCode();
			}
			if (this.WeaponExp != 0)
			{
				num ^= this.WeaponExp.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x00418FD6 File Offset: 0x004171D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5D0 RID: 116176 RVA: 0x00418FE3 File Offset: 0x004171E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5D1 RID: 116177 RVA: 0x00418FEC File Offset: 0x004171EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponLevel);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			this.itemMap_.WriteTo(ref output, WeaponLevelUpResponse._map_itemMap_codec);
			if (this.WeaponExp != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeaponExp);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5D2 RID: 116178 RVA: 0x00419090 File Offset: 0x00417290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.WeaponLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponLevel);
			}
			if (this.WeaponExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponExp);
			}
			num += this.itemMap_.CalculateSize(WeaponLevelUpResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5D3 RID: 116179 RVA: 0x0041912C File Offset: 0x0041732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.WeaponLevel != 0)
			{
				this.WeaponLevel = other.WeaponLevel;
			}
			if (other.WeaponExp != 0)
			{
				this.WeaponExp = other.WeaponExp;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5D4 RID: 116180 RVA: 0x004191B5 File Offset: 0x004173B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5D5 RID: 116181 RVA: 0x004191C0 File Offset: 0x004173C0
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.WeaponLevel = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.itemMap_.AddEntriesFrom(ref input, WeaponLevelUpResponse._map_itemMap_codec);
						continue;
					}
					if (num == 72U)
					{
						this.WeaponExp = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A273 RID: 41587
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A274 RID: 41588
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A275 RID: 41589
		private ErrorCode errorCode_;

		// Token: 0x0400A276 RID: 41590
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400A277 RID: 41591
		private int incId_;

		// Token: 0x0400A278 RID: 41592
		public const int WeaponLevelFieldNumber = 1;

		// Token: 0x0400A279 RID: 41593
		private int weaponLevel_;

		// Token: 0x0400A27A RID: 41594
		public const int WeaponExpFieldNumber = 9;

		// Token: 0x0400A27B RID: 41595
		private int weaponExp_;

		// Token: 0x0400A27C RID: 41596
		public const int ItemMapFieldNumber = 6;

		// Token: 0x0400A27D RID: 41597
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x0400A27E RID: 41598
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
