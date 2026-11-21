using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156A RID: 5482
	[NetMessage(EMessageId.WeaponLevelUpResponse)]
	public sealed class WeaponLevelUpResponse : IMessage<WeaponLevelUpResponse>, IMessage, IEquatable<WeaponLevelUpResponse>, IDeepCloneable<WeaponLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601D084 RID: 118916 RVA: 0x00434888 File Offset: 0x00432A88
		[NullableContext(1)]
		public static WeaponLevelUpResponse Create()
		{
			return new WeaponLevelUpResponse();
		}

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x0601D085 RID: 118917 RVA: 0x0043488F File Offset: 0x00432A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x0601D086 RID: 118918 RVA: 0x00434892 File Offset: 0x00432A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601D087 RID: 118919 RVA: 0x00434899 File Offset: 0x00432A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpResponse()
		{
		}

		// Token: 0x0601D088 RID: 118920 RVA: 0x004348AC File Offset: 0x00432AAC
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

		// Token: 0x0601D089 RID: 118921 RVA: 0x00434911 File Offset: 0x00432B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponLevelUpResponse Clone()
		{
			return new WeaponLevelUpResponse(this);
		}

		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x0601D08A RID: 118922 RVA: 0x00434919 File Offset: 0x00432B19
		// (set) Token: 0x0601D08B RID: 118923 RVA: 0x00434921 File Offset: 0x00432B21
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

		// Token: 0x1700623F RID: 25151
		// (get) Token: 0x0601D08C RID: 118924 RVA: 0x0043492A File Offset: 0x00432B2A
		// (set) Token: 0x0601D08D RID: 118925 RVA: 0x00434932 File Offset: 0x00432B32
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

		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x0601D08E RID: 118926 RVA: 0x0043493B File Offset: 0x00432B3B
		// (set) Token: 0x0601D08F RID: 118927 RVA: 0x00434943 File Offset: 0x00432B43
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

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x0601D090 RID: 118928 RVA: 0x0043494C File Offset: 0x00432B4C
		// (set) Token: 0x0601D091 RID: 118929 RVA: 0x00434954 File Offset: 0x00432B54
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

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x0601D092 RID: 118930 RVA: 0x0043495D File Offset: 0x00432B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601D093 RID: 118931 RVA: 0x00434965 File Offset: 0x00432B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponLevelUpResponse);
		}

		// Token: 0x0601D094 RID: 118932 RVA: 0x00434974 File Offset: 0x00432B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D095 RID: 118933 RVA: 0x004349F4 File Offset: 0x00432BF4
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

		// Token: 0x0601D096 RID: 118934 RVA: 0x00434A92 File Offset: 0x00432C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D097 RID: 118935 RVA: 0x00434A9F File Offset: 0x00432C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D098 RID: 118936 RVA: 0x00434AA8 File Offset: 0x00432CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponExp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponExp);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeaponLevel);
			}
			this.itemMap_.WriteTo(ref output, WeaponLevelUpResponse._map_itemMap_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D099 RID: 118937 RVA: 0x00434B4C File Offset: 0x00432D4C
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

		// Token: 0x0601D09A RID: 118938 RVA: 0x00434BE8 File Offset: 0x00432DE8
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

		// Token: 0x0601D09B RID: 118939 RVA: 0x00434C71 File Offset: 0x00432E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D09C RID: 118940 RVA: 0x00434C7C File Offset: 0x00432E7C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.WeaponExp = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.WeaponLevel = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						this.itemMap_.AddEntriesFrom(ref input, WeaponLevelUpResponse._map_itemMap_codec);
						continue;
					}
					if (num == 112U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A6CC RID: 42700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6CD RID: 42701
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A6CE RID: 42702
		private ErrorCode errorCode_;

		// Token: 0x0400A6CF RID: 42703
		public const int IncIdFieldNumber = 14;

		// Token: 0x0400A6D0 RID: 42704
		private int incId_;

		// Token: 0x0400A6D1 RID: 42705
		public const int WeaponLevelFieldNumber = 9;

		// Token: 0x0400A6D2 RID: 42706
		private int weaponLevel_;

		// Token: 0x0400A6D3 RID: 42707
		public const int WeaponExpFieldNumber = 1;

		// Token: 0x0400A6D4 RID: 42708
		private int weaponExp_;

		// Token: 0x0400A6D5 RID: 42709
		public const int ItemMapFieldNumber = 13;

		// Token: 0x0400A6D6 RID: 42710
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x0400A6D7 RID: 42711
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
